using FixedSegurosApp.Entidades;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Text;

namespace FixedSegurosApp.Utilidades
{
    // Exporta los reportes a CSV y genera el PDF de la póliza, sin librerías externas.
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

        private static bool HayImpresoraPdf()
        {
            foreach (string impresora in PrinterSettings.InstalledPrinters)
            {
                if (impresora == ImpresoraPdf)
                {
                    return true;
                }
            }
            return false;
        }

        // Dibuja la póliza en una hoja A4 vertical y la imprime en la impresora de PDF de Windows.
        // Se dibuja como texto, no como foto, así el PDF se ve nítido y se puede copiar.
        public static bool GuardarPoliza(string ruta, string numero, List<SeccionDocumento> secciones, out string mensaje)
        {
            mensaje = "";

            if (!HayImpresoraPdf())
            {
                mensaje = "Esta computadora no tiene la impresora \"" + ImpresoraPdf + "\". Actívela en Windows para descargar la póliza.";
                return false;
            }

            try
            {
                using (PrintDocument documento = new PrintDocument())
                {
                    documento.DocumentName = "Póliza " + numero;
                    documento.PrinterSettings.PrinterName = ImpresoraPdf;
                    documento.PrinterSettings.PrintToFile = true;
                    documento.PrinterSettings.PrintFileName = ruta;
                    documento.PrintController = new StandardPrintController();

                    foreach (PaperSize papel in documento.PrinterSettings.PaperSizes)
                    {
                        if (papel.Kind == PaperKind.A4)
                        {
                            documento.DefaultPageSettings.PaperSize = papel;
                        }
                    }

                    documento.PrintPage += (sender, e) => DibujarPoliza(e.Graphics, e.MarginBounds, numero, secciones);
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

        private static void DibujarPoliza(Graphics hoja, Rectangle area, string numero, List<SeccionDocumento> secciones)
        {
            const int columnaValor = 190;

            using (Font fuenteTitulo = new Font("Segoe UI Semibold", 20F))
            using (Font fuenteSeccion = new Font("Segoe UI Semibold", 12F))
            using (Font fuenteNormal = new Font("Segoe UI", 10F))
            using (Font fuentePie = new Font("Segoe UI", 8F))
            using (Brush navy = new SolidBrush(Estilos.NavyPrincipal))
            using (Brush teal = new SolidBrush(Estilos.Teal))
            using (Brush texto = new SolidBrush(Estilos.Texto))
            using (Brush gris = new SolidBrush(Estilos.TextoSecundario))
            using (Pen lineaTeal = new Pen(Estilos.Teal, 2))
            using (Pen lineaBorde = new Pen(Estilos.Borde, 1))
            {
                hoja.DrawImage(Properties.Resources.logo_FS, area.Left, area.Top, 64, 70);
                hoja.DrawString("Póliza de seguro", fuenteTitulo, navy, area.Left + 80, area.Top);
                hoja.DrawString("Fixed Seguros · N° " + numero, fuenteSeccion, teal, area.Left + 80, area.Top + 42);

                int y = area.Top + 84;
                hoja.DrawLine(lineaTeal, area.Left, y, area.Right, y);
                y += 16;

                foreach (SeccionDocumento seccion in secciones)
                {
                    hoja.DrawString(seccion.Titulo, fuenteSeccion, navy, area.Left, y);
                    y += 26;
                    hoja.DrawLine(lineaBorde, area.Left, y, area.Right, y);
                    y += 6;

                    foreach (string[] fila in seccion.Filas)
                    {
                        RectangleF espacio = new RectangleF(area.Left + columnaValor, y, area.Width - columnaValor, 200);
                        int alto = (int)hoja.MeasureString(fila[1], fuenteNormal, (int)espacio.Width).Height;

                        hoja.DrawString(fila[0], fuenteNormal, gris, area.Left, y);
                        hoja.DrawString(fila[1], fuenteNormal, texto, espacio);
                        y += alto + 3;
                    }

                    y += 14;
                }

                hoja.DrawString("Documento generado por Fixed Seguros el " + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + ".",
                                fuentePie, gris, area.Left, area.Bottom - 16);
            }
        }
    }
}
