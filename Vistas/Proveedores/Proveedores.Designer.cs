namespace FixedSegurosApp.Vistas
{
    partial class Proveedores
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
            System.Windows.Forms.DataGridViewCellStyle estiloComision = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.pnl_lista = new System.Windows.Forms.Panel();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.btn_nueva = new System.Windows.Forms.Button();
            this.btn_baja = new System.Windows.Forms.Button();
            this.dgv_proveedores = new System.Windows.Forms.DataGridView();
            this.col_nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ssn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_cuit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_comision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_cantidad = new System.Windows.Forms.Label();
            this.pnl_detalle = new System.Windows.Forms.Panel();
            this.lbl_detalle_titulo = new System.Windows.Forms.Label();
            this.pnl_linea_detalle = new System.Windows.Forms.Panel();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lbl_ssn = new System.Windows.Forms.Label();
            this.txt_ssn = new System.Windows.Forms.TextBox();
            this.lbl_cuit = new System.Windows.Forms.Label();
            this.txt_cuit = new System.Windows.Forms.TextBox();
            this.lbl_tipos = new System.Windows.Forms.Label();
            this.cb_tipos = new System.Windows.Forms.ComboBox();
            this.lbl_telefono = new System.Windows.Forms.Label();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lbl_sitio = new System.Windows.Forms.Label();
            this.txt_sitio = new System.Windows.Forms.TextBox();
            this.lbl_comision = new System.Windows.Forms.Label();
            this.txt_comision = new System.Windows.Forms.TextBox();
            this.lbl_direccion = new System.Windows.Forms.Label();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.lbl_provincia = new System.Windows.Forms.Label();
            this.cb_provincia = new System.Windows.Forms.ComboBox();
            this.lbl_ciudad = new System.Windows.Forms.Label();
            this.txt_ciudad = new System.Windows.Forms.TextBox();
            this.pnl_linea_pie = new System.Windows.Forms.Panel();
            this.btn_descartar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.pnl_lista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_proveedores)).BeginInit();
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
            this.lbl_titulo.Size = new System.Drawing.Size(131, 30);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Proveedores";
            //
            // pnl_lista
            //
            this.pnl_lista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_lista.Controls.Add(this.txt_buscar);
            this.pnl_lista.Controls.Add(this.btn_nueva);
            this.pnl_lista.Controls.Add(this.btn_baja);
            this.pnl_lista.Controls.Add(this.dgv_proveedores);
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
            this.txt_buscar.Size = new System.Drawing.Size(282, 25);
            this.txt_buscar.TabIndex = 0;
            this.txt_buscar.TextChanged += new System.EventHandler(this.txt_buscar_TextChanged);
            //
            // btn_nueva
            //
            this.btn_nueva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_nueva.Location = new System.Drawing.Point(306, 14);
            this.btn_nueva.Name = "btn_nueva";
            this.btn_nueva.Size = new System.Drawing.Size(150, 30);
            this.btn_nueva.TabIndex = 1;
            this.btn_nueva.Text = "Nueva aseguradora";
            this.btn_nueva.UseVisualStyleBackColor = false;
            this.btn_nueva.Click += new System.EventHandler(this.btn_nueva_Click);
            //
            // btn_baja
            //
            this.btn_baja.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_baja.Location = new System.Drawing.Point(462, 14);
            this.btn_baja.Name = "btn_baja";
            this.btn_baja.Size = new System.Drawing.Size(106, 30);
            this.btn_baja.TabIndex = 2;
            this.btn_baja.Text = "Dar de baja";
            this.btn_baja.UseVisualStyleBackColor = false;
            this.btn_baja.Click += new System.EventHandler(this.btn_baja_Click);
            //
            // dgv_proveedores
            //
            this.dgv_proveedores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_proveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_nombre,
            this.col_ssn,
            this.col_cuit,
            this.col_comision,
            this.col_estado});
            this.dgv_proveedores.Location = new System.Drawing.Point(1, 58);
            this.dgv_proveedores.Name = "dgv_proveedores";
            this.dgv_proveedores.Size = new System.Drawing.Size(582, 536);
            this.dgv_proveedores.TabIndex = 3;
            this.dgv_proveedores.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_proveedores_CellFormatting);
            this.dgv_proveedores.SelectionChanged += new System.EventHandler(this.dgv_proveedores_SelectionChanged);
            //
            // col_nombre
            //
            this.col_nombre.DataPropertyName = "Nombre";
            this.col_nombre.FillWeight = 140F;
            this.col_nombre.HeaderText = "Aseguradora";
            this.col_nombre.Name = "col_nombre";
            //
            // col_ssn
            //
            this.col_ssn.DataPropertyName = "RegistroSSN";
            this.col_ssn.FillWeight = 85F;
            this.col_ssn.HeaderText = "Registro SSN";
            this.col_ssn.Name = "col_ssn";
            //
            // col_cuit
            //
            this.col_cuit.DataPropertyName = "Cuit";
            this.col_cuit.FillWeight = 110F;
            this.col_cuit.HeaderText = "CUIT";
            this.col_cuit.Name = "col_cuit";
            //
            // col_comision
            //
            this.col_comision.DataPropertyName = "Comision";
            estiloComision.Format = "0.##\' %\'";
            this.col_comision.DefaultCellStyle = estiloComision;
            this.col_comision.FillWeight = 75F;
            this.col_comision.HeaderText = "Comisión";
            this.col_comision.Name = "col_comision";
            //
            // col_estado
            //
            this.col_estado.DataPropertyName = "Estado";
            this.col_estado.FillWeight = 70F;
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
            this.lbl_cantidad.Size = new System.Drawing.Size(145, 15);
            this.lbl_cantidad.TabIndex = 4;
            this.lbl_cantidad.Text = "Mostrando 0 aseguradoras";
            //
            // pnl_detalle
            //
            this.pnl_detalle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_detalle.Controls.Add(this.lbl_detalle_titulo);
            this.pnl_detalle.Controls.Add(this.pnl_linea_detalle);
            this.pnl_detalle.Controls.Add(this.lbl_nombre);
            this.pnl_detalle.Controls.Add(this.txt_nombre);
            this.pnl_detalle.Controls.Add(this.lbl_ssn);
            this.pnl_detalle.Controls.Add(this.txt_ssn);
            this.pnl_detalle.Controls.Add(this.lbl_cuit);
            this.pnl_detalle.Controls.Add(this.txt_cuit);
            this.pnl_detalle.Controls.Add(this.lbl_tipos);
            this.pnl_detalle.Controls.Add(this.cb_tipos);
            this.pnl_detalle.Controls.Add(this.lbl_telefono);
            this.pnl_detalle.Controls.Add(this.txt_telefono);
            this.pnl_detalle.Controls.Add(this.lbl_email);
            this.pnl_detalle.Controls.Add(this.txt_email);
            this.pnl_detalle.Controls.Add(this.lbl_sitio);
            this.pnl_detalle.Controls.Add(this.txt_sitio);
            this.pnl_detalle.Controls.Add(this.lbl_comision);
            this.pnl_detalle.Controls.Add(this.txt_comision);
            this.pnl_detalle.Controls.Add(this.lbl_direccion);
            this.pnl_detalle.Controls.Add(this.txt_direccion);
            this.pnl_detalle.Controls.Add(this.lbl_provincia);
            this.pnl_detalle.Controls.Add(this.cb_provincia);
            this.pnl_detalle.Controls.Add(this.lbl_ciudad);
            this.pnl_detalle.Controls.Add(this.txt_ciudad);
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
            this.lbl_detalle_titulo.Size = new System.Drawing.Size(175, 20);
            this.lbl_detalle_titulo.TabIndex = 0;
            this.lbl_detalle_titulo.Text = "Datos de la aseguradora";
            //
            // pnl_linea_detalle
            //
            this.pnl_linea_detalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(221)))), ((int)(((byte)(232)))));
            this.pnl_linea_detalle.Location = new System.Drawing.Point(1, 54);
            this.pnl_linea_detalle.Name = "pnl_linea_detalle";
            this.pnl_linea_detalle.Size = new System.Drawing.Size(374, 1);
            this.pnl_linea_detalle.TabIndex = 20;
            //
            // lbl_nombre
            //
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_nombre.Location = new System.Drawing.Point(16, 66);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(77, 15);
            this.lbl_nombre.Text = "Nombre legal";
            //
            // txt_nombre
            //
            this.txt_nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_nombre.Location = new System.Drawing.Point(16, 86);
            this.txt_nombre.MaxLength = 60;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(344, 23);
            this.txt_nombre.TabIndex = 1;
            //
            // lbl_ssn
            //
            this.lbl_ssn.AutoSize = true;
            this.lbl_ssn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_ssn.Location = new System.Drawing.Point(16, 120);
            this.lbl_ssn.Name = "lbl_ssn";
            this.lbl_ssn.Size = new System.Drawing.Size(74, 15);
            this.lbl_ssn.Text = "Registro SSN";
            //
            // txt_ssn
            //
            this.txt_ssn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ssn.Location = new System.Drawing.Point(16, 140);
            this.txt_ssn.MaxLength = 50;
            this.txt_ssn.Name = "txt_ssn";
            this.txt_ssn.Size = new System.Drawing.Size(164, 23);
            this.txt_ssn.TabIndex = 2;
            //
            // lbl_cuit
            //
            this.lbl_cuit.AutoSize = true;
            this.lbl_cuit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_cuit.Location = new System.Drawing.Point(196, 120);
            this.lbl_cuit.Name = "lbl_cuit";
            this.lbl_cuit.Size = new System.Drawing.Size(32, 15);
            this.lbl_cuit.Text = "CUIT";
            //
            // txt_cuit
            //
            this.txt_cuit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_cuit.Location = new System.Drawing.Point(196, 140);
            this.txt_cuit.MaxLength = 13;
            this.txt_cuit.Name = "txt_cuit";
            this.txt_cuit.Size = new System.Drawing.Size(164, 23);
            this.txt_cuit.TabIndex = 3;
            //
            // lbl_tipos
            //
            this.lbl_tipos.AutoSize = true;
            this.lbl_tipos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_tipos.Location = new System.Drawing.Point(16, 174);
            this.lbl_tipos.Name = "lbl_tipos";
            this.lbl_tipos.Size = new System.Drawing.Size(144, 15);
            this.lbl_tipos.Text = "Tipos de seguros ofrecidos";
            //
            // cb_tipos
            //
            this.cb_tipos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_tipos.Items.AddRange(new object[] {
            "Automotor",
            "Motovehículos",
            "Automotor y motovehículos",
            "Transporte de carga"});
            this.cb_tipos.Location = new System.Drawing.Point(16, 194);
            this.cb_tipos.Name = "cb_tipos";
            this.cb_tipos.Size = new System.Drawing.Size(344, 23);
            this.cb_tipos.TabIndex = 4;
            //
            // lbl_telefono
            //
            this.lbl_telefono.AutoSize = true;
            this.lbl_telefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_telefono.Location = new System.Drawing.Point(16, 228);
            this.lbl_telefono.Name = "lbl_telefono";
            this.lbl_telefono.Size = new System.Drawing.Size(113, 15);
            this.lbl_telefono.Text = "Teléfono de soporte";
            //
            // txt_telefono
            //
            this.txt_telefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_telefono.Location = new System.Drawing.Point(16, 248);
            this.txt_telefono.MaxLength = 12;
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(164, 23);
            this.txt_telefono.TabIndex = 5;
            //
            // lbl_email
            //
            this.lbl_email.AutoSize = true;
            this.lbl_email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_email.Location = new System.Drawing.Point(196, 228);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(103, 15);
            this.lbl_email.Text = "Email de contacto";
            //
            // txt_email
            //
            this.txt_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_email.Location = new System.Drawing.Point(196, 248);
            this.txt_email.MaxLength = 40;
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(164, 23);
            this.txt_email.TabIndex = 6;
            //
            // lbl_sitio
            //
            this.lbl_sitio.AutoSize = true;
            this.lbl_sitio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_sitio.Location = new System.Drawing.Point(16, 282);
            this.lbl_sitio.Name = "lbl_sitio";
            this.lbl_sitio.Size = new System.Drawing.Size(55, 15);
            this.lbl_sitio.Text = "Sitio web";
            //
            // txt_sitio
            //
            this.txt_sitio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_sitio.Location = new System.Drawing.Point(16, 302);
            this.txt_sitio.MaxLength = 60;
            this.txt_sitio.Name = "txt_sitio";
            this.txt_sitio.Size = new System.Drawing.Size(164, 23);
            this.txt_sitio.TabIndex = 7;
            //
            // lbl_comision
            //
            this.lbl_comision.AutoSize = true;
            this.lbl_comision.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_comision.Location = new System.Drawing.Point(196, 282);
            this.lbl_comision.Name = "lbl_comision";
            this.lbl_comision.Size = new System.Drawing.Size(81, 15);
            this.lbl_comision.Text = "Comisión (%)";
            //
            // txt_comision
            //
            this.txt_comision.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_comision.Location = new System.Drawing.Point(196, 302);
            this.txt_comision.MaxLength = 6;
            this.txt_comision.Name = "txt_comision";
            this.txt_comision.Size = new System.Drawing.Size(164, 23);
            this.txt_comision.TabIndex = 8;
            //
            // lbl_direccion
            //
            this.lbl_direccion.AutoSize = true;
            this.lbl_direccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_direccion.Location = new System.Drawing.Point(16, 336);
            this.lbl_direccion.Name = "lbl_direccion";
            this.lbl_direccion.Size = new System.Drawing.Size(57, 15);
            this.lbl_direccion.Text = "Dirección";
            //
            // txt_direccion
            //
            this.txt_direccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_direccion.Location = new System.Drawing.Point(16, 356);
            this.txt_direccion.MaxLength = 50;
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(344, 23);
            this.txt_direccion.TabIndex = 9;
            //
            // lbl_provincia
            //
            this.lbl_provincia.AutoSize = true;
            this.lbl_provincia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_provincia.Location = new System.Drawing.Point(16, 390);
            this.lbl_provincia.Name = "lbl_provincia";
            this.lbl_provincia.Size = new System.Drawing.Size(56, 15);
            this.lbl_provincia.Text = "Provincia";
            //
            // cb_provincia
            //
            this.cb_provincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_provincia.Location = new System.Drawing.Point(16, 410);
            this.cb_provincia.Name = "cb_provincia";
            this.cb_provincia.Size = new System.Drawing.Size(164, 23);
            this.cb_provincia.TabIndex = 10;
            //
            // lbl_ciudad
            //
            this.lbl_ciudad.AutoSize = true;
            this.lbl_ciudad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_ciudad.Location = new System.Drawing.Point(196, 390);
            this.lbl_ciudad.Name = "lbl_ciudad";
            this.lbl_ciudad.Size = new System.Drawing.Size(45, 15);
            this.lbl_ciudad.Text = "Ciudad";
            //
            // txt_ciudad
            //
            this.txt_ciudad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ciudad.Location = new System.Drawing.Point(196, 410);
            this.txt_ciudad.MaxLength = 60;
            this.txt_ciudad.Name = "txt_ciudad";
            this.txt_ciudad.Size = new System.Drawing.Size(164, 23);
            this.txt_ciudad.TabIndex = 11;
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
            this.btn_descartar.TabIndex = 13;
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
            this.btn_guardar.TabIndex = 12;
            this.btn_guardar.Text = "Guardar cambios";
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            //
            // Proveedores
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
            this.Name = "Proveedores";
            this.Text = "Proveedores";
            this.Load += new System.EventHandler(this.Proveedores_Load);
            this.pnl_lista.ResumeLayout(false);
            this.pnl_lista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_proveedores)).EndInit();
            this.pnl_detalle.ResumeLayout(false);
            this.pnl_detalle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Panel pnl_lista;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Button btn_nueva;
        private System.Windows.Forms.Button btn_baja;
        private System.Windows.Forms.DataGridView dgv_proveedores;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ssn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cuit;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_comision;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_estado;
        private System.Windows.Forms.Label lbl_cantidad;
        private System.Windows.Forms.Panel pnl_detalle;
        private System.Windows.Forms.Label lbl_detalle_titulo;
        private System.Windows.Forms.Panel pnl_linea_detalle;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label lbl_ssn;
        private System.Windows.Forms.TextBox txt_ssn;
        private System.Windows.Forms.Label lbl_cuit;
        private System.Windows.Forms.TextBox txt_cuit;
        private System.Windows.Forms.Label lbl_tipos;
        private System.Windows.Forms.ComboBox cb_tipos;
        private System.Windows.Forms.Label lbl_telefono;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label lbl_sitio;
        private System.Windows.Forms.TextBox txt_sitio;
        private System.Windows.Forms.Label lbl_comision;
        private System.Windows.Forms.TextBox txt_comision;
        private System.Windows.Forms.Label lbl_direccion;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.Label lbl_provincia;
        private System.Windows.Forms.ComboBox cb_provincia;
        private System.Windows.Forms.Label lbl_ciudad;
        private System.Windows.Forms.TextBox txt_ciudad;
        private System.Windows.Forms.Panel pnl_linea_pie;
        private System.Windows.Forms.Button btn_descartar;
        private System.Windows.Forms.Button btn_guardar;
    }
}
