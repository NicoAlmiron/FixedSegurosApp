namespace FixedSegurosApp.Vistas
{
    partial class Inicio
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
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.btn_nueva_poliza = new System.Windows.Forms.Button();
            this.btn_habilitar = new System.Windows.Forms.Button();
            this.btn_aseguradora = new System.Windows.Forms.Button();
            this.btn_mi_cuenta = new System.Windows.Forms.Button();
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
            this.pnl_aviso = new System.Windows.Forms.Panel();
            this.lbl_aviso = new System.Windows.Forms.Label();
            this.btn_cambiar = new System.Windows.Forms.Button();
            this.pnl_alertas = new System.Windows.Forms.Panel();
            this.lbl_alertas_titulo = new System.Windows.Forms.Label();
            this.lbl_mostrar = new System.Windows.Forms.Label();
            this.cb_aseguradora = new System.Windows.Forms.ComboBox();
            this.dgv_alertas = new System.Windows.Forms.DataGridView();
            this.col_nro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dominio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_aseguradora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_vence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_alerta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_cantidad = new System.Windows.Forms.Label();
            this.pnl_tarjeta1.SuspendLayout();
            this.pnl_tarjeta2.SuspendLayout();
            this.pnl_tarjeta3.SuspendLayout();
            this.pnl_tarjeta4.SuspendLayout();
            this.pnl_aviso.SuspendLayout();
            this.pnl_alertas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_alertas)).BeginInit();
            this.SuspendLayout();
            estiloVence.Format = "dd/MM/yyyy";
            //
            // lbl_titulo
            //
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Segoe UI Semibold", 16F);
            this.lbl_titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(58)))), ((int)(((byte)(92)))));
            this.lbl_titulo.Location = new System.Drawing.Point(20, 20);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(66, 30);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Inicio";
            //
            // btn_nueva_poliza
            //
            this.btn_nueva_poliza.Location = new System.Drawing.Point(410, 18);
            this.btn_nueva_poliza.Name = "btn_nueva_poliza";
            this.btn_nueva_poliza.Size = new System.Drawing.Size(120, 34);
            this.btn_nueva_poliza.TabIndex = 1;
            this.btn_nueva_poliza.Text = "Nueva póliza";
            this.btn_nueva_poliza.UseVisualStyleBackColor = false;
            this.btn_nueva_poliza.Click += new System.EventHandler(this.btn_nueva_poliza_Click);
            //
            // btn_habilitar
            //
            this.btn_habilitar.Location = new System.Drawing.Point(538, 18);
            this.btn_habilitar.Name = "btn_habilitar";
            this.btn_habilitar.Size = new System.Drawing.Size(160, 34);
            this.btn_habilitar.TabIndex = 2;
            this.btn_habilitar.Text = "Habilitar empleado";
            this.btn_habilitar.UseVisualStyleBackColor = false;
            this.btn_habilitar.Click += new System.EventHandler(this.btn_habilitar_Click);
            //
            // btn_aseguradora
            //
            this.btn_aseguradora.Location = new System.Drawing.Point(706, 18);
            this.btn_aseguradora.Name = "btn_aseguradora";
            this.btn_aseguradora.Size = new System.Drawing.Size(178, 34);
            this.btn_aseguradora.TabIndex = 3;
            this.btn_aseguradora.Text = "Registrar aseguradora";
            this.btn_aseguradora.UseVisualStyleBackColor = false;
            this.btn_aseguradora.Click += new System.EventHandler(this.btn_aseguradora_Click);
            //
            // btn_mi_cuenta
            //
            this.btn_mi_cuenta.Location = new System.Drawing.Point(892, 18);
            this.btn_mi_cuenta.Name = "btn_mi_cuenta";
            this.btn_mi_cuenta.Size = new System.Drawing.Size(104, 34);
            this.btn_mi_cuenta.TabIndex = 4;
            this.btn_mi_cuenta.Text = "Mi cuenta";
            this.btn_mi_cuenta.UseVisualStyleBackColor = false;
            this.btn_mi_cuenta.Click += new System.EventHandler(this.btn_mi_cuenta_Click);
            //
            // pnl_tarjeta1
            //
            this.pnl_tarjeta1.Controls.Add(this.lbl_titulo1);
            this.pnl_tarjeta1.Controls.Add(this.lbl_valor1);
            this.pnl_tarjeta1.Controls.Add(this.lbl_detalle1);
            this.pnl_tarjeta1.Location = new System.Drawing.Point(24, 70);
            this.pnl_tarjeta1.Name = "pnl_tarjeta1";
            this.pnl_tarjeta1.Size = new System.Drawing.Size(234, 100);
            this.pnl_tarjeta1.TabIndex = 5;
            //
            // lbl_titulo1
            //
            this.lbl_titulo1.AutoSize = true;
            this.lbl_titulo1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_titulo1.Location = new System.Drawing.Point(14, 12);
            this.lbl_titulo1.Name = "lbl_titulo1";
            this.lbl_titulo1.Size = new System.Drawing.Size(120, 15);
            this.lbl_titulo1.Text = "Título";
            //
            // lbl_valor1
            //
            this.lbl_valor1.AutoSize = true;
            this.lbl_valor1.Font = new System.Drawing.Font("Segoe UI Semibold", 20F);
            this.lbl_valor1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(58)))), ((int)(((byte)(92)))));
            this.lbl_valor1.Location = new System.Drawing.Point(11, 30);
            this.lbl_valor1.Name = "lbl_valor1";
            this.lbl_valor1.Size = new System.Drawing.Size(30, 37);
            this.lbl_valor1.Text = "0";
            //
            // lbl_detalle1
            //
            this.lbl_detalle1.AutoSize = true;
            this.lbl_detalle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_detalle1.Location = new System.Drawing.Point(14, 74);
            this.lbl_detalle1.Name = "lbl_detalle1";
            this.lbl_detalle1.Size = new System.Drawing.Size(90, 15);
            this.lbl_detalle1.Text = "Detalle";
            //
            // pnl_tarjeta2
            //
            this.pnl_tarjeta2.Controls.Add(this.lbl_titulo2);
            this.pnl_tarjeta2.Controls.Add(this.lbl_valor2);
            this.pnl_tarjeta2.Controls.Add(this.lbl_detalle2);
            this.pnl_tarjeta2.Location = new System.Drawing.Point(270, 70);
            this.pnl_tarjeta2.Name = "pnl_tarjeta2";
            this.pnl_tarjeta2.Size = new System.Drawing.Size(234, 100);
            this.pnl_tarjeta2.TabIndex = 6;
            //
            // lbl_titulo2
            //
            this.lbl_titulo2.AutoSize = true;
            this.lbl_titulo2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_titulo2.Location = new System.Drawing.Point(14, 12);
            this.lbl_titulo2.Name = "lbl_titulo2";
            this.lbl_titulo2.Size = new System.Drawing.Size(120, 15);
            this.lbl_titulo2.Text = "Título";
            //
            // lbl_valor2
            //
            this.lbl_valor2.AutoSize = true;
            this.lbl_valor2.Font = new System.Drawing.Font("Segoe UI Semibold", 20F);
            this.lbl_valor2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(58)))), ((int)(((byte)(92)))));
            this.lbl_valor2.Location = new System.Drawing.Point(11, 30);
            this.lbl_valor2.Name = "lbl_valor2";
            this.lbl_valor2.Size = new System.Drawing.Size(30, 37);
            this.lbl_valor2.Text = "0";
            //
            // lbl_detalle2
            //
            this.lbl_detalle2.AutoSize = true;
            this.lbl_detalle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_detalle2.Location = new System.Drawing.Point(14, 74);
            this.lbl_detalle2.Name = "lbl_detalle2";
            this.lbl_detalle2.Size = new System.Drawing.Size(90, 15);
            this.lbl_detalle2.Text = "Detalle";
            //
            // pnl_tarjeta3
            //
            this.pnl_tarjeta3.Controls.Add(this.lbl_titulo3);
            this.pnl_tarjeta3.Controls.Add(this.lbl_valor3);
            this.pnl_tarjeta3.Controls.Add(this.lbl_detalle3);
            this.pnl_tarjeta3.Location = new System.Drawing.Point(516, 70);
            this.pnl_tarjeta3.Name = "pnl_tarjeta3";
            this.pnl_tarjeta3.Size = new System.Drawing.Size(234, 100);
            this.pnl_tarjeta3.TabIndex = 7;
            //
            // lbl_titulo3
            //
            this.lbl_titulo3.AutoSize = true;
            this.lbl_titulo3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_titulo3.Location = new System.Drawing.Point(14, 12);
            this.lbl_titulo3.Name = "lbl_titulo3";
            this.lbl_titulo3.Size = new System.Drawing.Size(120, 15);
            this.lbl_titulo3.Text = "Título";
            //
            // lbl_valor3
            //
            this.lbl_valor3.AutoSize = true;
            this.lbl_valor3.Font = new System.Drawing.Font("Segoe UI Semibold", 20F);
            this.lbl_valor3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(58)))), ((int)(((byte)(92)))));
            this.lbl_valor3.Location = new System.Drawing.Point(11, 30);
            this.lbl_valor3.Name = "lbl_valor3";
            this.lbl_valor3.Size = new System.Drawing.Size(30, 37);
            this.lbl_valor3.Text = "0";
            //
            // lbl_detalle3
            //
            this.lbl_detalle3.AutoSize = true;
            this.lbl_detalle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_detalle3.Location = new System.Drawing.Point(14, 74);
            this.lbl_detalle3.Name = "lbl_detalle3";
            this.lbl_detalle3.Size = new System.Drawing.Size(90, 15);
            this.lbl_detalle3.Text = "Detalle";
            //
            // pnl_tarjeta4
            //
            this.pnl_tarjeta4.Controls.Add(this.lbl_titulo4);
            this.pnl_tarjeta4.Controls.Add(this.lbl_valor4);
            this.pnl_tarjeta4.Controls.Add(this.lbl_detalle4);
            this.pnl_tarjeta4.Location = new System.Drawing.Point(762, 70);
            this.pnl_tarjeta4.Name = "pnl_tarjeta4";
            this.pnl_tarjeta4.Size = new System.Drawing.Size(234, 100);
            this.pnl_tarjeta4.TabIndex = 8;
            //
            // lbl_titulo4
            //
            this.lbl_titulo4.AutoSize = true;
            this.lbl_titulo4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_titulo4.Location = new System.Drawing.Point(14, 12);
            this.lbl_titulo4.Name = "lbl_titulo4";
            this.lbl_titulo4.Size = new System.Drawing.Size(120, 15);
            this.lbl_titulo4.Text = "Título";
            //
            // lbl_valor4
            //
            this.lbl_valor4.AutoSize = true;
            this.lbl_valor4.Font = new System.Drawing.Font("Segoe UI Semibold", 20F);
            this.lbl_valor4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(58)))), ((int)(((byte)(92)))));
            this.lbl_valor4.Location = new System.Drawing.Point(11, 30);
            this.lbl_valor4.Name = "lbl_valor4";
            this.lbl_valor4.Size = new System.Drawing.Size(30, 37);
            this.lbl_valor4.Text = "0";
            //
            // lbl_detalle4
            //
            this.lbl_detalle4.AutoSize = true;
            this.lbl_detalle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_detalle4.Location = new System.Drawing.Point(14, 74);
            this.lbl_detalle4.Name = "lbl_detalle4";
            this.lbl_detalle4.Size = new System.Drawing.Size(90, 15);
            this.lbl_detalle4.Text = "Detalle";
            //
            // pnl_aviso
            //
            this.pnl_aviso.Controls.Add(this.lbl_aviso);
            this.pnl_aviso.Controls.Add(this.btn_cambiar);
            this.pnl_aviso.Location = new System.Drawing.Point(24, 182);
            this.pnl_aviso.Name = "pnl_aviso";
            this.pnl_aviso.Size = new System.Drawing.Size(972, 48);
            this.pnl_aviso.TabIndex = 9;
            //
            // lbl_aviso
            //
            this.lbl_aviso.AutoSize = true;
            this.lbl_aviso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(0)))));
            this.lbl_aviso.Location = new System.Drawing.Point(16, 16);
            this.lbl_aviso.Name = "lbl_aviso";
            this.lbl_aviso.Size = new System.Drawing.Size(500, 15);
            this.lbl_aviso.Text = "Su contraseña sigue siendo su DNI. Le recomendamos cambiarla para proteger su cuenta.";
            //
            // btn_cambiar
            //
            this.btn_cambiar.Location = new System.Drawing.Point(794, 7);
            this.btn_cambiar.Name = "btn_cambiar";
            this.btn_cambiar.Size = new System.Drawing.Size(164, 34);
            this.btn_cambiar.TabIndex = 0;
            this.btn_cambiar.Text = "Cambiar contraseña";
            this.btn_cambiar.UseVisualStyleBackColor = false;
            this.btn_cambiar.Click += new System.EventHandler(this.btn_mi_cuenta_Click);
            //
            // pnl_alertas
            //
            this.pnl_alertas.Controls.Add(this.lbl_alertas_titulo);
            this.pnl_alertas.Controls.Add(this.lbl_mostrar);
            this.pnl_alertas.Controls.Add(this.cb_aseguradora);
            this.pnl_alertas.Controls.Add(this.dgv_alertas);
            this.pnl_alertas.Controls.Add(this.lbl_cantidad);
            this.pnl_alertas.Location = new System.Drawing.Point(24, 242);
            this.pnl_alertas.Name = "pnl_alertas";
            this.pnl_alertas.Size = new System.Drawing.Size(972, 384);
            this.pnl_alertas.TabIndex = 10;
            //
            // lbl_alertas_titulo
            //
            this.lbl_alertas_titulo.AutoSize = true;
            this.lbl_alertas_titulo.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.lbl_alertas_titulo.Location = new System.Drawing.Point(14, 14);
            this.lbl_alertas_titulo.Name = "lbl_alertas_titulo";
            this.lbl_alertas_titulo.Size = new System.Drawing.Size(280, 20);
            this.lbl_alertas_titulo.Text = "Pólizas por vencer o con cuota impaga";
            //
            // lbl_mostrar
            //
            this.lbl_mostrar.AutoSize = true;
            this.lbl_mostrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_mostrar.Location = new System.Drawing.Point(680, 17);
            this.lbl_mostrar.Name = "lbl_mostrar";
            this.lbl_mostrar.Size = new System.Drawing.Size(50, 15);
            this.lbl_mostrar.Text = "Mostrar";
            //
            // cb_aseguradora
            //
            this.cb_aseguradora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_aseguradora.Location = new System.Drawing.Point(734, 13);
            this.cb_aseguradora.Name = "cb_aseguradora";
            this.cb_aseguradora.Size = new System.Drawing.Size(222, 23);
            this.cb_aseguradora.TabIndex = 0;
            this.cb_aseguradora.SelectedIndexChanged += new System.EventHandler(this.cb_aseguradora_SelectedIndexChanged);
            //
            // dgv_alertas
            //
            this.dgv_alertas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_alertas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.col_nro, this.col_cliente, this.col_dominio, this.col_aseguradora, this.col_vence, this.col_alerta });
            this.dgv_alertas.Location = new System.Drawing.Point(1, 50);
            this.dgv_alertas.Name = "dgv_alertas";
            this.dgv_alertas.Size = new System.Drawing.Size(970, 300);
            this.dgv_alertas.TabIndex = 1;
            this.dgv_alertas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_alertas_CellFormatting);
            this.dgv_alertas.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgv_alertas_DataBindingComplete);
            //
            // col_nro
            //
            this.col_nro.DataPropertyName = "NroTexto";
            this.col_nro.FillWeight = 70F;
            this.col_nro.HeaderText = "N° póliza";
            this.col_nro.Name = "col_nro";
            //
            // col_cliente
            //
            this.col_cliente.DataPropertyName = "Cliente";
            this.col_cliente.FillWeight = 130F;
            this.col_cliente.HeaderText = "Cliente";
            this.col_cliente.Name = "col_cliente";
            //
            // col_dominio
            //
            this.col_dominio.DataPropertyName = "Dominio";
            this.col_dominio.FillWeight = 80F;
            this.col_dominio.HeaderText = "Dominio";
            this.col_dominio.Name = "col_dominio";
            //
            // col_aseguradora
            //
            this.col_aseguradora.DataPropertyName = "Aseguradora";
            this.col_aseguradora.FillWeight = 120F;
            this.col_aseguradora.HeaderText = "Aseguradora";
            this.col_aseguradora.Name = "col_aseguradora";
            //
            // col_vence
            //
            this.col_vence.DataPropertyName = "Vence";
            this.col_vence.DefaultCellStyle = estiloVence;
            this.col_vence.FillWeight = 80F;
            this.col_vence.HeaderText = "Vence";
            this.col_vence.Name = "col_vence";
            //
            // col_alerta
            //
            this.col_alerta.DataPropertyName = "Alerta";
            this.col_alerta.FillWeight = 100F;
            this.col_alerta.HeaderText = "Alerta";
            this.col_alerta.Name = "col_alerta";
            //
            // lbl_cantidad
            //
            this.lbl_cantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_cantidad.AutoSize = true;
            this.lbl_cantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_cantidad.Location = new System.Drawing.Point(16, 358);
            this.lbl_cantidad.Name = "lbl_cantidad";
            this.lbl_cantidad.Size = new System.Drawing.Size(110, 15);
            this.lbl_cantidad.Text = "Mostrando 0 pólizas";
            //
            // Inicio
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1020, 650);
            this.Controls.Add(this.pnl_alertas);
            this.Controls.Add(this.pnl_aviso);
            this.Controls.Add(this.pnl_tarjeta1);
            this.Controls.Add(this.pnl_tarjeta2);
            this.Controls.Add(this.pnl_tarjeta3);
            this.Controls.Add(this.pnl_tarjeta4);
            this.Controls.Add(this.btn_mi_cuenta);
            this.Controls.Add(this.btn_aseguradora);
            this.Controls.Add(this.btn_habilitar);
            this.Controls.Add(this.btn_nueva_poliza);
            this.Controls.Add(this.lbl_titulo);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(56)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.pnl_tarjeta1.ResumeLayout(false);
            this.pnl_tarjeta1.PerformLayout();
            this.pnl_tarjeta2.ResumeLayout(false);
            this.pnl_tarjeta2.PerformLayout();
            this.pnl_tarjeta3.ResumeLayout(false);
            this.pnl_tarjeta3.PerformLayout();
            this.pnl_tarjeta4.ResumeLayout(false);
            this.pnl_tarjeta4.PerformLayout();
            this.pnl_aviso.ResumeLayout(false);
            this.pnl_aviso.PerformLayout();
            this.pnl_alertas.ResumeLayout(false);
            this.pnl_alertas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_alertas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Button btn_nueva_poliza;
        private System.Windows.Forms.Button btn_habilitar;
        private System.Windows.Forms.Button btn_aseguradora;
        private System.Windows.Forms.Button btn_mi_cuenta;
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
        private System.Windows.Forms.Panel pnl_aviso;
        private System.Windows.Forms.Label lbl_aviso;
        private System.Windows.Forms.Button btn_cambiar;
        private System.Windows.Forms.Panel pnl_alertas;
        private System.Windows.Forms.Label lbl_alertas_titulo;
        private System.Windows.Forms.Label lbl_mostrar;
        private System.Windows.Forms.ComboBox cb_aseguradora;
        private System.Windows.Forms.DataGridView dgv_alertas;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_nro;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dominio;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_aseguradora;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_vence;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_alerta;
        private System.Windows.Forms.Label lbl_cantidad;
    }
}
