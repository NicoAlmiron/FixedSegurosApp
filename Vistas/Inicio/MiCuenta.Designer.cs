namespace FixedSegurosApp.Vistas
{
    partial class MiCuenta
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
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.pnl_contrasena = new System.Windows.Forms.Panel();
            this.lbl_contrasena_titulo = new System.Windows.Forms.Label();
            this.lbl_actual = new System.Windows.Forms.Label();
            this.txt_actual = new System.Windows.Forms.TextBox();
            this.lbl_nueva = new System.Windows.Forms.Label();
            this.txt_nueva = new System.Windows.Forms.TextBox();
            this.lbl_repetir = new System.Windows.Forms.Label();
            this.txt_repetir = new System.Windows.Forms.TextBox();
            this.btn_cambiar = new System.Windows.Forms.Button();
            this.pnl_datos = new System.Windows.Forms.Panel();
            this.lbl_datos_titulo = new System.Windows.Forms.Label();
            this.lbl_telefono = new System.Windows.Forms.Label();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lbl_provincia = new System.Windows.Forms.Label();
            this.cb_provincia = new System.Windows.Forms.ComboBox();
            this.lbl_ciudad = new System.Windows.Forms.Label();
            this.txt_ciudad = new System.Windows.Forms.TextBox();
            this.lbl_direccion = new System.Windows.Forms.Label();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.pnl_contrasena.SuspendLayout();
            this.pnl_datos.SuspendLayout();
            this.SuspendLayout();
            //
            // lbl_titulo
            //
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Segoe UI Semibold", 16F);
            this.lbl_titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(58)))), ((int)(((byte)(92)))));
            this.lbl_titulo.Location = new System.Drawing.Point(20, 14);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(110, 30);
            this.lbl_titulo.Text = "Mi cuenta";
            //
            // pnl_contrasena
            //
            this.pnl_contrasena.Controls.Add(this.lbl_contrasena_titulo);
            this.pnl_contrasena.Controls.Add(this.lbl_actual);
            this.pnl_contrasena.Controls.Add(this.txt_actual);
            this.pnl_contrasena.Controls.Add(this.lbl_nueva);
            this.pnl_contrasena.Controls.Add(this.txt_nueva);
            this.pnl_contrasena.Controls.Add(this.lbl_repetir);
            this.pnl_contrasena.Controls.Add(this.txt_repetir);
            this.pnl_contrasena.Controls.Add(this.btn_cambiar);
            this.pnl_contrasena.Location = new System.Drawing.Point(24, 58);
            this.pnl_contrasena.Name = "pnl_contrasena";
            this.pnl_contrasena.Size = new System.Drawing.Size(472, 212);
            this.pnl_contrasena.TabIndex = 0;
            //
            // lbl_contrasena_titulo
            //
            this.lbl_contrasena_titulo.AutoSize = true;
            this.lbl_contrasena_titulo.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.lbl_contrasena_titulo.Location = new System.Drawing.Point(14, 12);
            this.lbl_contrasena_titulo.Name = "lbl_contrasena_titulo";
            this.lbl_contrasena_titulo.Size = new System.Drawing.Size(140, 20);
            this.lbl_contrasena_titulo.Text = "Cambiar contraseña";
            //
            // lbl_actual
            //
            this.lbl_actual.AutoSize = true;
            this.lbl_actual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_actual.Location = new System.Drawing.Point(16, 42);
            this.lbl_actual.Name = "lbl_actual";
            this.lbl_actual.Size = new System.Drawing.Size(100, 15);
            this.lbl_actual.Text = "Contraseña actual";
            //
            // txt_actual
            //
            this.txt_actual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_actual.Location = new System.Drawing.Point(16, 60);
            this.txt_actual.Name = "txt_actual";
            this.txt_actual.Size = new System.Drawing.Size(440, 23);
            this.txt_actual.TabIndex = 0;
            this.txt_actual.UseSystemPasswordChar = true;
            //
            // lbl_nueva
            //
            this.lbl_nueva.AutoSize = true;
            this.lbl_nueva.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_nueva.Location = new System.Drawing.Point(16, 94);
            this.lbl_nueva.Name = "lbl_nueva";
            this.lbl_nueva.Size = new System.Drawing.Size(100, 15);
            this.lbl_nueva.Text = "Contraseña nueva";
            //
            // txt_nueva
            //
            this.txt_nueva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_nueva.Location = new System.Drawing.Point(16, 112);
            this.txt_nueva.Name = "txt_nueva";
            this.txt_nueva.Size = new System.Drawing.Size(212, 23);
            this.txt_nueva.TabIndex = 1;
            this.txt_nueva.UseSystemPasswordChar = true;
            //
            // lbl_repetir
            //
            this.lbl_repetir.AutoSize = true;
            this.lbl_repetir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_repetir.Location = new System.Drawing.Point(244, 94);
            this.lbl_repetir.Name = "lbl_repetir";
            this.lbl_repetir.Size = new System.Drawing.Size(120, 15);
            this.lbl_repetir.Text = "Repetir contraseña";
            //
            // txt_repetir
            //
            this.txt_repetir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_repetir.Location = new System.Drawing.Point(244, 112);
            this.txt_repetir.Name = "txt_repetir";
            this.txt_repetir.Size = new System.Drawing.Size(212, 23);
            this.txt_repetir.TabIndex = 2;
            this.txt_repetir.UseSystemPasswordChar = true;
            //
            // btn_cambiar
            //
            this.btn_cambiar.Location = new System.Drawing.Point(296, 160);
            this.btn_cambiar.Name = "btn_cambiar";
            this.btn_cambiar.Size = new System.Drawing.Size(160, 34);
            this.btn_cambiar.TabIndex = 3;
            this.btn_cambiar.Text = "Cambiar contraseña";
            this.btn_cambiar.UseVisualStyleBackColor = false;
            this.btn_cambiar.Click += new System.EventHandler(this.btn_cambiar_Click);
            //
            // pnl_datos
            //
            this.pnl_datos.Controls.Add(this.lbl_datos_titulo);
            this.pnl_datos.Controls.Add(this.lbl_telefono);
            this.pnl_datos.Controls.Add(this.txt_telefono);
            this.pnl_datos.Controls.Add(this.lbl_email);
            this.pnl_datos.Controls.Add(this.txt_email);
            this.pnl_datos.Controls.Add(this.lbl_provincia);
            this.pnl_datos.Controls.Add(this.cb_provincia);
            this.pnl_datos.Controls.Add(this.lbl_ciudad);
            this.pnl_datos.Controls.Add(this.txt_ciudad);
            this.pnl_datos.Controls.Add(this.lbl_direccion);
            this.pnl_datos.Controls.Add(this.txt_direccion);
            this.pnl_datos.Controls.Add(this.btn_guardar);
            this.pnl_datos.Location = new System.Drawing.Point(24, 282);
            this.pnl_datos.Name = "pnl_datos";
            this.pnl_datos.Size = new System.Drawing.Size(472, 264);
            this.pnl_datos.TabIndex = 1;
            //
            // lbl_datos_titulo
            //
            this.lbl_datos_titulo.AutoSize = true;
            this.lbl_datos_titulo.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.lbl_datos_titulo.Location = new System.Drawing.Point(14, 12);
            this.lbl_datos_titulo.Name = "lbl_datos_titulo";
            this.lbl_datos_titulo.Size = new System.Drawing.Size(130, 20);
            this.lbl_datos_titulo.Text = "Datos de contacto";
            //
            // lbl_telefono
            //
            this.lbl_telefono.AutoSize = true;
            this.lbl_telefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_telefono.Location = new System.Drawing.Point(16, 42);
            this.lbl_telefono.Name = "lbl_telefono";
            this.lbl_telefono.Size = new System.Drawing.Size(55, 15);
            this.lbl_telefono.Text = "Teléfono";
            //
            // txt_telefono
            //
            this.txt_telefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_telefono.Location = new System.Drawing.Point(16, 60);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(212, 23);
            this.txt_telefono.TabIndex = 0;
            //
            // lbl_email
            //
            this.lbl_email.AutoSize = true;
            this.lbl_email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_email.Location = new System.Drawing.Point(244, 42);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(40, 15);
            this.lbl_email.Text = "Email";
            //
            // txt_email
            //
            this.txt_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_email.Location = new System.Drawing.Point(244, 60);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(212, 23);
            this.txt_email.TabIndex = 1;
            //
            // lbl_provincia
            //
            this.lbl_provincia.AutoSize = true;
            this.lbl_provincia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_provincia.Location = new System.Drawing.Point(16, 94);
            this.lbl_provincia.Name = "lbl_provincia";
            this.lbl_provincia.Size = new System.Drawing.Size(55, 15);
            this.lbl_provincia.Text = "Provincia";
            //
            // cb_provincia
            //
            this.cb_provincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_provincia.Location = new System.Drawing.Point(16, 112);
            this.cb_provincia.Name = "cb_provincia";
            this.cb_provincia.Size = new System.Drawing.Size(212, 23);
            this.cb_provincia.TabIndex = 2;
            //
            // lbl_ciudad
            //
            this.lbl_ciudad.AutoSize = true;
            this.lbl_ciudad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_ciudad.Location = new System.Drawing.Point(244, 94);
            this.lbl_ciudad.Name = "lbl_ciudad";
            this.lbl_ciudad.Size = new System.Drawing.Size(45, 15);
            this.lbl_ciudad.Text = "Ciudad";
            //
            // txt_ciudad
            //
            this.txt_ciudad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ciudad.Location = new System.Drawing.Point(244, 112);
            this.txt_ciudad.Name = "txt_ciudad";
            this.txt_ciudad.Size = new System.Drawing.Size(212, 23);
            this.txt_ciudad.TabIndex = 3;
            //
            // lbl_direccion
            //
            this.lbl_direccion.AutoSize = true;
            this.lbl_direccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_direccion.Location = new System.Drawing.Point(16, 146);
            this.lbl_direccion.Name = "lbl_direccion";
            this.lbl_direccion.Size = new System.Drawing.Size(60, 15);
            this.lbl_direccion.Text = "Dirección";
            //
            // txt_direccion
            //
            this.txt_direccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_direccion.Location = new System.Drawing.Point(16, 164);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(440, 23);
            this.txt_direccion.TabIndex = 4;
            //
            // btn_guardar
            //
            this.btn_guardar.Location = new System.Drawing.Point(296, 212);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(160, 34);
            this.btn_guardar.TabIndex = 5;
            this.btn_guardar.Text = "Guardar datos";
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            //
            // btn_cerrar
            //
            this.btn_cerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cerrar.Location = new System.Drawing.Point(388, 558);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(108, 34);
            this.btn_cerrar.TabIndex = 2;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = false;
            //
            // MiCuenta
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.CancelButton = this.btn_cerrar;
            this.ClientSize = new System.Drawing.Size(520, 606);
            this.ControlBox = false;
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.pnl_datos);
            this.Controls.Add(this.pnl_contrasena);
            this.Controls.Add(this.lbl_titulo);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(56)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = global::FixedSegurosApp.Properties.Resources.icono_FS;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MiCuenta";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Fixed Seguros: Mi cuenta";
            this.Load += new System.EventHandler(this.MiCuenta_Load);
            this.pnl_contrasena.ResumeLayout(false);
            this.pnl_contrasena.PerformLayout();
            this.pnl_datos.ResumeLayout(false);
            this.pnl_datos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Panel pnl_contrasena;
        private System.Windows.Forms.Label lbl_contrasena_titulo;
        private System.Windows.Forms.Label lbl_actual;
        private System.Windows.Forms.TextBox txt_actual;
        private System.Windows.Forms.Label lbl_nueva;
        private System.Windows.Forms.TextBox txt_nueva;
        private System.Windows.Forms.Label lbl_repetir;
        private System.Windows.Forms.TextBox txt_repetir;
        private System.Windows.Forms.Button btn_cambiar;
        private System.Windows.Forms.Panel pnl_datos;
        private System.Windows.Forms.Label lbl_datos_titulo;
        private System.Windows.Forms.Label lbl_telefono;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label lbl_provincia;
        private System.Windows.Forms.ComboBox cb_provincia;
        private System.Windows.Forms.Label lbl_ciudad;
        private System.Windows.Forms.TextBox txt_ciudad;
        private System.Windows.Forms.Label lbl_direccion;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_cerrar;
    }
}
