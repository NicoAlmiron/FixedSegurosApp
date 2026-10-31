using System;

namespace FixedSegurosApp.Entidades
{
    // Reclamo que inicia un cliente sobre una de sus pólizas.
    // Pendiente -> En evaluación -> Aprobado / Rechazado (desde Pendiente también se puede rechazar).
    public class Siniestro
    {
        public int IdSiniestro { get; set; }        // N° de expediente
        public int NroPoliza { get; set; }
        public DateTime FechaOcurrencia { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string TipoSiniestro { get; set; }
        public string Ubicacion { get; set; }
        public string Descripcion { get; set; }
        public string Observaciones { get; set; }   // las escribe el empleado, el cliente las ve
        public string Resultado { get; set; }       // Aprobado / Rechazado
        public string Estado { get; set; }          // Pendiente / En evaluación / Aprobado / Rechazado
        public DateTime? FechaResolucion { get; set; }
        public decimal MontoReclamado { get; set; }
        public string Cliente { get; set; }         // "Apellido, Nombre"
        public string Dominio { get; set; }
        public string EmpleadoResponsable { get; set; }   // vacío hasta que un empleado actúe
        public int CantidadFotos { get; set; }
        public int CantidadDenuncias { get; set; }
        public int CantidadFormularios { get; set; }   // el cliente no lo ve

        // ---------- Para mostrar en las grillas ----------

        public string ExpedienteTexto
        {
            get { return IdSiniestro.ToString("000000"); }
        }

        public string PolizaTexto
        {
            get { return NroPoliza.ToString("000000"); }
        }

        // Solo un reclamo que todavía no se revisó se puede corregir
        public bool EsPendiente
        {
            get { return Estado == "Pendiente"; }
        }

        public bool EstaResuelto
        {
            get { return Estado == "Aprobado" || Estado == "Rechazado"; }
        }
    }
}
