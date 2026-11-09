using FixedSegurosApp.Entidades;
using FixedSegurosApp.Negocio;
using FixedSegurosApp.Utilidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FixedSegurosApp.Vistas
{
    // Trámite en la oficina (solo el empleado): cliente, vehículo y póliza en una sola pantalla.
    // Se guarda todo junto al tocar "Crear y contratar"
    public partial class AltaOficina : Form
    {
        private Persona clienteRegistrado;                  // null = cliente nuevo
        private List<Vehiculo> vehiculosCliente = new List<Vehiculo>();   // sus vehículos aprobados sin póliza
        private PictureBox[] casilleros;

        // Las fotos elegidas: posición -> foto (bytes)
        private Dictionary<string, byte[]> fotosActuales = new Dictionary<string, byte[]>();

        // Preparo la grilla y armo los casilleros de fotos por código (GrillaFotos)
        public AltaOficina()
        {
            InitializeComponent();
            dgv_ofrecidas.AutoGenerateColumns = false;
            casilleros = GrillaFotos.Crear(grp_fotos, 10, 22, 57, 54, casillero_Click);
        }

        // Al abrir la pantalla le aplico los estilos y cargo los datos
        private void AltaOficina_Load(object sender, EventArgs e)
        {
            Estilos.Tarjeta(pnl_cliente);
            Estilos.Tarjeta(pnl_vehiculo);
            Estilos.Tarjeta(pnl_poliza);
            Estilos.Grilla(dgv_ofrecidas);
            Estilos.BotonSecundario(btn_volver);
            Estilos.BotonSecundario(btn_buscar);
            Estilos.BotonSecundario(btn_limpiar);
            Estilos.BotonPrincipal(btn_crear);
            Estilos.Placeholder(txt_dni, "Solo números");
            Estilos.Placeholder(txt_direccion, "Calle y número");
            Estilos.Placeholder(txt_dominio, "AB123CD");

            cb_provincia.Items.AddRange(Provincias.Lista);
            dtp_nacimiento.MaxDate = DateTime.Today;

            Limpiar();
        }

        // Dejo toda la pantalla vacía para un trámite nuevo
        private void Limpiar()
        {
            txt_dni.Clear();
            LimpiarCliente();
            txt_dni.Focus();
        }

        // Dejo la tarjeta del cliente como cliente nuevo (no toco el DNI) y reinicio el vehículo
        private void LimpiarCliente()
        {
            clienteRegistrado = null;
            vehiculosCliente = new List<Vehiculo>();

            txt_nombre.Clear();
            txt_apellido.Clear();
            dtp_nacimiento.Value = DateTime.Today.AddYears(-18);
            cb_provincia.SelectedIndex = -1;
            txt_ciudad.Clear();
            txt_direccion.Clear();
            txt_telefono.Clear();
            txt_email.Clear();
            lbl_cliente_info.Text = "Cliente nuevo: entra con su DNI como usuario y contraseña.";

            BloquearCliente(false);
            CargarComboVehiculos();
        }

        // Si el cliente ya existe, sus datos no se tocan desde acá: los bloqueo
        private void BloquearCliente(bool bloqueado)
        {
            txt_nombre.ReadOnly = bloqueado;
            txt_apellido.ReadOnly = bloqueado;
            dtp_nacimiento.Enabled = !bloqueado;
            cb_provincia.Enabled = !bloqueado;
            txt_ciudad.ReadOnly = bloqueado;
            txt_direccion.ReadOnly = bloqueado;
            txt_telefono.ReadOnly = bloqueado;
            txt_email.ReadOnly = bloqueado;
        }

        // ================= Cliente =================

        // Botón Buscar del DNI
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            BuscarCliente();
        }

        // Si el DNI ya es de un cliente, cargo sus datos y sus vehículos; si no, queda como cliente nuevo
        private void BuscarCliente()
        {
            int dni;
            if (!int.TryParse(txt_dni.Text.Trim(), out dni))
            {
                MessageBox.Show("Ingrese el DNI, solo números.", "Alta en oficina", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            LimpiarCliente();

            Persona cliente = ClienteNegocio.BuscarPorDni(dni);
            if (cliente == null)
            {
                lbl_cliente_info.Text = "No hay un cliente con ese DNI. Complete sus datos: entra con su DNI como usuario y contraseña.";
                txt_nombre.Focus();
                return;
            }

            clienteRegistrado = cliente;
            txt_nombre.Text = cliente.Nombre;
            txt_apellido.Text = cliente.Apellido;
            dtp_nacimiento.Value = cliente.FechaNacimiento;
            cb_provincia.Text = cliente.Provincia;
            txt_ciudad.Text = cliente.Ciudad;
            txt_direccion.Text = cliente.Direccion;
            txt_telefono.Text = cliente.Telefono;
            txt_email.Text = cliente.Email;
            lbl_cliente_info.Text = "Cliente ya registrado (legajo " + cliente.Legajo.ToString("0000") + "). Sus datos se editan en Usuarios.";

            BloquearCliente(true);

            vehiculosCliente = PolizaNegocio.ListarVehiculosAsegurables(cliente.Legajo);
            CargarComboVehiculos();
        }

        // Si cambian el DNI de un cliente ya encontrado, ya no es ese cliente
        private void txt_dni_TextChanged(object sender, EventArgs e)
        {
            if (clienteRegistrado != null && txt_dni.Text.Trim() != clienteRegistrado.Dni.ToString())
            {
                LimpiarCliente();
            }
        }

        // ================= Vehículo =================

        // La primera opción es cargar uno nuevo; después van los vehículos que ya tiene el cliente
        private void CargarComboVehiculos()
        {
            cb_vehiculo.Items.Clear();
            cb_vehiculo.Items.Add("Cargar vehículo nuevo");
            foreach (Vehiculo v in vehiculosCliente)
            {
                cb_vehiculo.Items.Add(v.Descripcion);
            }
            cb_vehiculo.SelectedIndex = 0;
        }

        // Al elegir un vehículo existente muestro sus datos; con "nuevo" habilito los campos y las fotos
        private void cb_vehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool esNuevo = cb_vehiculo.SelectedIndex <= 0;

            if (esNuevo)
            {
                cb_tipo.SelectedIndex = -1;
                txt_dominio.Clear();
                txt_marca.Clear();
                txt_modelo.Clear();
                txt_anio.Clear();
                dtp_vigencia.Value = DateTime.Today.AddYears(1);
                txt_chasis.Clear();
                txt_motor.Clear();
                fotosActuales = new Dictionary<string, byte[]>();
                MostrarFotos();
                CargarOfrecidas();
            }
            else
            {
                Vehiculo vehiculo = vehiculosCliente[cb_vehiculo.SelectedIndex - 1];
                cb_tipo.Text = vehiculo.TipoVehiculo;
                txt_dominio.Text = vehiculo.Dominio;
                txt_marca.Text = vehiculo.Marca;
                txt_modelo.Text = vehiculo.Modelo;
                txt_anio.Text = vehiculo.Anio.ToString();
                dtp_vigencia.Value = vehiculo.VigenciaVtv;
                txt_chasis.Text = vehiculo.NumeroChasis;
                txt_motor.Text = vehiculo.NumeroMotor;
            }

            // un vehículo que ya tiene el cliente está aprobado: no se toca ni pide fotos
            cb_tipo.Enabled = esNuevo;
            dtp_vigencia.Enabled = esNuevo;
            txt_dominio.ReadOnly = !esNuevo;
            txt_marca.ReadOnly = !esNuevo;
            txt_modelo.ReadOnly = !esNuevo;
            txt_anio.ReadOnly = !esNuevo;
            txt_chasis.ReadOnly = !esNuevo;
            txt_motor.ReadOnly = !esNuevo;
            grp_fotos.Visible = esNuevo;
        }

        // Al cambiar el tipo cambian las fotos que lleva y las pólizas que puede contratar
        private void cb_tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            GrillaFotos.Mostrar(casilleros, cb_tipo.Text);
            CargarOfrecidas();
        }

        // Muestro en los casilleros las fotos elegidas
        private void MostrarFotos()
        {
            for (int i = 0; i < casilleros.Length; i++)
            {
                string posicion = VehiculoNegocio.Posiciones[i];
                casilleros[i].Image = fotosActuales.ContainsKey(posicion) ? Imagenes.AImagen(fotosActuales[posicion]) : null;
            }
        }

        // Clic en un casillero: elijo la foto de esa posición y la preparo (legible y liviana)
        private void casillero_Click(object sender, EventArgs e)
        {
            int numero = (int)((PictureBox)sender).Tag;
            string posicion = VehiculoNegocio.Posiciones[numero];

            OpenFileDialog dialogo = new OpenFileDialog();
            dialogo.Title = "Foto del vehículo: " + posicion;
            dialogo.Filter = "Imágenes|*.jpg;*.jpeg;*.png;*.bmp";

            if (dialogo.ShowDialog() == DialogResult.OK)
            {
                string mensaje;
                byte[] foto = VehiculoNegocio.PrepararFoto(dialogo.FileName, out mensaje);

                if (foto == null)
                {
                    Avisos.Problema(mensaje, "Foto: " + posicion);
                    return;
                }

                fotosActuales[posicion] = foto;
                MostrarFotos();
            }
        }

        // ================= Póliza =================

        // Cargo las pólizas ofrecidas para el tipo de vehículo
        private void CargarOfrecidas()
        {
            List<Poliza> ofrecidas = cb_tipo.Text == "" ? new List<Poliza>() : PolizaNegocio.ListarOfrecidas(cb_tipo.Text);

            dgv_ofrecidas.DataSource = ofrecidas;

            if (cb_tipo.Text == "")
            {
                lbl_oferta.Text = "Elija el tipo de vehículo para ver las pólizas disponibles.";
            }
            else if (ofrecidas.Count == 0)
            {
                lbl_oferta.Text = "No hay pólizas ofrecidas para " + cb_tipo.Text + ".";
            }
        }

        // Al elegir una póliza muestro su detalle con las cuotas
        private void dgv_ofrecidas_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_ofrecidas.SelectedRows.Count > 0)
            {
                lbl_oferta.Text = PolizaNegocio.DescribirOferta((Poliza)dgv_ofrecidas.SelectedRows[0].DataBoundItem);
            }
        }

        // ================= Confirmar =================

        // Confirmo el trámite: Negocio valida todo y lo guarda en una sola transacción; después ofrezco cobrar la primera cuota
        private void btn_crear_Click(object sender, EventArgs e)
        {
            string mensaje;
            int nroPoliza;

            Persona cliente = clienteRegistrado != null ? clienteRegistrado : new Persona()
            {
                Nombre = txt_nombre.Text.Trim(),
                Apellido = txt_apellido.Text.Trim(),
                FechaNacimiento = dtp_nacimiento.Value.Date,
                Provincia = cb_provincia.Text,
                Ciudad = txt_ciudad.Text.Trim(),
                Direccion = txt_direccion.Text.Trim(),
                Telefono = txt_telefono.Text.Trim(),
                Email = txt_email.Text.Trim()
            };

            Vehiculo vehiculo = cb_vehiculo.SelectedIndex > 0 ? vehiculosCliente[cb_vehiculo.SelectedIndex - 1] : new Vehiculo()
            {
                TipoVehiculo = cb_tipo.Text,
                Dominio = txt_dominio.Text.Trim(),
                Marca = txt_marca.Text.Trim(),
                Modelo = txt_modelo.Text.Trim(),
                VigenciaVtv = dtp_vigencia.Value.Date,
                NumeroChasis = txt_chasis.Text.Trim(),
                NumeroMotor = txt_motor.Text.Trim()
            };

            List<FotoVehiculo> fotos = new List<FotoVehiculo>();
            foreach (KeyValuePair<string, byte[]> foto in fotosActuales)
            {
                fotos.Add(new FotoVehiculo() { Posicion = foto.Key, Imagen = foto.Value });
            }

            int nroOfrecida = dgv_ofrecidas.SelectedRows.Count > 0 ? ((Poliza)dgv_ofrecidas.SelectedRows[0].DataBoundItem).NroPoliza : 0;
            bool esNuevo = clienteRegistrado == null;

            if (!AltaOficinaNegocio.Confirmar(cliente, txt_dni.Text.Trim(), vehiculo, txt_anio.Text.Trim(), fotos, nroOfrecida, out nroPoliza, out mensaje))
            {
                Avisos.Problema(mensaje, "Alta en oficina");
                return;
            }

            string aviso = "Póliza N° " + nroPoliza.ToString("000000") + " contratada para " + vehiculo.Dominio + ".\n";
            if (esNuevo)
            {
                aviso += "El cliente entra con el usuario " + cliente.Dni + " y la contraseña " + cliente.Dni + ".\n";
            }

            DialogResult respuesta = MessageBox.Show(aviso + "\n¿Cobrar la primera cuota ahora?", "Alta en oficina", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                ((Principal)this.ParentForm).AbrirForm(new Pagos(cliente.Dni));
            }
            else
            {
                Limpiar();
            }
        }

        // Empiezo de nuevo
        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        // Vuelvo a Pólizas
        private void btn_volver_Click(object sender, EventArgs e)
        {
            ((Principal)this.ParentForm).AbrirForm(new Polizas());
        }
    }
}
