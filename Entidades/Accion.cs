using System;

namespace FixedSegurosApp.Entidades
{
    // Una fila del historial de acciones de usuarios
    public class Accion
    {
        public DateTime Fecha { get; set; }
        public string Usuario { get; set; }     // "Apellido, Nombre"
        public string Perfil { get; set; }
        public string Modulo { get; set; }
        public string Operacion { get; set; }   // la acción realizada (C# no deja llamarla "Accion" igual que la clase)
        public string Detalle { get; set; }
    }
}
