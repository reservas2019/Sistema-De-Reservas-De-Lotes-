namespace SisReservaLotes
{
    partial class FrmConsultasReservas
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
            this.px2 = new System.Windows.Forms.PictureBox();
            this.px1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.px2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.px1)).BeginInit();
            this.SuspendLayout();
            // 
            // px2
            // 
            this.px2.Location = new System.Drawing.Point(267, 27);
            this.px2.Margin = new System.Windows.Forms.Padding(4);
            this.px2.Name = "px2";
            this.px2.Size = new System.Drawing.Size(200, 167);
            this.px2.TabIndex = 1;
            this.px2.TabStop = false;
            // 
            // px1
            // 
            this.px1.Location = new System.Drawing.Point(29, 27);
            this.px1.Margin = new System.Windows.Forms.Padding(4);
            this.px1.Name = "px1";
            this.px1.Size = new System.Drawing.Size(200, 167);
            this.px1.TabIndex = 0;
            this.px1.TabStop = false;
            // 
            // FrmConsultasReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.px2);
            this.Controls.Add(this.px1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmConsultasReservas";
            this.Text = "FrmConsultasReservas";
            this.Load += new System.EventHandler(this.FrmConsultasReservas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.px2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.px1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox px2;
        private System.Windows.Forms.PictureBox px1;
    }
}