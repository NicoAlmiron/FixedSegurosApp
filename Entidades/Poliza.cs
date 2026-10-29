using System;

namespace FixedSegurosApp.Entidades
{
    // Por ahora solo los datos que se muestran en el Detalle del cliente (se completa en la Etapa 8)
    public class Poliza
    {
        public int NroPoliza { get; set; }
        public string Aseguradora { get; set; }
        public string Dominio { get; set; }
        public string TipoCobertura { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaVencimiento { get; set; }
        public string Estado { get; set; }          // Ofrecida / Vigente / Baja
    }
}
