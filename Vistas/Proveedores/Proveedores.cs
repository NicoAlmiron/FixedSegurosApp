using FixedSegurosApp.Entidades;
using FixedSegurosApp.Negocio;
using FixedSegurosApp.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace FixedSegurosApp.Vistas
{
    // ABM de aseguradoras (solo Administrador)
    public partial class Proveedores : Form
    {
        private BindingList<Proveedor> listaProveedores = new BindingList<Proveedor>();
        private Proveedor proveedorSeleccionado;   // null = se esta cargando una aseguradora nueva

        public Proveedores()
        {
            InitializeComponent();
            dgv_proveedores.AutoGenerateColumns = false;
            dgv_proveedores.DataSource = listaProveedores;
        }

        private void Proveedores_Load(object sender, EventArgs e)
        {
            Estilos.Tarjeta(pnl_lista);
            Estilos.Tarjeta(pnl_detalle);
            Estilos.Grilla(dgv_proveedores);
            Estilos.BotonPrincipal(btn_nueva);
            Estilos.BotonPeligro(btn_baja);
            Estilos.BotonSecundario(btn_descartar);
            Estilos.BotonPrincipal(btn_guardar);
            Estilos.Placeholder(txt_buscar, "Buscar por nombre, CUIT o registro SSN");
            Estilos.Placeholder(txt_cuit, "30-12345678-9");
            Estilos.Placeholder(txt_direccion, "Calle y número");

            cb_provincia.Items.AddRange(Provincias.Lista);

            CargarDatos();
        }

        public void CargarDatos()
        {
            CargarLista(ProveedorNegocio.ListarProveedores(txt_buscar.Text));
        }

        private void CargarLista(List<Proveedor> resultado)
        {
            listaProveedores.Clear();
            foreach (Proveedor p in resultado)
            {
                listaProveedores.Add(p);
            }
            lbl_cantidad.Text = "Mostrando " + listaProveedores.Count + " aseguradoras";

            if (listaProveedores.Count == 0)
            {
                LimpiarDetalle();
            }
        }

        private void dgv_proveedores_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_proveedores.SelectedRows.Count == 0)
            {
                return;
            }

            Proveedor fila = (Proveedor)dgv_proveedores.SelectedRows[0].DataBoundItem;
            MostrarProveedor(ProveedorNegocio.BuscarPorId(fila.IdProveedor));
        }

        private void MostrarProveedor(Proveedor proveedor)
        {
            proveedorSeleccionado = proveedor;
            if (proveedor == null)
            {
                return;
            }

            txt_nombre.Text = proveedor.Nombre;
            txt_ssn.Text = proveedor.RegistroSSN;
            txt_cuit.Text = proveedor.Cuit;
            cb_tipos.Text = proveedor.TiposSeguro;
            txt_telefono.Text = proveedor.Telefono;
            txt_email.Text = proveedor.Email;
            txt_sitio.Text = proveedor.SitioWeb;
            txt_direccion.Text = proveedor.Direccion;
            cb_provincia.Text = proveedor.Provincia;
            txt_ciudad.Text = proveedor.Ciudad;

            // el mismo boton sirve para dar de baja o volver a activar
            btn_baja.Text = proveedor.Activo ? "Dar de baja" : "Reactivar";
        }

        // Deja el panel de la derecha vacio para cargar una aseguradora nueva
        private void LimpiarDetalle()
        {
            proveedorSeleccionado = null;

            txt_nombre.Clear();
            txt_ssn.Clear();
            txt_cuit.Clear();
            cb_tipos.SelectedIndex = -1;
            txt_telefono.Clear();
            txt_email.Clear();
            txt_sitio.Clear();
            txt_direccion.Clear();
            cb_provincia.SelectedIndex = -1;
            txt_ciudad.Clear();
            btn_baja.Text = "Dar de baja";
        }

        private void SeleccionarFila(int idProveedor)
        {
            foreach (DataGridViewRow fila in dgv_proveedores.Rows)
            {
                if (((Proveedor)fila.DataBoundItem).IdProveedor == idProveedor)
                {
                    dgv_proveedores.CurrentCell = fila.Cells[0];
                    break;
                }
            }
        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btn_nueva_Click(object sender, EventArgs e)
        {
            dgv_proveedores.ClearSelection();
            LimpiarDetalle();
            txt_nombre.Focus();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            string mensaje;
            bool esNueva = proveedorSeleccionado == null;

            Proveedor proveedor = new Proveedor()
            {
                IdProveedor = esNueva ? 0 : proveedorSeleccionado.IdProveedor,
                Nombre = txt_nombre.Text.Trim(),
                RegistroSSN = txt_ssn.Text.Trim(),
                Cuit = txt_cuit.Text.Trim(),
                TiposSeguro = cb_tipos.Text,
                Telefono = txt_telefono.Text.Trim(),
                Email = txt_email.Text.Trim(),
                SitioWeb = txt_sitio.Text.Trim(),
                Direccion = txt_direccion.Text.Trim(),
                Provincia = cb_provincia.Text,
                Ciudad = txt_ciudad.Text.Trim()
            };

            if (ProveedorNegocio.GuardarProveedor(proveedor, out mensaje))
            {
                MessageBox.Show(esNueva ? "Aseguradora registrada correctamente." : "Los cambios se guardaron correctamente.", "Proveedores", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarDatos();
                SeleccionarFila(proveedor.IdProveedor);
            }
            else
            {
                MessageBox.Show(mensaje, "Proveedores", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_descartar_Click(object sender, EventArgs e)
        {
            if (proveedorSeleccionado != null)
            {
                MostrarProveedor(ProveedorNegocio.BuscarPorId(proveedorSeleccionado.IdProveedor));
            }
            else
            {
                LimpiarDetalle();
            }
        }

        private void btn_baja_Click(object sender, EventArgs e)
        {
            if (proveedorSeleccionado == null)
            {
                MessageBox.Show("No se ha seleccionado ninguna aseguradora.", "Proveedores", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string pregunta = proveedorSeleccionado.Activo
                ? "¿Dar de baja a " + proveedorSeleccionado.Nombre + "?\nNo podrá ofrecer pólizas nuevas hasta que se la reactive."
                : "¿Reactivar a " + proveedorSeleccionado.Nombre + "?";

            DialogResult respuesta = MessageBox.Show(pregunta, "Proveedores", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                if (!ProveedorNegocio.DarDeBajaOReactivar(proveedorSeleccionado))
                {
                    MessageBox.Show("No se pudo cambiar el estado de la aseguradora.", "Proveedores", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                int id = proveedorSeleccionado.IdProveedor;
                CargarDatos();
                SeleccionarFila(id);
            }
        }

        // Pinta la columna Estado con el color que le corresponde
        private void dgv_proveedores_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == col_estado.Index && e.Value != null)
            {
                e.CellStyle.ForeColor = Estilos.ColorEstado(e.Value.ToString());
                e.CellStyle.Font = Estilos.Negrita;
            }
        }
    }
}
