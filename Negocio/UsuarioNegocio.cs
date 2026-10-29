using FixedSegurosApp.Datos;
using FixedSegurosApp.Entidades;
using FixedSegurosApp.Utilidades;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace FixedSegurosApp.Negocio
{
    internal class UsuarioNegocio
    {
        // ================= Sesion =================

        // Valida los datos, busca el usuario y, si todo esta bien, lo guarda en la Sesion.
        // Devuelve true si pudo ingresar; si no, en "mensaje" queda el motivo.
        public static bool IniciarSesion(string dniTexto, string contrasena, out string mensaje)
        {
            mensaje = "";
            int dni;

            if (dniTexto.Trim() == "" || contrasena == "")
            {
                mensaje = "Ingrese su DNI y su contraseña.";
                return false;
            }

            if (!int.TryParse(dniTexto.Trim(), out dni))
            {
                mensaje = "El DNI debe contener solo números.";
                return false;
            }

            if (!Conexion.ProbarConexion())
            {
                mensaje = "No se pudo conectar con el servidor. Intente más tarde.";
                return false;
            }

            Persona usuario = UsuarioDatos.BuscarPorCredenciales(dni, HashMD5(contrasena));

            if (usuario == null)
            {
                mensaje = "DNI o contraseña incorrectos.";
                return false;
            }

            if (usuario.Estado == "Suspendido")
            {
                mensaje = "Su usuario está suspendido. Comuníquese con el administrador.";
                return false;
            }

            if (usuario.Estado == "Baja")
            {
                mensaje = "Su usuario fue dado de baja.";
                return false;
            }

            if (usuario.Perfil == "Empleado" && usuario.EstadoEmpleado == "Deshabilitado")
            {
                mensaje = "Su usuario de empleado fue deshabilitado. Comuníquese con el administrador.";
                return false;
            }

            if (usuario.Perfil == "Empleado" && usuario.EstadoEmpleado != "Habilitado")
            {
                mensaje = "Su usuario de empleado todavía no fue habilitado por el administrador.";
                return false;
            }

            Sesion.UsuarioActual = usuario;
            AccionDatos.RegistrarAccion(usuario.Legajo, "Usuarios", "Inició sesión", "");

            return true;
        }

        public static void CerrarSesion()
        {
            if (Sesion.UsuarioActual != null)
            {
                AccionDatos.RegistrarAccion(Sesion.UsuarioActual.Legajo, "Usuarios", "Cerró sesión", "");
            }
            Sesion.CerrarSesion();
        }

        // ================= Pantalla Usuarios =================

        public static List<Persona> ListarUsuarios(string buscar)
        {
            return UsuarioDatos.ListarUsuarios(buscar.Trim());
        }

        public static Persona BuscarPorLegajo(int legajo)
        {
            return UsuarioDatos.BuscarPorLegajo(legajo);
        }

        // Si usuario.Legajo es 0 lo crea; si no, guarda los cambios.
        // Un usuario nuevo tiene como contraseña inicial su DNI.
        public static bool GuardarUsuario(Persona usuario, string dniTexto, out string mensaje)
        {
            if (!ValidarDatos(usuario, dniTexto, out mensaje))
            {
                return false;
            }

            if (usuario.Legajo == 0)
            {
                usuario.Legajo = UsuarioDatos.CrearUsuario(usuario, HashMD5(usuario.Dni.ToString()));

                if (usuario.Legajo == 0)
                {
                    mensaje = "No se pudo crear el usuario.";
                    return false;
                }

                Registrar("Creó usuario", usuario.Legajo);
            }
            else
            {
                if (EstaDadoDeBaja(usuario.Legajo))
                {
                    mensaje = "No se puede modificar un usuario dado de baja.";
                    return false;
                }

                if (!UsuarioDatos.EditarUsuario(usuario))
                {
                    mensaje = "No se pudieron guardar los cambios.";
                    return false;
                }

                Registrar("Modificó usuario", usuario.Legajo);
            }

            return true;
        }

        // Activo -> Suspendido, Suspendido -> Activo
        public static bool SuspenderOReactivar(Persona usuario, out string mensaje)
        {
            if (!PuedeCambiarEstado(usuario, out mensaje))
            {
                return false;
            }

            if (usuario.Estado == "Activo")
            {
                UsuarioDatos.CambiarEstado(usuario.Legajo, "Suspendido");
                Registrar("Suspendió usuario", usuario.Legajo);
            }
            else
            {
                UsuarioDatos.CambiarEstado(usuario.Legajo, "Activo");
                Registrar("Reactivó usuario", usuario.Legajo);
            }

            return true;
        }

        // Baja definitiva: guarda la fecha de baja y el motivo. No se puede revertir.
        public static bool DarDeBaja(Persona usuario, string motivo, out string mensaje)
        {
            if (!PuedeCambiarEstado(usuario, out mensaje))
            {
                return false;
            }

            if (motivo.Trim() == "")
            {
                mensaje = "No se dio de baja: debe indicar el motivo.";
                return false;
            }

            if (!UsuarioDatos.DarDeBaja(usuario.Legajo, motivo.Trim()))
            {
                mensaje = "No se pudo dar de baja al usuario.";
                return false;
            }

            Registrar("Dio de baja usuario", usuario.Legajo);
            return true;
        }

        // La contraseña vuelve a ser el DNI del usuario
        public static bool RestablecerContrasena(Persona usuario, out string mensaje)
        {
            mensaje = "";

            if (EstaDadoDeBaja(usuario.Legajo))
            {
                mensaje = "No se puede restablecer la contraseña de un usuario dado de baja.";
                return false;
            }

            if (!UsuarioDatos.CambiarContrasena(usuario.Legajo, HashMD5(usuario.Dni.ToString())))
            {
                mensaje = "No se pudo restablecer la contraseña.";
                return false;
            }

            Registrar("Restableció contraseña", usuario.Legajo);
            return true;
        }

        // ================= Historial de acciones =================

        public static List<Accion> ListarAcciones(string usuario, string modulo, DateTime desde, DateTime hasta)
        {
            return AccionDatos.ListarAcciones(usuario.Trim(), modulo, desde, hasta);
        }

        // ================= Validaciones (las usa tambien el Registro de clientes) =================

        // Controla los datos personales y, si estan bien, carga el DNI en "usuario".
        public static bool ValidarDatos(Persona usuario, string dniTexto, out string mensaje)
        {
            mensaje = "";
            int dni;

            if (usuario.Nombre == "" || usuario.Apellido == "" || dniTexto == "" || usuario.Provincia == "" ||
                usuario.Ciudad == "" || usuario.Direccion == "" || usuario.Telefono == "" || usuario.Email == "")
            {
                mensaje = "Complete todos los campos.";
                return false;
            }

            if (!int.TryParse(dniTexto, out dni) || dniTexto.Length < 7)
            {
                mensaje = "El DNI debe tener 7 u 8 números.";
                return false;
            }

            if (usuario.FechaNacimiento.AddYears(18) > DateTime.Today)
            {
                mensaje = "El usuario debe ser mayor de 18 años.";
                return false;
            }

            if (!SoloNumeros(usuario.Telefono))
            {
                mensaje = "El teléfono debe contener solo números.";
                return false;
            }

            if (!usuario.Email.Contains("@") || !usuario.Email.Contains("."))
            {
                mensaje = "Ingrese un email válido.";
                return false;
            }

            if (UsuarioDatos.ExisteDni(dni, usuario.Legajo))
            {
                mensaje = "Ya existe un usuario registrado con ese DNI.";
                return false;
            }

            usuario.Dni = dni;
            return true;
        }

        // Convierte la contraseña en un texto de 32 caracteres (hash MD5).
        // Asi en la base nunca se guarda la contraseña real.
        public static string HashMD5(string texto)
        {
            MD5 md5 = MD5.Create();
            byte[] bytes = md5.ComputeHash(Encoding.UTF8.GetBytes(texto));

            StringBuilder hash = new StringBuilder();
            foreach (byte b in bytes)
            {
                hash.Append(b.ToString("x2"));
            }

            return hash.ToString();
        }

        // ================= Auxiliares =================

        // No se puede suspender ni dar de baja a uno mismo ni a alguien ya dado de baja
        private static bool PuedeCambiarEstado(Persona usuario, out string mensaje)
        {
            mensaje = "";

            if (usuario.Legajo == Sesion.UsuarioActual.Legajo)
            {
                mensaje = "No puede cambiar el estado de su propio usuario.";
                return false;
            }

            if (EstaDadoDeBaja(usuario.Legajo))
            {
                mensaje = "El usuario fue dado de baja. La baja es definitiva.";
                return false;
            }

            return true;
        }

        // Consulta la base (y no la pantalla) para saber el estado real del usuario
        private static bool EstaDadoDeBaja(int legajo)
        {
            Persona actual = UsuarioDatos.BuscarPorLegajo(legajo);
            return actual != null && actual.Estado == "Baja";
        }

        private static void Registrar(string accion, int legajo)
        {
            AccionDatos.RegistrarAccion(Sesion.UsuarioActual.Legajo, "Usuarios", accion, "Legajo " + legajo.ToString("0000"));
        }

        private static bool SoloNumeros(string texto)
        {
            foreach (char c in texto)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
