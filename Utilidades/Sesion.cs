using FixedSegurosApp.Entidades;

namespace FixedSegurosApp.Utilidades
{
    // Guarda el usuario que inicio sesion para usarlo desde cualquier pantalla
    internal class Sesion
    {
        public static Persona UsuarioActual { get; set; }

        public static void CerrarSesion()
        {
            UsuarioActual = null;
        }
    }
}
