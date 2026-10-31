namespace FixedSegurosApp.Entidades
{
    // Una fila de la tabla de Reportes: también es una barra de un gráfico
    public class FilaReporte
    {
        public string Grupo { get; set; }       // título del gráfico al que pertenece
        public string Detalle { get; set; }
        public int Cantidad { get; set; }
        public decimal Monto { get; set; }
        public bool TieneMonto { get; set; }

        // ---------- Para mostrar en la grilla ----------

        public string MontoTexto
        {
            get { return TieneMonto ? "$ " + Monto.ToString("N2") : "-"; }
        }
    }
}
