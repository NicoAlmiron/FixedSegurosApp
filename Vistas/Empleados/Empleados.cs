using FixedSegurosApp.Entidades;
using FixedSegurosApp.Negocio;
using FixedSegurosApp.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace FixedSegurosApp.Vistas
{
    // Habilitar / deshabilitar empleados (solo Administrador)
    public partial class Empleados : Form
    {
        private BindingList<Empleado> listaEmpleados = new BindingList<Empleado>();
        private Empleado empleadoSeleccionado;

        public Empleados()
        {
            InitializeComponent();
            dgv_empleados.AutoGenerateColumns = false;
            dgv_empleados.DataSource = listaEmpleados;
        }

        private void Empleados_Load(object sender, EventArgs e)
        {
            Estilos.Tarjeta(pnl_lista);
            Estilos.Tarjeta(pnl_detalle);
            Estilos.Grilla(dgv_empleados);
            Estilos.BotonPrincipal(btn_habilitar);
            Estilos.BotonPeligro(btn_deshabilitar);
            Estilos.BotonSecundario(btn_descartar);
            Estilos.BotonPrincipal(btn_guardar);
            Estilos.Placeholder(txt_buscar, "Buscar por legajo, DNI o apellido");

            CargarDatos();
        }

        public void CargarDatos()
        {
            CargarLista(EmpleadoNegocio.ListarEmpleados(txt_buscar.Text));
        }

        private void CargarLista(List<Empleado> resultado)
        {
            listaEmpleados.Clear();
            foreach (Empleado emp in resultado)
            {
                listaEmpleados.Add(emp);
            }
            lbl_cantidad.Text = "Mostrando " + listaEmpleados.Count + " empleados";
        }

        private void dgv_empleados_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_empleados.SelectedRows.Count == 0)
            {
                return;
            }

            Empleado fila = (Empleado)dgv_empleados.SelectedRows[0].DataBoundItem;
            MostrarEmpleado(EmpleadoNegocio.BuscarPorLegajo(fila.Legajo));
        }

        private void MostrarEmpleado(Empleado empleado)
        {
            empleadoSeleccionado = empleado;
            if (empleado == null)
            {
                return;
            }

            txt_legajo.Text = empleado.Legajo.ToString("0000");
            txt_dni.Text = empleado.Dni.ToString();
            txt_nombre.Text = empleado.Nombre;
            txt_apellido.Text = empleado.Apellido;
            cb_puesto.Text = empleado.Puesto;           // "Sin asignar" no está en la lista: queda vacío para elegir
            dtp_fecha_ingreso.Value = empleado.FechaIngreso;

            // "etiqueta" de color con el estado actual
            string estado = empleado.EstadoMostrado;
            lbl_estado_valor.Text = estado == "Baja" ? "Dado de baja" : estado;
            lbl_estado_valor.BackColor = Estilos.ColorEstado(estado);

            // un empleado dado de baja (en Usuarios) ya no se puede modificar
            bool modificable = empleado.Estado != "Baja";
            btn_habilitar.Visible = modificable;
            btn_deshabilitar.Visible = modificable;
            btn_descartar.Visible = modificable;
            btn_guardar.Visible = modificable;
        }

        private void SeleccionarFila(int legajo)
        {
            foreach (DataGridViewRow fila in dgv_empleados.Rows)
            {
                if (((Empleado)fila.DataBoundItem).Legajo == legajo)
                {
                    dgv_empleados.CurrentCell = fila.Cells[0];
                    break;
                }
            }
        }

        // Recarga la grilla y vuelve a dejar elegido al mismo empleado
        private void Refrescar()
        {
            int legajo = empleadoSeleccionado.Legajo;
            CargarDatos();
            SeleccionarFila(legajo);
        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btn_habilitar_Click(object sender, EventArgs e)
        {
            string mensaje;

            if (empleadoSeleccionado == null)
            {
                MessageBox.Show("No se ha seleccionado ningún empleado.", "Empleados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (EmpleadoNegocio.Habilitar(empleadoSeleccionado.Legajo, out mensaje))
            {
                MessageBox.Show(empleadoSeleccionado.ApellidoYNombre + " fue habilitado.\nYa puede iniciar sesión.", "Empleados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Refrescar();
            }
            else
            {
                MessageBox.Show(mensaje, "Empleados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_deshabilitar_Click(object sender, EventArgs e)
        {
            string mensaje;

            if (empleadoSeleccionado == null)
            {
                MessageBox.Show("No se ha seleccionado ningún empleado.", "Empleados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult respuesta = MessageBox.Show("¿Está seguro que quiere deshabilitar a " + empleadoSeleccionado.ApellidoYNombre + "?\nNo podrá iniciar sesión hasta que se lo vuelva a habilitar.", "Empleados", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (respuesta == DialogResult.Yes)
            {
                if (EmpleadoNegocio.Deshabilitar(empleadoSeleccionado.Legajo, out mensaje))
                {
                    Refrescar();
                }
                else
                {
                    MessageBox.Show(mensaje, "Empleados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            string mensaje;

            if (empleadoSeleccionado == null)
            {
                MessageBox.Show("No se ha seleccionado ningún empleado.", "Empleados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Empleado empleado = new Empleado()
            {
                Legajo = empleadoSeleccionado.Legajo,
                Puesto = cb_puesto.Text,
                FechaIngreso = dtp_fecha_ingreso.Value.Date
            };

            if (EmpleadoNegocio.GuardarEmpleado(empleado, out mensaje))
            {
                MessageBox.Show("Los cambios se guardaron correctamente.", "Empleados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Refrescar();
            }
            else
            {
                MessageBox.Show(mensaje, "Empleados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_descartar_Click(object sender, EventArgs e)
        {
            if (empleadoSeleccionado != null)
            {
                MostrarEmpleado(EmpleadoNegocio.BuscarPorLegajo(empleadoSeleccionado.Legajo));
            }
        }

        // Pinta la columna Estado con el color que le corresponde
        private void dgv_empleados_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
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
    }
}
