namespace FixedSegurosApp.Vistas
{
    partial class Pagos
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
            System.Windows.Forms.DataGridViewCellStyle estiloVencimiento = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle estiloMonto = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle estiloFechaPago = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.pnl_lista = new System.Windows.Forms.Panel();
            this.lbl_dni = new System.Windows.Forms.Label();
            this.txt_dni = new System.Windows.Forms.TextBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.lbl_poliza = new System.Windows.Forms.Label();
            this.cb_poliza = new System.Windows.Forms.ComboBox();
            this.dgv_cuotas = new System.Windows.Forms.DataGridView();
            this.col_cuota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_vencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_fecha_pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_cantidad = new System.Windows.Forms.Label();
            this.pnl_detalle = new System.Windows.Forms.Panel();
            this.lbl_detalle_titulo = new System.Windows.Forms.Label();
            this.pnl_linea_detalle = new System.Windows.Forms.Panel();
            this.lbl_cuota = new System.Windows.Forms.Label();
            this.txt_cuota = new System.Windows.Forms.TextBox();
            this.lbl_vencimiento = new System.Windows.Forms.Label();
            this.txt_vencimiento = new System.Windows.Forms.TextBox();
            this.lbl_monto = new System.Windows.Forms.Label();
            this.txt_monto = new System.Windows.Forms.TextBox();
            this.lbl_metodo = new System.Windows.Forms.Label();
            this.cb_metodo = new System.Windows.Forms.ComboBox();
            this.lbl_operacion = new System.Windows.Forms.Label();
            this.txt_operacion = new System.Windows.Forms.TextBox();
            this.pnl_aviso = new System.Windows.Forms.Panel();
            this.lbl_estado = new System.Windows.Forms.Label();
            this.lbl_aviso = new System.Windows.Forms.Label();
            this.pnl_linea_pie = new System.Windows.Forms.Panel();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_pagar = new System.Windows.Forms.Button();
            this.pnl_lista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cuotas)).BeginInit();
            this.pnl_detalle.SuspendLayout();
            this.pnl_aviso.SuspendLayout();
            this.SuspendLayout();
            //
            // lbl_titulo
            //
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Segoe UI Semibold", 16F);
            this.lbl_titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(58)))), ((int)(((byte)(92)))));
            this.lbl_titulo.Location = new System.Drawing.Point(20, 20);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(76, 30);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Pagos";
            //
            // pnl_lista
            //
            this.pnl_lista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_lista.Controls.Add(this.lbl_dni);
            this.pnl_lista.Controls.Add(this.txt_dni);
            this.pnl_lista.Controls.Add(this.btn_buscar);
            this.pnl_lista.Controls.Add(this.lbl_poliza);
            this.pnl_lista.Controls.Add(this.cb_poliza);
            this.pnl_lista.Controls.Add(this.dgv_cuotas);
            this.pnl_lista.Controls.Add(this.lbl_cantidad);
            this.pnl_lista.Location = new System.Drawing.Point(24, 70);
            this.pnl_lista.Name = "pnl_lista";
            this.pnl_lista.Size = new System.Drawing.Size(584, 636);
            this.pnl_lista.TabIndex = 1;
            //
            // lbl_dni
            //
            this.lbl_dni.AutoSize = true;
            this.lbl_dni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_dni.Location = new System.Drawing.Point(16, 21);
            this.lbl_dni.Name = "lbl_dni";
            this.lbl_dni.Size = new System.Drawing.Size(27, 15);
            this.lbl_dni.Text = "DNI";
            //
            // txt_dni
            //
            this.txt_dni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_dni.Location = new System.Drawing.Point(48, 17);
            this.txt_dni.MaxLength = 8;
            this.txt_dni.Name = "txt_dni";
            this.txt_dni.Size = new System.Drawing.Size(100, 23);
            this.txt_dni.TabIndex = 3;
            //
            // btn_buscar
            //
            this.btn_buscar.Location = new System.Drawing.Point(154, 15);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(74, 27);
            this.btn_buscar.TabIndex = 4;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            //
            // lbl_poliza
            //
            this.lbl_poliza.AutoSize = true;
            this.lbl_poliza.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_poliza.Location = new System.Drawing.Point(238, 21);
            this.lbl_poliza.Name = "lbl_poliza";
            this.lbl_poliza.Size = new System.Drawing.Size(39, 15);
            this.lbl_poliza.Text = "Póliza";
            //
            // cb_poliza
            //
            this.cb_poliza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_poliza.Location = new System.Drawing.Point(284, 17);
            this.cb_poliza.Name = "cb_poliza";
            this.cb_poliza.Size = new System.Drawing.Size(260, 23);
            this.cb_poliza.TabIndex = 0;
            this.cb_poliza.SelectedIndexChanged += new System.EventHandler(this.cb_poliza_SelectedIndexChanged);
            //
            // dgv_cuotas
            //
            this.dgv_cuotas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_cuotas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_cuota,
            this.col_vencimiento,
            this.col_monto,
            this.col_fecha_pago,
            this.col_estado});
            this.dgv_cuotas.Location = new System.Drawing.Point(1, 58);
            this.dgv_cuotas.Name = "dgv_cuotas";
            this.dgv_cuotas.Size = new System.Drawing.Size(582, 536);
            this.dgv_cuotas.TabIndex = 1;
            this.dgv_cuotas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_cuotas_CellFormatting);
            this.dgv_cuotas.SelectionChanged += new System.EventHandler(this.dgv_cuotas_SelectionChanged);
            //
            // col_cuota
            //
            this.col_cuota.DataPropertyName = "Cuota";
            this.col_cuota.FillWeight = 55F;
            this.col_cuota.HeaderText = "Cuota";
            this.col_cuota.Name = "col_cuota";
            //
            // col_vencimiento
            //
            this.col_vencimiento.DataPropertyName = "FechaVencimiento";
            estiloVencimiento.Format = "dd/MM/yyyy";
            this.col_vencimiento.DefaultCellStyle = estiloVencimiento;
            this.col_vencimiento.FillWeight = 95F;
            this.col_vencimiento.HeaderText = "Vencimiento";
            this.col_vencimiento.Name = "col_vencimiento";
            //
            // col_monto
            //
            this.col_monto.DataPropertyName = "Monto";
            estiloMonto.Format = "\'$ \'#,##0.00";
            this.col_monto.DefaultCellStyle = estiloMonto;
            this.col_monto.FillWeight = 95F;
            this.col_monto.HeaderText = "Monto";
            this.col_monto.Name = "col_monto";
            //
            // col_fecha_pago
            //
            this.col_fecha_pago.DataPropertyName = "FechaPago";
            estiloFechaPago.Format = "dd/MM/yyyy";
            estiloFechaPago.NullValue = "—";
            this.col_fecha_pago.DefaultCellStyle = estiloFechaPago;
            this.col_fecha_pago.FillWeight = 95F;
            this.col_fecha_pago.HeaderText = "Fecha de pago";
            this.col_fecha_pago.Name = "col_fecha_pago";
            //
            // col_estado
            //
            this.col_estado.DataPropertyName = "Estado";
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
            this.lbl_cantidad.Size = new System.Drawing.Size(113, 15);
            this.lbl_cantidad.TabIndex = 2;
            this.lbl_cantidad.Text = "Mostrando 0 cuotas";
            //
            // pnl_detalle
            //
            this.pnl_detalle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_detalle.Controls.Add(this.lbl_detalle_titulo);
            this.pnl_detalle.Controls.Add(this.pnl_linea_detalle);
            this.pnl_detalle.Controls.Add(this.lbl_cuota);
            this.pnl_detalle.Controls.Add(this.txt_cuota);
            this.pnl_detalle.Controls.Add(this.lbl_vencimiento);
            this.pnl_detalle.Controls.Add(this.txt_vencimiento);
            this.pnl_detalle.Controls.Add(this.lbl_monto);
            this.pnl_detalle.Controls.Add(this.txt_monto);
            this.pnl_detalle.Controls.Add(this.lbl_metodo);
            this.pnl_detalle.Controls.Add(this.cb_metodo);
            this.pnl_detalle.Controls.Add(this.lbl_operacion);
            this.pnl_detalle.Controls.Add(this.txt_operacion);
            this.pnl_detalle.Controls.Add(this.pnl_aviso);
            this.pnl_detalle.Controls.Add(this.pnl_linea_pie);
            this.pnl_detalle.Controls.Add(this.btn_cancelar);
            this.pnl_detalle.Controls.Add(this.btn_pagar);
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
            this.lbl_detalle_titulo.Size = new System.Drawing.Size(84, 20);
            this.lbl_detalle_titulo.TabIndex = 0;
            this.lbl_detalle_titulo.Text = "Pagar cuota";
            //
            // pnl_linea_detalle
            //
            this.pnl_linea_detalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(221)))), ((int)(((byte)(232)))));
            this.pnl_linea_detalle.Location = new System.Drawing.Point(1, 54);
            this.pnl_linea_detalle.Name = "pnl_linea_detalle";
            this.pnl_linea_detalle.Size = new System.Drawing.Size(374, 1);
            this.pnl_linea_detalle.TabIndex = 20;
            //
            // lbl_cuota
            //
            this.lbl_cuota.AutoSize = true;
            this.lbl_cuota.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_cuota.Location = new System.Drawing.Point(16, 66);
            this.lbl_cuota.Name = "lbl_cuota";
            this.lbl_cuota.Size = new System.Drawing.Size(80, 15);
            this.lbl_cuota.Text = "Cuota a pagar";
            //
            // txt_cuota
            //
            this.txt_cuota.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.txt_cuota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_cuota.Location = new System.Drawing.Point(16, 86);
            this.txt_cuota.Name = "txt_cuota";
            this.txt_cuota.ReadOnly = true;
            this.txt_cuota.Size = new System.Drawing.Size(164, 23);
            this.txt_cuota.TabIndex = 1;
            this.txt_cuota.TabStop = false;
            //
            // lbl_vencimiento
            //
            this.lbl_vencimiento.AutoSize = true;
            this.lbl_vencimiento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_vencimiento.Location = new System.Drawing.Point(196, 66);
            this.lbl_vencimiento.Name = "lbl_vencimiento";
            this.lbl_vencimiento.Size = new System.Drawing.Size(71, 15);
            this.lbl_vencimiento.Text = "Vencimiento";
            //
            // txt_vencimiento
            //
            this.txt_vencimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.txt_vencimiento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_vencimiento.Location = new System.Drawing.Point(196, 86);
            this.txt_vencimiento.Name = "txt_vencimiento";
            this.txt_vencimiento.ReadOnly = true;
            this.txt_vencimiento.Size = new System.Drawing.Size(164, 23);
            this.txt_vencimiento.TabIndex = 2;
            this.txt_vencimiento.TabStop = false;
            //
            // lbl_monto
            //
            this.lbl_monto.AutoSize = true;
            this.lbl_monto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_monto.Location = new System.Drawing.Point(16, 120);
            this.lbl_monto.Name = "lbl_monto";
            this.lbl_monto.Size = new System.Drawing.Size(43, 15);
            this.lbl_monto.Text = "Monto";
            //
            // txt_monto
            //
            this.txt_monto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.txt_monto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_monto.Location = new System.Drawing.Point(16, 140);
            this.txt_monto.Name = "txt_monto";
            this.txt_monto.ReadOnly = true;
            this.txt_monto.Size = new System.Drawing.Size(164, 23);
            this.txt_monto.TabIndex = 3;
            this.txt_monto.TabStop = false;
            //
            // lbl_metodo
            //
            this.lbl_metodo.AutoSize = true;
            this.lbl_metodo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_metodo.Location = new System.Drawing.Point(196, 120);
            this.lbl_metodo.Name = "lbl_metodo";
            this.lbl_metodo.Size = new System.Drawing.Size(93, 15);
            this.lbl_metodo.Text = "Método de pago";
            //
            // cb_metodo
            //
            this.cb_metodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_metodo.Location = new System.Drawing.Point(196, 140);
            this.cb_metodo.Name = "cb_metodo";
            this.cb_metodo.Size = new System.Drawing.Size(164, 23);
            this.cb_metodo.TabIndex = 4;
            //
            // lbl_operacion
            //
            this.lbl_operacion.AutoSize = true;
            this.lbl_operacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_operacion.Location = new System.Drawing.Point(16, 174);
            this.lbl_operacion.Name = "lbl_operacion";
            this.lbl_operacion.Size = new System.Drawing.Size(83, 15);
            this.lbl_operacion.Text = "N° de operación";
            //
            // txt_operacion
            //
            this.txt_operacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.txt_operacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_operacion.Location = new System.Drawing.Point(16, 194);
            this.txt_operacion.Name = "txt_operacion";
            this.txt_operacion.ReadOnly = true;
            this.txt_operacion.Size = new System.Drawing.Size(344, 23);
            this.txt_operacion.TabIndex = 5;
            this.txt_operacion.TabStop = false;
            //
            // pnl_aviso
            //
            this.pnl_aviso.Controls.Add(this.lbl_estado);
            this.pnl_aviso.Controls.Add(this.lbl_aviso);
            this.pnl_aviso.Location = new System.Drawing.Point(16, 234);
            this.pnl_aviso.Name = "pnl_aviso";
            this.pnl_aviso.Size = new System.Drawing.Size(344, 110);
            this.pnl_aviso.TabIndex = 6;
            //
            // lbl_estado
            //
            this.lbl_estado.AutoSize = true;
            this.lbl_estado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(0)))));
            this.lbl_estado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_estado.ForeColor = System.Drawing.Color.White;
            this.lbl_estado.Location = new System.Drawing.Point(12, 12);
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Padding = new System.Windows.Forms.Padding(6, 2, 6, 2);
            this.lbl_estado.Size = new System.Drawing.Size(104, 19);
            this.lbl_estado.Text = "Cuota pendiente";
            //
            // lbl_aviso
            //
            this.lbl_aviso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_aviso.Location = new System.Drawing.Point(12, 38);
            this.lbl_aviso.Name = "lbl_aviso";
            this.lbl_aviso.Size = new System.Drawing.Size(320, 64);
            this.lbl_aviso.Text = "Al confirmar, el sistema registra la operación y le asigna un número.";
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
            // btn_cancelar
            //
            this.btn_cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancelar.Location = new System.Drawing.Point(124, 586);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(110, 34);
            this.btn_cancelar.TabIndex = 8;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            //
            // btn_pagar
            //
            this.btn_pagar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_pagar.Location = new System.Drawing.Point(240, 586);
            this.btn_pagar.Name = "btn_pagar";
            this.btn_pagar.Size = new System.Drawing.Size(120, 34);
            this.btn_pagar.TabIndex = 7;
            this.btn_pagar.Text = "Pagar cuota";
            this.btn_pagar.UseVisualStyleBackColor = false;
            this.btn_pagar.Click += new System.EventHandler(this.btn_pagar_Click);
            //
            // Pagos
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
            this.Name = "Pagos";
            this.Text = "Pagos";
            this.Load += new System.EventHandler(this.Pagos_Load);
            this.pnl_lista.ResumeLayout(false);
            this.pnl_lista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cuotas)).EndInit();
            this.pnl_detalle.ResumeLayout(false);
            this.pnl_detalle.PerformLayout();
            this.pnl_aviso.ResumeLayout(false);
            this.pnl_aviso.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Panel pnl_lista;
        private System.Windows.Forms.Label lbl_dni;
        private System.Windows.Forms.TextBox txt_dni;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Label lbl_poliza;
        private System.Windows.Forms.ComboBox cb_poliza;
        private System.Windows.Forms.DataGridView dgv_cuotas;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cuota;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_vencimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_fecha_pago;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_estado;
        private System.Windows.Forms.Label lbl_cantidad;
        private System.Windows.Forms.Panel pnl_detalle;
        private System.Windows.Forms.Label lbl_detalle_titulo;
        private System.Windows.Forms.Panel pnl_linea_detalle;
        private System.Windows.Forms.Label lbl_cuota;
        private System.Windows.Forms.TextBox txt_cuota;
        private System.Windows.Forms.Label lbl_vencimiento;
        private System.Windows.Forms.TextBox txt_vencimiento;
        private System.Windows.Forms.Label lbl_monto;
        private System.Windows.Forms.TextBox txt_monto;
        private System.Windows.Forms.Label lbl_metodo;
        private System.Windows.Forms.ComboBox cb_metodo;
        private System.Windows.Forms.Label lbl_operacion;
        private System.Windows.Forms.TextBox txt_operacion;
        private System.Windows.Forms.Panel pnl_aviso;
        private System.Windows.Forms.Label lbl_estado;
        private System.Windows.Forms.Label lbl_aviso;
        private System.Windows.Forms.Panel pnl_linea_pie;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_pagar;
    }
}
