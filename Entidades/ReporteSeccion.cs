using System.Collections.Generic;

namespace FixedSegurosApp.Entidades
{
    // Lo que muestra una pestaña de Reportes: 4 tarjetas, 2 gráficos y una tabla con los datos de los gráficos
    public class ReporteSeccion
    {
        public string Titulo { get; set; }
        public List<TarjetaInicio> Tarjetas { get; set; }
        public GraficoReporte Grafico1 { get; set; }
        public GraficoReporte Grafico2 { get; set; }

        public List<FilaReporte> Tabla
        {
            get
            {
                List<FilaReporte> filas = new List<FilaReporte>(Grafico1.Filas);
                filas.AddRange(Grafico2.Filas);
                return filas;
            }
        }
    }
}
