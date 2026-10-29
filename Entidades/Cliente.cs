namespace FixedSegurosApp.Entidades
{
    // Cliente es una Persona con datos propios (herencia, como en el diagrama UML)
    public class Cliente : Persona
    {
        public string Observaciones { get; set; }
    }
}
