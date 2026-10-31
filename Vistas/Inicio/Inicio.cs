using FixedSegurosApp.Entidades;
using FixedSegurosApp.Negocio;
using FixedSegurosApp.Utilidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FixedSegurosApp.Vistas
{
    // Pantalla de entrada: cuatro tarjetas de resumen según el perfil y las pólizas que requieren atención.
    // El Administrador tiene además accesos rápidos; todos entran a Mi cuenta.
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
            dgv_alertas.AutoGenerateColumns = false;
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            string perfil = Sesion.UsuarioActual.Perfil;

            Estilos.Tarjeta(pnl_tarjeta1);
            Estilos.Tarjeta(pnl_tarjeta2);
            Estilos.Tarjeta(pnl_tarjeta3);
            Estilos.Tarjeta(pnl_tarjeta4);
            Estilos.Tarjeta(pnl_aviso);
            Estilos.Tarjeta(pnl_alertas);
            Estilos.Grilla(dgv_alertas);
            Estilos.BotonPrincipal(btn_nueva_poliza);
            Estilos.BotonSecundario(btn_habilitar);
            Estilos.BotonSecundario(btn_aseguradora);
            Estilos.BotonSecundario(btn_mi_cuenta);
            Estilos.BotonPrincipal(btn_cambiar);

            // los accesos rápidos son tareas del Administrador
            btn_nueva_poliza.Visible = perfil == "Administrador";
            btn_habilitar.Visible = perfil == "Administrador";
            btn_aseguradora.Visible = perfil == "Administrador";

            if (perfil == "Cliente")
            {
                lbl_alertas_titulo.Text = "Mis pólizas por vencer o con cuota impaga";
                col_cliente.Visible = false;
                lbl_mostrar.Visible = false;
                cb_aseguradora.Visible = false;
                CargarAlertas(0);
            }
            else
            {
                // la primera opción no filtra: Id 0 son todas las aseguradoras
                List<Proveedor> aseguradoras = ProveedorNegocio.ListarProveedores("");
                aseguradoras.Insert(0, new Proveedor() { IdProveedor = 0, Nombre = "Todas las aseguradoras" });

                cb_aseguradora.DisplayMember = "Nombre";
                cb_aseguradora.ValueMember = "IdProveedor";
                cb_aseguradora.DataSource = aseguradoras;     // al cargarlo se llena la grilla
            }

            CargarTarjetas();
            MostrarAvisoContrasena();
        }

        private void CargarTarjetas()
        {
            List<TarjetaInicio> tarjetas = InicioNegocio.ListarTarjetas();

            MostrarTarjeta(tarjetas[0], lbl_titulo1, lbl_valor1, lbl_detalle1);
            MostrarTarjeta(tarjetas[1], lbl_titulo2, lbl_valor2, lbl_detalle2);
            MostrarTarjeta(tarjetas[2], lbl_titulo3, lbl_valor3, lbl_detalle3);
            MostrarTarjeta(tarjetas[3], lbl_titulo4, lbl_valor4, lbl_detalle4);
        }

        private void MostrarTarjeta(TarjetaInicio tarjeta, Label titulo, Label valor, Label detalle)
        {
            titulo.Text = tarjeta.Titulo;
            valor.Text = tarjeta.Valor;
            valor.ForeColor = tarjeta.Alerta ? Estilos.Peligro : Estilos.NavyPrincipal;
            detalle.Text = tarjeta.Detalle;
        }

        // El aviso ocupa una franja debajo de las tarjetas; sin aviso la grilla sube y usa ese lugar
        private void MostrarAvisoContrasena()
        {
            bool mostrar = UsuarioNegocio.TieneContrasenaInicial();

            pnl_aviso.Visible = mostrar;

            int abajo = pnl_alertas.Bottom;
            pnl_alertas.Top = mostrar ? pnl_aviso.Bottom + 12 : pnl_aviso.Top;
            pnl_alertas.Height = abajo - pnl_alertas.Top;
        }

        private void CargarAlertas(int idProveedor)
        {
            List<AlertaPoliza> alertas = InicioNegocio.ListarAlertas(idProveedor);

            dgv_alertas.DataSource = alertas;
            lbl_cantidad.Text = alertas.Count == 0 ? "No hay pólizas que requieran atención" : "Mostrando " + alertas.Count + (alertas.Count == 1 ? " póliza" : " pólizas");
        }

        private void cb_aseguradora_SelectedIndexChanged(object sender, EventArgs e)
        {
            Proveedor aseguradora = cb_aseguradora.SelectedItem as Proveedor;

            if (aseguradora != null)
            {
                CargarAlertas(aseguradora.IdProveedor);
            }
        }

        private void btn_mi_cuenta_Click(object sender, EventArgs e)
        {
            new MiCuenta().ShowDialog();
            MostrarAvisoContrasena();
        }

        private void btn_nueva_poliza_Click(object sender, EventArgs e)
        {
            ((Principal)this.ParentForm).AbrirModulo("Pólizas");
        }

        private void btn_habilitar_Click(object sender, EventArgs e)
        {
            ((Principal)this.ParentForm).AbrirModulo("Empleados");
        }

        private void btn_aseguradora_Click(object sender, EventArgs e)
        {
            ((Principal)this.ParentForm).AbrirModulo("Proveedores");
        }

        // Sin fila elegida: la selección taparía el color de la alerta
        private void dgv_alertas_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgv_alertas.ClearSelection();
        }

        // Pinta la alerta: rojo si debe cuotas, amarillo si está por vencer
        private void dgv_alertas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == col_alerta.Index && e.Value != null)
            {
                AlertaPoliza alerta = (AlertaPoliza)dgv_alertas.Rows[e.RowIndex].DataBoundItem;

                e.CellStyle.ForeColor = alerta.CuotasVencidas > 0 ? Estilos.Peligro : Estilos.Advertencia;
                e.CellStyle.Font = Estilos.Negrita;
            }
        }
    }
}
