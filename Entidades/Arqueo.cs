using System;

namespace FixedSegurosApp.Entidades
{
    // Un cierre de comisiones de un rango de meses (lo guarda el administrador).
    // Las cuotas que entran en el arqueo quedan marcadas con Pago.idArqueo, así no se liquidan dos veces
    public class Arqueo
    {
        public int IdArqueo { get; set; }
        public DateTime Desde { get; set; }         // primer día del primer mes
        public DateTime Hasta { get; set; }         // último día del último mes
        public DateTime FechaCalculo { get; set; }
        public string Usuario { get; set; }         // "Apellido, Nombre" de quien lo guardó
        public decimal TotalCobrado { get; set; }
        public decimal TotalComision { get; set; }

        // Textos armados para mostrar en la grilla
        public string NroTexto
        {
            get { return IdArqueo.ToString("000000"); }
        }

        public string Periodo
        {
            get { return Desde.ToString("MM/yyyy") + " a " + Hasta.ToString("MM/yyyy"); }
        }
    }
}
