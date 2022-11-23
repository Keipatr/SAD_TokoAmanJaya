namespace POSTOKOAMANJAYA
{
    partial class formInventory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formInventory));
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.dgvInven = new System.Windows.Forms.DataGridView();
            this.paneldgvSearch = new System.Windows.Forms.Panel();
            this.pbBack = new System.Windows.Forms.PictureBox();
            this.pbNamaBarang = new System.Windows.Forms.PictureBox();
            this.pbSearch = new System.Windows.Forms.PictureBox();
            this.panelAtas = new System.Windows.Forms.Panel();
            this.pbEdit = new System.Windows.Forms.PictureBox();
            this.pbAdd = new System.Windows.Forms.PictureBox();
            this.pbTextPenjualan = new System.Windows.Forms.PictureBox();
            this.panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInven)).BeginInit();
            this.paneldgvSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNamaBarang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            this.panelAtas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTextPenjualan)).BeginInit();
            this.SuspendLayout();
            // 
            // tbSearch
            // 
            this.tbSearch.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tbSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 38.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(53, 1);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(420, 58);
            this.tbSearch.TabIndex = 2;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // panelSearch
            // 
            this.panelSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelSearch.Controls.Add(this.pbSearch);
            this.panelSearch.Controls.Add(this.tbSearch);
            this.panelSearch.Location = new System.Drawing.Point(365, 133);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(473, 60);
            this.panelSearch.TabIndex = 3;
            // 
            // dgvInven
            // 
            this.dgvInven.AllowUserToAddRows = false;
            this.dgvInven.AllowUserToDeleteRows = false;
            this.dgvInven.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInven.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvInven.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInven.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInven.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInven.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInven.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInven.EnableHeadersVisualStyles = false;
            this.dgvInven.Location = new System.Drawing.Point(0, 0);
            this.dgvInven.MultiSelect = false;
            this.dgvInven.Name = "dgvInven";
            this.dgvInven.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInven.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvInven.RowHeadersVisible = false;
            this.dgvInven.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.dgvInven.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvInven.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvInven.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInven.Size = new System.Drawing.Size(1297, 665);
            this.dgvInven.TabIndex = 4;
            this.dgvInven.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInven_CellContentClick);
            // 
            // paneldgvSearch
            // 
            this.paneldgvSearch.Controls.Add(this.dgvInven);
            this.paneldgvSearch.Location = new System.Drawing.Point(108, 247);
            this.paneldgvSearch.Name = "paneldgvSearch";
            this.paneldgvSearch.Size = new System.Drawing.Size(1297, 665);
            this.paneldgvSearch.TabIndex = 5;
            // 
            // pbBack
            // 
            this.pbBack.BackColor = System.Drawing.Color.Transparent;
            this.pbBack.Image = global::POSTOKOAMANJAYA.Properties.Resources.logoback;
            this.pbBack.Location = new System.Drawing.Point(1249, 18);
            this.pbBack.Name = "pbBack";
            this.pbBack.Size = new System.Drawing.Size(55, 55);
            this.pbBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbBack.TabIndex = 3;
            this.pbBack.TabStop = false;
            // 
            // pbNamaBarang
            // 
            this.pbNamaBarang.BackColor = System.Drawing.Color.Transparent;
            this.pbNamaBarang.Image = global::POSTOKOAMANJAYA.Properties.Resources.Nama_Barang;
            this.pbNamaBarang.Location = new System.Drawing.Point(110, 152);
            this.pbNamaBarang.Name = "pbNamaBarang";
            this.pbNamaBarang.Size = new System.Drawing.Size(231, 36);
            this.pbNamaBarang.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbNamaBarang.TabIndex = 6;
            this.pbNamaBarang.TabStop = false;
            // 
            // pbSearch
            // 
            this.pbSearch.BackColor = System.Drawing.Color.Transparent;
            this.pbSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pbSearch.Image = global::POSTOKOAMANJAYA.Properties.Resources.search;
            this.pbSearch.Location = new System.Drawing.Point(11, 12);
            this.pbSearch.Name = "pbSearch";
            this.pbSearch.Size = new System.Drawing.Size(36, 33);
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
            this.panelAtas.Controls.Add(this.pbBack);
            this.panelAtas.Controls.Add(this.pbEdit);
            this.panelAtas.Controls.Add(this.pbAdd);
            this.panelAtas.Controls.Add(this.pbTextPenjualan);
            this.panelAtas.Location = new System.Drawing.Point(0, 0);
            this.panelAtas.Name = "panelAtas";
            this.panelAtas.Size = new System.Drawing.Size(1512, 91);
            this.panelAtas.TabIndex = 0;
            // 
            // pbEdit
            // 
            this.pbEdit.BackColor = System.Drawing.Color.Transparent;
            this.pbEdit.Image = global::POSTOKOAMANJAYA.Properties.Resources.logoedit;
            this.pbEdit.Location = new System.Drawing.Point(1164, 17);
            this.pbEdit.Name = "pbEdit";
            this.pbEdit.Size = new System.Drawing.Size(55, 55);
            this.pbEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbEdit.TabIndex = 3;
            this.pbEdit.TabStop = false;
            // 
            // pbAdd
            // 
            this.pbAdd.BackColor = System.Drawing.Color.Transparent;
            this.pbAdd.Image = global::POSTOKOAMANJAYA.Properties.Resources.logoadd;
            this.pbAdd.Location = new System.Drawing.Point(1334, 18);
            this.pbAdd.Name = "pbAdd";
            this.pbAdd.Size = new System.Drawing.Size(55, 55);
            this.pbAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbAdd.TabIndex = 2;
            this.pbAdd.TabStop = false;
            // 
            // pbTextPenjualan
            // 
            this.pbTextPenjualan.BackColor = System.Drawing.Color.Transparent;
            this.pbTextPenjualan.Image = global::POSTOKOAMANJAYA.Properties.Resources.PENJUALAN;
            this.pbTextPenjualan.Location = new System.Drawing.Point(22, 16);
            this.pbTextPenjualan.Name = "pbTextPenjualan";
            this.pbTextPenjualan.Size = new System.Drawing.Size(398, 62);
            this.pbTextPenjualan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbTextPenjualan.TabIndex = 1;
            this.pbTextPenjualan.TabStop = false;
            // 
            // formInventory
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1496, 943);
            this.Controls.Add(this.pbNamaBarang);
            this.Controls.Add(this.panelSearch);
            this.Controls.Add(this.panelAtas);
            this.Controls.Add(this.paneldgvSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1512, 982);
            this.MinimumSize = new System.Drawing.Size(1512, 982);
            this.Name = "formInventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Penjualan";
            this.Load += new System.EventHandler(this.formMenu_Load);
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInven)).EndInit();
            this.paneldgvSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNamaBarang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).EndInit();
            this.panelAtas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTextPenjualan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAtas;
        private System.Windows.Forms.PictureBox pbTextPenjualan;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.PictureBox pbSearch;
        private System.Windows.Forms.DataGridView dgvInven;
        private System.Windows.Forms.Panel paneldgvSearch;
        private System.Windows.Forms.PictureBox pbNamaBarang;
        private System.Windows.Forms.PictureBox pbEdit;
        private System.Windows.Forms.PictureBox pbAdd;
        private System.Windows.Forms.PictureBox pbBack;
    }
}

