using FixedSegurosApp.Entidades;
using FixedSegurosApp.Negocio;
using FixedSegurosApp.Utilidades;
using System;
using System.Windows.Forms;

namespace FixedSegurosApp.Vistas
{
    public partial class Principal : Form
    {
        // El Login lo consulta para saber si tiene que volver a mostrarse
        public bool CerroSesion { get; private set; }

        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            Persona usuario = Sesion.UsuarioActual;

            this.Text = "Fixed Seguros: " + usuario.Perfil;
            lbl_usuario.Text = usuario.Apellido + ", " + usuario.Nombre;
            lbl_estado_perfil.Text = usuario.Perfil;

            foreach (Button btn in flp_menu.Controls)
            {
                Estilos.BotonMenu(btn);
            }

            ConfigurarMenu(usuario.Perfil);

            btn_inicio.PerformClick();
        }

        // Muestra solo los modulos que puede ver cada perfil (tabla de la guia visual)
        private void ConfigurarMenu(string perfil)
        {
            btn_usuarios.Visible = perfil == "Administrador" || perfil == "Empleado";
            btn_empleados.Visible = perfil == "Administrador";
            btn_vehiculos.Visible = perfil == "Cliente";
            btn_siniestros.Visible = perfil == "Empleado" || perfil == "Cliente";
            btn_pagos.Visible = perfil == "Empleado" || perfil == "Cliente";
            btn_proveedores.Visible = perfil == "Administrador";
            btn_notificaciones.Visible = perfil == "Empleado" || perfil == "Cliente";
        }

        // Pinta el boton elegido con el navy oscuro y los demas con el navy principal
        private void SeleccionarBoton(Button seleccionado)
        {
            foreach (Button btn in flp_menu.Controls)
            {
                btn.BackColor = Estilos.NavyPrincipal;
                btn.Font = new System.Drawing.Font("Segoe UI", 10F);
            }
            seleccionado.BackColor = Estilos.NavyOscuro;
            seleccionado.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        }

        // Todos los botones del menu usan este evento
        private void btn_menu_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            SeleccionarBoton(btn);

            // Cada etapa va reemplazando EnConstruccion por la pantalla real del modulo
            if (btn == btn_usuarios)
            {
                AbrirForm(new Usuarios());
            }
            else if (btn == btn_empleados)
            {
                AbrirForm(new Empleados());
            }
            else if (btn == btn_vehiculos)
            {
                AbrirForm(new MisVehiculos());
            }
            else if (btn == btn_polizas)
            {
                // el cliente ve sus pólizas y contrata; admin y empleado hacen el ABM
                if (Sesion.UsuarioActual.Perfil == "Cliente")
                {
                    AbrirForm(new MisPolizas());
                }
                else
                {
                    AbrirForm(new Polizas());
                }
            }
            else if (btn == btn_siniestros)
            {
                // el cliente inicia y sigue sus reclamos; el empleado los verifica
                if (Sesion.UsuarioActual.Perfil == "Cliente")
                {
                    AbrirForm(new MisSiniestros());
                }
                else
                {
                    AbrirForm(new Siniestros());
                }
            }
            else if (btn == btn_pagos)
            {
                AbrirForm(new Pagos());
            }
            else if (btn == btn_proveedores)
            {
                AbrirForm(new Proveedores());
            }
            else
            {
                AbrirForm(new EnConstruccion(btn.Text));
            }
        }

        // Muestra un form dentro del panel de contenido (igual que en FinalTallerProg2).
        // Es publico para que una pantalla pueda abrir otra (ej: Usuarios -> Historial).
        public void AbrirForm(Form formHijo)
        {
            if (pnl_contenido.Controls.Count > 0)
            {
                pnl_contenido.Controls[0].Dispose();
            }
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            pnl_contenido.Controls.Add(formHijo);
            formHijo.Show();
        }

        private void btn_cerrar_sesion_Click(object sender, EventArgs e)
        {
            UsuarioNegocio.CerrarSesion();
            CerroSesion = true;
            this.Close();
        }
    }
}
