using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;

namespace FixedSegurosApp.Utilidades
{
    // Acá preparo las fotos que se guardan dentro de la base de datos (como bytes)
    // y las vuelvo a convertir en imagen para mostrarlas.
    internal class Imagenes
    {
        public const int AnchoMinimo = 640;          // por debajo de esto la foto no se ve bien
        public const int AltoMinimo = 480;
        public const int LadoMaximo = 1280;          // las fotos más grandes las achico a este tamaño
        public const int PesoMaximo = 300 * 1024;    // 300 KB por foto, para no llenar la base (somee da 30 MB)

        // Leo la foto elegida, controlo que sea legible y la dejo liviana (JPEG de hasta 300 KB).
        // Devuelvo los bytes listos para guardar, o null si no sirve (en "mensaje" queda el motivo).
        public static byte[] PrepararFoto(string ruta, out string mensaje)
        {
            mensaje = "";

            try
            {
                byte[] archivo = File.ReadAllBytes(ruta);

                using (Image original = Image.FromFile(ruta))
                {
                    // comparo el lado mayor con 640 y el menor con 480, así sirven fotos acostadas o paradas
                    int ladoMayor = Math.Max(original.Width, original.Height);
                    int ladoMenor = Math.Min(original.Width, original.Height);

                    if (ladoMayor < AnchoMinimo || ladoMenor < AltoMinimo)
                    {
                        mensaje = "La foto es muy chica para verse bien (mínimo " + AnchoMinimo + " x " + AltoMinimo + ").";
                        return null;
                    }

                    // si es más grande que 1280 la achico manteniendo la proporción
                    double escala = Math.Min(1.0, (double)LadoMaximo / ladoMayor);
                    int ancho = (int)(original.Width * escala);
                    int alto = (int)(original.Height * escala);

                    using (Bitmap reducida = new Bitmap(ancho, alto))
                    {
                        using (Graphics g = Graphics.FromImage(reducida))
                        {
                            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                            g.DrawImage(original, 0, 0, ancho, alto);
                        }

                        // la paso a JPEG empezando con calidad 75 (a simple vista no se nota la diferencia con 85
                        // y pesa un 25% menos). Si todavía pesa más de 300 KB, voy bajando la calidad de a 10.
                        for (long calidad = 75; calidad >= 45; calidad -= 10)
                        {
                            byte[] bytes = AJpeg(reducida, calidad);

                            if (bytes.Length <= PesoMaximo)
                            {
                                // si el original ya era un JPEG chico, volver a comprimirlo lo agranda:
                                // en ese caso me quedo con el archivo tal cual vino
                                bool originalSirve = original.RawFormat.Equals(ImageFormat.Jpeg) && escala == 1.0 && archivo.Length < bytes.Length;
                                return originalSirve ? archivo : bytes;
                            }
                        }
                    }
                }

                mensaje = "La foto pesa demasiado aun reduciendo la calidad.";
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                mensaje = "La foto no se puede leer. Verifique que sea una imagen válida.";
                return null;
            }
        }

        // Convierto los bytes guardados en la base en una imagen para un PictureBox
        public static Image AImagen(byte[] bytes)
        {
            if (bytes == null || bytes.Length == 0)
            {
                return null;
            }

            using (MemoryStream memoria = new MemoryStream(bytes))
            {
                // la copio a un Bitmap para poder cerrar el MemoryStream sin que la imagen se rompa
                return new Bitmap(Image.FromStream(memoria));
            }
        }

        // Guardo la imagen como JPEG con la calidad que me piden (0 a 100) y devuelvo sus bytes
        private static byte[] AJpeg(Image imagen, long calidad)
        {
            // busco, entre los formatos que sabe guardar Windows, el de JPEG
            ImageCodecInfo codecJpeg = null;
            foreach (ImageCodecInfo codec in ImageCodecInfo.GetImageEncoders())
            {
                if (codec.FormatID == ImageFormat.Jpeg.Guid)
                {
                    codecJpeg = codec;
                }
            }

            EncoderParameters parametros = new EncoderParameters(1);
            parametros.Param[0] = new EncoderParameter(Encoder.Quality, calidad);

            // el MemoryStream es como un archivo en memoria: guardo ahí la imagen y saco los bytes
            using (MemoryStream memoria = new MemoryStream())
            {
                imagen.Save(memoria, codecJpeg, parametros);
                return memoria.ToArray();
            }
        }
    }
}
