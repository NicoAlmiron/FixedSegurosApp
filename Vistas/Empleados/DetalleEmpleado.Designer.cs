namespace FixedSegurosApp.Vistas
{
    partial class DetalleEmpleado
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
            System.Windows.Forms.DataGridViewCellStyle estilo1 = new System.Windows.Forms.DataGridViewCellStyle();
            estilo1.Format = "dd/MM/yyyy";
            System.Windows.Forms.DataGridViewCellStyle estilo2 = new System.Windows.Forms.DataGridViewCellStyle();
            estilo2.Format = "dd/MM/yyyy";
            System.Windows.Forms.DataGridViewCellStyle estilo3 = new System.Windows.Forms.DataGridViewCellStyle();
            estilo3.Format = "$ #,##0.00";
            System.Windows.Forms.DataGridViewCellStyle estilo4 = new System.Windows.Forms.DataGridViewCellStyle();
            estilo4.Format = "dd/MM/yyyy HH:mm";
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.btn_volver = new System.Windows.Forms.Button();
            this.pnl_empleado = new System.Windows.Forms.Panel();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_estado = new System.Windows.Forms.Label();
            this.lbl_datos1 = new System.Windows.Forms.Label();
            this.lbl_datos2 = new System.Windows.Forms.Label();
            this.lbl_datos3 = new System.Windows.Forms.Label();
            this.tab_detalle = new System.Windows.Forms.TabControl();
            this.tab_polizas = new System.Windows.Forms.TabPage();
            this.dgv_polizas = new System.Windows.Forms.DataGridView();
            this.col_pol_nro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_pol_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_pol_dominio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_pol_cobertura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_pol_vence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_pol_estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tab_siniestros = new System.Windows.Forms.TabPage();
            this.dgv_siniestros = new System.Windows.Forms.DataGridView();
            this.col_sin_expediente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_sin_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_sin_poliza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_sin_reclamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_sin_monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_sin_estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tab_historial = new System.Windows.Forms.TabPage();
            this.dgv_historial = new System.Windows.Forms.DataGridView();
            this.col_his_fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_his_modulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_his_accion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_his_detalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_empleado.SuspendLayout();
            this.tab_detalle.SuspendLayout();
            this.tab_polizas.SuspendLayout();
            this.tab_siniestros.SuspendLayout();
            this.tab_historial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_polizas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_siniestros)).BeginInit();
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
            this.lbl_titulo.Size = new System.Drawing.Size(340, 30);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Empleados › Detalle del empleado";
            //
            // btn_volver
            //
            this.btn_volver.Location = new System.Drawing.Point(826, 20);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(170, 32);
            this.btn_volver.TabIndex = 1;
            this.btn_volver.Text = "Volver a Empleados";
            this.btn_volver.UseVisualStyleBackColor = false;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            //
            // pnl_empleado
            //
            this.pnl_empleado.Controls.Add(this.lbl_nombre);
            this.pnl_empleado.Controls.Add(this.lbl_estado);
            this.pnl_empleado.Controls.Add(this.lbl_datos1);
            this.pnl_empleado.Controls.Add(this.lbl_datos2);
            this.pnl_empleado.Controls.Add(this.lbl_datos3);
            this.pnl_empleado.Location = new System.Drawing.Point(24, 66);
            this.pnl_empleado.Name = "pnl_empleado";
            this.pnl_empleado.Size = new System.Drawing.Size(972, 122);
            this.pnl_empleado.TabIndex = 2;
            //
            // lbl_nombre
            //
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Segoe UI Semibold", 14F);
            this.lbl_nombre.Location = new System.Drawing.Point(18, 10);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(133, 25);
            this.lbl_nombre.Text = "Empleado";
            //
            // lbl_estado
            //
            this.lbl_estado.AutoSize = true;
            this.lbl_estado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(79)))));
            this.lbl_estado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_estado.ForeColor = System.Drawing.Color.White;
            this.lbl_estado.Location = new System.Drawing.Point(260, 15);
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Padding = new System.Windows.Forms.Padding(6, 2, 6, 2);
            this.lbl_estado.Size = new System.Drawing.Size(58, 19);
            this.lbl_estado.Text = "Estado";
            //
            // lbl_datos1
            //
            this.lbl_datos1.AutoSize = true;
            this.lbl_datos1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_datos1.Location = new System.Drawing.Point(20, 44);
            this.lbl_datos1.Name = "lbl_datos1";
            this.lbl_datos1.Size = new System.Drawing.Size(100, 15);
            this.lbl_datos1.Text = "-";
            //
            // lbl_datos2
            //
            this.lbl_datos2.AutoSize = true;
            this.lbl_datos2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_datos2.Location = new System.Drawing.Point(20, 68);
            this.lbl_datos2.Name = "lbl_datos2";
            this.lbl_datos2.Size = new System.Drawing.Size(100, 15);
            this.lbl_datos2.Text = "-";
            //
            // lbl_datos3
            //
            this.lbl_datos3.AutoSize = true;
            this.lbl_datos3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_datos3.Location = new System.Drawing.Point(20, 92);
            this.lbl_datos3.Name = "lbl_datos3";
            this.lbl_datos3.Size = new System.Drawing.Size(100, 15);
            this.lbl_datos3.Text = "-";
            //
            // tab_detalle
            //
            this.tab_detalle.Controls.Add(this.tab_polizas);
            this.tab_detalle.Controls.Add(this.tab_siniestros);
            this.tab_detalle.Controls.Add(this.tab_historial);
            this.tab_detalle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tab_detalle.Location = new System.Drawing.Point(24, 198);
            this.tab_detalle.Name = "tab_detalle";
            this.tab_detalle.Padding = new System.Drawing.Point(14, 5);
            this.tab_detalle.SelectedIndex = 0;
            this.tab_detalle.Size = new System.Drawing.Size(972, 428);
            this.tab_detalle.TabIndex = 3;
            //
            // tab_polizas
            //
            this.tab_polizas.BackColor = System.Drawing.Color.White;
            this.tab_polizas.Controls.Add(this.dgv_polizas);
            this.tab_polizas.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tab_polizas.Location = new System.Drawing.Point(4, 30);
            this.tab_polizas.Name = "tab_polizas";
            this.tab_polizas.Padding = new System.Windows.Forms.Padding(8);
            this.tab_polizas.Size = new System.Drawing.Size(964, 394);
            this.tab_polizas.Text = "Pólizas";
            //
            // dgv_polizas
            //
            this.dgv_polizas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.col_pol_nro, this.col_pol_cliente, this.col_pol_dominio, this.col_pol_cobertura, this.col_pol_vence, this.col_pol_estado });
            this.dgv_polizas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_polizas.Name = "dgv_polizas";
            this.dgv_polizas.TabIndex = 0;
            this.dgv_polizas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grilla_CellFormatting);
            this.dgv_polizas.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.grilla_DataBindingComplete);
            //
            // col_pol_nro
            //
            this.col_pol_nro.DataPropertyName = "NroTexto";
            this.col_pol_nro.FillWeight = 60F;
            this.col_pol_nro.HeaderText = "N°";
            this.col_pol_nro.Name = "col_pol_nro";
            //
            // col_pol_cliente
            //
            this.col_pol_cliente.DataPropertyName = "ClienteTexto";
            this.col_pol_cliente.FillWeight = 120F;
            this.col_pol_cliente.HeaderText = "Cliente";
            this.col_pol_cliente.Name = "col_pol_cliente";
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
            // col_pol_vence
            //
            this.col_pol_vence.DataPropertyName = "FechaVencimiento";
            this.col_pol_vence.DefaultCellStyle = estilo1;
            this.col_pol_vence.FillWeight = 70F;
            this.col_pol_vence.HeaderText = "Vence";
            this.col_pol_vence.Name = "col_pol_vence";
            //
            // col_pol_estado
            //
            this.col_pol_estado.DataPropertyName = "EstadoMostrado";
            this.col_pol_estado.FillWeight = 70F;
            this.col_pol_estado.HeaderText = "Estado";
            this.col_pol_estado.Name = "col_pol_estado";
            //
            // tab_siniestros
            //
            this.tab_siniestros.BackColor = System.Drawing.Color.White;
            this.tab_siniestros.Controls.Add(this.dgv_siniestros);
            this.tab_siniestros.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tab_siniestros.Location = new System.Drawing.Point(4, 30);
            this.tab_siniestros.Name = "tab_siniestros";
            this.tab_siniestros.Padding = new System.Windows.Forms.Padding(8);
            this.tab_siniestros.Size = new System.Drawing.Size(964, 394);
            this.tab_siniestros.Text = "Siniestros";
            //
            // dgv_siniestros
            //
            this.dgv_siniestros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.col_sin_expediente, this.col_sin_cliente, this.col_sin_poliza, this.col_sin_reclamo, this.col_sin_monto, this.col_sin_estado });
            this.dgv_siniestros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_siniestros.Name = "dgv_siniestros";
            this.dgv_siniestros.TabIndex = 0;
            this.dgv_siniestros.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grilla_CellFormatting);
            this.dgv_siniestros.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.grilla_DataBindingComplete);
            //
            // col_sin_expediente
            //
            this.col_sin_expediente.DataPropertyName = "ExpedienteTexto";
            this.col_sin_expediente.FillWeight = 70F;
            this.col_sin_expediente.HeaderText = "Expediente";
            this.col_sin_expediente.Name = "col_sin_expediente";
            //
            // col_sin_cliente
            //
            this.col_sin_cliente.DataPropertyName = "Cliente";
            this.col_sin_cliente.FillWeight = 120F;
            this.col_sin_cliente.HeaderText = "Cliente";
            this.col_sin_cliente.Name = "col_sin_cliente";
            //
            // col_sin_poliza
            //
            this.col_sin_poliza.DataPropertyName = "PolizaTexto";
            this.col_sin_poliza.FillWeight = 60F;
            this.col_sin_poliza.HeaderText = "Póliza";
            this.col_sin_poliza.Name = "col_sin_poliza";
            //
            // col_sin_reclamo
            //
            this.col_sin_reclamo.DataPropertyName = "FechaRegistro";
            this.col_sin_reclamo.DefaultCellStyle = estilo2;
            this.col_sin_reclamo.FillWeight = 70F;
            this.col_sin_reclamo.HeaderText = "Reclamo";
            this.col_sin_reclamo.Name = "col_sin_reclamo";
            //
            // col_sin_monto
            //
            this.col_sin_monto.DataPropertyName = "MontoReclamado";
            this.col_sin_monto.DefaultCellStyle = estilo3;
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
            this.tab_historial.Padding = new System.Windows.Forms.Padding(8);
            this.tab_historial.Size = new System.Drawing.Size(964, 394);
            this.tab_historial.Text = "Historial";
            //
            // dgv_historial
            //
            this.dgv_historial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.col_his_fecha, this.col_his_modulo, this.col_his_accion, this.col_his_detalle });
            this.dgv_historial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_historial.Name = "dgv_historial";
            this.dgv_historial.TabIndex = 0;
            this.dgv_historial.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grilla_CellFormatting);
            this.dgv_historial.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.grilla_DataBindingComplete);
            //
            // col_his_fecha
            //
            this.col_his_fecha.DataPropertyName = "Fecha";
            this.col_his_fecha.DefaultCellStyle = estilo4;
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
            // DetalleEmpleado
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1020, 650);
            this.Controls.Add(this.tab_detalle);
            this.Controls.Add(this.pnl_empleado);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.lbl_titulo);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(56)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DetalleEmpleado";
            this.Text = "Detalle del empleado";
            this.Load += new System.EventHandler(this.DetalleEmpleado_Load);
            this.pnl_empleado.ResumeLayout(false);
            this.pnl_empleado.PerformLayout();
            this.tab_detalle.ResumeLayout(false);
            this.tab_polizas.ResumeLayout(false);
            this.tab_siniestros.ResumeLayout(false);
            this.tab_historial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_polizas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_siniestros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_historial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.Panel pnl_empleado;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_estado;
        private System.Windows.Forms.Label lbl_datos1;
        private System.Windows.Forms.Label lbl_datos2;
        private System.Windows.Forms.Label lbl_datos3;
        private System.Windows.Forms.TabControl tab_detalle;
        private System.Windows.Forms.TabPage tab_polizas;
        private System.Windows.Forms.DataGridView dgv_polizas;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_pol_nro;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_pol_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_pol_dominio;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_pol_cobertura;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_pol_vence;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_pol_estado;
        private System.Windows.Forms.TabPage tab_siniestros;
        private System.Windows.Forms.DataGridView dgv_siniestros;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_sin_expediente;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_sin_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_sin_poliza;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_sin_reclamo;
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
