namespace FixedSegurosApp.Vistas
{
    partial class Comisiones
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
            System.Windows.Forms.DataGridViewCellStyle estiloPoliza = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle estiloFecha = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle estiloMonto = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle estiloPorcentaje = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle estiloComision = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle estiloCalculado = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle estiloCobrado = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle estiloGanado = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.btn_volver = new System.Windows.Forms.Button();
            this.pnl_filtros = new System.Windows.Forms.Panel();
            this.lbl_desde = new System.Windows.Forms.Label();
            this.dtp_desde = new System.Windows.Forms.DateTimePicker();
            this.lbl_hasta = new System.Windows.Forms.Label();
            this.dtp_hasta = new System.Windows.Forms.DateTimePicker();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.lbl_total = new System.Windows.Forms.Label();
            this.pnl_cuotas = new System.Windows.Forms.Panel();
            this.lbl_cuotas_titulo = new System.Windows.Forms.Label();
            this.dgv_cuotas = new System.Windows.Forms.DataGridView();
            this.col_poliza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_aseguradora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_cuota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_fecha_pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_porcentaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_comision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_liquidacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_arqueos = new System.Windows.Forms.Panel();
            this.lbl_arqueos_titulo = new System.Windows.Forms.Label();
            this.dgv_arqueos = new System.Windows.Forms.DataGridView();
            this.col_arq_nro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_arq_periodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_arq_fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_arq_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_arq_cobrado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_arq_comision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_filtros.SuspendLayout();
            this.pnl_cuotas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cuotas)).BeginInit();
            this.pnl_arqueos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_arqueos)).BeginInit();
            this.SuspendLayout();
            //
            // lbl_titulo
            //
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Segoe UI Semibold", 16F);
            this.lbl_titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(58)))), ((int)(((byte)(92)))));
            this.lbl_titulo.Location = new System.Drawing.Point(20, 20);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(215, 30);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Pólizas › Comisiones";
            //
            // btn_volver
            //
            this.btn_volver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_volver.Location = new System.Drawing.Point(836, 20);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(160, 32);
            this.btn_volver.TabIndex = 4;
            this.btn_volver.Text = "Volver a Pólizas";
            this.btn_volver.UseVisualStyleBackColor = false;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            //
            // pnl_filtros
            //
            this.pnl_filtros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_filtros.Controls.Add(this.lbl_desde);
            this.pnl_filtros.Controls.Add(this.dtp_desde);
            this.pnl_filtros.Controls.Add(this.lbl_hasta);
            this.pnl_filtros.Controls.Add(this.dtp_hasta);
            this.pnl_filtros.Controls.Add(this.btn_calcular);
            this.pnl_filtros.Controls.Add(this.btn_guardar);
            this.pnl_filtros.Controls.Add(this.lbl_total);
            this.pnl_filtros.Location = new System.Drawing.Point(24, 66);
            this.pnl_filtros.Name = "pnl_filtros";
            this.pnl_filtros.Size = new System.Drawing.Size(972, 72);
            this.pnl_filtros.TabIndex = 1;
            //
            // lbl_desde
            //
            this.lbl_desde.AutoSize = true;
            this.lbl_desde.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_desde.Location = new System.Drawing.Point(16, 12);
            this.lbl_desde.Name = "lbl_desde";
            this.lbl_desde.Size = new System.Drawing.Size(70, 15);
            this.lbl_desde.Text = "Desde (mes)";
            //
            // dtp_desde
            //
            this.dtp_desde.CustomFormat = "MM/yyyy";
            this.dtp_desde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_desde.Location = new System.Drawing.Point(16, 32);
            this.dtp_desde.Name = "dtp_desde";
            this.dtp_desde.ShowUpDown = true;
            this.dtp_desde.Size = new System.Drawing.Size(110, 23);
            this.dtp_desde.TabIndex = 0;
            //
            // lbl_hasta
            //
            this.lbl_hasta.AutoSize = true;
            this.lbl_hasta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_hasta.Location = new System.Drawing.Point(140, 12);
            this.lbl_hasta.Name = "lbl_hasta";
            this.lbl_hasta.Size = new System.Drawing.Size(68, 15);
            this.lbl_hasta.Text = "Hasta (mes)";
            //
            // dtp_hasta
            //
            this.dtp_hasta.CustomFormat = "MM/yyyy";
            this.dtp_hasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_hasta.Location = new System.Drawing.Point(140, 32);
            this.dtp_hasta.Name = "dtp_hasta";
            this.dtp_hasta.ShowUpDown = true;
            this.dtp_hasta.Size = new System.Drawing.Size(110, 23);
            this.dtp_hasta.TabIndex = 1;
            //
            // btn_calcular
            //
            this.btn_calcular.Location = new System.Drawing.Point(266, 26);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(100, 32);
            this.btn_calcular.TabIndex = 2;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = false;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            //
            // btn_guardar
            //
            this.btn_guardar.Location = new System.Drawing.Point(374, 26);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(130, 32);
            this.btn_guardar.TabIndex = 3;
            this.btn_guardar.Text = "Guardar arqueo";
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            //
            // lbl_total
            //
            this.lbl_total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_total.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_total.Location = new System.Drawing.Point(620, 16);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(336, 42);
            this.lbl_total.Text = "Cobrado sin liquidar: $ 0,00";
            this.lbl_total.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // pnl_cuotas
            //
            this.pnl_cuotas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_cuotas.Controls.Add(this.lbl_cuotas_titulo);
            this.pnl_cuotas.Controls.Add(this.dgv_cuotas);
            this.pnl_cuotas.Location = new System.Drawing.Point(24, 150);
            this.pnl_cuotas.Name = "pnl_cuotas";
            this.pnl_cuotas.Size = new System.Drawing.Size(972, 344);
            this.pnl_cuotas.TabIndex = 2;
            //
            // lbl_cuotas_titulo
            //
            this.lbl_cuotas_titulo.AutoSize = true;
            this.lbl_cuotas_titulo.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.lbl_cuotas_titulo.Location = new System.Drawing.Point(14, 10);
            this.lbl_cuotas_titulo.Name = "lbl_cuotas_titulo";
            this.lbl_cuotas_titulo.Size = new System.Drawing.Size(121, 20);
            this.lbl_cuotas_titulo.Text = "Cuotas cobradas";
            //
            // dgv_cuotas
            //
            this.dgv_cuotas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_cuotas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_poliza,
            this.col_cliente,
            this.col_aseguradora,
            this.col_cuota,
            this.col_fecha_pago,
            this.col_monto,
            this.col_porcentaje,
            this.col_comision,
            this.col_liquidacion});
            this.dgv_cuotas.Location = new System.Drawing.Point(1, 38);
            this.dgv_cuotas.Name = "dgv_cuotas";
            this.dgv_cuotas.Size = new System.Drawing.Size(970, 305);
            this.dgv_cuotas.TabIndex = 0;
            this.dgv_cuotas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_cuotas_CellFormatting);
            //
            // col_poliza
            //
            this.col_poliza.DataPropertyName = "NroPoliza";
            estiloPoliza.Format = "000000";
            this.col_poliza.DefaultCellStyle = estiloPoliza;
            this.col_poliza.FillWeight = 65F;
            this.col_poliza.HeaderText = "N° póliza";
            this.col_poliza.Name = "col_poliza";
            //
            // col_cliente
            //
            this.col_cliente.DataPropertyName = "Cliente";
            this.col_cliente.FillWeight = 120F;
            this.col_cliente.HeaderText = "Cliente";
            this.col_cliente.Name = "col_cliente";
            //
            // col_aseguradora
            //
            this.col_aseguradora.DataPropertyName = "Aseguradora";
            this.col_aseguradora.FillWeight = 105F;
            this.col_aseguradora.HeaderText = "Aseguradora";
            this.col_aseguradora.Name = "col_aseguradora";
            //
            // col_cuota
            //
            this.col_cuota.DataPropertyName = "Cuota";
            this.col_cuota.FillWeight = 50F;
            this.col_cuota.HeaderText = "Cuota";
            this.col_cuota.Name = "col_cuota";
            //
            // col_fecha_pago
            //
            this.col_fecha_pago.DataPropertyName = "FechaPago";
            estiloFecha.Format = "dd/MM/yyyy";
            this.col_fecha_pago.DefaultCellStyle = estiloFecha;
            this.col_fecha_pago.FillWeight = 80F;
            this.col_fecha_pago.HeaderText = "Fecha de pago";
            this.col_fecha_pago.Name = "col_fecha_pago";
            //
            // col_monto
            //
            this.col_monto.DataPropertyName = "Monto";
            estiloMonto.Format = "\'$ \'#,##0.00";
            this.col_monto.DefaultCellStyle = estiloMonto;
            this.col_monto.FillWeight = 85F;
            this.col_monto.HeaderText = "Cobrado";
            this.col_monto.Name = "col_monto";
            //
            // col_porcentaje
            //
            this.col_porcentaje.DataPropertyName = "PorcentajeComision";
            estiloPorcentaje.Format = "0.##\' %\'";
            this.col_porcentaje.DefaultCellStyle = estiloPorcentaje;
            this.col_porcentaje.FillWeight = 50F;
            this.col_porcentaje.HeaderText = "%";
            this.col_porcentaje.Name = "col_porcentaje";
            //
            // col_comision
            //
            this.col_comision.DataPropertyName = "Comision";
            estiloComision.Format = "\'$ \'#,##0.00";
            this.col_comision.DefaultCellStyle = estiloComision;
            this.col_comision.FillWeight = 85F;
            this.col_comision.HeaderText = "Comisión";
            this.col_comision.Name = "col_comision";
            //
            // col_liquidacion
            //
            this.col_liquidacion.DataPropertyName = "Liquidacion";
            this.col_liquidacion.FillWeight = 90F;
            this.col_liquidacion.HeaderText = "Liquidación";
            this.col_liquidacion.Name = "col_liquidacion";
            //
            // pnl_arqueos
            //
            this.pnl_arqueos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_arqueos.Controls.Add(this.lbl_arqueos_titulo);
            this.pnl_arqueos.Controls.Add(this.dgv_arqueos);
            this.pnl_arqueos.Location = new System.Drawing.Point(24, 506);
            this.pnl_arqueos.Name = "pnl_arqueos";
            this.pnl_arqueos.Size = new System.Drawing.Size(972, 200);
            this.pnl_arqueos.TabIndex = 3;
            //
            // lbl_arqueos_titulo
            //
            this.lbl_arqueos_titulo.AutoSize = true;
            this.lbl_arqueos_titulo.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.lbl_arqueos_titulo.Location = new System.Drawing.Point(14, 10);
            this.lbl_arqueos_titulo.Name = "lbl_arqueos_titulo";
            this.lbl_arqueos_titulo.Size = new System.Drawing.Size(307, 20);
            this.lbl_arqueos_titulo.Text = "Arqueos guardados (clic para ver sus cuotas)";
            //
            // dgv_arqueos
            //
            this.dgv_arqueos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_arqueos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_arq_nro,
            this.col_arq_periodo,
            this.col_arq_fecha,
            this.col_arq_usuario,
            this.col_arq_cobrado,
            this.col_arq_comision});
            this.dgv_arqueos.Location = new System.Drawing.Point(1, 38);
            this.dgv_arqueos.Name = "dgv_arqueos";
            this.dgv_arqueos.Size = new System.Drawing.Size(970, 161);
            this.dgv_arqueos.TabIndex = 0;
            this.dgv_arqueos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_arqueos_CellClick);
            this.dgv_arqueos.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgv_arqueos_DataBindingComplete);
            //
            // col_arq_nro
            //
            this.col_arq_nro.DataPropertyName = "NroTexto";
            this.col_arq_nro.FillWeight = 60F;
            this.col_arq_nro.HeaderText = "Arqueo";
            this.col_arq_nro.Name = "col_arq_nro";
            //
            // col_arq_periodo
            //
            this.col_arq_periodo.DataPropertyName = "Periodo";
            this.col_arq_periodo.FillWeight = 100F;
            this.col_arq_periodo.HeaderText = "Período";
            this.col_arq_periodo.Name = "col_arq_periodo";
            //
            // col_arq_fecha
            //
            this.col_arq_fecha.DataPropertyName = "FechaCalculo";
            estiloCalculado.Format = "dd/MM/yyyy HH:mm";
            this.col_arq_fecha.DefaultCellStyle = estiloCalculado;
            this.col_arq_fecha.FillWeight = 100F;
            this.col_arq_fecha.HeaderText = "Calculado el";
            this.col_arq_fecha.Name = "col_arq_fecha";
            //
            // col_arq_usuario
            //
            this.col_arq_usuario.DataPropertyName = "Usuario";
            this.col_arq_usuario.FillWeight = 110F;
            this.col_arq_usuario.HeaderText = "Usuario";
            this.col_arq_usuario.Name = "col_arq_usuario";
            //
            // col_arq_cobrado
            //
            this.col_arq_cobrado.DataPropertyName = "TotalCobrado";
            estiloCobrado.Format = "\'$ \'#,##0.00";
            this.col_arq_cobrado.DefaultCellStyle = estiloCobrado;
            this.col_arq_cobrado.FillWeight = 90F;
            this.col_arq_cobrado.HeaderText = "Cobrado";
            this.col_arq_cobrado.Name = "col_arq_cobrado";
            //
            // col_arq_comision
            //
            this.col_arq_comision.DataPropertyName = "TotalComision";
            estiloGanado.Format = "\'$ \'#,##0.00";
            this.col_arq_comision.DefaultCellStyle = estiloGanado;
            this.col_arq_comision.FillWeight = 90F;
            this.col_arq_comision.HeaderText = "Comisión";
            this.col_arq_comision.Name = "col_arq_comision";
            //
            // Comisiones
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1020, 730);
            this.Controls.Add(this.pnl_arqueos);
            this.Controls.Add(this.pnl_cuotas);
            this.Controls.Add(this.pnl_filtros);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.lbl_titulo);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(56)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Comisiones";
            this.Text = "Comisiones";
            this.Load += new System.EventHandler(this.Comisiones_Load);
            this.pnl_filtros.ResumeLayout(false);
            this.pnl_filtros.PerformLayout();
            this.pnl_cuotas.ResumeLayout(false);
            this.pnl_cuotas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cuotas)).EndInit();
            this.pnl_arqueos.ResumeLayout(false);
            this.pnl_arqueos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_arqueos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.Panel pnl_filtros;
        private System.Windows.Forms.Label lbl_desde;
        private System.Windows.Forms.DateTimePicker dtp_desde;
        private System.Windows.Forms.Label lbl_hasta;
        private System.Windows.Forms.DateTimePicker dtp_hasta;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Panel pnl_cuotas;
        private System.Windows.Forms.Label lbl_cuotas_titulo;
        private System.Windows.Forms.DataGridView dgv_cuotas;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_poliza;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_aseguradora;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cuota;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_fecha_pago;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_porcentaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_comision;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_liquidacion;
        private System.Windows.Forms.Panel pnl_arqueos;
        private System.Windows.Forms.Label lbl_arqueos_titulo;
        private System.Windows.Forms.DataGridView dgv_arqueos;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_arq_nro;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_arq_periodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_arq_fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_arq_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_arq_cobrado;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_arq_comision;
    }
}
