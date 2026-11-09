using FixedSegurosApp.Entidades;
using FixedSegurosApp.Negocio;
using FixedSegurosApp.Utilidades;
using System;
using System.Windows.Forms;

namespace FixedSegurosApp.Vistas
{
    // Pantalla "Crear cuenta". Normalmente registra clientes, pero si la base está vacía
    // la uso para crear la cuenta del primer administrador (con su matrícula).
    public partial class Registro : Form
    {
        // El Login lo usa para dejar cargado el DNI después de registrarse
        public string DniRegistrado { get; private set; }

        private bool primerAdministrador;

        public Registro() : this(false)
        {
        }

        // primerAdministrador = true cuando el Login vio que todavía no hay ningún usuario
        public Registro(bool esPrimerAdministrador)
        {
            InitializeComponent();
            primerAdministrador = esPrimerAdministrador;
        }

        private void Registro_Load(object sender, EventArgs e)
        {
            Estilos.BotonPrincipal(btn_registrarme);
            Estilos.BotonSecundario(btn_cancelar);

            Estilos.Placeholder(txt_dni, "Solo números");
            Estilos.Placeholder(txt_direccion, "Calle y número");

            cb_provincia.Items.AddRange(Provincias.Lista);
            dtp_fecha_nacimiento.MaxDate = DateTime.Today;
            dtp_fecha_nacimiento.Value = DateTime.Today.AddYears(-18);

            if (primerAdministrador)
            {
                // cambio los textos y muestro la matrícula; agrando la ventana para que entre el campo
                // (el pie está anclado abajo, así que baja solo)
                lbl_titulo.Text = "Crear administrador";
                lbl_subtitulo.Text = "Todavía no hay usuarios: esta cuenta será la del administrador del sistema.";
                this.Text = "Fixed Seguros: Crear administrador";
                btn_registrarme.Text = "Crear cuenta";
                lbl_matricula.Visible = true;
                txt_matricula.Visible = true;
                this.ClientSize = new System.Drawing.Size(this.ClientSize.Width, this.ClientSize.Height + 60);
            }
        }

        private void btn_registrarme_Click(object sender, EventArgs e)
        {
            string mensaje;
            string titulo = primerAdministrador ? "Crear administrador" : "Registro de cliente";

            // armo el cliente con lo que escribió; Negocio decide si queda como cliente o como administrador
            Cliente cliente = new Cliente()
            {
                Nombre = txt_nombre.Text.Trim(),
                Apellido = txt_apellido.Text.Trim(),
                FechaNacimiento = dtp_fecha_nacimiento.Value.Date,
                Provincia = cb_provincia.Text,
                Ciudad = txt_ciudad.Text.Trim(),
                Direccion = txt_direccion.Text.Trim(),
                Telefono = txt_telefono.Text.Trim(),
                Email = txt_email.Text.Trim()
            };

            if (ClienteNegocio.RegistrarCuenta(cliente, txt_dni.Text.Trim(), txt_contrasena.Text, txt_repetir.Text, txt_matricula.Text, out mensaje))
            {
                string aviso = cliente.Perfil == "Administrador"
                    ? "¡Cuenta de administrador creada! Ya puede iniciar sesión con su DNI y contraseña."
                    : "¡Cuenta creada! Ya puede iniciar sesión con su DNI y contraseña.";
                MessageBox.Show(aviso, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);

                DniRegistrado = cliente.Dni.ToString();
                this.DialogResult = DialogResult.OK;   // cierra el form y le avisa al Login que salió bien
            }
            else
            {
                Avisos.Problema(mensaje, titulo);
            }
        }
    }
}
