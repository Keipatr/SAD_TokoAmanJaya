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
            this.lbNamabarang = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.pbTxtBack = new System.Windows.Forms.PictureBox();
            this.pbSearch = new System.Windows.Forms.PictureBox();
            this.panelAtas = new System.Windows.Forms.Panel();
            this.lbLogo = new System.Windows.Forms.Label();
            this.pbBack = new System.Windows.Forms.PictureBox();
            this.tbSearchs = new CustomControls.RJControls.RJTextBox();
            this.pnlNota = new System.Windows.Forms.Panel();
            this.lbNota = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbIDJual = new System.Windows.Forms.Label();
            this.btnSubmit = new CustomControls.RJControls.RJButton();
            this.pbKotak = new System.Windows.Forms.PictureBox();
            this.lbTextTotal = new System.Windows.Forms.Label();
            this.pbGarisAtas = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbTxtBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            this.panelAtas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).BeginInit();
            this.pnlNota.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKotak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGarisAtas)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNamabarang
            // 
            this.lbNamabarang.AutoSize = true;
            this.lbNamabarang.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNamabarang.ForeColor = System.Drawing.Color.Black;
            this.lbNamabarang.Location = new System.Drawing.Point(41, 142);
            this.lbNamabarang.Name = "lbNamabarang";
            this.lbNamabarang.Size = new System.Drawing.Size(276, 46);
            this.lbNamabarang.TabIndex = 6;
            this.lbNamabarang.Text = "Nama Barang";
            // 
            // tbSearch
            // 
            this.tbSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSearch.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(376, 142);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(417, 46);
            this.tbSearch.TabIndex = 9;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // pbTxtBack
            // 
            this.pbTxtBack.BackColor = System.Drawing.Color.Transparent;
            this.pbTxtBack.Image = global::POSTOKOAMANJAYA.Properties.Resources.popupBack;
            this.pbTxtBack.Location = new System.Drawing.Point(1422, 90);
            this.pbTxtBack.Name = "pbTxtBack";
            this.pbTxtBack.Size = new System.Drawing.Size(48, 32);
            this.pbTxtBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbTxtBack.TabIndex = 13;
            this.pbTxtBack.TabStop = false;
            this.pbTxtBack.Visible = false;
            // 
            // pbSearch
            // 
            this.pbSearch.BackColor = System.Drawing.Color.Transparent;
            this.pbSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pbSearch.Image = global::POSTOKOAMANJAYA.Properties.Resources.search;
            this.pbSearch.Location = new System.Drawing.Point(340, 143);
            this.pbSearch.Name = "pbSearch";
            this.pbSearch.Size = new System.Drawing.Size(36, 46);
            this.pbSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbSearch.TabIndex = 3;
            this.pbSearch.TabStop = false;
            this.pbSearch.Click += new System.EventHandler(this.pbSearch_Click);
            // 
            // panelAtas
            // 
            this.panelAtas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelAtas.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelAtas.BackgroundImage = global::POSTOKOAMANJAYA.Properties.Resources.kotak_biru_atas;
            this.panelAtas.Controls.Add(this.lbLogo);
            this.panelAtas.Controls.Add(this.pbBack);
            this.panelAtas.Location = new System.Drawing.Point(0, 0);
            this.panelAtas.Name = "panelAtas";
            this.panelAtas.Size = new System.Drawing.Size(1528, 91);
            this.panelAtas.TabIndex = 0;
            // 
            // lbLogo
            // 
            this.lbLogo.AutoSize = true;
            this.lbLogo.BackColor = System.Drawing.Color.Transparent;
            this.lbLogo.Font = new System.Drawing.Font("Arial", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogo.ForeColor = System.Drawing.Color.Goldenrod;
            this.lbLogo.Location = new System.Drawing.Point(8, 7);
            this.lbLogo.Name = "lbLogo";
            this.lbLogo.Size = new System.Drawing.Size(435, 78);
            this.lbLogo.TabIndex = 4;
            this.lbLogo.Text = "PENJUALAN";
            // 
            // pbBack
            // 
            this.pbBack.BackColor = System.Drawing.Color.Transparent;
            this.pbBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBack.Image = global::POSTOKOAMANJAYA.Properties.Resources.logoback;
            this.pbBack.Location = new System.Drawing.Point(1418, 19);
            this.pbBack.Name = "pbBack";
            this.pbBack.Size = new System.Drawing.Size(55, 55);
            this.pbBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbBack.TabIndex = 3;
            this.pbBack.TabStop = false;
            this.pbBack.Click += new System.EventHandler(this.pbBack_Click);
            this.pbBack.MouseLeave += new System.EventHandler(this.pbBack_MouseLeave);
            this.pbBack.MouseHover += new System.EventHandler(this.pbBack_MouseHover);
            // 
            // tbSearchs
            // 
            this.tbSearchs.BackColor = System.Drawing.SystemColors.Window;
            this.tbSearchs.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tbSearchs.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbSearchs.BorderRadius = 10;
            this.tbSearchs.BorderSize = 1;
            this.tbSearchs.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSearchs.Enabled = false;
            this.tbSearchs.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearchs.ForeColor = System.Drawing.Color.Black;
            this.tbSearchs.Location = new System.Drawing.Point(331, 136);
            this.tbSearchs.Margin = new System.Windows.Forms.Padding(4);
            this.tbSearchs.Multiline = false;
            this.tbSearchs.Name = "tbSearchs";
            this.tbSearchs.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbSearchs.PasswordChar = false;
            this.tbSearchs.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbSearchs.PlaceholderText = "";
            this.tbSearchs.Size = new System.Drawing.Size(473, 60);
            this.tbSearchs.TabIndex = 7;
            this.tbSearchs.Texts = "";
            this.tbSearchs.UnderlinedStyle = false;
            // 
            // pnlNota
            // 
            this.pnlNota.Controls.Add(this.pbGarisAtas);
            this.pnlNota.Controls.Add(this.lbTextTotal);
            this.pnlNota.Controls.Add(this.pbKotak);
            this.pnlNota.Controls.Add(this.btnSubmit);
            this.pnlNota.Controls.Add(this.lbIDJual);
            this.pnlNota.Controls.Add(this.lbNota);
            this.pnlNota.Location = new System.Drawing.Point(868, 90);
            this.pnlNota.Name = "pnlNota";
            this.pnlNota.Size = new System.Drawing.Size(644, 892);
            this.pnlNota.TabIndex = 14;
            // 
            // lbNota
            // 
            this.lbNota.AutoSize = true;
            this.lbNota.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNota.Location = new System.Drawing.Point(24, 26);
            this.lbNota.Name = "lbNota";
            this.lbNota.Size = new System.Drawing.Size(242, 44);
            this.lbNota.TabIndex = 0;
            this.lbNota.Text = "ID Penjualan";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::POSTOKOAMANJAYA.Properties.Resources.gambargaris;
            this.pictureBox1.Location = new System.Drawing.Point(836, 240);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(8, 350);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // lbIDJual
            // 
            this.lbIDJual.AutoSize = true;
            this.lbIDJual.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIDJual.ForeColor = System.Drawing.Color.Goldenrod;
            this.lbIDJual.Location = new System.Drawing.Point(372, 26);
            this.lbIDJual.Name = "lbIDJual";
            this.lbIDJual.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbIDJual.Size = new System.Drawing.Size(244, 44);
            this.lbIDJual.TabIndex = 2;
            this.lbIDJual.Text = "J2211118001";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSubmit.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSubmit.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSubmit.BorderRadius = 20;
            this.btnSubmit.BorderSize = 0;
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(487, 829);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(130, 42);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.TextColor = System.Drawing.Color.White;
            this.btnSubmit.UseVisualStyleBackColor = false;
            // 
            // pbKotak
            // 
            this.pbKotak.BackColor = System.Drawing.Color.Gold;
            this.pbKotak.Location = new System.Drawing.Point(32, 740);
            this.pbKotak.Name = "pbKotak";
            this.pbKotak.Size = new System.Drawing.Size(585, 62);
            this.pbKotak.TabIndex = 4;
            this.pbKotak.TabStop = false;
            // 
            // lbTextTotal
            // 
            this.lbTextTotal.AutoSize = true;
            this.lbTextTotal.BackColor = System.Drawing.Color.Transparent;
            this.lbTextTotal.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTextTotal.Location = new System.Drawing.Point(41, 750);
            this.lbTextTotal.Name = "lbTextTotal";
            this.lbTextTotal.Size = new System.Drawing.Size(125, 42);
            this.lbTextTotal.TabIndex = 5;
            this.lbTextTotal.Text = "TOTAL:";
            // 
            // pbGarisAtas
            // 
            this.pbGarisAtas.BackColor = System.Drawing.Color.Gold;
            this.pbGarisAtas.Location = new System.Drawing.Point(0, 85);
            this.pbGarisAtas.Name = "pbGarisAtas";
            this.pbGarisAtas.Size = new System.Drawing.Size(644, 10);
            this.pbGarisAtas.TabIndex = 6;
            this.pbGarisAtas.TabStop = false;
            // 
            // formPenjualan
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1512, 982);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pbTxtBack);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.pbSearch);
            this.Controls.Add(this.tbSearchs);
            this.Controls.Add(this.panelAtas);
            this.Controls.Add(this.lbNamabarang);
            this.Controls.Add(this.pnlNota);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "formPenjualan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Penjualan";
            this.Load += new System.EventHandler(this.formMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbTxtBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).EndInit();
            this.panelAtas.ResumeLayout(false);
            this.panelAtas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).EndInit();
            this.pnlNota.ResumeLayout(false);
            this.pnlNota.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKotak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGarisAtas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelAtas;
        private System.Windows.Forms.PictureBox pbBack;
        private System.Windows.Forms.Label lbLogo;
        private System.Windows.Forms.Label lbNamabarang;
        private CustomControls.RJControls.RJTextBox tbSearchs;
        private System.Windows.Forms.PictureBox pbSearch;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.PictureBox pbTxtBack;
        private System.Windows.Forms.Panel pnlNota;
        private System.Windows.Forms.Label lbNota;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbIDJual;
        private System.Windows.Forms.PictureBox pbKotak;
        private CustomControls.RJControls.RJButton btnSubmit;
        private System.Windows.Forms.Label lbTextTotal;
        private System.Windows.Forms.PictureBox pbGarisAtas;
    }
}

