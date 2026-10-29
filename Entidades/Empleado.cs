using System;

namespace FixedSegurosApp.Entidades
{
    // Empleado es una Persona con datos de la relación laboral (herencia, como en el diagrama UML).
    // El estado de habilitación está en Persona.EstadoEmpleado.
    public class Empleado : Persona
    {
        public string Puesto { get; set; }
        public DateTime FechaIngreso { get; set; }

        // Lo que se muestra en la columna Estado: si la persona fue dada de baja, eso manda
        public string EstadoMostrado
        {
            get { return Estado == "Baja" ? "Baja" : EstadoEmpleado; }
        }
    }
}
