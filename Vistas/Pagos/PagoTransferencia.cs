using FixedSegurosApp.Entidades;
using FixedSegurosApp.Utilidades;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace FixedSegurosApp.Vistas
{
    // Pantalla simulada de pago por transferencia: QR y alias de prueba, monto y estado del pago.
    // Todavía no hay conexión con bancos: no se puede subir el comprobante ni confirmar
    public partial class PagoTransferencia : Form
    {
        private const int Modulos = 25;      // cuadritos por lado del QR
        private const int TamanoModulo = 6;  // pixeles de cada cuadrito

        // Recibo la póliza y la cuota, y muestro el resumen y el monto
        public PagoTransferencia(Poliza poliza, Pago cuota)
        {
            InitializeComponent();

            lbl_resumen.Text = "Póliza " + poliza.NroTexto + " · Cuota " + cuota.Cuota + " de " + poliza.CantidadCuotas
                             + "\nVence el " + cuota.FechaVencimiento.ToString("dd/MM/yyyy");
            lbl_monto.Text = "$ " + cuota.Monto.ToString("N2");
        }

        // Aplico los estilos y dibujo el QR
        private void PagoTransferencia_Load(object sender, EventArgs e)
        {
            Estilos.AjustarVentana(this, 460, 466);
            Estilos.BotonSecundario(btn_cerrar);
            Estilos.BotonSecundario(btn_subir);
            Estilos.BotonPrincipal(btn_aceptar);
            btn_aceptar.BackColor = Estilos.Borde;   // deshabilitado: no se puede confirmar

            lbl_error.BackColor = Estilos.Peligro;
            lbl_estado.BackColor = Estilos.ColorEstado("Pendiente");

            pic_qr.Image = DibujarQr();
        }

        // Dibujo un QR de prueba: cuadritos al azar con los tres cuadros de las esquinas. No se puede escanear.
        // Recorro la grilla de 25 x 25 y pinto de negro los cuadritos que corresponden
        private Bitmap DibujarQr()
        {
            Bitmap qr = new Bitmap(Modulos * TamanoModulo, Modulos * TamanoModulo);
            Random azar = new Random(2026);   // semilla fija: siempre el mismo dibujo

            using (Graphics g = Graphics.FromImage(qr))
            {
                g.Clear(Color.White);

                for (int fila = 0; fila < Modulos; fila++)
                {
                    for (int columna = 0; columna < Modulos; columna++)
                    {
                        bool negro = EsEsquina(fila, columna) ? CuadroEsquina(fila, columna) : azar.Next(2) == 0;

                        if (negro)
                        {
                            g.FillRectangle(Brushes.Black, columna * TamanoModulo, fila * TamanoModulo, TamanoModulo, TamanoModulo);
                        }
                    }
                }
            }

            return qr;
        }

        // Las tres esquinas (arriba a la izquierda, arriba a la derecha y abajo a la izquierda) ocupan 8x8 con el borde blanco
        private bool EsEsquina(int fila, int columna)
        {
            bool arriba = fila < 8;
            bool izquierda = columna < 8;
            bool derecha = columna >= Modulos - 8;
            bool abajo = fila >= Modulos - 8;

            return (arriba && izquierda) || (arriba && derecha) || (abajo && izquierda);
        }

        // Dentro de una esquina: cuadro de 7x7 con borde negro, anillo blanco y centro negro de 3x3
        private bool CuadroEsquina(int fila, int columna)
        {
            int f = fila < 8 ? fila : fila - (Modulos - 7);
            int c = columna < 8 ? columna : columna - (Modulos - 7);

            if (f < 0 || c < 0 || f > 6 || c > 6)
            {
                return false;   // separador blanco
            }

            bool borde = f == 0 || f == 6 || c == 0 || c == 6;
            bool centro = f >= 2 && f <= 4 && c >= 2 && c <= 4;
            return borde || centro;
        }
    }
}
