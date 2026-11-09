namespace FixedSegurosApp.Vistas
{
    partial class PagoTransferencia
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
            this.lbl_resumen = new System.Windows.Forms.Label();
            this.lbl_error = new System.Windows.Forms.Label();
            this.pic_qr = new System.Windows.Forms.PictureBox();
            this.lbl_monto_titulo = new System.Windows.Forms.Label();
            this.lbl_monto = new System.Windows.Forms.Label();
            this.lbl_estado_titulo = new System.Windows.Forms.Label();
            this.lbl_estado = new System.Windows.Forms.Label();
            this.lbl_alias = new System.Windows.Forms.Label();
            this.txt_alias = new System.Windows.Forms.TextBox();
            this.lbl_cbu = new System.Windows.Forms.Label();
            this.txt_cbu = new System.Windows.Forms.TextBox();
            this.lbl_comprobante = new System.Windows.Forms.Label();
            this.btn_subir = new System.Windows.Forms.Button();
            this.lbl_sin_foto = new System.Windows.Forms.Label();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.btn_aceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_qr)).BeginInit();
            this.SuspendLayout();
            //
            // lbl_titulo
            //
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Segoe UI Semibold", 13F);
            this.lbl_titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(58)))), ((int)(((byte)(92)))));
            this.lbl_titulo.Location = new System.Drawing.Point(20, 16);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(185, 25);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Transferencia bancaria";
            //
            // lbl_resumen
            //
            this.lbl_resumen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_resumen.Location = new System.Drawing.Point(22, 48);
            this.lbl_resumen.Name = "lbl_resumen";
            this.lbl_resumen.Size = new System.Drawing.Size(416, 36);
            this.lbl_resumen.TabIndex = 1;
            //
            // lbl_error
            //
            this.lbl_error.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_error.ForeColor = System.Drawing.Color.White;
            this.lbl_error.Location = new System.Drawing.Point(22, 92);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(416, 36);
            this.lbl_error.TabIndex = 2;
            this.lbl_error.Text = "Hubo un error, vuelva a intentarlo más tarde.";
            this.lbl_error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // pic_qr
            //
            this.pic_qr.BackColor = System.Drawing.Color.White;
            this.pic_qr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_qr.Location = new System.Drawing.Point(22, 142);
            this.pic_qr.Name = "pic_qr";
            this.pic_qr.Size = new System.Drawing.Size(150, 150);
            this.pic_qr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic_qr.TabIndex = 3;
            this.pic_qr.TabStop = false;
            //
            // lbl_monto_titulo
            //
            this.lbl_monto_titulo.AutoSize = true;
            this.lbl_monto_titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_monto_titulo.Location = new System.Drawing.Point(190, 142);
            this.lbl_monto_titulo.Name = "lbl_monto_titulo";
            this.lbl_monto_titulo.Size = new System.Drawing.Size(82, 15);
            this.lbl_monto_titulo.TabIndex = 4;
            this.lbl_monto_titulo.Text = "Monto a pagar";
            //
            // lbl_monto
            //
            this.lbl_monto.AutoSize = true;
            this.lbl_monto.Font = new System.Drawing.Font("Segoe UI Semibold", 13F);
            this.lbl_monto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(58)))), ((int)(((byte)(92)))));
            this.lbl_monto.Location = new System.Drawing.Point(188, 160);
            this.lbl_monto.Name = "lbl_monto";
            this.lbl_monto.Size = new System.Drawing.Size(40, 25);
            this.lbl_monto.TabIndex = 5;
            this.lbl_monto.Text = "$ 0";
            //
            // lbl_estado_titulo
            //
            this.lbl_estado_titulo.AutoSize = true;
            this.lbl_estado_titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_estado_titulo.Location = new System.Drawing.Point(190, 194);
            this.lbl_estado_titulo.Name = "lbl_estado_titulo";
            this.lbl_estado_titulo.Size = new System.Drawing.Size(89, 15);
            this.lbl_estado_titulo.TabIndex = 6;
            this.lbl_estado_titulo.Text = "Estado del pago";
            //
            // lbl_estado
            //
            this.lbl_estado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_estado.ForeColor = System.Drawing.Color.White;
            this.lbl_estado.Location = new System.Drawing.Point(190, 212);
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Size = new System.Drawing.Size(96, 22);
            this.lbl_estado.TabIndex = 7;
            this.lbl_estado.Text = "Pendiente";
            this.lbl_estado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // lbl_alias
            //
            this.lbl_alias.AutoSize = true;
            this.lbl_alias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_alias.Location = new System.Drawing.Point(190, 248);
            this.lbl_alias.Name = "lbl_alias";
            this.lbl_alias.Size = new System.Drawing.Size(32, 15);
            this.lbl_alias.TabIndex = 8;
            this.lbl_alias.Text = "Alias";
            //
            // txt_alias
            //
            this.txt_alias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.txt_alias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_alias.Location = new System.Drawing.Point(190, 266);
            this.txt_alias.Name = "txt_alias";
            this.txt_alias.ReadOnly = true;
            this.txt_alias.Size = new System.Drawing.Size(248, 23);
            this.txt_alias.TabIndex = 9;
            this.txt_alias.TabStop = false;
            this.txt_alias.Text = "FIXED.SEGUROS.PAGOS";
            //
            // lbl_cbu
            //
            this.lbl_cbu.AutoSize = true;
            this.lbl_cbu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_cbu.Location = new System.Drawing.Point(22, 304);
            this.lbl_cbu.Name = "lbl_cbu";
            this.lbl_cbu.Size = new System.Drawing.Size(124, 15);
            this.lbl_cbu.TabIndex = 10;
            this.lbl_cbu.Text = "CBU (cuenta de prueba)";
            //
            // txt_cbu
            //
            this.txt_cbu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.txt_cbu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_cbu.Location = new System.Drawing.Point(22, 322);
            this.txt_cbu.Name = "txt_cbu";
            this.txt_cbu.ReadOnly = true;
            this.txt_cbu.Size = new System.Drawing.Size(416, 23);
            this.txt_cbu.TabIndex = 11;
            this.txt_cbu.TabStop = false;
            this.txt_cbu.Text = "0000000000000000000000";
            //
            // lbl_comprobante
            //
            this.lbl_comprobante.AutoSize = true;
            this.lbl_comprobante.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_comprobante.Location = new System.Drawing.Point(22, 356);
            this.lbl_comprobante.Name = "lbl_comprobante";
            this.lbl_comprobante.Size = new System.Drawing.Size(180, 15);
            this.lbl_comprobante.TabIndex = 12;
            this.lbl_comprobante.Text = "Comprobante de la transferencia";
            //
            // btn_subir
            //
            this.btn_subir.Enabled = false;
            this.btn_subir.Location = new System.Drawing.Point(22, 374);
            this.btn_subir.Name = "btn_subir";
            this.btn_subir.Size = new System.Drawing.Size(200, 32);
            this.btn_subir.TabIndex = 13;
            this.btn_subir.Text = "Subir foto del comprobante";
            this.btn_subir.UseVisualStyleBackColor = false;
            //
            // lbl_sin_foto
            //
            this.lbl_sin_foto.AutoSize = true;
            this.lbl_sin_foto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_sin_foto.Location = new System.Drawing.Point(232, 382);
            this.lbl_sin_foto.Name = "lbl_sin_foto";
            this.lbl_sin_foto.Size = new System.Drawing.Size(97, 15);
            this.lbl_sin_foto.TabIndex = 14;
            this.lbl_sin_foto.Text = "Sin foto cargada.";
            //
            // btn_cerrar
            //
            this.btn_cerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cerrar.Location = new System.Drawing.Point(218, 418);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(110, 34);
            this.btn_cerrar.TabIndex = 15;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = false;
            //
            // btn_aceptar
            //
            this.btn_aceptar.Enabled = false;
            this.btn_aceptar.Location = new System.Drawing.Point(334, 418);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(104, 34);
            this.btn_aceptar.TabIndex = 16;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = false;
            //
            // PagoTransferencia
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btn_cerrar;
            this.ClientSize = new System.Drawing.Size(460, 466);
            this.ControlBox = false;
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.lbl_sin_foto);
            this.Controls.Add(this.btn_subir);
            this.Controls.Add(this.lbl_comprobante);
            this.Controls.Add(this.txt_cbu);
            this.Controls.Add(this.lbl_cbu);
            this.Controls.Add(this.txt_alias);
            this.Controls.Add(this.lbl_alias);
            this.Controls.Add(this.lbl_estado);
            this.Controls.Add(this.lbl_estado_titulo);
            this.Controls.Add(this.lbl_monto);
            this.Controls.Add(this.lbl_monto_titulo);
            this.Controls.Add(this.pic_qr);
            this.Controls.Add(this.lbl_error);
            this.Controls.Add(this.lbl_resumen);
            this.Controls.Add(this.lbl_titulo);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(56)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PagoTransferencia";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Fixed Seguros: Pagar cuota";
            this.Load += new System.EventHandler(this.PagoTransferencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_qr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_resumen;
        private System.Windows.Forms.Label lbl_error;
        private System.Windows.Forms.PictureBox pic_qr;
        private System.Windows.Forms.Label lbl_monto_titulo;
        private System.Windows.Forms.Label lbl_monto;
        private System.Windows.Forms.Label lbl_estado_titulo;
        private System.Windows.Forms.Label lbl_estado;
        private System.Windows.Forms.Label lbl_alias;
        private System.Windows.Forms.TextBox txt_alias;
        private System.Windows.Forms.Label lbl_cbu;
        private System.Windows.Forms.TextBox txt_cbu;
        private System.Windows.Forms.Label lbl_comprobante;
        private System.Windows.Forms.Button btn_subir;
        private System.Windows.Forms.Label lbl_sin_foto;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Button btn_aceptar;
    }
}
