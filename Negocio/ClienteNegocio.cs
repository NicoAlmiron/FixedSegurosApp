using FixedSegurosApp.Datos;
using FixedSegurosApp.Entidades;

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
    }
}
