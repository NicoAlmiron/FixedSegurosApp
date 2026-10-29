using System.Windows.Forms;

namespace FixedSegurosApp.Vistas
{
    // Pantalla provisoria para los modulos que todavia no se hicieron
    public partial class EnConstruccion : Form
    {
        public EnConstruccion(string titulo)
        {
            InitializeComponent();
            lbl_titulo.Text = titulo;
        }
    }
}
