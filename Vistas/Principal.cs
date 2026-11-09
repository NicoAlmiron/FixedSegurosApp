using FixedSegurosApp.Entidades;
using FixedSegurosApp.Negocio;
using FixedSegurosApp.Utilidades;
using System;
using System.Windows.Forms;

namespace FixedSegurosApp.Vistas
{
    // Ventana principal: menú lateral según el perfil y, al centro, el panel donde abro cada módulo.
    // Abajo está la barra con el perfil, la versión y el servidor
    public partial class Principal : Form
    {
        // El Login lo consulta para saber si tiene que volver a mostrarse
        public bool CerroSesion { get; private set; }

        // Constructor de la ventana
        public Principal()
        {
            InitializeComponent();
        }

        // Al abrir la ventana: estilos, el menú según el perfil, la barra de abajo y la pantalla Inicio
        private void Principal_Load(object sender, EventArgs e)
        {
            Persona usuario = Sesion.UsuarioActual;

            this.Text = "Fixed Seguros: " + usuario.Perfil;
            MostrarNombreUsuario();
            lbl_estado_perfil.Text = usuario.Perfil;

            bool conectado;
            lbl_servidor.Text = UsuarioNegocio.TextoServidor(out conectado);
            lbl_servidor.ForeColor = conectado ? Estilos.TextoSecundario : Estilos.Peligro;

            foreach (Button btn in flp_menu.Controls)
            {
                Estilos.BotonMenu(btn);
            }

            ConfigurarMenu(usuario.Perfil);

            btn_inicio.PerformClick();
        }

        // Muestro el nombre del usuario en el menú. Es público porque el administrador puede cambiar su nombre desde Mi cuenta
        public void MostrarNombreUsuario()
        {
            lbl_usuario.Text = Sesion.UsuarioActual.Apellido + ", " + Sesion.UsuarioActual.Nombre;
        }

        // Si hay novedades el botón del menú va en negrita y con la cantidad.
        // Es público para que lo llame Notificaciones cuando se lee un aviso
        public void ActualizarNotificaciones()
        {
            if (Sesion.UsuarioActual.Perfil == "Administrador")
            {
                return;
            }

            int nuevas = NotificacionNegocio.ContarNuevas();
            bool seleccionado = btn_notificaciones.BackColor == Estilos.NavyOscuro;

            btn_notificaciones.Text = nuevas > 0 ? "Notificaciones (" + nuevas + ")" : "Notificaciones";
            btn_notificaciones.Font = new System.Drawing.Font("Segoe UI", 10F, nuevas > 0 || seleccionado ? System.Drawing.FontStyle.Bold : System.Drawing.FontStyle.Regular);
        }

        // Muestro solo los módulos que puede ver cada perfil; el FlowLayoutPanel acomoda los visibles sin dejar huecos
        private void ConfigurarMenu(string perfil)
        {
            btn_usuarios.Visible = perfil == "Administrador" || perfil == "Empleado";
            btn_empleados.Visible = perfil == "Administrador";
            btn_vehiculos.Visible = perfil == "Cliente";
            btn_siniestros.Visible = perfil == "Empleado" || perfil == "Cliente";
            btn_pagos.Visible = perfil == "Empleado" || perfil == "Cliente";
            btn_proveedores.Visible = perfil == "Administrador";
            btn_reportes.Visible = perfil == "Administrador";
            btn_notificaciones.Visible = perfil == "Empleado" || perfil == "Cliente";
        }

        // Pinto el botón elegido con el azul oscuro y los demás con el azul principal
        private void SeleccionarBoton(Button seleccionado)
        {
            foreach (Button btn in flp_menu.Controls)
            {
                btn.BackColor = Estilos.NavyPrincipal;
                btn.Font = new System.Drawing.Font("Segoe UI", 10F);
            }
            seleccionado.BackColor = Estilos.NavyOscuro;
            seleccionado.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);

            // el recorrido de arriba le saca la negrita, y se puede haber resuelto algo en la pantalla anterior
            ActualizarNotificaciones();
        }

        // Todos los botones del menú usan este evento: según el botón tocado abro el módulo que corresponde
        private void btn_menu_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            SeleccionarBoton(btn);

            if (btn == btn_inicio)
            {
                AbrirForm(new Inicio());
            }
            else if (btn == btn_usuarios)
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
            else if (btn == btn_reportes)
            {
                AbrirForm(new Reportes());
            }
            else if (btn == btn_notificaciones)
            {
                AbrirForm(new Notificaciones());
            }
        }

        // Abro un módulo como si se hubiera tocado su botón del menú (lo usan los accesos rápidos de Inicio)
        public void AbrirModulo(string nombre)
        {
            foreach (Button btn in flp_menu.Controls)
            {
                if (btn.Text == nombre)
                {
                    btn.PerformClick();
                }
            }
        }

        // Muestro un form dentro del panel de contenido (igual que en FinalTallerProg2).
        // Es público para que una pantalla pueda abrir otra (ej: Usuarios -> Historial)
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

        // Cierro la sesión y vuelvo al Login
        private void btn_cerrar_sesion_Click(object sender, EventArgs e)
        {
            UsuarioNegocio.CerrarSesion();
            CerroSesion = true;
            this.Close();
        }
    }
}
