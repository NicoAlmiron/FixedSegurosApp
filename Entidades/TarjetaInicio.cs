namespace FixedSegurosApp.Entidades
{
    // Una de las cuatro tarjetas de resumen de la pantalla Inicio
    public class TarjetaInicio
    {
        public string Titulo { get; set; }
        public string Valor { get; set; }
        public string Detalle { get; set; }
        public bool Alerta { get; set; }        // el valor se pinta de rojo
    }
}
