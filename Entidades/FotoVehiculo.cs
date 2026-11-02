namespace FixedSegurosApp.Entidades
{
    // Una de las fotos del vehículo (Frente, Atrás, ..., Tarjeta verde, VTV). La imagen se guarda en la base como bytes.
    public class FotoVehiculo
    {
        public string Posicion { get; set; }
        public byte[] Imagen { get; set; }
    }
}
