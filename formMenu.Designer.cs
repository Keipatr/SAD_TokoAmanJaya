namespace POSTOKOAMANJAYA
{
    partial class formMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMenu));
            this.pbHistory = new System.Windows.Forms.PictureBox();
            this.pbLaporan = new System.Windows.Forms.PictureBox();
            this.pbInven = new System.Windows.Forms.PictureBox();
            this.pbJual = new System.Windows.Forms.PictureBox();
            this.pbBeli = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLaporan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInven)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbJual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBeli)).BeginInit();
            this.SuspendLayout();
            // 
            // pbHistory
            // 
            this.pbHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbHistory.BackColor = System.Drawing.Color.Transparent;
            this.pbHistory.Image = global::POSTOKOAMANJAYA.Properties.Resources.logohistory;
            this.pbHistory.Location = new System.Drawing.Point(1195, 793);
            this.pbHistory.Name = "pbHistory";
            this.pbHistory.Size = new System.Drawing.Size(251, 67);
            this.pbHistory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbHistory.TabIndex = 5;
            this.pbHistory.TabStop = false;
            this.pbHistory.Click += new System.EventHandler(this.pbHistory_Click);
            // 
            // pbLaporan
            // 
            this.pbLaporan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbLaporan.BackColor = System.Drawing.Color.Transparent;
            this.pbLaporan.Image = global::POSTOKOAMANJAYA.Properties.Resources.logolaporan;
            this.pbLaporan.Location = new System.Drawing.Point(908, 793);
            this.pbLaporan.Name = "pbLaporan";
            this.pbLaporan.Size = new System.Drawing.Size(251, 67);
            this.pbLaporan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbLaporan.TabIndex = 4;
            this.pbLaporan.TabStop = false;
            this.pbLaporan.Click += new System.EventHandler(this.pbLaporan_Click);
            // 
            // pbInven
            // 
            this.pbInven.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbInven.BackColor = System.Drawing.Color.Transparent;
            this.pbInven.Image = global::POSTOKOAMANJAYA.Properties.Resources.logoinventory;
            this.pbInven.Location = new System.Drawing.Point(621, 793);
            this.pbInven.Name = "pbInven";
            this.pbInven.Size = new System.Drawing.Size(251, 67);
            this.pbInven.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbInven.TabIndex = 2;
            this.pbInven.TabStop = false;
            this.pbInven.Click += new System.EventHandler(this.pbInven_Click);
            // 
            // pbJual
            // 
            this.pbJual.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbJual.BackColor = System.Drawing.Color.Transparent;
            this.pbJual.Image = global::POSTOKOAMANJAYA.Properties.Resources.Logopenjualan;
            this.pbJual.Location = new System.Drawing.Point(47, 793);
            this.pbJual.Name = "pbJual";
            this.pbJual.Size = new System.Drawing.Size(251, 67);
            this.pbJual.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbJual.TabIndex = 1;
            this.pbJual.TabStop = false;
            this.pbJual.Click += new System.EventHandler(this.pbJual_Click);
            // 
            // pbBeli
            // 
            this.pbBeli.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbBeli.BackColor = System.Drawing.Color.Transparent;
            this.pbBeli.Image = global::POSTOKOAMANJAYA.Properties.Resources.logoPembelian;
            this.pbBeli.Location = new System.Drawing.Point(334, 793);
            this.pbBeli.Name = "pbBeli";
            this.pbBeli.Size = new System.Drawing.Size(251, 67);
            this.pbBeli.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbBeli.TabIndex = 0;
            this.pbBeli.TabStop = false;
            this.pbBeli.Click += new System.EventHandler(this.pbBeli_Click);
            // 
            // formMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::POSTOKOAMANJAYA.Properties.Resources.LOGOMENU;
            this.ClientSize = new System.Drawing.Size(1499, 971);
            this.Controls.Add(this.pbHistory);
            this.Controls.Add(this.pbLaporan);
            this.Controls.Add(this.pbInven);
            this.Controls.Add(this.pbJual);
            this.Controls.Add(this.pbBeli);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pbHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLaporan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInven)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbJual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBeli)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbBeli;
        private System.Windows.Forms.PictureBox pbJual;
        private System.Windows.Forms.PictureBox pbInven;
        private System.Windows.Forms.PictureBox pbLaporan;
        private System.Windows.Forms.PictureBox pbHistory;
    }
}

