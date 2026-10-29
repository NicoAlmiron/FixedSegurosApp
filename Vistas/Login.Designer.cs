namespace FixedSegurosApp.Vistas
{
    partial class Login
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
            this.pnl_cabecera = new System.Windows.Forms.Panel();
            this.lbl_subtitulo = new System.Windows.Forms.Label();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.pic_logo = new System.Windows.Forms.PictureBox();
            this.pnl_pie = new System.Windows.Forms.Panel();
            this.lbl_version = new System.Windows.Forms.Label();
            this.lbl_dni = new System.Windows.Forms.Label();
            this.txt_dni = new System.Windows.Forms.TextBox();
            this.lbl_contrasena = new System.Windows.Forms.Label();
            this.txt_contrasena = new System.Windows.Forms.TextBox();
            this.chk_mostrar = new System.Windows.Forms.CheckBox();
            this.lnk_olvido = new System.Windows.Forms.LinkLabel();
            this.btn_ingresar = new System.Windows.Forms.Button();
            this.pnl_separador = new System.Windows.Forms.Panel();
            this.lbl_cliente_nuevo = new System.Windows.Forms.Label();
            this.btn_registrarme = new System.Windows.Forms.Button();
            this.pnl_cabecera.SuspendLayout();
            this.pnl_pie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_cabecera
            // 
            this.pnl_cabecera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(58)))), ((int)(((byte)(92)))));
            this.pnl_cabecera.Controls.Add(this.lbl_subtitulo);
            this.pnl_cabecera.Controls.Add(this.lbl_titulo);
            this.pnl_cabecera.Controls.Add(this.pic_logo);
            this.pnl_cabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_cabecera.Location = new System.Drawing.Point(0, 0);
            this.pnl_cabecera.Name = "pnl_cabecera";
            this.pnl_cabecera.Size = new System.Drawing.Size(500, 170);
            this.pnl_cabecera.TabIndex = 0;
            // 
            // lbl_subtitulo
            // 
            this.lbl_subtitulo.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lbl_subtitulo.ForeColor = System.Drawing.Color.White;
            this.lbl_subtitulo.Location = new System.Drawing.Point(0, 120);
            this.lbl_subtitulo.Name = "lbl_subtitulo";
            this.lbl_subtitulo.Size = new System.Drawing.Size(500, 26);
            this.lbl_subtitulo.TabIndex = 2;
            this.lbl_subtitulo.Text = "Gestión de pólizas y siniestros";
            this.lbl_subtitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.Font = new System.Drawing.Font("Segoe UI Semibold", 20F);
            this.lbl_titulo.ForeColor = System.Drawing.Color.White;
            this.lbl_titulo.Location = new System.Drawing.Point(0, 76);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(500, 42);
            this.lbl_titulo.TabIndex = 1;
            this.lbl_titulo.Text = "Fixed Seguros";
            this.lbl_titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pic_logo
            //
            this.pic_logo.Image = global::FixedSegurosApp.Properties.Resources.logo_FS;
            this.pic_logo.Location = new System.Drawing.Point(222, 14);
            this.pic_logo.Name = "pic_logo";
            this.pic_logo.Size = new System.Drawing.Size(56, 60);
            this.pic_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_logo.TabIndex = 0;
            this.pic_logo.TabStop = false;
            // 
            // pnl_pie
            // 
            this.pnl_pie.BackColor = System.Drawing.Color.White;
            this.pnl_pie.Controls.Add(this.lbl_version);
            this.pnl_pie.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_pie.Location = new System.Drawing.Point(0, 508);
            this.pnl_pie.Name = "pnl_pie";
            this.pnl_pie.Size = new System.Drawing.Size(500, 32);
            this.pnl_pie.TabIndex = 9;
            // 
            // lbl_version
            // 
            this.lbl_version.AutoSize = true;
            this.lbl_version.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_version.Location = new System.Drawing.Point(12, 8);
            this.lbl_version.Name = "lbl_version";
            this.lbl_version.Size = new System.Drawing.Size(63, 15);
            this.lbl_version.TabIndex = 0;
            this.lbl_version.Text = "Versión 1.0";
            // 
            // lbl_dni
            // 
            this.lbl_dni.AutoSize = true;
            this.lbl_dni.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbl_dni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_dni.Location = new System.Drawing.Point(60, 194);
            this.lbl_dni.Name = "lbl_dni";
            this.lbl_dni.Size = new System.Drawing.Size(92, 19);
            this.lbl_dni.TabIndex = 1;
            this.lbl_dni.Text = "Usuario (DNI)";
            // 
            // txt_dni
            // 
            this.txt_dni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_dni.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txt_dni.Location = new System.Drawing.Point(60, 217);
            this.txt_dni.MaxLength = 8;
            this.txt_dni.Name = "txt_dni";
            this.txt_dni.Size = new System.Drawing.Size(380, 27);
            this.txt_dni.TabIndex = 2;
            // 
            // lbl_contrasena
            // 
            this.lbl_contrasena.AutoSize = true;
            this.lbl_contrasena.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbl_contrasena.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_contrasena.Location = new System.Drawing.Point(60, 258);
            this.lbl_contrasena.Name = "lbl_contrasena";
            this.lbl_contrasena.Size = new System.Drawing.Size(79, 19);
            this.lbl_contrasena.TabIndex = 3;
            this.lbl_contrasena.Text = "Contraseña";
            // 
            // txt_contrasena
            // 
            this.txt_contrasena.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_contrasena.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txt_contrasena.Location = new System.Drawing.Point(60, 281);
            this.txt_contrasena.Name = "txt_contrasena";
            this.txt_contrasena.Size = new System.Drawing.Size(380, 27);
            this.txt_contrasena.TabIndex = 4;
            this.txt_contrasena.UseSystemPasswordChar = true;
            // 
            // chk_mostrar
            // 
            this.chk_mostrar.AutoSize = true;
            this.chk_mostrar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chk_mostrar.Location = new System.Drawing.Point(60, 322);
            this.chk_mostrar.Name = "chk_mostrar";
            this.chk_mostrar.Size = new System.Drawing.Size(148, 23);
            this.chk_mostrar.TabIndex = 5;
            this.chk_mostrar.Text = "Mostrar contraseña";
            this.chk_mostrar.UseVisualStyleBackColor = true;
            this.chk_mostrar.CheckedChanged += new System.EventHandler(this.chk_mostrar_CheckedChanged);
            // 
            // lnk_olvido
            // 
            this.lnk_olvido.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lnk_olvido.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(111)))), ((int)(((byte)(176)))));
            this.lnk_olvido.Location = new System.Drawing.Point(260, 322);
            this.lnk_olvido.Name = "lnk_olvido";
            this.lnk_olvido.Size = new System.Drawing.Size(180, 23);
            this.lnk_olvido.TabIndex = 6;
            this.lnk_olvido.TabStop = true;
            this.lnk_olvido.Text = "¿Olvidó su contraseña?";
            this.lnk_olvido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lnk_olvido.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_olvido_LinkClicked);
            // 
            // btn_ingresar
            // 
            this.btn_ingresar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btn_ingresar.Location = new System.Drawing.Point(60, 360);
            this.btn_ingresar.Name = "btn_ingresar";
            this.btn_ingresar.Size = new System.Drawing.Size(380, 42);
            this.btn_ingresar.TabIndex = 7;
            this.btn_ingresar.Text = "Ingresar";
            this.btn_ingresar.UseVisualStyleBackColor = false;
            this.btn_ingresar.Click += new System.EventHandler(this.btn_ingresar_Click);
            // 
            // pnl_separador
            // 
            this.pnl_separador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(221)))), ((int)(((byte)(232)))));
            this.pnl_separador.Location = new System.Drawing.Point(60, 424);
            this.pnl_separador.Name = "pnl_separador";
            this.pnl_separador.Size = new System.Drawing.Size(380, 1);
            this.pnl_separador.TabIndex = 10;
            // 
            // lbl_cliente_nuevo
            // 
            this.lbl_cliente_nuevo.AutoSize = true;
            this.lbl_cliente_nuevo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbl_cliente_nuevo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_cliente_nuevo.Location = new System.Drawing.Point(60, 455);
            this.lbl_cliente_nuevo.Name = "lbl_cliente_nuevo";
            this.lbl_cliente_nuevo.Size = new System.Drawing.Size(105, 19);
            this.lbl_cliente_nuevo.TabIndex = 11;
            this.lbl_cliente_nuevo.Text = "¿Cliente nuevo?";
            // 
            // btn_registrarme
            // 
            this.btn_registrarme.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_registrarme.Location = new System.Drawing.Point(310, 446);
            this.btn_registrarme.Name = "btn_registrarme";
            this.btn_registrarme.Size = new System.Drawing.Size(130, 36);
            this.btn_registrarme.TabIndex = 8;
            this.btn_registrarme.Text = "Registrarme";
            this.btn_registrarme.UseVisualStyleBackColor = false;
            this.btn_registrarme.Click += new System.EventHandler(this.btn_registrarme_Click);
            // 
            // Login
            // 
            this.AcceptButton = this.btn_ingresar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(500, 540);
            this.Controls.Add(this.btn_registrarme);
            this.Controls.Add(this.lbl_cliente_nuevo);
            this.Controls.Add(this.pnl_separador);
            this.Controls.Add(this.btn_ingresar);
            this.Controls.Add(this.lnk_olvido);
            this.Controls.Add(this.chk_mostrar);
            this.Controls.Add(this.txt_contrasena);
            this.Controls.Add(this.lbl_contrasena);
            this.Controls.Add(this.txt_dni);
            this.Controls.Add(this.lbl_dni);
            this.Controls.Add(this.pnl_pie);
            this.Controls.Add(this.pnl_cabecera);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(56)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Icon = global::FixedSegurosApp.Properties.Resources.icono_FS;
            this.Text = "Fixed Seguros: Iniciar sesión";
            this.Load += new System.EventHandler(this.Login_Load);
            this.pnl_cabecera.ResumeLayout(false);
            this.pnl_pie.ResumeLayout(false);
            this.pnl_pie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_cabecera;
        private System.Windows.Forms.PictureBox pic_logo;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_subtitulo;
        private System.Windows.Forms.Panel pnl_pie;
        private System.Windows.Forms.Label lbl_version;
        private System.Windows.Forms.Label lbl_dni;
        private System.Windows.Forms.TextBox txt_dni;
        private System.Windows.Forms.Label lbl_contrasena;
        private System.Windows.Forms.TextBox txt_contrasena;
        private System.Windows.Forms.CheckBox chk_mostrar;
        private System.Windows.Forms.LinkLabel lnk_olvido;
        private System.Windows.Forms.Button btn_ingresar;
        private System.Windows.Forms.Panel pnl_separador;
        private System.Windows.Forms.Label lbl_cliente_nuevo;
        private System.Windows.Forms.Button btn_registrarme;
    }
}
