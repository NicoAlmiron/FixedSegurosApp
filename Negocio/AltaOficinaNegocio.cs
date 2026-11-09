using FixedSegurosApp.Datos;
using FixedSegurosApp.Entidades;
using FixedSegurosApp.Utilidades;
using System;
using System.Collections.Generic;

namespace FixedSegurosApp.Negocio
{
    // Trámite en la oficina (solo el empleado): en un solo paso cargo al cliente, su vehículo y su póliza.
    // Negocio valida lo que llega de la pantalla, aplica las reglas, llama a Datos y registra la acción en el historial. No escribe SQL.
    internal class AltaOficinaNegocio
    {
        // Valido todo y guardo el trámite. cliente.Legajo = 0 es un cliente nuevo; vehiculo.IdVehiculo = 0 es un vehículo nuevo.
        // Un cliente nuevo entra con su DNI como usuario y contraseña.
        // El vehículo nuevo queda aprobado de entrada: el empleado lo está viendo en persona
        public static bool Confirmar(Persona cliente, string dniTexto, Vehiculo vehiculo, string anioTexto, List<FotoVehiculo> fotos, int nroOfrecida, out int nroPoliza, out string mensaje)
        {
            mensaje = "";
            nroPoliza = 0;

            if (Sesion.UsuarioActual.Perfil != "Empleado")
            {
                mensaje = "Solo un empleado puede hacer el alta en oficina.";
                return false;
            }

            if (!ValidarCliente(cliente, dniTexto, out mensaje))
            {
                return false;
            }

            if (vehiculo.IdVehiculo == 0)
            {
                if (!VehiculoNegocio.ValidarVehiculo(vehiculo, anioTexto, fotos, out mensaje))
                {
                    return false;
                }
                fotos = VehiculoNegocio.QuitarFotosDeMas(fotos, VehiculoNegocio.PosicionesDe(vehiculo.TipoVehiculo));
                vehiculo.EstadoRevision = "Aprobado";
            }
            else
            {
                // con el legajo me aseguro de que el vehículo sea de ese cliente
                vehiculo = VehiculoDatos.BuscarPorId(vehiculo.IdVehiculo, cliente.Legajo);
            }

            if (nroOfrecida == 0)
            {
                mensaje = "Elija una de las pólizas disponibles.";
                return false;
            }

            Poliza ofrecida = PolizaDatos.BuscarPorNro(nroOfrecida);
            if (!PolizaNegocio.VerificarRequisitos(ofrecida, vehiculo, out mensaje))
            {
                return false;
            }

            DateTime inicio = PolizaNegocio.CalcularInicio(ofrecida);
            List<Pago> cuotas = PolizaNegocio.CalcularCuotas(ofrecida, inicio);

            // el cliente nuevo entra con su DNI como contraseña, guardada como hash con su sal
            string sal = UsuarioNegocio.GenerarSal();
            nroPoliza = AltaOficinaDatos.Guardar(cliente, UsuarioNegocio.HashConSal(cliente.Dni.ToString(), sal), sal, vehiculo, fotos, nroOfrecida, inicio, inicio.AddMonths(ofrecida.Duracion), cuotas, Sesion.UsuarioActual.Legajo);
            if (nroPoliza == 0)
            {
                mensaje = "No se pudo completar el alta. No se guardó ningún dato.";
                return false;
            }

            AccionDatos.RegistrarAccion(Sesion.UsuarioActual.Legajo, "Pólizas", "Alta en oficina",
                "DNI " + cliente.Dni + " · " + vehiculo.Dominio + " · Póliza " + nroPoliza.ToString("000000"));
            return true;
        }

        // Controlo los datos del cliente: si es nuevo uso las mismas reglas que Usuarios; si ya existe, que esté activo
        private static bool ValidarCliente(Persona cliente, string dniTexto, out string mensaje)
        {
            mensaje = "";

            if (cliente.Legajo == 0)
            {
                cliente.Perfil = "Cliente";
                return UsuarioNegocio.ValidarDatos(cliente, dniTexto, out mensaje);
            }

            Persona registrado = UsuarioDatos.BuscarPorLegajo(cliente.Legajo);

            if (registrado == null || registrado.Perfil != "Cliente")
            {
                mensaje = "No se encontró al cliente.";
                return false;
            }

            if (registrado.Estado != "Activo")
            {
                mensaje = "El cliente está " + (registrado.Estado == "Baja" ? "dado de baja" : "suspendido") + ": no se le puede contratar una póliza.";
                return false;
            }

            cliente.Dni = registrado.Dni;
            return true;
        }
    }
}
