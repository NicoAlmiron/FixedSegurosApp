using FixedSegurosApp.Entidades;
using FixedSegurosApp.Negocio;
using FixedSegurosApp.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace FixedSegurosApp.Vistas
{
    // Seguimiento de acciones de usuarios (solo el administrador), con filtros por usuario, módulo y fechas
    public partial class HistorialAcciones : Form
    {
        private BindingList<Accion> listaAcciones = new BindingList<Accion>();

        // Conecto la grilla con la lista
        public HistorialAcciones()
        {
            InitializeComponent();
            dgv_acciones.AutoGenerateColumns = false;
            dgv_acciones.DataSource = listaAcciones;
        }

        // Al abrir la pantalla le aplico los estilos y cargo los datos
        private void HistorialAcciones_Load(object sender, EventArgs e)
        {
            Estilos.Tarjeta(pnl_filtros);
            Estilos.Grilla(dgv_acciones);
            Estilos.BotonPrincipal(btn_buscar);
            Estilos.BotonSecundario(btn_limpiar);
            Estilos.BotonSecundario(btn_volver);

            cb_modulo.Items.AddRange(new string[] { "Todos", "Usuarios", "Empleados", "Vehículos", "Pólizas", "Siniestros", "Pagos", "Proveedores", "Notificaciones" });

            Limpiar();
        }

        // Filtros por defecto: todos los usuarios y módulos de los últimos 15 días
        private void Limpiar()
        {
            txt_usuario.Clear();
            cb_modulo.SelectedIndex = 0;
            dtp_desde.Value = DateTime.Today.AddDays(-15);
            dtp_hasta.Value = DateTime.Today;
            Buscar();
        }

        // Busco con los filtros elegidos (la fecha Desde no puede ser mayor que Hasta)
        private void Buscar()
        {
            if (dtp_desde.Value.Date > dtp_hasta.Value.Date)
            {
                MessageBox.Show("La fecha \"Desde\" no puede ser mayor que la fecha \"Hasta\".", "Historial de acciones", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            List<Accion> resultado = UsuarioNegocio.ListarAcciones(txt_usuario.Text, cb_modulo.Text, dtp_desde.Value, dtp_hasta.Value);

            listaAcciones.Clear();
            foreach (Accion a in resultado)
            {
                listaAcciones.Add(a);
            }
            lbl_cantidad.Text = "Mostrando " + listaAcciones.Count + " acciones";
        }

        // Botón Buscar
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        // Vuelvo a los filtros por defecto
        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        // Vuelvo a Usuarios
        private void btn_volver_Click(object sender, EventArgs e)
        {
            ((Principal)this.ParentForm).AbrirForm(new Usuarios());
        }
    }
}
