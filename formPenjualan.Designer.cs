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
            this.pnlNota = new System.Windows.Forms.Panel();
            this.lbTotal = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelNota = new System.Windows.Forms.Panel();
            this.pbGarisAtas = new System.Windows.Forms.PictureBox();
            this.lbTextTotal = new System.Windows.Forms.Label();
            this.pbKotak = new System.Windows.Forms.PictureBox();
            this.btnSubmit = new CustomControls.RJControls.RJButton();
            this.lbIDJual = new System.Windows.Forms.Label();
            this.lbNota = new System.Windows.Forms.Label();
            this.tbSearchs = new CustomControls.RJControls.RJTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbTxtBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            this.panelAtas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).BeginInit();
            this.pnlNota.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGarisAtas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKotak)).BeginInit();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNamabarang
            // 
            this.lbNamabarang.AutoSize = true;
            this.lbNamabarang.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNamabarang.ForeColor = System.Drawing.Color.Black;
            this.lbNamabarang.Location = new System.Drawing.Point(21, 143);
            this.lbNamabarang.Name = "lbNamabarang";
            this.lbNamabarang.Size = new System.Drawing.Size(347, 59);
            this.lbNamabarang.TabIndex = 6;
            this.lbNamabarang.Text = "Nama Barang";
            // 
            // tbSearch
            // 
            this.tbSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSearch.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(376, 142);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(417, 58);
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
            this.lbLogo.Size = new System.Drawing.Size(553, 97);
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
            // pnlNota
            // 
            this.pnlNota.BackColor = System.Drawing.Color.White;
            this.pnlNota.Controls.Add(this.lbTotal);
            this.pnlNota.Controls.Add(this.pictureBox1);
            this.pnlNota.Controls.Add(this.panelNota);
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
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.BackColor = System.Drawing.Color.Transparent;
            this.lbTotal.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(513, 750);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbTotal.Size = new System.Drawing.Size(82, 52);
            this.lbTotal.TabIndex = 16;
            this.lbTotal.Text = "......";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::POSTOKOAMANJAYA.Properties.Resources.header_nota;
            this.pictureBox1.Location = new System.Drawing.Point(25, 96);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(592, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // panelNota
            // 
            this.panelNota.AutoScroll = true;
            this.panelNota.Location = new System.Drawing.Point(25, 178);
            this.panelNota.Name = "panelNota";
            this.panelNota.Size = new System.Drawing.Size(592, 523);
            this.panelNota.TabIndex = 7;
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
            // lbTextTotal
            // 
            this.lbTextTotal.AutoSize = true;
            this.lbTextTotal.BackColor = System.Drawing.Color.Transparent;
            this.lbTextTotal.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTextTotal.Location = new System.Drawing.Point(36, 750);
            this.lbTextTotal.Name = "lbTextTotal";
            this.lbTextTotal.Size = new System.Drawing.Size(154, 52);
            this.lbTextTotal.TabIndex = 5;
            this.lbTextTotal.Text = "TOTAL:";
            // 
            // pbKotak
            // 
            this.pbKotak.BackColor = System.Drawing.Color.Gold;
            this.pbKotak.Location = new System.Drawing.Point(25, 740);
            this.pbKotak.Name = "pbKotak";
            this.pbKotak.Size = new System.Drawing.Size(592, 62);
            this.pbKotak.TabIndex = 4;
            this.pbKotak.TabStop = false;
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
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lbIDJual
            // 
            this.lbIDJual.AutoSize = true;
            this.lbIDJual.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIDJual.ForeColor = System.Drawing.Color.Goldenrod;
            this.lbIDJual.Location = new System.Drawing.Point(372, 26);
            this.lbIDJual.Name = "lbIDJual";
            this.lbIDJual.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbIDJual.Size = new System.Drawing.Size(301, 55);
            this.lbIDJual.TabIndex = 2;
            this.lbIDJual.Text = "J2211118001";
            // 
            // lbNota
            // 
            this.lbNota.AutoSize = true;
            this.lbNota.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNota.Location = new System.Drawing.Point(24, 26);
            this.lbNota.Name = "lbNota";
            this.lbNota.Size = new System.Drawing.Size(306, 55);
            this.lbNota.TabIndex = 0;
            this.lbNota.Text = "ID Penjualan";
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
            this.tbSearchs.Size = new System.Drawing.Size(473, 72);
            this.tbSearchs.TabIndex = 7;
            this.tbSearchs.Texts = "";
            this.tbSearchs.UnderlinedStyle = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mie Sedap Soto";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Highlight;
            this.label2.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 39);
            this.label2.TabIndex = 3;
            this.label2.Text = "QTY :  48";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Highlight;
            this.label3.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(11, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 39);
            this.label3.TabIndex = 4;
            this.label3.Text = " Rp 3.000";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Highlight;
            this.label4.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(278, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 53);
            this.label4.TabIndex = 5;
            this.label4.Text = "5";
            this.label4.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::POSTOKOAMANJAYA.Properties.Resources.logoMinus;
            this.button1.Location = new System.Drawing.Point(246, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 32);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::POSTOKOAMANJAYA.Properties.Resources.logoPlus;
            this.button2.Location = new System.Drawing.Point(312, 84);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 32);
            this.button2.TabIndex = 7;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            // 
            // panelMenu
            // 
            this.panelMenu.AutoScroll = true;
            this.panelMenu.Controls.Add(this.button2);
            this.panelMenu.Controls.Add(this.button1);
            this.panelMenu.Controls.Add(this.label4);
            this.panelMenu.Controls.Add(this.label3);
            this.panelMenu.Controls.Add(this.label2);
            this.panelMenu.Controls.Add(this.label1);
            this.panelMenu.Controls.Add(this.pictureBox3);
            this.panelMenu.Controls.Add(this.pictureBox2);
            this.panelMenu.Location = new System.Drawing.Point(29, 240);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(817, 742);
            this.panelMenu.TabIndex = 15;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::POSTOKOAMANJAYA.Properties.Resources.Kotak_Barang_1;
            this.pictureBox3.Location = new System.Drawing.Point(415, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(356, 121);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::POSTOKOAMANJAYA.Properties.Resources.Kotak_Barang_1;
            this.pictureBox2.Location = new System.Drawing.Point(3, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(356, 121);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // formPenjualan
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1512, 982);
            this.Controls.Add(this.panelMenu);
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
            this.Text = "v";
            this.Load += new System.EventHandler(this.formMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbTxtBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).EndInit();
            this.panelAtas.ResumeLayout(false);
            this.panelAtas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).EndInit();
            this.pnlNota.ResumeLayout(false);
            this.pnlNota.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGarisAtas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKotak)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.Label lbIDJual;
        private System.Windows.Forms.PictureBox pbKotak;
        private CustomControls.RJControls.RJButton btnSubmit;
        private System.Windows.Forms.Label lbTextTotal;
        private System.Windows.Forms.PictureBox pbGarisAtas;
        private System.Windows.Forms.Panel panelNota;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

