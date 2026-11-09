using FixedSegurosApp.Entidades;
using FixedSegurosApp.Utilidades;
using System;
using System.Windows.Forms;

namespace FixedSegurosApp.Vistas
{
    // Pantalla simulada de pago con tarjeta (débito automático o tarjeta de crédito).
    // Todavía no hay conexión con bancos: muestro el formulario, pero no se puede completar ni pagar
    public partial class PagoTarjeta : Form
    {
        // Recibo la póliza, la cuota y el método, y armo el título y el resumen
        public PagoTarjeta(Poliza poliza, Pago cuota, string metodo)
        {
            InitializeComponent();

            lbl_titulo.Text = metodo == "Débito automático" ? "Débito automático" : "Tarjeta de crédito o débito";
            lbl_resumen.Text = "Póliza " + poliza.NroTexto + " · Cuota " + cuota.Cuota + " de " + poliza.CantidadCuotas
                             + "\nMonto a pagar: $ " + cuota.Monto.ToString("N2");
        }

        // Aplico los estilos; el botón Pagar queda gris porque está deshabilitado
        private void PagoTarjeta_Load(object sender, EventArgs e)
        {
            Estilos.AjustarVentana(this, 460, 446);
            Estilos.BotonSecundario(btn_cerrar);
            Estilos.BotonPrincipal(btn_pagar);
            btn_pagar.BackColor = Estilos.Borde;     // deshabilitado: no se puede pagar

            lbl_error.BackColor = Estilos.Peligro;

            Estilos.Placeholder(txt_titular, "Como figura en la tarjeta");
            Estilos.Placeholder(txt_numero, "0000 0000 0000 0000");
            Estilos.Placeholder(txt_vencimiento, "MM/AA");
            Estilos.Placeholder(txt_codigo, "CVV");
        }
    }
}
