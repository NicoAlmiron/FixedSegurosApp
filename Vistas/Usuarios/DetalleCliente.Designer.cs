namespace FixedSegurosApp.Vistas
{
    partial class DetalleCliente
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
            System.Windows.Forms.DataGridViewCellStyle estiloNroPoliza = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle estiloInicio = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle estiloVence = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle estiloPagoPoliza = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle estiloPagoVence = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle estiloPagoMonto = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle estiloPagoFecha = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle estiloExpediente = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle estiloSinPoliza = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle estiloSinFecha = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle estiloSinMonto = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle estiloHistFecha = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.btn_volver = new System.Windows.Forms.Button();
            this.pnl_cliente = new System.Windows.Forms.Panel();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_estado = new System.Windows.Forms.Label();
            this.lbl_datos1 = new System.Windows.Forms.Label();
            this.lbl_datos2 = new System.Windows.Forms.Label();
            this.lbl_datos3 = new System.Windows.Forms.Label();
            this.pnl_separador = new System.Windows.Forms.Panel();
            this.lbl_observaciones = new System.Windows.Forms.Label();
            this.txt_observaciones = new System.Windows.Forms.TextBox();
            this.btn_guardar_obs = new System.Windows.Forms.Button();
            this.tab_detalle = new System.Windows.Forms.TabControl();
            this.tab_vehiculos = new System.Windows.Forms.TabPage();
            this.dgv_vehiculos = new System.Windows.Forms.DataGridView();
            this.col_veh_dominio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_veh_marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_veh_anio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_veh_vtv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_veh_estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_vehiculo = new System.Windows.Forms.Panel();
            this.lbl_vehiculo_titulo = new System.Windows.Forms.Label();
            this.lbl_revision_titulo = new System.Windows.Forms.Label();
            this.lbl_revision_valor = new System.Windows.Forms.Label();
            this.lbl_revision_detalle = new System.Windows.Forms.Label();
            this.btn_aprobar = new System.Windows.Forms.Button();
            this.btn_rechazar = new System.Windows.Forms.Button();
            this.tab_polizas = new System.Windows.Forms.TabPage();
            this.dgv_polizas = new System.Windows.Forms.DataGridView();
            this.col_pol_nro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_pol_aseguradora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_pol_dominio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_pol_cobertura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_pol_inicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_pol_vence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_pol_estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tab_pagos = new System.Windows.Forms.TabPage();
            this.dgv_pagos = new System.Windows.Forms.DataGridView();
            this.col_pag_poliza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_pag_cuota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_pag_vence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_pag_monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_pag_fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_pag_metodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_pag_estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tab_siniestros = new System.Windows.Forms.TabPage();
            this.dgv_siniestros = new System.Windows.Forms.DataGridView();
            this.col_sin_expediente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_sin_poliza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_sin_fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_sin_tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_sin_monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_sin_estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tab_historial = new System.Windows.Forms.TabPage();
            this.dgv_historial = new System.Windows.Forms.DataGridView();
            this.col_his_fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_his_modulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_his_accion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_his_detalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_cliente.SuspendLayout();
            this.tab_detalle.SuspendLayout();
            this.tab_vehiculos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vehiculos)).BeginInit();
            this.pnl_vehiculo.SuspendLayout();
            this.tab_polizas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_polizas)).BeginInit();
            this.tab_pagos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pagos)).BeginInit();
            this.tab_siniestros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_siniestros)).BeginInit();
            this.tab_historial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_historial)).BeginInit();
            this.SuspendLayout();
            //
            // lbl_titulo
            //
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Segoe UI Semibold", 16F);
            this.lbl_titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(58)))), ((int)(((byte)(92)))));
            this.lbl_titulo.Location = new System.Drawing.Point(20, 20);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(317, 30);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Usuarios › Detalle del cliente";
            //
            // btn_volver
            //
            this.btn_volver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_volver.Location = new System.Drawing.Point(836, 20);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(160, 32);
            this.btn_volver.TabIndex = 1;
            this.btn_volver.Text = "Volver a Usuarios";
            this.btn_volver.UseVisualStyleBackColor = false;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            //
            // pnl_cliente
            //
            this.pnl_cliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_cliente.Controls.Add(this.lbl_nombre);
            this.pnl_cliente.Controls.Add(this.lbl_estado);
            this.pnl_cliente.Controls.Add(this.lbl_datos1);
            this.pnl_cliente.Controls.Add(this.lbl_datos2);
            this.pnl_cliente.Controls.Add(this.lbl_datos3);
            this.pnl_cliente.Controls.Add(this.pnl_separador);
            this.pnl_cliente.Controls.Add(this.lbl_observaciones);
            this.pnl_cliente.Controls.Add(this.txt_observaciones);
            this.pnl_cliente.Controls.Add(this.btn_guardar_obs);
            this.pnl_cliente.Location = new System.Drawing.Point(24, 70);
            this.pnl_cliente.Name = "pnl_cliente";
            this.pnl_cliente.Size = new System.Drawing.Size(972, 150);
            this.pnl_cliente.TabIndex = 2;
            //
            // lbl_nombre
            //
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Segoe UI Semibold", 14F);
            this.lbl_nombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(58)))), ((int)(((byte)(92)))));
            this.lbl_nombre.Location = new System.Drawing.Point(18, 14);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(133, 25);
            this.lbl_nombre.Text = "Apellido, Nombre";
            //
            // lbl_estado
            //
            this.lbl_estado.AutoSize = true;
            this.lbl_estado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(79)))));
            this.lbl_estado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_estado.ForeColor = System.Drawing.Color.White;
            this.lbl_estado.Location = new System.Drawing.Point(260, 19);
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Padding = new System.Windows.Forms.Padding(6, 2, 6, 2);
            this.lbl_estado.Size = new System.Drawing.Size(58, 19);
            this.lbl_estado.Text = "Activo";
            //
            // lbl_datos1
            //
            this.lbl_datos1.AutoSize = true;
            this.lbl_datos1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_datos1.Location = new System.Drawing.Point(20, 52);
            this.lbl_datos1.Name = "lbl_datos1";
            this.lbl_datos1.Size = new System.Drawing.Size(100, 15);
            this.lbl_datos1.Text = "Legajo · DNI · Alta";
            //
            // lbl_datos2
            //
            this.lbl_datos2.AutoSize = true;
            this.lbl_datos2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_datos2.Location = new System.Drawing.Point(20, 78);
            this.lbl_datos2.Name = "lbl_datos2";
            this.lbl_datos2.Size = new System.Drawing.Size(100, 15);
            this.lbl_datos2.Text = "Teléfono · Email";
            //
            // lbl_datos3
            //
            this.lbl_datos3.AutoSize = true;
            this.lbl_datos3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_datos3.Location = new System.Drawing.Point(20, 104);
            this.lbl_datos3.Name = "lbl_datos3";
            this.lbl_datos3.Size = new System.Drawing.Size(57, 15);
            this.lbl_datos3.Text = "Dirección";
            //
            // pnl_separador
            //
            this.pnl_separador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_separador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(221)))), ((int)(((byte)(232)))));
            this.pnl_separador.Location = new System.Drawing.Point(560, 14);
            this.pnl_separador.Name = "pnl_separador";
            this.pnl_separador.Size = new System.Drawing.Size(1, 122);
            this.pnl_separador.TabIndex = 9;
            //
            // lbl_observaciones
            //
            this.lbl_observaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_observaciones.AutoSize = true;
            this.lbl_observaciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_observaciones.Location = new System.Drawing.Point(576, 12);
            this.lbl_observaciones.Name = "lbl_observaciones";
            this.lbl_observaciones.Size = new System.Drawing.Size(84, 15);
            this.lbl_observaciones.Text = "Observaciones";
            //
            // txt_observaciones
            //
            this.txt_observaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_observaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_observaciones.Location = new System.Drawing.Point(576, 32);
            this.txt_observaciones.MaxLength = 200;
            this.txt_observaciones.Multiline = true;
            this.txt_observaciones.Name = "txt_observaciones";
            this.txt_observaciones.Size = new System.Drawing.Size(380, 70);
            this.txt_observaciones.TabIndex = 0;
            //
            // btn_guardar_obs
            //
            this.btn_guardar_obs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_guardar_obs.Location = new System.Drawing.Point(786, 108);
            this.btn_guardar_obs.Name = "btn_guardar_obs";
            this.btn_guardar_obs.Size = new System.Drawing.Size(170, 30);
            this.btn_guardar_obs.TabIndex = 1;
            this.btn_guardar_obs.Text = "Guardar observaciones";
            this.btn_guardar_obs.UseVisualStyleBackColor = false;
            this.btn_guardar_obs.Click += new System.EventHandler(this.btn_guardar_obs_Click);
            //
            // tab_detalle
            //
            this.tab_detalle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab_detalle.Controls.Add(this.tab_vehiculos);
            this.tab_detalle.Controls.Add(this.tab_polizas);
            this.tab_detalle.Controls.Add(this.tab_pagos);
            this.tab_detalle.Controls.Add(this.tab_siniestros);
            this.tab_detalle.Controls.Add(this.tab_historial);
            this.tab_detalle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tab_detalle.Location = new System.Drawing.Point(24, 232);
            this.tab_detalle.Name = "tab_detalle";
            this.tab_detalle.Padding = new System.Drawing.Point(14, 5);
            this.tab_detalle.SelectedIndex = 0;
            this.tab_detalle.Size = new System.Drawing.Size(972, 476);
            this.tab_detalle.TabIndex = 3;
            //
            // tab_vehiculos
            //
            this.tab_vehiculos.BackColor = System.Drawing.Color.White;
            this.tab_vehiculos.Controls.Add(this.dgv_vehiculos);
            this.tab_vehiculos.Controls.Add(this.pnl_vehiculo);
            this.tab_vehiculos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tab_vehiculos.Location = new System.Drawing.Point(4, 30);
            this.tab_vehiculos.Name = "tab_vehiculos";
            this.tab_vehiculos.Size = new System.Drawing.Size(964, 442);
            this.tab_vehiculos.Padding = new System.Windows.Forms.Padding(8);
            this.tab_vehiculos.Text = "Vehículos";
            //
            // dgv_vehiculos
            //
            this.dgv_vehiculos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_vehiculos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_veh_dominio,
            this.col_veh_marca,
            this.col_veh_anio,
            this.col_veh_vtv,
            this.col_veh_estado});
            this.dgv_vehiculos.Location = new System.Drawing.Point(8, 8);
            this.dgv_vehiculos.Name = "dgv_vehiculos";
            this.dgv_vehiculos.Size = new System.Drawing.Size(556, 426);
            this.dgv_vehiculos.TabIndex = 0;
            this.dgv_vehiculos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grilla_CellFormatting);
            this.dgv_vehiculos.SelectionChanged += new System.EventHandler(this.dgv_vehiculos_SelectionChanged);
            //
            // col_veh_dominio
            //
            this.col_veh_dominio.DataPropertyName = "Dominio";
            this.col_veh_dominio.FillWeight = 80F;
            this.col_veh_dominio.HeaderText = "Dominio";
            this.col_veh_dominio.Name = "col_veh_dominio";
            //
            // col_veh_marca
            //
            this.col_veh_marca.DataPropertyName = "MarcaYModelo";
            this.col_veh_marca.FillWeight = 130F;
            this.col_veh_marca.HeaderText = "Marca y modelo";
            this.col_veh_marca.Name = "col_veh_marca";
            //
            // col_veh_anio
            //
            this.col_veh_anio.DataPropertyName = "Anio";
            this.col_veh_anio.FillWeight = 50F;
            this.col_veh_anio.HeaderText = "Año";
            this.col_veh_anio.Name = "col_veh_anio";
            //
            // col_veh_vtv
            //
            this.col_veh_vtv.DataPropertyName = "VtvTexto";
            this.col_veh_vtv.FillWeight = 85F;
            this.col_veh_vtv.HeaderText = "VTV";
            this.col_veh_vtv.Name = "col_veh_vtv";
            //
            // col_veh_estado
            //
            this.col_veh_estado.DataPropertyName = "EstadoRevision";
            this.col_veh_estado.FillWeight = 80F;
            this.col_veh_estado.HeaderText = "Revisión";
            this.col_veh_estado.Name = "col_veh_estado";
            //
            // pnl_vehiculo
            //
            this.pnl_vehiculo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_vehiculo.Controls.Add(this.lbl_vehiculo_titulo);
            this.pnl_vehiculo.Controls.Add(this.lbl_revision_titulo);
            this.pnl_vehiculo.Controls.Add(this.lbl_revision_valor);
            this.pnl_vehiculo.Controls.Add(this.lbl_revision_detalle);
            this.pnl_vehiculo.Controls.Add(this.btn_aprobar);
            this.pnl_vehiculo.Controls.Add(this.btn_rechazar);
            this.pnl_vehiculo.Location = new System.Drawing.Point(576, 8);
            this.pnl_vehiculo.Name = "pnl_vehiculo";
            this.pnl_vehiculo.Size = new System.Drawing.Size(380, 426);
            this.pnl_vehiculo.TabIndex = 1;
            //
            // lbl_vehiculo_titulo
            //
            this.lbl_vehiculo_titulo.AutoSize = true;
            this.lbl_vehiculo_titulo.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.lbl_vehiculo_titulo.Location = new System.Drawing.Point(0, 0);
            this.lbl_vehiculo_titulo.Name = "lbl_vehiculo_titulo";
            this.lbl_vehiculo_titulo.Size = new System.Drawing.Size(127, 20);
            this.lbl_vehiculo_titulo.Text = "Fotos del vehículo";
            //
            // lbl_revision_titulo
            //
            this.lbl_revision_titulo.AutoSize = true;
            this.lbl_revision_titulo.Location = new System.Drawing.Point(0, 222);
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
            this.lbl_revision_valor.Location = new System.Drawing.Point(62, 220);
            this.lbl_revision_valor.Name = "lbl_revision_valor";
            this.lbl_revision_valor.Padding = new System.Windows.Forms.Padding(6, 2, 6, 2);
            this.lbl_revision_valor.Size = new System.Drawing.Size(80, 19);
            this.lbl_revision_valor.Text = "Pendiente";
            //
            // lbl_revision_detalle
            //
            this.lbl_revision_detalle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_revision_detalle.Location = new System.Drawing.Point(0, 246);
            this.lbl_revision_detalle.Name = "lbl_revision_detalle";
            this.lbl_revision_detalle.Size = new System.Drawing.Size(380, 54);
            this.lbl_revision_detalle.Text = "Detalle de la revisión";
            //
            // btn_aprobar
            //
            this.btn_aprobar.Location = new System.Drawing.Point(0, 306);
            this.btn_aprobar.Name = "btn_aprobar";
            this.btn_aprobar.Size = new System.Drawing.Size(130, 32);
            this.btn_aprobar.TabIndex = 0;
            this.btn_aprobar.Text = "Aprobar";
            this.btn_aprobar.UseVisualStyleBackColor = false;
            this.btn_aprobar.Click += new System.EventHandler(this.btn_aprobar_Click);
            //
            // btn_rechazar
            //
            this.btn_rechazar.Location = new System.Drawing.Point(138, 306);
            this.btn_rechazar.Name = "btn_rechazar";
            this.btn_rechazar.Size = new System.Drawing.Size(130, 32);
            this.btn_rechazar.TabIndex = 1;
            this.btn_rechazar.Text = "Rechazar";
            this.btn_rechazar.UseVisualStyleBackColor = false;
            this.btn_rechazar.Click += new System.EventHandler(this.btn_rechazar_Click);
            //
            // tab_polizas
            //
            this.tab_polizas.BackColor = System.Drawing.Color.White;
            this.tab_polizas.Controls.Add(this.dgv_polizas);
            this.tab_polizas.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tab_polizas.Location = new System.Drawing.Point(4, 30);
            this.tab_polizas.Name = "tab_polizas";
            this.tab_polizas.Size = new System.Drawing.Size(964, 442);
            this.tab_polizas.Padding = new System.Windows.Forms.Padding(8);
            this.tab_polizas.Text = "Pólizas";
            //
            // dgv_polizas
            //
            this.dgv_polizas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_pol_nro,
            this.col_pol_aseguradora,
            this.col_pol_dominio,
            this.col_pol_cobertura,
            this.col_pol_inicio,
            this.col_pol_vence,
            this.col_pol_estado});
            this.dgv_polizas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_polizas.Name = "dgv_polizas";
            this.dgv_polizas.TabIndex = 0;
            this.dgv_polizas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grilla_CellFormatting);
            //
            // col_pol_nro
            //
            this.col_pol_nro.DataPropertyName = "NroPoliza";
            estiloNroPoliza.Format = "000000";
            this.col_pol_nro.DefaultCellStyle = estiloNroPoliza;
            this.col_pol_nro.FillWeight = 60F;
            this.col_pol_nro.HeaderText = "N° póliza";
            this.col_pol_nro.Name = "col_pol_nro";
            //
            // col_pol_aseguradora
            //
            this.col_pol_aseguradora.DataPropertyName = "Aseguradora";
            this.col_pol_aseguradora.FillWeight = 110F;
            this.col_pol_aseguradora.HeaderText = "Aseguradora";
            this.col_pol_aseguradora.Name = "col_pol_aseguradora";
            //
            // col_pol_dominio
            //
            this.col_pol_dominio.DataPropertyName = "Dominio";
            this.col_pol_dominio.FillWeight = 70F;
            this.col_pol_dominio.HeaderText = "Dominio";
            this.col_pol_dominio.Name = "col_pol_dominio";
            //
            // col_pol_cobertura
            //
            this.col_pol_cobertura.DataPropertyName = "TipoCobertura";
            this.col_pol_cobertura.FillWeight = 100F;
            this.col_pol_cobertura.HeaderText = "Cobertura";
            this.col_pol_cobertura.Name = "col_pol_cobertura";
            //
            // col_pol_inicio
            //
            this.col_pol_inicio.DataPropertyName = "FechaInicio";
            estiloInicio.Format = "dd/MM/yyyy";
            this.col_pol_inicio.DefaultCellStyle = estiloInicio;
            this.col_pol_inicio.FillWeight = 70F;
            this.col_pol_inicio.HeaderText = "Inicio";
            this.col_pol_inicio.Name = "col_pol_inicio";
            //
            // col_pol_vence
            //
            this.col_pol_vence.DataPropertyName = "FechaVencimiento";
            estiloVence.Format = "dd/MM/yyyy";
            this.col_pol_vence.DefaultCellStyle = estiloVence;
            this.col_pol_vence.FillWeight = 70F;
            this.col_pol_vence.HeaderText = "Vence";
            this.col_pol_vence.Name = "col_pol_vence";
            //
            // col_pol_estado
            //
            this.col_pol_estado.DataPropertyName = "Estado";
            this.col_pol_estado.FillWeight = 70F;
            this.col_pol_estado.HeaderText = "Estado";
            this.col_pol_estado.Name = "col_pol_estado";
            //
            // tab_pagos
            //
            this.tab_pagos.BackColor = System.Drawing.Color.White;
            this.tab_pagos.Controls.Add(this.dgv_pagos);
            this.tab_pagos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tab_pagos.Location = new System.Drawing.Point(4, 30);
            this.tab_pagos.Name = "tab_pagos";
            this.tab_pagos.Size = new System.Drawing.Size(964, 442);
            this.tab_pagos.Padding = new System.Windows.Forms.Padding(8);
            this.tab_pagos.Text = "Pagos";
            //
            // dgv_pagos
            //
            this.dgv_pagos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_pag_poliza,
            this.col_pag_cuota,
            this.col_pag_vence,
            this.col_pag_monto,
            this.col_pag_fecha,
            this.col_pag_metodo,
            this.col_pag_estado});
            this.dgv_pagos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_pagos.Name = "dgv_pagos";
            this.dgv_pagos.TabIndex = 0;
            this.dgv_pagos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grilla_CellFormatting);
            //
            // col_pag_poliza
            //
            this.col_pag_poliza.DataPropertyName = "NroPoliza";
            estiloPagoPoliza.Format = "000000";
            this.col_pag_poliza.DefaultCellStyle = estiloPagoPoliza;
            this.col_pag_poliza.FillWeight = 60F;
            this.col_pag_poliza.HeaderText = "Póliza";
            this.col_pag_poliza.Name = "col_pag_poliza";
            //
            // col_pag_cuota
            //
            this.col_pag_cuota.DataPropertyName = "Cuota";
            this.col_pag_cuota.FillWeight = 45F;
            this.col_pag_cuota.HeaderText = "Cuota";
            this.col_pag_cuota.Name = "col_pag_cuota";
            //
            // col_pag_vence
            //
            this.col_pag_vence.DataPropertyName = "FechaVencimiento";
            estiloPagoVence.Format = "dd/MM/yyyy";
            this.col_pag_vence.DefaultCellStyle = estiloPagoVence;
            this.col_pag_vence.FillWeight = 75F;
            this.col_pag_vence.HeaderText = "Vencimiento";
            this.col_pag_vence.Name = "col_pag_vence";
            //
            // col_pag_monto
            //
            this.col_pag_monto.DataPropertyName = "Monto";
            estiloPagoMonto.Format = "$ #,##0.00";
            this.col_pag_monto.DefaultCellStyle = estiloPagoMonto;
            this.col_pag_monto.FillWeight = 75F;
            this.col_pag_monto.HeaderText = "Monto";
            this.col_pag_monto.Name = "col_pag_monto";
            //
            // col_pag_fecha
            //
            this.col_pag_fecha.DataPropertyName = "FechaPago";
            estiloPagoFecha.Format = "dd/MM/yyyy";
            this.col_pag_fecha.DefaultCellStyle = estiloPagoFecha;
            this.col_pag_fecha.FillWeight = 75F;
            this.col_pag_fecha.HeaderText = "Fecha de pago";
            this.col_pag_fecha.Name = "col_pag_fecha";
            //
            // col_pag_metodo
            //
            this.col_pag_metodo.DataPropertyName = "MetodoPago";
            this.col_pag_metodo.FillWeight = 90F;
            this.col_pag_metodo.HeaderText = "Método";
            this.col_pag_metodo.Name = "col_pag_metodo";
            //
            // col_pag_estado
            //
            this.col_pag_estado.DataPropertyName = "Estado";
            this.col_pag_estado.FillWeight = 65F;
            this.col_pag_estado.HeaderText = "Estado";
            this.col_pag_estado.Name = "col_pag_estado";
            //
            // tab_siniestros
            //
            this.tab_siniestros.BackColor = System.Drawing.Color.White;
            this.tab_siniestros.Controls.Add(this.dgv_siniestros);
            this.tab_siniestros.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tab_siniestros.Location = new System.Drawing.Point(4, 30);
            this.tab_siniestros.Name = "tab_siniestros";
            this.tab_siniestros.Size = new System.Drawing.Size(964, 442);
            this.tab_siniestros.Padding = new System.Windows.Forms.Padding(8);
            this.tab_siniestros.Text = "Siniestros";
            //
            // dgv_siniestros
            //
            this.dgv_siniestros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_sin_expediente,
            this.col_sin_poliza,
            this.col_sin_fecha,
            this.col_sin_tipo,
            this.col_sin_monto,
            this.col_sin_estado});
            this.dgv_siniestros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_siniestros.Name = "dgv_siniestros";
            this.dgv_siniestros.TabIndex = 0;
            this.dgv_siniestros.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grilla_CellFormatting);
            //
            // col_sin_expediente
            //
            this.col_sin_expediente.DataPropertyName = "IdSiniestro";
            estiloExpediente.Format = "000000";
            this.col_sin_expediente.DefaultCellStyle = estiloExpediente;
            this.col_sin_expediente.FillWeight = 70F;
            this.col_sin_expediente.HeaderText = "Expediente";
            this.col_sin_expediente.Name = "col_sin_expediente";
            //
            // col_sin_poliza
            //
            this.col_sin_poliza.DataPropertyName = "NroPoliza";
            estiloSinPoliza.Format = "000000";
            this.col_sin_poliza.DefaultCellStyle = estiloSinPoliza;
            this.col_sin_poliza.FillWeight = 60F;
            this.col_sin_poliza.HeaderText = "Póliza";
            this.col_sin_poliza.Name = "col_sin_poliza";
            //
            // col_sin_fecha
            //
            this.col_sin_fecha.DataPropertyName = "FechaOcurrencia";
            estiloSinFecha.Format = "dd/MM/yyyy";
            this.col_sin_fecha.DefaultCellStyle = estiloSinFecha;
            this.col_sin_fecha.FillWeight = 75F;
            this.col_sin_fecha.HeaderText = "Fecha del hecho";
            this.col_sin_fecha.Name = "col_sin_fecha";
            //
            // col_sin_tipo
            //
            this.col_sin_tipo.DataPropertyName = "TipoSiniestro";
            this.col_sin_tipo.FillWeight = 90F;
            this.col_sin_tipo.HeaderText = "Tipo";
            this.col_sin_tipo.Name = "col_sin_tipo";
            //
            // col_sin_monto
            //
            this.col_sin_monto.DataPropertyName = "MontoReclamado";
            estiloSinMonto.Format = "$ #,##0.00";
            this.col_sin_monto.DefaultCellStyle = estiloSinMonto;
            this.col_sin_monto.FillWeight = 80F;
            this.col_sin_monto.HeaderText = "Monto reclamado";
            this.col_sin_monto.Name = "col_sin_monto";
            //
            // col_sin_estado
            //
            this.col_sin_estado.DataPropertyName = "Estado";
            this.col_sin_estado.FillWeight = 80F;
            this.col_sin_estado.HeaderText = "Estado";
            this.col_sin_estado.Name = "col_sin_estado";
            //
            // tab_historial
            //
            this.tab_historial.BackColor = System.Drawing.Color.White;
            this.tab_historial.Controls.Add(this.dgv_historial);
            this.tab_historial.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tab_historial.Location = new System.Drawing.Point(4, 30);
            this.tab_historial.Name = "tab_historial";
            this.tab_historial.Size = new System.Drawing.Size(964, 442);
            this.tab_historial.Padding = new System.Windows.Forms.Padding(8);
            this.tab_historial.Text = "Historial";
            //
            // dgv_historial
            //
            this.dgv_historial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_his_fecha,
            this.col_his_modulo,
            this.col_his_accion,
            this.col_his_detalle});
            this.dgv_historial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_historial.Name = "dgv_historial";
            this.dgv_historial.TabIndex = 0;
            //
            // col_his_fecha
            //
            this.col_his_fecha.DataPropertyName = "Fecha";
            estiloHistFecha.Format = "dd/MM/yyyy HH:mm";
            this.col_his_fecha.DefaultCellStyle = estiloHistFecha;
            this.col_his_fecha.FillWeight = 80F;
            this.col_his_fecha.HeaderText = "Fecha y hora";
            this.col_his_fecha.Name = "col_his_fecha";
            //
            // col_his_modulo
            //
            this.col_his_modulo.DataPropertyName = "Modulo";
            this.col_his_modulo.FillWeight = 70F;
            this.col_his_modulo.HeaderText = "Módulo";
            this.col_his_modulo.Name = "col_his_modulo";
            //
            // col_his_accion
            //
            this.col_his_accion.DataPropertyName = "Operacion";
            this.col_his_accion.FillWeight = 110F;
            this.col_his_accion.HeaderText = "Acción";
            this.col_his_accion.Name = "col_his_accion";
            //
            // col_his_detalle
            //
            this.col_his_detalle.DataPropertyName = "Detalle";
            this.col_his_detalle.FillWeight = 120F;
            this.col_his_detalle.HeaderText = "Detalle";
            this.col_his_detalle.Name = "col_his_detalle";
            //
            // DetalleCliente
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1020, 730);
            this.Controls.Add(this.tab_detalle);
            this.Controls.Add(this.pnl_cliente);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.lbl_titulo);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(56)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DetalleCliente";
            this.Text = "Detalle del cliente";
            this.Load += new System.EventHandler(this.DetalleCliente_Load);
            this.pnl_cliente.ResumeLayout(false);
            this.pnl_cliente.PerformLayout();
            this.tab_detalle.ResumeLayout(false);
            this.tab_vehiculos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vehiculos)).EndInit();
            this.pnl_vehiculo.ResumeLayout(false);
            this.pnl_vehiculo.PerformLayout();
            this.tab_polizas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_polizas)).EndInit();
            this.tab_pagos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pagos)).EndInit();
            this.tab_siniestros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_siniestros)).EndInit();
            this.tab_historial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_historial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.Panel pnl_cliente;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_estado;
        private System.Windows.Forms.Label lbl_datos1;
        private System.Windows.Forms.Label lbl_datos2;
        private System.Windows.Forms.Label lbl_datos3;
        private System.Windows.Forms.Panel pnl_separador;
        private System.Windows.Forms.Label lbl_observaciones;
        private System.Windows.Forms.TextBox txt_observaciones;
        private System.Windows.Forms.Button btn_guardar_obs;
        private System.Windows.Forms.TabControl tab_detalle;
        private System.Windows.Forms.TabPage tab_vehiculos;
        private System.Windows.Forms.DataGridView dgv_vehiculos;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_veh_dominio;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_veh_marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_veh_anio;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_veh_vtv;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_veh_estado;
        private System.Windows.Forms.Panel pnl_vehiculo;
        private System.Windows.Forms.Label lbl_vehiculo_titulo;
        private System.Windows.Forms.Label lbl_revision_titulo;
        private System.Windows.Forms.Label lbl_revision_valor;
        private System.Windows.Forms.Label lbl_revision_detalle;
        private System.Windows.Forms.Button btn_aprobar;
        private System.Windows.Forms.Button btn_rechazar;
        private System.Windows.Forms.TabPage tab_polizas;
        private System.Windows.Forms.DataGridView dgv_polizas;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_pol_nro;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_pol_aseguradora;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_pol_dominio;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_pol_cobertura;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_pol_inicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_pol_vence;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_pol_estado;
        private System.Windows.Forms.TabPage tab_pagos;
        private System.Windows.Forms.DataGridView dgv_pagos;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_pag_poliza;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_pag_cuota;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_pag_vence;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_pag_monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_pag_fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_pag_metodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_pag_estado;
        private System.Windows.Forms.TabPage tab_siniestros;
        private System.Windows.Forms.DataGridView dgv_siniestros;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_sin_expediente;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_sin_poliza;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_sin_fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_sin_tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_sin_monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_sin_estado;
        private System.Windows.Forms.TabPage tab_historial;
        private System.Windows.Forms.DataGridView dgv_historial;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_his_fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_his_modulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_his_accion;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_his_detalle;
    }
}
