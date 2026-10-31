using FixedSegurosApp.Entidades;
using FixedSegurosApp.Negocio;
using FixedSegurosApp.Utilidades;
using System;
using System.Windows.Forms;

namespace FixedSegurosApp.Vistas
{
    // Ventana secundaria: todos cambian su contraseña; el cliente además corrige sus datos de contacto.
    public partial class MiCuenta : Form
    {
        public MiCuenta()
        {
            InitializeComponent();
        }

        private void MiCuenta_Load(object sender, EventArgs e)
        {
            Estilos.Tarjeta(pnl_contrasena);
            Estilos.Tarjeta(pnl_datos);
            Estilos.BotonPrincipal(btn_cambiar);
            Estilos.BotonPrincipal(btn_guardar);
            Estilos.BotonSecundario(btn_cerrar);

            if (Sesion.UsuarioActual.Perfil == "Cliente")
            {
                CargarDatos();
            }
            else
            {
                // sin el panel de datos la ventana se acorta y el botón sube
                pnl_datos.Visible = false;
                btn_cerrar.Top = pnl_datos.Top;
                this.ClientSize = new System.Drawing.Size(this.ClientSize.Width, btn_cerrar.Bottom + 14);
            }
        }

        private void CargarDatos()
        {
            Persona usuario = UsuarioNegocio.BuscarPorLegajo(Sesion.UsuarioActual.Legajo);

            cb_provincia.Items.AddRange(Provincias.Lista);
            cb_provincia.SelectedItem = usuario.Provincia;
            txt_telefono.Text = usuario.Telefono;
            txt_email.Text = usuario.Email;
            txt_ciudad.Text = usuario.Ciudad;
            txt_direccion.Text = usuario.Direccion;
        }

        private void btn_cambiar_Click(object sender, EventArgs e)
        {
            string mensaje;

            if (UsuarioNegocio.CambiarContrasena(txt_actual.Text, txt_nueva.Text, txt_repetir.Text, out mensaje))
            {
                txt_actual.Clear();
                txt_nueva.Clear();
                txt_repetir.Clear();
                MessageBox.Show("Contraseña cambiada.", "Mi cuenta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(mensaje, "Mi cuenta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            string mensaje;

            if (UsuarioNegocio.GuardarMisDatos(cb_provincia.Text, txt_ciudad.Text, txt_direccion.Text, txt_telefono.Text, txt_email.Text, out mensaje))
            {
                MessageBox.Show("Datos guardados.", "Mi cuenta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(mensaje, "Mi cuenta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
