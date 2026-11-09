using FixedSegurosApp.Negocio;
using FixedSegurosApp.Utilidades;
using System;
using System.Windows.Forms;

namespace FixedSegurosApp.Vistas
{
    // Primera pantalla del sistema: inicio de sesión con DNI y contraseña.
    // Si la base todavía no tiene usuarios, ofrece crear la cuenta del administrador.
    public partial class Login : Form
    {
        private bool faltaAdministrador;   // true cuando la base está vacía

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

            lbl_version.Text = "Versión " + Sesion.Version;

            RevisarPrimerUsuario();
        }

        // Me fijo si ya hay usuarios. Si no hay, cambio el pie para que se cree el administrador
        private void RevisarPrimerUsuario()
        {
            faltaAdministrador = !UsuarioNegocio.HayUsuarios();

            if (faltaAdministrador)
            {
                lbl_cliente_nuevo.Text = "Todavía no hay usuarios.";
                lbl_cliente_nuevo.ForeColor = Estilos.Advertencia;
                btn_registrarme.Text = "Crear administrador";
                btn_registrarme.Width = 170;
                btn_registrarme.Left = txt_dni.Right - btn_registrarme.Width;
            }
            else
            {
                lbl_cliente_nuevo.Text = "¿Cliente nuevo?";
                lbl_cliente_nuevo.ForeColor = Estilos.Texto;
                btn_registrarme.Text = "Registrarme";
                btn_registrarme.Width = 130;
                btn_registrarme.Left = txt_dni.Right - btn_registrarme.Width;
            }
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
                    this.Close();         // cerró la ventana con la X: termina el programa
                }
            }
            else
            {
                Avisos.Problema(mensaje, "Iniciar sesión");
            }
        }

        // Muestro u oculto la contraseña según el casillero
        private void chk_mostrar_CheckedChanged(object sender, EventArgs e)
        {
            txt_contrasena.UseSystemPasswordChar = !chk_mostrar.Checked;
        }

        private void lnk_olvido_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Comuníquese con el administrador para que restablezca su contraseña.", "Recuperar contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Abro "Crear cuenta". Si falta el administrador, se abre en modo administrador
        private void btn_registrarme_Click(object sender, EventArgs e)
        {
            Registro registro = new Registro(faltaAdministrador);

            if (registro.ShowDialog() == DialogResult.OK)
            {
                // dejo cargado el DNI recién registrado para que solo escriba la contraseña
                txt_dni.Text = registro.DniRegistrado;
                txt_contrasena.Clear();
                txt_contrasena.Focus();
            }

            RevisarPrimerUsuario();
        }
    }
}
