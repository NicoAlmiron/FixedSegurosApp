namespace FixedSegurosApp.Vistas
{
    partial class Principal
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            this.pnl_menu = new System.Windows.Forms.Panel();
            this.flp_menu = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_inicio = new System.Windows.Forms.Button();
            this.btn_usuarios = new System.Windows.Forms.Button();
            this.btn_empleados = new System.Windows.Forms.Button();
            this.btn_vehiculos = new System.Windows.Forms.Button();
            this.btn_polizas = new System.Windows.Forms.Button();
            this.btn_siniestros = new System.Windows.Forms.Button();
            this.btn_pagos = new System.Windows.Forms.Button();
            this.btn_proveedores = new System.Windows.Forms.Button();
            this.btn_notificaciones = new System.Windows.Forms.Button();
            this.pnl_sesion = new System.Windows.Forms.Panel();
            this.btn_cerrar_sesion = new System.Windows.Forms.Button();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.lbl_sesion_iniciada = new System.Windows.Forms.Label();
            this.pnl_logo = new System.Windows.Forms.Panel();
            this.lbl_logo = new System.Windows.Forms.Label();
            this.pic_logo = new System.Windows.Forms.PictureBox();
            this.pnl_estado = new System.Windows.Forms.Panel();
            this.lbl_servidor = new System.Windows.Forms.Label();
            this.lbl_estado_perfil = new System.Windows.Forms.Label();
            this.pnl_contenido = new System.Windows.Forms.Panel();
            this.pnl_menu.SuspendLayout();
            this.flp_menu.SuspendLayout();
            this.pnl_sesion.SuspendLayout();
            this.pnl_logo.SuspendLayout();
            this.pnl_estado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            this.SuspendLayout();
            //
            // pnl_menu
            //
            this.pnl_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(58)))), ((int)(((byte)(92)))));
            this.pnl_menu.Controls.Add(this.flp_menu);
            this.pnl_menu.Controls.Add(this.pnl_sesion);
            this.pnl_menu.Controls.Add(this.pnl_logo);
            this.pnl_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_menu.Location = new System.Drawing.Point(0, 0);
            this.pnl_menu.Name = "pnl_menu";
            this.pnl_menu.Size = new System.Drawing.Size(260, 730);
            this.pnl_menu.TabIndex = 0;
            //
            // flp_menu
            //
            this.flp_menu.Controls.Add(this.btn_inicio);
            this.flp_menu.Controls.Add(this.btn_usuarios);
            this.flp_menu.Controls.Add(this.btn_empleados);
            this.flp_menu.Controls.Add(this.btn_vehiculos);
            this.flp_menu.Controls.Add(this.btn_polizas);
            this.flp_menu.Controls.Add(this.btn_siniestros);
            this.flp_menu.Controls.Add(this.btn_pagos);
            this.flp_menu.Controls.Add(this.btn_proveedores);
            this.flp_menu.Controls.Add(this.btn_notificaciones);
            this.flp_menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flp_menu.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flp_menu.Location = new System.Drawing.Point(0, 68);
            this.flp_menu.Name = "flp_menu";
            this.flp_menu.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.flp_menu.Size = new System.Drawing.Size(260, 532);
            this.flp_menu.TabIndex = 1;
            this.flp_menu.WrapContents = false;
            //
            // btn_inicio
            //
            this.btn_inicio.Margin = new System.Windows.Forms.Padding(0);
            this.btn_inicio.Name = "btn_inicio";
            this.btn_inicio.Size = new System.Drawing.Size(260, 52);
            this.btn_inicio.TabIndex = 0;
            this.btn_inicio.Text = "Inicio";
            this.btn_inicio.UseVisualStyleBackColor = false;
            this.btn_inicio.Click += new System.EventHandler(this.btn_menu_Click);
            //
            // btn_usuarios
            //
            this.btn_usuarios.Margin = new System.Windows.Forms.Padding(0);
            this.btn_usuarios.Name = "btn_usuarios";
            this.btn_usuarios.Size = new System.Drawing.Size(260, 52);
            this.btn_usuarios.TabIndex = 1;
            this.btn_usuarios.Text = "Usuarios";
            this.btn_usuarios.UseVisualStyleBackColor = false;
            this.btn_usuarios.Click += new System.EventHandler(this.btn_menu_Click);
            //
            // btn_empleados
            //
            this.btn_empleados.Margin = new System.Windows.Forms.Padding(0);
            this.btn_empleados.Name = "btn_empleados";
            this.btn_empleados.Size = new System.Drawing.Size(260, 52);
            this.btn_empleados.TabIndex = 2;
            this.btn_empleados.Text = "Empleados";
            this.btn_empleados.UseVisualStyleBackColor = false;
            this.btn_empleados.Click += new System.EventHandler(this.btn_menu_Click);
            //
            // btn_vehiculos
            //
            this.btn_vehiculos.Margin = new System.Windows.Forms.Padding(0);
            this.btn_vehiculos.Name = "btn_vehiculos";
            this.btn_vehiculos.Size = new System.Drawing.Size(260, 52);
            this.btn_vehiculos.TabIndex = 3;
            this.btn_vehiculos.Text = "Mis vehículos";
            this.btn_vehiculos.UseVisualStyleBackColor = false;
            this.btn_vehiculos.Click += new System.EventHandler(this.btn_menu_Click);
            //
            // btn_polizas
            //
            this.btn_polizas.Margin = new System.Windows.Forms.Padding(0);
            this.btn_polizas.Name = "btn_polizas";
            this.btn_polizas.Size = new System.Drawing.Size(260, 52);
            this.btn_polizas.TabIndex = 4;
            this.btn_polizas.Text = "Pólizas";
            this.btn_polizas.UseVisualStyleBackColor = false;
            this.btn_polizas.Click += new System.EventHandler(this.btn_menu_Click);
            //
            // btn_siniestros
            //
            this.btn_siniestros.Margin = new System.Windows.Forms.Padding(0);
            this.btn_siniestros.Name = "btn_siniestros";
            this.btn_siniestros.Size = new System.Drawing.Size(260, 52);
            this.btn_siniestros.TabIndex = 5;
            this.btn_siniestros.Text = "Siniestros";
            this.btn_siniestros.UseVisualStyleBackColor = false;
            this.btn_siniestros.Click += new System.EventHandler(this.btn_menu_Click);
            //
            // btn_pagos
            //
            this.btn_pagos.Margin = new System.Windows.Forms.Padding(0);
            this.btn_pagos.Name = "btn_pagos";
            this.btn_pagos.Size = new System.Drawing.Size(260, 52);
            this.btn_pagos.TabIndex = 6;
            this.btn_pagos.Text = "Pagos";
            this.btn_pagos.UseVisualStyleBackColor = false;
            this.btn_pagos.Click += new System.EventHandler(this.btn_menu_Click);
            //
            // btn_proveedores
            //
            this.btn_proveedores.Margin = new System.Windows.Forms.Padding(0);
            this.btn_proveedores.Name = "btn_proveedores";
            this.btn_proveedores.Size = new System.Drawing.Size(260, 52);
            this.btn_proveedores.TabIndex = 7;
            this.btn_proveedores.Text = "Proveedores";
            this.btn_proveedores.UseVisualStyleBackColor = false;
            this.btn_proveedores.Click += new System.EventHandler(this.btn_menu_Click);
            //
            // btn_notificaciones
            //
            this.btn_notificaciones.Margin = new System.Windows.Forms.Padding(0);
            this.btn_notificaciones.Name = "btn_notificaciones";
            this.btn_notificaciones.Size = new System.Drawing.Size(260, 52);
            this.btn_notificaciones.TabIndex = 8;
            this.btn_notificaciones.Text = "Notificaciones";
            this.btn_notificaciones.UseVisualStyleBackColor = false;
            this.btn_notificaciones.Click += new System.EventHandler(this.btn_menu_Click);
            //
            // pnl_sesion
            //
            this.pnl_sesion.Controls.Add(this.btn_cerrar_sesion);
            this.pnl_sesion.Controls.Add(this.lbl_usuario);
            this.pnl_sesion.Controls.Add(this.lbl_sesion_iniciada);
            this.pnl_sesion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_sesion.Location = new System.Drawing.Point(0, 600);
            this.pnl_sesion.Name = "pnl_sesion";
            this.pnl_sesion.Size = new System.Drawing.Size(260, 130);
            this.pnl_sesion.TabIndex = 2;
            //
            // lbl_sesion_iniciada
            //
            this.lbl_sesion_iniciada.AutoSize = true;
            this.lbl_sesion_iniciada.ForeColor = System.Drawing.Color.White;
            this.lbl_sesion_iniciada.Location = new System.Drawing.Point(24, 18);
            this.lbl_sesion_iniciada.Name = "lbl_sesion_iniciada";
            this.lbl_sesion_iniciada.Size = new System.Drawing.Size(122, 15);
            this.lbl_sesion_iniciada.TabIndex = 0;
            this.lbl_sesion_iniciada.Text = "Sesión iniciada como";
            //
            // lbl_usuario
            //
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_usuario.ForeColor = System.Drawing.Color.White;
            this.lbl_usuario.Location = new System.Drawing.Point(24, 38);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(60, 19);
            this.lbl_usuario.TabIndex = 1;
            this.lbl_usuario.Text = "Usuario";
            //
            // btn_cerrar_sesion
            //
            this.btn_cerrar_sesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cerrar_sesion.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_cerrar_sesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(38)))), ((int)(((byte)(63)))));
            this.btn_cerrar_sesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar_sesion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btn_cerrar_sesion.ForeColor = System.Drawing.Color.White;
            this.btn_cerrar_sesion.Location = new System.Drawing.Point(24, 74);
            this.btn_cerrar_sesion.Name = "btn_cerrar_sesion";
            this.btn_cerrar_sesion.Size = new System.Drawing.Size(212, 36);
            this.btn_cerrar_sesion.TabIndex = 2;
            this.btn_cerrar_sesion.Text = "Cerrar sesión";
            this.btn_cerrar_sesion.UseVisualStyleBackColor = false;
            this.btn_cerrar_sesion.Click += new System.EventHandler(this.btn_cerrar_sesion_Click);
            //
            // pnl_logo
            //
            this.pnl_logo.Controls.Add(this.lbl_logo);
            this.pnl_logo.Controls.Add(this.pic_logo);
            this.pnl_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_logo.Location = new System.Drawing.Point(0, 0);
            this.pnl_logo.Name = "pnl_logo";
            this.pnl_logo.Size = new System.Drawing.Size(260, 68);
            this.pnl_logo.TabIndex = 0;
            //
            // pic_logo
            //
            this.pic_logo.Image = global::FixedSegurosApp.Properties.Resources.logo_FS;
            this.pic_logo.Location = new System.Drawing.Point(22, 16);
            this.pic_logo.Name = "pic_logo";
            this.pic_logo.Size = new System.Drawing.Size(30, 34);
            this.pic_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_logo.TabIndex = 0;
            this.pic_logo.TabStop = false;
            //
            // lbl_logo
            //
            this.lbl_logo.AutoSize = true;
            this.lbl_logo.Font = new System.Drawing.Font("Segoe UI Semibold", 14F);
            this.lbl_logo.ForeColor = System.Drawing.Color.White;
            this.lbl_logo.Location = new System.Drawing.Point(58, 18);
            this.lbl_logo.Name = "lbl_logo";
            this.lbl_logo.Size = new System.Drawing.Size(123, 25);
            this.lbl_logo.TabIndex = 1;
            this.lbl_logo.Text = "Fixed Seguros";
            //
            // pnl_estado
            //
            this.pnl_estado.BackColor = System.Drawing.Color.White;
            this.pnl_estado.Controls.Add(this.lbl_servidor);
            this.pnl_estado.Controls.Add(this.lbl_estado_perfil);
            this.pnl_estado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_estado.Location = new System.Drawing.Point(0, 730);
            this.pnl_estado.Name = "pnl_estado";
            this.pnl_estado.Size = new System.Drawing.Size(1280, 30);
            this.pnl_estado.TabIndex = 2;
            //
            // lbl_estado_perfil
            //
            this.lbl_estado_perfil.AutoSize = true;
            this.lbl_estado_perfil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_estado_perfil.Location = new System.Drawing.Point(14, 7);
            this.lbl_estado_perfil.Name = "lbl_estado_perfil";
            this.lbl_estado_perfil.Size = new System.Drawing.Size(36, 15);
            this.lbl_estado_perfil.TabIndex = 0;
            this.lbl_estado_perfil.Text = "Perfil";
            //
            // lbl_servidor
            //
            this.lbl_servidor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_servidor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_servidor.Location = new System.Drawing.Point(1066, 7);
            this.lbl_servidor.Name = "lbl_servidor";
            this.lbl_servidor.Size = new System.Drawing.Size(200, 15);
            this.lbl_servidor.TabIndex = 1;
            this.lbl_servidor.Text = "Servidor local: conectado";
            this.lbl_servidor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // pnl_contenido
            //
            this.pnl_contenido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.pnl_contenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_contenido.Location = new System.Drawing.Point(260, 0);
            this.pnl_contenido.Name = "pnl_contenido";
            this.pnl_contenido.Size = new System.Drawing.Size(1020, 730);
            this.pnl_contenido.TabIndex = 1;
            //
            // Principal
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1280, 760);
            this.Controls.Add(this.pnl_contenido);
            this.Controls.Add(this.pnl_menu);
            this.Controls.Add(this.pnl_estado);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(56)))));
            this.MinimumSize = new System.Drawing.Size(1100, 700);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Icon = global::FixedSegurosApp.Properties.Resources.icono_FS;
            this.Text = "Fixed Seguros";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.pnl_menu.ResumeLayout(false);
            this.flp_menu.ResumeLayout(false);
            this.pnl_sesion.ResumeLayout(false);
            this.pnl_sesion.PerformLayout();
            this.pnl_logo.ResumeLayout(false);
            this.pnl_logo.PerformLayout();
            this.pnl_estado.ResumeLayout(false);
            this.pnl_estado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_menu;
        private System.Windows.Forms.FlowLayoutPanel flp_menu;
        private System.Windows.Forms.Button btn_inicio;
        private System.Windows.Forms.Button btn_usuarios;
        private System.Windows.Forms.Button btn_empleados;
        private System.Windows.Forms.Button btn_vehiculos;
        private System.Windows.Forms.Button btn_polizas;
        private System.Windows.Forms.Button btn_siniestros;
        private System.Windows.Forms.Button btn_pagos;
        private System.Windows.Forms.Button btn_proveedores;
        private System.Windows.Forms.Button btn_notificaciones;
        private System.Windows.Forms.Panel pnl_sesion;
        private System.Windows.Forms.Button btn_cerrar_sesion;
        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.Label lbl_sesion_iniciada;
        private System.Windows.Forms.Panel pnl_logo;
        private System.Windows.Forms.Label lbl_logo;
        private System.Windows.Forms.PictureBox pic_logo;
        private System.Windows.Forms.Panel pnl_estado;
        private System.Windows.Forms.Label lbl_servidor;
        private System.Windows.Forms.Label lbl_estado_perfil;
        private System.Windows.Forms.Panel pnl_contenido;
    }
}
