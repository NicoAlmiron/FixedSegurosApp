using FixedSegurosApp.Entidades;
using FixedSegurosApp.Negocio;
using FixedSegurosApp.Utilidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FixedSegurosApp.Vistas
{
    // A la izquierda la lista, a la derecha el detalle del aviso que se abre con un clic.
    // Cliente: sus avisos; al abrir uno queda leído.
    // Empleado: arriba lo que tiene para evaluar y debajo los avisos de los clientes, con si los vieron.
    public partial class Notificaciones : Form
    {
        private bool esEmpleado;
        private Notificacion notificacionActual;

        public Notificaciones()
        {
            InitializeComponent();
            dgv_notificaciones.AutoGenerateColumns = false;
        }

        private void Notificaciones_Load(object sender, EventArgs e)
        {
            Estilos.Tarjeta(pnl_lista);
            Estilos.Tarjeta(pnl_detalle);
            Estilos.Grilla(dgv_notificaciones);
            Estilos.BotonSecundario(btn_ver);

            esEmpleado = Sesion.UsuarioActual.Perfil == "Empleado";

            if (esEmpleado)
            {
                chk_nuevas.Text = "Solo pendientes";
                lbl_ayuda.Text = "Lo pendiente se muestra arriba, en negrita";
            }
            else
            {
                // el cliente solo ve lo suyo: el dato del cliente no le dice nada
                col_cliente.Visible = false;
                lbl_cliente.Visible = false;
                txt_cliente.Visible = false;
                lbl_fecha.Left = lbl_cliente.Left;
                txt_fecha.Left = txt_cliente.Left;
                txt_fecha.Width = txt_tipo.Width;
            }

            cb_tipo.Items.AddRange(NotificacionNegocio.TiposDe(Sesion.UsuarioActual.Perfil));
            cb_tipo.SelectedIndex = 0;     // al elegirlo se carga la lista
        }

        private void cb_tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarLista();
        }

        private void chk_nuevas_CheckedChanged(object sender, EventArgs e)
        {
            CargarLista();
        }

        private void CargarLista()
        {
            List<Notificacion> lista = NotificacionNegocio.Listar(cb_tipo.Text, chk_nuevas.Checked);

            dgv_notificaciones.DataSource = lista;
            LimpiarDetalle(lista.Count == 0 ? "No hay notificaciones para mostrar." : "Elija una notificación para ver el detalle.");
        }

        // Ninguna fila se elige sola: abrir un aviso es lo que lo marca como leído
        private void dgv_notificaciones_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgv_notificaciones.ClearSelection();
        }

        private void dgv_notificaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            Notificacion notificacion = (Notificacion)dgv_notificaciones.Rows[e.RowIndex].DataBoundItem;

            if (NotificacionNegocio.MarcarLeida(notificacion))
            {
                dgv_notificaciones.InvalidateRow(e.RowIndex);
                ((Principal)this.ParentForm).ActualizarNotificaciones();
            }

            MostrarNotificacion(notificacion);
        }

        private void MostrarNotificacion(Notificacion notificacion)
        {
            notificacionActual = notificacion;

            txt_cliente.Text = notificacion.Cliente;
            txt_fecha.Text = notificacion.FechaEnvio.HasValue ? notificacion.FechaEnvio.Value.ToString("dd/MM/yyyy") : "-";
            txt_tipo.Text = notificacion.Tipo;
            txt_mensaje.Text = notificacion.Mensaje;

            if (notificacion.EsPendiente)
            {
                lbl_estado.Text = "Pendiente de evaluar";
                lbl_estado.ForeColor = Estilos.Advertencia;
            }
            else if (esEmpleado)
            {
                lbl_estado.Text = "Leída por el cliente: " + notificacion.LeidaTexto;
                lbl_estado.ForeColor = notificacion.Leida ? Estilos.Exito : Estilos.TextoSecundario;
            }
            else
            {
                lbl_estado.Text = "Estado: Leída";
                lbl_estado.ForeColor = Estilos.TextoSecundario;
            }

            if (notificacion.IdSiniestro != 0)
            {
                btn_ver.Text = "Ver siniestro";
            }
            else if (notificacion.EsPendiente)
            {
                btn_ver.Text = "Ver detalle del cliente";
            }
            else
            {
                btn_ver.Text = "Ver póliza";
            }

            btn_ver.Visible = notificacion.EsPendiente || notificacion.NroPoliza != 0;
        }

        // El panel queda a la vista, vacío y sin acciones
        private void LimpiarDetalle(string aviso)
        {
            notificacionActual = null;

            txt_cliente.Text = "";
            txt_fecha.Text = "";
            txt_tipo.Text = "";
            txt_mensaje.Text = "";
            lbl_estado.Text = aviso;
            lbl_estado.ForeColor = Estilos.TextoSecundario;

            btn_ver.Visible = false;
        }

        private void btn_ver_Click(object sender, EventArgs e)
        {
            Principal principal = (Principal)this.ParentForm;

            if (notificacionActual.IdSiniestro != 0)
            {
                principal.AbrirForm(new Siniestros(notificacionActual.IdSiniestro));
            }
            else if (notificacionActual.EsPendiente)
            {
                principal.AbrirForm(new DetalleCliente(notificacionActual.LegajoCliente));
            }
            else if (esEmpleado)
            {
                principal.AbrirForm(new Polizas(notificacionActual.NroPoliza));
            }
            else
            {
                principal.AbrirForm(new MisPolizas());
            }
        }

        // En negrita lo que necesita atención: las no leídas del cliente y lo pendiente del empleado
        private void dgv_notificaciones_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Notificacion notificacion = (Notificacion)dgv_notificaciones.Rows[e.RowIndex].DataBoundItem;

            if (esEmpleado ? notificacion.EsPendiente : !notificacion.Leida)
            {
                e.CellStyle.Font = Estilos.Negrita;
            }
        }
    }
}
