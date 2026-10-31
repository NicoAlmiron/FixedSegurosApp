namespace FixedSegurosApp.Entidades
{
    // Foto del daño, denuncia o formulario de un reclamo (se guarda dentro de la base)
    public class AdjuntoSiniestro
    {
        public string Tipo { get; set; }        // Foto / Denuncia / Formulario
        public byte[] Imagen { get; set; }
    }
}
