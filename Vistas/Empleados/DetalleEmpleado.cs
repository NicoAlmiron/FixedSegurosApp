using FixedSegurosApp.Entidades;
using FixedSegurosApp.Negocio;
using FixedSegurosApp.Utilidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FixedSegurosApp.Vistas
{
    // Todo sobre un empleado (solo Administrador): sus datos, las pólizas que cargó o vendió,
    // los siniestros que tiene a cargo y su historial. Es solo de consulta.
    public partial class DetalleEmpleado : Form
    {
        private int legajoEmpleado;

        public DetalleEmpleado(int legajo)
        {
            InitializeComponent();
            legajoEmpleado = legajo;

            dgv_polizas.AutoGenerateColumns = false;
            dgv_siniestros.AutoGenerateColumns = false;
            dgv_historial.AutoGenerateColumns = false;
        }

        private void DetalleEmpleado_Load(object sender, EventArgs e)
        {
            Estilos.Tarjeta(pnl_empleado);
            Estilos.Grilla(dgv_polizas);
            Estilos.Grilla(dgv_siniestros);
            Estilos.Grilla(dgv_historial);
            Estilos.BotonSecundario(btn_volver);

            CargarEmpleado();
            CargarPestanas();
        }

        private void CargarEmpleado()
        {
            Empleado empleado = EmpleadoNegocio.BuscarPorLegajo(legajoEmpleado);
            Persona datos = UsuarioNegocio.BuscarPorLegajo(legajoEmpleado);

            if (empleado == null || datos == null)
            {
                return;
            }

            string estado = empleado.EstadoMostrado;

            lbl_nombre.Text = datos.ApellidoYNombre;
            lbl_estado.Text = estado == "Baja" ? "Dado de baja" : estado;
            lbl_estado.BackColor = Estilos.ColorEstado(estado);
            lbl_estado.Left = lbl_nombre.Right + 10;     // la etiqueta va pegada al nombre

            lbl_datos1.Text = "Legajo " + datos.Legajo.ToString("0000") + "   ·   DNI " + datos.Dni + "   ·   " + empleado.Puesto + "   ·   Ingreso " + empleado.FechaIngreso.ToString("dd/MM/yyyy");
            lbl_datos2.Text = "Tel. " + datos.Telefono + "   ·   " + datos.Email;
            lbl_datos3.Text = datos.Direccion + ", " + datos.Ciudad + ", " + datos.Provincia;
        }

        private void CargarPestanas()
        {
            List<Poliza> polizas = EmpleadoNegocio.ListarPolizas(legajoEmpleado);
            List<Siniestro> siniestros = EmpleadoNegocio.ListarSiniestros(legajoEmpleado);
            List<Accion> historial = EmpleadoNegocio.ListarHistorial(legajoEmpleado);

            dgv_polizas.DataSource = polizas;
            dgv_siniestros.DataSource = siniestros;
            dgv_historial.DataSource = historial;

            // el título de cada pestaña muestra cuántos registros tiene
            tab_polizas.Text = "Pólizas (" + polizas.Count + ")";
            tab_siniestros.Text = "Siniestros (" + siniestros.Count + ")";
            tab_historial.Text = "Historial (" + historial.Count + ")";
        }

        // Las grillas son solo de consulta: ninguna fila queda elegida y el color del estado se ve siempre
        private void grilla_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ((DataGridView)sender).ClearSelection();
        }

        // Pinta las columnas de estado con el color que les corresponde
        private void grilla_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            string columna = ((DataGridView)sender).Columns[e.ColumnIndex].Name;

            if (columna.EndsWith("_estado") && e.Value != null)
            {
                e.CellStyle.ForeColor = Estilos.ColorEstado(e.Value.ToString());
                e.CellStyle.Font = Estilos.Negrita;
            }
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            ((Principal)this.ParentForm).AbrirForm(new Empleados());
        }
    }
}
