using FixedSegurosApp.Entidades;
using FixedSegurosApp.Negocio;
using FixedSegurosApp.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace FixedSegurosApp.Vistas
{
    // ABM de pólizas (Administrador y Empleado).
    // Se cargan pólizas "Ofrecidas"; el cliente las adquiere desde su pantalla (MisPolizas).
    public partial class Polizas : Form
    {
        private BindingList<Poliza> listaPolizas = new BindingList<Poliza>();
        private Poliza polizaSeleccionada;   // null = se está cargando una póliza nueva
        private int nroInicial;

        public Polizas()
        {
            InitializeComponent();
            dgv_polizas.AutoGenerateColumns = false;
            dgv_polizas.DataSource = listaPolizas;
        }

        // Notificaciones abre la pantalla con la póliza ya buscada
        public Polizas(int nroPoliza) : this()
        {
            nroInicial = nroPoliza;
        }

        private void Polizas_Load(object sender, EventArgs e)
        {
            Estilos.Tarjeta(pnl_lista);
            Estilos.Tarjeta(pnl_detalle);
            Estilos.Grilla(dgv_polizas);
            Estilos.BotonPrincipal(btn_nueva);
            Estilos.BotonSecundario(btn_comision);
            Estilos.BotonPrincipal(btn_alta);
            Estilos.BotonPeligro(btn_baja);
            Estilos.BotonSecundario(btn_descartar);
            Estilos.BotonPrincipal(btn_guardar);
            Estilos.Placeholder(txt_buscar, "Buscar por N° de póliza, DNI o dominio");
            Estilos.Placeholder(txt_prima, "$ 45000");
            Estilos.Placeholder(txt_descuento, "10 %");
            Estilos.Placeholder(txt_franquicia, "$ 80000");
            Estilos.Placeholder(txt_comision, "12 %");
            Estilos.Placeholder(txt_adicionales, "Cristales, grúa...");

            // las ganancias de la empresa solo las ve el Administrador
            btn_comision.Visible = Sesion.UsuarioActual.Perfil == "Administrador";

            // la atención en la oficina la hace el empleado
            btn_alta.Visible = Sesion.UsuarioActual.Perfil == "Empleado";

            // todas las aseguradoras (si se elige una inactiva, Negocio avisa que no puede ofrecer pólizas)
            cb_aseguradora.DisplayMember = "Nombre";
            cb_aseguradora.ValueMember = "IdProveedor";
            cb_aseguradora.DataSource = ProveedorNegocio.ListarProveedores("");

            if (nroInicial != 0)
            {
                txt_buscar.Text = nroInicial.ToString();    // busca solo, con txt_buscar_TextChanged
            }
            else
            {
                CargarDatos();
            }
        }

        public void CargarDatos()
        {
            CargarLista(PolizaNegocio.ListarPolizas(txt_buscar.Text));
        }

        private void CargarLista(List<Poliza> resultado)
        {
            listaPolizas.Clear();
            foreach (Poliza p in resultado)
            {
                listaPolizas.Add(p);
            }
            lbl_cantidad.Text = "Mostrando " + listaPolizas.Count + " pólizas";

            if (listaPolizas.Count == 0)
            {
                LimpiarDetalle();
            }
        }

        private void dgv_polizas_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_polizas.SelectedRows.Count == 0)
            {
                return;
            }

            Poliza fila = (Poliza)dgv_polizas.SelectedRows[0].DataBoundItem;
            MostrarPoliza(PolizaNegocio.BuscarPorNro(fila.NroPoliza));
        }

        private void MostrarPoliza(Poliza poliza)
        {
            polizaSeleccionada = poliza;
            if (poliza == null)
            {
                return;
            }

            lbl_detalle_titulo.Text = "Datos de la póliza " + poliza.NroTexto;
            cb_aseguradora.SelectedValue = poliza.IdProveedor;
            cb_cobertura.Text = poliza.TipoCobertura;
            cb_tipo_vehiculo.Text = poliza.TipoVehiculo;
            cb_tipo_prima.Text = poliza.TipoPrima;
            txt_prima.Text = poliza.Prima.ToString("0.##");
            cb_forma_pago.Text = poliza.FormaPago;
            txt_descuento.Text = poliza.Descuento.ToString("0.##");
            txt_duracion.Text = poliza.Duracion.ToString();
            dtp_inicio.Value = poliza.FechaInicio.Value;
            txt_franquicia.Text = poliza.Franquicia.ToString("0.##");
            txt_comision.Text = poliza.Comision.ToString("0.##");
            txt_adicionales.Text = poliza.Adicionales;
            txt_requisitos.Text = poliza.Requisitos;

            string cuotas = poliza.CantidadCuotas + " cuotas de $ " + poliza.MontoCuota.ToString("N2");

            if (poliza.Estado == "Ofrecida")
            {
                lbl_info.Text = "Póliza ofrecida: la puede contratar un cliente con un " + poliza.TipoVehiculo + " aprobado.\n" + cuotas + " (prima con descuento).";
            }
            else
            {
                lbl_info.Text = "Contratada por " + poliza.Cliente + " para el vehículo " + poliza.Dominio + ".\n" +
                                "Vigencia: " + poliza.FechaInicio.Value.ToString("dd/MM/yyyy") + " al " + poliza.FechaVencimiento.Value.ToString("dd/MM/yyyy") + " · " + cuotas + "\n" +
                                "Una póliza contratada solo se puede dar de baja.";

                if (Sesion.UsuarioActual.Perfil == "Administrador")
                {
                    lbl_info.Text += "\nCuotas liquidadas: " + poliza.CuotasLiquidadas + " de " + poliza.CantidadCuotas + ".";
                }
            }

            // solo se editan las ofrecidas; una dada de baja tampoco se puede volver a dar de baja
            Bloquear(poliza.Estado != "Ofrecida");
            btn_baja.Enabled = poliza.Estado != "Baja";
        }

        // Deja el panel de la derecha vacío para cargar una póliza nueva
        private void LimpiarDetalle()
        {
            polizaSeleccionada = null;

            lbl_detalle_titulo.Text = "Nueva póliza";
            cb_aseguradora.SelectedIndex = -1;
            cb_cobertura.SelectedIndex = -1;
            cb_tipo_vehiculo.SelectedIndex = -1;
            cb_tipo_prima.SelectedIndex = -1;
            txt_prima.Clear();
            cb_forma_pago.SelectedIndex = -1;
            txt_descuento.Clear();
            txt_duracion.Clear();
            dtp_inicio.Value = DateTime.Today;
            txt_franquicia.Clear();
            txt_comision.Clear();
            txt_adicionales.Clear();
            txt_requisitos.Clear();
            lbl_info.Text = "La póliza queda como \"Ofrecida\" hasta que un cliente la contrate para un vehículo aprobado.";

            Bloquear(false);
            btn_baja.Enabled = true;
        }

        // Con una póliza contratada o dada de baja no se puede tocar nada
        private void Bloquear(bool bloqueado)
        {
            cb_aseguradora.Enabled = !bloqueado;
            cb_cobertura.Enabled = !bloqueado;
            cb_tipo_vehiculo.Enabled = !bloqueado;
            cb_tipo_prima.Enabled = !bloqueado;
            txt_prima.ReadOnly = bloqueado;
            cb_forma_pago.Enabled = !bloqueado;
            txt_descuento.ReadOnly = bloqueado;
            txt_duracion.ReadOnly = bloqueado;
            dtp_inicio.Enabled = !bloqueado;
            txt_franquicia.ReadOnly = bloqueado;
            txt_comision.ReadOnly = bloqueado;
            txt_adicionales.ReadOnly = bloqueado;
            txt_requisitos.ReadOnly = bloqueado;
            btn_guardar.Visible = !bloqueado;
            btn_descartar.Visible = !bloqueado;
        }

        private void SeleccionarFila(int nroPoliza)
        {
            foreach (DataGridViewRow fila in dgv_polizas.Rows)
            {
                if (((Poliza)fila.DataBoundItem).NroPoliza == nroPoliza)
                {
                    dgv_polizas.CurrentCell = fila.Cells[0];
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
            dgv_polizas.ClearSelection();
            LimpiarDetalle();
            cb_aseguradora.Focus();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            string mensaje;
            bool esNueva = polizaSeleccionada == null;

            Poliza poliza = new Poliza()
            {
                NroPoliza = esNueva ? 0 : polizaSeleccionada.NroPoliza,
                IdProveedor = cb_aseguradora.SelectedValue == null ? 0 : (int)cb_aseguradora.SelectedValue,
                TipoCobertura = cb_cobertura.Text,
                TipoVehiculo = cb_tipo_vehiculo.Text,
                TipoPrima = cb_tipo_prima.Text,
                FormaPago = cb_forma_pago.Text,
                FechaInicio = dtp_inicio.Value.Date,
                Adicionales = txt_adicionales.Text.Trim(),
                Requisitos = txt_requisitos.Text.Trim()
            };

            if (PolizaNegocio.GuardarPoliza(poliza, txt_prima.Text.Trim(), txt_descuento.Text.Trim(), txt_duracion.Text.Trim(), txt_franquicia.Text.Trim(), txt_comision.Text.Trim(), out mensaje))
            {
                MessageBox.Show(esNueva ? "Póliza " + poliza.NroTexto + " creada. Ya la pueden contratar los clientes." : "Los cambios se guardaron correctamente.", "Pólizas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_buscar.Clear();   // para que la póliza aparezca aunque hubiera una búsqueda escrita
                CargarDatos();
                SeleccionarFila(poliza.NroPoliza);
            }
            else
            {
                MessageBox.Show(mensaje, "Pólizas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_descartar_Click(object sender, EventArgs e)
        {
            if (polizaSeleccionada != null)
            {
                MostrarPoliza(PolizaNegocio.BuscarPorNro(polizaSeleccionada.NroPoliza));
            }
            else
            {
                LimpiarDetalle();
            }
        }

        private void btn_baja_Click(object sender, EventArgs e)
        {
            string mensaje;

            if (polizaSeleccionada == null)
            {
                MessageBox.Show("No se ha seleccionado ninguna póliza.", "Pólizas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string pregunta = polizaSeleccionada.Estado == "Ofrecida"
                ? "¿Dar de baja la póliza " + polizaSeleccionada.NroTexto + "?\nLos clientes ya no podrán contratarla."
                : "¿Dar de baja la póliza " + polizaSeleccionada.NroTexto + " de " + polizaSeleccionada.Cliente + "?\nEl vehículo " + polizaSeleccionada.Dominio + " queda sin cobertura y se anulan las cuotas que todavía no vencieron.";

            DialogResult respuesta = MessageBox.Show(pregunta, "Pólizas", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                if (!PolizaNegocio.DarDeBaja(polizaSeleccionada, out mensaje))
                {
                    MessageBox.Show(mensaje, "Pólizas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                int nro = polizaSeleccionada.NroPoliza;
                CargarDatos();
                SeleccionarFila(nro);
            }
        }

        private void btn_alta_Click(object sender, EventArgs e)
        {
            ((Principal)this.ParentForm).AbrirForm(new AltaOficina());
        }

        private void btn_comision_Click(object sender, EventArgs e)
        {
            ((Principal)this.ParentForm).AbrirForm(new Comisiones());
        }

        // Pinta la columna Estado con el color que le corresponde
        private void dgv_polizas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == col_estado.Index && e.Value != null)
            {
                e.CellStyle.ForeColor = Estilos.ColorEstado(e.Value.ToString());
                e.CellStyle.Font = Estilos.Negrita;
            }
        }
    }
}
