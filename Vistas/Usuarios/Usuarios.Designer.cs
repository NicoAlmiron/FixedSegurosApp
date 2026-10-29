namespace FixedSegurosApp.Vistas
{
    partial class Usuarios
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
            System.Windows.Forms.DataGridViewCellStyle estiloLegajo = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.btn_historial = new System.Windows.Forms.Button();
            this.pnl_lista = new System.Windows.Forms.Panel();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.btn_suspender = new System.Windows.Forms.Button();
            this.btn_baja = new System.Windows.Forms.Button();
            this.dgv_usuarios = new System.Windows.Forms.DataGridView();
            this.col_legajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_apellido_nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_perfil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_cantidad = new System.Windows.Forms.Label();
            this.pnl_detalle = new System.Windows.Forms.Panel();
            this.lbl_detalle_titulo = new System.Windows.Forms.Label();
            this.btn_restablecer = new System.Windows.Forms.Button();
            this.pnl_linea_detalle = new System.Windows.Forms.Panel();
            this.lbl_legajo = new System.Windows.Forms.Label();
            this.txt_legajo = new System.Windows.Forms.TextBox();
            this.lbl_perfil = new System.Windows.Forms.Label();
            this.cb_perfil = new System.Windows.Forms.ComboBox();
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
            this.lbl_fecha_alta = new System.Windows.Forms.Label();
            this.txt_fecha_alta = new System.Windows.Forms.TextBox();
            this.lbl_fecha_baja = new System.Windows.Forms.Label();
            this.txt_fecha_baja = new System.Windows.Forms.TextBox();
            this.lbl_motivo_baja = new System.Windows.Forms.Label();
            this.txt_motivo_baja = new System.Windows.Forms.TextBox();
            this.pnl_linea_pie = new System.Windows.Forms.Panel();
            this.btn_descartar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.pnl_lista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuarios)).BeginInit();
            this.pnl_detalle.SuspendLayout();
            this.SuspendLayout();
            //
            // lbl_titulo
            //
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Segoe UI Semibold", 16F);
            this.lbl_titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(58)))), ((int)(((byte)(92)))));
            this.lbl_titulo.Location = new System.Drawing.Point(20, 20);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(97, 30);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Usuarios";
            //
            // btn_historial
            //
            this.btn_historial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_historial.Location = new System.Drawing.Point(836, 20);
            this.btn_historial.Name = "btn_historial";
            this.btn_historial.Size = new System.Drawing.Size(160, 32);
            this.btn_historial.TabIndex = 1;
            this.btn_historial.Text = "Historial de acciones";
            this.btn_historial.UseVisualStyleBackColor = false;
            this.btn_historial.Click += new System.EventHandler(this.btn_historial_Click);
            //
            // pnl_lista
            //
            this.pnl_lista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_lista.Controls.Add(this.txt_buscar);
            this.pnl_lista.Controls.Add(this.btn_nuevo);
            this.pnl_lista.Controls.Add(this.btn_suspender);
            this.pnl_lista.Controls.Add(this.btn_baja);
            this.pnl_lista.Controls.Add(this.dgv_usuarios);
            this.pnl_lista.Controls.Add(this.lbl_cantidad);
            this.pnl_lista.Location = new System.Drawing.Point(24, 70);
            this.pnl_lista.Name = "pnl_lista";
            this.pnl_lista.Size = new System.Drawing.Size(584, 636);
            this.pnl_lista.TabIndex = 2;
            //
            // txt_buscar
            //
            this.txt_buscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_buscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_buscar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_buscar.Location = new System.Drawing.Point(16, 16);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(246, 25);
            this.txt_buscar.TabIndex = 0;
            this.txt_buscar.TextChanged += new System.EventHandler(this.txt_buscar_TextChanged);
            //
            // btn_nuevo
            //
            this.btn_nuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_nuevo.Location = new System.Drawing.Point(270, 14);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(116, 30);
            this.btn_nuevo.TabIndex = 1;
            this.btn_nuevo.Text = "Nuevo usuario";
            this.btn_nuevo.UseVisualStyleBackColor = false;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            //
            // btn_suspender
            //
            this.btn_suspender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_suspender.Location = new System.Drawing.Point(392, 14);
            this.btn_suspender.Name = "btn_suspender";
            this.btn_suspender.Size = new System.Drawing.Size(84, 30);
            this.btn_suspender.TabIndex = 2;
            this.btn_suspender.Text = "Suspender";
            this.btn_suspender.UseVisualStyleBackColor = false;
            this.btn_suspender.Click += new System.EventHandler(this.btn_suspender_Click);
            //
            // btn_baja
            //
            this.btn_baja.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_baja.Location = new System.Drawing.Point(482, 14);
            this.btn_baja.Name = "btn_baja";
            this.btn_baja.Size = new System.Drawing.Size(86, 30);
            this.btn_baja.TabIndex = 3;
            this.btn_baja.Text = "Dar de baja";
            this.btn_baja.UseVisualStyleBackColor = false;
            this.btn_baja.Click += new System.EventHandler(this.btn_baja_Click);
            //
            // dgv_usuarios
            //
            this.dgv_usuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_usuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_legajo,
            this.col_apellido_nombre,
            this.col_dni,
            this.col_perfil,
            this.col_estado});
            this.dgv_usuarios.Location = new System.Drawing.Point(1, 58);
            this.dgv_usuarios.Name = "dgv_usuarios";
            this.dgv_usuarios.Size = new System.Drawing.Size(582, 536);
            this.dgv_usuarios.TabIndex = 4;
            this.dgv_usuarios.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_usuarios_CellFormatting);
            this.dgv_usuarios.SelectionChanged += new System.EventHandler(this.dgv_usuarios_SelectionChanged);
            //
            // col_legajo
            //
            this.col_legajo.DataPropertyName = "Legajo";
            estiloLegajo.Format = "0000";
            this.col_legajo.DefaultCellStyle = estiloLegajo;
            this.col_legajo.FillWeight = 55F;
            this.col_legajo.HeaderText = "Legajo";
            this.col_legajo.Name = "col_legajo";
            //
            // col_apellido_nombre
            //
            this.col_apellido_nombre.DataPropertyName = "ApellidoYNombre";
            this.col_apellido_nombre.FillWeight = 150F;
            this.col_apellido_nombre.HeaderText = "Apellido y nombre";
            this.col_apellido_nombre.Name = "col_apellido_nombre";
            //
            // col_dni
            //
            this.col_dni.DataPropertyName = "Dni";
            this.col_dni.FillWeight = 80F;
            this.col_dni.HeaderText = "DNI";
            this.col_dni.Name = "col_dni";
            //
            // col_perfil
            //
            this.col_perfil.DataPropertyName = "Perfil";
            this.col_perfil.FillWeight = 95F;
            this.col_perfil.HeaderText = "Perfil";
            this.col_perfil.Name = "col_perfil";
            //
            // col_estado
            //
            this.col_estado.DataPropertyName = "Estado";
            this.col_estado.FillWeight = 90F;
            this.col_estado.HeaderText = "Estado";
            this.col_estado.Name = "col_estado";
            //
            // lbl_cantidad
            //
            this.lbl_cantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_cantidad.AutoSize = true;
            this.lbl_cantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_cantidad.Location = new System.Drawing.Point(16, 606);
            this.lbl_cantidad.Name = "lbl_cantidad";
            this.lbl_cantidad.Size = new System.Drawing.Size(116, 15);
            this.lbl_cantidad.TabIndex = 5;
            this.lbl_cantidad.Text = "Mostrando 0 usuarios";
            //
            // pnl_detalle
            //
            this.pnl_detalle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_detalle.Controls.Add(this.lbl_detalle_titulo);
            this.pnl_detalle.Controls.Add(this.btn_restablecer);
            this.pnl_detalle.Controls.Add(this.pnl_linea_detalle);
            this.pnl_detalle.Controls.Add(this.lbl_legajo);
            this.pnl_detalle.Controls.Add(this.txt_legajo);
            this.pnl_detalle.Controls.Add(this.lbl_perfil);
            this.pnl_detalle.Controls.Add(this.cb_perfil);
            this.pnl_detalle.Controls.Add(this.lbl_nombre);
            this.pnl_detalle.Controls.Add(this.txt_nombre);
            this.pnl_detalle.Controls.Add(this.lbl_apellido);
            this.pnl_detalle.Controls.Add(this.txt_apellido);
            this.pnl_detalle.Controls.Add(this.lbl_dni);
            this.pnl_detalle.Controls.Add(this.txt_dni);
            this.pnl_detalle.Controls.Add(this.lbl_fecha_nacimiento);
            this.pnl_detalle.Controls.Add(this.dtp_fecha_nacimiento);
            this.pnl_detalle.Controls.Add(this.lbl_provincia);
            this.pnl_detalle.Controls.Add(this.cb_provincia);
            this.pnl_detalle.Controls.Add(this.lbl_ciudad);
            this.pnl_detalle.Controls.Add(this.txt_ciudad);
            this.pnl_detalle.Controls.Add(this.lbl_direccion);
            this.pnl_detalle.Controls.Add(this.txt_direccion);
            this.pnl_detalle.Controls.Add(this.lbl_telefono);
            this.pnl_detalle.Controls.Add(this.txt_telefono);
            this.pnl_detalle.Controls.Add(this.lbl_email);
            this.pnl_detalle.Controls.Add(this.txt_email);
            this.pnl_detalle.Controls.Add(this.lbl_fecha_alta);
            this.pnl_detalle.Controls.Add(this.txt_fecha_alta);
            this.pnl_detalle.Controls.Add(this.lbl_fecha_baja);
            this.pnl_detalle.Controls.Add(this.txt_fecha_baja);
            this.pnl_detalle.Controls.Add(this.lbl_motivo_baja);
            this.pnl_detalle.Controls.Add(this.txt_motivo_baja);
            this.pnl_detalle.Controls.Add(this.pnl_linea_pie);
            this.pnl_detalle.Controls.Add(this.btn_descartar);
            this.pnl_detalle.Controls.Add(this.btn_guardar);
            this.pnl_detalle.Location = new System.Drawing.Point(620, 70);
            this.pnl_detalle.Name = "pnl_detalle";
            this.pnl_detalle.Size = new System.Drawing.Size(376, 636);
            this.pnl_detalle.TabIndex = 3;
            //
            // lbl_detalle_titulo
            //
            this.lbl_detalle_titulo.AutoSize = true;
            this.lbl_detalle_titulo.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.lbl_detalle_titulo.Location = new System.Drawing.Point(14, 18);
            this.lbl_detalle_titulo.Name = "lbl_detalle_titulo";
            this.lbl_detalle_titulo.Size = new System.Drawing.Size(126, 20);
            this.lbl_detalle_titulo.TabIndex = 0;
            this.lbl_detalle_titulo.Text = "Datos del usuario";
            //
            // btn_restablecer
            //
            this.btn_restablecer.Location = new System.Drawing.Point(200, 12);
            this.btn_restablecer.Name = "btn_restablecer";
            this.btn_restablecer.Size = new System.Drawing.Size(160, 30);
            this.btn_restablecer.TabIndex = 20;
            this.btn_restablecer.Text = "Restablecer contraseña";
            this.btn_restablecer.UseVisualStyleBackColor = false;
            this.btn_restablecer.Click += new System.EventHandler(this.btn_restablecer_Click);
            //
            // pnl_linea_detalle
            //
            this.pnl_linea_detalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(221)))), ((int)(((byte)(232)))));
            this.pnl_linea_detalle.Location = new System.Drawing.Point(1, 54);
            this.pnl_linea_detalle.Name = "pnl_linea_detalle";
            this.pnl_linea_detalle.Size = new System.Drawing.Size(374, 1);
            this.pnl_linea_detalle.TabIndex = 21;
            //
            // lbl_legajo
            //
            this.lbl_legajo.AutoSize = true;
            this.lbl_legajo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_legajo.Location = new System.Drawing.Point(16, 66);
            this.lbl_legajo.Name = "lbl_legajo";
            this.lbl_legajo.Size = new System.Drawing.Size(42, 15);
            this.lbl_legajo.Text = "Legajo";
            //
            // txt_legajo
            //
            this.txt_legajo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.txt_legajo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_legajo.Location = new System.Drawing.Point(16, 86);
            this.txt_legajo.Name = "txt_legajo";
            this.txt_legajo.ReadOnly = true;
            this.txt_legajo.Size = new System.Drawing.Size(164, 23);
            this.txt_legajo.TabStop = false;
            //
            // lbl_perfil
            //
            this.lbl_perfil.AutoSize = true;
            this.lbl_perfil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_perfil.Location = new System.Drawing.Point(196, 66);
            this.lbl_perfil.Name = "lbl_perfil";
            this.lbl_perfil.Size = new System.Drawing.Size(34, 15);
            this.lbl_perfil.Text = "Perfil";
            //
            // cb_perfil
            //
            this.cb_perfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_perfil.Location = new System.Drawing.Point(196, 86);
            this.cb_perfil.Name = "cb_perfil";
            this.cb_perfil.Size = new System.Drawing.Size(164, 23);
            this.cb_perfil.TabIndex = 1;
            //
            // lbl_nombre
            //
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_nombre.Location = new System.Drawing.Point(16, 120);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(57, 15);
            this.lbl_nombre.Text = "Nombres";
            //
            // txt_nombre
            //
            this.txt_nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_nombre.Location = new System.Drawing.Point(16, 140);
            this.txt_nombre.MaxLength = 50;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(164, 23);
            this.txt_nombre.TabIndex = 2;
            //
            // lbl_apellido
            //
            this.lbl_apellido.AutoSize = true;
            this.lbl_apellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_apellido.Location = new System.Drawing.Point(196, 120);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(57, 15);
            this.lbl_apellido.Text = "Apellidos";
            //
            // txt_apellido
            //
            this.txt_apellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_apellido.Location = new System.Drawing.Point(196, 140);
            this.txt_apellido.MaxLength = 50;
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(164, 23);
            this.txt_apellido.TabIndex = 3;
            //
            // lbl_dni
            //
            this.lbl_dni.AutoSize = true;
            this.lbl_dni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_dni.Location = new System.Drawing.Point(16, 174);
            this.lbl_dni.Name = "lbl_dni";
            this.lbl_dni.Size = new System.Drawing.Size(27, 15);
            this.lbl_dni.Text = "DNI";
            //
            // txt_dni
            //
            this.txt_dni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_dni.Location = new System.Drawing.Point(16, 194);
            this.txt_dni.MaxLength = 8;
            this.txt_dni.Name = "txt_dni";
            this.txt_dni.Size = new System.Drawing.Size(164, 23);
            this.txt_dni.TabIndex = 4;
            //
            // lbl_fecha_nacimiento
            //
            this.lbl_fecha_nacimiento.AutoSize = true;
            this.lbl_fecha_nacimiento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_fecha_nacimiento.Location = new System.Drawing.Point(196, 174);
            this.lbl_fecha_nacimiento.Name = "lbl_fecha_nacimiento";
            this.lbl_fecha_nacimiento.Size = new System.Drawing.Size(117, 15);
            this.lbl_fecha_nacimiento.Text = "Fecha de nacimiento";
            //
            // dtp_fecha_nacimiento
            //
            this.dtp_fecha_nacimiento.CustomFormat = "dd/MM/yyyy";
            this.dtp_fecha_nacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_fecha_nacimiento.Location = new System.Drawing.Point(196, 194);
            this.dtp_fecha_nacimiento.Name = "dtp_fecha_nacimiento";
            this.dtp_fecha_nacimiento.Size = new System.Drawing.Size(164, 23);
            this.dtp_fecha_nacimiento.TabIndex = 5;
            //
            // lbl_provincia
            //
            this.lbl_provincia.AutoSize = true;
            this.lbl_provincia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_provincia.Location = new System.Drawing.Point(16, 228);
            this.lbl_provincia.Name = "lbl_provincia";
            this.lbl_provincia.Size = new System.Drawing.Size(56, 15);
            this.lbl_provincia.Text = "Provincia";
            //
            // cb_provincia
            //
            this.cb_provincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_provincia.Location = new System.Drawing.Point(16, 248);
            this.cb_provincia.Name = "cb_provincia";
            this.cb_provincia.Size = new System.Drawing.Size(164, 23);
            this.cb_provincia.TabIndex = 6;
            //
            // lbl_ciudad
            //
            this.lbl_ciudad.AutoSize = true;
            this.lbl_ciudad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_ciudad.Location = new System.Drawing.Point(196, 228);
            this.lbl_ciudad.Name = "lbl_ciudad";
            this.lbl_ciudad.Size = new System.Drawing.Size(45, 15);
            this.lbl_ciudad.Text = "Ciudad";
            //
            // txt_ciudad
            //
            this.txt_ciudad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ciudad.Location = new System.Drawing.Point(196, 248);
            this.txt_ciudad.MaxLength = 60;
            this.txt_ciudad.Name = "txt_ciudad";
            this.txt_ciudad.Size = new System.Drawing.Size(164, 23);
            this.txt_ciudad.TabIndex = 7;
            //
            // lbl_direccion
            //
            this.lbl_direccion.AutoSize = true;
            this.lbl_direccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_direccion.Location = new System.Drawing.Point(16, 282);
            this.lbl_direccion.Name = "lbl_direccion";
            this.lbl_direccion.Size = new System.Drawing.Size(57, 15);
            this.lbl_direccion.Text = "Dirección";
            //
            // txt_direccion
            //
            this.txt_direccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_direccion.Location = new System.Drawing.Point(16, 302);
            this.txt_direccion.MaxLength = 50;
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(344, 23);
            this.txt_direccion.TabIndex = 8;
            //
            // lbl_telefono
            //
            this.lbl_telefono.AutoSize = true;
            this.lbl_telefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_telefono.Location = new System.Drawing.Point(16, 336);
            this.lbl_telefono.Name = "lbl_telefono";
            this.lbl_telefono.Size = new System.Drawing.Size(53, 15);
            this.lbl_telefono.Text = "Teléfono";
            //
            // txt_telefono
            //
            this.txt_telefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_telefono.Location = new System.Drawing.Point(16, 356);
            this.txt_telefono.MaxLength = 12;
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(164, 23);
            this.txt_telefono.TabIndex = 9;
            //
            // lbl_email
            //
            this.lbl_email.AutoSize = true;
            this.lbl_email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_email.Location = new System.Drawing.Point(196, 336);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(36, 15);
            this.lbl_email.Text = "Email";
            //
            // txt_email
            //
            this.txt_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_email.Location = new System.Drawing.Point(196, 356);
            this.txt_email.MaxLength = 40;
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(164, 23);
            this.txt_email.TabIndex = 10;
            //
            // lbl_fecha_alta
            //
            this.lbl_fecha_alta.AutoSize = true;
            this.lbl_fecha_alta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_fecha_alta.Location = new System.Drawing.Point(16, 390);
            this.lbl_fecha_alta.Name = "lbl_fecha_alta";
            this.lbl_fecha_alta.Size = new System.Drawing.Size(76, 15);
            this.lbl_fecha_alta.Text = "Fecha de alta";
            //
            // txt_fecha_alta
            //
            this.txt_fecha_alta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.txt_fecha_alta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_fecha_alta.Location = new System.Drawing.Point(16, 410);
            this.txt_fecha_alta.Name = "txt_fecha_alta";
            this.txt_fecha_alta.ReadOnly = true;
            this.txt_fecha_alta.Size = new System.Drawing.Size(164, 23);
            this.txt_fecha_alta.TabStop = false;
            //
            // lbl_fecha_baja
            //
            this.lbl_fecha_baja.AutoSize = true;
            this.lbl_fecha_baja.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_fecha_baja.Location = new System.Drawing.Point(196, 390);
            this.lbl_fecha_baja.Name = "lbl_fecha_baja";
            this.lbl_fecha_baja.Size = new System.Drawing.Size(80, 15);
            this.lbl_fecha_baja.Text = "Fecha de baja";
            //
            // txt_fecha_baja
            //
            this.txt_fecha_baja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.txt_fecha_baja.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_fecha_baja.Location = new System.Drawing.Point(196, 410);
            this.txt_fecha_baja.Name = "txt_fecha_baja";
            this.txt_fecha_baja.ReadOnly = true;
            this.txt_fecha_baja.Size = new System.Drawing.Size(164, 23);
            this.txt_fecha_baja.TabStop = false;
            //
            // lbl_motivo_baja
            //
            this.lbl_motivo_baja.AutoSize = true;
            this.lbl_motivo_baja.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_motivo_baja.Location = new System.Drawing.Point(16, 444);
            this.lbl_motivo_baja.Name = "lbl_motivo_baja";
            this.lbl_motivo_baja.Size = new System.Drawing.Size(103, 15);
            this.lbl_motivo_baja.Text = "Motivo de la baja";
            //
            // txt_motivo_baja
            //
            this.txt_motivo_baja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.txt_motivo_baja.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_motivo_baja.Location = new System.Drawing.Point(16, 464);
            this.txt_motivo_baja.Multiline = true;
            this.txt_motivo_baja.Name = "txt_motivo_baja";
            this.txt_motivo_baja.ReadOnly = true;
            this.txt_motivo_baja.Size = new System.Drawing.Size(344, 60);
            this.txt_motivo_baja.TabStop = false;
            //
            // pnl_linea_pie
            //
            this.pnl_linea_pie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnl_linea_pie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(221)))), ((int)(((byte)(232)))));
            this.pnl_linea_pie.Location = new System.Drawing.Point(1, 572);
            this.pnl_linea_pie.Name = "pnl_linea_pie";
            this.pnl_linea_pie.Size = new System.Drawing.Size(374, 1);
            this.pnl_linea_pie.TabIndex = 22;
            //
            // btn_descartar
            //
            this.btn_descartar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_descartar.Location = new System.Drawing.Point(124, 586);
            this.btn_descartar.Name = "btn_descartar";
            this.btn_descartar.Size = new System.Drawing.Size(110, 34);
            this.btn_descartar.TabIndex = 12;
            this.btn_descartar.Text = "Descartar";
            this.btn_descartar.UseVisualStyleBackColor = false;
            this.btn_descartar.Click += new System.EventHandler(this.btn_descartar_Click);
            //
            // btn_guardar
            //
            this.btn_guardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_guardar.Location = new System.Drawing.Point(240, 586);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(120, 34);
            this.btn_guardar.TabIndex = 11;
            this.btn_guardar.Text = "Guardar cambios";
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            //
            // Usuarios
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1020, 730);
            this.Controls.Add(this.pnl_detalle);
            this.Controls.Add(this.pnl_lista);
            this.Controls.Add(this.btn_historial);
            this.Controls.Add(this.lbl_titulo);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(56)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Usuarios";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.Usuarios_Load);
            this.pnl_lista.ResumeLayout(false);
            this.pnl_lista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuarios)).EndInit();
            this.pnl_detalle.ResumeLayout(false);
            this.pnl_detalle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Button btn_historial;
        private System.Windows.Forms.Panel pnl_lista;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Button btn_suspender;
        private System.Windows.Forms.Button btn_baja;
        private System.Windows.Forms.DataGridView dgv_usuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_legajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_apellido_nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_perfil;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_estado;
        private System.Windows.Forms.Label lbl_cantidad;
        private System.Windows.Forms.Panel pnl_detalle;
        private System.Windows.Forms.Label lbl_detalle_titulo;
        private System.Windows.Forms.Button btn_restablecer;
        private System.Windows.Forms.Panel pnl_linea_detalle;
        private System.Windows.Forms.Label lbl_legajo;
        private System.Windows.Forms.TextBox txt_legajo;
        private System.Windows.Forms.Label lbl_perfil;
        private System.Windows.Forms.ComboBox cb_perfil;
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
        private System.Windows.Forms.Label lbl_fecha_alta;
        private System.Windows.Forms.TextBox txt_fecha_alta;
        private System.Windows.Forms.Label lbl_fecha_baja;
        private System.Windows.Forms.TextBox txt_fecha_baja;
        private System.Windows.Forms.Label lbl_motivo_baja;
        private System.Windows.Forms.TextBox txt_motivo_baja;
        private System.Windows.Forms.Panel pnl_linea_pie;
        private System.Windows.Forms.Button btn_descartar;
        private System.Windows.Forms.Button btn_guardar;
    }
}
