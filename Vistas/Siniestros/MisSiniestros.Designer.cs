namespace FixedSegurosApp.Vistas
{
    partial class MisSiniestros
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
            this.lbl_dni = new System.Windows.Forms.Label();
            this.txt_dni = new System.Windows.Forms.TextBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_volver = new System.Windows.Forms.Button();
            this.pnl_form = new System.Windows.Forms.Panel();
            this.lbl_form_titulo = new System.Windows.Forms.Label();
            this.pnl_linea_form = new System.Windows.Forms.Panel();
            this.lbl_seccion_datos = new System.Windows.Forms.Label();
            this.lbl_poliza = new System.Windows.Forms.Label();
            this.cb_poliza = new System.Windows.Forms.ComboBox();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.lbl_tipo = new System.Windows.Forms.Label();
            this.cb_tipo = new System.Windows.Forms.ComboBox();
            this.lbl_ubicacion = new System.Windows.Forms.Label();
            this.txt_ubicacion = new System.Windows.Forms.TextBox();
            this.lbl_descripcion = new System.Windows.Forms.Label();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.lbl_seccion_bien = new System.Windows.Forms.Label();
            this.lbl_marca = new System.Windows.Forms.Label();
            this.txt_marca = new System.Windows.Forms.TextBox();
            this.lbl_dominio = new System.Windows.Forms.Label();
            this.txt_dominio = new System.Windows.Forms.TextBox();
            this.lbl_anio = new System.Windows.Forms.Label();
            this.txt_anio = new System.Windows.Forms.TextBox();
            this.lbl_monto = new System.Windows.Forms.Label();
            this.txt_monto = new System.Windows.Forms.TextBox();
            this.pnl_linea_pie = new System.Windows.Forms.Panel();
            this.lbl_ayuda = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_enviar = new System.Windows.Forms.Button();
            this.pnl_detalle = new System.Windows.Forms.Panel();
            this.lbl_documentacion_titulo = new System.Windows.Forms.Label();
            this.lbl_fotos_titulo = new System.Windows.Forms.Label();
            this.btn_fotos = new System.Windows.Forms.Button();
            this.lbl_fotos = new System.Windows.Forms.Label();
            this.lbl_denuncia_titulo = new System.Windows.Forms.Label();
            this.btn_denuncia = new System.Windows.Forms.Button();
            this.lbl_denuncia = new System.Windows.Forms.Label();
            this.pnl_linea_reclamos = new System.Windows.Forms.Panel();
            this.lbl_reclamos_titulo = new System.Windows.Forms.Label();
            this.dgv_reclamos = new System.Windows.Forms.DataGridView();
            this.col_expediente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_poliza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_linea_seguimiento = new System.Windows.Forms.Panel();
            this.lbl_seguimiento_titulo = new System.Windows.Forms.Label();
            this.lbl_paso1 = new System.Windows.Forms.Label();
            this.lbl_paso2 = new System.Windows.Forms.Label();
            this.lbl_paso3 = new System.Windows.Forms.Label();
            this.lbl_observaciones = new System.Windows.Forms.Label();
            this.pnl_form.SuspendLayout();
            this.pnl_detalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reclamos)).BeginInit();
            this.SuspendLayout();
            //
            // lbl_titulo
            //
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Segoe UI Semibold", 16F);
            this.lbl_titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(58)))), ((int)(((byte)(92)))));
            this.lbl_titulo.Location = new System.Drawing.Point(20, 20);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(103, 30);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Siniestros";
            //
            // lbl_dni
            //
            this.lbl_dni.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_dni.AutoSize = true;
            this.lbl_dni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_dni.Location = new System.Drawing.Point(566, 30);
            this.lbl_dni.Name = "lbl_dni";
            this.lbl_dni.Size = new System.Drawing.Size(27, 15);
            this.lbl_dni.Text = "DNI";
            //
            // txt_dni
            //
            this.txt_dni.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_dni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_dni.Location = new System.Drawing.Point(598, 27);
            this.txt_dni.MaxLength = 8;
            this.txt_dni.Name = "txt_dni";
            this.txt_dni.Size = new System.Drawing.Size(120, 23);
            this.txt_dni.TabIndex = 0;
            //
            // btn_buscar
            //
            this.btn_buscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_buscar.Location = new System.Drawing.Point(726, 22);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(90, 32);
            this.btn_buscar.TabIndex = 1;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            //
            // btn_volver
            //
            this.btn_volver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_volver.Location = new System.Drawing.Point(826, 22);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(170, 32);
            this.btn_volver.TabIndex = 2;
            this.btn_volver.Text = "Volver a Siniestros";
            this.btn_volver.UseVisualStyleBackColor = false;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            //
            // pnl_form
            //
            this.pnl_form.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_form.Controls.Add(this.lbl_form_titulo);
            this.pnl_form.Controls.Add(this.pnl_linea_form);
            this.pnl_form.Controls.Add(this.lbl_seccion_datos);
            this.pnl_form.Controls.Add(this.lbl_poliza);
            this.pnl_form.Controls.Add(this.cb_poliza);
            this.pnl_form.Controls.Add(this.lbl_fecha);
            this.pnl_form.Controls.Add(this.dtp_fecha);
            this.pnl_form.Controls.Add(this.lbl_tipo);
            this.pnl_form.Controls.Add(this.cb_tipo);
            this.pnl_form.Controls.Add(this.lbl_ubicacion);
            this.pnl_form.Controls.Add(this.txt_ubicacion);
            this.pnl_form.Controls.Add(this.lbl_descripcion);
            this.pnl_form.Controls.Add(this.txt_descripcion);
            this.pnl_form.Controls.Add(this.lbl_seccion_bien);
            this.pnl_form.Controls.Add(this.lbl_marca);
            this.pnl_form.Controls.Add(this.txt_marca);
            this.pnl_form.Controls.Add(this.lbl_dominio);
            this.pnl_form.Controls.Add(this.txt_dominio);
            this.pnl_form.Controls.Add(this.lbl_anio);
            this.pnl_form.Controls.Add(this.txt_anio);
            this.pnl_form.Controls.Add(this.lbl_monto);
            this.pnl_form.Controls.Add(this.txt_monto);
            this.pnl_form.Controls.Add(this.pnl_linea_pie);
            this.pnl_form.Controls.Add(this.lbl_ayuda);
            this.pnl_form.Controls.Add(this.btn_cancelar);
            this.pnl_form.Controls.Add(this.btn_enviar);
            this.pnl_form.Location = new System.Drawing.Point(24, 70);
            this.pnl_form.Name = "pnl_form";
            this.pnl_form.Size = new System.Drawing.Size(584, 636);
            this.pnl_form.TabIndex = 1;
            //
            // lbl_form_titulo
            //
            this.lbl_form_titulo.AutoSize = true;
            this.lbl_form_titulo.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.lbl_form_titulo.Location = new System.Drawing.Point(14, 18);
            this.lbl_form_titulo.Name = "lbl_form_titulo";
            this.lbl_form_titulo.Size = new System.Drawing.Size(106, 20);
            this.lbl_form_titulo.TabIndex = 0;
            this.lbl_form_titulo.Text = "Nuevo reclamo";
            //
            // pnl_linea_form
            //
            this.pnl_linea_form.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_linea_form.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(221)))), ((int)(((byte)(232)))));
            this.pnl_linea_form.Location = new System.Drawing.Point(1, 54);
            this.pnl_linea_form.Name = "pnl_linea_form";
            this.pnl_linea_form.Size = new System.Drawing.Size(582, 1);
            this.pnl_linea_form.TabIndex = 20;
            //
            // lbl_seccion_datos
            //
            this.lbl_seccion_datos.AutoSize = true;
            this.lbl_seccion_datos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_seccion_datos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(58)))), ((int)(((byte)(92)))));
            this.lbl_seccion_datos.Location = new System.Drawing.Point(16, 66);
            this.lbl_seccion_datos.Name = "lbl_seccion_datos";
            this.lbl_seccion_datos.Size = new System.Drawing.Size(112, 15);
            this.lbl_seccion_datos.Text = "Datos del siniestro";
            //
            // lbl_poliza
            //
            this.lbl_poliza.AutoSize = true;
            this.lbl_poliza.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_poliza.Location = new System.Drawing.Point(16, 92);
            this.lbl_poliza.Name = "lbl_poliza";
            this.lbl_poliza.Size = new System.Drawing.Size(81, 15);
            this.lbl_poliza.Text = "Póliza vigente";
            //
            // cb_poliza
            //
            this.cb_poliza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_poliza.Location = new System.Drawing.Point(16, 110);
            this.cb_poliza.Name = "cb_poliza";
            this.cb_poliza.Size = new System.Drawing.Size(268, 23);
            this.cb_poliza.TabIndex = 1;
            this.cb_poliza.SelectedIndexChanged += new System.EventHandler(this.cb_poliza_SelectedIndexChanged);
            //
            // lbl_fecha
            //
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_fecha.Location = new System.Drawing.Point(300, 92);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(88, 15);
            this.lbl_fecha.Text = "Fecha del hecho";
            //
            // dtp_fecha
            //
            this.dtp_fecha.CustomFormat = "dd/MM/yyyy";
            this.dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_fecha.Location = new System.Drawing.Point(300, 110);
            this.dtp_fecha.Name = "dtp_fecha";
            this.dtp_fecha.Size = new System.Drawing.Size(268, 23);
            this.dtp_fecha.TabIndex = 2;
            //
            // lbl_tipo
            //
            this.lbl_tipo.AutoSize = true;
            this.lbl_tipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_tipo.Location = new System.Drawing.Point(16, 146);
            this.lbl_tipo.Name = "lbl_tipo";
            this.lbl_tipo.Size = new System.Drawing.Size(92, 15);
            this.lbl_tipo.Text = "Tipo de siniestro";
            //
            // cb_tipo
            //
            this.cb_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_tipo.Location = new System.Drawing.Point(16, 164);
            this.cb_tipo.Name = "cb_tipo";
            this.cb_tipo.Size = new System.Drawing.Size(268, 23);
            this.cb_tipo.TabIndex = 3;
            //
            // lbl_ubicacion
            //
            this.lbl_ubicacion.AutoSize = true;
            this.lbl_ubicacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_ubicacion.Location = new System.Drawing.Point(300, 146);
            this.lbl_ubicacion.Name = "lbl_ubicacion";
            this.lbl_ubicacion.Size = new System.Drawing.Size(107, 15);
            this.lbl_ubicacion.Text = "Ubicación del hecho";
            //
            // txt_ubicacion
            //
            this.txt_ubicacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ubicacion.Location = new System.Drawing.Point(300, 164);
            this.txt_ubicacion.MaxLength = 100;
            this.txt_ubicacion.Name = "txt_ubicacion";
            this.txt_ubicacion.Size = new System.Drawing.Size(268, 23);
            this.txt_ubicacion.TabIndex = 4;
            //
            // lbl_descripcion
            //
            this.lbl_descripcion.AutoSize = true;
            this.lbl_descripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_descripcion.Location = new System.Drawing.Point(16, 200);
            this.lbl_descripcion.Name = "lbl_descripcion";
            this.lbl_descripcion.Size = new System.Drawing.Size(99, 15);
            this.lbl_descripcion.Text = "Descripción breve";
            //
            // txt_descripcion
            //
            this.txt_descripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_descripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_descripcion.Location = new System.Drawing.Point(16, 218);
            this.txt_descripcion.MaxLength = 450;
            this.txt_descripcion.Multiline = true;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_descripcion.Size = new System.Drawing.Size(552, 173);
            this.txt_descripcion.TabIndex = 5;
            //
            // lbl_seccion_bien
            //
            this.lbl_seccion_bien.AutoSize = true;
            this.lbl_seccion_bien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_seccion_bien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(58)))), ((int)(((byte)(92)))));
            this.lbl_seccion_bien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_seccion_bien.Location = new System.Drawing.Point(16, 405);
            this.lbl_seccion_bien.Name = "lbl_seccion_bien";
            this.lbl_seccion_bien.Size = new System.Drawing.Size(84, 15);
            this.lbl_seccion_bien.Text = "Bien afectado";
            //
            // lbl_marca
            //
            this.lbl_marca.AutoSize = true;
            this.lbl_marca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_marca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_marca.Location = new System.Drawing.Point(16, 431);
            this.lbl_marca.Name = "lbl_marca";
            this.lbl_marca.Size = new System.Drawing.Size(92, 15);
            this.lbl_marca.Text = "Marca y modelo";
            //
            // txt_marca
            //
            this.txt_marca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.txt_marca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_marca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_marca.Location = new System.Drawing.Point(16, 449);
            this.txt_marca.Name = "txt_marca";
            this.txt_marca.ReadOnly = true;
            this.txt_marca.Size = new System.Drawing.Size(268, 23);
            this.txt_marca.TabStop = false;
            //
            // lbl_dominio
            //
            this.lbl_dominio.AutoSize = true;
            this.lbl_dominio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_dominio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_dominio.Location = new System.Drawing.Point(300, 431);
            this.lbl_dominio.Name = "lbl_dominio";
            this.lbl_dominio.Size = new System.Drawing.Size(51, 15);
            this.lbl_dominio.Text = "Dominio";
            //
            // txt_dominio
            //
            this.txt_dominio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.txt_dominio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_dominio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_dominio.Location = new System.Drawing.Point(300, 449);
            this.txt_dominio.Name = "txt_dominio";
            this.txt_dominio.ReadOnly = true;
            this.txt_dominio.Size = new System.Drawing.Size(268, 23);
            this.txt_dominio.TabStop = false;
            //
            // lbl_anio
            //
            this.lbl_anio.AutoSize = true;
            this.lbl_anio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_anio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_anio.Location = new System.Drawing.Point(16, 485);
            this.lbl_anio.Name = "lbl_anio";
            this.lbl_anio.Size = new System.Drawing.Size(29, 15);
            this.lbl_anio.Text = "Año";
            //
            // txt_anio
            //
            this.txt_anio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.txt_anio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_anio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_anio.Location = new System.Drawing.Point(16, 503);
            this.txt_anio.Name = "txt_anio";
            this.txt_anio.ReadOnly = true;
            this.txt_anio.Size = new System.Drawing.Size(268, 23);
            this.txt_anio.TabStop = false;
            //
            // lbl_monto
            //
            this.lbl_monto.AutoSize = true;
            this.lbl_monto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_monto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_monto.Location = new System.Drawing.Point(300, 485);
            this.lbl_monto.Name = "lbl_monto";
            this.lbl_monto.Size = new System.Drawing.Size(138, 15);
            this.lbl_monto.Text = "Valor aproximado del daño";
            //
            // txt_monto
            //
            this.txt_monto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_monto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_monto.Location = new System.Drawing.Point(300, 503);
            this.txt_monto.Name = "txt_monto";
            this.txt_monto.Size = new System.Drawing.Size(268, 23);
            this.txt_monto.TabIndex = 6;
            //
            // pnl_linea_pie
            //
            this.pnl_linea_pie.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_linea_pie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(221)))), ((int)(((byte)(232)))));
            this.pnl_linea_pie.Location = new System.Drawing.Point(1, 572);
            this.pnl_linea_pie.Name = "pnl_linea_pie";
            this.pnl_linea_pie.Size = new System.Drawing.Size(582, 1);
            this.pnl_linea_pie.TabIndex = 21;
            //
            // lbl_ayuda
            //
            this.lbl_ayuda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_ayuda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_ayuda.Location = new System.Drawing.Point(16, 534);
            this.lbl_ayuda.Name = "lbl_ayuda";
            this.lbl_ayuda.Size = new System.Drawing.Size(552, 32);
            this.lbl_ayuda.Text = "El reclamo queda en estado Pendiente hasta que un empleado revise la documentación.";
            //
            // btn_cancelar
            //
            this.btn_cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancelar.Location = new System.Drawing.Point(318, 586);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(104, 34);
            this.btn_cancelar.TabIndex = 8;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            //
            // btn_enviar
            //
            this.btn_enviar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_enviar.Location = new System.Drawing.Point(432, 586);
            this.btn_enviar.Name = "btn_enviar";
            this.btn_enviar.Size = new System.Drawing.Size(136, 34);
            this.btn_enviar.TabIndex = 7;
            this.btn_enviar.Text = "Enviar reclamo";
            this.btn_enviar.UseVisualStyleBackColor = false;
            this.btn_enviar.Click += new System.EventHandler(this.btn_enviar_Click);
            //
            // pnl_detalle
            //
            this.pnl_detalle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_detalle.Controls.Add(this.lbl_documentacion_titulo);
            this.pnl_detalle.Controls.Add(this.lbl_fotos_titulo);
            this.pnl_detalle.Controls.Add(this.btn_fotos);
            this.pnl_detalle.Controls.Add(this.lbl_fotos);
            this.pnl_detalle.Controls.Add(this.lbl_denuncia_titulo);
            this.pnl_detalle.Controls.Add(this.btn_denuncia);
            this.pnl_detalle.Controls.Add(this.lbl_denuncia);
            this.pnl_detalle.Controls.Add(this.pnl_linea_reclamos);
            this.pnl_detalle.Controls.Add(this.lbl_reclamos_titulo);
            this.pnl_detalle.Controls.Add(this.dgv_reclamos);
            this.pnl_detalle.Controls.Add(this.pnl_linea_seguimiento);
            this.pnl_detalle.Controls.Add(this.lbl_seguimiento_titulo);
            this.pnl_detalle.Controls.Add(this.lbl_paso1);
            this.pnl_detalle.Controls.Add(this.lbl_paso2);
            this.pnl_detalle.Controls.Add(this.lbl_paso3);
            this.pnl_detalle.Controls.Add(this.lbl_observaciones);
            this.pnl_detalle.Location = new System.Drawing.Point(620, 70);
            this.pnl_detalle.Name = "pnl_detalle";
            this.pnl_detalle.Size = new System.Drawing.Size(376, 636);
            this.pnl_detalle.TabIndex = 2;
            //
            // lbl_documentacion_titulo
            //
            this.lbl_documentacion_titulo.AutoSize = true;
            this.lbl_documentacion_titulo.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.lbl_documentacion_titulo.Location = new System.Drawing.Point(14, 14);
            this.lbl_documentacion_titulo.Name = "lbl_documentacion_titulo";
            this.lbl_documentacion_titulo.Size = new System.Drawing.Size(117, 20);
            this.lbl_documentacion_titulo.Text = "Documentación";
            //
            // lbl_fotos_titulo
            //
            this.lbl_fotos_titulo.AutoSize = true;
            this.lbl_fotos_titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_fotos_titulo.Location = new System.Drawing.Point(16, 42);
            this.lbl_fotos_titulo.Name = "lbl_fotos_titulo";
            this.lbl_fotos_titulo.Size = new System.Drawing.Size(202, 15);
            this.lbl_fotos_titulo.Text = "Fotos del daño o del lugar del hecho";
            //
            // btn_fotos
            //
            this.btn_fotos.Location = new System.Drawing.Point(16, 60);
            this.btn_fotos.Name = "btn_fotos";
            this.btn_fotos.Size = new System.Drawing.Size(130, 32);
            this.btn_fotos.TabIndex = 0;
            this.btn_fotos.Text = "Adjuntar fotos";
            this.btn_fotos.UseVisualStyleBackColor = false;
            this.btn_fotos.Click += new System.EventHandler(this.btn_fotos_Click);
            //
            // lbl_fotos
            //
            this.lbl_fotos.AutoSize = true;
            this.lbl_fotos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_fotos.Location = new System.Drawing.Point(156, 69);
            this.lbl_fotos.Name = "lbl_fotos";
            this.lbl_fotos.Size = new System.Drawing.Size(70, 15);
            this.lbl_fotos.Text = "Sin adjuntar";
            //
            // lbl_denuncia_titulo
            //
            this.lbl_denuncia_titulo.AutoSize = true;
            this.lbl_denuncia_titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_denuncia_titulo.Location = new System.Drawing.Point(16, 100);
            this.lbl_denuncia_titulo.Name = "lbl_denuncia_titulo";
            this.lbl_denuncia_titulo.Size = new System.Drawing.Size(55, 15);
            this.lbl_denuncia_titulo.Text = "Denuncia";
            //
            // btn_denuncia
            //
            this.btn_denuncia.Location = new System.Drawing.Point(16, 118);
            this.btn_denuncia.Name = "btn_denuncia";
            this.btn_denuncia.Size = new System.Drawing.Size(130, 32);
            this.btn_denuncia.TabIndex = 1;
            this.btn_denuncia.Text = "Adjuntar denuncia";
            this.btn_denuncia.UseVisualStyleBackColor = false;
            this.btn_denuncia.Click += new System.EventHandler(this.btn_denuncia_Click);
            //
            // lbl_denuncia
            //
            this.lbl_denuncia.AutoSize = true;
            this.lbl_denuncia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_denuncia.Location = new System.Drawing.Point(156, 127);
            this.lbl_denuncia.Name = "lbl_denuncia";
            this.lbl_denuncia.Size = new System.Drawing.Size(70, 15);
            this.lbl_denuncia.Text = "Sin adjuntar";
            //
            // pnl_linea_reclamos
            //
            this.pnl_linea_reclamos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(221)))), ((int)(((byte)(232)))));
            this.pnl_linea_reclamos.Location = new System.Drawing.Point(1, 162);
            this.pnl_linea_reclamos.Name = "pnl_linea_reclamos";
            this.pnl_linea_reclamos.Size = new System.Drawing.Size(374, 1);
            this.pnl_linea_reclamos.TabIndex = 20;
            //
            // lbl_reclamos_titulo
            //
            this.lbl_reclamos_titulo.AutoSize = true;
            this.lbl_reclamos_titulo.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.lbl_reclamos_titulo.Location = new System.Drawing.Point(14, 170);
            this.lbl_reclamos_titulo.Name = "lbl_reclamos_titulo";
            this.lbl_reclamos_titulo.Size = new System.Drawing.Size(99, 20);
            this.lbl_reclamos_titulo.Text = "Mis reclamos";
            //
            // dgv_reclamos
            //
            this.dgv_reclamos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_reclamos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_expediente,
            this.col_poliza,
            this.col_fecha,
            this.col_estado});
            this.dgv_reclamos.Location = new System.Drawing.Point(1, 196);
            this.dgv_reclamos.Name = "dgv_reclamos";
            this.dgv_reclamos.Size = new System.Drawing.Size(374, 236);
            this.dgv_reclamos.TabIndex = 2;
            this.dgv_reclamos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_reclamos_CellClick);
            this.dgv_reclamos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_reclamos_CellFormatting);
            this.dgv_reclamos.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgv_reclamos_DataBindingComplete);
            //
            // col_expediente
            //
            this.col_expediente.DataPropertyName = "ExpedienteTexto";
            this.col_expediente.FillWeight = 85F;
            this.col_expediente.HeaderText = "Expediente";
            this.col_expediente.Name = "col_expediente";
            //
            // col_poliza
            //
            this.col_poliza.DataPropertyName = "PolizaTexto";
            this.col_poliza.FillWeight = 70F;
            this.col_poliza.HeaderText = "Póliza";
            this.col_poliza.Name = "col_poliza";
            //
            // col_fecha
            //
            this.col_fecha.DataPropertyName = "FechaRegistro";
            estiloFecha.Format = "dd/MM/yyyy";
            this.col_fecha.DefaultCellStyle = estiloFecha;
            this.col_fecha.FillWeight = 80F;
            this.col_fecha.HeaderText = "Reclamo";
            this.col_fecha.Name = "col_fecha";
            //
            // col_estado
            //
            this.col_estado.DataPropertyName = "Estado";
            this.col_estado.FillWeight = 95F;
            this.col_estado.HeaderText = "Estado";
            this.col_estado.Name = "col_estado";
            //
            // pnl_linea_seguimiento
            //
            this.pnl_linea_seguimiento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnl_linea_seguimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(221)))), ((int)(((byte)(232)))));
            this.pnl_linea_seguimiento.Location = new System.Drawing.Point(1, 440);
            this.pnl_linea_seguimiento.Name = "pnl_linea_seguimiento";
            this.pnl_linea_seguimiento.Size = new System.Drawing.Size(374, 1);
            this.pnl_linea_seguimiento.TabIndex = 21;
            //
            // lbl_seguimiento_titulo
            //
            this.lbl_seguimiento_titulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_seguimiento_titulo.AutoSize = true;
            this.lbl_seguimiento_titulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_seguimiento_titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(58)))), ((int)(((byte)(92)))));
            this.lbl_seguimiento_titulo.Location = new System.Drawing.Point(16, 450);
            this.lbl_seguimiento_titulo.Name = "lbl_seguimiento_titulo";
            this.lbl_seguimiento_titulo.Size = new System.Drawing.Size(156, 15);
            this.lbl_seguimiento_titulo.Text = "Seguimiento del expediente";
            //
            // lbl_paso1
            //
            this.lbl_paso1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_paso1.AutoSize = true;
            this.lbl_paso1.Location = new System.Drawing.Point(16, 472);
            this.lbl_paso1.Name = "lbl_paso1";
            this.lbl_paso1.Size = new System.Drawing.Size(203, 15);
            this.lbl_paso1.Text = "1. Pendiente: documentación recibida";
            //
            // lbl_paso2
            //
            this.lbl_paso2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_paso2.AutoSize = true;
            this.lbl_paso2.Location = new System.Drawing.Point(16, 492);
            this.lbl_paso2.Name = "lbl_paso2";
            this.lbl_paso2.Size = new System.Drawing.Size(232, 15);
            this.lbl_paso2.Text = "2. En evaluación: a cargo de la aseguradora";
            //
            // lbl_paso3
            //
            this.lbl_paso3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_paso3.AutoSize = true;
            this.lbl_paso3.Location = new System.Drawing.Point(16, 512);
            this.lbl_paso3.Name = "lbl_paso3";
            this.lbl_paso3.Size = new System.Drawing.Size(187, 15);
            this.lbl_paso3.Text = "3. Resultado: Aprobado o Rechazado";
            //
            // lbl_observaciones
            //
            this.lbl_observaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_observaciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_observaciones.Location = new System.Drawing.Point(16, 534);
            this.lbl_observaciones.Name = "lbl_observaciones";
            this.lbl_observaciones.Size = new System.Drawing.Size(344, 94);
            //
            // MisSiniestros
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1020, 730);
            this.Controls.Add(this.pnl_detalle);
            this.Controls.Add(this.pnl_form);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.txt_dni);
            this.Controls.Add(this.lbl_dni);
            this.Controls.Add(this.lbl_titulo);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(56)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MisSiniestros";
            this.Text = "Siniestros";
            this.Load += new System.EventHandler(this.MisSiniestros_Load);
            this.pnl_form.ResumeLayout(false);
            this.pnl_form.PerformLayout();
            this.pnl_detalle.ResumeLayout(false);
            this.pnl_detalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reclamos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_dni;
        private System.Windows.Forms.TextBox txt_dni;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.Panel pnl_form;
        private System.Windows.Forms.Label lbl_form_titulo;
        private System.Windows.Forms.Panel pnl_linea_form;
        private System.Windows.Forms.Label lbl_seccion_datos;
        private System.Windows.Forms.Label lbl_poliza;
        private System.Windows.Forms.ComboBox cb_poliza;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.DateTimePicker dtp_fecha;
        private System.Windows.Forms.Label lbl_tipo;
        private System.Windows.Forms.ComboBox cb_tipo;
        private System.Windows.Forms.Label lbl_ubicacion;
        private System.Windows.Forms.TextBox txt_ubicacion;
        private System.Windows.Forms.Label lbl_descripcion;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.Label lbl_seccion_bien;
        private System.Windows.Forms.Label lbl_marca;
        private System.Windows.Forms.TextBox txt_marca;
        private System.Windows.Forms.Label lbl_dominio;
        private System.Windows.Forms.TextBox txt_dominio;
        private System.Windows.Forms.Label lbl_anio;
        private System.Windows.Forms.TextBox txt_anio;
        private System.Windows.Forms.Label lbl_monto;
        private System.Windows.Forms.TextBox txt_monto;
        private System.Windows.Forms.Panel pnl_linea_pie;
        private System.Windows.Forms.Label lbl_ayuda;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_enviar;
        private System.Windows.Forms.Panel pnl_detalle;
        private System.Windows.Forms.Label lbl_documentacion_titulo;
        private System.Windows.Forms.Label lbl_fotos_titulo;
        private System.Windows.Forms.Button btn_fotos;
        private System.Windows.Forms.Label lbl_fotos;
        private System.Windows.Forms.Label lbl_denuncia_titulo;
        private System.Windows.Forms.Button btn_denuncia;
        private System.Windows.Forms.Label lbl_denuncia;
        private System.Windows.Forms.Panel pnl_linea_reclamos;
        private System.Windows.Forms.Label lbl_reclamos_titulo;
        private System.Windows.Forms.DataGridView dgv_reclamos;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_expediente;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_poliza;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_estado;
        private System.Windows.Forms.Panel pnl_linea_seguimiento;
        private System.Windows.Forms.Label lbl_seguimiento_titulo;
        private System.Windows.Forms.Label lbl_paso1;
        private System.Windows.Forms.Label lbl_paso2;
        private System.Windows.Forms.Label lbl_paso3;
        private System.Windows.Forms.Label lbl_observaciones;
    }
}
