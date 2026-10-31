namespace FixedSegurosApp.Vistas
{
    partial class Reportes
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
            this.lbl_desde = new System.Windows.Forms.Label();
            this.dtp_desde = new System.Windows.Forms.DateTimePicker();
            this.lbl_hasta = new System.Windows.Forms.Label();
            this.dtp_hasta = new System.Windows.Forms.DateTimePicker();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.btn_csv = new System.Windows.Forms.Button();
            this.btn_pdf = new System.Windows.Forms.Button();
            this.tab_secciones = new System.Windows.Forms.TabControl();
            this.tab_general = new System.Windows.Forms.TabPage();
            this.tab_polizas = new System.Windows.Forms.TabPage();
            this.tab_cobranzas = new System.Windows.Forms.TabPage();
            this.tab_siniestros = new System.Windows.Forms.TabPage();
            this.tab_clientes = new System.Windows.Forms.TabPage();
            this.tab_personal = new System.Windows.Forms.TabPage();
            this.pnl_tarjeta1 = new System.Windows.Forms.Panel();
            this.lbl_titulo1 = new System.Windows.Forms.Label();
            this.lbl_valor1 = new System.Windows.Forms.Label();
            this.lbl_detalle1 = new System.Windows.Forms.Label();
            this.pnl_tarjeta2 = new System.Windows.Forms.Panel();
            this.lbl_titulo2 = new System.Windows.Forms.Label();
            this.lbl_valor2 = new System.Windows.Forms.Label();
            this.lbl_detalle2 = new System.Windows.Forms.Label();
            this.pnl_tarjeta3 = new System.Windows.Forms.Panel();
            this.lbl_titulo3 = new System.Windows.Forms.Label();
            this.lbl_valor3 = new System.Windows.Forms.Label();
            this.lbl_detalle3 = new System.Windows.Forms.Label();
            this.pnl_tarjeta4 = new System.Windows.Forms.Panel();
            this.lbl_titulo4 = new System.Windows.Forms.Label();
            this.lbl_valor4 = new System.Windows.Forms.Label();
            this.lbl_detalle4 = new System.Windows.Forms.Label();
            this.chart_1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgv_datos = new System.Windows.Forms.DataGridView();
            this.col_grupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_detalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_nota = new System.Windows.Forms.Label();
            this.tab_secciones.SuspendLayout();
            this.pnl_tarjeta1.SuspendLayout();
            this.pnl_tarjeta2.SuspendLayout();
            this.pnl_tarjeta3.SuspendLayout();
            this.pnl_tarjeta4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datos)).BeginInit();
            this.SuspendLayout();
            //
            // lbl_titulo
            //
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Segoe UI Semibold", 16F);
            this.lbl_titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(58)))), ((int)(((byte)(92)))));
            this.lbl_titulo.Location = new System.Drawing.Point(20, 20);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(95, 30);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Reportes";
            //
            // lbl_desde
            //
            this.lbl_desde.AutoSize = true;
            this.lbl_desde.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_desde.Location = new System.Drawing.Point(316, 28);
            this.lbl_desde.Name = "lbl_desde";
            this.lbl_desde.Size = new System.Drawing.Size(39, 15);
            this.lbl_desde.Text = "Desde";
            //
            // dtp_desde
            //
            this.dtp_desde.CustomFormat = "dd/MM/yyyy";
            this.dtp_desde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_desde.Location = new System.Drawing.Point(360, 24);
            this.dtp_desde.Name = "dtp_desde";
            this.dtp_desde.Size = new System.Drawing.Size(110, 23);
            this.dtp_desde.TabIndex = 1;
            //
            // lbl_hasta
            //
            this.lbl_hasta.AutoSize = true;
            this.lbl_hasta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_hasta.Location = new System.Drawing.Point(480, 28);
            this.lbl_hasta.Name = "lbl_hasta";
            this.lbl_hasta.Size = new System.Drawing.Size(37, 15);
            this.lbl_hasta.Text = "Hasta";
            //
            // dtp_hasta
            //
            this.dtp_hasta.CustomFormat = "dd/MM/yyyy";
            this.dtp_hasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_hasta.Location = new System.Drawing.Point(522, 24);
            this.dtp_hasta.Name = "dtp_hasta";
            this.dtp_hasta.Size = new System.Drawing.Size(110, 23);
            this.dtp_hasta.TabIndex = 2;
            //
            // btn_consultar
            //
            this.btn_consultar.Location = new System.Drawing.Point(640, 20);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(96, 32);
            this.btn_consultar.TabIndex = 3;
            this.btn_consultar.Text = "Consultar";
            this.btn_consultar.UseVisualStyleBackColor = false;
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            //
            // btn_csv
            //
            this.btn_csv.Location = new System.Drawing.Point(744, 20);
            this.btn_csv.Name = "btn_csv";
            this.btn_csv.Size = new System.Drawing.Size(122, 32);
            this.btn_csv.TabIndex = 4;
            this.btn_csv.Text = "Exportar CSV";
            this.btn_csv.UseVisualStyleBackColor = false;
            this.btn_csv.Click += new System.EventHandler(this.btn_csv_Click);
            //
            // btn_pdf
            //
            this.btn_pdf.Location = new System.Drawing.Point(874, 20);
            this.btn_pdf.Name = "btn_pdf";
            this.btn_pdf.Size = new System.Drawing.Size(122, 32);
            this.btn_pdf.TabIndex = 5;
            this.btn_pdf.Text = "Exportar PDF";
            this.btn_pdf.UseVisualStyleBackColor = false;
            this.btn_pdf.Click += new System.EventHandler(this.btn_pdf_Click);
            //
            // tab_secciones
            //
            this.tab_secciones.Controls.Add(this.tab_general);
            this.tab_secciones.Controls.Add(this.tab_polizas);
            this.tab_secciones.Controls.Add(this.tab_cobranzas);
            this.tab_secciones.Controls.Add(this.tab_siniestros);
            this.tab_secciones.Controls.Add(this.tab_clientes);
            this.tab_secciones.Controls.Add(this.tab_personal);
            this.tab_secciones.Location = new System.Drawing.Point(24, 62);
            this.tab_secciones.Name = "tab_secciones";
            this.tab_secciones.SelectedIndex = 0;
            this.tab_secciones.Size = new System.Drawing.Size(972, 28);
            this.tab_secciones.TabIndex = 6;
            this.tab_secciones.SelectedIndexChanged += new System.EventHandler(this.tab_secciones_SelectedIndexChanged);
            //
            // tab_general
            //
            this.tab_general.Location = new System.Drawing.Point(4, 24);
            this.tab_general.Name = "tab_general";
            this.tab_general.Size = new System.Drawing.Size(964, 0);
            this.tab_general.Text = "General";
            //
            // tab_polizas
            //
            this.tab_polizas.Location = new System.Drawing.Point(4, 24);
            this.tab_polizas.Name = "tab_polizas";
            this.tab_polizas.Size = new System.Drawing.Size(964, 0);
            this.tab_polizas.Text = "Pólizas";
            //
            // tab_cobranzas
            //
            this.tab_cobranzas.Location = new System.Drawing.Point(4, 24);
            this.tab_cobranzas.Name = "tab_cobranzas";
            this.tab_cobranzas.Size = new System.Drawing.Size(964, 0);
            this.tab_cobranzas.Text = "Cobranzas";
            //
            // tab_siniestros
            //
            this.tab_siniestros.Location = new System.Drawing.Point(4, 24);
            this.tab_siniestros.Name = "tab_siniestros";
            this.tab_siniestros.Size = new System.Drawing.Size(964, 0);
            this.tab_siniestros.Text = "Siniestros";
            //
            // tab_clientes
            //
            this.tab_clientes.Location = new System.Drawing.Point(4, 24);
            this.tab_clientes.Name = "tab_clientes";
            this.tab_clientes.Size = new System.Drawing.Size(964, 0);
            this.tab_clientes.Text = "Clientes y vehículos";
            //
            // tab_personal
            //
            this.tab_personal.Location = new System.Drawing.Point(4, 24);
            this.tab_personal.Name = "tab_personal";
            this.tab_personal.Size = new System.Drawing.Size(964, 0);
            this.tab_personal.Text = "Personal";
            //
            // pnl_tarjeta1
            //
            this.pnl_tarjeta1.Controls.Add(this.lbl_titulo1);
            this.pnl_tarjeta1.Controls.Add(this.lbl_valor1);
            this.pnl_tarjeta1.Controls.Add(this.lbl_detalle1);
            this.pnl_tarjeta1.Location = new System.Drawing.Point(24, 96);
            this.pnl_tarjeta1.Name = "pnl_tarjeta1";
            this.pnl_tarjeta1.Size = new System.Drawing.Size(234, 84);
            this.pnl_tarjeta1.TabIndex = 7;
            //
            // lbl_titulo1
            //
            this.lbl_titulo1.AutoSize = true;
            this.lbl_titulo1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_titulo1.Location = new System.Drawing.Point(12, 8);
            this.lbl_titulo1.Name = "lbl_titulo1";
            this.lbl_titulo1.Size = new System.Drawing.Size(120, 15);
            this.lbl_titulo1.Text = "Título";
            //
            // lbl_valor1
            //
            this.lbl_valor1.AutoSize = true;
            this.lbl_valor1.Font = new System.Drawing.Font("Segoe UI Semibold", 16F);
            this.lbl_valor1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(58)))), ((int)(((byte)(92)))));
            this.lbl_valor1.Location = new System.Drawing.Point(10, 25);
            this.lbl_valor1.Name = "lbl_valor1";
            this.lbl_valor1.Size = new System.Drawing.Size(26, 30);
            this.lbl_valor1.Text = "0";
            //
            // lbl_detalle1
            //
            this.lbl_detalle1.AutoSize = true;
            this.lbl_detalle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_detalle1.Location = new System.Drawing.Point(12, 60);
            this.lbl_detalle1.Name = "lbl_detalle1";
            this.lbl_detalle1.Size = new System.Drawing.Size(90, 15);
            this.lbl_detalle1.Text = "Detalle";
            //
            // pnl_tarjeta2
            //
            this.pnl_tarjeta2.Controls.Add(this.lbl_titulo2);
            this.pnl_tarjeta2.Controls.Add(this.lbl_valor2);
            this.pnl_tarjeta2.Controls.Add(this.lbl_detalle2);
            this.pnl_tarjeta2.Location = new System.Drawing.Point(270, 96);
            this.pnl_tarjeta2.Name = "pnl_tarjeta2";
            this.pnl_tarjeta2.Size = new System.Drawing.Size(234, 84);
            this.pnl_tarjeta2.TabIndex = 8;
            //
            // lbl_titulo2
            //
            this.lbl_titulo2.AutoSize = true;
            this.lbl_titulo2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_titulo2.Location = new System.Drawing.Point(12, 8);
            this.lbl_titulo2.Name = "lbl_titulo2";
            this.lbl_titulo2.Size = new System.Drawing.Size(120, 15);
            this.lbl_titulo2.Text = "Título";
            //
            // lbl_valor2
            //
            this.lbl_valor2.AutoSize = true;
            this.lbl_valor2.Font = new System.Drawing.Font("Segoe UI Semibold", 16F);
            this.lbl_valor2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(58)))), ((int)(((byte)(92)))));
            this.lbl_valor2.Location = new System.Drawing.Point(10, 25);
            this.lbl_valor2.Name = "lbl_valor2";
            this.lbl_valor2.Size = new System.Drawing.Size(26, 30);
            this.lbl_valor2.Text = "0";
            //
            // lbl_detalle2
            //
            this.lbl_detalle2.AutoSize = true;
            this.lbl_detalle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_detalle2.Location = new System.Drawing.Point(12, 60);
            this.lbl_detalle2.Name = "lbl_detalle2";
            this.lbl_detalle2.Size = new System.Drawing.Size(90, 15);
            this.lbl_detalle2.Text = "Detalle";
            //
            // pnl_tarjeta3
            //
            this.pnl_tarjeta3.Controls.Add(this.lbl_titulo3);
            this.pnl_tarjeta3.Controls.Add(this.lbl_valor3);
            this.pnl_tarjeta3.Controls.Add(this.lbl_detalle3);
            this.pnl_tarjeta3.Location = new System.Drawing.Point(516, 96);
            this.pnl_tarjeta3.Name = "pnl_tarjeta3";
            this.pnl_tarjeta3.Size = new System.Drawing.Size(234, 84);
            this.pnl_tarjeta3.TabIndex = 9;
            //
            // lbl_titulo3
            //
            this.lbl_titulo3.AutoSize = true;
            this.lbl_titulo3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_titulo3.Location = new System.Drawing.Point(12, 8);
            this.lbl_titulo3.Name = "lbl_titulo3";
            this.lbl_titulo3.Size = new System.Drawing.Size(120, 15);
            this.lbl_titulo3.Text = "Título";
            //
            // lbl_valor3
            //
            this.lbl_valor3.AutoSize = true;
            this.lbl_valor3.Font = new System.Drawing.Font("Segoe UI Semibold", 16F);
            this.lbl_valor3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(58)))), ((int)(((byte)(92)))));
            this.lbl_valor3.Location = new System.Drawing.Point(10, 25);
            this.lbl_valor3.Name = "lbl_valor3";
            this.lbl_valor3.Size = new System.Drawing.Size(26, 30);
            this.lbl_valor3.Text = "0";
            //
            // lbl_detalle3
            //
            this.lbl_detalle3.AutoSize = true;
            this.lbl_detalle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_detalle3.Location = new System.Drawing.Point(12, 60);
            this.lbl_detalle3.Name = "lbl_detalle3";
            this.lbl_detalle3.Size = new System.Drawing.Size(90, 15);
            this.lbl_detalle3.Text = "Detalle";
            //
            // pnl_tarjeta4
            //
            this.pnl_tarjeta4.Controls.Add(this.lbl_titulo4);
            this.pnl_tarjeta4.Controls.Add(this.lbl_valor4);
            this.pnl_tarjeta4.Controls.Add(this.lbl_detalle4);
            this.pnl_tarjeta4.Location = new System.Drawing.Point(762, 96);
            this.pnl_tarjeta4.Name = "pnl_tarjeta4";
            this.pnl_tarjeta4.Size = new System.Drawing.Size(234, 84);
            this.pnl_tarjeta4.TabIndex = 10;
            //
            // lbl_titulo4
            //
            this.lbl_titulo4.AutoSize = true;
            this.lbl_titulo4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_titulo4.Location = new System.Drawing.Point(12, 8);
            this.lbl_titulo4.Name = "lbl_titulo4";
            this.lbl_titulo4.Size = new System.Drawing.Size(120, 15);
            this.lbl_titulo4.Text = "Título";
            //
            // lbl_valor4
            //
            this.lbl_valor4.AutoSize = true;
            this.lbl_valor4.Font = new System.Drawing.Font("Segoe UI Semibold", 16F);
            this.lbl_valor4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(58)))), ((int)(((byte)(92)))));
            this.lbl_valor4.Location = new System.Drawing.Point(10, 25);
            this.lbl_valor4.Name = "lbl_valor4";
            this.lbl_valor4.Size = new System.Drawing.Size(26, 30);
            this.lbl_valor4.Text = "0";
            //
            // lbl_detalle4
            //
            this.lbl_detalle4.AutoSize = true;
            this.lbl_detalle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_detalle4.Location = new System.Drawing.Point(12, 60);
            this.lbl_detalle4.Name = "lbl_detalle4";
            this.lbl_detalle4.Size = new System.Drawing.Size(90, 15);
            this.lbl_detalle4.Text = "Detalle";
            //
            // chart_1
            //
            this.chart_1.Location = new System.Drawing.Point(24, 188);
            this.chart_1.Name = "chart_1";
            this.chart_1.Size = new System.Drawing.Size(480, 180);
            this.chart_1.TabIndex = 11;
            //
            // chart_2
            //
            this.chart_2.Location = new System.Drawing.Point(516, 188);
            this.chart_2.Name = "chart_2";
            this.chart_2.Size = new System.Drawing.Size(480, 180);
            this.chart_2.TabIndex = 12;
            //
            // dgv_datos
            //
            this.dgv_datos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.col_grupo, this.col_detalle, this.col_cantidad, this.col_monto });
            this.dgv_datos.Location = new System.Drawing.Point(24, 376);
            this.dgv_datos.Name = "dgv_datos";
            this.dgv_datos.Size = new System.Drawing.Size(972, 232);
            this.dgv_datos.TabIndex = 13;
            this.dgv_datos.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgv_datos_DataBindingComplete);
            //
            // col_grupo
            //
            this.col_grupo.DataPropertyName = "Grupo";
            this.col_grupo.FillWeight = 130F;
            this.col_grupo.HeaderText = "Gráfico";
            this.col_grupo.Name = "col_grupo";
            //
            // col_detalle
            //
            this.col_detalle.DataPropertyName = "Detalle";
            this.col_detalle.FillWeight = 130F;
            this.col_detalle.HeaderText = "Detalle";
            this.col_detalle.Name = "col_detalle";
            //
            // col_cantidad
            //
            this.col_cantidad.DataPropertyName = "Cantidad";
            this.col_cantidad.FillWeight = 50F;
            this.col_cantidad.HeaderText = "Cantidad";
            this.col_cantidad.Name = "col_cantidad";
            //
            // col_monto
            //
            this.col_monto.DataPropertyName = "MontoTexto";
            this.col_monto.FillWeight = 70F;
            this.col_monto.HeaderText = "Monto";
            this.col_monto.Name = "col_monto";
            //
            // lbl_nota
            //
            this.lbl_nota.AutoSize = true;
            this.lbl_nota.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_nota.Location = new System.Drawing.Point(24, 616);
            this.lbl_nota.Name = "lbl_nota";
            this.lbl_nota.Size = new System.Drawing.Size(500, 15);
            this.lbl_nota.Text = "Las tarjetas y gráficos marcados Hoy o Histórico no dependen del período elegido.";
            //
            // Reportes
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1020, 650);
            this.Controls.Add(this.lbl_nota);
            this.Controls.Add(this.dgv_datos);
            this.Controls.Add(this.chart_2);
            this.Controls.Add(this.chart_1);
            this.Controls.Add(this.pnl_tarjeta1);
            this.Controls.Add(this.pnl_tarjeta2);
            this.Controls.Add(this.pnl_tarjeta3);
            this.Controls.Add(this.pnl_tarjeta4);
            this.Controls.Add(this.tab_secciones);
            this.Controls.Add(this.btn_pdf);
            this.Controls.Add(this.btn_csv);
            this.Controls.Add(this.btn_consultar);
            this.Controls.Add(this.dtp_hasta);
            this.Controls.Add(this.lbl_hasta);
            this.Controls.Add(this.dtp_desde);
            this.Controls.Add(this.lbl_desde);
            this.Controls.Add(this.lbl_titulo);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(56)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reportes";
            this.Text = "Reportes";
            this.Load += new System.EventHandler(this.Reportes_Load);
            this.tab_secciones.ResumeLayout(false);
            this.pnl_tarjeta1.ResumeLayout(false);
            this.pnl_tarjeta1.PerformLayout();
            this.pnl_tarjeta2.ResumeLayout(false);
            this.pnl_tarjeta2.PerformLayout();
            this.pnl_tarjeta3.ResumeLayout(false);
            this.pnl_tarjeta3.PerformLayout();
            this.pnl_tarjeta4.ResumeLayout(false);
            this.pnl_tarjeta4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_desde;
        private System.Windows.Forms.DateTimePicker dtp_desde;
        private System.Windows.Forms.Label lbl_hasta;
        private System.Windows.Forms.DateTimePicker dtp_hasta;
        private System.Windows.Forms.Button btn_consultar;
        private System.Windows.Forms.Button btn_csv;
        private System.Windows.Forms.Button btn_pdf;
        private System.Windows.Forms.TabControl tab_secciones;
        private System.Windows.Forms.TabPage tab_general;
        private System.Windows.Forms.TabPage tab_polizas;
        private System.Windows.Forms.TabPage tab_cobranzas;
        private System.Windows.Forms.TabPage tab_siniestros;
        private System.Windows.Forms.TabPage tab_clientes;
        private System.Windows.Forms.TabPage tab_personal;
        private System.Windows.Forms.Panel pnl_tarjeta1;
        private System.Windows.Forms.Label lbl_titulo1;
        private System.Windows.Forms.Label lbl_valor1;
        private System.Windows.Forms.Label lbl_detalle1;
        private System.Windows.Forms.Panel pnl_tarjeta2;
        private System.Windows.Forms.Label lbl_titulo2;
        private System.Windows.Forms.Label lbl_valor2;
        private System.Windows.Forms.Label lbl_detalle2;
        private System.Windows.Forms.Panel pnl_tarjeta3;
        private System.Windows.Forms.Label lbl_titulo3;
        private System.Windows.Forms.Label lbl_valor3;
        private System.Windows.Forms.Label lbl_detalle3;
        private System.Windows.Forms.Panel pnl_tarjeta4;
        private System.Windows.Forms.Label lbl_titulo4;
        private System.Windows.Forms.Label lbl_valor4;
        private System.Windows.Forms.Label lbl_detalle4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_2;
        private System.Windows.Forms.DataGridView dgv_datos;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_grupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_detalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_monto;
        private System.Windows.Forms.Label lbl_nota;
    }
}
