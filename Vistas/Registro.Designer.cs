namespace FixedSegurosApp.Vistas
{
    partial class Registro
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
            this.pnl_pie = new System.Windows.Forms.Panel();
            this.pnl_linea = new System.Windows.Forms.Panel();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_registrarme = new System.Windows.Forms.Button();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.lbl_dni = new System.Windows.Forms.Label();
            this.txt_dni = new System.Windows.Forms.TextBox();
            this.lbl_fecha_nacimiento = new System.Windows.Forms.Label();
            this.dtp_fecha_nacimiento = new System.Windows.Forms.DateTimePicker();
            this.lbl_provincia = new System.Windows.Forms.Label();
            this.cb_provincia = new System.Windows.Forms.ComboBox();
            this.lbl_ciudad = new System.Windows.Forms.Label();
            this.txt_ciudad = new System.Windows.Forms.TextBox();
            this.lbl_direccion = new System.Windows.Forms.Label();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.lbl_telefono = new System.Windows.Forms.Label();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lbl_contrasena = new System.Windows.Forms.Label();
            this.txt_contrasena = new System.Windows.Forms.TextBox();
            this.lbl_repetir = new System.Windows.Forms.Label();
            this.txt_repetir = new System.Windows.Forms.TextBox();
            this.pnl_cabecera.SuspendLayout();
            this.pnl_pie.SuspendLayout();
            this.SuspendLayout();
            //
            // pnl_cabecera
            //
            this.pnl_cabecera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(58)))), ((int)(((byte)(92)))));
            this.pnl_cabecera.Controls.Add(this.lbl_subtitulo);
            this.pnl_cabecera.Controls.Add(this.lbl_titulo);
            this.pnl_cabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_cabecera.Location = new System.Drawing.Point(0, 0);
            this.pnl_cabecera.Name = "pnl_cabecera";
            this.pnl_cabecera.Size = new System.Drawing.Size(560, 92);
            this.pnl_cabecera.TabIndex = 0;
            //
            // lbl_titulo
            //
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Segoe UI Semibold", 16F);
            this.lbl_titulo.ForeColor = System.Drawing.Color.White;
            this.lbl_titulo.Location = new System.Drawing.Point(28, 16);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(134, 30);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Crear cuenta";
            //
            // lbl_subtitulo
            //
            this.lbl_subtitulo.AutoSize = true;
            this.lbl_subtitulo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbl_subtitulo.ForeColor = System.Drawing.Color.White;
            this.lbl_subtitulo.Location = new System.Drawing.Point(30, 52);
            this.lbl_subtitulo.Name = "lbl_subtitulo";
            this.lbl_subtitulo.Size = new System.Drawing.Size(392, 19);
            this.lbl_subtitulo.TabIndex = 1;
            this.lbl_subtitulo.Text = "Con su registro podrá cargar sus vehículos y ver sus pólizas.";
            //
            // pnl_pie
            //
            this.pnl_pie.BackColor = System.Drawing.Color.White;
            this.pnl_pie.Controls.Add(this.pnl_linea);
            this.pnl_pie.Controls.Add(this.btn_cancelar);
            this.pnl_pie.Controls.Add(this.btn_registrarme);
            this.pnl_pie.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_pie.Location = new System.Drawing.Point(0, 516);
            this.pnl_pie.Name = "pnl_pie";
            this.pnl_pie.Size = new System.Drawing.Size(560, 64);
            this.pnl_pie.TabIndex = 20;
            //
            // pnl_linea
            //
            this.pnl_linea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(221)))), ((int)(((byte)(232)))));
            this.pnl_linea.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_linea.Location = new System.Drawing.Point(0, 0);
            this.pnl_linea.Name = "pnl_linea";
            this.pnl_linea.Size = new System.Drawing.Size(560, 1);
            this.pnl_linea.TabIndex = 2;
            //
            // btn_cancelar
            //
            this.btn_cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancelar.Location = new System.Drawing.Point(276, 14);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(120, 36);
            this.btn_cancelar.TabIndex = 13;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            //
            // btn_registrarme
            //
            this.btn_registrarme.Location = new System.Drawing.Point(408, 14);
            this.btn_registrarme.Name = "btn_registrarme";
            this.btn_registrarme.Size = new System.Drawing.Size(120, 36);
            this.btn_registrarme.TabIndex = 12;
            this.btn_registrarme.Text = "Registrarme";
            this.btn_registrarme.UseVisualStyleBackColor = false;
            this.btn_registrarme.Click += new System.EventHandler(this.btn_registrarme_Click);
            //
            // lbl_nombre
            //
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_nombre.Location = new System.Drawing.Point(32, 112);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(57, 15);
            this.lbl_nombre.Text = "Nombres";
            //
            // txt_nombre
            //
            this.txt_nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_nombre.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_nombre.Location = new System.Drawing.Point(32, 134);
            this.txt_nombre.MaxLength = 50;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(240, 25);
            this.txt_nombre.TabIndex = 0;
            //
            // lbl_apellido
            //
            this.lbl_apellido.AutoSize = true;
            this.lbl_apellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_apellido.Location = new System.Drawing.Point(288, 112);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(57, 15);
            this.lbl_apellido.Text = "Apellidos";
            //
            // txt_apellido
            //
            this.txt_apellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_apellido.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_apellido.Location = new System.Drawing.Point(288, 134);
            this.txt_apellido.MaxLength = 50;
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(240, 25);
            this.txt_apellido.TabIndex = 1;
            //
            // lbl_dni
            //
            this.lbl_dni.AutoSize = true;
            this.lbl_dni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_dni.Location = new System.Drawing.Point(32, 174);
            this.lbl_dni.Name = "lbl_dni";
            this.lbl_dni.Size = new System.Drawing.Size(27, 15);
            this.lbl_dni.Text = "DNI";
            //
            // txt_dni
            //
            this.txt_dni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_dni.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_dni.Location = new System.Drawing.Point(32, 196);
            this.txt_dni.MaxLength = 8;
            this.txt_dni.Name = "txt_dni";
            this.txt_dni.Size = new System.Drawing.Size(240, 25);
            this.txt_dni.TabIndex = 2;
            //
            // lbl_fecha_nacimiento
            //
            this.lbl_fecha_nacimiento.AutoSize = true;
            this.lbl_fecha_nacimiento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_fecha_nacimiento.Location = new System.Drawing.Point(288, 174);
            this.lbl_fecha_nacimiento.Name = "lbl_fecha_nacimiento";
            this.lbl_fecha_nacimiento.Size = new System.Drawing.Size(117, 15);
            this.lbl_fecha_nacimiento.Text = "Fecha de nacimiento";
            //
            // dtp_fecha_nacimiento
            //
            this.dtp_fecha_nacimiento.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtp_fecha_nacimiento.CustomFormat = "dd/MM/yyyy";
            this.dtp_fecha_nacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_fecha_nacimiento.Location = new System.Drawing.Point(288, 196);
            this.dtp_fecha_nacimiento.Name = "dtp_fecha_nacimiento";
            this.dtp_fecha_nacimiento.Size = new System.Drawing.Size(240, 25);
            this.dtp_fecha_nacimiento.TabIndex = 3;
            //
            // lbl_provincia
            //
            this.lbl_provincia.AutoSize = true;
            this.lbl_provincia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_provincia.Location = new System.Drawing.Point(32, 236);
            this.lbl_provincia.Name = "lbl_provincia";
            this.lbl_provincia.Size = new System.Drawing.Size(56, 15);
            this.lbl_provincia.Text = "Provincia";
            //
            // cb_provincia
            //
            this.cb_provincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_provincia.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb_provincia.Location = new System.Drawing.Point(32, 258);
            this.cb_provincia.Name = "cb_provincia";
            this.cb_provincia.Size = new System.Drawing.Size(240, 25);
            this.cb_provincia.TabIndex = 4;
            //
            // lbl_ciudad
            //
            this.lbl_ciudad.AutoSize = true;
            this.lbl_ciudad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_ciudad.Location = new System.Drawing.Point(288, 236);
            this.lbl_ciudad.Name = "lbl_ciudad";
            this.lbl_ciudad.Size = new System.Drawing.Size(45, 15);
            this.lbl_ciudad.Text = "Ciudad";
            //
            // txt_ciudad
            //
            this.txt_ciudad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ciudad.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_ciudad.Location = new System.Drawing.Point(288, 258);
            this.txt_ciudad.MaxLength = 60;
            this.txt_ciudad.Name = "txt_ciudad";
            this.txt_ciudad.Size = new System.Drawing.Size(240, 25);
            this.txt_ciudad.TabIndex = 5;
            //
            // lbl_direccion
            //
            this.lbl_direccion.AutoSize = true;
            this.lbl_direccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_direccion.Location = new System.Drawing.Point(32, 298);
            this.lbl_direccion.Name = "lbl_direccion";
            this.lbl_direccion.Size = new System.Drawing.Size(57, 15);
            this.lbl_direccion.Text = "Dirección";
            //
            // txt_direccion
            //
            this.txt_direccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_direccion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_direccion.Location = new System.Drawing.Point(32, 320);
            this.txt_direccion.MaxLength = 50;
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(496, 25);
            this.txt_direccion.TabIndex = 6;
            //
            // lbl_telefono
            //
            this.lbl_telefono.AutoSize = true;
            this.lbl_telefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_telefono.Location = new System.Drawing.Point(32, 360);
            this.lbl_telefono.Name = "lbl_telefono";
            this.lbl_telefono.Size = new System.Drawing.Size(53, 15);
            this.lbl_telefono.Text = "Teléfono";
            //
            // txt_telefono
            //
            this.txt_telefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_telefono.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_telefono.Location = new System.Drawing.Point(32, 382);
            this.txt_telefono.MaxLength = 12;
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(240, 25);
            this.txt_telefono.TabIndex = 7;
            //
            // lbl_email
            //
            this.lbl_email.AutoSize = true;
            this.lbl_email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_email.Location = new System.Drawing.Point(288, 360);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(36, 15);
            this.lbl_email.Text = "Email";
            //
            // txt_email
            //
            this.txt_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_email.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_email.Location = new System.Drawing.Point(288, 382);
            this.txt_email.MaxLength = 40;
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(240, 25);
            this.txt_email.TabIndex = 8;
            //
            // lbl_contrasena
            //
            this.lbl_contrasena.AutoSize = true;
            this.lbl_contrasena.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_contrasena.Location = new System.Drawing.Point(32, 422);
            this.lbl_contrasena.Name = "lbl_contrasena";
            this.lbl_contrasena.Size = new System.Drawing.Size(67, 15);
            this.lbl_contrasena.Text = "Contraseña";
            //
            // txt_contrasena
            //
            this.txt_contrasena.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_contrasena.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_contrasena.Location = new System.Drawing.Point(32, 444);
            this.txt_contrasena.Name = "txt_contrasena";
            this.txt_contrasena.Size = new System.Drawing.Size(240, 25);
            this.txt_contrasena.TabIndex = 9;
            this.txt_contrasena.UseSystemPasswordChar = true;
            //
            // lbl_repetir
            //
            this.lbl_repetir.AutoSize = true;
            this.lbl_repetir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_repetir.Location = new System.Drawing.Point(288, 422);
            this.lbl_repetir.Name = "lbl_repetir";
            this.lbl_repetir.Size = new System.Drawing.Size(110, 15);
            this.lbl_repetir.Text = "Repetir contraseña";
            //
            // txt_repetir
            //
            this.txt_repetir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_repetir.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_repetir.Location = new System.Drawing.Point(288, 444);
            this.txt_repetir.Name = "txt_repetir";
            this.txt_repetir.Size = new System.Drawing.Size(240, 25);
            this.txt_repetir.TabIndex = 10;
            this.txt_repetir.UseSystemPasswordChar = true;
            //
            // Registro
            //
            this.AcceptButton = this.btn_registrarme;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.CancelButton = this.btn_cancelar;
            this.ClientSize = new System.Drawing.Size(560, 580);
            this.Controls.Add(this.txt_repetir);
            this.Controls.Add(this.lbl_repetir);
            this.Controls.Add(this.txt_contrasena);
            this.Controls.Add(this.lbl_contrasena);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.txt_telefono);
            this.Controls.Add(this.lbl_telefono);
            this.Controls.Add(this.txt_direccion);
            this.Controls.Add(this.lbl_direccion);
            this.Controls.Add(this.txt_ciudad);
            this.Controls.Add(this.lbl_ciudad);
            this.Controls.Add(this.cb_provincia);
            this.Controls.Add(this.lbl_provincia);
            this.Controls.Add(this.dtp_fecha_nacimiento);
            this.Controls.Add(this.lbl_fecha_nacimiento);
            this.Controls.Add(this.txt_dni);
            this.Controls.Add(this.lbl_dni);
            this.Controls.Add(this.txt_apellido);
            this.Controls.Add(this.lbl_apellido);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.pnl_pie);
            this.Controls.Add(this.pnl_cabecera);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(56)))));
            this.ControlBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = global::FixedSegurosApp.Properties.Resources.icono_FS;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Registro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Fixed Seguros: Registro de cliente";
            this.Load += new System.EventHandler(this.Registro_Load);
            this.pnl_cabecera.ResumeLayout(false);
            this.pnl_cabecera.PerformLayout();
            this.pnl_pie.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_cabecera;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_subtitulo;
        private System.Windows.Forms.Panel pnl_pie;
        private System.Windows.Forms.Panel pnl_linea;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_registrarme;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label lbl_apellido;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.Label lbl_dni;
        private System.Windows.Forms.TextBox txt_dni;
        private System.Windows.Forms.Label lbl_fecha_nacimiento;
        private System.Windows.Forms.DateTimePicker dtp_fecha_nacimiento;
        private System.Windows.Forms.Label lbl_provincia;
        private System.Windows.Forms.ComboBox cb_provincia;
        private System.Windows.Forms.Label lbl_ciudad;
        private System.Windows.Forms.TextBox txt_ciudad;
        private System.Windows.Forms.Label lbl_direccion;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.Label lbl_telefono;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label lbl_contrasena;
        private System.Windows.Forms.TextBox txt_contrasena;
        private System.Windows.Forms.Label lbl_repetir;
        private System.Windows.Forms.TextBox txt_repetir;
    }
}
