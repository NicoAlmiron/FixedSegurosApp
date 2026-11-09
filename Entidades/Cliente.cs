namespace FixedSegurosApp.Entidades
{
    // Un cliente es una Persona con sus datos propios (uso herencia, como en el diagrama UML)
    public class Cliente : Persona
    {
        public string Observaciones { get; set; }
    }
}
