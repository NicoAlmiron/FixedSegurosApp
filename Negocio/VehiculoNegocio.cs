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
        // Esta es la lista completa (9): cada casillero de la pantalla es una de estas posiciones.
        public static readonly string[] Posiciones =
        {
            "Frente", "Atrás", "Lateral izquierdo", "Lateral derecho",
            "Interior del baúl", "Interior delantero", "Motor (bajo el capot)",
            "Tarjeta verde", "VTV"
        };

        // Una motocicleta no tiene baúl ni interior: lleva 7 fotos
        private static readonly string[] PosicionesMoto =
        {
            "Frente", "Atrás", "Lateral izquierdo", "Lateral derecho", "Motor (bajo el capot)",
            "Tarjeta verde", "VTV"
        };

        public const string FotoVtvNueva = VehiculoDatos.FotoVtvNueva;

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
            int legajo = Sesion.UsuarioActual.Legajo;

            if (!ValidarVehiculo(vehiculo, anioTexto, fotos, out mensaje))
            {
                return false;
            }

            fotos = QuitarFotosDeMas(fotos, PosicionesDe(vehiculo.TipoVehiculo));

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

        // Valida los datos y las fotos de un vehículo. Si está todo bien deja el dominio normalizado y el año cargado.
        public static bool ValidarVehiculo(Vehiculo vehiculo, string anioTexto, List<FotoVehiculo> fotos, out string mensaje)
        {
            mensaje = "";
            int anio;

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

            if (VehiculoDatos.ExisteDominio(vehiculo.Dominio, vehiculo.IdVehiculo))
            {
                mensaje = "Ya hay un vehículo registrado con el dominio " + vehiculo.Dominio + ".";
                return false;
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

        // El cliente envía la VTV renovada. Queda en revisión: si se envió antes de vencer el servicio no se suspende.
        public static bool ActualizarVtv(int idVehiculo, DateTime vigencia, byte[] foto, out string mensaje)
        {
            mensaje = "";
            int legajo = Sesion.UsuarioActual.Legajo;

            Vehiculo vehiculo = VehiculoDatos.BuscarPorId(idVehiculo, legajo);

            if (vehiculo == null)
            {
                mensaje = "No se encontró el vehículo.";
                return false;
            }

            if (vehiculo.EstadoRevision != "Aprobado")
            {
                mensaje = "Mientras el vehículo no esté aprobado, la VTV se corrige desde sus datos.";
                return false;
            }

            if (vehiculo.VtvEnRevision)
            {
                mensaje = "La VTV ya fue enviada y espera la revisión de un empleado.";
                return false;
            }

            if (foto == null)
            {
                mensaje = "Adjunte la foto de la VTV renovada.";
                return false;
            }

            if (vigencia.Date < DateTime.Today || vigencia.Date <= vehiculo.VigenciaVtv)
            {
                mensaje = "La nueva vigencia debe ser posterior a la actual y no puede estar vencida.";
                return false;
            }

            if (!VehiculoDatos.EnviarVtv(idVehiculo, vigencia.Date, foto, legajo))
            {
                mensaje = "No se pudo enviar la VTV.";
                return false;
            }

            Registrar("Actualizó VTV", vehiculo.Dominio);
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

        // El empleado corroboró la VTV renovada: se actualiza la vigencia y, si estaba suspendida, se reactiva la póliza
        public static bool AprobarVtv(int idVehiculo, int legajoCliente, out string mensaje)
        {
            Vehiculo vehiculo;
            if (!PuedeRevisarVtv(idVehiculo, legajoCliente, out vehiculo, out mensaje))
            {
                return false;
            }

            if (!VehiculoDatos.AprobarVtv(idVehiculo, Sesion.UsuarioActual.Legajo))
            {
                mensaje = "No se pudo aprobar la VTV.";
                return false;
            }

            string aviso = "La VTV del vehículo " + vehiculo.Dominio + " fue aprobada, vigente hasta el " + vehiculo.VigenciaVtvNueva.Value.ToString("dd/MM/yyyy") + ".";
            if (vehiculo.ServicioSuspendido && vehiculo.NroPoliza != 0)
            {
                aviso += " La póliza " + vehiculo.PolizaTexto + " se reactivó.";
            }

            NotificacionDatos.CrearNotificacionVtv(idVehiculo, vehiculo.NroPoliza, aviso);
            Registrar("Aprobó VTV", vehiculo.Dominio);
            return true;
        }

        public static bool RechazarVtv(int idVehiculo, int legajoCliente, string motivo, out string mensaje)
        {
            Vehiculo vehiculo;
            if (!PuedeRevisarVtv(idVehiculo, legajoCliente, out vehiculo, out mensaje))
            {
                return false;
            }

            if (motivo.Trim() == "")
            {
                mensaje = "No se rechazó: debe indicar el motivo para que el cliente sepa qué corregir.";
                return false;
            }

            if (!VehiculoDatos.RechazarVtv(idVehiculo, motivo.Trim(), Sesion.UsuarioActual.Legajo))
            {
                mensaje = "No se pudo rechazar la VTV.";
                return false;
            }

            NotificacionDatos.CrearNotificacionVtv(idVehiculo, vehiculo.NroPoliza, "La VTV del vehículo " + vehiculo.Dominio + " fue rechazada. Motivo: " + motivo.Trim());
            Registrar("Rechazó VTV", vehiculo.Dominio);
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

        private static bool PuedeRevisarVtv(int idVehiculo, int legajoCliente, out Vehiculo vehiculo, out string mensaje)
        {
            mensaje = "";
            vehiculo = null;

            if (Sesion.UsuarioActual.Perfil == "Cliente")
            {
                mensaje = "Solo un empleado o administrador puede revisar la VTV.";
                return false;
            }

            vehiculo = VehiculoDatos.BuscarPorId(idVehiculo, legajoCliente);

            if (vehiculo == null || !vehiculo.VtvEnRevision)
            {
                mensaje = "No hay una VTV para revisar.";
                return false;
            }

            return true;
        }

        // Si el cliente cambió el tipo de vehículo, pueden quedar fotos que ese tipo no lleva
        public static List<FotoVehiculo> QuitarFotosDeMas(List<FotoVehiculo> fotos, string[] posiciones)
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
