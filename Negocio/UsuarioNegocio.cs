using FixedSegurosApp.Datos;
using FixedSegurosApp.Entidades;
using FixedSegurosApp.Utilidades;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace FixedSegurosApp.Negocio
{
    // Reglas de usuarios: inicio de sesión, contraseñas, la pantalla Usuarios, Mi cuenta y el historial.
    // Negocio valida lo que llega de la pantalla, aplica las reglas, llama a Datos y registra la acción en el historial. No escribe SQL.
    internal class UsuarioNegocio
    {
        // Texto del cartel de la barra inferior: la versión del sistema y el servidor al que se conecta
        public static string TextoServidor(out bool conectado)
        {
            conectado = Conexion.ProbarConexion();

            return "Versión " + Sesion.Version + "   ·   Servidor: " + Conexion.NombreServidor() + (conectado ? " (conectado)" : " (sin conexión)");
        }

        // ================= Sesión =================

        // Controlo los datos, busco al usuario y, si está todo bien, lo guardo en la Sesion.
        // Devuelvo true si pudo entrar; si no, en "mensaje" queda el motivo
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

            Persona usuario = Autenticar(dni, contrasena);

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
            NotificacionNegocio.GenerarAvisos();

            return true;
        }

        // Registro la salida en el historial y borro la sesión
        public static void CerrarSesion()
        {
            if (Sesion.UsuarioActual != null)
            {
                AccionDatos.RegistrarAccion(Sesion.UsuarioActual.Legajo, "Usuarios", "Cerró sesión", "");
            }
            Sesion.CerrarSesion();
        }

        // ================= Pantalla Usuarios =================

        // Lista para la grilla. El empleado solo ve clientes
        public static List<Persona> ListarUsuarios(string buscar)
        {
            return UsuarioDatos.ListarUsuarios(buscar.Trim(), Sesion.UsuarioActual.Perfil == "Empleado");
        }

        // Todos los datos de un usuario
        public static Persona BuscarPorLegajo(int legajo)
        {
            return UsuarioDatos.BuscarPorLegajo(legajo);
        }

        // Si usuario.Legajo es 0 lo creo; si no, guardo los cambios.
        // Un usuario nuevo tiene como contraseña inicial su DNI (guardada como hash con su sal)
        public static bool GuardarUsuario(Persona usuario, string dniTexto, out string mensaje)
        {
            if (!ValidarDatos(usuario, dniTexto, out mensaje))
            {
                return false;
            }

            if (usuario.Legajo == 0)
            {
                string sal = GenerarSal();
                usuario.Legajo = UsuarioDatos.CrearUsuario(usuario, HashConSal(usuario.Dni.ToString(), sal), sal);

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

        // Activo -> Suspendido o Suspendido -> Activo
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

        // Baja definitiva: guardo la fecha de baja y el motivo. No se puede revertir
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

        // La contraseña vuelve a ser el DNI del usuario, con una sal nueva
        public static bool RestablecerContrasena(Persona usuario, out string mensaje)
        {
            mensaje = "";

            if (EstaDadoDeBaja(usuario.Legajo))
            {
                mensaje = "No se puede restablecer la contraseña de un usuario dado de baja.";
                return false;
            }

            string sal = GenerarSal();
            if (!UsuarioDatos.CambiarContrasena(usuario.Legajo, HashConSal(usuario.Dni.ToString(), sal), sal))
            {
                mensaje = "No se pudo restablecer la contraseña.";
                return false;
            }

            Registrar("Restableció contraseña", usuario.Legajo);
            return true;
        }

        // ================= Mi cuenta =================

        // true si sigue con la contraseña inicial: los usuarios creados por el administrador o en la oficina arrancan con su DNI
        public static bool TieneContrasenaInicial()
        {
            int dni = Sesion.UsuarioActual.Dni;
            return Autenticar(dni, dni.ToString()) != null;
        }

        // Cambio la contraseña de quien inició sesión: controlo la actual y las reglas de la nueva (mínimo 6, distinta, no el DNI)
        public static bool CambiarContrasena(string actual, string nueva, string repetir, out string mensaje)
        {
            mensaje = "";
            Persona usuario = Sesion.UsuarioActual;

            if (actual == "" || nueva == "" || repetir == "")
            {
                mensaje = "Complete los tres campos.";
                return false;
            }

            if (Autenticar(usuario.Dni, actual) == null)
            {
                mensaje = "La contraseña actual no es correcta.";
                return false;
            }

            if (nueva.Length < 6)
            {
                mensaje = "La contraseña debe tener al menos 6 caracteres.";
                return false;
            }

            if (nueva != repetir)
            {
                mensaje = "Las contraseñas no coinciden.";
                return false;
            }

            if (nueva == actual)
            {
                mensaje = "La contraseña nueva debe ser distinta de la actual.";
                return false;
            }

            if (nueva == usuario.Dni.ToString())
            {
                mensaje = "La contraseña no puede ser su DNI.";
                return false;
            }

            string sal = GenerarSal();
            if (!UsuarioDatos.CambiarContrasena(usuario.Legajo, HashConSal(nueva, sal), sal))
            {
                mensaje = "No se pudo cambiar la contraseña.";
                return false;
            }

            Registrar("Cambió su contraseña", usuario.Legajo);
            return true;
        }

        // Cada usuario corrige sus datos de contacto; el administrador además su nombre y su matrícula.
        // El DNI no se cambia: es el usuario para iniciar sesión
        public static bool GuardarMisDatos(string nombre, string apellido, string provincia, string ciudad, string direccion, string telefono, string email, string matricula, out string mensaje)
        {
            mensaje = "";
            bool esAdministrador = Sesion.UsuarioActual.Perfil == "Administrador";

            Persona usuario = UsuarioDatos.BuscarPorLegajo(Sesion.UsuarioActual.Legajo);

            if (esAdministrador)
            {
                usuario.Nombre = nombre.Trim();
                usuario.Apellido = apellido.Trim();
                usuario.Matricula = matricula;
            }

            usuario.Provincia = provincia;
            usuario.Ciudad = ciudad.Trim();
            usuario.Direccion = direccion.Trim();
            usuario.Telefono = telefono.Trim();
            usuario.Email = email.Trim();

            if (!ValidarDatos(usuario, usuario.Dni.ToString(), out mensaje))
            {
                return false;
            }

            if (!UsuarioDatos.EditarUsuario(usuario))
            {
                mensaje = "No se pudieron guardar los cambios.";
                return false;
            }

            // actualizo la sesión, porque el menú lateral muestra el nombre
            Sesion.UsuarioActual.Nombre = usuario.Nombre;
            Sesion.UsuarioActual.Apellido = usuario.Apellido;

            Registrar("Modificó sus datos", usuario.Legajo);
            return true;
        }

        // ================= Historial de acciones =================

        // Historial de acciones con los filtros de la pantalla
        public static List<Accion> ListarAcciones(string usuario, string modulo, DateTime desde, DateTime hasta)
        {
            return AccionDatos.ListarAcciones(usuario.Trim(), modulo, desde, hasta);
        }

        // ================= Validaciones (las usa también el Registro) =================

        // Controlo los datos personales y, si están bien, cargo el DNI en "usuario"
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

            if (usuario.Perfil == "Administrador")
            {
                usuario.Matricula = (usuario.Matricula ?? "").Trim();

                if (usuario.Matricula == "" || usuario.Matricula.Length > 50)
                {
                    mensaje = "Ingrese la matrícula del administrador (hasta 50 caracteres).";
                    return false;
                }
            }

            usuario.Dni = dni;
            return true;
        }

        // ================= Contraseñas con hash y sal ================

        private const int Vueltas = 10000;   // PBKDF2 repite el cálculo 10.000 veces: así adivinar por fuerza bruta es muy lento

        // Genero 16 bytes al azar y los paso a texto (Base64) para guardarlos en la base
        public static string GenerarSal()
        {
            byte[] sal = new byte[16];

            using (RNGCryptoServiceProvider azar = new RNGCryptoServiceProvider())
            {
                azar.GetBytes(sal);
            }

            return Convert.ToBase64String(sal);
        }

        // Calculo el hash de la contraseña mezclada con la sal (PBKDF2 con SHA-256) y lo devuelvo como texto
        public static string HashConSal(string contrasena, string sal)
        {
            using (Rfc2898DeriveBytes pbkdf2 = new Rfc2898DeriveBytes(contrasena, Convert.FromBase64String(sal), Vueltas, HashAlgorithmName.SHA256))
            {
                return Convert.ToBase64String(pbkdf2.GetBytes(32));
            }
        }

        // Para saber si la contraseña es correcta vuelvo a calcular el hash con la sal guardada y comparo
        public static bool VerificarContrasena(string contrasena, string hashGuardado, string sal)
        {
            return HashConSal(contrasena, sal) == hashGuardado;
        }

        // Busco al usuario por DNI y controlo la contraseña. Si no existe o la contraseña no coincide, devuelvo null
        private static Persona Autenticar(int dni, string contrasena)
        {
            string hashGuardado;
            string sal;
            Persona usuario = UsuarioDatos.BuscarParaLogin(dni, out hashGuardado, out sal);

            if (usuario == null || !VerificarContrasena(contrasena, hashGuardado, sal))
            {
                return null;
            }

            return usuario;
        }

        // ================= Primer usuario =================

        // Si la base está vacía, el primero que se registra es el administrador.
        // Si no hay conexión (ContarUsuarios devuelve -1) digo que sí hay, para no ofrecer crear un administrador de más.
        public static bool HayUsuarios()
        {
            return UsuarioDatos.ContarUsuarios() != 0;
        }

        // ================= Auxiliares =================

        // No se puede suspender ni dar de baja a un administrador, a uno mismo ni a alguien ya dado de baja
        private static bool PuedeCambiarEstado(Persona usuario, out string mensaje)
        {
            mensaje = "";

            // consulto la base: el perfil que llega desde la pantalla podría no ser el real
            Persona actual = UsuarioDatos.BuscarPorLegajo(usuario.Legajo);

            if (actual != null && actual.Perfil == "Administrador")
            {
                mensaje = "No se puede suspender ni dar de baja a un administrador.";
                return false;
            }

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

        // Consulto la base (y no la pantalla) para saber el estado real del usuario
        private static bool EstaDadoDeBaja(int legajo)
        {
            Persona actual = UsuarioDatos.BuscarPorLegajo(legajo);
            return actual != null && actual.Estado == "Baja";
        }

        // Dejo la acción en el historial, en el módulo Usuarios
        private static void Registrar(string accion, int legajo)
        {
            AccionDatos.RegistrarAccion(Sesion.UsuarioActual.Legajo, "Usuarios", accion, "Legajo " + legajo.ToString("0000"));
        }

        // true si el texto tiene solo dígitos
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
