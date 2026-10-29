using System;

namespace FixedSegurosApp.Entidades
{
    // Una cuota de una póliza. Por ahora solo lo que se muestra en el Detalle del cliente (se completa en la Etapa 9)
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
