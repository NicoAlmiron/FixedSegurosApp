namespace FixedSegurosApp.Vistas
{
    partial class ActualizarVtv
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.lbl_vehiculo = new System.Windows.Forms.Label();
            this.lbl_vigencia = new System.Windows.Forms.Label();
            this.dtp_vigencia = new System.Windows.Forms.DateTimePicker();
            this.btn_foto = new System.Windows.Forms.Button();
            this.pic_foto = new System.Windows.Forms.PictureBox();
            this.lbl_aviso = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_enviar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_foto)).BeginInit();
            this.SuspendLayout();
            //
            // lbl_titulo
            //
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Segoe UI Semibold", 13F);
            this.lbl_titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(58)))), ((int)(((byte)(92)))));
            this.lbl_titulo.Location = new System.Drawing.Point(20, 16);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(120, 25);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Actualizar VTV";
            //
            // lbl_vehiculo
            //
            this.lbl_vehiculo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_vehiculo.Location = new System.Drawing.Point(22, 48);
            this.lbl_vehiculo.Name = "lbl_vehiculo";
            this.lbl_vehiculo.Size = new System.Drawing.Size(396, 36);
            this.lbl_vehiculo.TabIndex = 1;
            //
            // lbl_vigencia
            //
            this.lbl_vigencia.AutoSize = true;
            this.lbl_vigencia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_vigencia.Location = new System.Drawing.Point(22, 94);
            this.lbl_vigencia.Name = "lbl_vigencia";
            this.lbl_vigencia.Size = new System.Drawing.Size(94, 15);
            this.lbl_vigencia.TabIndex = 2;
            this.lbl_vigencia.Text = "Nueva vigencia";
            //
            // dtp_vigencia
            //
            this.dtp_vigencia.CustomFormat = "dd/MM/yyyy";
            this.dtp_vigencia.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_vigencia.Location = new System.Drawing.Point(22, 112);
            this.dtp_vigencia.Name = "dtp_vigencia";
            this.dtp_vigencia.Size = new System.Drawing.Size(164, 23);
            this.dtp_vigencia.TabIndex = 3;
            //
            // btn_foto
            //
            this.btn_foto.Location = new System.Drawing.Point(22, 148);
            this.btn_foto.Name = "btn_foto";
            this.btn_foto.Size = new System.Drawing.Size(164, 32);
            this.btn_foto.TabIndex = 4;
            this.btn_foto.Text = "Elegir foto de la VTV";
            this.btn_foto.UseVisualStyleBackColor = false;
            this.btn_foto.Click += new System.EventHandler(this.btn_foto_Click);
            //
            // pic_foto
            //
            this.pic_foto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.pic_foto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_foto.Location = new System.Drawing.Point(204, 94);
            this.pic_foto.Name = "pic_foto";
            this.pic_foto.Size = new System.Drawing.Size(214, 150);
            this.pic_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_foto.TabIndex = 5;
            this.pic_foto.TabStop = false;
            //
            // lbl_aviso
            //
            this.lbl_aviso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_aviso.Location = new System.Drawing.Point(22, 192);
            this.lbl_aviso.Name = "lbl_aviso";
            this.lbl_aviso.Size = new System.Drawing.Size(170, 60);
            this.lbl_aviso.TabIndex = 6;
            //
            // btn_cancelar
            //
            this.btn_cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancelar.Location = new System.Drawing.Point(198, 262);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(110, 34);
            this.btn_cancelar.TabIndex = 8;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            //
            // btn_enviar
            //
            this.btn_enviar.Location = new System.Drawing.Point(314, 262);
            this.btn_enviar.Name = "btn_enviar";
            this.btn_enviar.Size = new System.Drawing.Size(104, 34);
            this.btn_enviar.TabIndex = 7;
            this.btn_enviar.Text = "Enviar";
            this.btn_enviar.UseVisualStyleBackColor = false;
            this.btn_enviar.Click += new System.EventHandler(this.btn_enviar_Click);
            //
            // ActualizarVtv
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btn_cancelar;
            this.ClientSize = new System.Drawing.Size(440, 312);
            this.ControlBox = false;
            this.Controls.Add(this.btn_enviar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.lbl_aviso);
            this.Controls.Add(this.pic_foto);
            this.Controls.Add(this.btn_foto);
            this.Controls.Add(this.dtp_vigencia);
            this.Controls.Add(this.lbl_vigencia);
            this.Controls.Add(this.lbl_vehiculo);
            this.Controls.Add(this.lbl_titulo);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(56)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ActualizarVtv";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Fixed Seguros: Actualizar VTV";
            ((System.ComponentModel.ISupportInitialize)(this.pic_foto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_vehiculo;
        private System.Windows.Forms.Label lbl_vigencia;
        private System.Windows.Forms.DateTimePicker dtp_vigencia;
        private System.Windows.Forms.Button btn_foto;
        private System.Windows.Forms.PictureBox pic_foto;
        private System.Windows.Forms.Label lbl_aviso;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_enviar;
    }
}
