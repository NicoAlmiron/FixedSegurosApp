namespace FixedSegurosApp.Entidades
{
    // Un archivo de un reclamo (foto del daño, denuncia o formulario). La imagen la guardo dentro de la base, como bytes
    public class AdjuntoSiniestro
    {
        public string Tipo { get; set; }        // Foto / Denuncia / Formulario
        public byte[] Imagen { get; set; }
    }
}
