using FixedSegurosApp.Entidades;

namespace FixedSegurosApp.Utilidades
{
    // Guardo acá el usuario que inició sesión, para usarlo desde cualquier pantalla.
    // Al ser static hay uno solo para todo el programa
    internal class Sesion
    {
        public const string Version = "1.2";

        public static Persona UsuarioActual { get; set; }

        // Al cerrar sesión borro el usuario guardado
        public static void CerrarSesion()
        {
            UsuarioActual = null;
        }
    }
}
