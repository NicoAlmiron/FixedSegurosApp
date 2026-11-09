using FixedSegurosApp.Datos;
using FixedSegurosApp.Entidades;
using FixedSegurosApp.Utilidades;
using System.Collections.Generic;

namespace FixedSegurosApp.Negocio
{
    // Reglas del registro de cuentas y del "Detalle del cliente".
    // Negocio valida lo que llega de la pantalla, aplica las reglas, llama a Datos y registra la acción en el historial. No escribe SQL.
    internal class ClienteNegocio
    {
        // Valido los datos del formulario "Crear cuenta" y registro la cuenta.
        // Si todavía no hay ningún usuario en la base, esta cuenta es la del administrador (con matrícula);
        // si ya hay usuarios, siempre es un cliente. Lo decido acá y no en la pantalla, así no se puede saltear.
        // Devuelvo true si se guardó; si no, en "mensaje" queda el motivo.
        public static bool RegistrarCuenta(Cliente cliente, string dniTexto, string contrasena, string repetirContrasena, string matricula, out string mensaje)
        {
            bool esPrimerUsuario = !UsuarioNegocio.HayUsuarios();

            cliente.Perfil = esPrimerUsuario ? "Administrador" : "Cliente";
            cliente.Matricula = esPrimerUsuario ? matricula : null;

            // mismas reglas que la pantalla Usuarios (nombre, DNI, edad, teléfono, email, DNI repetido y matrícula del administrador)
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

            // guardo la contraseña como hash con una sal nueva
            string sal = UsuarioNegocio.GenerarSal();
            cliente.Legajo = UsuarioDatos.CrearUsuario(cliente, UsuarioNegocio.HashConSal(contrasena, sal), sal);

            if (cliente.Legajo == 0)
            {
                mensaje = "No se pudo registrar la cuenta. Intente más tarde.";
                return false;
            }

            string accion = esPrimerUsuario ? "Creó la cuenta del primer administrador" : "Se registró como cliente";
            AccionDatos.RegistrarAccion(cliente.Legajo, "Usuarios", accion, "DNI " + cliente.Dni);

            return true;
        }

        // Busco el cliente con ese DNI; null si no hay ninguno
        public static Persona BuscarPorDni(int dni)
        {
            return UsuarioDatos.BuscarClientePorDni(dni);
        }

        // ================= Detalle del cliente (lo usan el empleado y el administrador) =================

        // Las observaciones guardadas del cliente
        public static string BuscarObservaciones(int legajo)
        {
            return ClienteDatos.BuscarObservaciones(legajo);
        }

        // Guardo las observaciones (hasta 200 caracteres) y lo registro en el historial
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

        // Pestaña Pólizas del detalle
        public static List<Poliza> ListarPolizas(int legajo)
        {
            return PolizaDatos.ListarPolizasDeCliente(legajo);
        }

        // Pestaña Pagos del detalle
        public static List<Pago> ListarPagos(int legajo)
        {
            return ClienteDatos.ListarPagos(legajo);
        }

        // Pestaña Siniestros del detalle
        public static List<Siniestro> ListarSiniestros(int legajo)
        {
            return ClienteDatos.ListarSiniestros(legajo);
        }

        // Pestaña Historial del detalle
        public static List<Accion> ListarHistorial(int legajo)
        {
            return AccionDatos.ListarAccionesDeUsuario(legajo);
        }
    }
}
