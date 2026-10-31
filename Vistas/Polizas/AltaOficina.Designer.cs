namespace FixedSegurosApp.Vistas
{
    partial class AltaOficina
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
            System.Windows.Forms.DataGridViewCellStyle estiloCuota = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.btn_volver = new System.Windows.Forms.Button();
            this.pnl_cliente = new System.Windows.Forms.Panel();
            this.lbl_cliente_titulo = new System.Windows.Forms.Label();
            this.pnl_linea_cliente_titulo = new System.Windows.Forms.Panel();
            this.lbl_dni = new System.Windows.Forms.Label();
            this.txt_dni = new System.Windows.Forms.TextBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.lbl_nacimiento = new System.Windows.Forms.Label();
            this.dtp_nacimiento = new System.Windows.Forms.DateTimePicker();
            this.lbl_provincia = new System.Windows.Forms.Label();
            this.cb_provincia = new System.Windows.Forms.ComboBox();
            this.lbl_ciudad = new System.Windows.Forms.Label();
            this.txt_ciudad = new System.Windows.Forms.TextBox();
            this.lbl_direccion = new System.Windows.Forms.Label();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.lbl_telefono = new System.Windows.Forms.Label();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lbl_cliente_info = new System.Windows.Forms.Label();
            this.pnl_vehiculo = new System.Windows.Forms.Panel();
            this.lbl_vehiculo_titulo = new System.Windows.Forms.Label();
            this.pnl_linea_vehiculo_titulo = new System.Windows.Forms.Panel();
            this.lbl_vehiculo = new System.Windows.Forms.Label();
            this.cb_vehiculo = new System.Windows.Forms.ComboBox();
            this.lbl_tipo = new System.Windows.Forms.Label();
            this.cb_tipo = new System.Windows.Forms.ComboBox();
            this.lbl_dominio = new System.Windows.Forms.Label();
            this.txt_dominio = new System.Windows.Forms.TextBox();
            this.lbl_marca = new System.Windows.Forms.Label();
            this.txt_marca = new System.Windows.Forms.TextBox();
            this.lbl_modelo = new System.Windows.Forms.Label();
            this.txt_modelo = new System.Windows.Forms.TextBox();
            this.lbl_anio = new System.Windows.Forms.Label();
            this.txt_anio = new System.Windows.Forms.TextBox();
            this.lbl_vtv = new System.Windows.Forms.Label();
            this.cb_vtv = new System.Windows.Forms.ComboBox();
            this.lbl_chasis = new System.Windows.Forms.Label();
            this.txt_chasis = new System.Windows.Forms.TextBox();
            this.lbl_motor = new System.Windows.Forms.Label();
            this.txt_motor = new System.Windows.Forms.TextBox();
            this.grp_fotos = new System.Windows.Forms.GroupBox();
            this.pnl_poliza = new System.Windows.Forms.Panel();
            this.lbl_poliza_titulo = new System.Windows.Forms.Label();
            this.pnl_linea_poliza_titulo = new System.Windows.Forms.Panel();
            this.lbl_ofrecidas = new System.Windows.Forms.Label();
            this.dgv_ofrecidas = new System.Windows.Forms.DataGridView();
            this.col_of_aseguradora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_of_cobertura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_of_cuota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_oferta = new System.Windows.Forms.Label();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_crear = new System.Windows.Forms.Button();
            this.pnl_cliente.SuspendLayout();
            this.pnl_vehiculo.SuspendLayout();
            this.pnl_poliza.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ofrecidas)).BeginInit();
            this.SuspendLayout();
            //
            // lbl_titulo
            //
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Segoe UI Semibold", 16F);
            this.lbl_titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(58)))), ((int)(((byte)(92)))));
            this.lbl_titulo.Location = new System.Drawing.Point(20, 20);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(250, 30);
            this.lbl_titulo.Text = "Pólizas › Alta en oficina";
            //
            // btn_volver
            //
            this.btn_volver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_volver.Location = new System.Drawing.Point(836, 20);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(160, 32);
            this.btn_volver.TabIndex = 1;
            this.btn_volver.Text = "Volver a Pólizas";
            this.btn_volver.UseVisualStyleBackColor = false;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            //
            // pnl_cliente
            //
            this.pnl_cliente.Controls.Add(this.lbl_cliente_titulo);
            this.pnl_cliente.Controls.Add(this.pnl_linea_cliente_titulo);
            this.pnl_cliente.Controls.Add(this.lbl_dni);
            this.pnl_cliente.Controls.Add(this.txt_dni);
            this.pnl_cliente.Controls.Add(this.btn_buscar);
            this.pnl_cliente.Controls.Add(this.lbl_nombre);
            this.pnl_cliente.Controls.Add(this.txt_nombre);
            this.pnl_cliente.Controls.Add(this.lbl_apellido);
            this.pnl_cliente.Controls.Add(this.txt_apellido);
            this.pnl_cliente.Controls.Add(this.lbl_nacimiento);
            this.pnl_cliente.Controls.Add(this.dtp_nacimiento);
            this.pnl_cliente.Controls.Add(this.lbl_provincia);
            this.pnl_cliente.Controls.Add(this.cb_provincia);
            this.pnl_cliente.Controls.Add(this.lbl_ciudad);
            this.pnl_cliente.Controls.Add(this.txt_ciudad);
            this.pnl_cliente.Controls.Add(this.lbl_direccion);
            this.pnl_cliente.Controls.Add(this.txt_direccion);
            this.pnl_cliente.Controls.Add(this.lbl_telefono);
            this.pnl_cliente.Controls.Add(this.txt_telefono);
            this.pnl_cliente.Controls.Add(this.lbl_email);
            this.pnl_cliente.Controls.Add(this.txt_email);
                       this.pnl_cliente.Location = new System.Drawing.Point(24, 66);
            this.pnl_cliente.Name = "pnl_cliente";
            this.pnl_cliente.Size = new System.Drawing.Size(290, 510);
            this.pnl_cliente.TabIndex = 1;
            //
            // lbl_cliente_titulo
            //
            this.lbl_cliente_titulo.AutoSize = true;
            this.lbl_cliente_titulo.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.lbl_cliente_titulo.Location = new System.Drawing.Point(14, 12);
            this.lbl_cliente_titulo.Name = "lbl_cliente_titulo";
            this.lbl_cliente_titulo.Size = new System.Drawing.Size(120, 20);
            this.lbl_cliente_titulo.Text = "1. Cliente";
            //
            // pnl_linea_cliente_titulo
            //
            this.pnl_linea_cliente_titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(221)))), ((int)(((byte)(232)))));
            this.pnl_linea_cliente_titulo.Location = new System.Drawing.Point(1, 42);
            this.pnl_linea_cliente_titulo.Name = "pnl_linea_cliente_titulo";
            this.pnl_linea_cliente_titulo.Size = new System.Drawing.Size(288, 1);
            //
            // lbl_dni
            //
            this.lbl_dni.AutoSize = true;
            this.lbl_dni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_dni.Location = new System.Drawing.Point(14, 52);
            this.lbl_dni.Name = "lbl_dni";
            this.lbl_dni.Size = new System.Drawing.Size(60, 15);
            this.lbl_dni.Text = "DNI";
            //
            // txt_dni
            //
            this.txt_dni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_dni.Location = new System.Drawing.Point(14, 70);
            this.txt_dni.MaxLength = 8;
            this.txt_dni.Name = "txt_dni";
            this.txt_dni.TextChanged += new System.EventHandler(this.txt_dni_TextChanged);
            this.txt_dni.Size = new System.Drawing.Size(170, 23);
            this.txt_dni.TabIndex = 2;
            //
            // btn_buscar
            //
            this.btn_buscar.Location = new System.Drawing.Point(190, 68);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(86, 27);
            this.btn_buscar.TabIndex = 3;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            //
            // lbl_nombre
            //
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_nombre.Location = new System.Drawing.Point(14, 102);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(60, 15);
            this.lbl_nombre.Text = "Nombres";
            //
            // txt_nombre
            //
            this.txt_nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_nombre.Location = new System.Drawing.Point(14, 120);
            this.txt_nombre.MaxLength = 50;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(262, 23);
            this.txt_nombre.TabIndex = 4;
            //
            // lbl_apellido
            //
            this.lbl_apellido.AutoSize = true;
            this.lbl_apellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_apellido.Location = new System.Drawing.Point(14, 152);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(60, 15);
            this.lbl_apellido.Text = "Apellidos";
            //
            // txt_apellido
            //
            this.txt_apellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_apellido.Location = new System.Drawing.Point(14, 170);
            this.txt_apellido.MaxLength = 50;
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(262, 23);
            this.txt_apellido.TabIndex = 5;
            //
            // lbl_nacimiento
            //
            this.lbl_nacimiento.AutoSize = true;
            this.lbl_nacimiento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_nacimiento.Location = new System.Drawing.Point(14, 202);
            this.lbl_nacimiento.Name = "lbl_nacimiento";
            this.lbl_nacimiento.Size = new System.Drawing.Size(60, 15);
            this.lbl_nacimiento.Text = "Fecha de nacimiento";
            //
            // dtp_nacimiento
            //
            this.dtp_nacimiento.CustomFormat = "dd/MM/yyyy";
            this.dtp_nacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_nacimiento.Location = new System.Drawing.Point(14, 220);
            this.dtp_nacimiento.Name = "dtp_nacimiento";
            this.dtp_nacimiento.Size = new System.Drawing.Size(262, 23);
            this.dtp_nacimiento.TabIndex = 6;
            //
            // lbl_provincia
            //
            this.lbl_provincia.AutoSize = true;
            this.lbl_provincia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_provincia.Location = new System.Drawing.Point(14, 252);
            this.lbl_provincia.Name = "lbl_provincia";
            this.lbl_provincia.Size = new System.Drawing.Size(60, 15);
            this.lbl_provincia.Text = "Provincia";
            //
            // cb_provincia
            //
            this.cb_provincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_provincia.Location = new System.Drawing.Point(14, 270);
            this.cb_provincia.Name = "cb_provincia";
            this.cb_provincia.Size = new System.Drawing.Size(262, 23);
            this.cb_provincia.TabIndex = 7;
            //
            // lbl_ciudad
            //
            this.lbl_ciudad.AutoSize = true;
            this.lbl_ciudad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_ciudad.Location = new System.Drawing.Point(14, 302);
            this.lbl_ciudad.Name = "lbl_ciudad";
            this.lbl_ciudad.Size = new System.Drawing.Size(60, 15);
            this.lbl_ciudad.Text = "Ciudad";
            //
            // txt_ciudad
            //
            this.txt_ciudad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ciudad.Location = new System.Drawing.Point(14, 320);
            this.txt_ciudad.MaxLength = 60;
            this.txt_ciudad.Name = "txt_ciudad";
            this.txt_ciudad.Size = new System.Drawing.Size(262, 23);
            this.txt_ciudad.TabIndex = 8;
            //
            // lbl_direccion
            //
            this.lbl_direccion.AutoSize = true;
            this.lbl_direccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_direccion.Location = new System.Drawing.Point(14, 352);
            this.lbl_direccion.Name = "lbl_direccion";
            this.lbl_direccion.Size = new System.Drawing.Size(60, 15);
            this.lbl_direccion.Text = "Dirección";
            //
            // txt_direccion
            //
            this.txt_direccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_direccion.Location = new System.Drawing.Point(14, 370);
            this.txt_direccion.MaxLength = 50;
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(262, 23);
            this.txt_direccion.TabIndex = 9;
            //
            // lbl_telefono
            //
            this.lbl_telefono.AutoSize = true;
            this.lbl_telefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_telefono.Location = new System.Drawing.Point(14, 402);
            this.lbl_telefono.Name = "lbl_telefono";
            this.lbl_telefono.Size = new System.Drawing.Size(60, 15);
            this.lbl_telefono.Text = "Teléfono";
            //
            // txt_telefono
            //
            this.txt_telefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_telefono.Location = new System.Drawing.Point(14, 420);
            this.txt_telefono.MaxLength = 12;
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(262, 23);
            this.txt_telefono.TabIndex = 10;
            //
            // lbl_email
            //
            this.lbl_email.AutoSize = true;
            this.lbl_email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_email.Location = new System.Drawing.Point(14, 452);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(60, 15);
            this.lbl_email.Text = "Email";
            //
            // txt_email
            //
            this.txt_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_email.Location = new System.Drawing.Point(14, 470);
            this.txt_email.MaxLength = 40;
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(262, 23);
            this.txt_email.TabIndex = 11;
            //
            // lbl_cliente_info
            //
            this.lbl_cliente_info.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_cliente_info.Location = new System.Drawing.Point(26, 594);
            this.lbl_cliente_info.Name = "lbl_cliente_info";
            this.lbl_cliente_info.Size = new System.Drawing.Size(680, 18);
            this.lbl_cliente_info.Text = "Cliente nuevo";
            //
            // pnl_vehiculo
            //
            this.pnl_vehiculo.Controls.Add(this.lbl_vehiculo_titulo);
            this.pnl_vehiculo.Controls.Add(this.pnl_linea_vehiculo_titulo);
            this.pnl_vehiculo.Controls.Add(this.lbl_vehiculo);
            this.pnl_vehiculo.Controls.Add(this.cb_vehiculo);
            this.pnl_vehiculo.Controls.Add(this.lbl_tipo);
            this.pnl_vehiculo.Controls.Add(this.cb_tipo);
            this.pnl_vehiculo.Controls.Add(this.lbl_dominio);
            this.pnl_vehiculo.Controls.Add(this.txt_dominio);
            this.pnl_vehiculo.Controls.Add(this.lbl_marca);
            this.pnl_vehiculo.Controls.Add(this.txt_marca);
            this.pnl_vehiculo.Controls.Add(this.lbl_modelo);
            this.pnl_vehiculo.Controls.Add(this.txt_modelo);
            this.pnl_vehiculo.Controls.Add(this.lbl_anio);
            this.pnl_vehiculo.Controls.Add(this.txt_anio);
            this.pnl_vehiculo.Controls.Add(this.lbl_vtv);
            this.pnl_vehiculo.Controls.Add(this.cb_vtv);
            this.pnl_vehiculo.Controls.Add(this.lbl_chasis);
            this.pnl_vehiculo.Controls.Add(this.txt_chasis);
            this.pnl_vehiculo.Controls.Add(this.lbl_motor);
            this.pnl_vehiculo.Controls.Add(this.txt_motor);
            this.pnl_vehiculo.Controls.Add(this.grp_fotos);
            this.pnl_vehiculo.Location = new System.Drawing.Point(326, 66);
            this.pnl_vehiculo.Name = "pnl_vehiculo";
            this.pnl_vehiculo.Size = new System.Drawing.Size(360, 510);
            this.pnl_vehiculo.TabIndex = 1;
            //
            // lbl_vehiculo_titulo
            //
            this.lbl_vehiculo_titulo.AutoSize = true;
            this.lbl_vehiculo_titulo.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.lbl_vehiculo_titulo.Location = new System.Drawing.Point(14, 12);
            this.lbl_vehiculo_titulo.Name = "lbl_vehiculo_titulo";
            this.lbl_vehiculo_titulo.Size = new System.Drawing.Size(120, 20);
            this.lbl_vehiculo_titulo.Text = "2. Vehículo";
            //
            // pnl_linea_vehiculo_titulo
            //
            this.pnl_linea_vehiculo_titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(221)))), ((int)(((byte)(232)))));
            this.pnl_linea_vehiculo_titulo.Location = new System.Drawing.Point(1, 42);
            this.pnl_linea_vehiculo_titulo.Name = "pnl_linea_vehiculo_titulo";
            this.pnl_linea_vehiculo_titulo.Size = new System.Drawing.Size(358, 1);
            //
            // lbl_vehiculo
            //
            this.lbl_vehiculo.AutoSize = true;
            this.lbl_vehiculo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_vehiculo.Location = new System.Drawing.Point(14, 52);
            this.lbl_vehiculo.Name = "lbl_vehiculo";
            this.lbl_vehiculo.Size = new System.Drawing.Size(60, 15);
            this.lbl_vehiculo.Text = "Vehículo";
            //
            // cb_vehiculo
            //
            this.cb_vehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_vehiculo.Location = new System.Drawing.Point(14, 70);
            this.cb_vehiculo.Name = "cb_vehiculo";
            this.cb_vehiculo.SelectedIndexChanged += new System.EventHandler(this.cb_vehiculo_SelectedIndexChanged);
            this.cb_vehiculo.Size = new System.Drawing.Size(332, 23);
            this.cb_vehiculo.TabIndex = 12;
            //
            // lbl_tipo
            //
            this.lbl_tipo.AutoSize = true;
            this.lbl_tipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_tipo.Location = new System.Drawing.Point(14, 102);
            this.lbl_tipo.Name = "lbl_tipo";
            this.lbl_tipo.Size = new System.Drawing.Size(60, 15);
            this.lbl_tipo.Text = "Tipo de vehículo";
            //
            // cb_tipo
            //
            this.cb_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_tipo.Items.AddRange(new object[] {
            "Automóvil",
            "Camioneta",
            "Motocicleta",
            "Camión"});
            this.cb_tipo.Location = new System.Drawing.Point(14, 120);
            this.cb_tipo.Name = "cb_tipo";
            this.cb_tipo.SelectedIndexChanged += new System.EventHandler(this.cb_tipo_SelectedIndexChanged);
            this.cb_tipo.Size = new System.Drawing.Size(160, 23);
            this.cb_tipo.TabIndex = 13;
            //
            // lbl_dominio
            //
            this.lbl_dominio.AutoSize = true;
            this.lbl_dominio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_dominio.Location = new System.Drawing.Point(186, 102);
            this.lbl_dominio.Name = "lbl_dominio";
            this.lbl_dominio.Size = new System.Drawing.Size(60, 15);
            this.lbl_dominio.Text = "Dominio";
            //
            // txt_dominio
            //
            this.txt_dominio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_dominio.Location = new System.Drawing.Point(186, 120);
            this.txt_dominio.MaxLength = 10;
            this.txt_dominio.Name = "txt_dominio";
            this.txt_dominio.Size = new System.Drawing.Size(160, 23);
            this.txt_dominio.TabIndex = 14;
            //
            // lbl_marca
            //
            this.lbl_marca.AutoSize = true;
            this.lbl_marca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_marca.Location = new System.Drawing.Point(14, 152);
            this.lbl_marca.Name = "lbl_marca";
            this.lbl_marca.Size = new System.Drawing.Size(60, 15);
            this.lbl_marca.Text = "Marca";
            //
            // txt_marca
            //
            this.txt_marca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_marca.Location = new System.Drawing.Point(14, 170);
            this.txt_marca.MaxLength = 40;
            this.txt_marca.Name = "txt_marca";
            this.txt_marca.Size = new System.Drawing.Size(160, 23);
            this.txt_marca.TabIndex = 15;
            //
            // lbl_modelo
            //
            this.lbl_modelo.AutoSize = true;
            this.lbl_modelo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_modelo.Location = new System.Drawing.Point(186, 152);
            this.lbl_modelo.Name = "lbl_modelo";
            this.lbl_modelo.Size = new System.Drawing.Size(60, 15);
            this.lbl_modelo.Text = "Modelo";
            //
            // txt_modelo
            //
            this.txt_modelo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_modelo.Location = new System.Drawing.Point(186, 170);
            this.txt_modelo.MaxLength = 40;
            this.txt_modelo.Name = "txt_modelo";
            this.txt_modelo.Size = new System.Drawing.Size(160, 23);
            this.txt_modelo.TabIndex = 16;
            //
            // lbl_anio
            //
            this.lbl_anio.AutoSize = true;
            this.lbl_anio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_anio.Location = new System.Drawing.Point(14, 202);
            this.lbl_anio.Name = "lbl_anio";
            this.lbl_anio.Size = new System.Drawing.Size(60, 15);
            this.lbl_anio.Text = "Año";
            //
            // txt_anio
            //
            this.txt_anio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_anio.Location = new System.Drawing.Point(14, 220);
            this.txt_anio.MaxLength = 4;
            this.txt_anio.Name = "txt_anio";
            this.txt_anio.Size = new System.Drawing.Size(160, 23);
            this.txt_anio.TabIndex = 17;
            //
            // lbl_vtv
            //
            this.lbl_vtv.AutoSize = true;
            this.lbl_vtv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_vtv.Location = new System.Drawing.Point(186, 202);
            this.lbl_vtv.Name = "lbl_vtv";
            this.lbl_vtv.Size = new System.Drawing.Size(60, 15);
            this.lbl_vtv.Text = "Estado de la VTV";
            //
            // cb_vtv
            //
            this.cb_vtv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_vtv.Items.AddRange(new object[] {
            "Vigente",
            "Vencida"});
            this.cb_vtv.Location = new System.Drawing.Point(186, 220);
            this.cb_vtv.Name = "cb_vtv";
            this.cb_vtv.Size = new System.Drawing.Size(160, 23);
            this.cb_vtv.TabIndex = 18;
            //
            // lbl_chasis
            //
            this.lbl_chasis.AutoSize = true;
            this.lbl_chasis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_chasis.Location = new System.Drawing.Point(14, 252);
            this.lbl_chasis.Name = "lbl_chasis";
            this.lbl_chasis.Size = new System.Drawing.Size(60, 15);
            this.lbl_chasis.Text = "N° de chasis";
            //
            // txt_chasis
            //
            this.txt_chasis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_chasis.Location = new System.Drawing.Point(14, 270);
            this.txt_chasis.MaxLength = 30;
            this.txt_chasis.Name = "txt_chasis";
            this.txt_chasis.Size = new System.Drawing.Size(160, 23);
            this.txt_chasis.TabIndex = 19;
            //
            // lbl_motor
            //
            this.lbl_motor.AutoSize = true;
            this.lbl_motor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_motor.Location = new System.Drawing.Point(186, 252);
            this.lbl_motor.Name = "lbl_motor";
            this.lbl_motor.Size = new System.Drawing.Size(60, 15);
            this.lbl_motor.Text = "N° de motor";
            //
            // txt_motor
            //
            this.txt_motor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_motor.Location = new System.Drawing.Point(186, 270);
            this.txt_motor.MaxLength = 30;
            this.txt_motor.Name = "txt_motor";
            this.txt_motor.Size = new System.Drawing.Size(160, 23);
            this.txt_motor.TabIndex = 20;
            //
            // grp_fotos
            //
            this.grp_fotos.Location = new System.Drawing.Point(14, 304);
            this.grp_fotos.Name = "grp_fotos";
            this.grp_fotos.Size = new System.Drawing.Size(332, 186);
            this.grp_fotos.TabStop = false;
            this.grp_fotos.Text = "Fotos (clic en cada una para cargarla)";
            //
            // pnl_poliza
            //
            this.pnl_poliza.Controls.Add(this.lbl_poliza_titulo);
            this.pnl_poliza.Controls.Add(this.pnl_linea_poliza_titulo);
            this.pnl_poliza.Controls.Add(this.lbl_ofrecidas);
            this.pnl_poliza.Controls.Add(this.dgv_ofrecidas);
            this.pnl_poliza.Controls.Add(this.lbl_oferta);
            this.pnl_poliza.Location = new System.Drawing.Point(698, 66);
            this.pnl_poliza.Name = "pnl_poliza";
            this.pnl_poliza.Size = new System.Drawing.Size(298, 510);
            this.pnl_poliza.TabIndex = 1;
            //
            // lbl_poliza_titulo
            //
            this.lbl_poliza_titulo.AutoSize = true;
            this.lbl_poliza_titulo.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.lbl_poliza_titulo.Location = new System.Drawing.Point(14, 12);
            this.lbl_poliza_titulo.Name = "lbl_poliza_titulo";
            this.lbl_poliza_titulo.Size = new System.Drawing.Size(120, 20);
            this.lbl_poliza_titulo.Text = "3. Póliza";
            //
            // pnl_linea_poliza_titulo
            //
            this.pnl_linea_poliza_titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(221)))), ((int)(((byte)(232)))));
            this.pnl_linea_poliza_titulo.Location = new System.Drawing.Point(1, 42);
            this.pnl_linea_poliza_titulo.Name = "pnl_linea_poliza_titulo";
            this.pnl_linea_poliza_titulo.Size = new System.Drawing.Size(296, 1);
            //
            // lbl_ofrecidas
            //
            this.lbl_ofrecidas.AutoSize = true;
            this.lbl_ofrecidas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(107)))), ((int)(((byte)(127)))));
            this.lbl_ofrecidas.Location = new System.Drawing.Point(14, 52);
            this.lbl_ofrecidas.Name = "lbl_ofrecidas";
            this.lbl_ofrecidas.Size = new System.Drawing.Size(60, 15);
            this.lbl_ofrecidas.Text = "Pólizas disponibles";
            //
            // dgv_ofrecidas
            //
            this.dgv_ofrecidas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_of_aseguradora,
            this.col_of_cobertura,
            this.col_of_cuota});
            this.dgv_ofrecidas.Location = new System.Drawing.Point(14, 72);
            this.dgv_ofrecidas.Name = "dgv_ofrecidas";
            this.dgv_ofrecidas.Size = new System.Drawing.Size(270, 200);
            this.dgv_ofrecidas.TabIndex = 90;
            this.dgv_ofrecidas.SelectionChanged += new System.EventHandler(this.dgv_ofrecidas_SelectionChanged);
            //
            // col_of_aseguradora
            //
            this.col_of_aseguradora.DataPropertyName = "Aseguradora";
            this.col_of_aseguradora.HeaderText = "Aseguradora";
            this.col_of_aseguradora.Name = "col_of_aseguradora";
            //
            // col_of_cobertura
            //
            this.col_of_cobertura.DataPropertyName = "TipoCobertura";
            this.col_of_cobertura.HeaderText = "Cobertura";
            this.col_of_cobertura.Name = "col_of_cobertura";
            //
            // col_of_cuota
            //
            this.col_of_cuota.DataPropertyName = "MontoCuota";
            estiloCuota.Format = "\'$ \'#,##0";
            this.col_of_cuota.DefaultCellStyle = estiloCuota;
            this.col_of_cuota.FillWeight = 70F;
            this.col_of_cuota.HeaderText = "Cuota";
            this.col_of_cuota.Name = "col_of_cuota";
            //
            // lbl_oferta
            //
            this.lbl_oferta.Location = new System.Drawing.Point(14, 284);
            this.lbl_oferta.Name = "lbl_oferta";
            this.lbl_oferta.Size = new System.Drawing.Size(270, 212);
            this.lbl_oferta.Text = "Detalle de la póliza elegida";
            //
            // btn_limpiar
            //
            this.btn_limpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_limpiar.Location = new System.Drawing.Point(726, 586);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(110, 34);
            this.btn_limpiar.TabIndex = 21;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = false;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            //
            // btn_crear
            //
            this.btn_crear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_crear.Location = new System.Drawing.Point(846, 586);
            this.btn_crear.Name = "btn_crear";
            this.btn_crear.Size = new System.Drawing.Size(150, 34);
            this.btn_crear.TabIndex = 22;
            this.btn_crear.Text = "Crear y contratar";
            this.btn_crear.UseVisualStyleBackColor = false;
            this.btn_crear.Click += new System.EventHandler(this.btn_crear_Click);
            //
            // AltaOficina
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1020, 650);
            this.Controls.Add(this.lbl_cliente_info);
            this.Controls.Add(this.btn_crear);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.pnl_poliza);
            this.Controls.Add(this.pnl_vehiculo);
            this.Controls.Add(this.pnl_cliente);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.lbl_titulo);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(56)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AltaOficina";
            this.Text = "Alta en oficina";
            this.Load += new System.EventHandler(this.AltaOficina_Load);
            this.pnl_cliente.ResumeLayout(false);
            this.pnl_cliente.PerformLayout();
            this.pnl_vehiculo.ResumeLayout(false);
            this.pnl_vehiculo.PerformLayout();
            this.pnl_poliza.ResumeLayout(false);
            this.pnl_poliza.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ofrecidas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.Panel pnl_cliente;
        private System.Windows.Forms.Label lbl_cliente_titulo;
        private System.Windows.Forms.Panel pnl_linea_cliente_titulo;
        private System.Windows.Forms.Label lbl_dni;
        private System.Windows.Forms.TextBox txt_dni;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label lbl_apellido;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.Label lbl_nacimiento;
        private System.Windows.Forms.DateTimePicker dtp_nacimiento;
        private System.Windows.Forms.Label lbl_provincia;
        private System.Windows.Forms.ComboBox cb_provincia;
        private System.Windows.Forms.Label lbl_ciudad;
        private System.Windows.Forms.TextBox txt_ciudad;
        private System.Windows.Forms.Label lbl_direccion;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.Label lbl_telefono;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label lbl_cliente_info;
        private System.Windows.Forms.Panel pnl_vehiculo;
        private System.Windows.Forms.Label lbl_vehiculo_titulo;
        private System.Windows.Forms.Panel pnl_linea_vehiculo_titulo;
        private System.Windows.Forms.Label lbl_vehiculo;
        private System.Windows.Forms.ComboBox cb_vehiculo;
        private System.Windows.Forms.Label lbl_tipo;
        private System.Windows.Forms.ComboBox cb_tipo;
        private System.Windows.Forms.Label lbl_dominio;
        private System.Windows.Forms.TextBox txt_dominio;
        private System.Windows.Forms.Label lbl_marca;
        private System.Windows.Forms.TextBox txt_marca;
        private System.Windows.Forms.Label lbl_modelo;
        private System.Windows.Forms.TextBox txt_modelo;
        private System.Windows.Forms.Label lbl_anio;
        private System.Windows.Forms.TextBox txt_anio;
        private System.Windows.Forms.Label lbl_vtv;
        private System.Windows.Forms.ComboBox cb_vtv;
        private System.Windows.Forms.Label lbl_chasis;
        private System.Windows.Forms.TextBox txt_chasis;
        private System.Windows.Forms.Label lbl_motor;
        private System.Windows.Forms.TextBox txt_motor;
        private System.Windows.Forms.GroupBox grp_fotos;
        private System.Windows.Forms.Panel pnl_poliza;
        private System.Windows.Forms.Label lbl_poliza_titulo;
        private System.Windows.Forms.Panel pnl_linea_poliza_titulo;
        private System.Windows.Forms.Label lbl_ofrecidas;
        private System.Windows.Forms.DataGridView dgv_ofrecidas;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_of_aseguradora;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_of_cobertura;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_of_cuota;
        private System.Windows.Forms.Label lbl_oferta;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_crear;
    }
}