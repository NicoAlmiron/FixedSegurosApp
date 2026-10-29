using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;

namespace FixedSegurosApp.Utilidades
{
    // Fotos que se guardan dentro de la base de datos (como bytes).
    internal class Imagenes
    {
        public const int AnchoMinimo = 640;          // por debajo de esto la foto no es legible
        public const int AltoMinimo = 480;
        public const int LadoMaximo = 1280;          // las fotos más grandes se achican a este tamaño
        public const int PesoMaximo = 500 * 1024;    // 500 KB

        // Lee la foto elegida, controla que sea legible y la deja liviana (JPEG de hasta 500 KB).
        // Devuelve los bytes listos para guardar, o null si no sirve (en "mensaje" queda el motivo).
        public static byte[] PrepararFoto(string ruta, out string mensaje)
        {
            mensaje = "";

            try
            {
                using (Image original = Image.FromFile(ruta))
                {
                    // las fotos acostadas o paradas: se compara el lado mayor con 640 y el menor con 480
                    int ladoMayor = Math.Max(original.Width, original.Height);
                    int ladoMenor = Math.Min(original.Width, original.Height);

                    if (ladoMayor < AnchoMinimo || ladoMenor < AltoMinimo)
                    {
                        mensaje = "La foto es muy chica para verse bien (mínimo " + AnchoMinimo + " x " + AltoMinimo + ").";
                        return null;
                    }

                    // si es más grande que 1280 se achica manteniendo la proporción
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

                        // se guarda en JPEG bajando la calidad hasta que pese 500 KB o menos
                        for (long calidad = 85; calidad >= 50; calidad -= 10)
                        {
                            byte[] bytes = AJpeg(reducida, calidad);
                            if (bytes.Length <= PesoMaximo)
                            {
                                return bytes;
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
                mensaje = "No se pudo leer la foto. Verifique que sea una imagen válida.";
                return null;
            }
        }

        // Convierte los bytes guardados en la base en una imagen para un PictureBox
        public static Image AImagen(byte[] bytes)
        {
            if (bytes == null || bytes.Length == 0)
            {
                return null;
            }

            using (MemoryStream memoria = new MemoryStream(bytes))
            {
                return new Bitmap(Image.FromStream(memoria));
            }
        }

        private static byte[] AJpeg(Image imagen, long calidad)
        {
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

            using (MemoryStream memoria = new MemoryStream())
            {
                imagen.Save(memoria, codecJpeg, parametros);
                return memoria.ToArray();
            }
        }
    }
}
