using System;

namespace FixedSegurosApp.Entidades
{
    // Una sola tabla para las pólizas:
    // - "Ofrecida": la crea un Empleado/Administrador, todavía no tiene cliente ni vehículo.
    // - "Vigente": la adquirió un cliente para uno de sus vehículos (es una copia de la ofrecida).
    // - "Baja": dada de baja.
    public class Poliza
    {
        public int NroPoliza { get; set; }
        public int IdProveedor { get; set; }
        public string Aseguradora { get; set; }
        public bool AseguradoraActiva { get; set; }
        public string TipoCobertura { get; set; }
        public string TipoVehiculo { get; set; }
        public string Adicionales { get; set; }
        public DateTime? FechaInicio { get; set; }          // en una ofrecida es la fecha de inicio propuesta
        public DateTime? FechaVencimiento { get; set; }     // se calcula al adquirirla
        public decimal Descuento { get; set; }              // porcentaje
        public int Duracion { get; set; }                   // meses
        public string Requisitos { get; set; }
        public string TipoPrima { get; set; }               // Mensual / Trimestral / Semestral / Anual
        public decimal Prima { get; set; }                  // monto de cada cuota antes del descuento
        public string FormaPago { get; set; }
        public decimal Franquicia { get; set; }
        public decimal Comision { get; set; }               // porcentaje que gana Fixed Seguros sobre cada cuota cobrada
        public int CuotasLiquidadas { get; set; }           // cuotas que ya entraron en un arqueo de comisiones
        public string Estado { get; set; }                  // Ofrecida / Vigente / Baja
        public string Cliente { get; set; }                 // "Apellido, Nombre" (vacío si es ofrecida)
        public string Dominio { get; set; }                 // vacío si es ofrecida
        public int IdVehiculo { get; set; }                 // 0 si es ofrecida

        // ---------- Para mostrar en las grillas ----------

        public string NroTexto
        {
            get { return NroPoliza.ToString("000000"); }
        }

        // Para los combos: "000124 · AB123CD"
        public string Descripcion
        {
            get { return NroTexto + " · " + Dominio; }
        }

        public string ClienteTexto
        {
            get { return Cliente == "" ? "Sin asignar" : Cliente; }
        }

        // Una vigente se muestra "Por vencer" si le quedan 30 días o menos, y "Vencida" si ya pasó la fecha
        public string EstadoMostrado
        {
            get
            {
                if (Estado == "Baja")
                {
                    return "Dada de baja";
                }
                if (Estado == "Vigente" && FechaVencimiento != null)
                {
                    if (FechaVencimiento.Value < DateTime.Today)
                    {
                        return "Vencida";
                    }
                    if (FechaVencimiento.Value <= DateTime.Today.AddDays(30))
                    {
                        return "Por vencer";
                    }
                }
                return Estado;
            }
        }

        // ---------- Cuotas ----------

        // Cada cuántos meses se paga según el tipo de prima
        public int MesesPorCuota
        {
            get
            {
                switch (TipoPrima)
                {
                    case "Trimestral":
                        return 3;
                    case "Semestral":
                        return 6;
                    case "Anual":
                        return 12;
                    default:
                        return 1;   // Mensual
                }
            }
        }

        public int CantidadCuotas
        {
            get { return Duracion / MesesPorCuota; }
        }

        // Prima con el descuento aplicado
        public decimal MontoCuota
        {
            get { return Math.Round(Prima * (100 - Descuento) / 100, 2); }
        }
    }
}
