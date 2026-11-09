using System;

namespace FixedSegurosApp.Entidades
{
    // Un aviso para un cliente; "Leida" dice si él ya lo abrió.
    // Lo pendiente del empleado (siniestros y vehículos por evaluar) usa esta misma clase pero no lo guardo:
    // lo calculo en el momento, por eso no tiene IdNotificacion
    public class Notificacion
    {
        public int IdNotificacion { get; set; }     // 0 si es un pendiente del empleado
        public DateTime? FechaEnvio { get; set; }   // el vehículo no guarda fecha de carga
        public string Mensaje { get; set; }
        public string Tipo { get; set; }            // Por vencer / Cuota impaga / Siniestro / Siniestro por evaluar / Vehículo por evaluar
        public bool Leida { get; set; }             // la vio el cliente
        public int NroPoliza { get; set; }          // 0 si no tiene
        public string Cliente { get; set; }         // "Apellido, Nombre"
        public int LegajoCliente { get; set; }
        public int IdSiniestro { get; set; }        // solo en "Siniestro por evaluar"

        public bool EsPendiente
        {
            get { return IdNotificacion == 0; }
        }

        // ---------- Para mostrar en la grilla ----------

        public string LeidaTexto
        {
            get
            {
                if (EsPendiente)
                {
                    return "-";
                }
                return Leida ? "Sí" : "No";
            }
        }
    }
}
