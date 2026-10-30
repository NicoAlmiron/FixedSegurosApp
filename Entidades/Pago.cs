using System;

namespace FixedSegurosApp.Entidades
{
    // Una cuota de una póliza
    public class Pago
    {
        public int IdPago { get; set; }             // N° de operación
        public int NroPoliza { get; set; }
        public int Cuota { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public decimal Monto { get; set; }
        public DateTime? FechaPago { get; set; }
        public string MetodoPago { get; set; }
        public bool Pagada { get; set; }

        // Datos para el cálculo de comisiones
        public string Cliente { get; set; }
        public string Aseguradora { get; set; }
        public decimal PorcentajeComision { get; set; }
        public int IdArqueo { get; set; }           // 0 = comisión sin liquidar

        public decimal Comision
        {
            get { return Math.Round(Monto * PorcentajeComision / 100, 2); }
        }

        public string Liquidacion
        {
            get { return IdArqueo == 0 ? "Sin liquidar" : "Arqueo " + IdArqueo.ToString("000000"); }
        }

        // Pagada, o Vencida si ya pasó la fecha, o Pendiente
        public string Estado
        {
            get
            {
                if (Pagada)
                {
                    return "Pagada";
                }
                return FechaVencimiento < DateTime.Today ? "Vencida" : "Pendiente";
            }
        }
    }
}
