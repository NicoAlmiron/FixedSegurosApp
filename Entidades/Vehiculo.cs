using System;

namespace FixedSegurosApp.Entidades
{
    public class Vehiculo
    {
        public int IdVehiculo { get; set; }
        public string Dominio { get; set; }         // patente, guardada sin espacios: AB123CD
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Anio { get; set; }
        public string TipoVehiculo { get; set; }
        public DateTime VigenciaVtv { get; set; }   // hasta cuándo vale la VTV, inclusive
        public string NumeroChasis { get; set; }
        public string NumeroMotor { get; set; }
        public int NroPoliza { get; set; }          // 0 = sin póliza vigente

        // Revisión: un empleado o administrador aprueba el vehículo antes de que pueda tener póliza
        public string EstadoRevision { get; set; }          // Pendiente / Aprobado / Rechazado
        public string ObservacionRevision { get; set; }     // motivo del rechazo
        public string Revisor { get; set; }                 // "Apellido, Nombre" de quien lo revisó
        public DateTime? FechaRevision { get; set; }

        // Renovación de la VTV: el vehículo sigue aprobado mientras un empleado la revisa
        public DateTime? VigenciaVtvNueva { get; set; }     // null = no hay nada para revisar
        public DateTime? FechaEnvioVtv { get; set; }
        public string ObservacionVtv { get; set; }          // motivo del rechazo de la renovación

        public bool VtvVigente
        {
            get { return VigenciaVtv >= DateTime.Today; }
        }

        public bool VtvEnRevision
        {
            get { return VigenciaVtvNueva != null; }
        }

        // Con la VTV vencida el servicio se suspende, salvo que la renovación se haya enviado antes de vencer.
        // La misma regla está en VehiculoDatos.Suspendido, para las consultas.
        public bool ServicioSuspendido
        {
            get { return !VtvVigente && (FechaEnvioVtv == null || FechaEnvioVtv.Value.Date > VigenciaVtv); }
        }

        // Para mostrar en la grilla
        public string MarcaYModelo
        {
            get { return Marca + " " + Modelo; }
        }

        // Para los combos: "AB123CD · Fiat Cronos"
        public string Descripcion
        {
            get { return Dominio + " · " + MarcaYModelo; }
        }

        public string PolizaTexto
        {
            get { return NroPoliza == 0 ? "Sin póliza" : NroPoliza.ToString("000000"); }
        }

        public string VtvTexto
        {
            get
            {
                if (VtvEnRevision)
                {
                    return "VTV en revisión";
                }
                return VtvVigente ? "VTV vigente" : "VTV vencida";
            }
        }
    }
}
