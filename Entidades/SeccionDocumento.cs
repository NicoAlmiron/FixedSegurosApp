using System.Collections.Generic;

namespace FixedSegurosApp.Entidades
{
    // Un bloque del PDF de la póliza: un título y sus filas { dato, valor }
    public class SeccionDocumento
    {
        public string Titulo { get; set; }
        public List<string[]> Filas { get; set; } = new List<string[]>();

        // Agrego una fila al bloque
        public void Agregar(string dato, string valor)
        {
            Filas.Add(new string[] { dato, valor });
        }
    }
}
