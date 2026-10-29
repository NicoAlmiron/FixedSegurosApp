using FixedSegurosApp.Negocio;
using FixedSegurosApp.Utilidades;
using System;
using System.Windows.Forms;

namespace FixedSegurosApp.Vistas
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            Estilos.BotonPrincipal(btn_ingresar);
            Estilos.BotonSecundario(btn_registrarme);
            btn_ingresar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);

            Estilos.Placeholder(txt_dni, "Ingrese su número de documento");
            Estilos.Placeholder(txt_contrasena, "Ingrese su contraseña");
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            string mensaje;

            if (UsuarioNegocio.IniciarSesion(txt_dni.Text, txt_contrasena.Text, out mensaje))
            {
                Principal principal = new Principal();

                this.Hide();
                principal.ShowDialog();   // el Login queda esperando hasta que se cierre la ventana principal

                if (principal.CerroSesion)
                {
                    txt_contrasena.Clear();
                    this.Show();
                }
                else
                {
                    this.Close();         // cerro la ventana con la X: termina el programa
                }
            }
            else
            {
                MessageBox.Show(mensaje, "Iniciar sesión", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void chk_mostrar_CheckedChanged(object sender, EventArgs e)
        {
            txt_contrasena.UseSystemPasswordChar = !chk_mostrar.Checked;
        }

        private void lnk_olvido_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Comuníquese con el administrador para que restablezca su contraseña.", "Recuperar contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_registrarme_Click(object sender, EventArgs e)
        {
            Registro registro = new Registro();

            if (registro.ShowDialog() == DialogResult.OK)
            {
                // deja cargado el DNI recien registrado para que solo escriba la contraseña
                txt_dni.Text = registro.DniRegistrado;
                txt_contrasena.Clear();
                txt_contrasena.Focus();
            }
        }
    }
}
