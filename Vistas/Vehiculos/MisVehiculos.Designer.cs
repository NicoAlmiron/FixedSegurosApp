namespace FixedSegurosApp.Vistas
{
    partial class MisVehiculos
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
            this.pnl_lista = new System.Windows.Forms.Panel();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.dgv_vehiculos = new System.Windows.Forms.DataGridView();
            this.col_dominio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_marca_modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_anio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_poliza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_vtv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_revision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_cantidad = new System.Windows.Forms.Label();
            this.pnl_detalle = new System.Windows.Forms.Panel();
            this.lbl_detalle_titulo = new System.Windows.Forms.Label();
            this.pnl_linea_detalle = new System.Windows.Forms.Panel();
            this.lbl_tipo = new System.Windows.Forms.Label();
            this.cb_tipo = new System.Windows.Forms.ComboBox();
            this.lbl_dominio = new System.Windows.Forms.Label();
            this.txt_dominio = new System.Windows.Forms.TextBox();
            this.lbl_marca = new System.Windows.Forms.Label();
            this.txt_marca = new System.Windows.Forms.TextBox();
            this.lbl_modelo = new System.Windows.Forms.Label();
            this.txt_modelo = new System.Windows.Forms.TextBox();
            this.lbl_anio = new System.Windows.Forms.Label();
            this.txt_anio = new System.Windows.Forms.TextBox();
            this.lbl_vtv = new System.Windows.Forms.Label();
            this.cb_vtv = new System.Windows.Forms.ComboBox();
            this.lbl_chasis = new System.Windows.Forms.Label();
            this.txt_chasis = new System.Windows.Forms.TextBox();
            this.lbl_motor = new System.Windows.Forms.Label();
            this.txt_motor = new System.Windows.Forms.TextBox();
            this.lbl_revision_titulo = new System.Windows.Forms.Label();
            this.lbl_revision_valor = new System.Windows.Forms.Label();
            this.lbl_revision_motivo = new System.Windows.Forms.Label();
            this.grp_fotos = new System.Windows.Forms.GroupBox();
            this.pnl_linea_pie = new System.Windows.Forms.Panel();
            this.btn_descartar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.pnl_lista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vehiculos)).BeginInit();
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
            this.lbl_titulo.Size = new System.Drawing.Size(150, 30);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Mis vehículos";
            //
            // pnl_lista
            //
            this.pnl_lista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_lista.Controls.Add(this.btn_agregar);
            this.pnl_lista.Controls.Add(this.btn_eliminar);
            this.pnl_lista.Controls.Add(this.dgv_vehiculos);
            this.pnl_lista.Controls.Add(this.lbl_cantidad);
            this.pnl_lista.Location = new System.Drawing.Point(24, 70);
            this.pnl_lista.Name = "pnl_lista";
            this.pnl_lista.Size = new System.Drawing.Size(584, 636);
            this.pnl_lista.TabIndex = 1;
            //
            // btn_agregar
            //
            this.btn_agregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_agregar.Location = new System.Drawing.Point(330, 14);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(140, 30);
            this.btn_agregar.TabIndex = 0;
            this.btn_agregar.Text = "Agregar vehículo";
            this.btn_agregar.UseVisualStyleBackColor = false;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            //
            // btn_eliminar
            //
            this.btn_eliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_eliminar.Location = new System.Drawing.Point(476, 14);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(92, 30);
            this.btn_eliminar.TabIndex = 1;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = false;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            //
            // dgv_vehiculos
            //
            this.dgv_vehiculos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_vehiculos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_dominio,
            this.col_marca_modelo,
            this.col_anio,
            this.col_poliza,
            this.col_vtv,
            this.col_revision});
            this.dgv_vehiculos.Location = new System.Drawing.Point(1, 58);
            this.dgv_vehiculos.Name = "dgv_vehiculos";
            this.dgv_vehiculos.Size = new System.Drawing.Size(582, 536);
            this.dgv_vehiculos.TabIndex = 2;
            this.dgv_vehiculos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_vehiculos_CellFormatting);
            this.dgv_vehiculos.SelectionChanged += new System.EventHandler(this.dgv_vehiculos_SelectionChanged);
            //
            // col_dominio
            //
            this.col_dominio.DataPropertyName = "Dominio";
            this.col_dominio.FillWeight = 80F;
            this.col_dominio.HeaderText = "Dominio";
            this.col_dominio.Name = "col_dominio";
            //
            // col_marca_modelo
            //
            this.col_marca_modelo.DataPropertyName = "MarcaYModelo";
            this.col_marca_modelo.FillWeight = 130F;
            this.col_marca_modelo.HeaderText = "Marca y modelo";
            this.col_marca_modelo.Name = "col_marca_modelo";
            //
            // col_anio
            //
            this.col_anio.DataPropertyName = "Anio";
            this.col_anio.FillWeight = 50F;
            this.col_anio.HeaderText = "Año";
            this.col_anio.Name = "col_anio";
            //
            // col_poliza
            //
            this.col_poliza.DataPropertyName = "PolizaTexto";
            this.col_poliza.FillWeight = 75F;
            this.col_poliza.HeaderText = "Póliza";
            this.col_poliza.Name = "col_poliza";
            //
            // col_vtv
            //
            this.col_vtv.DataPropertyName = "VtvTexto";
            this.col_vtv.FillWeight = 85F;
            this.col_vtv.HeaderText = "VTV";
            this.col_vtv.Name = "col_vtv";
            //
            // col_revision
            //
            this.col_revision.DataPropertyName = "EstadoRevision";
            this.col_revision.FillWeight = 80F;
            this.col_revision.HeaderText = "Revisión";
            this.col_revision.Name = "col_revision";
            //
            // lbl_cantidad
            //
            this.lbl_cantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_cantidad.AutoSize = true;
            this.lbl_cantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_cantidad.Location = new System.Drawing.Point(16, 606);
            this.lbl_cantidad.Name = "lbl_cantidad";
            this.lbl_cantidad.Size = new System.Drawing.Size(126, 15);
            this.lbl_cantidad.TabIndex = 3;
            this.lbl_cantidad.Text = "Mostrando 0 vehículos";
            //
            // pnl_detalle
            //
            this.pnl_detalle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_detalle.Controls.Add(this.lbl_detalle_titulo);
            this.pnl_detalle.Controls.Add(this.pnl_linea_detalle);
            this.pnl_detalle.Controls.Add(this.lbl_tipo);
            this.pnl_detalle.Controls.Add(this.cb_tipo);
            this.pnl_detalle.Controls.Add(this.lbl_dominio);
            this.pnl_detalle.Controls.Add(this.txt_dominio);
            this.pnl_detalle.Controls.Add(this.lbl_marca);
            this.pnl_detalle.Controls.Add(this.txt_marca);
            this.pnl_detalle.Controls.Add(this.lbl_modelo);
            this.pnl_detalle.Controls.Add(this.txt_modelo);
            this.pnl_detalle.Controls.Add(this.lbl_anio);
            this.pnl_detalle.Controls.Add(this.txt_anio);
            this.pnl_detalle.Controls.Add(this.lbl_vtv);
            this.pnl_detalle.Controls.Add(this.cb_vtv);
            this.pnl_detalle.Controls.Add(this.lbl_chasis);
            this.pnl_detalle.Controls.Add(this.txt_chasis);
            this.pnl_detalle.Controls.Add(this.lbl_motor);
            this.pnl_detalle.Controls.Add(this.txt_motor);
            this.pnl_detalle.Controls.Add(this.lbl_revision_titulo);
            this.pnl_detalle.Controls.Add(this.lbl_revision_valor);
            this.pnl_detalle.Controls.Add(this.lbl_revision_motivo);
            this.pnl_detalle.Controls.Add(this.grp_fotos);
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
            this.lbl_detalle_titulo.Size = new System.Drawing.Size(134, 20);
            this.lbl_detalle_titulo.TabIndex = 0;
            this.lbl_detalle_titulo.Text = "Datos del vehículo";
            //
            // pnl_linea_detalle
            //
            this.pnl_linea_detalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(221)))), ((int)(((byte)(232)))));
            this.pnl_linea_detalle.Location = new System.Drawing.Point(1, 54);
            this.pnl_linea_detalle.Name = "pnl_linea_detalle";
            this.pnl_linea_detalle.Size = new System.Drawing.Size(374, 1);
            this.pnl_linea_detalle.TabIndex = 20;
            //
            // lbl_tipo
            //
            this.lbl_tipo.AutoSize = true;
            this.lbl_tipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_tipo.Location = new System.Drawing.Point(16, 62);
            this.lbl_tipo.Name = "lbl_tipo";
            this.lbl_tipo.Size = new System.Drawing.Size(97, 15);
            this.lbl_tipo.Text = "Tipo de vehículo";
            //
            // cb_tipo
            //
            this.cb_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_tipo.Items.AddRange(new object[] {
            "Automóvil",
            "Camioneta",
            "Motocicleta",
            "Camión"});
            this.cb_tipo.Location = new System.Drawing.Point(16, 80);
            this.cb_tipo.Name = "cb_tipo";
            this.cb_tipo.SelectedIndexChanged += new System.EventHandler(this.cb_tipo_SelectedIndexChanged);
            this.cb_tipo.Size = new System.Drawing.Size(164, 23);
            this.cb_tipo.TabIndex = 1;
            //
            // lbl_dominio
            //
            this.lbl_dominio.AutoSize = true;
            this.lbl_dominio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_dominio.Location = new System.Drawing.Point(196, 62);
            this.lbl_dominio.Name = "lbl_dominio";
            this.lbl_dominio.Size = new System.Drawing.Size(52, 15);
            this.lbl_dominio.Text = "Dominio";
            //
            // txt_dominio
            //
            this.txt_dominio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_dominio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_dominio.Location = new System.Drawing.Point(196, 80);
            this.txt_dominio.MaxLength = 10;
            this.txt_dominio.Name = "txt_dominio";
            this.txt_dominio.Size = new System.Drawing.Size(164, 23);
            this.txt_dominio.TabIndex = 2;
            //
            // lbl_marca
            //
            this.lbl_marca.AutoSize = true;
            this.lbl_marca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_marca.Location = new System.Drawing.Point(16, 110);
            this.lbl_marca.Name = "lbl_marca";
            this.lbl_marca.Size = new System.Drawing.Size(40, 15);
            this.lbl_marca.Text = "Marca";
            //
            // txt_marca
            //
            this.txt_marca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_marca.Location = new System.Drawing.Point(16, 128);
            this.txt_marca.MaxLength = 50;
            this.txt_marca.Name = "txt_marca";
            this.txt_marca.Size = new System.Drawing.Size(164, 23);
            this.txt_marca.TabIndex = 3;
            //
            // lbl_modelo
            //
            this.lbl_modelo.AutoSize = true;
            this.lbl_modelo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_modelo.Location = new System.Drawing.Point(196, 110);
            this.lbl_modelo.Name = "lbl_modelo";
            this.lbl_modelo.Size = new System.Drawing.Size(48, 15);
            this.lbl_modelo.Text = "Modelo";
            //
            // txt_modelo
            //
            this.txt_modelo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_modelo.Location = new System.Drawing.Point(196, 128);
            this.txt_modelo.MaxLength = 50;
            this.txt_modelo.Name = "txt_modelo";
            this.txt_modelo.Size = new System.Drawing.Size(164, 23);
            this.txt_modelo.TabIndex = 4;
            //
            // lbl_anio
            //
            this.lbl_anio.AutoSize = true;
            this.lbl_anio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_anio.Location = new System.Drawing.Point(16, 158);
            this.lbl_anio.Name = "lbl_anio";
            this.lbl_anio.Size = new System.Drawing.Size(29, 15);
            this.lbl_anio.Text = "Año";
            //
            // txt_anio
            //
            this.txt_anio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_anio.Location = new System.Drawing.Point(16, 176);
            this.txt_anio.MaxLength = 4;
            this.txt_anio.Name = "txt_anio";
            this.txt_anio.Size = new System.Drawing.Size(164, 23);
            this.txt_anio.TabIndex = 5;
            //
            // lbl_vtv
            //
            this.lbl_vtv.AutoSize = true;
            this.lbl_vtv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_vtv.Location = new System.Drawing.Point(196, 158);
            this.lbl_vtv.Name = "lbl_vtv";
            this.lbl_vtv.Size = new System.Drawing.Size(98, 15);
            this.lbl_vtv.Text = "Estado de la VTV";
            //
            // cb_vtv
            //
            this.cb_vtv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_vtv.Items.AddRange(new object[] {
            "Vigente",
            "Vencida"});
            this.cb_vtv.Location = new System.Drawing.Point(196, 176);
            this.cb_vtv.Name = "cb_vtv";
            this.cb_vtv.Size = new System.Drawing.Size(164, 23);
            this.cb_vtv.TabIndex = 6;
            //
            // lbl_chasis
            //
            this.lbl_chasis.AutoSize = true;
            this.lbl_chasis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_chasis.Location = new System.Drawing.Point(16, 206);
            this.lbl_chasis.Name = "lbl_chasis";
            this.lbl_chasis.Size = new System.Drawing.Size(73, 15);
            this.lbl_chasis.Text = "N° de chasis";
            //
            // txt_chasis
            //
            this.txt_chasis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_chasis.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_chasis.Location = new System.Drawing.Point(16, 224);
            this.txt_chasis.MaxLength = 25;
            this.txt_chasis.Name = "txt_chasis";
            this.txt_chasis.Size = new System.Drawing.Size(164, 23);
            this.txt_chasis.TabIndex = 7;
            //
            // lbl_motor
            //
            this.lbl_motor.AutoSize = true;
            this.lbl_motor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_motor.Location = new System.Drawing.Point(196, 206);
            this.lbl_motor.Name = "lbl_motor";
            this.lbl_motor.Size = new System.Drawing.Size(70, 15);
            this.lbl_motor.Text = "N° de motor";
            //
            // txt_motor
            //
            this.txt_motor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_motor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_motor.Location = new System.Drawing.Point(196, 224);
            this.txt_motor.MaxLength = 20;
            this.txt_motor.Name = "txt_motor";
            this.txt_motor.Size = new System.Drawing.Size(164, 23);
            this.txt_motor.TabIndex = 8;
            //
            // lbl_revision_titulo
            //
            this.lbl_revision_titulo.AutoSize = true;
            this.lbl_revision_titulo.Location = new System.Drawing.Point(16, 260);
            this.lbl_revision_titulo.Name = "lbl_revision_titulo";
            this.lbl_revision_titulo.Size = new System.Drawing.Size(55, 15);
            this.lbl_revision_titulo.Text = "Revisión:";
            //
            // lbl_revision_valor
            //
            this.lbl_revision_valor.AutoSize = true;
            this.lbl_revision_valor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(0)))));
            this.lbl_revision_valor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_revision_valor.ForeColor = System.Drawing.Color.White;
            this.lbl_revision_valor.Location = new System.Drawing.Point(76, 258);
            this.lbl_revision_valor.Name = "lbl_revision_valor";
            this.lbl_revision_valor.Padding = new System.Windows.Forms.Padding(6, 2, 6, 2);
            this.lbl_revision_valor.Size = new System.Drawing.Size(80, 19);
            this.lbl_revision_valor.Text = "Pendiente";
            //
            // lbl_revision_motivo
            //
            this.lbl_revision_motivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.lbl_revision_motivo.Location = new System.Drawing.Point(16, 282);
            this.lbl_revision_motivo.Name = "lbl_revision_motivo";
            this.lbl_revision_motivo.Size = new System.Drawing.Size(344, 32);
            this.lbl_revision_motivo.Text = "Motivo del rechazo";
            //
            // grp_fotos
            //
            this.grp_fotos.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.grp_fotos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(58)))), ((int)(((byte)(92)))));
            this.grp_fotos.Location = new System.Drawing.Point(16, 318);
            this.grp_fotos.Name = "grp_fotos";
            this.grp_fotos.Size = new System.Drawing.Size(344, 170);
            this.grp_fotos.TabIndex = 9;
            this.grp_fotos.TabStop = false;
            this.grp_fotos.Text = "Fotos del vehículo (clic en cada una para cargarla)";
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
            this.btn_descartar.TabIndex = 11;
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
            this.btn_guardar.TabIndex = 10;
            this.btn_guardar.Text = "Guardar cambios";
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            //
            // MisVehiculos
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
            this.Name = "MisVehiculos";
            this.Text = "Mis vehículos";
            this.Load += new System.EventHandler(this.MisVehiculos_Load);
            this.pnl_lista.ResumeLayout(false);
            this.pnl_lista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vehiculos)).EndInit();
            this.pnl_detalle.ResumeLayout(false);
            this.pnl_detalle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Panel pnl_lista;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.DataGridView dgv_vehiculos;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dominio;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_marca_modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_anio;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_poliza;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_vtv;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_revision;
        private System.Windows.Forms.Label lbl_cantidad;
        private System.Windows.Forms.Panel pnl_detalle;
        private System.Windows.Forms.Label lbl_detalle_titulo;
        private System.Windows.Forms.Panel pnl_linea_detalle;
        private System.Windows.Forms.Label lbl_tipo;
        private System.Windows.Forms.ComboBox cb_tipo;
        private System.Windows.Forms.Label lbl_dominio;
        private System.Windows.Forms.TextBox txt_dominio;
        private System.Windows.Forms.Label lbl_marca;
        private System.Windows.Forms.TextBox txt_marca;
        private System.Windows.Forms.Label lbl_modelo;
        private System.Windows.Forms.TextBox txt_modelo;
        private System.Windows.Forms.Label lbl_anio;
        private System.Windows.Forms.TextBox txt_anio;
        private System.Windows.Forms.Label lbl_vtv;
        private System.Windows.Forms.ComboBox cb_vtv;
        private System.Windows.Forms.Label lbl_chasis;
        private System.Windows.Forms.TextBox txt_chasis;
        private System.Windows.Forms.Label lbl_motor;
        private System.Windows.Forms.TextBox txt_motor;
        private System.Windows.Forms.Label lbl_revision_titulo;
        private System.Windows.Forms.Label lbl_revision_valor;
        private System.Windows.Forms.Label lbl_revision_motivo;
        private System.Windows.Forms.GroupBox grp_fotos;
        private System.Windows.Forms.Panel pnl_linea_pie;
        private System.Windows.Forms.Button btn_descartar;
        private System.Windows.Forms.Button btn_guardar;
    }
}
