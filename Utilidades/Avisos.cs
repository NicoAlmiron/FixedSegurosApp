using System.Windows.Forms;

namespace FixedSegurosApp.Utilidades
{
    // Muestro el motivo por el que Negocio no pudo hacer algo, con el ícono que corresponde:
    // - Error: falló el sistema (la base, la conexión o un archivo). Esos mensajes siempre empiezan con "No se pudo".
    // - Advertencia: falta un dato o está mal cargado, y lo arregla el usuario.
    internal class Avisos
    {
        public static void Problema(string mensaje, string titulo)
        {
            MessageBoxIcon icono = mensaje.StartsWith("No se pudo") ? MessageBoxIcon.Error : MessageBoxIcon.Exclamation;
            MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, icono);
        }
    }
}
