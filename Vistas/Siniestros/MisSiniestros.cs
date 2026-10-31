using FixedSegurosApp.Entidades;
using FixedSegurosApp.Negocio;
using FixedSegurosApp.Utilidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FixedSegurosApp.Vistas
{
    // Carga de reclamos: a la izquierda el reclamo, a la derecha la documentación, los reclamos y el seguimiento.
    // El cliente carga los suyos y puede reabrir uno Pendiente para corregirlo.
    // El empleado busca al cliente por DNI y carga el reclamo en la oficina (queda En evaluación).
    public partial class MisSiniestros : Form
    {
        private bool esEmpleado;
        private int legajoCliente;
        private Siniestro reclamoActual;                    // null = reclamo nuevo
        private List<byte[]> fotosNuevas = new List<byte[]>();
        private byte[] denunciaNueva;

        public MisSiniestros()
        {
            InitializeComponent();
            dgv_reclamos.AutoGenerateColumns = false;
        }

        private void MisSiniestros_Load(object sender, EventArgs e)
        {
            Estilos.Tarjeta(pnl_form);
            Estilos.Tarjeta(pnl_detalle);
            Estilos.Grilla(dgv_reclamos);
            Estilos.BotonSecundario(btn_fotos);
            Estilos.BotonSecundario(btn_denuncia);
            Estilos.BotonSecundario(btn_cancelar);
            Estilos.BotonPrincipal(btn_enviar);
            Estilos.BotonSecundario(btn_buscar);
            Estilos.BotonSecundario(btn_volver);

            cb_tipo.Items.AddRange(SiniestroNegocio.Tipos);
            cb_poliza.DisplayMember = "Descripcion";     // muestra "000124 · AB123CD"
            cb_poliza.ValueMember = "NroPoliza";

            esEmpleado = Sesion.UsuarioActual.Perfil == "Empleado";
            lbl_dni.Visible = esEmpleado;
            txt_dni.Visible = esEmpleado;
            btn_buscar.Visible = esEmpleado;
            btn_volver.Visible = esEmpleado;

            if (!esEmpleado)
            {
                legajoCliente = Sesion.UsuarioActual.Legajo;
            }

            CargarReclamos();
            NuevoReclamo();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            int dni;
            Persona cliente = null;

            if (int.TryParse(txt_dni.Text.Trim(), out dni))
            {
                cliente = ClienteNegocio.BuscarPorDni(dni);
            }

            if (cliente == null)
            {
                MessageBox.Show("No hay ningún cliente con ese DNI.", "Siniestros", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            legajoCliente = cliente.Legajo;
            lbl_titulo.Text = "Siniestros · " + cliente.ApellidoYNombre;
            CargarReclamos();
            NuevoReclamo();
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            ((Principal)this.ParentForm).AbrirForm(new Siniestros());
        }

        private void CargarReclamos()
        {
            List<Siniestro> reclamos = SiniestroNegocio.ListarReclamosDe(legajoCliente);
            dgv_reclamos.DataSource = reclamos;
            lbl_reclamos_titulo.Text = (esEmpleado ? "Reclamos del cliente (" : "Mis reclamos (") + reclamos.Count + ")";
        }

        // Deja el formulario vacío para iniciar un reclamo
        private void NuevoReclamo()
        {
            reclamoActual = null;
            fotosNuevas = new List<byte[]>();
            denunciaNueva = null;

            lbl_form_titulo.Text = "Nuevo reclamo";
            btn_enviar.Text = "Enviar reclamo";
            btn_cancelar.Text = "Cancelar";

            List<Poliza> polizas = SiniestroNegocio.ListarPolizasParaReclamo(legajoCliente, 0);
            cb_poliza.DataSource = polizas;
            cb_poliza.Enabled = true;

            cb_tipo.SelectedIndex = -1;
            dtp_fecha.Value = DateTime.Today;
            txt_ubicacion.Text = "";
            txt_descripcion.Text = "";
            txt_monto.Text = "";

            if (polizas.Count == 0)
            {
                LimpiarVehiculo();
            }

            if (esEmpleado && legajoCliente == 0)
            {
                lbl_ayuda.Text = "Busque al cliente por su DNI.";
            }
            else if (polizas.Count == 0)
            {
                lbl_ayuda.Text = "Se necesita una póliza vigente para iniciar un reclamo.";
            }
            else if (esEmpleado)
            {
                lbl_ayuda.Text = "Cargado en la oficina, el reclamo pasa directo a En evaluación.";
            }
            else
            {
                lbl_ayuda.Text = "El reclamo queda en estado Pendiente hasta que un empleado revise la documentación.";
            }

            PermitirEdicion(polizas.Count > 0);
            MostrarAdjuntos();
            MostrarSeguimiento(null);
            dgv_reclamos.ClearSelection();
        }

        // Carga un reclamo en el formulario: si está Pendiente se puede corregir, si no solo se mira
        private void MostrarReclamo(Siniestro reclamo)
        {
            reclamoActual = reclamo;
            fotosNuevas = new List<byte[]>();
            denunciaNueva = null;

            lbl_form_titulo.Text = "Expediente " + reclamo.ExpedienteTexto;
            btn_enviar.Text = "Guardar cambios";

            // solo el cliente corrige su reclamo: el empleado lo revisa desde la pantalla Siniestros
            bool editable = reclamo.EsPendiente && !esEmpleado;
            btn_cancelar.Text = editable ? "Cancelar" : "Volver";

            // la póliza de un reclamo ya iniciado no se cambia
            cb_poliza.DataSource = SiniestroNegocio.ListarPolizasParaReclamo(legajoCliente, reclamo.NroPoliza);
            cb_poliza.SelectedValue = reclamo.NroPoliza;
            cb_poliza.Enabled = false;

            cb_tipo.SelectedItem = reclamo.TipoSiniestro;
            dtp_fecha.Value = reclamo.FechaOcurrencia;
            txt_ubicacion.Text = reclamo.Ubicacion;
            txt_descripcion.Text = reclamo.Descripcion;
            txt_monto.Text = reclamo.MontoReclamado.ToString("0.##");

            if (editable)
            {
                lbl_ayuda.Text = "Puede corregir el reclamo hasta que un empleado lo pase a evaluación.";
            }
            else if (esEmpleado)
            {
                lbl_ayuda.Text = "Solo consulta: la verificación se hace en la pantalla Siniestros.";
            }
            else
            {
                lbl_ayuda.Text = "Este reclamo ya fue revisado: no se puede modificar.";
            }

            PermitirEdicion(editable);
            MostrarAdjuntos();
            MostrarSeguimiento(reclamo);
        }

        private void PermitirEdicion(bool editable)
        {
            cb_tipo.Enabled = editable;
            dtp_fecha.Enabled = editable;
            txt_ubicacion.Enabled = editable;
            txt_descripcion.Enabled = editable;
            txt_monto.Enabled = editable;
            btn_fotos.Enabled = editable;
            btn_denuncia.Enabled = editable;
            btn_enviar.Visible = editable;
        }

        // Al elegir la póliza se completa el bien afectado
        private void cb_poliza_SelectedIndexChanged(object sender, EventArgs e)
        {
            Poliza poliza = cb_poliza.SelectedItem as Poliza;
            if (poliza == null)
            {
                return;
            }

            Vehiculo vehiculo = SiniestroNegocio.BuscarVehiculoDe(poliza, legajoCliente);
            if (vehiculo == null)
            {
                LimpiarVehiculo();
                return;
            }

            txt_dominio.Text = vehiculo.Dominio;
            txt_marca.Text = vehiculo.MarcaYModelo;
            txt_anio.Text = vehiculo.Anio.ToString();
        }

        private void LimpiarVehiculo()
        {
            txt_dominio.Text = "";
            txt_marca.Text = "";
            txt_anio.Text = "";
        }

        // ================= Documentación =================

        private void MostrarAdjuntos()
        {
            int fotos = fotosNuevas.Count;
            bool denuncia = denunciaNueva != null;

            if (reclamoActual != null)
            {
                if (fotos == 0)
                {
                    fotos = reclamoActual.CantidadFotos;
                }
                denuncia = denuncia || reclamoActual.CantidadDenuncias > 0;
            }

            lbl_fotos.Text = fotos == 0 ? "Sin adjuntar" : fotos + (fotos == 1 ? " archivo adjunto" : " archivos adjuntos");
            lbl_denuncia.Text = denuncia ? "1 archivo adjunto" : "Sin adjuntar";
        }

        private void btn_fotos_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialogo = new OpenFileDialog();
            dialogo.Title = "Fotos del daño o del lugar del hecho (hasta " + SiniestroNegocio.MaximoFotos + ")";
            dialogo.Filter = "Imágenes|*.jpg;*.jpeg;*.png;*.bmp";
            dialogo.Multiselect = true;

            if (dialogo.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            if (dialogo.FileNames.Length > SiniestroNegocio.MaximoFotos)
            {
                MessageBox.Show("Puede adjuntar hasta " + SiniestroNegocio.MaximoFotos + " fotos.", "Siniestros", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // las fotos elegidas reemplazan a todas las anteriores
            List<byte[]> elegidas = new List<byte[]>();
            foreach (string ruta in dialogo.FileNames)
            {
                string mensaje;
                byte[] foto = VehiculoNegocio.PrepararFoto(ruta, out mensaje);

                if (foto == null)
                {
                    MessageBox.Show(mensaje, "Siniestros", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                elegidas.Add(foto);
            }

            fotosNuevas = elegidas;
            MostrarAdjuntos();
        }

        private void btn_denuncia_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialogo = new OpenFileDialog();
            dialogo.Title = "Foto de la denuncia";
            dialogo.Filter = "Imágenes|*.jpg;*.jpeg;*.png;*.bmp";

            if (dialogo.ShowDialog() == DialogResult.OK)
            {
                string mensaje;
                byte[] foto = VehiculoNegocio.PrepararFoto(dialogo.FileName, out mensaje);

                if (foto == null)
                {
                    MessageBox.Show(mensaje, "Siniestros", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                denunciaNueva = foto;
                MostrarAdjuntos();
            }
        }

        // ================= Enviar =================

        private void btn_enviar_Click(object sender, EventArgs e)
        {
            string mensaje;
            Poliza poliza = cb_poliza.SelectedItem as Poliza;

            Siniestro reclamo = new Siniestro()
            {
                IdSiniestro = reclamoActual != null ? reclamoActual.IdSiniestro : 0,
                NroPoliza = poliza != null ? poliza.NroPoliza : 0,
                FechaOcurrencia = dtp_fecha.Value.Date,
                TipoSiniestro = cb_tipo.Text,
                Ubicacion = txt_ubicacion.Text,
                Descripcion = txt_descripcion.Text,
                CantidadFotos = reclamoActual != null ? reclamoActual.CantidadFotos : 0,
                CantidadDenuncias = reclamoActual != null ? reclamoActual.CantidadDenuncias : 0
            };

            bool esNuevo = reclamoActual == null;

            if (SiniestroNegocio.GuardarReclamo(reclamo, legajoCliente, txt_monto.Text.Trim(), fotosNuevas, denunciaNueva, out mensaje))
            {
                string aviso = esNuevo ? "Reclamo enviado. N° de expediente: " + reclamo.ExpedienteTexto + "." : "Reclamo modificado.";
                if (esEmpleado)
                {
                    aviso += " Quedó En evaluación.";
                }
                MessageBox.Show(aviso, "Siniestros", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarReclamos();
                NuevoReclamo();
            }
            else
            {
                MessageBox.Show(mensaje, "Siniestros", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            NuevoReclamo();
        }

        // ================= Mis reclamos =================

        // Se abre con un clic: al cargar la grilla no se elige ningún reclamo solo
        private void dgv_reclamos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                MostrarReclamo((Siniestro)dgv_reclamos.Rows[e.RowIndex].DataBoundItem);
            }
        }

        private void dgv_reclamos_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgv_reclamos.ClearSelection();
        }

        private void dgv_reclamos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == col_estado.Index && e.Value != null)
            {
                e.CellStyle.ForeColor = Estilos.ColorEstado(e.Value.ToString());
                e.CellStyle.Font = Estilos.Negrita;
            }
        }

        // ================= Seguimiento =================

        private void MostrarSeguimiento(Siniestro reclamo)
        {
            lbl_paso3.Text = "3. Resultado: Aprobado o Rechazado";

            if (reclamo == null)
            {
                lbl_seguimiento_titulo.Text = "Seguimiento del expediente";
                MarcarPaso(lbl_paso1, false);
                MarcarPaso(lbl_paso2, false);
                MarcarPaso(lbl_paso3, false);
                lbl_observaciones.Text = "Elija un reclamo para ver su seguimiento.";
                return;
            }

            lbl_seguimiento_titulo.Text = "Seguimiento del expediente " + reclamo.ExpedienteTexto;
            MarcarPaso(lbl_paso1, true);

            // un reclamo rechazado pudo no haber pasado por la aseguradora: ese paso queda sin marcar
            MarcarPaso(lbl_paso2, reclamo.Estado == "En evaluación" || reclamo.Estado == "Aprobado");
            MarcarPaso(lbl_paso3, reclamo.EstaResuelto);

            if (reclamo.EstaResuelto)
            {
                lbl_paso3.Text = "3. Resultado: " + reclamo.Resultado + " el " + reclamo.FechaResolucion.Value.ToString("dd/MM/yyyy");
                lbl_paso3.ForeColor = Estilos.ColorEstado(reclamo.Estado);
            }

            lbl_observaciones.Text = reclamo.Observaciones == "" ? "" : "Observaciones: " + reclamo.Observaciones;
        }

        private void MarcarPaso(Label paso, bool hecho)
        {
            paso.Font = hecho ? Estilos.Negrita : Estilos.Normal;
            paso.ForeColor = hecho ? Estilos.Exito : Estilos.TextoSecundario;
        }
    }
}
