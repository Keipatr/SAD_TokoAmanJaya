namespace POSTOKOAMANJAYA
{
    partial class formAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formAdd));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbKategori = new POSTOKOAMANJAYA.CustomTool.RJComboBox();
            this.tbNama = new CustomControls.RJControls.RJTextBox();
            this.btnCancel = new CustomControls.RJControls.RJButton();
            this.btnSave = new CustomControls.RJControls.RJButton();
            this.tbQty = new CustomControls.RJControls.RJTextBox();
            this.tbBeli = new CustomControls.RJControls.RJTextBox();
            this.tbJual = new CustomControls.RJControls.RJTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 36);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nama Barang :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 36);
            this.label2.TabIndex = 10;
            this.label2.Text = "Qty :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 36);
            this.label3.TabIndex = 11;
            this.label3.Text = "Harga Beli :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 36);
            this.label4.TabIndex = 12;
            this.label4.Text = "Harga Jual :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 36);
            this.label5.TabIndex = 17;
            this.label5.Text = "Kategori : ";
            // 
            // cbKategori
            // 
            this.cbKategori.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbKategori.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cbKategori.BorderRadius = 12;
            this.cbKategori.BorderSize = 0;
            this.cbKategori.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbKategori.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKategori.ForeColor = System.Drawing.Color.White;
            this.cbKategori.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cbKategori.Items.AddRange(new object[] {
            "Food",
            "Drink",
            "Ciggaretes",
            "Detergent",
            "Shampoo",
            "Soap"});
            this.cbKategori.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbKategori.ListTextColor = System.Drawing.Color.White;
            this.cbKategori.Location = new System.Drawing.Point(232, 101);
            this.cbKategori.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbKategori.Name = "cbKategori";
            this.cbKategori.Size = new System.Drawing.Size(280, 40);
            this.cbKategori.TabIndex = 18;
            this.cbKategori.Texts = "Pilih Kategori";
            // 
            // tbNama
            // 
            this.tbNama.BackColor = System.Drawing.SystemColors.Window;
            this.tbNama.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tbNama.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbNama.BorderRadius = 12;
            this.tbNama.BorderSize = 2;
            this.tbNama.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNama.ForeColor = System.Drawing.Color.White;
            this.tbNama.Location = new System.Drawing.Point(232, 44);
            this.tbNama.Margin = new System.Windows.Forms.Padding(4);
            this.tbNama.Multiline = false;
            this.tbNama.Name = "tbNama";
            this.tbNama.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbNama.PasswordChar = false;
            this.tbNama.PlaceholderColor = System.Drawing.Color.White;
            this.tbNama.PlaceholderText = "";
            this.tbNama.Size = new System.Drawing.Size(373, 42);
            this.tbNama.TabIndex = 13;
            this.tbNama.Texts = "";
            this.tbNama.UnderlinedStyle = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnCancel.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnCancel.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCancel.BorderRadius = 22;
            this.btnCancel.BorderSize = 0;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(549, 382);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(123, 45);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextColor = System.Drawing.Color.White;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSave.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSave.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSave.BorderRadius = 22;
            this.btnSave.BorderSize = 0;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(692, 382);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(123, 45);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.TextColor = System.Drawing.Color.White;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbQty
            // 
            this.tbQty.BackColor = System.Drawing.SystemColors.Window;
            this.tbQty.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tbQty.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbQty.BorderRadius = 12;
            this.tbQty.BorderSize = 2;
            this.tbQty.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbQty.ForeColor = System.Drawing.Color.White;
            this.tbQty.Location = new System.Drawing.Point(232, 155);
            this.tbQty.Margin = new System.Windows.Forms.Padding(4);
            this.tbQty.Multiline = false;
            this.tbQty.Name = "tbQty";
            this.tbQty.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbQty.PasswordChar = false;
            this.tbQty.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbQty.PlaceholderText = "";
            this.tbQty.Size = new System.Drawing.Size(85, 42);
            this.tbQty.TabIndex = 14;
            this.tbQty.Texts = "";
            this.tbQty.UnderlinedStyle = false;
            this.tbQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbQty_KeyPress);
            // 
            // tbBeli
            // 
            this.tbBeli.BackColor = System.Drawing.SystemColors.Window;
            this.tbBeli.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tbBeli.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbBeli.BorderRadius = 12;
            this.tbBeli.BorderSize = 2;
            this.tbBeli.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBeli.ForeColor = System.Drawing.Color.White;
            this.tbBeli.Location = new System.Drawing.Point(232, 216);
            this.tbBeli.Margin = new System.Windows.Forms.Padding(4);
            this.tbBeli.Multiline = false;
            this.tbBeli.Name = "tbBeli";
            this.tbBeli.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbBeli.PasswordChar = false;
            this.tbBeli.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbBeli.PlaceholderText = "";
            this.tbBeli.Size = new System.Drawing.Size(193, 42);
            this.tbBeli.TabIndex = 15;
            this.tbBeli.Texts = "";
            this.tbBeli.UnderlinedStyle = false;
            this.tbBeli.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBeli_KeyPress);
            // 
            // tbJual
            // 
            this.tbJual.BackColor = System.Drawing.SystemColors.Window;
            this.tbJual.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tbJual.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbJual.BorderRadius = 12;
            this.tbJual.BorderSize = 2;
            this.tbJual.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbJual.ForeColor = System.Drawing.Color.White;
            this.tbJual.Location = new System.Drawing.Point(232, 273);
            this.tbJual.Margin = new System.Windows.Forms.Padding(4);
            this.tbJual.Multiline = false;
            this.tbJual.Name = "tbJual";
            this.tbJual.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbJual.PasswordChar = false;
            this.tbJual.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbJual.PlaceholderText = "";
            this.tbJual.Size = new System.Drawing.Size(193, 42);
            this.tbJual.TabIndex = 16;
            this.tbJual.Texts = "";
            this.tbJual.UnderlinedStyle = false;
            this.tbJual.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbJual_KeyPress);
            // 
            // formAdd
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(866, 455);
            this.Controls.Add(this.cbKategori);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbNama);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbQty);
            this.Controls.Add(this.tbBeli);
            this.Controls.Add(this.tbJual);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "formAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Edit";
            this.Load += new System.EventHandler(this.formMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CustomControls.RJControls.RJButton btnSave;
        private CustomControls.RJControls.RJButton btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private CustomControls.RJControls.RJTextBox tbNama;
        private CustomControls.RJControls.RJTextBox tbQty;
        private CustomControls.RJControls.RJTextBox tbBeli;
        private CustomControls.RJControls.RJTextBox tbJual;
        private System.Windows.Forms.Label label5;
        private CustomTool.RJComboBox cbKategori;
    }
}

