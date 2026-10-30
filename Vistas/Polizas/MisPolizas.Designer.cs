namespace FixedSegurosApp.Vistas
{
    partial class MisPolizas
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
            System.Windows.Forms.DataGridViewCellStyle estiloVence = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle estiloCuota = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.pnl_lista = new System.Windows.Forms.Panel();
            this.lbl_lista_titulo = new System.Windows.Forms.Label();
            this.dgv_polizas = new System.Windows.Forms.DataGridView();
            this.col_nro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dominio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_aseguradora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_cobertura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_vence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_cantidad = new System.Windows.Forms.Label();
            this.pnl_detalle = new System.Windows.Forms.Panel();
            this.lbl_detalle_titulo = new System.Windows.Forms.Label();
            this.pnl_linea_detalle = new System.Windows.Forms.Panel();
            this.lbl_vehiculo = new System.Windows.Forms.Label();
            this.cb_vehiculo = new System.Windows.Forms.ComboBox();
            this.lbl_ayuda = new System.Windows.Forms.Label();
            this.lbl_ofrecidas = new System.Windows.Forms.Label();
            this.dgv_ofrecidas = new System.Windows.Forms.DataGridView();
            this.col_of_aseguradora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_of_cobertura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_of_cuota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_oferta = new System.Windows.Forms.Label();
            this.pnl_linea_pie = new System.Windows.Forms.Panel();
            this.btn_adquirir = new System.Windows.Forms.Button();
            this.pnl_lista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_polizas)).BeginInit();
            this.pnl_detalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ofrecidas)).BeginInit();
            this.SuspendLayout();
            //
            // lbl_titulo
            //
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Segoe UI Semibold", 16F);
            this.lbl_titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(58)))), ((int)(((byte)(92)))));
            this.lbl_titulo.Location = new System.Drawing.Point(20, 20);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(84, 30);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Pólizas";
            //
            // pnl_lista
            //
            this.pnl_lista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_lista.Controls.Add(this.lbl_lista_titulo);
            this.pnl_lista.Controls.Add(this.dgv_polizas);
            this.pnl_lista.Controls.Add(this.lbl_cantidad);
            this.pnl_lista.Location = new System.Drawing.Point(24, 70);
            this.pnl_lista.Name = "pnl_lista";
            this.pnl_lista.Size = new System.Drawing.Size(584, 636);
            this.pnl_lista.TabIndex = 1;
            //
            // lbl_lista_titulo
            //
            this.lbl_lista_titulo.AutoSize = true;
            this.lbl_lista_titulo.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.lbl_lista_titulo.Location = new System.Drawing.Point(14, 18);
            this.lbl_lista_titulo.Name = "lbl_lista_titulo";
            this.lbl_lista_titulo.Size = new System.Drawing.Size(92, 20);
            this.lbl_lista_titulo.TabIndex = 0;
            this.lbl_lista_titulo.Text = "Mis pólizas";
            //
            // dgv_polizas
            //
            this.dgv_polizas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_polizas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_nro,
            this.col_dominio,
            this.col_aseguradora,
            this.col_cobertura,
            this.col_vence,
            this.col_estado});
            this.dgv_polizas.Location = new System.Drawing.Point(1, 58);
            this.dgv_polizas.Name = "dgv_polizas";
            this.dgv_polizas.Size = new System.Drawing.Size(582, 536);
            this.dgv_polizas.TabIndex = 1;
            this.dgv_polizas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grilla_CellFormatting);
            //
            // col_nro
            //
            this.col_nro.DataPropertyName = "NroTexto";
            this.col_nro.FillWeight = 65F;
            this.col_nro.HeaderText = "N°";
            this.col_nro.Name = "col_nro";
            //
            // col_dominio
            //
            this.col_dominio.DataPropertyName = "Dominio";
            this.col_dominio.FillWeight = 75F;
            this.col_dominio.HeaderText = "Dominio";
            this.col_dominio.Name = "col_dominio";
            //
            // col_aseguradora
            //
            this.col_aseguradora.DataPropertyName = "Aseguradora";
            this.col_aseguradora.FillWeight = 110F;
            this.col_aseguradora.HeaderText = "Aseguradora";
            this.col_aseguradora.Name = "col_aseguradora";
            //
            // col_cobertura
            //
            this.col_cobertura.DataPropertyName = "TipoCobertura";
            this.col_cobertura.FillWeight = 100F;
            this.col_cobertura.HeaderText = "Cobertura";
            this.col_cobertura.Name = "col_cobertura";
            //
            // col_vence
            //
            this.col_vence.DataPropertyName = "FechaVencimiento";
            estiloVence.Format = "dd/MM/yyyy";
            this.col_vence.DefaultCellStyle = estiloVence;
            this.col_vence.FillWeight = 75F;
            this.col_vence.HeaderText = "Vence";
            this.col_vence.Name = "col_vence";
            //
            // col_estado
            //
            this.col_estado.DataPropertyName = "EstadoMostrado";
            this.col_estado.FillWeight = 80F;
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
            this.lbl_cantidad.Size = new System.Drawing.Size(121, 15);
            this.lbl_cantidad.TabIndex = 2;
            this.lbl_cantidad.Text = "Mostrando 0 pólizas";
            //
            // pnl_detalle
            //
            this.pnl_detalle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_detalle.Controls.Add(this.lbl_detalle_titulo);
            this.pnl_detalle.Controls.Add(this.pnl_linea_detalle);
            this.pnl_detalle.Controls.Add(this.lbl_vehiculo);
            this.pnl_detalle.Controls.Add(this.cb_vehiculo);
            this.pnl_detalle.Controls.Add(this.lbl_ayuda);
            this.pnl_detalle.Controls.Add(this.lbl_ofrecidas);
            this.pnl_detalle.Controls.Add(this.dgv_ofrecidas);
            this.pnl_detalle.Controls.Add(this.lbl_oferta);
            this.pnl_detalle.Controls.Add(this.pnl_linea_pie);
            this.pnl_detalle.Controls.Add(this.btn_adquirir);
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
            this.lbl_detalle_titulo.Size = new System.Drawing.Size(157, 20);
            this.lbl_detalle_titulo.TabIndex = 0;
            this.lbl_detalle_titulo.Text = "Contratar una póliza";
            //
            // pnl_linea_detalle
            //
            this.pnl_linea_detalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(221)))), ((int)(((byte)(232)))));
            this.pnl_linea_detalle.Location = new System.Drawing.Point(1, 54);
            this.pnl_linea_detalle.Name = "pnl_linea_detalle";
            this.pnl_linea_detalle.Size = new System.Drawing.Size(374, 1);
            this.pnl_linea_detalle.TabIndex = 20;
            //
            // lbl_vehiculo
            //
            this.lbl_vehiculo.AutoSize = true;
            this.lbl_vehiculo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_vehiculo.Location = new System.Drawing.Point(16, 66);
            this.lbl_vehiculo.Name = "lbl_vehiculo";
            this.lbl_vehiculo.Size = new System.Drawing.Size(51, 15);
            this.lbl_vehiculo.Text = "Vehículo";
            //
            // cb_vehiculo
            //
            this.cb_vehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_vehiculo.Location = new System.Drawing.Point(16, 86);
            this.cb_vehiculo.Name = "cb_vehiculo";
            this.cb_vehiculo.Size = new System.Drawing.Size(344, 23);
            this.cb_vehiculo.TabIndex = 1;
            this.cb_vehiculo.SelectedIndexChanged += new System.EventHandler(this.cb_vehiculo_SelectedIndexChanged);
            //
            // lbl_ayuda
            //
            this.lbl_ayuda.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lbl_ayuda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_ayuda.Location = new System.Drawing.Point(16, 112);
            this.lbl_ayuda.Name = "lbl_ayuda";
            this.lbl_ayuda.Size = new System.Drawing.Size(344, 30);
            this.lbl_ayuda.Text = "Solo aparecen sus vehículos aprobados por un empleado y sin póliza vigente.";
            //
            // lbl_ofrecidas
            //
            this.lbl_ofrecidas.AutoSize = true;
            this.lbl_ofrecidas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_ofrecidas.Location = new System.Drawing.Point(16, 146);
            this.lbl_ofrecidas.Name = "lbl_ofrecidas";
            this.lbl_ofrecidas.Size = new System.Drawing.Size(111, 15);
            this.lbl_ofrecidas.Text = "Pólizas disponibles";
            //
            // dgv_ofrecidas
            //
            this.dgv_ofrecidas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_of_aseguradora,
            this.col_of_cobertura,
            this.col_of_cuota});
            this.dgv_ofrecidas.Location = new System.Drawing.Point(16, 166);
            this.dgv_ofrecidas.Name = "dgv_ofrecidas";
            this.dgv_ofrecidas.Size = new System.Drawing.Size(344, 170);
            this.dgv_ofrecidas.TabIndex = 2;
            this.dgv_ofrecidas.SelectionChanged += new System.EventHandler(this.dgv_ofrecidas_SelectionChanged);
            //
            // col_of_aseguradora
            //
            this.col_of_aseguradora.DataPropertyName = "Aseguradora";
            this.col_of_aseguradora.FillWeight = 100F;
            this.col_of_aseguradora.HeaderText = "Aseguradora";
            this.col_of_aseguradora.Name = "col_of_aseguradora";
            //
            // col_of_cobertura
            //
            this.col_of_cobertura.DataPropertyName = "TipoCobertura";
            this.col_of_cobertura.FillWeight = 100F;
            this.col_of_cobertura.HeaderText = "Cobertura";
            this.col_of_cobertura.Name = "col_of_cobertura";
            //
            // col_of_cuota
            //
            this.col_of_cuota.DataPropertyName = "MontoCuota";
            estiloCuota.Format = "\'$ \'#,##0";
            this.col_of_cuota.DefaultCellStyle = estiloCuota;
            this.col_of_cuota.FillWeight = 70F;
            this.col_of_cuota.HeaderText = "Cuota";
            this.col_of_cuota.Name = "col_of_cuota";
            //
            // lbl_oferta
            //
            this.lbl_oferta.Location = new System.Drawing.Point(16, 348);
            this.lbl_oferta.Name = "lbl_oferta";
            this.lbl_oferta.Size = new System.Drawing.Size(344, 214);
            this.lbl_oferta.Text = "Detalle de la póliza elegida";
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
            // btn_adquirir
            //
            this.btn_adquirir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_adquirir.Location = new System.Drawing.Point(220, 586);
            this.btn_adquirir.Name = "btn_adquirir";
            this.btn_adquirir.Size = new System.Drawing.Size(140, 34);
            this.btn_adquirir.TabIndex = 3;
            this.btn_adquirir.Text = "Adquirir póliza";
            this.btn_adquirir.UseVisualStyleBackColor = false;
            this.btn_adquirir.Click += new System.EventHandler(this.btn_adquirir_Click);
            //
            // MisPolizas
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
            this.Name = "MisPolizas";
            this.Text = "Pólizas";
            this.Load += new System.EventHandler(this.MisPolizas_Load);
            this.pnl_lista.ResumeLayout(false);
            this.pnl_lista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_polizas)).EndInit();
            this.pnl_detalle.ResumeLayout(false);
            this.pnl_detalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ofrecidas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Panel pnl_lista;
        private System.Windows.Forms.Label lbl_lista_titulo;
        private System.Windows.Forms.DataGridView dgv_polizas;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_nro;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dominio;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_aseguradora;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cobertura;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_vence;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_estado;
        private System.Windows.Forms.Label lbl_cantidad;
        private System.Windows.Forms.Panel pnl_detalle;
        private System.Windows.Forms.Label lbl_detalle_titulo;
        private System.Windows.Forms.Panel pnl_linea_detalle;
        private System.Windows.Forms.Label lbl_vehiculo;
        private System.Windows.Forms.ComboBox cb_vehiculo;
        private System.Windows.Forms.Label lbl_ayuda;
        private System.Windows.Forms.Label lbl_ofrecidas;
        private System.Windows.Forms.DataGridView dgv_ofrecidas;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_of_aseguradora;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_of_cobertura;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_of_cuota;
        private System.Windows.Forms.Label lbl_oferta;
        private System.Windows.Forms.Panel pnl_linea_pie;
        private System.Windows.Forms.Button btn_adquirir;
    }
}
