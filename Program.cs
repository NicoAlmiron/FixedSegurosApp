using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FixedSegurosApp
{
    // Lo primero que se ejecuta al abrir el programa
    internal static class Program
    {
        // Punto de entrada: preparo el estilo visual de Windows y abro el Login.
        // Application.Run deja el programa abierto hasta que se cierra esa ventana
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Vistas.Login());
        }
    }
}
