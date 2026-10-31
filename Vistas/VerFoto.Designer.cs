namespace FixedSegurosApp.Vistas
{
    partial class VerFoto
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
            this.pic_foto = new System.Windows.Forms.PictureBox();
            this.pnl_pie = new System.Windows.Forms.Panel();
            this.btn_cerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_foto)).BeginInit();
            this.pnl_pie.SuspendLayout();
            this.SuspendLayout();
            //
            // pic_foto
            //
            this.pic_foto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(38)))), ((int)(((byte)(63)))));
            this.pic_foto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic_foto.Location = new System.Drawing.Point(0, 0);
            this.pic_foto.Name = "pic_foto";
            this.pic_foto.Size = new System.Drawing.Size(900, 640);
            this.pic_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_foto.TabStop = false;
            //
            // pnl_pie
            //
            this.pnl_pie.BackColor = System.Drawing.Color.White;
            this.pnl_pie.Controls.Add(this.btn_cerrar);
            this.pnl_pie.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_pie.Location = new System.Drawing.Point(0, 640);
            this.pnl_pie.Name = "pnl_pie";
            this.pnl_pie.Size = new System.Drawing.Size(900, 56);
            this.pnl_pie.TabIndex = 0;
            //
            // btn_cerrar
            //
            this.btn_cerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cerrar.Location = new System.Drawing.Point(776, 11);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(108, 34);
            this.btn_cerrar.TabIndex = 0;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = false;
            //
            // VerFoto
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_cerrar;
            this.ClientSize = new System.Drawing.Size(900, 696);
            this.ControlBox = false;
            this.Controls.Add(this.pic_foto);
            this.Controls.Add(this.pnl_pie);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = global::FixedSegurosApp.Properties.Resources.icono_FS;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VerFoto";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Fixed Seguros: Foto";
            ((System.ComponentModel.ISupportInitialize)(this.pic_foto)).EndInit();
            this.pnl_pie.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_foto;
        private System.Windows.Forms.Panel pnl_pie;
        private System.Windows.Forms.Button btn_cerrar;
    }
}
