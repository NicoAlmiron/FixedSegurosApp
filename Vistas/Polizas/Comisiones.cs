using FixedSegurosApp.Entidades;
using FixedSegurosApp.Negocio;
using FixedSegurosApp.Utilidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FixedSegurosApp.Vistas
{
    // Cálculo de comisiones por rango de meses (solo Administrador).
    // "Calcular" solo muestra el resultado; "Guardar arqueo" cierra el rango y marca sus cuotas.
    public partial class Comisiones : Form
    {
        public Comisiones()
        {
            InitializeComponent();
            dgv_cuotas.AutoGenerateColumns = false;
            dgv_arqueos.AutoGenerateColumns = false;
        }

        private void Comisiones_Load(object sender, EventArgs e)
        {
            Estilos.Tarjeta(pnl_filtros);
            Estilos.Tarjeta(pnl_cuotas);
            Estilos.Tarjeta(pnl_arqueos);
            Estilos.Grilla(dgv_cuotas);
            Estilos.Grilla(dgv_arqueos);
            Estilos.BotonPrincipal(btn_calcular);
            Estilos.BotonSecundario(btn_guardar);
            Estilos.BotonSecundario(btn_volver);

            // por defecto, el último mes terminado
            DateTime mesAnterior = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1).AddMonths(-1);
            dtp_desde.Value = mesAnterior;
            dtp_hasta.Value = mesAnterior;

            CargarArqueos();
            Calcular();
        }

        private void CargarArqueos()
        {
            dgv_arqueos.DataSource = ComisionNegocio.ListarArqueos();
        }

        private void Calcular()
        {
            string mensaje;
            List<Pago> cuotas;

            if (!ComisionNegocio.Calcular(dtp_desde.Value, dtp_hasta.Value, out cuotas, out mensaje))
            {
                MessageBox.Show(mensaje, "Comisiones", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            dgv_cuotas.DataSource = cuotas;
            lbl_cuotas_titulo.Text = "Cuotas cobradas de " + dtp_desde.Value.ToString("MM/yyyy") + " a " + dtp_hasta.Value.ToString("MM/yyyy") + " (" + cuotas.Count + ")";
            lbl_total.Text = "Cobrado sin liquidar: $ " + ComisionNegocio.TotalCobrado(cuotas).ToString("N2") + "\n" +
                             "Comisión sin liquidar: $ " + ComisionNegocio.TotalComision(cuotas).ToString("N2");
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            Calcular();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            string mensaje;

            DialogResult respuesta = MessageBox.Show("¿Guardar el arqueo de " + dtp_desde.Value.ToString("MM/yyyy") + " a " + dtp_hasta.Value.ToString("MM/yyyy") + "?\nEs definitivo: esos meses ya no se podrán volver a calcular.", "Guardar arqueo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                if (ComisionNegocio.GuardarArqueo(dtp_desde.Value, dtp_hasta.Value, out mensaje))
                {
                    MessageBox.Show("Arqueo guardado.", "Guardar arqueo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarArqueos();
                    Calcular();
                }
                else
                {
                    MessageBox.Show(mensaje, "Guardar arqueo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        // Clic en un arqueo guardado: arriba se ven sus cuotas
        private void dgv_arqueos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            Arqueo arqueo = (Arqueo)dgv_arqueos.Rows[e.RowIndex].DataBoundItem;
            List<Pago> cuotas = ComisionNegocio.ListarCuotasDeArqueo(arqueo.IdArqueo);

            dgv_cuotas.DataSource = cuotas;
            lbl_cuotas_titulo.Text = "Cuotas del arqueo " + arqueo.NroTexto + " · " + arqueo.Periodo + " (" + cuotas.Count + ")";
            lbl_total.Text = "Cobrado: $ " + arqueo.TotalCobrado.ToString("N2") + "\n" +
                             "Comisión: $ " + arqueo.TotalComision.ToString("N2");
        }

        // Así ninguna fila aparece elegida hasta que se haga clic
        private void dgv_arqueos_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgv_arqueos.ClearSelection();
        }

        // Pinta la columna Liquidación: pendiente o ya incluida en un arqueo
        private void dgv_cuotas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == col_liquidacion.Index && e.Value != null)
            {
                e.CellStyle.ForeColor = e.Value.ToString() == "Sin liquidar" ? Estilos.ColorEstado("Sin liquidar") : Estilos.Exito;
                e.CellStyle.Font = Estilos.Negrita;
            }
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            ((Principal)this.ParentForm).AbrirForm(new Polizas());
        }
    }
}
