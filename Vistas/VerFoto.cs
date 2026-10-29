using System.Drawing;
using System.Windows.Forms;

namespace FixedSegurosApp.Vistas
{
    // Ventana para ver una foto en grande
    public partial class VerFoto : Form
    {
        public VerFoto(string titulo, Image foto)
        {
            InitializeComponent();
            this.Text = "Fixed Seguros: " + titulo;
            pic_foto.Image = foto;
        }
    }
}
