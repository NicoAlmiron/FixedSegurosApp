using FixedSegurosApp.Entidades;
using FixedSegurosApp.Utilidades;
using System.Collections.Generic;
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
            Estilos.BotonSecundario(btn_cerrar);
        }

        // Abre los adjuntos de un reclamo de a uno: al cerrar una foto aparece la siguiente
        public static void MostrarAdjuntos(List<AdjuntoSiniestro> adjuntos, string expediente)
        {
            for (int i = 0; i < adjuntos.Count; i++)
            {
                string titulo = adjuntos[i].Tipo + " " + (i + 1) + " de " + adjuntos.Count + " · Expediente " + expediente;
                new VerFoto(titulo, Imagenes.AImagen(adjuntos[i].Imagen)).ShowDialog();
            }
        }
    }
}
