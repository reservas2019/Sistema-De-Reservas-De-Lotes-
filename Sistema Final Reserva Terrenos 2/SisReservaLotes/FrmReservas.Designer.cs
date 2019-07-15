namespace SisReservaLotes
{
    partial class FrmReservas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtLote = new System.Windows.Forms.TextBox();
            this.btnBuscarLotes = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.txtCodigoCliente = new System.Windows.Forms.TextBox();
            this.dtfechaRegistro = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.CbEstado = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPrecioTotal = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtPrecioUnitario = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dtFechaLimite = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCodigoDetalle = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCodigoLote = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lbregistrosdetalle = new System.Windows.Forms.Label();
            this.btnElim = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbiarEstadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.eToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnG = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.txtcodigoReserva = new System.Windows.Forms.TextBox();
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.ttMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.dataListadoDetalle = new System.Windows.Forms.DataGridView();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lbcarnet = new System.Windows.Forms.Label();
            this.txtNombreBuscar = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbBuscarEstado = new System.Windows.Forms.ComboBox();
            this.btnVus = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dtFecha2 = new System.Windows.Forms.DateTimePicker();
            this.dtFecha1 = new System.Windows.Forms.DateTimePicker();
            this.dataListado = new System.Windows.Forms.DataGridView();
            this.Eliminarr = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ldtotal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSumar = new System.Windows.Forms.Button();
            this.lbhora = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataListadoDetalle)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnQuitar
            // 
            this.btnQuitar.Image = global::SisReservaLotes.Properties.Resources.error;
            this.btnQuitar.Location = new System.Drawing.Point(431, 262);
            this.btnQuitar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(139, 53);
            this.btnQuitar.TabIndex = 129;
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.BtnQuitar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = global::SisReservaLotes.Properties.Resources.guar;
            this.btnAgregar.Location = new System.Drawing.Point(276, 262);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(135, 53);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // txtLote
            // 
            this.txtLote.BackColor = System.Drawing.Color.White;
            this.txtLote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLote.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLote.Location = new System.Drawing.Point(76, 73);
            this.txtLote.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLote.Name = "txtLote";
            this.txtLote.Size = new System.Drawing.Size(209, 29);
            this.txtLote.TabIndex = 0;
            // 
            // btnBuscarLotes
            // 
            this.btnBuscarLotes.BackColor = System.Drawing.Color.YellowGreen;
            this.btnBuscarLotes.Image = global::SisReservaLotes.Properties.Resources.ICbuscar;
            this.btnBuscarLotes.Location = new System.Drawing.Point(295, 64);
            this.btnBuscarLotes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscarLotes.Name = "btnBuscarLotes";
            this.btnBuscarLotes.Size = new System.Drawing.Size(48, 43);
            this.btnBuscarLotes.TabIndex = 2;
            this.btnBuscarLotes.UseVisualStyleBackColor = false;
            this.btnBuscarLotes.Click += new System.EventHandler(this.BtnBuscarLotes_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(7, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 15);
            this.label4.TabIndex = 132;
            this.label4.Text = "Campos Obligatorios";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(475, 107);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 29);
            this.label8.TabIndex = 140;
            this.label8.Text = "*";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.BackColor = System.Drawing.Color.White;
            this.txtNombreCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCliente.Location = new System.Drawing.Point(104, 102);
            this.txtNombreCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(291, 29);
            this.txtNombreCliente.TabIndex = 0;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.BackColor = System.Drawing.Color.YellowGreen;
            this.btnBuscarCliente.Image = global::SisReservaLotes.Properties.Resources.ICbuscar;
            this.btnBuscarCliente.Location = new System.Drawing.Point(419, 96);
            this.btnBuscarCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(52, 39);
            this.btnBuscarCliente.TabIndex = 139;
            this.btnBuscarCliente.UseVisualStyleBackColor = false;
            this.btnBuscarCliente.Click += new System.EventHandler(this.BtnBuscarCliente_Click);
            // 
            // txtCodigoCliente
            // 
            this.txtCodigoCliente.BackColor = System.Drawing.Color.White;
            this.txtCodigoCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoCliente.Location = new System.Drawing.Point(247, 46);
            this.txtCodigoCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodigoCliente.Name = "txtCodigoCliente";
            this.txtCodigoCliente.Size = new System.Drawing.Size(65, 29);
            this.txtCodigoCliente.TabIndex = 131;
            // 
            // dtfechaRegistro
            // 
            this.dtfechaRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtfechaRegistro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtfechaRegistro.Location = new System.Drawing.Point(167, 140);
            this.dtfechaRegistro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtfechaRegistro.Name = "dtfechaRegistro";
            this.dtfechaRegistro.Size = new System.Drawing.Size(160, 29);
            this.dtfechaRegistro.TabIndex = 101;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(15, 143);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 18);
            this.label11.TabIndex = 97;
            this.label11.Text = "Fecha Registro:";
            // 
            // CbEstado
            // 
            this.CbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbEstado.FormattingEnabled = true;
            this.CbEstado.Items.AddRange(new object[] {
            "RESERVADO",
            "VENCIDO"});
            this.CbEstado.Location = new System.Drawing.Point(655, 15);
            this.CbEstado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CbEstado.Name = "CbEstado";
            this.CbEstado.Size = new System.Drawing.Size(160, 28);
            this.CbEstado.TabIndex = 91;
            this.CbEstado.Text = "RESERVADO";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(580, 18);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(66, 18);
            this.label16.TabIndex = 84;
            this.label16.Text = "Estado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(20, 48);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 18);
            this.label3.TabIndex = 66;
            this.label3.Text = "Codigo:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox2.Controls.Add(this.txtPrecioTotal);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.txtPrecioUnitario);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.dtFechaLimite);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtCodigoDetalle);
            this.groupBox2.Controls.Add(this.btnQuitar);
            this.groupBox2.Controls.Add(this.btnAgregar);
            this.groupBox2.Controls.Add(this.txtLote);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.dtfechaRegistro);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.btnBuscarLotes);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtCodigoLote);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txtCantidad);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(529, 270);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(868, 321);
            this.groupBox2.TabIndex = 171;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Lotes";
            // 
            // txtPrecioTotal
            // 
            this.txtPrecioTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioTotal.Location = new System.Drawing.Point(607, 208);
            this.txtPrecioTotal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrecioTotal.Name = "txtPrecioTotal";
            this.txtPrecioTotal.Size = new System.Drawing.Size(208, 29);
            this.txtPrecioTotal.TabIndex = 148;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Red;
            this.label19.Location = new System.Drawing.Point(351, 217);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(24, 29);
            this.label19.TabIndex = 147;
            this.label19.Text = "*";
            // 
            // txtPrecioUnitario
            // 
            this.txtPrecioUnitario.BackColor = System.Drawing.Color.White;
            this.txtPrecioUnitario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecioUnitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioUnitario.Location = new System.Drawing.Point(607, 127);
            this.txtPrecioUnitario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrecioUnitario.Name = "txtPrecioUnitario";
            this.txtPrecioUnitario.Size = new System.Drawing.Size(209, 29);
            this.txtPrecioUnitario.TabIndex = 145;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(461, 132);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(126, 18);
            this.label17.TabIndex = 146;
            this.label17.Text = "Precio Unitario:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(481, 208);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(105, 18);
            this.label14.TabIndex = 144;
            this.label14.Text = "Precio Total:";
            // 
            // dtFechaLimite
            // 
            this.dtFechaLimite.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaLimite.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaLimite.Location = new System.Drawing.Point(167, 208);
            this.dtFechaLimite.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtFechaLimite.Name = "dtFechaLimite";
            this.dtFechaLimite.Size = new System.Drawing.Size(160, 29);
            this.dtFechaLimite.TabIndex = 142;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(28, 212);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 18);
            this.label10.TabIndex = 141;
            this.label10.Text = "Fecha Limite:";
            // 
            // txtCodigoDetalle
            // 
            this.txtCodigoDetalle.BackColor = System.Drawing.Color.White;
            this.txtCodigoDetalle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigoDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoDetalle.Location = new System.Drawing.Point(104, 38);
            this.txtCodigoDetalle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodigoDetalle.Name = "txtCodigoDetalle";
            this.txtCodigoDetalle.Size = new System.Drawing.Size(65, 26);
            this.txtCodigoDetalle.TabIndex = 140;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(351, 73);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 29);
            this.label9.TabIndex = 117;
            this.label9.Text = "*";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(9, 20);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(141, 15);
            this.label13.TabIndex = 93;
            this.label13.Text = "Campos Obligatorios";
            // 
            // txtCodigoLote
            // 
            this.txtCodigoLote.BackColor = System.Drawing.Color.White;
            this.txtCodigoLote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigoLote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoLote.Location = new System.Drawing.Point(213, 39);
            this.txtCodigoLote.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodigoLote.Name = "txtCodigoLote";
            this.txtCodigoLote.Size = new System.Drawing.Size(65, 26);
            this.txtCodigoLote.TabIndex = 83;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(16, 78);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 18);
            this.label15.TabIndex = 82;
            this.label15.Text = "Lote:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.BackColor = System.Drawing.Color.White;
            this.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(607, 53);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(209, 29);
            this.txtCantidad.TabIndex = 1;
            this.txtCantidad.Text = "1";
            this.txtCantidad.TextChanged += new System.EventHandler(this.TxtCantidad_TextChanged);
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCantidad_KeyPress);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(508, 59);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(79, 18);
            this.label18.TabIndex = 67;
            this.label18.Text = "Cantidad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(21, 107);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 18);
            this.label5.TabIndex = 133;
            this.label5.Text = "Cliente:";
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.MinimumWidth = 6;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Width = 125;
            // 
            // lbregistrosdetalle
            // 
            this.lbregistrosdetalle.AutoSize = true;
            this.lbregistrosdetalle.Location = new System.Drawing.Point(1075, 612);
            this.lbregistrosdetalle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbregistrosdetalle.Name = "lbregistrosdetalle";
            this.lbregistrosdetalle.Size = new System.Drawing.Size(16, 17);
            this.lbregistrosdetalle.TabIndex = 177;
            this.lbregistrosdetalle.Text = "0";
            // 
            // btnElim
            // 
            this.btnElim.ForeColor = System.Drawing.Color.SandyBrown;
            this.btnElim.Name = "btnElim";
            this.btnElim.Size = new System.Drawing.Size(172, 29);
            this.btnElim.Text = "Eliminar Reserva";
            this.btnElim.Click += new System.EventHandler(this.BtnElim_Click);
            // 
            // cmbiarEstadoToolStripMenuItem
            // 
            this.cmbiarEstadoToolStripMenuItem.ForeColor = System.Drawing.Color.SandyBrown;
            this.cmbiarEstadoToolStripMenuItem.Name = "cmbiarEstadoToolStripMenuItem";
            this.cmbiarEstadoToolStripMenuItem.Size = new System.Drawing.Size(277, 30);
            this.cmbiarEstadoToolStripMenuItem.Text = "Cambiar Estado";
            // 
            // editarClienteToolStripMenuItem
            // 
            this.editarClienteToolStripMenuItem.ForeColor = System.Drawing.Color.SandyBrown;
            this.editarClienteToolStripMenuItem.Name = "editarClienteToolStripMenuItem";
            this.editarClienteToolStripMenuItem.Size = new System.Drawing.Size(277, 30);
            this.editarClienteToolStripMenuItem.Text = "Editar Reserva";
            this.editarClienteToolStripMenuItem.Click += new System.EventHandler(this.EditarClienteToolStripMenuItem_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarClienteToolStripMenuItem,
            this.cmbiarEstadoToolStripMenuItem,
            this.eToolStripMenuItem});
            this.btnEditar.ForeColor = System.Drawing.Color.SandyBrown;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(186, 29);
            this.btnEditar.Text = "Modificar Reserva";
            // 
            // eToolStripMenuItem
            // 
            this.eToolStripMenuItem.ForeColor = System.Drawing.Color.SandyBrown;
            this.eToolStripMenuItem.Name = "eToolStripMenuItem";
            this.eToolStripMenuItem.Size = new System.Drawing.Size(277, 30);
            this.eToolStripMenuItem.Text = "Editar Items Reserva";
            // 
            // btnNuevo
            // 
            this.btnNuevo.ForeColor = System.Drawing.Color.SandyBrown;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(157, 29);
            this.btnNuevo.Text = "Nueva Reserva";
            this.btnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(4, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(516, 46);
            this.label1.TabIndex = 175;
            this.label1.Text = "GESTION DE RESERVAS";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Linen;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Crimson;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(1249, 816);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(128, 37);
            this.btnCancelar.TabIndex = 168;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // btnG
            // 
            this.btnG.BackColor = System.Drawing.Color.Linen;
            this.btnG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnG.ForeColor = System.Drawing.Color.Crimson;
            this.btnG.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnG.Location = new System.Drawing.Point(1031, 818);
            this.btnG.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnG.Name = "btnG";
            this.btnG.Size = new System.Drawing.Size(189, 37);
            this.btnG.TabIndex = 170;
            this.btnG.Text = "Aceptar y Guardar";
            this.btnG.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnG.UseVisualStyleBackColor = false;
            this.btnG.Click += new System.EventHandler(this.BtnG_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.btnEditar,
            this.btnElim});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1425, 33);
            this.menuStrip1.TabIndex = 176;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // txtcodigoReserva
            // 
            this.txtcodigoReserva.BackColor = System.Drawing.Color.White;
            this.txtcodigoReserva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcodigoReserva.Enabled = false;
            this.txtcodigoReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigoReserva.Location = new System.Drawing.Point(103, 46);
            this.txtcodigoReserva.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtcodigoReserva.Name = "txtcodigoReserva";
            this.txtcodigoReserva.Size = new System.Drawing.Size(115, 29);
            this.txtcodigoReserva.TabIndex = 68;
            // 
            // errorIcono
            // 
            this.errorIcono.ContainerControl = this;
            // 
            // ttMensaje
            // 
            this.ttMensaje.IsBalloon = true;
            // 
            // dataListadoDetalle
            // 
            this.dataListadoDetalle.AllowUserToAddRows = false;
            this.dataListadoDetalle.AllowUserToDeleteRows = false;
            this.dataListadoDetalle.AllowUserToOrderColumns = true;
            this.dataListadoDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListadoDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.dataListadoDetalle.Location = new System.Drawing.Point(13, 631);
            this.dataListadoDetalle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataListadoDetalle.MultiSelect = false;
            this.dataListadoDetalle.Name = "dataListadoDetalle";
            this.dataListadoDetalle.ReadOnly = true;
            this.dataListadoDetalle.RowHeadersWidth = 51;
            this.dataListadoDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataListadoDetalle.Size = new System.Drawing.Size(1364, 180);
            this.dataListadoDetalle.TabIndex = 179;
            this.dataListadoDetalle.Click += new System.EventHandler(this.DataListadoDetalle_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Linen;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.Crimson;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(367, 823);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(189, 37);
            this.btnGuardar.TabIndex = 167;
            this.btnGuardar.Text = "Aceptar y Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(299, 250);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(16, 17);
            this.lblTotal.TabIndex = 173;
            this.lblTotal.Text = "0";
            // 
            // lbcarnet
            // 
            this.lbcarnet.AutoSize = true;
            this.lbcarnet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcarnet.ForeColor = System.Drawing.Color.Black;
            this.lbcarnet.Location = new System.Drawing.Point(43, 26);
            this.lbcarnet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbcarnet.Name = "lbcarnet";
            this.lbcarnet.Size = new System.Drawing.Size(64, 17);
            this.lbcarnet.TabIndex = 147;
            this.lbcarnet.Text = "Nombre";
            // 
            // txtNombreBuscar
            // 
            this.txtNombreBuscar.BackColor = System.Drawing.Color.Azure;
            this.txtNombreBuscar.Location = new System.Drawing.Point(11, 46);
            this.txtNombreBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombreBuscar.Name = "txtNombreBuscar";
            this.txtNombreBuscar.Size = new System.Drawing.Size(132, 22);
            this.txtNombreBuscar.TabIndex = 146;
            this.txtNombreBuscar.TextChanged += new System.EventHandler(this.TxtNombreBuscar_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(43, 101);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 17);
            this.label12.TabIndex = 145;
            this.label12.Text = "Desde";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(236, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 144;
            this.label2.Text = "Hasta";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbBuscarEstado);
            this.groupBox3.Controls.Add(this.lbcarnet);
            this.groupBox3.Controls.Add(this.txtNombreBuscar);
            this.groupBox3.Controls.Add(this.btnVus);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.btnBuscar);
            this.groupBox3.Controls.Add(this.dtFecha2);
            this.groupBox3.Controls.Add(this.dtFecha1);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox3.Location = new System.Drawing.Point(13, 84);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(501, 162);
            this.groupBox3.TabIndex = 178;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Buscar Por";
            // 
            // cbBuscarEstado
            // 
            this.cbBuscarEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBuscarEstado.FormattingEnabled = true;
            this.cbBuscarEstado.Items.AddRange(new object[] {
            "RESERVADO",
            "VENCIDO"});
            this.cbBuscarEstado.Location = new System.Drawing.Point(199, 43);
            this.cbBuscarEstado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbBuscarEstado.Name = "cbBuscarEstado";
            this.cbBuscarEstado.Size = new System.Drawing.Size(160, 28);
            this.cbBuscarEstado.TabIndex = 141;
            this.cbBuscarEstado.SelectedIndexChanged += new System.EventHandler(this.CbBuscarBuscar_SelectedIndexChanged);
            // 
            // btnVus
            // 
            this.btnVus.BackColor = System.Drawing.Color.Silver;
            this.btnVus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnVus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVus.Location = new System.Drawing.Point(389, 116);
            this.btnVus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVus.Name = "btnVus";
            this.btnVus.Size = new System.Drawing.Size(105, 37);
            this.btnVus.TabIndex = 148;
            this.btnVus.Text = "BUSCAR";
            this.btnVus.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(228, 26);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 17);
            this.label7.TabIndex = 142;
            this.label7.Text = "Estado";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Silver;
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(389, 39);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(105, 36);
            this.btnBuscar.TabIndex = 137;
            this.btnBuscar.Text = "&MOSTRAR";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // dtFecha2
            // 
            this.dtFecha2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha2.Location = new System.Drawing.Point(199, 122);
            this.dtFecha2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtFecha2.Name = "dtFecha2";
            this.dtFecha2.Size = new System.Drawing.Size(143, 22);
            this.dtFecha2.TabIndex = 141;
            // 
            // dtFecha1
            // 
            this.dtFecha1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha1.Location = new System.Drawing.Point(11, 119);
            this.dtFecha1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtFecha1.Name = "dtFecha1";
            this.dtFecha1.Size = new System.Drawing.Size(132, 22);
            this.dtFecha1.TabIndex = 140;
            // 
            // dataListado
            // 
            this.dataListado.AllowUserToAddRows = false;
            this.dataListado.AllowUserToDeleteRows = false;
            this.dataListado.AllowUserToOrderColumns = true;
            this.dataListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminarr});
            this.dataListado.Location = new System.Drawing.Point(13, 270);
            this.dataListado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataListado.MultiSelect = false;
            this.dataListado.Name = "dataListado";
            this.dataListado.ReadOnly = true;
            this.dataListado.RowHeadersWidth = 51;
            this.dataListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataListado.Size = new System.Drawing.Size(501, 321);
            this.dataListado.TabIndex = 172;
            this.dataListado.Click += new System.EventHandler(this.DataListado_Click);
            // 
            // Eliminarr
            // 
            this.Eliminarr.HeaderText = "Eliminar";
            this.Eliminarr.MinimumWidth = 6;
            this.Eliminarr.Name = "Eliminarr";
            this.Eliminarr.ReadOnly = true;
            this.Eliminarr.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtNombreCliente);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnBuscarCliente);
            this.groupBox1.Controls.Add(this.txtCodigoCliente);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.CbEstado);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtcodigoReserva);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(529, 84);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(868, 162);
            this.groupBox1.TabIndex = 174;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Reserva";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // ldtotal
            // 
            this.ldtotal.AutoSize = true;
            this.ldtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ldtotal.Location = new System.Drawing.Point(269, 823);
            this.ldtotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ldtotal.Name = "ldtotal";
            this.ldtotal.Size = new System.Drawing.Size(42, 25);
            this.ldtotal.TabIndex = 181;
            this.ldtotal.Text = "0.0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 823);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(216, 20);
            this.label6.TabIndex = 180;
            this.label6.Text = "Precio Total de Pedidos:";
            // 
            // btnSumar
            // 
            this.btnSumar.Image = global::SisReservaLotes.Properties.Resources.guar;
            this.btnSumar.Location = new System.Drawing.Point(885, 815);
            this.btnSumar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSumar.Name = "btnSumar";
            this.btnSumar.Size = new System.Drawing.Size(135, 44);
            this.btnSumar.TabIndex = 149;
            this.btnSumar.UseVisualStyleBackColor = true;
            this.btnSumar.Click += new System.EventHandler(this.BtnSumar_Click_1);
            // 
            // lbhora
            // 
            this.lbhora.AutoSize = true;
            this.lbhora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbhora.ForeColor = System.Drawing.Color.Black;
            this.lbhora.Location = new System.Drawing.Point(1132, 594);
            this.lbhora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbhora.Name = "lbhora";
            this.lbhora.Size = new System.Drawing.Size(109, 18);
            this.lbhora.TabIndex = 149;
            this.lbhora.Text = "Fecha Limite:";
            // 
            // FrmReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1425, 859);
            this.Controls.Add(this.lbhora);
            this.Controls.Add(this.btnSumar);
            this.Controls.Add(this.ldtotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lbregistrosdetalle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnG);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataListadoDetalle);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dataListado);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmReservas";
            this.Text = "GESTION DE RESERVAS";
            this.Load += new System.EventHandler(this.FrmReservas_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataListadoDetalle)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtLote;
        private System.Windows.Forms.Button btnBuscarLotes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.TextBox txtCodigoCliente;
        private System.Windows.Forms.DateTimePicker dtfechaRegistro;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox CbEstado;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCodigoLote;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.Label lbregistrosdetalle;
        private System.Windows.Forms.ToolStripMenuItem btnElim;
        private System.Windows.Forms.ToolStripMenuItem cmbiarEstadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnEditar;
        private System.Windows.Forms.ToolStripMenuItem btnNuevo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnG;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TextBox txtcodigoReserva;
        private System.Windows.Forms.ErrorProvider errorIcono;
        private System.Windows.Forms.DataGridView dataListadoDetalle;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbBuscarEstado;
        private System.Windows.Forms.Label lbcarnet;
        private System.Windows.Forms.TextBox txtNombreBuscar;
        private System.Windows.Forms.Button btnVus;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DateTimePicker dtFecha2;
        private System.Windows.Forms.DateTimePicker dtFecha1;
        private System.Windows.Forms.DataGridView dataListado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminarr;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolTip ttMensaje;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem eToolStripMenuItem;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtPrecioUnitario;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dtFechaLimite;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCodigoDetalle;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txtPrecioTotal;
        private System.Windows.Forms.Button btnSumar;
        private System.Windows.Forms.Label ldtotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbhora;
    }
}