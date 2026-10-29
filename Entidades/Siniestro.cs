using System;

namespace FixedSegurosApp.Entidades
{
    // Por ahora solo los datos que se muestran en el Detalle del cliente (se completa en la Etapa 10)
    public class Siniestro
    {
        public int IdSiniestro { get; set; }        // N° de expediente
        public int NroPoliza { get; set; }
        public DateTime FechaOcurrencia { get; set; }
        public string TipoSiniestro { get; set; }
        public decimal MontoReclamado { get; set; }
        public string Estado { get; set; }          // Pendiente / En evaluación / Aprobado / Rechazado
    }
}
