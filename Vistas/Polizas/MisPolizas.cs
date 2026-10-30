using FixedSegurosApp.Entidades;
using FixedSegurosApp.Negocio;
using FixedSegurosApp.Utilidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FixedSegurosApp.Vistas
{
    // Pantalla de pólizas del Cliente: a la izquierda sus pólizas, a la derecha contratar una nueva
    // eligiendo uno de sus vehículos aprobados y una de las pólizas ofrecidas para ese tipo de vehículo.
    public partial class MisPolizas : Form
    {
        public MisPolizas()
        {
            InitializeComponent();
            dgv_polizas.AutoGenerateColumns = false;
            dgv_ofrecidas.AutoGenerateColumns = false;
        }

        private void MisPolizas_Load(object sender, EventArgs e)
        {
            Estilos.Tarjeta(pnl_lista);
            Estilos.Tarjeta(pnl_detalle);
            Estilos.Grilla(dgv_polizas);
            Estilos.Grilla(dgv_ofrecidas);
            Estilos.BotonPrincipal(btn_adquirir);

            CargarDatos();
        }

        private void CargarDatos()
        {
            List<Poliza> polizas = PolizaNegocio.ListarMisPolizas();
            dgv_polizas.DataSource = polizas;
            lbl_cantidad.Text = "Mostrando " + polizas.Count + " pólizas";

            // el combo muestra "AB123CD · Fiat Cronos" y guarda el id del vehículo
            List<Vehiculo> vehiculos = PolizaNegocio.ListarVehiculosAsegurables();
            cb_vehiculo.DisplayMember = "Descripcion";
            cb_vehiculo.ValueMember = "IdVehiculo";
            cb_vehiculo.DataSource = vehiculos;

            if (vehiculos.Count == 0)
            {
                dgv_ofrecidas.DataSource = null;
                lbl_oferta.Text = "No tiene vehículos para asegurar.\n\nCargue su vehículo en \"Mis vehículos\" con sus fotos y espere a que un empleado lo apruebe.";
                btn_adquirir.Enabled = false;
            }
        }

        // Al elegir un vehículo se muestran las pólizas ofrecidas para su tipo
        private void cb_vehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Vehiculo vehiculo = cb_vehiculo.SelectedItem as Vehiculo;
            if (vehiculo == null)
            {
                return;
            }

            List<Poliza> ofrecidas = PolizaNegocio.ListarOfrecidas(vehiculo.TipoVehiculo);
            dgv_ofrecidas.DataSource = ofrecidas;
            lbl_ofrecidas.Text = "Pólizas disponibles para " + vehiculo.TipoVehiculo + " (" + ofrecidas.Count + ")";

            if (ofrecidas.Count == 0)
            {
                lbl_oferta.Text = "Por ahora no hay pólizas ofrecidas para este tipo de vehículo.";
                btn_adquirir.Enabled = false;
            }
        }

        // Detalle de la póliza ofrecida elegida, con las cuotas que se van a generar
        private void dgv_ofrecidas_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_ofrecidas.SelectedRows.Count == 0)
            {
                return;
            }

            Poliza poliza = (Poliza)dgv_ofrecidas.SelectedRows[0].DataBoundItem;
            DateTime inicio = PolizaNegocio.CalcularInicio(poliza);

            lbl_oferta.Text = poliza.Aseguradora + " · " + poliza.TipoCobertura + "\n\n" +
                              "Prima " + poliza.TipoPrima.ToLower() + ": $ " + poliza.Prima.ToString("N2") +
                              (poliza.Descuento > 0 ? " (" + poliza.Descuento.ToString("0.##") + " % de descuento)" : "") + "\n" +
                              poliza.CantidadCuotas + " cuotas de $ " + poliza.MontoCuota.ToString("N2") + " · " + poliza.FormaPago + "\n" +
                              "Franquicia: $ " + poliza.Franquicia.ToString("N2") + "\n" +
                              "Vigencia: " + inicio.ToString("dd/MM/yyyy") + " al " + inicio.AddMonths(poliza.Duracion).ToString("dd/MM/yyyy") + " (" + poliza.Duracion + " meses)\n" +
                              (poliza.Adicionales != "" ? "Adicionales: " + poliza.Adicionales + "\n" : "") +
                              (poliza.Requisitos != "" ? "Requisitos: " + poliza.Requisitos : "");
            btn_adquirir.Enabled = true;
        }

        private void btn_adquirir_Click(object sender, EventArgs e)
        {
            string mensaje;
            int nroNueva;

            Vehiculo vehiculo = cb_vehiculo.SelectedItem as Vehiculo;
            if (vehiculo == null || dgv_ofrecidas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Elija un vehículo y una de las pólizas disponibles.", "Pólizas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Poliza poliza = (Poliza)dgv_ofrecidas.SelectedRows[0].DataBoundItem;

            DialogResult respuesta = MessageBox.Show("¿Contratar la póliza " + poliza.TipoCobertura + " de " + poliza.Aseguradora + " para " + vehiculo.Dominio + "?\n" +
                                                     "Se generan " + poliza.CantidadCuotas + " cuotas de $ " + poliza.MontoCuota.ToString("N2") + ".",
                                                     "Adquirir póliza", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta != DialogResult.Yes)
            {
                return;
            }

            if (PolizaNegocio.Adquirir(poliza.NroPoliza, vehiculo.IdVehiculo, out nroNueva, out mensaje))
            {
                MessageBox.Show("Listo. Su póliza es la N° " + nroNueva.ToString("000000") + ".\nPuede ver y pagar las cuotas en \"Pagos\".", "Adquirir póliza", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarDatos();
            }
            else
            {
                MessageBox.Show(mensaje, "Adquirir póliza", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        // Pinta la columna Estado con el color que le corresponde
        private void grilla_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == col_estado.Index && e.Value != null)
            {
                e.CellStyle.ForeColor = Estilos.ColorEstado(e.Value.ToString());
                e.CellStyle.Font = Estilos.Negrita;
            }
        }
    }
}
