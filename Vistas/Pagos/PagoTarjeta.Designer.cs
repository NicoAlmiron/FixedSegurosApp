namespace FixedSegurosApp.Vistas
{
    partial class PagoTarjeta
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
            this.lbl_tipo = new System.Windows.Forms.Label();
            this.rb_mastercard = new System.Windows.Forms.RadioButton();
            this.rb_visa = new System.Windows.Forms.RadioButton();
            this.lbl_titular = new System.Windows.Forms.Label();
            this.txt_titular = new System.Windows.Forms.TextBox();
            this.lbl_numero = new System.Windows.Forms.Label();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.lbl_vencimiento = new System.Windows.Forms.Label();
            this.txt_vencimiento = new System.Windows.Forms.TextBox();
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.chk_terminos = new System.Windows.Forms.CheckBox();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.btn_pagar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // lbl_titulo
            //
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Segoe UI Semibold", 13F);
            this.lbl_titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(58)))), ((int)(((byte)(92)))));
            this.lbl_titulo.Location = new System.Drawing.Point(20, 16);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(140, 25);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Pago con tarjeta";
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
            // lbl_tipo
            //
            this.lbl_tipo.AutoSize = true;
            this.lbl_tipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_tipo.Location = new System.Drawing.Point(22, 142);
            this.lbl_tipo.Name = "lbl_tipo";
            this.lbl_tipo.Size = new System.Drawing.Size(86, 15);
            this.lbl_tipo.TabIndex = 3;
            this.lbl_tipo.Text = "Tipo de tarjeta";
            //
            // rb_mastercard
            //
            this.rb_mastercard.AutoSize = true;
            this.rb_mastercard.Enabled = false;
            this.rb_mastercard.Location = new System.Drawing.Point(24, 162);
            this.rb_mastercard.Name = "rb_mastercard";
            this.rb_mastercard.Size = new System.Drawing.Size(86, 19);
            this.rb_mastercard.TabIndex = 4;
            this.rb_mastercard.Text = "Mastercard";
            //
            // rb_visa
            //
            this.rb_visa.AutoSize = true;
            this.rb_visa.Enabled = false;
            this.rb_visa.Location = new System.Drawing.Point(140, 162);
            this.rb_visa.Name = "rb_visa";
            this.rb_visa.Size = new System.Drawing.Size(46, 19);
            this.rb_visa.TabIndex = 5;
            this.rb_visa.Text = "Visa";
            //
            // lbl_titular
            //
            this.lbl_titular.AutoSize = true;
            this.lbl_titular.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_titular.Location = new System.Drawing.Point(22, 194);
            this.lbl_titular.Name = "lbl_titular";
            this.lbl_titular.Size = new System.Drawing.Size(103, 15);
            this.lbl_titular.TabIndex = 6;
            this.lbl_titular.Text = "Nombre del titular";
            //
            // txt_titular
            //
            this.txt_titular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.txt_titular.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_titular.Location = new System.Drawing.Point(22, 212);
            this.txt_titular.Name = "txt_titular";
            this.txt_titular.ReadOnly = true;
            this.txt_titular.Size = new System.Drawing.Size(416, 23);
            this.txt_titular.TabIndex = 7;
            this.txt_titular.TabStop = false;
            //
            // lbl_numero
            //
            this.lbl_numero.AutoSize = true;
            this.lbl_numero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_numero.Location = new System.Drawing.Point(22, 246);
            this.lbl_numero.Name = "lbl_numero";
            this.lbl_numero.Size = new System.Drawing.Size(103, 15);
            this.lbl_numero.TabIndex = 8;
            this.lbl_numero.Text = "Número de tarjeta";
            //
            // txt_numero
            //
            this.txt_numero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.txt_numero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_numero.Location = new System.Drawing.Point(22, 264);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.ReadOnly = true;
            this.txt_numero.Size = new System.Drawing.Size(416, 23);
            this.txt_numero.TabIndex = 9;
            this.txt_numero.TabStop = false;
            //
            // lbl_vencimiento
            //
            this.lbl_vencimiento.AutoSize = true;
            this.lbl_vencimiento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_vencimiento.Location = new System.Drawing.Point(22, 298);
            this.lbl_vencimiento.Name = "lbl_vencimiento";
            this.lbl_vencimiento.Size = new System.Drawing.Size(117, 15);
            this.lbl_vencimiento.TabIndex = 10;
            this.lbl_vencimiento.Text = "Fecha de vencimiento";
            //
            // txt_vencimiento
            //
            this.txt_vencimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.txt_vencimiento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_vencimiento.Location = new System.Drawing.Point(22, 316);
            this.txt_vencimiento.Name = "txt_vencimiento";
            this.txt_vencimiento.ReadOnly = true;
            this.txt_vencimiento.Size = new System.Drawing.Size(130, 23);
            this.txt_vencimiento.TabIndex = 11;
            this.txt_vencimiento.TabStop = false;
            //
            // lbl_codigo
            //
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_codigo.Location = new System.Drawing.Point(170, 298);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(115, 15);
            this.lbl_codigo.TabIndex = 12;
            this.lbl_codigo.Text = "Código de seguridad";
            //
            // txt_codigo
            //
            this.txt_codigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.txt_codigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_codigo.Location = new System.Drawing.Point(170, 316);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.ReadOnly = true;
            this.txt_codigo.Size = new System.Drawing.Size(90, 23);
            this.txt_codigo.TabIndex = 13;
            this.txt_codigo.TabStop = false;
            //
            // chk_terminos
            //
            this.chk_terminos.AutoSize = true;
            this.chk_terminos.Enabled = false;
            this.chk_terminos.Location = new System.Drawing.Point(24, 356);
            this.chk_terminos.Name = "chk_terminos";
            this.chk_terminos.Size = new System.Drawing.Size(212, 19);
            this.chk_terminos.TabIndex = 14;
            this.chk_terminos.Text = "Acepto los términos y condiciones";
            //
            // btn_cerrar
            //
            this.btn_cerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cerrar.Location = new System.Drawing.Point(218, 396);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(110, 34);
            this.btn_cerrar.TabIndex = 15;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = false;
            //
            // btn_pagar
            //
            this.btn_pagar.Enabled = false;
            this.btn_pagar.Location = new System.Drawing.Point(334, 396);
            this.btn_pagar.Name = "btn_pagar";
            this.btn_pagar.Size = new System.Drawing.Size(104, 34);
            this.btn_pagar.TabIndex = 16;
            this.btn_pagar.Text = "Pagar";
            this.btn_pagar.UseVisualStyleBackColor = false;
            //
            // PagoTarjeta
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btn_cerrar;
            this.ClientSize = new System.Drawing.Size(460, 446);
            this.ControlBox = false;
            this.Controls.Add(this.btn_pagar);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.chk_terminos);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.lbl_codigo);
            this.Controls.Add(this.txt_vencimiento);
            this.Controls.Add(this.lbl_vencimiento);
            this.Controls.Add(this.txt_numero);
            this.Controls.Add(this.lbl_numero);
            this.Controls.Add(this.txt_titular);
            this.Controls.Add(this.lbl_titular);
            this.Controls.Add(this.rb_visa);
            this.Controls.Add(this.rb_mastercard);
            this.Controls.Add(this.lbl_tipo);
            this.Controls.Add(this.lbl_error);
            this.Controls.Add(this.lbl_resumen);
            this.Controls.Add(this.lbl_titulo);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(56)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PagoTarjeta";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Fixed Seguros: Pagar cuota";
            this.Load += new System.EventHandler(this.PagoTarjeta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_resumen;
        private System.Windows.Forms.Label lbl_error;
        private System.Windows.Forms.Label lbl_tipo;
        private System.Windows.Forms.RadioButton rb_mastercard;
        private System.Windows.Forms.RadioButton rb_visa;
        private System.Windows.Forms.Label lbl_titular;
        private System.Windows.Forms.TextBox txt_titular;
        private System.Windows.Forms.Label lbl_numero;
        private System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.Label lbl_vencimiento;
        private System.Windows.Forms.TextBox txt_vencimiento;
        private System.Windows.Forms.Label lbl_codigo;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.CheckBox chk_terminos;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Button btn_pagar;
    }
}
