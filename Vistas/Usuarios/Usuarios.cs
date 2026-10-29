using FixedSegurosApp.Entidades;
using FixedSegurosApp.Negocio;
using FixedSegurosApp.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace FixedSegurosApp.Vistas
{
    public partial class Usuarios : Form
    {
        private BindingList<Persona> listaUsuarios = new BindingList<Persona>();
        private Persona usuarioSeleccionado;   // null = se esta cargando un usuario nuevo
        private bool soloLectura;              // el Empleado solo puede consultar

        public Usuarios()
        {
            InitializeComponent();
            dgv_usuarios.AutoGenerateColumns = false;   // usa solo las columnas definidas en el diseñador
            dgv_usuarios.DataSource = listaUsuarios;
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            Estilos.Tarjeta(pnl_lista);
            Estilos.Tarjeta(pnl_detalle);
            Estilos.Grilla(dgv_usuarios);
            Estilos.BotonPrincipal(btn_nuevo);
            Estilos.BotonSecundario(btn_suspender);
            Estilos.BotonPeligro(btn_baja);
            Estilos.BotonSecundario(btn_restablecer);
            Estilos.BotonSecundario(btn_historial);
            Estilos.BotonPrincipal(btn_detalle_cliente);
            Estilos.BotonSecundario(btn_descartar);
            Estilos.BotonPrincipal(btn_guardar);
            Estilos.Placeholder(txt_buscar, "Buscar por legajo, DNI o apellido");

            cb_provincia.Items.AddRange(Provincias.Lista);
            cb_perfil.Items.AddRange(new string[] { "Cliente", "Empleado", "Administrador" });

            soloLectura = Sesion.UsuarioActual.Perfil != "Administrador";
            if (soloLectura)
            {
                ModoSoloLectura();
            }

            CargarDatos();
        }

        public void CargarDatos()
        {
            CargarLista(UsuarioNegocio.ListarUsuarios(txt_buscar.Text));
        }

        private void CargarLista(List<Persona> resultado)
        {
            listaUsuarios.Clear();
            foreach (Persona p in resultado)
            {
                listaUsuarios.Add(p);
            }
            lbl_cantidad.Text = "Mostrando " + listaUsuarios.Count + " usuarios";

            if (listaUsuarios.Count == 0)
            {
                LimpiarDetalle();
            }
        }

        // Al elegir una fila se muestran sus datos a la derecha
        private void dgv_usuarios_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_usuarios.SelectedRows.Count == 0)
            {
                return;
            }

            Persona fila = (Persona)dgv_usuarios.SelectedRows[0].DataBoundItem;
            MostrarUsuario(UsuarioNegocio.BuscarPorLegajo(fila.Legajo));
        }

        private void MostrarUsuario(Persona usuario)
        {
            usuarioSeleccionado = usuario;
            if (usuario == null)
            {
                return;
            }

            txt_legajo.Text = usuario.Legajo.ToString("0000");
            cb_perfil.Text = usuario.Perfil;
            cb_perfil.Enabled = false;          // el perfil solo se elige al crear el usuario
            txt_nombre.Text = usuario.Nombre;
            txt_apellido.Text = usuario.Apellido;
            txt_dni.Text = usuario.Dni.ToString();
            dtp_fecha_nacimiento.Value = usuario.FechaNacimiento;
            cb_provincia.Text = usuario.Provincia;
            txt_ciudad.Text = usuario.Ciudad;
            txt_direccion.Text = usuario.Direccion;
            txt_telefono.Text = usuario.Telefono;
            txt_email.Text = usuario.Email;
            txt_fecha_alta.Text = usuario.FechaAlta.ToString("dd/MM/yyyy");
            txt_fecha_baja.Text = usuario.FechaBaja.HasValue ? usuario.FechaBaja.Value.ToString("dd/MM/yyyy") : "";
            txt_motivo_baja.Text = usuario.ObservacionBaja;

            btn_suspender.Text = usuario.Estado == "Suspendido" ? "Reactivar" : "Suspender";

            // la baja es definitiva: un usuario dado de baja ya no se puede modificar
            HabilitarAcciones(usuario.Estado != "Baja");

            // el detalle (vehículos, pólizas, pagos...) solo existe para clientes
            btn_detalle_cliente.Visible = usuario.Perfil == "Cliente";
        }

        // Muestra u oculta los botones que modifican al usuario (el Empleado nunca los ve)
        private void HabilitarAcciones(bool habilitar)
        {
            bool mostrar = habilitar && !soloLectura;

            btn_suspender.Visible = mostrar;
            btn_baja.Visible = mostrar;
            btn_restablecer.Visible = mostrar;
            btn_descartar.Visible = mostrar;
            btn_guardar.Visible = mostrar;
        }

        // Deja el panel de la derecha vacio para cargar un usuario nuevo
        private void LimpiarDetalle()
        {
            usuarioSeleccionado = null;

            txt_legajo.Text = "Nuevo";
            cb_perfil.Enabled = !soloLectura;
            cb_perfil.SelectedIndex = 0;
            txt_nombre.Clear();
            txt_apellido.Clear();
            txt_dni.Clear();
            dtp_fecha_nacimiento.Value = DateTime.Today.AddYears(-18);
            cb_provincia.SelectedIndex = -1;
            txt_ciudad.Clear();
            txt_direccion.Clear();
            txt_telefono.Clear();
            txt_email.Clear();
            txt_fecha_alta.Text = DateTime.Today.ToString("dd/MM/yyyy");
            txt_fecha_baja.Clear();
            txt_motivo_baja.Clear();
            btn_suspender.Text = "Suspender";
            btn_detalle_cliente.Visible = false;
            HabilitarAcciones(true);
        }

        private void SeleccionarFila(int legajo)
        {
            foreach (DataGridViewRow fila in dgv_usuarios.Rows)
            {
                if (((Persona)fila.DataBoundItem).Legajo == legajo)
                {
                    dgv_usuarios.CurrentCell = fila.Cells[0];
                    break;
                }
            }
        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            dgv_usuarios.ClearSelection();
            LimpiarDetalle();
            txt_nombre.Focus();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            string mensaje;
            bool esNuevo = usuarioSeleccionado == null;

            Persona usuario = new Persona()
            {
                Legajo = esNuevo ? 0 : usuarioSeleccionado.Legajo,
                Perfil = cb_perfil.Text,
                Nombre = txt_nombre.Text.Trim(),
                Apellido = txt_apellido.Text.Trim(),
                FechaNacimiento = dtp_fecha_nacimiento.Value.Date,
                Provincia = cb_provincia.Text,
                Ciudad = txt_ciudad.Text.Trim(),
                Direccion = txt_direccion.Text.Trim(),
                Telefono = txt_telefono.Text.Trim(),
                Email = txt_email.Text.Trim()
            };

            if (UsuarioNegocio.GuardarUsuario(usuario, txt_dni.Text.Trim(), out mensaje))
            {
                if (esNuevo)
                {
                    MessageBox.Show("Usuario creado con el legajo " + usuario.Legajo.ToString("0000") + ".\nSu contraseña inicial es su DNI.", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Los cambios se guardaron correctamente.", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                CargarDatos();
                SeleccionarFila(usuario.Legajo);
            }
            else
            {
                MessageBox.Show(mensaje, "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_descartar_Click(object sender, EventArgs e)
        {
            if (usuarioSeleccionado != null)
            {
                MostrarUsuario(UsuarioNegocio.BuscarPorLegajo(usuarioSeleccionado.Legajo));
            }
            else
            {
                LimpiarDetalle();
            }
        }

        private void btn_suspender_Click(object sender, EventArgs e)
        {
            string mensaje;

            if (usuarioSeleccionado == null)
            {
                MessageBox.Show("No se ha seleccionado ningún usuario.", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string accion = usuarioSeleccionado.Estado == "Suspendido" ? "reactivar" : "suspender";

            DialogResult respuesta = MessageBox.Show("¿Está seguro que quiere " + accion + " a " + usuarioSeleccionado.ApellidoYNombre + "?", "Usuarios", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                if (!UsuarioNegocio.SuspenderOReactivar(usuarioSeleccionado, out mensaje))
                {
                    MessageBox.Show(mensaje, "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                int legajo = usuarioSeleccionado.Legajo;
                CargarDatos();
                SeleccionarFila(legajo);
            }
        }

        private void btn_baja_Click(object sender, EventArgs e)
        {
            string mensaje;

            if (usuarioSeleccionado == null)
            {
                MessageBox.Show("No se ha seleccionado ningún usuario.", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // InputBox: ventanita para escribir un texto (si se cancela devuelve "")
            string motivo = Microsoft.VisualBasic.Interaction.InputBox(
                "Va a dar de baja a " + usuarioSeleccionado.ApellidoYNombre + ". Esta acción no se puede revertir.\n\nIndique el motivo de la baja:",
                "Dar de baja");

            if (!UsuarioNegocio.DarDeBaja(usuarioSeleccionado, motivo, out mensaje))
            {
                MessageBox.Show(mensaje, "Dar de baja", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            int legajo = usuarioSeleccionado.Legajo;
            CargarDatos();
            SeleccionarFila(legajo);
        }

        private void btn_restablecer_Click(object sender, EventArgs e)
        {
            if (usuarioSeleccionado == null)
            {
                MessageBox.Show("No se ha seleccionado ningún usuario.", "Restablecer contraseña", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult respuesta = MessageBox.Show("La contraseña de " + usuarioSeleccionado.ApellidoYNombre + " volverá a ser su DNI. ¿Continuar?", "Restablecer contraseña", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                string mensaje;
                if (UsuarioNegocio.RestablecerContrasena(usuarioSeleccionado, out mensaje))
                {
                    MessageBox.Show("Contraseña restablecida. Ahora es el DNI del usuario.", "Restablecer contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(mensaje, "Restablecer contraseña", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btn_detalle_cliente_Click(object sender, EventArgs e)
        {
            AbrirDetalleCliente();
        }

        // Doble clic en la fila de un cliente: abre su detalle
        private void dgv_usuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                AbrirDetalleCliente();
            }
        }

        private void AbrirDetalleCliente()
        {
            if (usuarioSeleccionado == null || usuarioSeleccionado.Perfil != "Cliente")
            {
                return;
            }
            ((Principal)this.ParentForm).AbrirForm(new DetalleCliente(usuarioSeleccionado.Legajo));
        }

        private void btn_historial_Click(object sender, EventArgs e)
        {
            // ParentForm es la ventana Principal que contiene a esta pantalla
            ((Principal)this.ParentForm).AbrirForm(new HistorialAcciones());
        }

        // Pinta la columna Estado con el color que le corresponde
        private void dgv_usuarios_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == col_estado.Index && e.Value != null)
            {
                string estado = e.Value.ToString();

                e.CellStyle.ForeColor = Estilos.ColorEstado(estado);
                e.CellStyle.Font = Estilos.Negrita;

                if (estado == "Baja")
                {
                    e.Value = "Dado de baja";
                    e.FormattingApplied = true;
                }
            }
        }

        // El Empleado puede ver los usuarios pero no modificarlos
        private void ModoSoloLectura()
        {
            btn_nuevo.Visible = false;
            btn_suspender.Visible = false;
            btn_baja.Visible = false;
            btn_restablecer.Visible = false;
            btn_historial.Visible = false;
            btn_detalle_cliente.Left = btn_historial.Right - btn_detalle_cliente.Width;   // ocupa el lugar del historial
            btn_descartar.Visible = false;
            btn_guardar.Visible = false;

            foreach (Control control in pnl_detalle.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).ReadOnly = true;
                }
                else if (control is ComboBox || control is DateTimePicker)
                {
                    control.Enabled = false;
                }
            }
        }
    }
}
