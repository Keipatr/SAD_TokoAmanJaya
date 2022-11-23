namespace POSTOKOAMANJAYA
{
    partial class formAddBarang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formAddBarang));
            this.tbNamaBarang = new System.Windows.Forms.TextBox();
            this.tbJumlah = new System.Windows.Forms.TextBox();
            this.tbHargaBeli = new System.Windows.Forms.TextBox();
            this.tbHargaJual = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbKategori = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbNamaBarang
            // 
            this.tbNamaBarang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNamaBarang.Font = new System.Drawing.Font("Arial", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNamaBarang.ForeColor = System.Drawing.Color.White;
            this.tbNamaBarang.Location = new System.Drawing.Point(227, 40);
            this.tbNamaBarang.Name = "tbNamaBarang";
            this.tbNamaBarang.Size = new System.Drawing.Size(373, 38);
            this.tbNamaBarang.TabIndex = 1;
            // 
            // tbJumlah
            // 
            this.tbJumlah.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbJumlah.Font = new System.Drawing.Font("Arial", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbJumlah.ForeColor = System.Drawing.Color.White;
            this.tbJumlah.Location = new System.Drawing.Point(227, 162);
            this.tbJumlah.Name = "tbJumlah";
            this.tbJumlah.Size = new System.Drawing.Size(85, 38);
            this.tbJumlah.TabIndex = 2;
            // 
            // tbHargaBeli
            // 
            this.tbHargaBeli.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbHargaBeli.Font = new System.Drawing.Font("Arial", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHargaBeli.ForeColor = System.Drawing.Color.White;
            this.tbHargaBeli.Location = new System.Drawing.Point(227, 224);
            this.tbHargaBeli.Name = "tbHargaBeli";
            this.tbHargaBeli.Size = new System.Drawing.Size(193, 38);
            this.tbHargaBeli.TabIndex = 3;
            // 
            // tbHargaJual
            // 
            this.tbHargaJual.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbHargaJual.Font = new System.Drawing.Font("Arial", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHargaJual.ForeColor = System.Drawing.Color.White;
            this.tbHargaJual.Location = new System.Drawing.Point(227, 287);
            this.tbHargaJual.Name = "tbHargaJual";
            this.tbHargaJual.Size = new System.Drawing.Size(193, 38);
            this.tbHargaJual.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(559, 366);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(123, 45);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(703, 366);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(123, 45);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cbKategori
            // 
            this.cbKategori.DropDownWidth = 180;
            this.cbKategori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbKategori.Font = new System.Drawing.Font("Arial", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKategori.ForeColor = System.Drawing.Color.White;
            this.cbKategori.FormattingEnabled = true;
            this.cbKategori.Items.AddRange(new object[] {
            "Food",
            "Drink",
            "Ciggaretes",
            "Detergent",
            "Shampoo",
            "Soap"});
            this.cbKategori.Location = new System.Drawing.Point(227, 99);
            this.cbKategori.Name = "cbKategori";
            this.cbKategori.Size = new System.Drawing.Size(85, 46);
            this.cbKategori.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::POSTOKOAMANJAYA.Properties.Resources.Nama_Barang___Kategori___Qty___Harga_Beli___Harga_Jual__;
            this.pictureBox1.Location = new System.Drawing.Point(42, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 280);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // formAddBarang
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(866, 455);
            this.Controls.Add(this.cbKategori);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbHargaJual);
            this.Controls.Add(this.tbHargaBeli);
            this.Controls.Add(this.tbJumlah);
            this.Controls.Add(this.tbNamaBarang);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "formAddBarang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Edit";
            this.Load += new System.EventHandler(this.formMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbNamaBarang;
        private System.Windows.Forms.TextBox tbJumlah;
        private System.Windows.Forms.TextBox tbHargaBeli;
        private System.Windows.Forms.TextBox tbHargaJual;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cbKategori;
    }
}

