using FixedSegurosApp.Entidades;
using FixedSegurosApp.Negocio;
using FixedSegurosApp.Utilidades;
using System;
using System.Windows.Forms;

namespace FixedSegurosApp.Vistas
{
    // Ventana aparte: el cliente carga la nueva vigencia y la foto de la VTV renovada; después la corrobora un empleado
    public partial class ActualizarVtv : Form
    {
        private Vehiculo vehiculo;
        private byte[] fotoNueva;

        // Recibo el vehículo, muestro su VTV actual y propongo una fecha nueva
        public ActualizarVtv(Vehiculo vehiculoActual)
        {
            InitializeComponent();
            vehiculo = vehiculoActual;

            Estilos.BotonSecundario(btn_foto);
            Estilos.BotonSecundario(btn_cancelar);
            Estilos.BotonPrincipal(btn_enviar);

            lbl_vehiculo.Text = vehiculo.Descripcion + "\nVTV actual: hasta el " + vehiculo.VigenciaVtv.ToString("dd/MM/yyyy");
            lbl_aviso.Text = vehiculo.ServicioSuspendido
                ? "El servicio sigue suspendido hasta que un empleado apruebe la VTV."
                : "Queda en espera de la revisión de un empleado. Mientras tanto el servicio no se suspende.";

            DateTime sugerida = DateTime.Today.AddYears(1);
            dtp_vigencia.Value = sugerida > vehiculo.VigenciaVtv ? sugerida : vehiculo.VigenciaVtv.AddYears(1);
        }

        // Ajusto el tamaño de la ventana
        private void ActualizarVtv_Load(object sender, EventArgs e)
        {
            Estilos.AjustarVentana(this, 440, 312);
        }

        // Elijo la foto de la VTV nueva y la preparo (legible y liviana)
        private void btn_foto_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialogo = new OpenFileDialog();
            dialogo.Title = "Foto de la VTV renovada";
            dialogo.Filter = "Imágenes|*.jpg;*.jpeg;*.png;*.bmp";

            if (dialogo.ShowDialog() == DialogResult.OK)
            {
                string mensaje;
                byte[] foto = VehiculoNegocio.PrepararFoto(dialogo.FileName, out mensaje);

                if (foto == null)
                {
                    Avisos.Problema(mensaje, "Actualizar VTV");
                    return;
                }

                fotoNueva = foto;
                pic_foto.Image = Imagenes.AImagen(foto);
            }
        }

        // Envío la renovación: queda en revisión hasta que la vea un empleado
        private void btn_enviar_Click(object sender, EventArgs e)
        {
            string mensaje;

            if (VehiculoNegocio.ActualizarVtv(vehiculo.IdVehiculo, dtp_vigencia.Value.Date, fotoNueva, out mensaje))
            {
                MessageBox.Show("VTV enviada. Queda en espera de la revisión de un empleado.", "Actualizar VTV", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
            }
            else
            {
                Avisos.Problema(mensaje, "Actualizar VTV");
            }
        }
    }
}
