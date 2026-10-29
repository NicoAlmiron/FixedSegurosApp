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
            ((System.ComponentModel.ISupportInitialize)(this.pic_foto)).BeginInit();
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
            // VerFoto
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 640);
            this.Controls.Add(this.pic_foto);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Icon = global::FixedSegurosApp.Properties.Resources.icono_FS;
            this.MinimizeBox = false;
            this.Name = "VerFoto";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Fixed Seguros: Foto";
            ((System.ComponentModel.ISupportInitialize)(this.pic_foto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_foto;
    }
}
