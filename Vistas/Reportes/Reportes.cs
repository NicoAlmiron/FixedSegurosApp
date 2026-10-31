using FixedSegurosApp.Entidades;
using FixedSegurosApp.Negocio;
using FixedSegurosApp.Utilidades;
using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace FixedSegurosApp.Vistas
{
    // Estadísticas del sistema (solo Administrador). Las pestañas no tienen controles propios:
    // todas comparten las tarjetas, los gráficos y la tabla, que se cargan con la sección elegida.
    public partial class Reportes : Form
    {
        private DateTime desde;
        private DateTime hasta;
        private ReporteSeccion seccionActual;

        public Reportes()
        {
            InitializeComponent();
            dgv_datos.AutoGenerateColumns = false;
        }

        private void Reportes_Load(object sender, EventArgs e)
        {
            Estilos.Tarjeta(pnl_tarjeta1);
            Estilos.Tarjeta(pnl_tarjeta2);
            Estilos.Tarjeta(pnl_tarjeta3);
            Estilos.Tarjeta(pnl_tarjeta4);
            Estilos.Grilla(dgv_datos);
            dgv_datos.RowTemplate.Height = 28;
            Estilos.Grafico(chart_1);
            Estilos.Grafico(chart_2);
            Estilos.BotonPrincipal(btn_consultar);
            Estilos.BotonSecundario(btn_csv);
            Estilos.BotonSecundario(btn_pdf);

            // por defecto, el mes actual
            desde = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            hasta = DateTime.Today;
            dtp_desde.Value = desde;
            dtp_hasta.Value = hasta;

            MostrarSeccion();
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            string mensaje;

            if (!ReporteNegocio.ValidarPeriodo(dtp_desde.Value, dtp_hasta.Value, out mensaje))
            {
                MessageBox.Show(mensaje, "Reportes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            desde = dtp_desde.Value.Date;
            hasta = dtp_hasta.Value.Date;
            MostrarSeccion();
        }

        private void tab_secciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarSeccion();
        }

        private void MostrarSeccion()
        {
            seccionActual = ReporteNegocio.ArmarSeccion(tab_secciones.SelectedIndex, desde, hasta);

            MostrarTarjeta(seccionActual.Tarjetas[0], lbl_titulo1, lbl_valor1, lbl_detalle1);
            MostrarTarjeta(seccionActual.Tarjetas[1], lbl_titulo2, lbl_valor2, lbl_detalle2);
            MostrarTarjeta(seccionActual.Tarjetas[2], lbl_titulo3, lbl_valor3, lbl_detalle3);
            MostrarTarjeta(seccionActual.Tarjetas[3], lbl_titulo4, lbl_valor4, lbl_detalle4);

            MostrarGrafico(chart_1, seccionActual.Grafico1);
            MostrarGrafico(chart_2, seccionActual.Grafico2);

            dgv_datos.DataSource = seccionActual.Tabla;
        }

        private void MostrarTarjeta(TarjetaInicio tarjeta, Label titulo, Label valor, Label detalle)
        {
            titulo.Text = tarjeta.Titulo;
            valor.Text = tarjeta.Valor;
            valor.ForeColor = tarjeta.Alerta ? Estilos.Peligro : Estilos.NavyPrincipal;
            detalle.Text = tarjeta.Detalle;
        }

        private void MostrarGrafico(Chart chart, GraficoReporte grafico)
        {
            Series serie = new Series();
            serie.ChartType = grafico.Vertical ? SeriesChartType.Column : SeriesChartType.Bar;
            serie.Color = Estilos.Teal;
            serie.IsVisibleInLegend = false;
            serie["PointWidth"] = "0.5";
            serie.ToolTip = grafico.PorMonto ? "#VALX: $ #VALY{N2}" : "#VALX: #VALY{N0}";

            double mayor = 0;

            // las barras acostadas se dibujan de abajo hacia arriba: se cargan al revés para que la mayor quede arriba
            for (int i = 0; i < grafico.Filas.Count; i++)
            {
                FilaReporte fila = grafico.Filas[grafico.Vertical ? i : grafico.Filas.Count - 1 - i];
                double valor = grafico.PorMonto ? (double)fila.Monto : fila.Cantidad;

                serie.Points.AddXY(fila.Detalle, valor);
                mayor = Math.Max(mayor, valor);
            }

            chart.Series.Clear();
            chart.Series.Add(serie);
            chart.Titles[0].Text = grafico.Filas.Count == 0 ? grafico.Titulo + ": sin datos en el período" : grafico.Titulo;

            Axis ejeX = chart.ChartAreas[0].AxisX;
            Axis ejeY = chart.ChartAreas[0].AxisY;

            ejeX.Interval = 1;      // muestra todas las etiquetas
            ejeY.LabelStyle.Format = "N0";

            // con cantidades chicas el eje marcaría 0,2 - 0,4...: se fuerza de a uno
            ejeY.Interval = !grafico.PorMonto && mayor <= 5 ? 1 : 0;
            chart.ResetAutoValues();
        }

        // Sin fila elegida: la tabla solo se consulta
        private void dgv_datos_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgv_datos.ClearSelection();
        }

        // ================= Exportar =================

        private string TextoPeriodo()
        {
            return desde.ToString("dd/MM/yyyy") + " al " + hasta.ToString("dd/MM/yyyy");
        }

        private string NombreArchivo()
        {
            return "Reporte " + seccionActual.Titulo + " " + desde.ToString("yyyy-MM-dd") + " a " + hasta.ToString("yyyy-MM-dd");
        }

        private void btn_csv_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialogo = new SaveFileDialog();
            dialogo.Title = "Exportar a CSV";
            dialogo.Filter = "Archivo CSV|*.csv";
            dialogo.FileName = NombreArchivo();

            if (dialogo.ShowDialog() == DialogResult.OK)
            {
                string mensaje;

                if (Exportar.GuardarCsv(dialogo.FileName, seccionActual, TextoPeriodo(), out mensaje))
                {
                    MessageBox.Show("Reporte guardado.", "Reportes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(mensaje, "Reportes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btn_pdf_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialogo = new SaveFileDialog();
            dialogo.Title = "Exportar a PDF";
            dialogo.Filter = "Archivo PDF|*.pdf";
            dialogo.FileName = NombreArchivo();

            if (dialogo.ShowDialog() == DialogResult.OK)
            {
                string mensaje;

                if (Exportar.GuardarPdf(dialogo.FileName, this, "Reporte " + seccionActual.Titulo, out mensaje))
                {
                    MessageBox.Show("Reporte guardado.", "Reportes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(mensaje, "Reportes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}
