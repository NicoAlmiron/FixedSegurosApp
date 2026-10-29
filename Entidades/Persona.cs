using System;

namespace FixedSegurosApp.Entidades
{
    public class Persona
    {
        public int Legajo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Dni { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Direccion { get; set; }       // calle y número
        public string Ciudad { get; set; }
        public string Provincia { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public DateTime FechaAlta { get; set; }
        public DateTime? FechaBaja { get; set; }    // el ? permite que quede vacía (null)
        public string ObservacionBaja { get; set; } // motivo de la baja
        public string Estado { get; set; }          // Activo / Suspendido / Baja
        public string Perfil { get; set; }          // Administrador / Empleado / Cliente
        public string EstadoEmpleado { get; set; }  // solo para empleados: Por habilitar / Habilitado / Deshabilitado

        // Para mostrar en las grillas: "García, María"
        public string ApellidoYNombre
        {
            get { return Apellido + ", " + Nombre; }
        }
    }
}
