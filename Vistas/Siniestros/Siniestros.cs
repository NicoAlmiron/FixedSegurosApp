using FixedSegurosApp.Entidades;
using FixedSegurosApp.Negocio;
using FixedSegurosApp.Utilidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FixedSegurosApp.Vistas
{
    // Pantalla de siniestros del Empleado: arriba los reclamos, abajo la verificación de la documentación
    // y a la derecha los datos. El empleado verifica, pasa a evaluación y carga el resultado de la aseguradora.
    // "Nuevo reclamo" abre MisSiniestros para cargar uno en la oficina.
    public partial class Siniestros : Form
    {
        private Siniestro siniestroActual;
        private int idInicial;      // Notificaciones abre la pantalla con el expediente ya elegido

        public Siniestros()
        {
            InitializeComponent();
            dgv_siniestros.AutoGenerateColumns = false;
        }

        public Siniestros(int idSiniestro) : this()
        {
            idInicial = idSiniestro;
        }

        private void Siniestros_Load(object sender, EventArgs e)
        {
            Estilos.Tarjeta(pnl_lista);
            Estilos.Tarjeta(pnl_verificacion);
            Estilos.Tarjeta(pnl_detalle);
            Estilos.Grilla(dgv_siniestros);
            Estilos.BotonPrincipal(btn_nuevo);
            Estilos.BotonSecundario(btn_ver_fotos);
            Estilos.BotonSecundario(btn_ver_denuncia);
            Estilos.BotonSecundario(btn_ver_formulario);
            Estilos.BotonPrincipal(btn_cargar_formulario);
            Estilos.BotonSecundario(btn_guardar_observaciones);
            Estilos.BotonPeligro(btn_rechazar);
            Estilos.BotonPrincipal(btn_evaluar);
            Estilos.BotonPrincipal(btn_aprobar);

            cb_estado.Items.AddRange(SiniestroNegocio.Estados);
            cb_estado.SelectedIndex = 0;     // al elegirlo se carga la lista

            if (idInicial != 0)
            {
                CargarLista(idInicial);
            }
        }

        private void cb_estado_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarLista(0);
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            ((Principal)this.ParentForm).AbrirForm(new MisSiniestros());
        }

        // Carga la lista y deja elegido el reclamo idElegir (el primero si no está)
        private void CargarLista(int idElegir)
        {
            List<Siniestro> siniestros = SiniestroNegocio.ListarSiniestros(cb_estado.Text);

            dgv_siniestros.DataSource = siniestros;
            lbl_cantidad.Text = "Mostrando " + siniestros.Count + (siniestros.Count == 1 ? " reclamo" : " reclamos");

            if (siniestros.Count == 0)
            {
                LimpiarDetalle();
                return;
            }

            int fila = 0;
            for (int i = 0; i < siniestros.Count; i++)
            {
                if (siniestros[i].IdSiniestro == idElegir)
                {
                    fila = i;
                }
            }

            dgv_siniestros.CurrentCell = dgv_siniestros.Rows[fila].Cells[0];
            MostrarSiniestro(siniestros[fila]);
        }

        private void dgv_siniestros_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_siniestros.SelectedRows.Count == 0)
            {
                return;
            }

            MostrarSiniestro((Siniestro)dgv_siniestros.SelectedRows[0].DataBoundItem);
        }

        // Sin reclamos en la lista los paneles quedan a la vista, vacíos y sin acciones
        private void LimpiarDetalle()
        {
            siniestroActual = null;

            foreach (TextBox campo in new TextBox[] { txt_cliente, txt_poliza, txt_tipo, txt_fecha, txt_ubicacion, txt_monto, txt_responsable, txt_descripcion, txt_observaciones })
            {
                campo.Text = "";
            }

            lbl_fotos.Text = "Fotos del daño: -";
            lbl_denuncia.Text = "Denuncia: -";
            lbl_formulario.Text = "Formulario: -";
            lbl_verificacion_titulo.Text = "Verificación de la documentación";
            lbl_estado.Text = "No hay reclamos para mostrar.";
            lbl_estado.ForeColor = Estilos.TextoSecundario;
            txt_observaciones.ReadOnly = true;

            foreach (CheckBox control in new CheckBox[] { chk_fotos, chk_denuncia, chk_poliza })
            {
                control.Enabled = false;
                control.Checked = false;
            }

            btn_evaluar.Visible = false;
            btn_aprobar.Visible = false;
            btn_rechazar.Visible = false;
            btn_guardar_observaciones.Visible = false;
            btn_ver_fotos.Enabled = false;
            btn_ver_denuncia.Enabled = false;
            btn_ver_formulario.Enabled = false;
            btn_cargar_formulario.Visible = false;
        }

        private void MostrarSiniestro(Siniestro siniestro)
        {
            siniestroActual = siniestro;
            btn_ver_fotos.Enabled = true;
            btn_ver_denuncia.Enabled = true;

            txt_cliente.Text = siniestro.Cliente;
            txt_poliza.Text = siniestro.PolizaTexto + " · " + siniestro.Dominio;
            txt_tipo.Text = siniestro.TipoSiniestro;
            txt_fecha.Text = siniestro.FechaOcurrencia.ToString("dd/MM/yyyy");
            txt_ubicacion.Text = siniestro.Ubicacion;
            txt_monto.Text = "$ " + siniestro.MontoReclamado.ToString("N2");
            txt_responsable.Text = siniestro.EmpleadoResponsable == "" ? "Sin asignar" : siniestro.EmpleadoResponsable;
            txt_descripcion.Text = siniestro.Descripcion;

            lbl_fotos.Text = "Fotos del daño: " + siniestro.CantidadFotos + (siniestro.CantidadFotos == 1 ? " archivo" : " archivos");
            lbl_denuncia.Text = "Denuncia: " + siniestro.CantidadDenuncias + " archivo";
            lbl_formulario.Text = "Formulario: " + siniestro.CantidadFormularios + (siniestro.CantidadFormularios == 1 ? " archivo" : " archivos");
            btn_ver_formulario.Enabled = siniestro.CantidadFormularios > 0;
            btn_cargar_formulario.Visible = siniestro.Estado == "En evaluación";

            lbl_verificacion_titulo.Text = "Verificación de la documentación (expediente " + siniestro.ExpedienteTexto + ")";
            txt_observaciones.Text = siniestro.Observaciones;
            txt_observaciones.ReadOnly = siniestro.EstaResuelto;

            lbl_estado.Text = "Estado actual: " + siniestro.Estado;
            lbl_estado.ForeColor = Estilos.ColorEstado(siniestro.Estado);

            if (siniestro.EstaResuelto)
            {
                lbl_estado.Text += " el " + siniestro.FechaResolucion.Value.ToString("dd/MM/yyyy");
            }

            // los controles solo se marcan en Pendiente: pasar a evaluación ya implica que se verificó
            // (un rechazado pudo no haber pasado por la evaluación, por eso queda sin marcar)
            bool verificado = siniestro.Estado == "En evaluación" || siniestro.Estado == "Aprobado";
            chk_fotos.Enabled = siniestro.EsPendiente;
            chk_denuncia.Enabled = siniestro.EsPendiente;
            chk_poliza.Enabled = siniestro.EsPendiente;
            chk_fotos.Checked = verificado;
            chk_denuncia.Checked = verificado;
            chk_poliza.Checked = verificado;

            btn_evaluar.Visible = siniestro.EsPendiente;
            btn_aprobar.Visible = siniestro.Estado == "En evaluación";
            btn_rechazar.Visible = !siniestro.EstaResuelto;
            btn_guardar_observaciones.Visible = !siniestro.EstaResuelto;
        }

        // ================= Documentación =================

        private void btn_ver_fotos_Click(object sender, EventArgs e)
        {
            MostrarAdjuntos("Foto");
        }

        private void btn_ver_denuncia_Click(object sender, EventArgs e)
        {
            MostrarAdjuntos("Denuncia");
        }

        private void btn_ver_formulario_Click(object sender, EventArgs e)
        {
            MostrarAdjuntos("Formulario");
        }

        private void MostrarAdjuntos(string tipo)
        {
            VerFoto.MostrarAdjuntos(SiniestroNegocio.ListarAdjuntos(siniestroActual.IdSiniestro, tipo), siniestroActual.ExpedienteTexto);
        }

        // El formulario se elige y se guarda en el momento; el que había se reemplaza
        private void btn_cargar_formulario_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialogo = new OpenFileDialog();
            dialogo.Title = "Fotos del formulario (hasta " + SiniestroNegocio.MaximoFormularios + ")";
            dialogo.Filter = "Imágenes|*.jpg;*.jpeg;*.png;*.bmp";
            dialogo.Multiselect = true;

            if (dialogo.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            string mensaje;
            int id = siniestroActual.IdSiniestro;
            List<byte[]> fotos = new List<byte[]>();

            foreach (string ruta in dialogo.FileNames)
            {
                byte[] foto = VehiculoNegocio.PrepararFoto(ruta, out mensaje);

                if (foto == null)
                {
                    MessageBox.Show(mensaje, "Siniestros", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                fotos.Add(foto);
            }

            if (SiniestroNegocio.CargarFormulario(siniestroActual, fotos, out mensaje))
            {
                MessageBox.Show("Formulario guardado.", "Siniestros", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarLista(id);
            }
            else
            {
                MessageBox.Show(mensaje, "Siniestros", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        // ================= Cambios de estado =================

        private void btn_guardar_observaciones_Click(object sender, EventArgs e)
        {
            string mensaje;
            int id = siniestroActual.IdSiniestro;

            if (SiniestroNegocio.GuardarObservaciones(siniestroActual, txt_observaciones.Text, out mensaje))
            {
                MessageBox.Show("Observaciones guardadas.", "Siniestros", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(mensaje, "Siniestros", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            CargarLista(id);
        }

        private void btn_evaluar_Click(object sender, EventArgs e)
        {
            string mensaje;
            int id = siniestroActual.IdSiniestro;

            if (SiniestroNegocio.PasarAEvaluacion(siniestroActual, chk_fotos.Checked, chk_denuncia.Checked, chk_poliza.Checked, txt_observaciones.Text, out mensaje))
            {
                MessageBox.Show("El expediente pasó a evaluación de la aseguradora.", "Siniestros", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarLista(id);
            }
            else
            {
                MessageBox.Show(mensaje, "Siniestros", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_aprobar_Click(object sender, EventArgs e)
        {
            string mensaje;
            int id = siniestroActual.IdSiniestro;

            DialogResult respuesta = MessageBox.Show("¿Registrar que la aseguradora aprobó el expediente " + siniestroActual.ExpedienteTexto + "? No se puede deshacer.", "Aprobar reclamo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                if (SiniestroNegocio.Aprobar(siniestroActual, txt_observaciones.Text, out mensaje))
                {
                    CargarLista(id);
                }
                else
                {
                    MessageBox.Show(mensaje, "Aprobar reclamo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btn_rechazar_Click(object sender, EventArgs e)
        {
            string mensaje;
            int id = siniestroActual.IdSiniestro;

            DialogResult respuesta = MessageBox.Show("¿Rechazar el expediente " + siniestroActual.ExpedienteTexto + "? No se puede deshacer.", "Rechazar reclamo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                if (SiniestroNegocio.Rechazar(siniestroActual, txt_observaciones.Text, out mensaje))
                {
                    CargarLista(id);
                }
                else
                {
                    MessageBox.Show(mensaje, "Rechazar reclamo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        // Pinta la columna Estado con el color que le corresponde
        private void dgv_siniestros_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == col_estado.Index && e.Value != null)
            {
                e.CellStyle.ForeColor = Estilos.ColorEstado(e.Value.ToString());
                e.CellStyle.Font = Estilos.Negrita;
            }
        }
    }
}
