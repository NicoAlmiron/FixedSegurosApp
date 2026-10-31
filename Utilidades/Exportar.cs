using FixedSegurosApp.Entidades;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace FixedSegurosApp.Utilidades
{
    // Saca los reportes de la pantalla sin librerías externas.
    internal class Exportar
    {
        private const string ImpresoraPdf = "Microsoft Print to PDF";

        // CSV separado por ";" y en UTF-8 con BOM: así Excel respeta las columnas y los acentos
        public static bool GuardarCsv(string ruta, ReporteSeccion seccion, string periodo, out string mensaje)
        {
            mensaje = "";

            List<string> lineas = new List<string>();
            lineas.Add(Linea("Fixed Seguros", "Reportes: " + seccion.Titulo));
            lineas.Add(Linea("Período", periodo));
            lineas.Add("");
            lineas.Add(Linea("Indicador", "Valor", "Detalle"));

            foreach (TarjetaInicio tarjeta in seccion.Tarjetas)
            {
                lineas.Add(Linea(tarjeta.Titulo, tarjeta.Valor, tarjeta.Detalle));
            }

            lineas.Add("");
            lineas.Add(Linea("Grupo", "Detalle", "Cantidad", "Monto"));

            foreach (FilaReporte fila in seccion.Tabla)
            {
                lineas.Add(Linea(fila.Grupo, fila.Detalle, fila.Cantidad.ToString(), fila.MontoTexto));
            }

            try
            {
                File.WriteAllLines(ruta, lineas, new UTF8Encoding(true));
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                mensaje = "No se pudo guardar el archivo. Verifique que no esté abierto en otro programa.";
                return false;
            }
        }

        // Cada campo va entre comillas, por si el texto tiene ";"
        private static string Linea(params string[] campos)
        {
            List<string> partes = new List<string>();

            foreach (string campo in campos)
            {
                partes.Add("\"" + campo.Replace("\"", "\"\"") + "\"");
            }

            return string.Join(";", partes);
        }

        // Imprime una foto de la pantalla en la impresora de PDF de Windows, ajustada a una hoja horizontal
        public static bool GuardarPdf(string ruta, Control pantalla, string titulo, out string mensaje)
        {
            mensaje = "";

            bool hayImpresora = false;
            foreach (string impresora in PrinterSettings.InstalledPrinters)
            {
                if (impresora == ImpresoraPdf)
                {
                    hayImpresora = true;
                }
            }

            if (!hayImpresora)
            {
                mensaje = "Esta computadora no tiene la impresora \"" + ImpresoraPdf + "\". Actívela en Windows o use Exportar CSV.";
                return false;
            }

            try
            {
                using (Bitmap foto = new Bitmap(pantalla.Width, pantalla.Height))
                using (PrintDocument documento = new PrintDocument())
                {
                    pantalla.DrawToBitmap(foto, new Rectangle(0, 0, foto.Width, foto.Height));

                    documento.DocumentName = titulo;
                    documento.PrinterSettings.PrinterName = ImpresoraPdf;
                    documento.PrinterSettings.PrintToFile = true;
                    documento.PrinterSettings.PrintFileName = ruta;
                    documento.DefaultPageSettings.Landscape = true;
                    documento.PrintController = new StandardPrintController();   // sin ventana de "imprimiendo"

                    documento.PrintPage += (sender, e) =>
                    {
                        // se escala manteniendo la proporción para que entre en la hoja
                        double escala = Math.Min((double)e.MarginBounds.Width / foto.Width, (double)e.MarginBounds.Height / foto.Height);
                        e.Graphics.DrawImage(foto, e.MarginBounds.Left, e.MarginBounds.Top, (int)(foto.Width * escala), (int)(foto.Height * escala));
                    };

                    documento.Print();
                }

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                mensaje = "No se pudo generar el PDF. Verifique que el archivo no esté abierto.";
                return false;
            }
        }
    }
}
