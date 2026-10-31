using System.Collections.Generic;

namespace FixedSegurosApp.Entidades
{
    // Datos de un gráfico de barras de Reportes
    public class GraficoReporte
    {
        public string Titulo { get; set; }
        public List<FilaReporte> Filas { get; set; }
        public bool PorMonto { get; set; }      // las barras muestran el monto en lugar de la cantidad
        public bool Vertical { get; set; }      // columnas para los meses; barras acostadas para las categorías
    }
}
