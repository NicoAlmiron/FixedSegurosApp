namespace FixedSegurosApp.Vistas
{
    partial class Notificaciones
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
            System.Windows.Forms.DataGridViewCellStyle estiloFecha = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle estiloTipo = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle estiloMensaje = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.pnl_lista = new System.Windows.Forms.Panel();
            this.lbl_filtro = new System.Windows.Forms.Label();
            this.cb_tipo = new System.Windows.Forms.ComboBox();
            this.chk_nuevas = new System.Windows.Forms.CheckBox();
            this.dgv_notificaciones = new System.Windows.Forms.DataGridView();
            this.col_fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_mensaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_leida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_ayuda = new System.Windows.Forms.Label();
            this.pnl_detalle = new System.Windows.Forms.Panel();
            this.lbl_detalle_titulo = new System.Windows.Forms.Label();
            this.pnl_linea_detalle = new System.Windows.Forms.Panel();
            this.lbl_cliente = new System.Windows.Forms.Label();
            this.txt_cliente = new System.Windows.Forms.TextBox();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.txt_fecha = new System.Windows.Forms.TextBox();
            this.lbl_tipo = new System.Windows.Forms.Label();
            this.txt_tipo = new System.Windows.Forms.TextBox();
            this.lbl_mensaje = new System.Windows.Forms.Label();
            this.txt_mensaje = new System.Windows.Forms.TextBox();
            this.lbl_estado = new System.Windows.Forms.Label();
            this.pnl_linea_pie = new System.Windows.Forms.Panel();
            this.btn_ver = new System.Windows.Forms.Button();
            this.pnl_lista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_notificaciones)).BeginInit();
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
            this.lbl_titulo.Size = new System.Drawing.Size(158, 30);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Notificaciones";
            //
            // pnl_lista
            //
            this.pnl_lista.Controls.Add(this.lbl_filtro);
            this.pnl_lista.Controls.Add(this.cb_tipo);
            this.pnl_lista.Controls.Add(this.chk_nuevas);
            this.pnl_lista.Controls.Add(this.dgv_notificaciones);
            this.pnl_lista.Controls.Add(this.lbl_ayuda);
            this.pnl_lista.Location = new System.Drawing.Point(24, 70);
            this.pnl_lista.Name = "pnl_lista";
            this.pnl_lista.Size = new System.Drawing.Size(584, 636);
            this.pnl_lista.TabIndex = 1;
            //
            // lbl_filtro
            //
            this.lbl_filtro.AutoSize = true;
            this.lbl_filtro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_filtro.Location = new System.Drawing.Point(16, 19);
            this.lbl_filtro.Name = "lbl_filtro";
            this.lbl_filtro.Size = new System.Drawing.Size(30, 15);
            this.lbl_filtro.Text = "Tipo";
            //
            // cb_tipo
            //
            this.cb_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_tipo.Location = new System.Drawing.Point(54, 15);
            this.cb_tipo.Name = "cb_tipo";
            this.cb_tipo.Size = new System.Drawing.Size(170, 23);
            this.cb_tipo.TabIndex = 0;
            this.cb_tipo.SelectedIndexChanged += new System.EventHandler(this.cb_tipo_SelectedIndexChanged);
            //
            // chk_nuevas
            //
            this.chk_nuevas.AutoSize = true;
            this.chk_nuevas.Location = new System.Drawing.Point(242, 17);
            this.chk_nuevas.Name = "chk_nuevas";
            this.chk_nuevas.Size = new System.Drawing.Size(103, 19);
            this.chk_nuevas.TabIndex = 1;
            this.chk_nuevas.Text = "Solo no leídas";
            this.chk_nuevas.CheckedChanged += new System.EventHandler(this.chk_nuevas_CheckedChanged);
            //
            // dgv_notificaciones
            //
            this.dgv_notificaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_fecha,
            this.col_cliente,
            this.col_tipo,
            this.col_mensaje,
            this.col_leida});
            this.dgv_notificaciones.Location = new System.Drawing.Point(1, 50);
            this.dgv_notificaciones.Name = "dgv_notificaciones";
            this.dgv_notificaciones.Size = new System.Drawing.Size(582, 544);
            this.dgv_notificaciones.TabIndex = 2;
            this.dgv_notificaciones.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_notificaciones_CellFormatting);
            this.dgv_notificaciones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_notificaciones_CellClick);
            this.dgv_notificaciones.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgv_notificaciones_DataBindingComplete);
            //
            // col_fecha
            //
            this.col_fecha.DataPropertyName = "FechaEnvio";
            estiloFecha.Format = "dd/MM/yyyy";
            this.col_fecha.DefaultCellStyle = estiloFecha;
            this.col_fecha.FillWeight = 72F;
            this.col_fecha.HeaderText = "Fecha";
            this.col_fecha.Name = "col_fecha";
            //
            // col_cliente
            //
            this.col_cliente.DataPropertyName = "Cliente";
            this.col_cliente.FillWeight = 95F;
            this.col_cliente.HeaderText = "Cliente";
            this.col_cliente.Name = "col_cliente";
            //
            // col_tipo
            //
            this.col_tipo.DataPropertyName = "Tipo";
            estiloTipo.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.col_tipo.DefaultCellStyle = estiloTipo;
            this.col_tipo.FillWeight = 72F;
            this.col_tipo.HeaderText = "Tipo";
            this.col_tipo.Name = "col_tipo";
            //
            // col_mensaje
            //
            this.col_mensaje.DataPropertyName = "Mensaje";
            estiloMensaje.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.col_mensaje.DefaultCellStyle = estiloMensaje;
            this.col_mensaje.FillWeight = 190F;
            this.col_mensaje.HeaderText = "Mensaje";
            this.col_mensaje.Name = "col_mensaje";
            //
            // col_leida
            //
            this.col_leida.DataPropertyName = "LeidaTexto";
            this.col_leida.FillWeight = 42F;
            this.col_leida.HeaderText = "Leída";
            this.col_leida.Name = "col_leida";
            //
            // lbl_ayuda
            //
            this.lbl_ayuda.AutoSize = true;
            this.lbl_ayuda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_ayuda.Location = new System.Drawing.Point(16, 606);
            this.lbl_ayuda.Name = "lbl_ayuda";
            this.lbl_ayuda.Size = new System.Drawing.Size(203, 15);
            this.lbl_ayuda.Text = "Las no leídas se muestran en negrita";
            //
            // pnl_detalle
            //
            this.pnl_detalle.Controls.Add(this.lbl_detalle_titulo);
            this.pnl_detalle.Controls.Add(this.pnl_linea_detalle);
            this.pnl_detalle.Controls.Add(this.lbl_cliente);
            this.pnl_detalle.Controls.Add(this.txt_cliente);
            this.pnl_detalle.Controls.Add(this.lbl_fecha);
            this.pnl_detalle.Controls.Add(this.txt_fecha);
            this.pnl_detalle.Controls.Add(this.lbl_tipo);
            this.pnl_detalle.Controls.Add(this.txt_tipo);
            this.pnl_detalle.Controls.Add(this.lbl_mensaje);
            this.pnl_detalle.Controls.Add(this.txt_mensaje);
            this.pnl_detalle.Controls.Add(this.lbl_estado);
            this.pnl_detalle.Controls.Add(this.pnl_linea_pie);
            this.pnl_detalle.Controls.Add(this.btn_ver);
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
            this.lbl_detalle_titulo.Size = new System.Drawing.Size(55, 20);
            this.lbl_detalle_titulo.Text = "Detalle";
            //
            // pnl_linea_detalle
            //
            this.pnl_linea_detalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(221)))), ((int)(((byte)(232)))));
            this.pnl_linea_detalle.Location = new System.Drawing.Point(1, 54);
            this.pnl_linea_detalle.Name = "pnl_linea_detalle";
            this.pnl_linea_detalle.Size = new System.Drawing.Size(374, 1);
            this.pnl_linea_detalle.TabIndex = 20;
            //
            // lbl_cliente
            //
            this.lbl_cliente.AutoSize = true;
            this.lbl_cliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_cliente.Location = new System.Drawing.Point(16, 66);
            this.lbl_cliente.Name = "lbl_cliente";
            this.lbl_cliente.Size = new System.Drawing.Size(44, 15);
            this.lbl_cliente.Text = "Cliente";
            //
            // txt_cliente
            //
            this.txt_cliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.txt_cliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_cliente.Location = new System.Drawing.Point(16, 84);
            this.txt_cliente.Name = "txt_cliente";
            this.txt_cliente.ReadOnly = true;
            this.txt_cliente.Size = new System.Drawing.Size(168, 23);
            this.txt_cliente.TabStop = false;
            //
            // lbl_fecha
            //
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_fecha.Location = new System.Drawing.Point(192, 66);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(84, 15);
            this.lbl_fecha.Text = "Fecha de envío";
            //
            // txt_fecha
            //
            this.txt_fecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.txt_fecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_fecha.Location = new System.Drawing.Point(192, 84);
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.ReadOnly = true;
            this.txt_fecha.Size = new System.Drawing.Size(168, 23);
            this.txt_fecha.TabStop = false;
            //
            // lbl_tipo
            //
            this.lbl_tipo.AutoSize = true;
            this.lbl_tipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_tipo.Location = new System.Drawing.Point(16, 120);
            this.lbl_tipo.Name = "lbl_tipo";
            this.lbl_tipo.Size = new System.Drawing.Size(30, 15);
            this.lbl_tipo.Text = "Tipo";
            //
            // txt_tipo
            //
            this.txt_tipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.txt_tipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_tipo.Location = new System.Drawing.Point(16, 138);
            this.txt_tipo.Name = "txt_tipo";
            this.txt_tipo.ReadOnly = true;
            this.txt_tipo.Size = new System.Drawing.Size(344, 23);
            this.txt_tipo.TabStop = false;
            //
            // lbl_mensaje
            //
            this.lbl_mensaje.AutoSize = true;
            this.lbl_mensaje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_mensaje.Location = new System.Drawing.Point(16, 174);
            this.lbl_mensaje.Name = "lbl_mensaje";
            this.lbl_mensaje.Size = new System.Drawing.Size(51, 15);
            this.lbl_mensaje.Text = "Mensaje";
            //
            // txt_mensaje
            //
            this.txt_mensaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.txt_mensaje.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_mensaje.Location = new System.Drawing.Point(16, 192);
            this.txt_mensaje.Multiline = true;
            this.txt_mensaje.Name = "txt_mensaje";
            this.txt_mensaje.ReadOnly = true;
            this.txt_mensaje.Size = new System.Drawing.Size(344, 150);
            this.txt_mensaje.TabStop = false;
            //
            // lbl_estado
            //
            this.lbl_estado.AutoSize = true;
            this.lbl_estado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_estado.Location = new System.Drawing.Point(16, 356);
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Size = new System.Drawing.Size(47, 15);
            this.lbl_estado.Text = "Estado:";
            //
            // pnl_linea_pie
            //
            this.pnl_linea_pie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(221)))), ((int)(((byte)(232)))));
            this.pnl_linea_pie.Location = new System.Drawing.Point(1, 572);
            this.pnl_linea_pie.Name = "pnl_linea_pie";
            this.pnl_linea_pie.Size = new System.Drawing.Size(374, 1);
            this.pnl_linea_pie.TabIndex = 21;
            //
            // btn_ver
            //
            this.btn_ver.Location = new System.Drawing.Point(16, 586);
            this.btn_ver.Name = "btn_ver";
            this.btn_ver.Size = new System.Drawing.Size(200, 34);
            this.btn_ver.TabIndex = 0;
            this.btn_ver.Text = "Ver póliza";
            this.btn_ver.UseVisualStyleBackColor = false;
            this.btn_ver.Click += new System.EventHandler(this.btn_ver_Click);
            //
            // Notificaciones
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
            this.Name = "Notificaciones";
            this.Text = "Notificaciones";
            this.Load += new System.EventHandler(this.Notificaciones_Load);
            this.pnl_lista.ResumeLayout(false);
            this.pnl_lista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_notificaciones)).EndInit();
            this.pnl_detalle.ResumeLayout(false);
            this.pnl_detalle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Panel pnl_lista;
        private System.Windows.Forms.Label lbl_filtro;
        private System.Windows.Forms.ComboBox cb_tipo;
        private System.Windows.Forms.CheckBox chk_nuevas;
        private System.Windows.Forms.DataGridView dgv_notificaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_mensaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_leida;
        private System.Windows.Forms.Label lbl_ayuda;
        private System.Windows.Forms.Panel pnl_detalle;
        private System.Windows.Forms.Label lbl_detalle_titulo;
        private System.Windows.Forms.Panel pnl_linea_detalle;
        private System.Windows.Forms.Label lbl_cliente;
        private System.Windows.Forms.TextBox txt_cliente;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.TextBox txt_fecha;
        private System.Windows.Forms.Label lbl_tipo;
        private System.Windows.Forms.TextBox txt_tipo;
        private System.Windows.Forms.Label lbl_mensaje;
        private System.Windows.Forms.TextBox txt_mensaje;
        private System.Windows.Forms.Label lbl_estado;
        private System.Windows.Forms.Panel pnl_linea_pie;
        private System.Windows.Forms.Button btn_ver;
    }
}
