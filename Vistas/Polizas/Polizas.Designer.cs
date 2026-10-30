namespace FixedSegurosApp.Vistas
{
    partial class Polizas
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
            System.Windows.Forms.DataGridViewCellStyle estiloVence = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.btn_comision = new System.Windows.Forms.Button();
            this.btn_alta = new System.Windows.Forms.Button();
            this.pnl_lista = new System.Windows.Forms.Panel();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.btn_nueva = new System.Windows.Forms.Button();
            this.btn_baja = new System.Windows.Forms.Button();
            this.dgv_polizas = new System.Windows.Forms.DataGridView();
            this.col_nro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dominio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_cobertura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_vence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_cantidad = new System.Windows.Forms.Label();
            this.pnl_detalle = new System.Windows.Forms.Panel();
            this.lbl_detalle_titulo = new System.Windows.Forms.Label();
            this.pnl_linea_detalle = new System.Windows.Forms.Panel();
            this.lbl_aseguradora = new System.Windows.Forms.Label();
            this.cb_aseguradora = new System.Windows.Forms.ComboBox();
            this.lbl_cobertura = new System.Windows.Forms.Label();
            this.cb_cobertura = new System.Windows.Forms.ComboBox();
            this.lbl_tipo_vehiculo = new System.Windows.Forms.Label();
            this.cb_tipo_vehiculo = new System.Windows.Forms.ComboBox();
            this.lbl_tipo_prima = new System.Windows.Forms.Label();
            this.cb_tipo_prima = new System.Windows.Forms.ComboBox();
            this.lbl_prima = new System.Windows.Forms.Label();
            this.txt_prima = new System.Windows.Forms.TextBox();
            this.lbl_forma_pago = new System.Windows.Forms.Label();
            this.cb_forma_pago = new System.Windows.Forms.ComboBox();
            this.lbl_descuento = new System.Windows.Forms.Label();
            this.txt_descuento = new System.Windows.Forms.TextBox();
            this.lbl_duracion = new System.Windows.Forms.Label();
            this.txt_duracion = new System.Windows.Forms.TextBox();
            this.lbl_inicio = new System.Windows.Forms.Label();
            this.dtp_inicio = new System.Windows.Forms.DateTimePicker();
            this.lbl_franquicia = new System.Windows.Forms.Label();
            this.txt_franquicia = new System.Windows.Forms.TextBox();
            this.lbl_comision = new System.Windows.Forms.Label();
            this.txt_comision = new System.Windows.Forms.TextBox();
            this.lbl_adicionales = new System.Windows.Forms.Label();
            this.txt_adicionales = new System.Windows.Forms.TextBox();
            this.lbl_requisitos = new System.Windows.Forms.Label();
            this.txt_requisitos = new System.Windows.Forms.TextBox();
            this.lbl_info = new System.Windows.Forms.Label();
            this.pnl_linea_pie = new System.Windows.Forms.Panel();
            this.btn_descartar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.pnl_lista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_polizas)).BeginInit();
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
            this.lbl_titulo.Size = new System.Drawing.Size(84, 30);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Pólizas";
            //
            // btn_comision
            //
            this.btn_comision.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_comision.Location = new System.Drawing.Point(836, 24);
            this.btn_comision.Name = "btn_comision";
            this.btn_comision.Size = new System.Drawing.Size(160, 32);
            this.btn_comision.TabIndex = 3;
            this.btn_comision.Text = "Calcular comisión";
            this.btn_comision.UseVisualStyleBackColor = false;
            this.btn_comision.Click += new System.EventHandler(this.btn_comision_Click);
            //
            // btn_alta
            //
            this.btn_alta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_alta.Location = new System.Drawing.Point(836, 24);
            this.btn_alta.Name = "btn_alta";
            this.btn_alta.Size = new System.Drawing.Size(160, 32);
            this.btn_alta.TabIndex = 4;
            this.btn_alta.Text = "Alta en oficina";
            this.btn_alta.UseVisualStyleBackColor = false;
            this.btn_alta.Click += new System.EventHandler(this.btn_alta_Click);
            //
            // pnl_lista
            //
            this.pnl_lista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_lista.Controls.Add(this.txt_buscar);
            this.pnl_lista.Controls.Add(this.btn_nueva);
            this.pnl_lista.Controls.Add(this.btn_baja);
            this.pnl_lista.Controls.Add(this.dgv_polizas);
            this.pnl_lista.Controls.Add(this.lbl_cantidad);
            this.pnl_lista.Location = new System.Drawing.Point(24, 70);
            this.pnl_lista.Name = "pnl_lista";
            this.pnl_lista.Size = new System.Drawing.Size(584, 636);
            this.pnl_lista.TabIndex = 1;
            //
            // txt_buscar
            //
            this.txt_buscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_buscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_buscar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_buscar.Location = new System.Drawing.Point(16, 16);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(302, 25);
            this.txt_buscar.TabIndex = 0;
            this.txt_buscar.TextChanged += new System.EventHandler(this.txt_buscar_TextChanged);
            //
            // btn_nueva
            //
            this.btn_nueva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_nueva.Location = new System.Drawing.Point(326, 14);
            this.btn_nueva.Name = "btn_nueva";
            this.btn_nueva.Size = new System.Drawing.Size(130, 30);
            this.btn_nueva.TabIndex = 1;
            this.btn_nueva.Text = "Nueva póliza";
            this.btn_nueva.UseVisualStyleBackColor = false;
            this.btn_nueva.Click += new System.EventHandler(this.btn_nueva_Click);
            //
            // btn_baja
            //
            this.btn_baja.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_baja.Location = new System.Drawing.Point(462, 14);
            this.btn_baja.Name = "btn_baja";
            this.btn_baja.Size = new System.Drawing.Size(106, 30);
            this.btn_baja.TabIndex = 2;
            this.btn_baja.Text = "Dar de baja";
            this.btn_baja.UseVisualStyleBackColor = false;
            this.btn_baja.Click += new System.EventHandler(this.btn_baja_Click);
            //
            // dgv_polizas
            //
            this.dgv_polizas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_polizas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_nro,
            this.col_cliente,
            this.col_dominio,
            this.col_cobertura,
            this.col_vence,
            this.col_estado});
            this.dgv_polizas.Location = new System.Drawing.Point(1, 58);
            this.dgv_polizas.Name = "dgv_polizas";
            this.dgv_polizas.Size = new System.Drawing.Size(582, 536);
            this.dgv_polizas.TabIndex = 3;
            this.dgv_polizas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_polizas_CellFormatting);
            this.dgv_polizas.SelectionChanged += new System.EventHandler(this.dgv_polizas_SelectionChanged);
            //
            // col_nro
            //
            this.col_nro.DataPropertyName = "NroTexto";
            this.col_nro.FillWeight = 60F;
            this.col_nro.HeaderText = "N°";
            this.col_nro.Name = "col_nro";
            //
            // col_cliente
            //
            this.col_cliente.DataPropertyName = "ClienteTexto";
            this.col_cliente.FillWeight = 120F;
            this.col_cliente.HeaderText = "Cliente";
            this.col_cliente.Name = "col_cliente";
            //
            // col_dominio
            //
            this.col_dominio.DataPropertyName = "Dominio";
            this.col_dominio.FillWeight = 70F;
            this.col_dominio.HeaderText = "Dominio";
            this.col_dominio.Name = "col_dominio";
            //
            // col_cobertura
            //
            this.col_cobertura.DataPropertyName = "TipoCobertura";
            this.col_cobertura.FillWeight = 95F;
            this.col_cobertura.HeaderText = "Cobertura";
            this.col_cobertura.Name = "col_cobertura";
            //
            // col_vence
            //
            this.col_vence.DataPropertyName = "FechaVencimiento";
            estiloVence.Format = "dd/MM/yyyy";
            this.col_vence.DefaultCellStyle = estiloVence;
            this.col_vence.FillWeight = 75F;
            this.col_vence.HeaderText = "Vence";
            this.col_vence.Name = "col_vence";
            //
            // col_estado
            //
            this.col_estado.DataPropertyName = "EstadoMostrado";
            this.col_estado.FillWeight = 80F;
            this.col_estado.HeaderText = "Estado";
            this.col_estado.Name = "col_estado";
            //
            // lbl_cantidad
            //
            this.lbl_cantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_cantidad.AutoSize = true;
            this.lbl_cantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_cantidad.Location = new System.Drawing.Point(16, 606);
            this.lbl_cantidad.Name = "lbl_cantidad";
            this.lbl_cantidad.Size = new System.Drawing.Size(121, 15);
            this.lbl_cantidad.TabIndex = 4;
            this.lbl_cantidad.Text = "Mostrando 0 pólizas";
            //
            // pnl_detalle
            //
            this.pnl_detalle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_detalle.Controls.Add(this.lbl_detalle_titulo);
            this.pnl_detalle.Controls.Add(this.pnl_linea_detalle);
            this.pnl_detalle.Controls.Add(this.lbl_aseguradora);
            this.pnl_detalle.Controls.Add(this.cb_aseguradora);
            this.pnl_detalle.Controls.Add(this.lbl_cobertura);
            this.pnl_detalle.Controls.Add(this.cb_cobertura);
            this.pnl_detalle.Controls.Add(this.lbl_tipo_vehiculo);
            this.pnl_detalle.Controls.Add(this.cb_tipo_vehiculo);
            this.pnl_detalle.Controls.Add(this.lbl_tipo_prima);
            this.pnl_detalle.Controls.Add(this.cb_tipo_prima);
            this.pnl_detalle.Controls.Add(this.lbl_prima);
            this.pnl_detalle.Controls.Add(this.txt_prima);
            this.pnl_detalle.Controls.Add(this.lbl_forma_pago);
            this.pnl_detalle.Controls.Add(this.cb_forma_pago);
            this.pnl_detalle.Controls.Add(this.lbl_descuento);
            this.pnl_detalle.Controls.Add(this.txt_descuento);
            this.pnl_detalle.Controls.Add(this.lbl_duracion);
            this.pnl_detalle.Controls.Add(this.txt_duracion);
            this.pnl_detalle.Controls.Add(this.lbl_inicio);
            this.pnl_detalle.Controls.Add(this.dtp_inicio);
            this.pnl_detalle.Controls.Add(this.lbl_franquicia);
            this.pnl_detalle.Controls.Add(this.txt_franquicia);
            this.pnl_detalle.Controls.Add(this.lbl_comision);
            this.pnl_detalle.Controls.Add(this.txt_comision);
            this.pnl_detalle.Controls.Add(this.lbl_adicionales);
            this.pnl_detalle.Controls.Add(this.txt_adicionales);
            this.pnl_detalle.Controls.Add(this.lbl_requisitos);
            this.pnl_detalle.Controls.Add(this.txt_requisitos);
            this.pnl_detalle.Controls.Add(this.lbl_info);
            this.pnl_detalle.Controls.Add(this.pnl_linea_pie);
            this.pnl_detalle.Controls.Add(this.btn_descartar);
            this.pnl_detalle.Controls.Add(this.btn_guardar);
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
            this.lbl_detalle_titulo.Size = new System.Drawing.Size(139, 20);
            this.lbl_detalle_titulo.TabIndex = 0;
            this.lbl_detalle_titulo.Text = "Datos de la póliza";
            //
            // pnl_linea_detalle
            //
            this.pnl_linea_detalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(221)))), ((int)(((byte)(232)))));
            this.pnl_linea_detalle.Location = new System.Drawing.Point(1, 54);
            this.pnl_linea_detalle.Name = "pnl_linea_detalle";
            this.pnl_linea_detalle.Size = new System.Drawing.Size(374, 1);
            this.pnl_linea_detalle.TabIndex = 20;
            //
            // lbl_aseguradora
            //
            this.lbl_aseguradora.AutoSize = true;
            this.lbl_aseguradora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_aseguradora.Location = new System.Drawing.Point(16, 66);
            this.lbl_aseguradora.Name = "lbl_aseguradora";
            this.lbl_aseguradora.Size = new System.Drawing.Size(131, 15);
            this.lbl_aseguradora.Text = "Compañía aseguradora";
            //
            // cb_aseguradora
            //
            this.cb_aseguradora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_aseguradora.Location = new System.Drawing.Point(16, 86);
            this.cb_aseguradora.Name = "cb_aseguradora";
            this.cb_aseguradora.Size = new System.Drawing.Size(164, 23);
            this.cb_aseguradora.TabIndex = 1;
            //
            // lbl_cobertura
            //
            this.lbl_cobertura.AutoSize = true;
            this.lbl_cobertura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_cobertura.Location = new System.Drawing.Point(196, 66);
            this.lbl_cobertura.Name = "lbl_cobertura";
            this.lbl_cobertura.Size = new System.Drawing.Size(60, 15);
            this.lbl_cobertura.Text = "Cobertura";
            //
            // cb_cobertura
            //
            this.cb_cobertura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_cobertura.Items.AddRange(new object[] {
            "Responsabilidad civil",
            "Terceros",
            "Terceros completo",
            "Todo riesgo"});
            this.cb_cobertura.Location = new System.Drawing.Point(196, 86);
            this.cb_cobertura.Name = "cb_cobertura";
            this.cb_cobertura.Size = new System.Drawing.Size(164, 23);
            this.cb_cobertura.TabIndex = 2;
            //
            // lbl_tipo_vehiculo
            //
            this.lbl_tipo_vehiculo.AutoSize = true;
            this.lbl_tipo_vehiculo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_tipo_vehiculo.Location = new System.Drawing.Point(16, 120);
            this.lbl_tipo_vehiculo.Name = "lbl_tipo_vehiculo";
            this.lbl_tipo_vehiculo.Size = new System.Drawing.Size(94, 15);
            this.lbl_tipo_vehiculo.Text = "Tipo de vehículo";
            //
            // cb_tipo_vehiculo
            //
            this.cb_tipo_vehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_tipo_vehiculo.Items.AddRange(new object[] {
            "Automóvil",
            "Camioneta",
            "Motocicleta",
            "Camión"});
            this.cb_tipo_vehiculo.Location = new System.Drawing.Point(16, 140);
            this.cb_tipo_vehiculo.Name = "cb_tipo_vehiculo";
            this.cb_tipo_vehiculo.Size = new System.Drawing.Size(164, 23);
            this.cb_tipo_vehiculo.TabIndex = 3;
            //
            // lbl_tipo_prima
            //
            this.lbl_tipo_prima.AutoSize = true;
            this.lbl_tipo_prima.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_tipo_prima.Location = new System.Drawing.Point(196, 120);
            this.lbl_tipo_prima.Name = "lbl_tipo_prima";
            this.lbl_tipo_prima.Size = new System.Drawing.Size(80, 15);
            this.lbl_tipo_prima.Text = "Tipo de prima";
            //
            // cb_tipo_prima
            //
            this.cb_tipo_prima.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_tipo_prima.Items.AddRange(new object[] {
            "Mensual",
            "Trimestral",
            "Semestral",
            "Anual"});
            this.cb_tipo_prima.Location = new System.Drawing.Point(196, 140);
            this.cb_tipo_prima.Name = "cb_tipo_prima";
            this.cb_tipo_prima.Size = new System.Drawing.Size(164, 23);
            this.cb_tipo_prima.TabIndex = 4;
            //
            // lbl_prima
            //
            this.lbl_prima.AutoSize = true;
            this.lbl_prima.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_prima.Location = new System.Drawing.Point(16, 174);
            this.lbl_prima.Name = "lbl_prima";
            this.lbl_prima.Size = new System.Drawing.Size(99, 15);
            this.lbl_prima.Text = "Prima (por cuota)";
            //
            // txt_prima
            //
            this.txt_prima.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_prima.Location = new System.Drawing.Point(16, 194);
            this.txt_prima.MaxLength = 15;
            this.txt_prima.Name = "txt_prima";
            this.txt_prima.Size = new System.Drawing.Size(164, 23);
            this.txt_prima.TabIndex = 5;
            //
            // lbl_forma_pago
            //
            this.lbl_forma_pago.AutoSize = true;
            this.lbl_forma_pago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_forma_pago.Location = new System.Drawing.Point(196, 174);
            this.lbl_forma_pago.Name = "lbl_forma_pago";
            this.lbl_forma_pago.Size = new System.Drawing.Size(85, 15);
            this.lbl_forma_pago.Text = "Forma de pago";
            //
            // cb_forma_pago
            //
            this.cb_forma_pago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_forma_pago.Items.AddRange(new object[] {
            "Débito automático",
            "Tarjeta de crédito",
            "Transferencia bancaria",
            "Efectivo",
            "Todas las formas de pago"});
            this.cb_forma_pago.Location = new System.Drawing.Point(196, 194);
            this.cb_forma_pago.Name = "cb_forma_pago";
            this.cb_forma_pago.Size = new System.Drawing.Size(164, 23);
            this.cb_forma_pago.TabIndex = 6;
            //
            // lbl_descuento
            //
            this.lbl_descuento.AutoSize = true;
            this.lbl_descuento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_descuento.Location = new System.Drawing.Point(16, 228);
            this.lbl_descuento.Name = "lbl_descuento";
            this.lbl_descuento.Size = new System.Drawing.Size(132, 15);
            this.lbl_descuento.Text = "Descuentos posibles (%)";
            //
            // txt_descuento
            //
            this.txt_descuento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_descuento.Location = new System.Drawing.Point(16, 248);
            this.txt_descuento.MaxLength = 6;
            this.txt_descuento.Name = "txt_descuento";
            this.txt_descuento.Size = new System.Drawing.Size(164, 23);
            this.txt_descuento.TabIndex = 7;
            //
            // lbl_duracion
            //
            this.lbl_duracion.AutoSize = true;
            this.lbl_duracion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_duracion.Location = new System.Drawing.Point(196, 228);
            this.lbl_duracion.Name = "lbl_duracion";
            this.lbl_duracion.Size = new System.Drawing.Size(100, 15);
            this.lbl_duracion.Text = "Duración (meses)";
            //
            // txt_duracion
            //
            this.txt_duracion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_duracion.Location = new System.Drawing.Point(196, 248);
            this.txt_duracion.MaxLength = 2;
            this.txt_duracion.Name = "txt_duracion";
            this.txt_duracion.Size = new System.Drawing.Size(164, 23);
            this.txt_duracion.TabIndex = 8;
            //
            // lbl_inicio
            //
            this.lbl_inicio.AutoSize = true;
            this.lbl_inicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_inicio.Location = new System.Drawing.Point(16, 282);
            this.lbl_inicio.Name = "lbl_inicio";
            this.lbl_inicio.Size = new System.Drawing.Size(140, 15);
            this.lbl_inicio.Text = "Fecha de inicio propuesta";
            //
            // dtp_inicio
            //
            this.dtp_inicio.CustomFormat = "dd/MM/yyyy";
            this.dtp_inicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_inicio.Location = new System.Drawing.Point(16, 302);
            this.dtp_inicio.Name = "dtp_inicio";
            this.dtp_inicio.Size = new System.Drawing.Size(164, 23);
            this.dtp_inicio.TabIndex = 9;
            //
            // lbl_franquicia
            //
            this.lbl_franquicia.AutoSize = true;
            this.lbl_franquicia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_franquicia.Location = new System.Drawing.Point(196, 282);
            this.lbl_franquicia.Name = "lbl_franquicia";
            this.lbl_franquicia.Size = new System.Drawing.Size(61, 15);
            this.lbl_franquicia.Text = "Franquicia";
            //
            // txt_franquicia
            //
            this.txt_franquicia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_franquicia.Location = new System.Drawing.Point(196, 302);
            this.txt_franquicia.MaxLength = 15;
            this.txt_franquicia.Name = "txt_franquicia";
            this.txt_franquicia.Size = new System.Drawing.Size(164, 23);
            this.txt_franquicia.TabIndex = 10;
            //
            // lbl_comision
            //
            this.lbl_comision.AutoSize = true;
            this.lbl_comision.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_comision.Location = new System.Drawing.Point(16, 336);
            this.lbl_comision.Name = "lbl_comision";
            this.lbl_comision.Size = new System.Drawing.Size(80, 15);
            this.lbl_comision.Text = "Comisión (%)";
            //
            // txt_comision
            //
            this.txt_comision.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_comision.Location = new System.Drawing.Point(16, 356);
            this.txt_comision.MaxLength = 7;
            this.txt_comision.Name = "txt_comision";
            this.txt_comision.Size = new System.Drawing.Size(164, 23);
            this.txt_comision.TabIndex = 11;
            //
            // lbl_adicionales
            //
            this.lbl_adicionales.AutoSize = true;
            this.lbl_adicionales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_adicionales.Location = new System.Drawing.Point(196, 336);
            this.lbl_adicionales.Name = "lbl_adicionales";
            this.lbl_adicionales.Size = new System.Drawing.Size(66, 15);
            this.lbl_adicionales.Text = "Adicionales";
            //
            // txt_adicionales
            //
            this.txt_adicionales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_adicionales.Location = new System.Drawing.Point(196, 356);
            this.txt_adicionales.MaxLength = 200;
            this.txt_adicionales.Name = "txt_adicionales";
            this.txt_adicionales.Size = new System.Drawing.Size(164, 23);
            this.txt_adicionales.TabIndex = 12;
            //
            // lbl_requisitos
            //
            this.lbl_requisitos.AutoSize = true;
            this.lbl_requisitos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_requisitos.Location = new System.Drawing.Point(16, 390);
            this.lbl_requisitos.Name = "lbl_requisitos";
            this.lbl_requisitos.Size = new System.Drawing.Size(141, 15);
            this.lbl_requisitos.Text = "Condiciones o requisitos";
            //
            // txt_requisitos
            //
            this.txt_requisitos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_requisitos.Location = new System.Drawing.Point(16, 410);
            this.txt_requisitos.MaxLength = 200;
            this.txt_requisitos.Multiline = true;
            this.txt_requisitos.Name = "txt_requisitos";
            this.txt_requisitos.Size = new System.Drawing.Size(344, 60);
            this.txt_requisitos.TabIndex = 13;
            //
            // lbl_info
            //
            this.lbl_info.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_info.Location = new System.Drawing.Point(16, 482);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(344, 80);
            this.lbl_info.Text = "Información de la póliza";
            //
            // pnl_linea_pie
            //
            this.pnl_linea_pie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnl_linea_pie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(221)))), ((int)(((byte)(232)))));
            this.pnl_linea_pie.Location = new System.Drawing.Point(1, 572);
            this.pnl_linea_pie.Name = "pnl_linea_pie";
            this.pnl_linea_pie.Size = new System.Drawing.Size(374, 1);
            this.pnl_linea_pie.TabIndex = 22;
            //
            // btn_descartar
            //
            this.btn_descartar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_descartar.Location = new System.Drawing.Point(124, 586);
            this.btn_descartar.Name = "btn_descartar";
            this.btn_descartar.Size = new System.Drawing.Size(110, 34);
            this.btn_descartar.TabIndex = 15;
            this.btn_descartar.Text = "Descartar";
            this.btn_descartar.UseVisualStyleBackColor = false;
            this.btn_descartar.Click += new System.EventHandler(this.btn_descartar_Click);
            //
            // btn_guardar
            //
            this.btn_guardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_guardar.Location = new System.Drawing.Point(240, 586);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(120, 34);
            this.btn_guardar.TabIndex = 14;
            this.btn_guardar.Text = "Guardar cambios";
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            //
            // Polizas
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1020, 730);
            this.Controls.Add(this.pnl_detalle);
            this.Controls.Add(this.pnl_lista);
            this.Controls.Add(this.btn_alta);
            this.Controls.Add(this.btn_comision);
            this.Controls.Add(this.lbl_titulo);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(56)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Polizas";
            this.Text = "Pólizas";
            this.Load += new System.EventHandler(this.Polizas_Load);
            this.pnl_lista.ResumeLayout(false);
            this.pnl_lista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_polizas)).EndInit();
            this.pnl_detalle.ResumeLayout(false);
            this.pnl_detalle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Button btn_comision;
        private System.Windows.Forms.Button btn_alta;
        private System.Windows.Forms.Panel pnl_lista;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Button btn_nueva;
        private System.Windows.Forms.Button btn_baja;
        private System.Windows.Forms.DataGridView dgv_polizas;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_nro;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dominio;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cobertura;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_vence;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_estado;
        private System.Windows.Forms.Label lbl_cantidad;
        private System.Windows.Forms.Panel pnl_detalle;
        private System.Windows.Forms.Label lbl_detalle_titulo;
        private System.Windows.Forms.Panel pnl_linea_detalle;
        private System.Windows.Forms.Label lbl_aseguradora;
        private System.Windows.Forms.ComboBox cb_aseguradora;
        private System.Windows.Forms.Label lbl_cobertura;
        private System.Windows.Forms.ComboBox cb_cobertura;
        private System.Windows.Forms.Label lbl_tipo_vehiculo;
        private System.Windows.Forms.ComboBox cb_tipo_vehiculo;
        private System.Windows.Forms.Label lbl_tipo_prima;
        private System.Windows.Forms.ComboBox cb_tipo_prima;
        private System.Windows.Forms.Label lbl_prima;
        private System.Windows.Forms.TextBox txt_prima;
        private System.Windows.Forms.Label lbl_forma_pago;
        private System.Windows.Forms.ComboBox cb_forma_pago;
        private System.Windows.Forms.Label lbl_descuento;
        private System.Windows.Forms.TextBox txt_descuento;
        private System.Windows.Forms.Label lbl_duracion;
        private System.Windows.Forms.TextBox txt_duracion;
        private System.Windows.Forms.Label lbl_inicio;
        private System.Windows.Forms.DateTimePicker dtp_inicio;
        private System.Windows.Forms.Label lbl_franquicia;
        private System.Windows.Forms.TextBox txt_franquicia;
        private System.Windows.Forms.Label lbl_comision;
        private System.Windows.Forms.TextBox txt_comision;
        private System.Windows.Forms.Label lbl_adicionales;
        private System.Windows.Forms.TextBox txt_adicionales;
        private System.Windows.Forms.Label lbl_requisitos;
        private System.Windows.Forms.TextBox txt_requisitos;
        private System.Windows.Forms.Label lbl_info;
        private System.Windows.Forms.Panel pnl_linea_pie;
        private System.Windows.Forms.Button btn_descartar;
        private System.Windows.Forms.Button btn_guardar;
    }
}
