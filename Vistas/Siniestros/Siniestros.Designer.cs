namespace FixedSegurosApp.Vistas
{
    partial class Siniestros
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
            this.pnl_lista = new System.Windows.Forms.Panel();
            this.lbl_filtro = new System.Windows.Forms.Label();
            this.cb_estado = new System.Windows.Forms.ComboBox();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.dgv_siniestros = new System.Windows.Forms.DataGridView();
            this.col_expediente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_poliza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_reclamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_cantidad = new System.Windows.Forms.Label();
            this.pnl_verificacion = new System.Windows.Forms.Panel();
            this.lbl_verificacion_titulo = new System.Windows.Forms.Label();
            this.chk_fotos = new System.Windows.Forms.CheckBox();
            this.chk_denuncia = new System.Windows.Forms.CheckBox();
            this.chk_poliza = new System.Windows.Forms.CheckBox();
            this.lbl_observaciones = new System.Windows.Forms.Label();
            this.txt_observaciones = new System.Windows.Forms.TextBox();
            this.lbl_estado = new System.Windows.Forms.Label();
            this.btn_rechazar = new System.Windows.Forms.Button();
            this.btn_guardar_observaciones = new System.Windows.Forms.Button();
            this.btn_evaluar = new System.Windows.Forms.Button();
            this.btn_aprobar = new System.Windows.Forms.Button();
            this.pnl_detalle = new System.Windows.Forms.Panel();
            this.lbl_detalle_titulo = new System.Windows.Forms.Label();
            this.pnl_linea_detalle = new System.Windows.Forms.Panel();
            this.lbl_cliente = new System.Windows.Forms.Label();
            this.txt_cliente = new System.Windows.Forms.TextBox();
            this.lbl_poliza = new System.Windows.Forms.Label();
            this.txt_poliza = new System.Windows.Forms.TextBox();
            this.lbl_tipo = new System.Windows.Forms.Label();
            this.txt_tipo = new System.Windows.Forms.TextBox();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.txt_fecha = new System.Windows.Forms.TextBox();
            this.lbl_ubicacion = new System.Windows.Forms.Label();
            this.txt_ubicacion = new System.Windows.Forms.TextBox();
            this.lbl_monto = new System.Windows.Forms.Label();
            this.txt_monto = new System.Windows.Forms.TextBox();
            this.lbl_responsable = new System.Windows.Forms.Label();
            this.txt_responsable = new System.Windows.Forms.TextBox();
            this.lbl_descripcion = new System.Windows.Forms.Label();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.pnl_linea_documentacion = new System.Windows.Forms.Panel();
            this.lbl_documentacion_titulo = new System.Windows.Forms.Label();
            this.lbl_fotos = new System.Windows.Forms.Label();
            this.lbl_denuncia = new System.Windows.Forms.Label();
            this.btn_ver_fotos = new System.Windows.Forms.Button();
            this.btn_ver_denuncia = new System.Windows.Forms.Button();
            this.lbl_formulario = new System.Windows.Forms.Label();
            this.btn_ver_formulario = new System.Windows.Forms.Button();
            this.btn_cargar_formulario = new System.Windows.Forms.Button();
            this.pnl_lista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_siniestros)).BeginInit();
            this.pnl_verificacion.SuspendLayout();
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
            this.lbl_titulo.Size = new System.Drawing.Size(103, 30);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Siniestros";
            //
            // pnl_lista
            //
            this.pnl_lista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_lista.Controls.Add(this.lbl_filtro);
            this.pnl_lista.Controls.Add(this.cb_estado);
            this.pnl_lista.Controls.Add(this.btn_nuevo);
            this.pnl_lista.Controls.Add(this.dgv_siniestros);
            this.pnl_lista.Controls.Add(this.lbl_cantidad);
            this.pnl_lista.Location = new System.Drawing.Point(24, 70);
            this.pnl_lista.Name = "pnl_lista";
            this.pnl_lista.Size = new System.Drawing.Size(584, 336);
            this.pnl_lista.TabIndex = 1;
            //
            // lbl_filtro
            //
            this.lbl_filtro.AutoSize = true;
            this.lbl_filtro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_filtro.Location = new System.Drawing.Point(16, 19);
            this.lbl_filtro.Name = "lbl_filtro";
            this.lbl_filtro.Size = new System.Drawing.Size(42, 15);
            this.lbl_filtro.Text = "Estado";
            //
            // cb_estado
            //
            this.cb_estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_estado.Location = new System.Drawing.Point(66, 15);
            this.cb_estado.Name = "cb_estado";
            this.cb_estado.Size = new System.Drawing.Size(170, 23);
            this.cb_estado.TabIndex = 0;
            this.cb_estado.SelectedIndexChanged += new System.EventHandler(this.cb_estado_SelectedIndexChanged);
            //
            // btn_nuevo
            //
            this.btn_nuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_nuevo.Location = new System.Drawing.Point(438, 10);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(130, 32);
            this.btn_nuevo.TabIndex = 2;
            this.btn_nuevo.Text = "Nuevo reclamo";
            this.btn_nuevo.UseVisualStyleBackColor = false;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            //
            // dgv_siniestros
            //
            this.dgv_siniestros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_siniestros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_expediente,
            this.col_cliente,
            this.col_poliza,
            this.col_reclamo,
            this.col_estado});
            this.dgv_siniestros.Location = new System.Drawing.Point(1, 50);
            this.dgv_siniestros.Name = "dgv_siniestros";
            this.dgv_siniestros.Size = new System.Drawing.Size(582, 252);
            this.dgv_siniestros.TabIndex = 1;
            this.dgv_siniestros.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_siniestros_CellFormatting);
            this.dgv_siniestros.SelectionChanged += new System.EventHandler(this.dgv_siniestros_SelectionChanged);
            //
            // col_expediente
            //
            this.col_expediente.DataPropertyName = "ExpedienteTexto";
            this.col_expediente.FillWeight = 100F;
            this.col_expediente.HeaderText = "Expediente";
            this.col_expediente.Name = "col_expediente";
            //
            // col_cliente
            //
            this.col_cliente.DataPropertyName = "Cliente";
            this.col_cliente.FillWeight = 100F;
            this.col_cliente.HeaderText = "Cliente";
            this.col_cliente.Name = "col_cliente";
            //
            // col_poliza
            //
            this.col_poliza.DataPropertyName = "PolizaTexto";
            this.col_poliza.FillWeight = 65F;
            this.col_poliza.HeaderText = "Póliza";
            this.col_poliza.Name = "col_poliza";
            //
            // col_reclamo
            //
            this.col_reclamo.DataPropertyName = "FechaRegistro";
            estiloFecha.Format = "dd/MM/yyyy";
            this.col_reclamo.DefaultCellStyle = estiloFecha;
            this.col_reclamo.FillWeight = 90F;
            this.col_reclamo.HeaderText = "Reclamo";
            this.col_reclamo.Name = "col_reclamo";
            //
            // col_estado
            //
            this.col_estado.DataPropertyName = "Estado";
            this.col_estado.FillWeight = 90F;
            this.col_estado.HeaderText = "Estado";
            this.col_estado.Name = "col_estado";
            //
            // lbl_cantidad
            //
            this.lbl_cantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_cantidad.AutoSize = true;
            this.lbl_cantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_cantidad.Location = new System.Drawing.Point(16, 311);
            this.lbl_cantidad.Name = "lbl_cantidad";
            this.lbl_cantidad.Size = new System.Drawing.Size(118, 15);
            this.lbl_cantidad.Text = "Mostrando 0 reclamos";
            //
            // pnl_verificacion
            //
            this.pnl_verificacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_verificacion.Controls.Add(this.lbl_verificacion_titulo);
            this.pnl_verificacion.Controls.Add(this.chk_fotos);
            this.pnl_verificacion.Controls.Add(this.chk_denuncia);
            this.pnl_verificacion.Controls.Add(this.chk_poliza);
            this.pnl_verificacion.Controls.Add(this.lbl_observaciones);
            this.pnl_verificacion.Controls.Add(this.txt_observaciones);
            this.pnl_verificacion.Controls.Add(this.lbl_estado);
            this.pnl_verificacion.Controls.Add(this.btn_rechazar);
            this.pnl_verificacion.Controls.Add(this.btn_guardar_observaciones);
            this.pnl_verificacion.Controls.Add(this.btn_evaluar);
            this.pnl_verificacion.Controls.Add(this.btn_aprobar);
            this.pnl_verificacion.Location = new System.Drawing.Point(24, 418);
            this.pnl_verificacion.Name = "pnl_verificacion";
            this.pnl_verificacion.Size = new System.Drawing.Size(584, 288);
            this.pnl_verificacion.TabIndex = 2;
            //
            // lbl_verificacion_titulo
            //
            this.lbl_verificacion_titulo.AutoSize = true;
            this.lbl_verificacion_titulo.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.lbl_verificacion_titulo.Location = new System.Drawing.Point(14, 14);
            this.lbl_verificacion_titulo.Name = "lbl_verificacion_titulo";
            this.lbl_verificacion_titulo.Size = new System.Drawing.Size(225, 20);
            this.lbl_verificacion_titulo.Text = "Verificación de la documentación";
            //
            // chk_fotos
            //
            this.chk_fotos.AutoSize = true;
            this.chk_fotos.Location = new System.Drawing.Point(16, 46);
            this.chk_fotos.Name = "chk_fotos";
            this.chk_fotos.Size = new System.Drawing.Size(160, 19);
            this.chk_fotos.TabIndex = 0;
            this.chk_fotos.Text = "Fotos recibidas y legibles";
            //
            // chk_denuncia
            //
            this.chk_denuncia.AutoSize = true;
            this.chk_denuncia.Location = new System.Drawing.Point(216, 46);
            this.chk_denuncia.Name = "chk_denuncia";
            this.chk_denuncia.Size = new System.Drawing.Size(123, 19);
            this.chk_denuncia.TabIndex = 1;
            this.chk_denuncia.Text = "Denuncia recibida";
            //
            // chk_poliza
            //
            this.chk_poliza.AutoSize = true;
            this.chk_poliza.Location = new System.Drawing.Point(16, 72);
            this.chk_poliza.Name = "chk_poliza";
            this.chk_poliza.Size = new System.Drawing.Size(183, 19);
            this.chk_poliza.TabIndex = 2;
            this.chk_poliza.Text = "Datos de la póliza coinciden";
            //
            // lbl_observaciones
            //
            this.lbl_observaciones.AutoSize = true;
            this.lbl_observaciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_observaciones.Location = new System.Drawing.Point(16, 102);
            this.lbl_observaciones.Name = "lbl_observaciones";
            this.lbl_observaciones.Size = new System.Drawing.Size(120, 15);
            this.lbl_observaciones.Text = "Observaciones del trámite";
            //
            // txt_observaciones
            //
            this.txt_observaciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_observaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_observaciones.Location = new System.Drawing.Point(16, 120);
            this.txt_observaciones.MaxLength = 200;
            this.txt_observaciones.Multiline = true;
            this.txt_observaciones.Name = "txt_observaciones";
            this.txt_observaciones.Size = new System.Drawing.Size(552, 66);
            this.txt_observaciones.TabIndex = 3;
            //
            // lbl_estado
            //
            this.lbl_estado.AutoSize = true;
            this.lbl_estado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_estado.Location = new System.Drawing.Point(16, 198);
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Size = new System.Drawing.Size(84, 15);
            this.lbl_estado.Text = "Estado actual:";
            //
            // btn_rechazar
            //
            this.btn_rechazar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_rechazar.Location = new System.Drawing.Point(464, 192);
            this.btn_rechazar.Name = "btn_rechazar";
            this.btn_rechazar.Size = new System.Drawing.Size(104, 34);
            this.btn_rechazar.TabIndex = 6;
            this.btn_rechazar.Text = "Rechazar";
            this.btn_rechazar.UseVisualStyleBackColor = false;
            this.btn_rechazar.Click += new System.EventHandler(this.btn_rechazar_Click);
            //
            // btn_guardar_observaciones
            //
            this.btn_guardar_observaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_guardar_observaciones.Location = new System.Drawing.Point(258, 238);
            this.btn_guardar_observaciones.Name = "btn_guardar_observaciones";
            this.btn_guardar_observaciones.Size = new System.Drawing.Size(160, 34);
            this.btn_guardar_observaciones.TabIndex = 4;
            this.btn_guardar_observaciones.Text = "Guardar observaciones";
            this.btn_guardar_observaciones.UseVisualStyleBackColor = false;
            this.btn_guardar_observaciones.Click += new System.EventHandler(this.btn_guardar_observaciones_Click);
            //
            // btn_evaluar
            //
            this.btn_evaluar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_evaluar.Location = new System.Drawing.Point(428, 238);
            this.btn_evaluar.Name = "btn_evaluar";
            this.btn_evaluar.Size = new System.Drawing.Size(140, 34);
            this.btn_evaluar.TabIndex = 5;
            this.btn_evaluar.Text = "Pasar a evaluación";
            this.btn_evaluar.UseVisualStyleBackColor = false;
            this.btn_evaluar.Click += new System.EventHandler(this.btn_evaluar_Click);
            //
            // btn_aprobar
            //
            this.btn_aprobar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_aprobar.Location = new System.Drawing.Point(428, 238);
            this.btn_aprobar.Name = "btn_aprobar";
            this.btn_aprobar.Size = new System.Drawing.Size(140, 34);
            this.btn_aprobar.TabIndex = 7;
            this.btn_aprobar.Text = "Aprobar";
            this.btn_aprobar.UseVisualStyleBackColor = false;
            this.btn_aprobar.Click += new System.EventHandler(this.btn_aprobar_Click);
            //
            // pnl_detalle
            //
            this.pnl_detalle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_detalle.Controls.Add(this.lbl_detalle_titulo);
            this.pnl_detalle.Controls.Add(this.pnl_linea_detalle);
            this.pnl_detalle.Controls.Add(this.lbl_cliente);
            this.pnl_detalle.Controls.Add(this.txt_cliente);
            this.pnl_detalle.Controls.Add(this.lbl_poliza);
            this.pnl_detalle.Controls.Add(this.txt_poliza);
            this.pnl_detalle.Controls.Add(this.lbl_tipo);
            this.pnl_detalle.Controls.Add(this.txt_tipo);
            this.pnl_detalle.Controls.Add(this.lbl_fecha);
            this.pnl_detalle.Controls.Add(this.txt_fecha);
            this.pnl_detalle.Controls.Add(this.lbl_ubicacion);
            this.pnl_detalle.Controls.Add(this.txt_ubicacion);
            this.pnl_detalle.Controls.Add(this.lbl_monto);
            this.pnl_detalle.Controls.Add(this.txt_monto);
            this.pnl_detalle.Controls.Add(this.lbl_responsable);
            this.pnl_detalle.Controls.Add(this.txt_responsable);
            this.pnl_detalle.Controls.Add(this.lbl_descripcion);
            this.pnl_detalle.Controls.Add(this.txt_descripcion);
            this.pnl_detalle.Controls.Add(this.pnl_linea_documentacion);
            this.pnl_detalle.Controls.Add(this.lbl_documentacion_titulo);
            this.pnl_detalle.Controls.Add(this.lbl_fotos);
            this.pnl_detalle.Controls.Add(this.lbl_denuncia);
            this.pnl_detalle.Controls.Add(this.btn_ver_fotos);
            this.pnl_detalle.Controls.Add(this.btn_ver_denuncia);
            this.pnl_detalle.Controls.Add(this.lbl_formulario);
            this.pnl_detalle.Controls.Add(this.btn_ver_formulario);
            this.pnl_detalle.Controls.Add(this.btn_cargar_formulario);
            this.pnl_detalle.Location = new System.Drawing.Point(620, 70);
            this.pnl_detalle.Name = "pnl_detalle";
            this.pnl_detalle.Size = new System.Drawing.Size(376, 636);
            this.pnl_detalle.TabIndex = 3;
            //
            // lbl_detalle_titulo
            //
            this.lbl_detalle_titulo.AutoSize = true;
            this.lbl_detalle_titulo.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.lbl_detalle_titulo.Location = new System.Drawing.Point(14, 18);
            this.lbl_detalle_titulo.Name = "lbl_detalle_titulo";
            this.lbl_detalle_titulo.Size = new System.Drawing.Size(121, 20);
            this.lbl_detalle_titulo.Text = "Datos del reclamo";
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
            // lbl_poliza
            //
            this.lbl_poliza.AutoSize = true;
            this.lbl_poliza.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_poliza.Location = new System.Drawing.Point(192, 66);
            this.lbl_poliza.Name = "lbl_poliza";
            this.lbl_poliza.Size = new System.Drawing.Size(38, 15);
            this.lbl_poliza.Text = "Póliza";
            //
            // txt_poliza
            //
            this.txt_poliza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.txt_poliza.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_poliza.Location = new System.Drawing.Point(192, 84);
            this.txt_poliza.Name = "txt_poliza";
            this.txt_poliza.ReadOnly = true;
            this.txt_poliza.Size = new System.Drawing.Size(168, 23);
            this.txt_poliza.TabStop = false;
            //
            // lbl_tipo
            //
            this.lbl_tipo.AutoSize = true;
            this.lbl_tipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_tipo.Location = new System.Drawing.Point(16, 120);
            this.lbl_tipo.Name = "lbl_tipo";
            this.lbl_tipo.Size = new System.Drawing.Size(92, 15);
            this.lbl_tipo.Text = "Tipo de siniestro";
            //
            // txt_tipo
            //
            this.txt_tipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.txt_tipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_tipo.Location = new System.Drawing.Point(16, 138);
            this.txt_tipo.Name = "txt_tipo";
            this.txt_tipo.ReadOnly = true;
            this.txt_tipo.Size = new System.Drawing.Size(168, 23);
            this.txt_tipo.TabStop = false;
            //
            // lbl_fecha
            //
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_fecha.Location = new System.Drawing.Point(192, 120);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(88, 15);
            this.lbl_fecha.Text = "Fecha del hecho";
            //
            // txt_fecha
            //
            this.txt_fecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.txt_fecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_fecha.Location = new System.Drawing.Point(192, 138);
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.ReadOnly = true;
            this.txt_fecha.Size = new System.Drawing.Size(168, 23);
            this.txt_fecha.TabStop = false;
            //
            // lbl_ubicacion
            //
            this.lbl_ubicacion.AutoSize = true;
            this.lbl_ubicacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_ubicacion.Location = new System.Drawing.Point(16, 174);
            this.lbl_ubicacion.Name = "lbl_ubicacion";
            this.lbl_ubicacion.Size = new System.Drawing.Size(107, 15);
            this.lbl_ubicacion.Text = "Ubicación del hecho";
            //
            // txt_ubicacion
            //
            this.txt_ubicacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.txt_ubicacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ubicacion.Location = new System.Drawing.Point(16, 192);
            this.txt_ubicacion.Name = "txt_ubicacion";
            this.txt_ubicacion.ReadOnly = true;
            this.txt_ubicacion.Size = new System.Drawing.Size(344, 23);
            this.txt_ubicacion.TabStop = false;
            //
            // lbl_monto
            //
            this.lbl_monto.AutoSize = true;
            this.lbl_monto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_monto.Location = new System.Drawing.Point(16, 228);
            this.lbl_monto.Name = "lbl_monto";
            this.lbl_monto.Size = new System.Drawing.Size(99, 15);
            this.lbl_monto.Text = "Monto reclamado";
            //
            // txt_monto
            //
            this.txt_monto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.txt_monto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_monto.Location = new System.Drawing.Point(16, 246);
            this.txt_monto.Name = "txt_monto";
            this.txt_monto.ReadOnly = true;
            this.txt_monto.Size = new System.Drawing.Size(168, 23);
            this.txt_monto.TabStop = false;
            //
            // lbl_responsable
            //
            this.lbl_responsable.AutoSize = true;
            this.lbl_responsable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_responsable.Location = new System.Drawing.Point(192, 228);
            this.lbl_responsable.Name = "lbl_responsable";
            this.lbl_responsable.Size = new System.Drawing.Size(121, 15);
            this.lbl_responsable.Text = "Empleado responsable";
            //
            // txt_responsable
            //
            this.txt_responsable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.txt_responsable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_responsable.Location = new System.Drawing.Point(192, 246);
            this.txt_responsable.Name = "txt_responsable";
            this.txt_responsable.ReadOnly = true;
            this.txt_responsable.Size = new System.Drawing.Size(168, 23);
            this.txt_responsable.TabStop = false;
            //
            // lbl_descripcion
            //
            this.lbl_descripcion.AutoSize = true;
            this.lbl_descripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_descripcion.Location = new System.Drawing.Point(16, 282);
            this.lbl_descripcion.Name = "lbl_descripcion";
            this.lbl_descripcion.Size = new System.Drawing.Size(69, 15);
            this.lbl_descripcion.Text = "Descripción";
            //
            // txt_descripcion
            //
            this.txt_descripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.txt_descripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_descripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_descripcion.Location = new System.Drawing.Point(16, 300);
            this.txt_descripcion.Multiline = true;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.ReadOnly = true;
            this.txt_descripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_descripcion.Size = new System.Drawing.Size(344, 142);
            this.txt_descripcion.TabStop = false;
            //
            // pnl_linea_documentacion
            //
            this.pnl_linea_documentacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnl_linea_documentacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(221)))), ((int)(((byte)(232)))));
            this.pnl_linea_documentacion.Location = new System.Drawing.Point(1, 456);
            this.pnl_linea_documentacion.Name = "pnl_linea_documentacion";
            this.pnl_linea_documentacion.Size = new System.Drawing.Size(374, 1);
            this.pnl_linea_documentacion.TabIndex = 21;
            //
            // lbl_documentacion_titulo
            //
            this.lbl_documentacion_titulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_documentacion_titulo.AutoSize = true;
            this.lbl_documentacion_titulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_documentacion_titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(58)))), ((int)(((byte)(92)))));
            this.lbl_documentacion_titulo.Location = new System.Drawing.Point(16, 466);
            this.lbl_documentacion_titulo.Name = "lbl_documentacion_titulo";
            this.lbl_documentacion_titulo.Size = new System.Drawing.Size(143, 15);
            this.lbl_documentacion_titulo.Text = "Documentación recibida";
            //
            // lbl_fotos
            //
            this.lbl_fotos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_fotos.AutoSize = true;
            this.lbl_fotos.Location = new System.Drawing.Point(16, 488);
            this.lbl_fotos.Name = "lbl_fotos";
            this.lbl_fotos.Size = new System.Drawing.Size(84, 15);
            this.lbl_fotos.Text = "Fotos del daño:";
            //
            // lbl_denuncia
            //
            this.lbl_denuncia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_denuncia.AutoSize = true;
            this.lbl_denuncia.Location = new System.Drawing.Point(192, 488);
            this.lbl_denuncia.Name = "lbl_denuncia";
            this.lbl_denuncia.Size = new System.Drawing.Size(58, 15);
            this.lbl_denuncia.Text = "Denuncia:";
            //
            // btn_ver_fotos
            //
            this.btn_ver_fotos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_ver_fotos.Location = new System.Drawing.Point(16, 544);
            this.btn_ver_fotos.Name = "btn_ver_fotos";
            this.btn_ver_fotos.Size = new System.Drawing.Size(120, 34);
            this.btn_ver_fotos.TabIndex = 0;
            this.btn_ver_fotos.Text = "Ver fotos";
            this.btn_ver_fotos.UseVisualStyleBackColor = false;
            this.btn_ver_fotos.Click += new System.EventHandler(this.btn_ver_fotos_Click);
            //
            // btn_ver_denuncia
            //
            this.btn_ver_denuncia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_ver_denuncia.Location = new System.Drawing.Point(146, 544);
            this.btn_ver_denuncia.Name = "btn_ver_denuncia";
            this.btn_ver_denuncia.Size = new System.Drawing.Size(120, 34);
            this.btn_ver_denuncia.TabIndex = 1;
            this.btn_ver_denuncia.Text = "Ver denuncia";
            this.btn_ver_denuncia.UseVisualStyleBackColor = false;
            this.btn_ver_denuncia.Click += new System.EventHandler(this.btn_ver_denuncia_Click);
            //
            // lbl_formulario
            //
            this.lbl_formulario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_formulario.AutoSize = true;
            this.lbl_formulario.Location = new System.Drawing.Point(16, 510);
            this.lbl_formulario.Name = "lbl_formulario";
            this.lbl_formulario.Size = new System.Drawing.Size(68, 15);
            this.lbl_formulario.Text = "Formulario:";
            //
            // btn_ver_formulario
            //
            this.btn_ver_formulario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_ver_formulario.Location = new System.Drawing.Point(16, 586);
            this.btn_ver_formulario.Name = "btn_ver_formulario";
            this.btn_ver_formulario.Size = new System.Drawing.Size(120, 34);
            this.btn_ver_formulario.TabIndex = 2;
            this.btn_ver_formulario.Text = "Ver formulario";
            this.btn_ver_formulario.UseVisualStyleBackColor = false;
            this.btn_ver_formulario.Click += new System.EventHandler(this.btn_ver_formulario_Click);
            //
            // btn_cargar_formulario
            //
            this.btn_cargar_formulario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_cargar_formulario.Location = new System.Drawing.Point(146, 586);
            this.btn_cargar_formulario.Name = "btn_cargar_formulario";
            this.btn_cargar_formulario.Size = new System.Drawing.Size(136, 34);
            this.btn_cargar_formulario.TabIndex = 3;
            this.btn_cargar_formulario.Text = "Cargar formulario";
            this.btn_cargar_formulario.UseVisualStyleBackColor = false;
            this.btn_cargar_formulario.Click += new System.EventHandler(this.btn_cargar_formulario_Click);
            //
            // Siniestros
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1020, 730);
            this.Controls.Add(this.pnl_detalle);
            this.Controls.Add(this.pnl_verificacion);
            this.Controls.Add(this.pnl_lista);
            this.Controls.Add(this.lbl_titulo);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(56)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Siniestros";
            this.Text = "Siniestros";
            this.Load += new System.EventHandler(this.Siniestros_Load);
            this.pnl_lista.ResumeLayout(false);
            this.pnl_lista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_siniestros)).EndInit();
            this.pnl_verificacion.ResumeLayout(false);
            this.pnl_verificacion.PerformLayout();
            this.pnl_detalle.ResumeLayout(false);
            this.pnl_detalle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Panel pnl_lista;
        private System.Windows.Forms.Label lbl_filtro;
        private System.Windows.Forms.ComboBox cb_estado;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.DataGridView dgv_siniestros;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_expediente;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_poliza;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_reclamo;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_estado;
        private System.Windows.Forms.Label lbl_cantidad;
        private System.Windows.Forms.Panel pnl_verificacion;
        private System.Windows.Forms.Label lbl_verificacion_titulo;
        private System.Windows.Forms.CheckBox chk_fotos;
        private System.Windows.Forms.CheckBox chk_denuncia;
        private System.Windows.Forms.CheckBox chk_poliza;
        private System.Windows.Forms.Label lbl_observaciones;
        private System.Windows.Forms.TextBox txt_observaciones;
        private System.Windows.Forms.Label lbl_estado;
        private System.Windows.Forms.Button btn_rechazar;
        private System.Windows.Forms.Button btn_guardar_observaciones;
        private System.Windows.Forms.Button btn_evaluar;
        private System.Windows.Forms.Button btn_aprobar;
        private System.Windows.Forms.Panel pnl_detalle;
        private System.Windows.Forms.Label lbl_detalle_titulo;
        private System.Windows.Forms.Panel pnl_linea_detalle;
        private System.Windows.Forms.Label lbl_cliente;
        private System.Windows.Forms.TextBox txt_cliente;
        private System.Windows.Forms.Label lbl_poliza;
        private System.Windows.Forms.TextBox txt_poliza;
        private System.Windows.Forms.Label lbl_tipo;
        private System.Windows.Forms.TextBox txt_tipo;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.TextBox txt_fecha;
        private System.Windows.Forms.Label lbl_ubicacion;
        private System.Windows.Forms.TextBox txt_ubicacion;
        private System.Windows.Forms.Label lbl_monto;
        private System.Windows.Forms.TextBox txt_monto;
        private System.Windows.Forms.Label lbl_responsable;
        private System.Windows.Forms.TextBox txt_responsable;
        private System.Windows.Forms.Label lbl_descripcion;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.Panel pnl_linea_documentacion;
        private System.Windows.Forms.Label lbl_documentacion_titulo;
        private System.Windows.Forms.Label lbl_fotos;
        private System.Windows.Forms.Label lbl_denuncia;
        private System.Windows.Forms.Button btn_ver_fotos;
        private System.Windows.Forms.Button btn_ver_denuncia;
        private System.Windows.Forms.Label lbl_formulario;
        private System.Windows.Forms.Button btn_ver_formulario;
        private System.Windows.Forms.Button btn_cargar_formulario;
    }
}
