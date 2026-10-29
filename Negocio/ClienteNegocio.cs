using FixedSegurosApp.Datos;
using FixedSegurosApp.Entidades;
using FixedSegurosApp.Utilidades;
using System.Collections.Generic;

namespace FixedSegurosApp.Negocio
{
    internal class ClienteNegocio
    {
        // Valida los datos del formulario "Crear cuenta" y registra al cliente.
        // Devuelve true si se guardo; si no, en "mensaje" queda el motivo.
        public static bool RegistrarCliente(Cliente cliente, string dniTexto, string contrasena, string repetirContrasena, out string mensaje)
        {
            // mismas reglas que la pantalla Usuarios (nombre, DNI, edad, teléfono, email, DNI repetido)
            if (!UsuarioNegocio.ValidarDatos(cliente, dniTexto, out mensaje))
            {
                return false;
            }

            if (contrasena.Length < 6)
            {
                mensaje = "La contraseña debe tener al menos 6 caracteres.";
                return false;
            }

            if (contrasena != repetirContrasena)
            {
                mensaje = "Las contraseñas no coinciden.";
                return false;
            }

            cliente.Perfil = "Cliente";
            cliente.Legajo = UsuarioDatos.CrearUsuario(cliente, UsuarioNegocio.HashMD5(contrasena));

            if (cliente.Legajo == 0)
            {
                mensaje = "No se pudo registrar la cuenta. Intente más tarde.";
                return false;
            }

            AccionDatos.RegistrarAccion(cliente.Legajo, "Usuarios", "Se registró como cliente", "DNI " + cliente.Dni);

            return true;
        }

        // ================= Detalle del cliente (empleado / administrador) =================

        public static string BuscarObservaciones(int legajo)
        {
            return ClienteDatos.BuscarObservaciones(legajo);
        }

        public static bool GuardarObservaciones(int legajo, string observaciones, out string mensaje)
        {
            mensaje = "";

            if (observaciones.Length > 200)
            {
                mensaje = "Las observaciones pueden tener hasta 200 caracteres.";
                return false;
            }

            if (!ClienteDatos.GuardarObservaciones(legajo, observaciones.Trim()))
            {
                mensaje = "No se pudieron guardar las observaciones.";
                return false;
            }

            AccionDatos.RegistrarAccion(Sesion.UsuarioActual.Legajo, "Usuarios", "Modificó observaciones", "Legajo " + legajo.ToString("0000"));
            return true;
        }

        public static List<Poliza> ListarPolizas(int legajo)
        {
            return ClienteDatos.ListarPolizas(legajo);
        }

        public static List<Pago> ListarPagos(int legajo)
        {
            return ClienteDatos.ListarPagos(legajo);
        }

        public static List<Siniestro> ListarSiniestros(int legajo)
        {
            return ClienteDatos.ListarSiniestros(legajo);
        }

        public static List<Accion> ListarHistorial(int legajo)
        {
            return AccionDatos.ListarAccionesDeUsuario(legajo);
        }
    }
}
