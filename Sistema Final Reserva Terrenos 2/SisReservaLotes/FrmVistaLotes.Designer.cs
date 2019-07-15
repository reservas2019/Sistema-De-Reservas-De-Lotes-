namespace SisReservaLotes
{
    partial class FrmVistaLotes
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbBuscarEstado = new System.Windows.Forms.ComboBox();
            this.txtBuscarNro = new System.Windows.Forms.TextBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.kk = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dgvRegistros = new System.Windows.Forms.DataGridView();
            this.lblTotal = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.cbBuscarEstado);
            this.groupBox1.Controls.Add(this.txtBuscarNro);
            this.groupBox1.Controls.Add(this.btnMostrar);
            this.groupBox1.Controls.Add(this.kk);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(36, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(899, 126);
            this.groupBox1.TabIndex = 88;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro de Busqueda";
            // 
            // cbBuscarEstado
            // 
            this.cbBuscarEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBuscarEstado.FormattingEnabled = true;
            this.cbBuscarEstado.Items.AddRange(new object[] {
            "HABILITADO",
            "RESERVADO"});
            this.cbBuscarEstado.Location = new System.Drawing.Point(416, 54);
            this.cbBuscarEstado.Margin = new System.Windows.Forms.Padding(4);
            this.cbBuscarEstado.Name = "cbBuscarEstado";
            this.cbBuscarEstado.Size = new System.Drawing.Size(188, 32);
            this.cbBuscarEstado.TabIndex = 54;
            // 
            // txtBuscarNro
            // 
            this.txtBuscarNro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarNro.Location = new System.Drawing.Point(91, 57);
            this.txtBuscarNro.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscarNro.Name = "txtBuscarNro";
            this.txtBuscarNro.Size = new System.Drawing.Size(189, 29);
            this.txtBuscarNro.TabIndex = 41;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(625, 57);
            this.btnMostrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(123, 28);
            this.btnMostrar.TabIndex = 38;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            // 
            // kk
            // 
            this.kk.AutoSize = true;
            this.kk.Location = new System.Drawing.Point(143, 27);
            this.kk.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.kk.Name = "kk";
            this.kk.Size = new System.Drawing.Size(101, 17);
            this.kk.TabIndex = 37;
            this.kk.Text = "Nro_Terreno";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(477, 27);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 17);
            this.label11.TabIndex = 33;
            this.label11.Text = "Estado";
            // 
            // dgvRegistros
            // 
            this.dgvRegistros.AllowUserToAddRows = false;
            this.dgvRegistros.AllowUserToDeleteRows = false;
            this.dgvRegistros.AllowUserToOrderColumns = true;
            this.dgvRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistros.EnableHeadersVisualStyles = false;
            this.dgvRegistros.Location = new System.Drawing.Point(36, 164);
            this.dgvRegistros.Margin = new System.Windows.Forms.Padding(4);
            this.dgvRegistros.Name = "dgvRegistros";
            this.dgvRegistros.ReadOnly = true;
            this.dgvRegistros.RowHeadersWidth = 51;
            this.dgvRegistros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRegistros.Size = new System.Drawing.Size(899, 438);
            this.dgvRegistros.TabIndex = 87;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(549, 143);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(69, 17);
            this.lblTotal.TabIndex = 89;
            this.lblTotal.Text = "Nombres:";
            // 
            // FrmVistaLotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(968, 615);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvRegistros);
            this.Controls.Add(this.lblTotal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmVistaLotes";
            this.Text = "FrmVistaLotes";
            this.Load += new System.EventHandler(this.FrmVistaLotes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbBuscarEstado;
        private System.Windows.Forms.TextBox txtBuscarNro;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Label kk;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgvRegistros;
        private System.Windows.Forms.Label lblTotal;
    }
}