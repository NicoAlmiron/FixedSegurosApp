namespace FixedSegurosApp.Vistas
{
    partial class PagoEfectivo
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
            this.lbl_monto = new System.Windows.Forms.Label();
            this.txt_monto = new System.Windows.Forms.TextBox();
            this.lbl_recibido = new System.Windows.Forms.Label();
            this.txt_recibido = new System.Windows.Forms.TextBox();
            this.lbl_vuelto = new System.Windows.Forms.Label();
            this.txt_vuelto = new System.Windows.Forms.TextBox();
            this.lbl_aviso = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_finalizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // lbl_titulo
            //
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Segoe UI Semibold", 13F);
            this.lbl_titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(58)))), ((int)(((byte)(92)))));
            this.lbl_titulo.Location = new System.Drawing.Point(20, 16);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(146, 25);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Cobro en efectivo";
            //
            // lbl_resumen
            //
            this.lbl_resumen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_resumen.Location = new System.Drawing.Point(22, 48);
            this.lbl_resumen.Name = "lbl_resumen";
            this.lbl_resumen.Size = new System.Drawing.Size(396, 36);
            this.lbl_resumen.TabIndex = 1;
            //
            // lbl_monto
            //
            this.lbl_monto.AutoSize = true;
            this.lbl_monto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_monto.Location = new System.Drawing.Point(22, 94);
            this.lbl_monto.Name = "lbl_monto";
            this.lbl_monto.Size = new System.Drawing.Size(101, 15);
            this.lbl_monto.TabIndex = 2;
            this.lbl_monto.Text = "Monto de la cuota";
            //
            // txt_monto
            //
            this.txt_monto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.txt_monto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_monto.Location = new System.Drawing.Point(22, 112);
            this.txt_monto.Name = "txt_monto";
            this.txt_monto.ReadOnly = true;
            this.txt_monto.Size = new System.Drawing.Size(190, 23);
            this.txt_monto.TabIndex = 3;
            this.txt_monto.TabStop = false;
            //
            // lbl_recibido
            //
            this.lbl_recibido.AutoSize = true;
            this.lbl_recibido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_recibido.Location = new System.Drawing.Point(228, 94);
            this.lbl_recibido.Name = "lbl_recibido";
            this.lbl_recibido.Size = new System.Drawing.Size(88, 15);
            this.lbl_recibido.TabIndex = 4;
            this.lbl_recibido.Text = "Monto recibido";
            //
            // txt_recibido
            //
            this.txt_recibido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_recibido.Location = new System.Drawing.Point(228, 112);
            this.txt_recibido.Name = "txt_recibido";
            this.txt_recibido.Size = new System.Drawing.Size(190, 23);
            this.txt_recibido.TabIndex = 5;
            this.txt_recibido.TextChanged += new System.EventHandler(this.txt_recibido_TextChanged);
            //
            // lbl_vuelto
            //
            this.lbl_vuelto.AutoSize = true;
            this.lbl_vuelto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_vuelto.Location = new System.Drawing.Point(22, 148);
            this.lbl_vuelto.Name = "lbl_vuelto";
            this.lbl_vuelto.Size = new System.Drawing.Size(40, 15);
            this.lbl_vuelto.TabIndex = 6;
            this.lbl_vuelto.Text = "Vuelto";
            //
            // txt_vuelto
            //
            this.txt_vuelto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.txt_vuelto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_vuelto.Location = new System.Drawing.Point(22, 166);
            this.txt_vuelto.Name = "txt_vuelto";
            this.txt_vuelto.ReadOnly = true;
            this.txt_vuelto.Size = new System.Drawing.Size(190, 23);
            this.txt_vuelto.TabIndex = 7;
            this.txt_vuelto.TabStop = false;
            //
            // lbl_aviso
            //
            this.lbl_aviso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_aviso.Location = new System.Drawing.Point(22, 204);
            this.lbl_aviso.Name = "lbl_aviso";
            this.lbl_aviso.Size = new System.Drawing.Size(396, 54);
            this.lbl_aviso.TabIndex = 8;
            //
            // btn_cancelar
            //
            this.btn_cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancelar.Location = new System.Drawing.Point(182, 276);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(110, 34);
            this.btn_cancelar.TabIndex = 10;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            //
            // btn_finalizar
            //
            this.btn_finalizar.Location = new System.Drawing.Point(298, 276);
            this.btn_finalizar.Name = "btn_finalizar";
            this.btn_finalizar.Size = new System.Drawing.Size(120, 34);
            this.btn_finalizar.TabIndex = 9;
            this.btn_finalizar.Text = "Finalizar pago";
            this.btn_finalizar.UseVisualStyleBackColor = false;
            this.btn_finalizar.Click += new System.EventHandler(this.btn_finalizar_Click);
            //
            // PagoEfectivo
            //
            this.AcceptButton = this.btn_finalizar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btn_cancelar;
            this.ClientSize = new System.Drawing.Size(440, 326);
            this.ControlBox = false;
            this.Controls.Add(this.btn_finalizar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.lbl_aviso);
            this.Controls.Add(this.txt_vuelto);
            this.Controls.Add(this.lbl_vuelto);
            this.Controls.Add(this.txt_recibido);
            this.Controls.Add(this.lbl_recibido);
            this.Controls.Add(this.txt_monto);
            this.Controls.Add(this.lbl_monto);
            this.Controls.Add(this.lbl_resumen);
            this.Controls.Add(this.lbl_titulo);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(56)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PagoEfectivo";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Fixed Seguros: Cobro en efectivo";
            this.Load += new System.EventHandler(this.PagoEfectivo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_resumen;
        private System.Windows.Forms.Label lbl_monto;
        private System.Windows.Forms.TextBox txt_monto;
        private System.Windows.Forms.Label lbl_recibido;
        private System.Windows.Forms.TextBox txt_recibido;
        private System.Windows.Forms.Label lbl_vuelto;
        private System.Windows.Forms.TextBox txt_vuelto;
        private System.Windows.Forms.Label lbl_aviso;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_finalizar;
    }
}
