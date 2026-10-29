namespace FixedSegurosApp.Vistas
{
    partial class HistorialAcciones
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
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.btn_volver = new System.Windows.Forms.Button();
            this.pnl_filtros = new System.Windows.Forms.Panel();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.lbl_modulo = new System.Windows.Forms.Label();
            this.cb_modulo = new System.Windows.Forms.ComboBox();
            this.lbl_desde = new System.Windows.Forms.Label();
            this.dtp_desde = new System.Windows.Forms.DateTimePicker();
            this.lbl_hasta = new System.Windows.Forms.Label();
            this.dtp_hasta = new System.Windows.Forms.DateTimePicker();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.dgv_acciones = new System.Windows.Forms.DataGridView();
            this.col_fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_perfil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_modulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_operacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_detalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_cantidad = new System.Windows.Forms.Label();
            this.pnl_filtros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_acciones)).BeginInit();
            this.SuspendLayout();
            //
            // lbl_titulo
            //
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Segoe UI Semibold", 16F);
            this.lbl_titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(58)))), ((int)(((byte)(92)))));
            this.lbl_titulo.Location = new System.Drawing.Point(20, 20);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(331, 30);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Usuarios › Historial de acciones";
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
            // pnl_filtros
            //
            this.pnl_filtros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_filtros.Controls.Add(this.lbl_usuario);
            this.pnl_filtros.Controls.Add(this.txt_usuario);
            this.pnl_filtros.Controls.Add(this.lbl_modulo);
            this.pnl_filtros.Controls.Add(this.cb_modulo);
            this.pnl_filtros.Controls.Add(this.lbl_desde);
            this.pnl_filtros.Controls.Add(this.dtp_desde);
            this.pnl_filtros.Controls.Add(this.lbl_hasta);
            this.pnl_filtros.Controls.Add(this.dtp_hasta);
            this.pnl_filtros.Controls.Add(this.btn_buscar);
            this.pnl_filtros.Controls.Add(this.btn_limpiar);
            this.pnl_filtros.Location = new System.Drawing.Point(24, 70);
            this.pnl_filtros.Name = "pnl_filtros";
            this.pnl_filtros.Size = new System.Drawing.Size(972, 76);
            this.pnl_filtros.TabIndex = 2;
            //
            // lbl_usuario
            //
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_usuario.Location = new System.Drawing.Point(16, 12);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(150, 15);
            this.lbl_usuario.Text = "Usuario (legajo o apellido)";
            //
            // txt_usuario
            //
            this.txt_usuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_usuario.Location = new System.Drawing.Point(16, 34);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(220, 23);
            this.txt_usuario.TabIndex = 0;
            //
            // lbl_modulo
            //
            this.lbl_modulo.AutoSize = true;
            this.lbl_modulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_modulo.Location = new System.Drawing.Point(250, 12);
            this.lbl_modulo.Name = "lbl_modulo";
            this.lbl_modulo.Size = new System.Drawing.Size(49, 15);
            this.lbl_modulo.Text = "Módulo";
            //
            // cb_modulo
            //
            this.cb_modulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_modulo.Location = new System.Drawing.Point(250, 34);
            this.cb_modulo.Name = "cb_modulo";
            this.cb_modulo.Size = new System.Drawing.Size(200, 23);
            this.cb_modulo.TabIndex = 1;
            //
            // lbl_desde
            //
            this.lbl_desde.AutoSize = true;
            this.lbl_desde.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_desde.Location = new System.Drawing.Point(464, 12);
            this.lbl_desde.Name = "lbl_desde";
            this.lbl_desde.Size = new System.Drawing.Size(39, 15);
            this.lbl_desde.Text = "Desde";
            //
            // dtp_desde
            //
            this.dtp_desde.CustomFormat = "dd/MM/yyyy";
            this.dtp_desde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_desde.Location = new System.Drawing.Point(464, 34);
            this.dtp_desde.Name = "dtp_desde";
            this.dtp_desde.Size = new System.Drawing.Size(130, 23);
            this.dtp_desde.TabIndex = 2;
            //
            // lbl_hasta
            //
            this.lbl_hasta.AutoSize = true;
            this.lbl_hasta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_hasta.Location = new System.Drawing.Point(608, 12);
            this.lbl_hasta.Name = "lbl_hasta";
            this.lbl_hasta.Size = new System.Drawing.Size(37, 15);
            this.lbl_hasta.Text = "Hasta";
            //
            // dtp_hasta
            //
            this.dtp_hasta.CustomFormat = "dd/MM/yyyy";
            this.dtp_hasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_hasta.Location = new System.Drawing.Point(608, 34);
            this.dtp_hasta.Name = "dtp_hasta";
            this.dtp_hasta.Size = new System.Drawing.Size(130, 23);
            this.dtp_hasta.TabIndex = 3;
            //
            // btn_buscar
            //
            this.btn_buscar.Location = new System.Drawing.Point(752, 30);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(98, 30);
            this.btn_buscar.TabIndex = 4;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            //
            // btn_limpiar
            //
            this.btn_limpiar.Location = new System.Drawing.Point(858, 30);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(98, 30);
            this.btn_limpiar.TabIndex = 5;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = false;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            //
            // dgv_acciones
            //
            this.dgv_acciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_acciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_fecha,
            this.col_usuario,
            this.col_perfil,
            this.col_modulo,
            this.col_operacion,
            this.col_detalle});
            this.dgv_acciones.Location = new System.Drawing.Point(24, 162);
            this.dgv_acciones.Name = "dgv_acciones";
            this.dgv_acciones.Size = new System.Drawing.Size(972, 516);
            this.dgv_acciones.TabIndex = 3;
            //
            // col_fecha
            //
            this.col_fecha.DataPropertyName = "Fecha";
            estiloFecha.Format = "dd/MM/yyyy HH:mm";
            this.col_fecha.DefaultCellStyle = estiloFecha;
            this.col_fecha.FillWeight = 110F;
            this.col_fecha.HeaderText = "Fecha y hora";
            this.col_fecha.Name = "col_fecha";
            //
            // col_usuario
            //
            this.col_usuario.DataPropertyName = "Usuario";
            this.col_usuario.FillWeight = 120F;
            this.col_usuario.HeaderText = "Usuario";
            this.col_usuario.Name = "col_usuario";
            //
            // col_perfil
            //
            this.col_perfil.DataPropertyName = "Perfil";
            this.col_perfil.FillWeight = 90F;
            this.col_perfil.HeaderText = "Perfil";
            this.col_perfil.Name = "col_perfil";
            //
            // col_modulo
            //
            this.col_modulo.DataPropertyName = "Modulo";
            this.col_modulo.FillWeight = 90F;
            this.col_modulo.HeaderText = "Módulo";
            this.col_modulo.Name = "col_modulo";
            //
            // col_operacion
            //
            this.col_operacion.DataPropertyName = "Operacion";
            this.col_operacion.FillWeight = 130F;
            this.col_operacion.HeaderText = "Acción";
            this.col_operacion.Name = "col_operacion";
            //
            // col_detalle
            //
            this.col_detalle.DataPropertyName = "Detalle";
            this.col_detalle.FillWeight = 140F;
            this.col_detalle.HeaderText = "Detalle";
            this.col_detalle.Name = "col_detalle";
            //
            // lbl_cantidad
            //
            this.lbl_cantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_cantidad.AutoSize = true;
            this.lbl_cantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_cantidad.Location = new System.Drawing.Point(24, 692);
            this.lbl_cantidad.Name = "lbl_cantidad";
            this.lbl_cantidad.Size = new System.Drawing.Size(117, 15);
            this.lbl_cantidad.TabIndex = 4;
            this.lbl_cantidad.Text = "Mostrando 0 acciones";
            //
            // HistorialAcciones
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1020, 730);
            this.Controls.Add(this.lbl_cantidad);
            this.Controls.Add(this.dgv_acciones);
            this.Controls.Add(this.pnl_filtros);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.lbl_titulo);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(56)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HistorialAcciones";
            this.Text = "Historial de acciones";
            this.Load += new System.EventHandler(this.HistorialAcciones_Load);
            this.pnl_filtros.ResumeLayout(false);
            this.pnl_filtros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_acciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.Panel pnl_filtros;
        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.Label lbl_modulo;
        private System.Windows.Forms.ComboBox cb_modulo;
        private System.Windows.Forms.Label lbl_desde;
        private System.Windows.Forms.DateTimePicker dtp_desde;
        private System.Windows.Forms.Label lbl_hasta;
        private System.Windows.Forms.DateTimePicker dtp_hasta;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.DataGridView dgv_acciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_perfil;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_modulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_operacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_detalle;
        private System.Windows.Forms.Label lbl_cantidad;
    }
}
