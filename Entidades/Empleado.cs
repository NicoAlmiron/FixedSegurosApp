using System;

namespace FixedSegurosApp.Entidades
{
    // Un empleado es una Persona con los datos de su trabajo (herencia, como en el UML).
    // Si está habilitado o no lo guardo en Persona.EstadoEmpleado
    public class Empleado : Persona
    {
        public string Puesto { get; set; }
        public DateTime FechaIngreso { get; set; }

        // Lo que muestro en la columna Estado: si la persona fue dada de baja, eso manda sobre la habilitación
        public string EstadoMostrado
        {
            get { return Estado == "Baja" ? "Baja" : EstadoEmpleado; }
        }
    }
}
