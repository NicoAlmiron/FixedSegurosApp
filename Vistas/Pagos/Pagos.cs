using FixedSegurosApp.Entidades;
using FixedSegurosApp.Negocio;
using FixedSegurosApp.Utilidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FixedSegurosApp.Vistas
{
    // Cuotas de las pólizas de un cliente: a la izquierda las cuotas, a la derecha pagar la que corresponde.
    // El cliente ve las suyas; el empleado busca al cliente por DNI y le cobra en la oficina.
    public partial class Pagos : Form
    {
        private int legajoCliente;
        private int dniInicial;      // el alta en oficina abre la pantalla con el cliente ya buscado
        private List<Pago> cuotas = new List<Pago>();
        private Pago cuotaSeleccionada;

        public Pagos()
        {
            InitializeComponent();
            dgv_cuotas.AutoGenerateColumns = false;
        }

        public Pagos(int dni) : this()
        {
            dniInicial = dni;
        }

        private void Pagos_Load(object sender, EventArgs e)
        {
            Estilos.Tarjeta(pnl_lista);
            Estilos.Tarjeta(pnl_detalle);
            Estilos.Tarjeta(pnl_aviso);
            Estilos.Grilla(dgv_cuotas);
            Estilos.BotonSecundario(btn_buscar);
            Estilos.BotonSecundario(btn_cancelar);
            Estilos.BotonPrincipal(btn_pagar);

            cb_poliza.DisplayMember = "Descripcion";     // muestra "000124 · AB123CD"
            cb_poliza.ValueMember = "NroPoliza";

            if (Sesion.UsuarioActual.Perfil == "Empleado")
            {
                pnl_detalle.Visible = false;
                lbl_cantidad.Text = "Busque al cliente por su DNI.";

                if (dniInicial != 0)
                {
                    txt_dni.Text = dniInicial.ToString();
                    BuscarCliente();
                }
            }
            else
            {
                // el cliente no busca a nadie: el combo de pólizas ocupa el lugar del DNI
                lbl_dni.Visible = false;
                txt_dni.Visible = false;
                btn_buscar.Visible = false;
                lbl_poliza.Left = 16;
                cb_poliza.Left = 62;

                legajoCliente = Sesion.UsuarioActual.Legajo;
                CargarPolizas();
            }
        }

        private void BuscarCliente()
        {
            int dni;
            Persona cliente = null;

            if (int.TryParse(txt_dni.Text.Trim(), out dni))
            {
                cliente = ClienteNegocio.BuscarPorDni(dni);
            }

            if (cliente == null)
            {
                MessageBox.Show("No hay ningún cliente con ese DNI.", "Pagos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            legajoCliente = cliente.Legajo;
            lbl_titulo.Text = "Pagos · " + cliente.ApellidoYNombre;
            CargarPolizas();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            BuscarCliente();
        }

        private void CargarPolizas()
        {
            List<Poliza> polizas = PagoNegocio.ListarPolizasDe(legajoCliente);
            cb_poliza.DataSource = polizas;

            if (polizas.Count == 0)
            {
                cuotas = new List<Pago>();
                dgv_cuotas.DataSource = cuotas;
                lbl_cantidad.Text = "No tiene pólizas contratadas.";
                pnl_detalle.Visible = false;
            }
        }

        private void cb_poliza_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_poliza.SelectedItem is Poliza)
            {
                CargarCuotas();
            }
        }

        // Carga las cuotas de la póliza y deja elegida la que hay que pagar
        private void CargarCuotas()
        {
            Poliza poliza = (Poliza)cb_poliza.SelectedItem;

            cuotas = PagoNegocio.ListarCuotas(poliza.NroPoliza, legajoCliente);
            dgv_cuotas.DataSource = cuotas;
            lbl_cantidad.Text = "Mostrando " + cuotas.Count + " cuotas de la póliza " + poliza.NroTexto;

            pnl_detalle.Visible = cuotas.Count > 0;
            if (cuotas.Count == 0)
            {
                return;
            }

            Pago proxima = PagoNegocio.ProximaCuota(cuotas);
            int fila = proxima != null ? cuotas.IndexOf(proxima) : cuotas.Count - 1;
            dgv_cuotas.CurrentCell = dgv_cuotas.Rows[fila].Cells[0];
            MostrarCuota(cuotas[fila]);
        }

        private void dgv_cuotas_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_cuotas.SelectedRows.Count == 0)
            {
                return;
            }

            MostrarCuota((Pago)dgv_cuotas.SelectedRows[0].DataBoundItem);
        }

        private void MostrarCuota(Pago cuota)
        {
            cuotaSeleccionada = cuota;

            Poliza poliza = (Poliza)cb_poliza.SelectedItem;
            Pago proxima = PagoNegocio.ProximaCuota(cuotas);
            List<string> metodos = PagoNegocio.MetodosDe(poliza);
            bool esLaProxima = proxima != null && proxima.IdPago == cuota.IdPago;
            bool sePuedePagar = esLaProxima && metodos.Count > 0;

            txt_cuota.Text = cuota.Cuota + " de " + poliza.CantidadCuotas;
            txt_vencimiento.Text = cuota.FechaVencimiento.ToString("dd/MM/yyyy");
            txt_monto.Text = "$ " + cuota.Monto.ToString("N2");
            txt_operacion.Text = cuota.Pagada ? cuota.IdPago.ToString("000000") : "Se asigna al confirmar";

            // una cuota pagada muestra su método, aunque sea uno que este usuario no puede elegir
            cb_metodo.Items.Clear();
            if (cuota.Pagada)
            {
                cb_metodo.Items.Add(cuota.MetodoPago);
            }
            else
            {
                cb_metodo.Items.AddRange(metodos.ToArray());
            }
            if (cb_metodo.Items.Count > 0)
            {
                cb_metodo.SelectedIndex = 0;
            }

            lbl_estado.Text = "Cuota " + cuota.Estado.ToLower();
            lbl_estado.BackColor = Estilos.ColorEstado(cuota.Estado);

            if (cuota.Pagada)
            {
                lbl_aviso.Text = "Pagada el " + cuota.FechaPago.Value.ToString("dd/MM/yyyy") + ". El número de operación es su comprobante.";
            }
            else if (!esLaProxima)
            {
                lbl_aviso.Text = "Las cuotas se pagan en orden: primero debe pagar la cuota " + proxima.Cuota + ".";
            }
            else if (metodos.Count == 0)
            {
                lbl_aviso.Text = "Esta póliza se paga en efectivo en la oficina.";
            }
            else if (cuota.Estado == "Vencida")
            {
                lbl_aviso.Text = "Regularice el pago para mantener la cobertura de la póliza. Al confirmar, el sistema registra la operación y le asigna un número.";
            }
            else
            {
                lbl_aviso.Text = "Al confirmar, el sistema registra la operación y le asigna un número.";
            }

            cb_metodo.Enabled = sePuedePagar;
            btn_pagar.Visible = sePuedePagar;
            btn_cancelar.Visible = sePuedePagar;
        }

        private void btn_pagar_Click(object sender, EventArgs e)
        {
            string mensaje;
            Poliza poliza = (Poliza)cb_poliza.SelectedItem;
            int idPago = cuotaSeleccionada.IdPago;

            DialogResult respuesta = MessageBox.Show("¿Pagar la cuota " + cuotaSeleccionada.Cuota + " de la póliza " + poliza.NroTexto + " por $ " + cuotaSeleccionada.Monto.ToString("N2") + " con " + cb_metodo.Text + "?", "Pagar cuota", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                if (PagoNegocio.Pagar(poliza, idPago, cb_metodo.Text, legajoCliente, out mensaje))
                {
                    MessageBox.Show("Pago registrado. N° de operación: " + idPago.ToString("000000") + ".", "Pagar cuota", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarCuotas();
                }
                else
                {
                    MessageBox.Show(mensaje, "Pagar cuota", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        // Vuelve a la cuota que corresponde pagar
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            CargarCuotas();
        }

        // Pinta la columna Estado con el color que le corresponde
        private void dgv_cuotas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == col_estado.Index && e.Value != null)
            {
                e.CellStyle.ForeColor = Estilos.ColorEstado(e.Value.ToString());
                e.CellStyle.Font = Estilos.Negrita;
            }
        }
    }
}
