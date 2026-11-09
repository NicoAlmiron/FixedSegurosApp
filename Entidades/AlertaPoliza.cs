using System;

namespace FixedSegurosApp.Entidades
{
    // Una fila de las alertas de Inicio: una póliza que está por vencer o que tiene cuotas vencidas sin pagar
    public class AlertaPoliza
    {
        public int NroPoliza { get; set; }
        public string Cliente { get; set; }
        public string Dominio { get; set; }
        public string Aseguradora { get; set; }
        public DateTime Vence { get; set; }
        public int CuotasVencidas { get; set; }

        // ---------- Propiedades calculadas: no están en la base, las armo para mostrar en la grilla ----------

        public string NroTexto
        {
            get { return NroPoliza.ToString("000000"); }
        }

        // Si tiene las dos cosas muestro la cuota impaga, porque es lo más urgente
        public string Alerta
        {
            get
            {
                if (CuotasVencidas == 1)
                {
                    return "Cuota impaga";
                }
                if (CuotasVencidas > 1)
                {
                    return CuotasVencidas + " cuotas impagas";
                }

                int dias = (Vence.Date - DateTime.Today).Days;

                if (dias == 0)
                {
                    return "Vence hoy";
                }
                return dias == 1 ? "Vence mañana" : "Vence en " + dias + " días";
            }
        }
    }
}
