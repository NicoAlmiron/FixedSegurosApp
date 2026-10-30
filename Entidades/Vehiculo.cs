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
        public bool VtvVigente { get; set; }
        public string NumeroChasis { get; set; }
        public string NumeroMotor { get; set; }
        public int NroPoliza { get; set; }          // 0 = sin póliza vigente

        // Revisión: un empleado o administrador aprueba el vehículo antes de que pueda tener póliza
        public string EstadoRevision { get; set; }          // Pendiente / Aprobado / Rechazado
        public string ObservacionRevision { get; set; }     // motivo del rechazo
        public string Revisor { get; set; }                 // "Apellido, Nombre" de quien lo revisó
        public DateTime? FechaRevision { get; set; }

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
            get { return VtvVigente ? "VTV vigente" : "VTV vencida"; }
        }
    }
}
