using FixedSegurosApp.Entidades;
using FixedSegurosApp.Negocio;
using FixedSegurosApp.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace FixedSegurosApp.Vistas
{
    // Vehículos del cliente que inició sesión
    public partial class MisVehiculos : Form
    {
        private BindingList<Vehiculo> listaVehiculos = new BindingList<Vehiculo>();
        private Vehiculo vehiculoSeleccionado;     // null = se esta cargando uno nuevo
        private PictureBox[] casilleros;           // los casilleros de fotos

        // Las fotos que se ven en pantalla: posición -> foto (bytes). Se guardan recién al tocar "Guardar cambios".
        private Dictionary<string, byte[]> fotosActuales = new Dictionary<string, byte[]>();

        public MisVehiculos()
        {
            InitializeComponent();
            dgv_vehiculos.AutoGenerateColumns = false;
            dgv_vehiculos.DataSource = listaVehiculos;
            casilleros = GrillaFotos.Crear(grp_fotos, 10, 26, 76, 70, casillero_Click);
        }

        private void MisVehiculos_Load(object sender, EventArgs e)
        {
            Estilos.Tarjeta(pnl_lista);
            Estilos.Tarjeta(pnl_detalle);
            Estilos.Grilla(dgv_vehiculos);
            Estilos.BotonPrincipal(btn_agregar);
            Estilos.BotonPeligro(btn_eliminar);
            Estilos.BotonSecundario(btn_descartar);
            Estilos.BotonPrincipal(btn_guardar);
            Estilos.Placeholder(txt_dominio, "AB123CD");

            CargarDatos();
        }

        public void CargarDatos()
        {
            listaVehiculos.Clear();
            foreach (Vehiculo v in VehiculoNegocio.ListarMisVehiculos())
            {
                listaVehiculos.Add(v);
            }
            lbl_cantidad.Text = "Mostrando " + listaVehiculos.Count + " vehículos";

            if (listaVehiculos.Count == 0)
            {
                LimpiarDetalle();
            }
        }

        private void dgv_vehiculos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_vehiculos.SelectedRows.Count == 0)
            {
                return;
            }

            Vehiculo fila = (Vehiculo)dgv_vehiculos.SelectedRows[0].DataBoundItem;
            MostrarVehiculo(VehiculoNegocio.BuscarMiVehiculo(fila.IdVehiculo));
        }

        private void MostrarVehiculo(Vehiculo vehiculo)
        {
            vehiculoSeleccionado = vehiculo;
            if (vehiculo == null)
            {
                return;
            }

            cb_tipo.Text = vehiculo.TipoVehiculo;
            txt_dominio.Text = vehiculo.Dominio;
            txt_marca.Text = vehiculo.Marca;
            txt_modelo.Text = vehiculo.Modelo;
            txt_anio.Text = vehiculo.Anio.ToString();
            cb_vtv.Text = vehiculo.VtvVigente ? "Vigente" : "Vencida";
            txt_chasis.Text = vehiculo.NumeroChasis;
            txt_motor.Text = vehiculo.NumeroMotor;

            // las fotos se traen de la base recién ahora (pesan)
            fotosActuales = new Dictionary<string, byte[]>();
            foreach (FotoVehiculo foto in VehiculoNegocio.ListarFotos(vehiculo.IdVehiculo, Sesion.UsuarioActual.Legajo))
            {
                fotosActuales[foto.Posicion] = foto.Imagen;
            }
            MostrarFotos();

            MostrarRevision(vehiculo.EstadoRevision, vehiculo.ObservacionRevision);

            // un vehículo aprobado queda bloqueado: sus fotos son la prueba del estado inicial
            Bloquear(vehiculo.EstadoRevision == "Aprobado");
        }

        // Deja el panel de la derecha vacio para cargar un vehículo nuevo
        private void LimpiarDetalle()
        {
            vehiculoSeleccionado = null;

            cb_tipo.SelectedIndex = -1;
            txt_dominio.Clear();
            txt_marca.Clear();
            txt_modelo.Clear();
            txt_anio.Clear();
            cb_vtv.SelectedIndex = 0;
            txt_chasis.Clear();
            txt_motor.Clear();

            fotosActuales = new Dictionary<string, byte[]>();
            MostrarFotos();

            MostrarRevision("Nuevo", "");
            Bloquear(false);
        }

        // Etiqueta de color con el estado de revisión y, si fue rechazado, el motivo
        private void MostrarRevision(string estado, string motivo)
        {
            lbl_revision_valor.Text = estado == "Nuevo" ? "Sin enviar" : estado;
            lbl_revision_valor.BackColor = Estilos.ColorEstado(estado);
            lbl_revision_motivo.Text = estado == "Rechazado" ? "Motivo: " + motivo + " Corrija y guarde para enviarlo de nuevo." : "";
        }

        // Una motocicleta lleva menos fotos que el resto
        private void cb_tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            GrillaFotos.Mostrar(casilleros, cb_tipo.Text);
        }

        private void MostrarFotos()
        {
            for (int i = 0; i < casilleros.Length; i++)
            {
                string posicion = VehiculoNegocio.Posiciones[i];
                casilleros[i].Image = fotosActuales.ContainsKey(posicion) ? Imagenes.AImagen(fotosActuales[posicion]) : null;
            }
        }

        private void Bloquear(bool bloqueado)
        {
            cb_tipo.Enabled = !bloqueado;
            cb_vtv.Enabled = !bloqueado;
            txt_dominio.ReadOnly = bloqueado;
            txt_marca.ReadOnly = bloqueado;
            txt_modelo.ReadOnly = bloqueado;
            txt_anio.ReadOnly = bloqueado;
            txt_chasis.ReadOnly = bloqueado;
            txt_motor.ReadOnly = bloqueado;
            btn_guardar.Visible = !bloqueado;
            btn_descartar.Visible = !bloqueado;
            grp_fotos.Text = bloqueado ? "Fotos del vehículo (clic para verlas en grande)" : "Fotos del vehículo (clic en cada una para cargarla)";
        }

        // Clic en un casillero: si el vehículo está aprobado se ve la foto en grande; si no, se elige la foto
        private void casillero_Click(object sender, EventArgs e)
        {
            int numero = (int)((PictureBox)sender).Tag;
            string posicion = VehiculoNegocio.Posiciones[numero];

            if (vehiculoSeleccionado != null && vehiculoSeleccionado.EstadoRevision == "Aprobado")
            {
                if (fotosActuales.ContainsKey(posicion))
                {
                    new VerFoto(posicion, Imagenes.AImagen(fotosActuales[posicion])).ShowDialog();
                }
                return;
            }

            OpenFileDialog dialogo = new OpenFileDialog();
            dialogo.Title = "Foto del vehículo: " + posicion;
            dialogo.Filter = "Imágenes|*.jpg;*.jpeg;*.png;*.bmp";

            if (dialogo.ShowDialog() == DialogResult.OK)
            {
                string mensaje;
                byte[] foto = VehiculoNegocio.PrepararFoto(dialogo.FileName, out mensaje);

                if (foto == null)
                {
                    MessageBox.Show(mensaje, "Foto: " + posicion, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                fotosActuales[posicion] = foto;
                MostrarFotos();
            }
        }

        private void SeleccionarFila(int idVehiculo)
        {
            foreach (DataGridViewRow fila in dgv_vehiculos.Rows)
            {
                if (((Vehiculo)fila.DataBoundItem).IdVehiculo == idVehiculo)
                {
                    dgv_vehiculos.CurrentCell = fila.Cells[0];
                    break;
                }
            }
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            dgv_vehiculos.ClearSelection();
            LimpiarDetalle();
            cb_tipo.Focus();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            string mensaje;
            bool esNuevo = vehiculoSeleccionado == null;

            Vehiculo vehiculo = new Vehiculo()
            {
                IdVehiculo = esNuevo ? 0 : vehiculoSeleccionado.IdVehiculo,
                TipoVehiculo = cb_tipo.Text,
                Dominio = txt_dominio.Text.Trim(),
                Marca = txt_marca.Text.Trim(),
                Modelo = txt_modelo.Text.Trim(),
                VtvVigente = cb_vtv.Text == "Vigente",
                NumeroChasis = txt_chasis.Text.Trim(),
                NumeroMotor = txt_motor.Text.Trim()
            };

            List<FotoVehiculo> fotos = new List<FotoVehiculo>();
            foreach (KeyValuePair<string, byte[]> foto in fotosActuales)
            {
                fotos.Add(new FotoVehiculo() { Posicion = foto.Key, Imagen = foto.Value });
            }

            if (VehiculoNegocio.GuardarVehiculo(vehiculo, txt_anio.Text.Trim(), fotos, out mensaje))
            {
                MessageBox.Show("Vehículo guardado. Queda pendiente hasta que un empleado lo revise y lo apruebe.", "Mis vehículos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarDatos();
                SeleccionarFila(vehiculo.IdVehiculo);
            }
            else
            {
                MessageBox.Show(mensaje, "Mis vehículos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_descartar_Click(object sender, EventArgs e)
        {
            if (vehiculoSeleccionado != null)
            {
                MostrarVehiculo(VehiculoNegocio.BuscarMiVehiculo(vehiculoSeleccionado.IdVehiculo));
            }
            else
            {
                LimpiarDetalle();
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            string mensaje;

            if (vehiculoSeleccionado == null)
            {
                MessageBox.Show("No se ha seleccionado ningún vehículo.", "Mis vehículos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult respuesta = MessageBox.Show("¿Está seguro que quiere eliminar el vehículo " + vehiculoSeleccionado.Dominio + "?\nEsta acción no se puede revertir.", "Mis vehículos", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (respuesta == DialogResult.Yes)
            {
                if (VehiculoNegocio.EliminarVehiculo(vehiculoSeleccionado, out mensaje))
                {
                    MessageBox.Show("Vehículo eliminado.", "Mis vehículos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarDatos();
                }
                else
                {
                    MessageBox.Show(mensaje, "Mis vehículos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        // Pinta las columnas VTV y Revisión con su color
        private void dgv_vehiculos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((e.ColumnIndex == col_vtv.Index || e.ColumnIndex == col_revision.Index) && e.Value != null)
            {
                e.CellStyle.ForeColor = Estilos.ColorEstado(e.Value.ToString());
                e.CellStyle.Font = Estilos.Negrita;
            }
        }
    }
}
