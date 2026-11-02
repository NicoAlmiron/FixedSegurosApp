using FixedSegurosApp.Entidades;
using FixedSegurosApp.Negocio;
using FixedSegurosApp.Utilidades;
using System;
using System.Windows.Forms;

namespace FixedSegurosApp.Vistas
{
    // Ventana secundaria: todos cambian su contraseña y corrigen sus datos de contacto,
    // y el administrador además su nombre y matrícula.
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

            CargarDatos();

            if (Sesion.UsuarioActual.Perfil != "Administrador")
            {
                OcultarDatosDeAdministrador();
            }

            Estilos.AjustarVentana(this, 520, btn_cerrar.Bottom + 14);
        }

        // Cliente y empleado no cambian su nombre ni tienen matrícula: esa fila se saca y el resto sube
        private void OcultarDatosDeAdministrador()
        {
            int primeraFila = lbl_telefono.Top;
            int alto = primeraFila - lbl_nombre.Top;

            foreach (Control control in new Control[] { lbl_nombre, txt_nombre, lbl_apellido, txt_apellido, lbl_matricula, txt_matricula })
            {
                control.Visible = false;
            }

            foreach (Control control in pnl_datos.Controls)
            {
                if (control.Top >= primeraFila)
                {
                    control.Top -= alto;
                }
            }

            txt_direccion.Width = txt_email.Right - txt_direccion.Left;
            pnl_datos.Height -= alto;
            btn_cerrar.Top -= alto;
        }

        private void CargarDatos()
        {
            Persona usuario = UsuarioNegocio.BuscarPorLegajo(Sesion.UsuarioActual.Legajo);

            cb_provincia.Items.AddRange(Provincias.Lista);
            cb_provincia.SelectedItem = usuario.Provincia;
            txt_nombre.Text = usuario.Nombre;
            txt_apellido.Text = usuario.Apellido;
            txt_matricula.Text = usuario.Matricula;
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

            if (UsuarioNegocio.GuardarMisDatos(txt_nombre.Text, txt_apellido.Text, cb_provincia.Text, txt_ciudad.Text, txt_direccion.Text, txt_telefono.Text, txt_email.Text, txt_matricula.Text, out mensaje))
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
