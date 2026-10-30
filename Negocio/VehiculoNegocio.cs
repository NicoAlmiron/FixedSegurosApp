using FixedSegurosApp.Datos;
using FixedSegurosApp.Entidades;
using FixedSegurosApp.Utilidades;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace FixedSegurosApp.Negocio
{
    internal class VehiculoNegocio
    {
        // Las fotos obligatorias registran el estado del vehículo al comenzar la póliza.
        // Esta es la lista completa (7): cada casillero de la pantalla es una de estas posiciones.
        public static readonly string[] Posiciones =
        {
            "Frente", "Atrás", "Lateral izquierdo", "Lateral derecho",
            "Interior del baúl", "Interior delantero", "Motor (bajo el capot)"
        };

        // Una motocicleta no tiene baúl ni interior: lleva 5 fotos
        private static readonly string[] PosicionesMoto =
        {
            "Frente", "Atrás", "Lateral izquierdo", "Lateral derecho", "Motor (bajo el capot)"
        };

        public static string[] PosicionesDe(string tipoVehiculo)
        {
            return tipoVehiculo == "Motocicleta" ? PosicionesMoto : Posiciones;
        }

        // ================= Cliente: "Mis vehículos" =================

        public static List<Vehiculo> ListarMisVehiculos()
        {
            return VehiculoDatos.ListarVehiculos(Sesion.UsuarioActual.Legajo);
        }

        public static Vehiculo BuscarMiVehiculo(int idVehiculo)
        {
            return VehiculoDatos.BuscarPorId(idVehiculo, Sesion.UsuarioActual.Legajo);
        }

        // Controla que la foto elegida sirva (legible y liviana) y la devuelve lista para guardar
        public static byte[] PrepararFoto(string ruta, out string mensaje)
        {
            return Imagenes.PrepararFoto(ruta, out mensaje);
        }

        // Si vehiculo.IdVehiculo es 0 lo crea; si no, guarda los cambios. En ambos casos queda Pendiente de revisión.
        public static bool GuardarVehiculo(Vehiculo vehiculo, string anioTexto, List<FotoVehiculo> fotos, out string mensaje)
        {
            mensaje = "";
            int anio;
            int legajo = Sesion.UsuarioActual.Legajo;

            if (vehiculo.TipoVehiculo == "" || vehiculo.Dominio == "" || vehiculo.Marca == "" || vehiculo.Modelo == "" || anioTexto == "")
            {
                mensaje = "Complete tipo de vehículo, dominio, marca, modelo y año.";
                return false;
            }

            // Chasis y motor son obligatorios: el empleado los compara con las fotos antes de aprobar
            if (vehiculo.NumeroChasis == "" || vehiculo.NumeroMotor == "")
            {
                mensaje = "Complete el número de chasis y el número de motor.";
                return false;
            }

            // Dominio: se guarda en mayúsculas y sin espacios ni guiones
            vehiculo.Dominio = vehiculo.Dominio.ToUpper().Replace(" ", "").Replace("-", "");
            if (!DominioValido(vehiculo.Dominio))
            {
                mensaje = "El dominio no es válido. Ejemplos: AB123CD, ABC123 (autos) o A123BCD, 123ABC (motos).";
                return false;
            }

            if (!int.TryParse(anioTexto, out anio) || anio < 1950 || anio > DateTime.Today.Year + 1)
            {
                mensaje = "El año debe estar entre 1950 y " + (DateTime.Today.Year + 1) + ".";
                return false;
            }
            vehiculo.Anio = anio;

            // Fotos obligatorias según el tipo de vehículo
            string[] posiciones = PosicionesDe(vehiculo.TipoVehiculo);
            foreach (string posicion in posiciones)
            {
                if (!TieneFoto(fotos, posicion))
                {
                    mensaje = "Falta la foto: " + posicion + ". Las " + posiciones.Length + " fotos son obligatorias.";
                    return false;
                }
            }

            fotos = QuitarFotosDeMas(fotos, posiciones);

            if (VehiculoDatos.ExisteDominio(vehiculo.Dominio, vehiculo.IdVehiculo))
            {
                mensaje = "Ya hay un vehículo registrado con el dominio " + vehiculo.Dominio + ".";
                return false;
            }

            if (vehiculo.IdVehiculo == 0)
            {
                vehiculo.IdVehiculo = VehiculoDatos.CrearVehiculo(vehiculo, fotos, legajo);

                if (vehiculo.IdVehiculo == 0)
                {
                    mensaje = "No se pudo guardar el vehículo.";
                    return false;
                }

                Registrar("Agregó vehículo", vehiculo.Dominio);
            }
            else
            {
                Vehiculo actual = VehiculoDatos.BuscarPorId(vehiculo.IdVehiculo, legajo);

                if (actual == null)
                {
                    mensaje = "No se encontró el vehículo.";
                    return false;
                }

                if (actual.EstadoRevision == "Aprobado")
                {
                    mensaje = "El vehículo ya fue aprobado y no se puede modificar.";
                    return false;
                }

                if (!VehiculoDatos.EditarVehiculo(vehiculo, fotos, legajo))
                {
                    mensaje = "No se pudieron guardar los cambios.";
                    return false;
                }

                Registrar("Modificó vehículo", vehiculo.Dominio);
            }

            return true;
        }

        // Solo se puede eliminar si nunca estuvo en una póliza
        public static bool EliminarVehiculo(Vehiculo vehiculo, out string mensaje)
        {
            mensaje = "";

            if (VehiculoDatos.TienePolizas(vehiculo.IdVehiculo))
            {
                mensaje = "No se puede eliminar el vehículo porque tiene pólizas asociadas.";
                return false;
            }

            if (!VehiculoDatos.EliminarVehiculo(vehiculo.IdVehiculo, Sesion.UsuarioActual.Legajo))
            {
                mensaje = "No se pudo eliminar el vehículo.";
                return false;
            }

            Registrar("Eliminó vehículo", vehiculo.Dominio);
            return true;
        }

        // ================= Empleado / Administrador: Detalle del cliente =================

        public static List<Vehiculo> ListarVehiculosDeCliente(int legajoCliente)
        {
            return VehiculoDatos.ListarVehiculos(legajoCliente);
        }

        public static Vehiculo BuscarVehiculoDeCliente(int idVehiculo, int legajoCliente)
        {
            return VehiculoDatos.BuscarPorId(idVehiculo, legajoCliente);
        }

        public static bool Aprobar(int idVehiculo, int legajoCliente, out string mensaje)
        {
            Vehiculo vehiculo;
            if (!PuedeRevisar(idVehiculo, legajoCliente, out vehiculo, out mensaje))
            {
                return false;
            }

            if (!VehiculoDatos.CambiarRevision(idVehiculo, "Aprobado", "", Sesion.UsuarioActual.Legajo))
            {
                mensaje = "No se pudo aprobar el vehículo.";
                return false;
            }

            Registrar("Aprobó vehículo", vehiculo.Dominio);
            return true;
        }

        public static bool Rechazar(int idVehiculo, int legajoCliente, string motivo, out string mensaje)
        {
            Vehiculo vehiculo;
            if (!PuedeRevisar(idVehiculo, legajoCliente, out vehiculo, out mensaje))
            {
                return false;
            }

            if (motivo.Trim() == "")
            {
                mensaje = "No se rechazó: debe indicar el motivo para que el cliente sepa qué corregir.";
                return false;
            }

            if (!VehiculoDatos.CambiarRevision(idVehiculo, "Rechazado", motivo.Trim(), Sesion.UsuarioActual.Legajo))
            {
                mensaje = "No se pudo rechazar el vehículo.";
                return false;
            }

            Registrar("Rechazó vehículo", vehiculo.Dominio);
            return true;
        }

        // ================= Comunes =================

        // Las fotos de un vehículo; el legajo asegura que el vehículo sea de ese cliente
        public static List<FotoVehiculo> ListarFotos(int idVehiculo, int legajoCliente)
        {
            if (VehiculoDatos.BuscarPorId(idVehiculo, legajoCliente) == null)
            {
                return new List<FotoVehiculo>();
            }
            return VehiculoDatos.ListarFotos(idVehiculo);
        }

        // Solo empleados y administradores revisan, y solo vehículos Pendientes
        private static bool PuedeRevisar(int idVehiculo, int legajoCliente, out Vehiculo vehiculo, out string mensaje)
        {
            mensaje = "";
            vehiculo = null;

            if (Sesion.UsuarioActual.Perfil == "Cliente")
            {
                mensaje = "Solo un empleado o administrador puede revisar vehículos.";
                return false;
            }

            vehiculo = VehiculoDatos.BuscarPorId(idVehiculo, legajoCliente);

            if (vehiculo == null)
            {
                mensaje = "No se encontró el vehículo.";
                return false;
            }

            if (vehiculo.EstadoRevision != "Pendiente")
            {
                mensaje = "El vehículo ya fue revisado (" + vehiculo.EstadoRevision + ").";
                return false;
            }

            return true;
        }

        // Si el cliente cambió el tipo de vehículo, pueden quedar fotos que ese tipo no lleva
        private static List<FotoVehiculo> QuitarFotosDeMas(List<FotoVehiculo> fotos, string[] posiciones)
        {
            List<FotoVehiculo> lista = new List<FotoVehiculo>();

            foreach (FotoVehiculo foto in fotos)
            {
                if (Array.IndexOf(posiciones, foto.Posicion) >= 0)
                {
                    lista.Add(foto);
                }
            }
            return lista;
        }

        private static bool TieneFoto(List<FotoVehiculo> fotos, string posicion)
        {
            foreach (FotoVehiculo foto in fotos)
            {
                if (foto.Posicion == posicion && foto.Imagen != null && foto.Imagen.Length > 0)
                {
                    return true;
                }
            }
            return false;
        }

        // Formatos de patente argentina: AB123CD (Mercosur), ABC123 (viejo), A123BCD (moto Mercosur), 123ABC (moto vieja)
        private static bool DominioValido(string dominio)
        {
            return Regex.IsMatch(dominio, "^([A-Z]{2}[0-9]{3}[A-Z]{2}|[A-Z]{3}[0-9]{3}|[A-Z][0-9]{3}[A-Z]{3}|[0-9]{3}[A-Z]{3})$");
        }

        private static void Registrar(string accion, string dominio)
        {
            AccionDatos.RegistrarAccion(Sesion.UsuarioActual.Legajo, "Vehículos", accion, "Dominio " + dominio);
        }
    }
}
