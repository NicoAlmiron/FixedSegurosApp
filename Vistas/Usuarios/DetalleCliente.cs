using FixedSegurosApp.Entidades;
using FixedSegurosApp.Negocio;
using FixedSegurosApp.Utilidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FixedSegurosApp.Vistas
{
    // Todo sobre un cliente: datos, observaciones, vehículos (con fotos y revisión), pólizas, pagos, siniestros e historial.
    // La abren el Administrador y el Empleado desde Usuarios.
    public partial class DetalleCliente : Form
    {
        private int legajoCliente;
        private Vehiculo vehiculoSeleccionado;
        private PictureBox[] casilleros;                                       // las 7 fotos del vehículo elegido
        private Dictionary<string, byte[]> fotos = new Dictionary<string, byte[]>();

        public DetalleCliente(int legajo)
        {
            InitializeComponent();
            legajoCliente = legajo;

            dgv_vehiculos.AutoGenerateColumns = false;
            dgv_polizas.AutoGenerateColumns = false;
            dgv_pagos.AutoGenerateColumns = false;
            dgv_siniestros.AutoGenerateColumns = false;
            dgv_historial.AutoGenerateColumns = false;

            casilleros = GrillaFotos.Crear(pnl_vehiculo, 0, 48, 88, 66, casillero_Click);
        }

        private void DetalleCliente_Load(object sender, EventArgs e)
        {
            Estilos.Tarjeta(pnl_cliente);
            Estilos.Grilla(dgv_vehiculos);
            Estilos.Grilla(dgv_polizas);
            Estilos.Grilla(dgv_pagos);
            Estilos.Grilla(dgv_siniestros);
            Estilos.Grilla(dgv_historial);
            Estilos.BotonSecundario(btn_volver);
            Estilos.BotonSecundario(btn_guardar_obs);
            Estilos.BotonPrincipal(btn_aprobar);
            Estilos.BotonPeligro(btn_rechazar);

            CargarCliente();
            CargarVehiculos();
            CargarPestanas();
        }

        // ================= Tarjeta de arriba =================

        private void CargarCliente()
        {
            Persona cliente = UsuarioNegocio.BuscarPorLegajo(legajoCliente);
            if (cliente == null)
            {
                return;
            }

            lbl_nombre.Text = cliente.ApellidoYNombre;
            lbl_estado.Text = cliente.Estado == "Baja" ? "Dado de baja" : cliente.Estado;
            lbl_estado.BackColor = Estilos.ColorEstado(cliente.Estado);
            lbl_estado.Left = lbl_nombre.Right + 10;     // la etiqueta va pegada al nombre

            lbl_datos1.Text = "Legajo " + cliente.Legajo.ToString("0000") + "   ·   DNI " + cliente.Dni + "   ·   Cliente desde " + cliente.FechaAlta.ToString("dd/MM/yyyy");
            lbl_datos2.Text = "Tel. " + cliente.Telefono + "   ·   " + cliente.Email;
            lbl_datos3.Text = cliente.Direccion + ", " + cliente.Ciudad + ", " + cliente.Provincia;

            txt_observaciones.Text = ClienteNegocio.BuscarObservaciones(legajoCliente);
        }

        private void btn_guardar_obs_Click(object sender, EventArgs e)
        {
            string mensaje;

            if (ClienteNegocio.GuardarObservaciones(legajoCliente, txt_observaciones.Text, out mensaje))
            {
                MessageBox.Show("Observaciones guardadas.", "Detalle del cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarPestanas();   // el historial cambió
            }
            else
            {
                MessageBox.Show(mensaje, "Detalle del cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        // ================= Pestañas =================

        private void CargarPestanas()
        {
            List<Poliza> polizas = ClienteNegocio.ListarPolizas(legajoCliente);
            List<Pago> pagos = ClienteNegocio.ListarPagos(legajoCliente);
            List<Siniestro> siniestros = ClienteNegocio.ListarSiniestros(legajoCliente);
            List<Accion> historial = ClienteNegocio.ListarHistorial(legajoCliente);

            dgv_polizas.DataSource = polizas;
            dgv_pagos.DataSource = pagos;
            dgv_siniestros.DataSource = siniestros;
            dgv_historial.DataSource = historial;

            // el título de cada pestaña muestra cuántos registros tiene
            tab_polizas.Text = "Pólizas (" + polizas.Count + ")";
            tab_pagos.Text = "Pagos (" + pagos.Count + ")";
            tab_siniestros.Text = "Siniestros (" + siniestros.Count + ")";
            tab_historial.Text = "Historial (" + historial.Count + ")";
        }

        // ================= Pestaña Vehículos =================

        private void CargarVehiculos()
        {
            List<Vehiculo> vehiculos = VehiculoNegocio.ListarVehiculosDeCliente(legajoCliente);

            dgv_vehiculos.DataSource = vehiculos;
            tab_vehiculos.Text = "Vehículos (" + vehiculos.Count + ")";

            if (vehiculos.Count == 0)
            {
                vehiculoSeleccionado = null;
                pnl_vehiculo.Visible = false;
            }
        }

        private void dgv_vehiculos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_vehiculos.SelectedRows.Count == 0)
            {
                return;
            }

            Vehiculo fila = (Vehiculo)dgv_vehiculos.SelectedRows[0].DataBoundItem;
            MostrarVehiculo(VehiculoNegocio.BuscarVehiculoDeCliente(fila.IdVehiculo, legajoCliente));
        }

        private void MostrarVehiculo(Vehiculo vehiculo)
        {
            vehiculoSeleccionado = vehiculo;
            pnl_vehiculo.Visible = vehiculo != null;
            if (vehiculo == null)
            {
                return;
            }

            lbl_vehiculo_titulo.Text = vehiculo.Dominio + " · " + vehiculo.MarcaYModelo + " (" + vehiculo.Anio + ")";
            // chasis y motor: hay que compararlos con las fotos antes de aprobar
            lbl_vehiculo_datos.Text = "Chasis: " + vehiculo.NumeroChasis + "   ·   Motor: " + vehiculo.NumeroMotor;

            fotos = new Dictionary<string, byte[]>();
            foreach (FotoVehiculo foto in VehiculoNegocio.ListarFotos(vehiculo.IdVehiculo, legajoCliente))
            {
                fotos[foto.Posicion] = foto.Imagen;
            }
            for (int i = 0; i < casilleros.Length; i++)
            {
                string posicion = VehiculoNegocio.Posiciones[i];
                casilleros[i].Image = fotos.ContainsKey(posicion) ? Imagenes.AImagen(fotos[posicion]) : null;
            }

            lbl_revision_valor.Text = vehiculo.EstadoRevision;
            lbl_revision_valor.BackColor = Estilos.ColorEstado(vehiculo.EstadoRevision);

            if (vehiculo.EstadoRevision == "Pendiente")
            {
                lbl_revision_detalle.Text = "Revise las " + VehiculoNegocio.Posiciones.Length + " fotos (clic para verlas en grande) antes de aprobar.";
            }
            else
            {
                lbl_revision_detalle.Text = "Revisado por " + vehiculo.Revisor + " el " + vehiculo.FechaRevision.Value.ToString("dd/MM/yyyy HH:mm") + ".";
                if (vehiculo.EstadoRevision == "Rechazado")
                {
                    lbl_revision_detalle.Text += "\nMotivo: " + vehiculo.ObservacionRevision;
                }
            }

            // solo se aprueba o rechaza un vehículo pendiente
            btn_aprobar.Visible = vehiculo.EstadoRevision == "Pendiente";
            btn_rechazar.Visible = vehiculo.EstadoRevision == "Pendiente";
        }

        private void casillero_Click(object sender, EventArgs e)
        {
            int numero = (int)((PictureBox)sender).Tag;
            string posicion = VehiculoNegocio.Posiciones[numero];

            if (fotos.ContainsKey(posicion))
            {
                new VerFoto(vehiculoSeleccionado.Dominio + " · " + posicion, Imagenes.AImagen(fotos[posicion])).ShowDialog();
            }
        }

        private void btn_aprobar_Click(object sender, EventArgs e)
        {
            string mensaje;

            DialogResult respuesta = MessageBox.Show("¿Aprobar el vehículo " + vehiculoSeleccionado.Dominio + "?\nLas fotos quedan como registro del estado inicial y el cliente ya no podrá modificarlo.", "Aprobar vehículo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                if (VehiculoNegocio.Aprobar(vehiculoSeleccionado.IdVehiculo, legajoCliente, out mensaje))
                {
                    RefrescarVehiculos();
                }
                else
                {
                    MessageBox.Show(mensaje, "Aprobar vehículo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btn_rechazar_Click(object sender, EventArgs e)
        {
            string mensaje;

            string motivo = Microsoft.VisualBasic.Interaction.InputBox(
                "Va a rechazar el vehículo " + vehiculoSeleccionado.Dominio + ".\n\nIndique el motivo (el cliente lo va a ver para corregirlo):",
                "Rechazar vehículo");

            if (VehiculoNegocio.Rechazar(vehiculoSeleccionado.IdVehiculo, legajoCliente, motivo, out mensaje))
            {
                RefrescarVehiculos();
            }
            else
            {
                MessageBox.Show(mensaje, "Rechazar vehículo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        // Recarga la grilla de vehículos y vuelve a elegir el mismo
        private void RefrescarVehiculos()
        {
            int id = vehiculoSeleccionado.IdVehiculo;
            CargarVehiculos();

            foreach (DataGridViewRow fila in dgv_vehiculos.Rows)
            {
                if (((Vehiculo)fila.DataBoundItem).IdVehiculo == id)
                {
                    dgv_vehiculos.CurrentCell = fila.Cells[0];
                    break;
                }
            }
            MostrarVehiculo(VehiculoNegocio.BuscarVehiculoDeCliente(id, legajoCliente));
        }

        // Pinta las columnas de estado (y la VTV) con su color en todas las grillas
        private void grilla_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            string columna = ((DataGridView)sender).Columns[e.ColumnIndex].Name;

            if ((columna.EndsWith("_estado") || columna == "col_veh_vtv") && e.Value != null)
            {
                e.CellStyle.ForeColor = Estilos.ColorEstado(e.Value.ToString());
                e.CellStyle.Font = Estilos.Negrita;
            }
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            ((Principal)this.ParentForm).AbrirForm(new Usuarios());
        }
    }
}
