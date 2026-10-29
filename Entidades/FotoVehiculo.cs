namespace FixedSegurosApp.Entidades
{
    // Una de las 7 fotos del vehículo (Frente, Atrás, ...). La imagen se guarda en la base como bytes.
    public class FotoVehiculo
    {
        public string Posicion { get; set; }
        public byte[] Imagen { get; set; }
    }
}
