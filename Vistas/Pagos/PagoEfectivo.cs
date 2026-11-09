using FixedSegurosApp.Entidades;
using FixedSegurosApp.Negocio;
using FixedSegurosApp.Utilidades;
using System;
using System.Windows.Forms;

namespace FixedSegurosApp.Vistas
{
    // Cobro en efectivo en la oficina (solo el empleado): escribe lo que entrega el cliente y calculo el vuelto
    public partial class PagoEfectivo : Form
    {
        private Poliza poliza;
        private Pago cuota;
        private int legajoCliente;

        // Recibo la póliza, la cuota y el cliente, y muestro el resumen
        public PagoEfectivo(Poliza polizaActual, Pago cuotaActual, int legajo)
        {
            InitializeComponent();
            poliza = polizaActual;
            cuota = cuotaActual;
            legajoCliente = legajo;

            lbl_resumen.Text = "Póliza " + poliza.NroTexto + " · Cuota " + cuota.Cuota + " de " + poliza.CantidadCuotas
                             + "\nVence el " + cuota.FechaVencimiento.ToString("dd/MM/yyyy");
            txt_monto.Text = "$ " + cuota.Monto.ToString("N2");
        }

        // Al abrir la pantalla le aplico los estilos y cargo los datos
        private void PagoEfectivo_Load(object sender, EventArgs e)
        {
            Estilos.AjustarVentana(this, 440, 326);
            Estilos.BotonSecundario(btn_cancelar);
            Estilos.BotonPrincipal(btn_finalizar);
            Estilos.Placeholder(txt_recibido, "0,00");

            MostrarVuelto();
        }

        // Cada vez que cambia el monto escrito recalculo el vuelto
        private void txt_recibido_TextChanged(object sender, EventArgs e)
        {
            MostrarVuelto();
        }

        // Calculo el vuelto con lo que se lleva escrito y habilito "Finalizar pago" solo si alcanza
        private void MostrarVuelto()
        {
            decimal recibido;
            bool esNumero = decimal.TryParse(txt_recibido.Text.Trim(), out recibido);
            bool alcanza = esNumero && recibido >= cuota.Monto;

            txt_vuelto.Text = alcanza ? "$ " + (recibido - cuota.Monto).ToString("N2") : "";
            btn_finalizar.Enabled = alcanza;
            btn_finalizar.BackColor = alcanza ? Estilos.Teal : Estilos.Borde;

            if (txt_recibido.Text.Trim() == "")
            {
                lbl_aviso.ForeColor = Estilos.TextoSecundario;
                lbl_aviso.Text = "Ingrese el dinero que entrega el cliente. El pago queda registrado en efectivo a su nombre.";
            }
            else if (!esNumero)
            {
                lbl_aviso.ForeColor = Estilos.Peligro;
                lbl_aviso.Text = "Ingrese el monto solo con números (por ejemplo 15000,50).";
            }
            else if (!alcanza)
            {
                lbl_aviso.ForeColor = Estilos.Peligro;
                lbl_aviso.Text = "Faltan $ " + (cuota.Monto - recibido).ToString("N2") + " para cubrir la cuota.";
            }
            else
            {
                lbl_aviso.ForeColor = Estilos.Exito;
                lbl_aviso.Text = "Al finalizar, el sistema registra el pago y le asigna un N° de operación, que es el comprobante del cliente.";
            }
        }

        // Registro el pago: Negocio vuelve a controlar el monto y guarda la cuota como pagada en efectivo
        private void btn_finalizar_Click(object sender, EventArgs e)
        {
            string mensaje;
            decimal recibido = decimal.Parse(txt_recibido.Text.Trim());

            if (PagoNegocio.CobrarEnEfectivo(poliza, cuota, recibido, legajoCliente, out mensaje))
            {
                MessageBox.Show("Pago registrado. N° de operación: " + cuota.IdPago.ToString("000000") + ".\nVuelto: " + txt_vuelto.Text + ".", "Cobro en efectivo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
            }
            else
            {
                Avisos.Problema(mensaje, "Cobro en efectivo");
            }
        }
    }
}
