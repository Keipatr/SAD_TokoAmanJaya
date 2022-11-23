namespace POSTOKOAMANJAYA
{
    partial class formPenjualan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formPenjualan));
            this.panelAtas = new System.Windows.Forms.Panel();
            this.pbTextPenjualan = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelAtas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTextPenjualan)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAtas
            // 
            this.panelAtas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelAtas.BackColor = System.Drawing.Color.Transparent;
            this.panelAtas.BackgroundImage = global::POSTOKOAMANJAYA.Properties.Resources.kotak_biru_atas;
            this.panelAtas.Controls.Add(this.pbTextPenjualan);
            this.panelAtas.Location = new System.Drawing.Point(0, 0);
            this.panelAtas.Name = "panelAtas";
            this.panelAtas.Size = new System.Drawing.Size(1512, 91);
            this.panelAtas.TabIndex = 0;
            // 
            // pbTextPenjualan
            // 
            this.pbTextPenjualan.Image = global::POSTOKOAMANJAYA.Properties.Resources.PENJUALAN;
            this.pbTextPenjualan.Location = new System.Drawing.Point(22, 16);
            this.pbTextPenjualan.Name = "pbTextPenjualan";
            this.pbTextPenjualan.Size = new System.Drawing.Size(398, 62);
            this.pbTextPenjualan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbTextPenjualan.TabIndex = 1;
            this.pbTextPenjualan.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 61);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nama Barang";
            // 
            // formPenjualan
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1496, 943);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelAtas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1512, 982);
            this.MinimumSize = new System.Drawing.Size(1512, 982);
            this.Name = "formPenjualan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Penjualan";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.formMenu_Load);
            this.panelAtas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbTextPenjualan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelAtas;
        private System.Windows.Forms.PictureBox pbTextPenjualan;
        private System.Windows.Forms.Label label1;
    }
}

