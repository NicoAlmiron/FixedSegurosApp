namespace FixedSegurosApp.Vistas
{
    partial class Empleados
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
            System.Windows.Forms.DataGridViewCellStyle estiloIngreso = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.pnl_lista = new System.Windows.Forms.Panel();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.btn_habilitar = new System.Windows.Forms.Button();
            this.btn_deshabilitar = new System.Windows.Forms.Button();
            this.dgv_empleados = new System.Windows.Forms.DataGridView();
            this.col_legajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_apellido_nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_puesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ingreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_cantidad = new System.Windows.Forms.Label();
            this.pnl_detalle = new System.Windows.Forms.Panel();
            this.lbl_detalle_titulo = new System.Windows.Forms.Label();
            this.pnl_linea_detalle = new System.Windows.Forms.Panel();
            this.lbl_legajo = new System.Windows.Forms.Label();
            this.txt_legajo = new System.Windows.Forms.TextBox();
            this.lbl_dni = new System.Windows.Forms.Label();
            this.txt_dni = new System.Windows.Forms.TextBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.lbl_puesto = new System.Windows.Forms.Label();
            this.cb_puesto = new System.Windows.Forms.ComboBox();
            this.lbl_fecha_ingreso = new System.Windows.Forms.Label();
            this.dtp_fecha_ingreso = new System.Windows.Forms.DateTimePicker();
            this.grp_habilitacion = new System.Windows.Forms.GroupBox();
            this.lbl_estado_titulo = new System.Windows.Forms.Label();
            this.lbl_estado_valor = new System.Windows.Forms.Label();
            this.lbl_explicacion = new System.Windows.Forms.Label();
            this.pnl_linea_pie = new System.Windows.Forms.Panel();
            this.btn_descartar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.pnl_lista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_empleados)).BeginInit();
            this.pnl_detalle.SuspendLayout();
            this.grp_habilitacion.SuspendLayout();
            this.SuspendLayout();
            //
            // lbl_titulo
            //
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Segoe UI Semibold", 16F);
            this.lbl_titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(58)))), ((int)(((byte)(92)))));
            this.lbl_titulo.Location = new System.Drawing.Point(20, 20);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(117, 30);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Empleados";
            //
            // pnl_lista
            //
            this.pnl_lista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_lista.Controls.Add(this.txt_buscar);
            this.pnl_lista.Controls.Add(this.btn_habilitar);
            this.pnl_lista.Controls.Add(this.btn_deshabilitar);
            this.pnl_lista.Controls.Add(this.dgv_empleados);
            this.pnl_lista.Controls.Add(this.lbl_cantidad);
            this.pnl_lista.Location = new System.Drawing.Point(24, 70);
            this.pnl_lista.Name = "pnl_lista";
            this.pnl_lista.Size = new System.Drawing.Size(584, 636);
            this.pnl_lista.TabIndex = 1;
            //
            // txt_buscar
            //
            this.txt_buscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_buscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_buscar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_buscar.Location = new System.Drawing.Point(16, 16);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(300, 25);
            this.txt_buscar.TabIndex = 0;
            this.txt_buscar.TextChanged += new System.EventHandler(this.txt_buscar_TextChanged);
            //
            // btn_habilitar
            //
            this.btn_habilitar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_habilitar.Location = new System.Drawing.Point(324, 14);
            this.btn_habilitar.Name = "btn_habilitar";
            this.btn_habilitar.Size = new System.Drawing.Size(116, 30);
            this.btn_habilitar.TabIndex = 1;
            this.btn_habilitar.Text = "Habilitar";
            this.btn_habilitar.UseVisualStyleBackColor = false;
            this.btn_habilitar.Click += new System.EventHandler(this.btn_habilitar_Click);
            //
            // btn_deshabilitar
            //
            this.btn_deshabilitar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_deshabilitar.Location = new System.Drawing.Point(446, 14);
            this.btn_deshabilitar.Name = "btn_deshabilitar";
            this.btn_deshabilitar.Size = new System.Drawing.Size(122, 30);
            this.btn_deshabilitar.TabIndex = 2;
            this.btn_deshabilitar.Text = "Deshabilitar";
            this.btn_deshabilitar.UseVisualStyleBackColor = false;
            this.btn_deshabilitar.Click += new System.EventHandler(this.btn_deshabilitar_Click);
            //
            // dgv_empleados
            //
            this.dgv_empleados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_empleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_legajo,
            this.col_apellido_nombre,
            this.col_puesto,
            this.col_ingreso,
            this.col_estado});
            this.dgv_empleados.Location = new System.Drawing.Point(1, 58);
            this.dgv_empleados.Name = "dgv_empleados";
            this.dgv_empleados.Size = new System.Drawing.Size(582, 536);
            this.dgv_empleados.TabIndex = 3;
            this.dgv_empleados.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_empleados_CellFormatting);
            this.dgv_empleados.SelectionChanged += new System.EventHandler(this.dgv_empleados_SelectionChanged);
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
            this.col_apellido_nombre.FillWeight = 130F;
            this.col_apellido_nombre.HeaderText = "Apellido y nombre";
            this.col_apellido_nombre.Name = "col_apellido_nombre";
            //
            // col_puesto
            //
            this.col_puesto.DataPropertyName = "Puesto";
            this.col_puesto.FillWeight = 120F;
            this.col_puesto.HeaderText = "Puesto";
            this.col_puesto.Name = "col_puesto";
            //
            // col_ingreso
            //
            this.col_ingreso.DataPropertyName = "FechaIngreso";
            estiloIngreso.Format = "dd/MM/yyyy";
            this.col_ingreso.DefaultCellStyle = estiloIngreso;
            this.col_ingreso.FillWeight = 75F;
            this.col_ingreso.HeaderText = "Ingreso";
            this.col_ingreso.Name = "col_ingreso";
            //
            // col_estado
            //
            this.col_estado.DataPropertyName = "EstadoMostrado";
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
            this.lbl_cantidad.Size = new System.Drawing.Size(130, 15);
            this.lbl_cantidad.TabIndex = 4;
            this.lbl_cantidad.Text = "Mostrando 0 empleados";
            //
            // pnl_detalle
            //
            this.pnl_detalle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_detalle.Controls.Add(this.lbl_detalle_titulo);
            this.pnl_detalle.Controls.Add(this.pnl_linea_detalle);
            this.pnl_detalle.Controls.Add(this.lbl_legajo);
            this.pnl_detalle.Controls.Add(this.txt_legajo);
            this.pnl_detalle.Controls.Add(this.lbl_dni);
            this.pnl_detalle.Controls.Add(this.txt_dni);
            this.pnl_detalle.Controls.Add(this.lbl_nombre);
            this.pnl_detalle.Controls.Add(this.txt_nombre);
            this.pnl_detalle.Controls.Add(this.lbl_apellido);
            this.pnl_detalle.Controls.Add(this.txt_apellido);
            this.pnl_detalle.Controls.Add(this.lbl_puesto);
            this.pnl_detalle.Controls.Add(this.cb_puesto);
            this.pnl_detalle.Controls.Add(this.lbl_fecha_ingreso);
            this.pnl_detalle.Controls.Add(this.dtp_fecha_ingreso);
            this.pnl_detalle.Controls.Add(this.grp_habilitacion);
            this.pnl_detalle.Controls.Add(this.pnl_linea_pie);
            this.pnl_detalle.Controls.Add(this.btn_descartar);
            this.pnl_detalle.Controls.Add(this.btn_guardar);
            this.pnl_detalle.Location = new System.Drawing.Point(620, 70);
            this.pnl_detalle.Name = "pnl_detalle";
            this.pnl_detalle.Size = new System.Drawing.Size(376, 636);
            this.pnl_detalle.TabIndex = 2;
            //
            // lbl_detalle_titulo
            //
            this.lbl_detalle_titulo.AutoSize = true;
            this.lbl_detalle_titulo.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.lbl_detalle_titulo.Location = new System.Drawing.Point(14, 18);
            this.lbl_detalle_titulo.Name = "lbl_detalle_titulo";
            this.lbl_detalle_titulo.Size = new System.Drawing.Size(140, 20);
            this.lbl_detalle_titulo.TabIndex = 0;
            this.lbl_detalle_titulo.Text = "Datos del empleado";
            //
            // pnl_linea_detalle
            //
            this.pnl_linea_detalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(221)))), ((int)(((byte)(232)))));
            this.pnl_linea_detalle.Location = new System.Drawing.Point(1, 54);
            this.pnl_linea_detalle.Name = "pnl_linea_detalle";
            this.pnl_linea_detalle.Size = new System.Drawing.Size(374, 1);
            this.pnl_linea_detalle.TabIndex = 20;
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
            // lbl_dni
            //
            this.lbl_dni.AutoSize = true;
            this.lbl_dni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_dni.Location = new System.Drawing.Point(196, 66);
            this.lbl_dni.Name = "lbl_dni";
            this.lbl_dni.Size = new System.Drawing.Size(27, 15);
            this.lbl_dni.Text = "DNI";
            //
            // txt_dni
            //
            this.txt_dni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.txt_dni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_dni.Location = new System.Drawing.Point(196, 86);
            this.txt_dni.Name = "txt_dni";
            this.txt_dni.ReadOnly = true;
            this.txt_dni.Size = new System.Drawing.Size(164, 23);
            this.txt_dni.TabStop = false;
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
            this.txt_nombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.txt_nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_nombre.Location = new System.Drawing.Point(16, 140);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.ReadOnly = true;
            this.txt_nombre.Size = new System.Drawing.Size(164, 23);
            this.txt_nombre.TabStop = false;
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
            this.txt_apellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.txt_apellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_apellido.Location = new System.Drawing.Point(196, 140);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.ReadOnly = true;
            this.txt_apellido.Size = new System.Drawing.Size(164, 23);
            this.txt_apellido.TabStop = false;
            //
            // lbl_puesto
            //
            this.lbl_puesto.AutoSize = true;
            this.lbl_puesto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_puesto.Location = new System.Drawing.Point(16, 174);
            this.lbl_puesto.Name = "lbl_puesto";
            this.lbl_puesto.Size = new System.Drawing.Size(43, 15);
            this.lbl_puesto.Text = "Puesto";
            //
            // cb_puesto
            //
            this.cb_puesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_puesto.Items.AddRange(new object[] {
            "Atención al cliente",
            "Gestor de pólizas",
            "Gestor de siniestros"});
            this.cb_puesto.Location = new System.Drawing.Point(16, 194);
            this.cb_puesto.Name = "cb_puesto";
            this.cb_puesto.Size = new System.Drawing.Size(164, 23);
            this.cb_puesto.TabIndex = 1;
            //
            // lbl_fecha_ingreso
            //
            this.lbl_fecha_ingreso.AutoSize = true;
            this.lbl_fecha_ingreso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_fecha_ingreso.Location = new System.Drawing.Point(196, 174);
            this.lbl_fecha_ingreso.Name = "lbl_fecha_ingreso";
            this.lbl_fecha_ingreso.Size = new System.Drawing.Size(97, 15);
            this.lbl_fecha_ingreso.Text = "Fecha de ingreso";
            //
            // dtp_fecha_ingreso
            //
            this.dtp_fecha_ingreso.CustomFormat = "dd/MM/yyyy";
            this.dtp_fecha_ingreso.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_fecha_ingreso.Location = new System.Drawing.Point(196, 194);
            this.dtp_fecha_ingreso.Name = "dtp_fecha_ingreso";
            this.dtp_fecha_ingreso.Size = new System.Drawing.Size(164, 23);
            this.dtp_fecha_ingreso.TabIndex = 2;
            //
            // grp_habilitacion
            //
            this.grp_habilitacion.Controls.Add(this.lbl_estado_titulo);
            this.grp_habilitacion.Controls.Add(this.lbl_estado_valor);
            this.grp_habilitacion.Controls.Add(this.lbl_explicacion);
            this.grp_habilitacion.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.grp_habilitacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(58)))), ((int)(((byte)(92)))));
            this.grp_habilitacion.Location = new System.Drawing.Point(16, 238);
            this.grp_habilitacion.Name = "grp_habilitacion";
            this.grp_habilitacion.Size = new System.Drawing.Size(344, 140);
            this.grp_habilitacion.TabIndex = 21;
            this.grp_habilitacion.TabStop = false;
            this.grp_habilitacion.Text = "Habilitación";
            //
            // lbl_estado_titulo
            //
            this.lbl_estado_titulo.AutoSize = true;
            this.lbl_estado_titulo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_estado_titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(56)))));
            this.lbl_estado_titulo.Location = new System.Drawing.Point(14, 32);
            this.lbl_estado_titulo.Name = "lbl_estado_titulo";
            this.lbl_estado_titulo.Size = new System.Drawing.Size(79, 15);
            this.lbl_estado_titulo.Text = "Estado actual:";
            //
            // lbl_estado_valor
            //
            this.lbl_estado_valor.AutoSize = true;
            this.lbl_estado_valor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(0)))));
            this.lbl_estado_valor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_estado_valor.ForeColor = System.Drawing.Color.White;
            this.lbl_estado_valor.Location = new System.Drawing.Point(100, 30);
            this.lbl_estado_valor.Name = "lbl_estado_valor";
            this.lbl_estado_valor.Padding = new System.Windows.Forms.Padding(6, 2, 6, 2);
            this.lbl_estado_valor.Size = new System.Drawing.Size(96, 19);
            this.lbl_estado_valor.Text = "Por habilitar";
            //
            // lbl_explicacion
            //
            this.lbl_explicacion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_explicacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_explicacion.Location = new System.Drawing.Point(14, 60);
            this.lbl_explicacion.Name = "lbl_explicacion";
            this.lbl_explicacion.Size = new System.Drawing.Size(316, 70);
            this.lbl_explicacion.Text = "Hasta que el Administrador lo habilite, el empleado no puede iniciar sesión, iniciar reclamos, consultar datos ni dar de baja pólizas. Cada operación que realice queda registrada a su nombre.";
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
            this.btn_descartar.TabIndex = 4;
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
            this.btn_guardar.TabIndex = 3;
            this.btn_guardar.Text = "Guardar cambios";
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            //
            // Empleados
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1020, 730);
            this.Controls.Add(this.pnl_detalle);
            this.Controls.Add(this.pnl_lista);
            this.Controls.Add(this.lbl_titulo);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(56)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Empleados";
            this.Text = "Empleados";
            this.Load += new System.EventHandler(this.Empleados_Load);
            this.pnl_lista.ResumeLayout(false);
            this.pnl_lista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_empleados)).EndInit();
            this.pnl_detalle.ResumeLayout(false);
            this.pnl_detalle.PerformLayout();
            this.grp_habilitacion.ResumeLayout(false);
            this.grp_habilitacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Panel pnl_lista;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Button btn_habilitar;
        private System.Windows.Forms.Button btn_deshabilitar;
        private System.Windows.Forms.DataGridView dgv_empleados;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_legajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_apellido_nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_puesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ingreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_estado;
        private System.Windows.Forms.Label lbl_cantidad;
        private System.Windows.Forms.Panel pnl_detalle;
        private System.Windows.Forms.Label lbl_detalle_titulo;
        private System.Windows.Forms.Panel pnl_linea_detalle;
        private System.Windows.Forms.Label lbl_legajo;
        private System.Windows.Forms.TextBox txt_legajo;
        private System.Windows.Forms.Label lbl_dni;
        private System.Windows.Forms.TextBox txt_dni;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label lbl_apellido;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.Label lbl_puesto;
        private System.Windows.Forms.ComboBox cb_puesto;
        private System.Windows.Forms.Label lbl_fecha_ingreso;
        private System.Windows.Forms.DateTimePicker dtp_fecha_ingreso;
        private System.Windows.Forms.GroupBox grp_habilitacion;
        private System.Windows.Forms.Label lbl_estado_titulo;
        private System.Windows.Forms.Label lbl_estado_valor;
        private System.Windows.Forms.Label lbl_explicacion;
        private System.Windows.Forms.Panel pnl_linea_pie;
        private System.Windows.Forms.Button btn_descartar;
        private System.Windows.Forms.Button btn_guardar;
    }
}
