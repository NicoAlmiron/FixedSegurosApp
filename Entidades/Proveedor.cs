using System;

namespace FixedSegurosApp.Entidades
{
    // Compañía aseguradora que ofrece pólizas
    public class Proveedor
    {
        public int IdProveedor { get; set; }
        public string Nombre { get; set; }
        public string RegistroSSN { get; set; }     // matrícula de la Superintendencia de Seguros de la Nación
        public string Cuit { get; set; }            // formato 30-12345678-9
        public string TiposSeguro { get; set; }
        public decimal Comision { get; set; }       // porcentaje
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string SitioWeb { get; set; }
        public string Direccion { get; set; }       // calle y número
        public string Ciudad { get; set; }
        public string Provincia { get; set; }
        public DateTime FechaAlta { get; set; }
        public bool Activo { get; set; }

        // Para mostrar en la grilla
        public string Estado
        {
            get { return Activo ? "Activa" : "Inactiva"; }
        }
    }
}
