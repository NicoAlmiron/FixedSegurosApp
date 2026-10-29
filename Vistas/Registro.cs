using FixedSegurosApp.Entidades;
using FixedSegurosApp.Negocio;
using FixedSegurosApp.Utilidades;
using System;
using System.Windows.Forms;

namespace FixedSegurosApp.Vistas
{
    public partial class Registro : Form
    {
        // El Login lo usa para dejar cargado el DNI despues de registrarse
        public string DniRegistrado { get; private set; }

        public Registro()
        {
            InitializeComponent();
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
        }

        private void btn_registrarme_Click(object sender, EventArgs e)
        {
            string mensaje;

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

            if (ClienteNegocio.RegistrarCliente(cliente, txt_dni.Text.Trim(), txt_contrasena.Text, txt_repetir.Text, out mensaje))
            {
                MessageBox.Show("¡Cuenta creada! Ya puede iniciar sesión con su DNI y contraseña.", "Registro de cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DniRegistrado = cliente.Dni.ToString();
                this.DialogResult = DialogResult.OK;   // cierra el form y avisa al Login que salio bien
            }
            else
            {
                MessageBox.Show(mensaje, "Registro de cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
