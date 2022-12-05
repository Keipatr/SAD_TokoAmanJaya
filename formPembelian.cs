﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace POSTOKOAMANJAYA
{
    public partial class formPembelian : Form
    {
        public formPembelian()
        {
            InitializeComponent();
        }
        //public static string sqlConnection = "server=127.0.0.1;uid=root;pwd=;database=sad_tokoamanjaya";
        public static string sqlConnection = "server=139.255.11.84;uid=student;pwd=isbmantap;database=SAD_TokoAmanJaya";
        public MySqlConnection sqlConnect = new MySqlConnection(sqlConnection);
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;
        public string sqlQuery;

        public static int cekBuatDT = 0;
        public static string nama = "";
        public static string hbeli = "";
        public static string id = "";
        public int jumlahBarang = 0;
        public int X = 0;
        public int Y = 0;
        public int jmlMenu = 0;
        public DataTable dtBarang = new DataTable();
        public static DataTable dtJumlahBarang = new DataTable();

        public Button menu = new Button();

        public int[] tes = new int[dtJumlahBarang.Rows.Count];
        public void loadDesign()
        {
            this.BackColor = ColorTranslator.FromHtml("#E4EFFF");
            tbSearchs.BackColor = ColorTranslator.FromHtml("#FFC814");
            tbSearchs.BorderColor = ColorTranslator.FromHtml("#FFC814");
            tbSearchs.BorderFocusColor = ColorTranslator.FromHtml("#FFC814");
            tbSearchs.Enabled = false;
            tbSearch.BackColor = ColorTranslator.FromHtml("#FFC814");
            pbSearch.BackColor = ColorTranslator.FromHtml("#FFC814");
            lbLogo.ForeColor = ColorTranslator.FromHtml("#FFC814");
            lbNota.ForeColor = ColorTranslator.FromHtml("#091D36");
            lbIDJual.ForeColor = ColorTranslator.FromHtml("#FF9900");
            pnlNota.BackColor = Color.White;
            pbKotak.BackColor = ColorTranslator.FromHtml("#FFC814");
            lbTextTotal.BackColor = ColorTranslator.FromHtml("#FFC814");
            lbTotal.BackColor = ColorTranslator.FromHtml("#FFC814");
            lbTotal.Text = "";
            btnSubmit.BackColor = ColorTranslator.FromHtml("#32324E");
            pbGarisAtas.BackColor = ColorTranslator.FromHtml("#32324E");
            panelMenu.BackColor = ColorTranslator.FromHtml("#E4EFFF");

            DataTable dtIdNota = new DataTable();
            sqlConnect.Open();
            sqlCommand = new MySqlCommand("select fAutogenIDBeli()", sqlConnect);            
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtIdNota);
            sqlConnect.Close();
            lbIDJual.Text = dtIdNota.Rows[0][0].ToString();
        }

        public void buatMenu()
        {
            DataTable dtBarang = new DataTable();
            sqlConnect.Open();
            sqlCommand = new MySqlCommand("pSearchBarang", sqlConnect);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("cekNama", tbSearch.Text);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtBarang);
            sqlConnect.Close();
            
            
            DataTable dtJumlahBarang = new DataTable();
            sqlConnect.Open();
            sqlCommand = new MySqlCommand("select * from BARANG where status_delete = 'N'", sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtJumlahBarang);
            sqlConnect.Close();

            jumlahBarang = dtJumlahBarang.Rows.Count;
            X = 3;
            Y = 12;

            jmlMenu = 0;
            for (int i = 0; i < (dtBarang.Rows.Count / 2)+1; i++)
            {
                
                    for (int j = 0; j < 2; j++)
                    {
                        if (dtBarang.Rows.Count > 0 && jmlMenu < dtBarang.Rows.Count)
                        {
                            menu = new Button();
                            panelMenu.Controls.Add(menu);
                            menu.Image = Properties.Resources.Kotak_Barang_1;
                            menu.Text = dtBarang.Rows[jmlMenu]["Nama Barang"].ToString() + "\nQTY : " + dtBarang.Rows[jmlMenu]["QTY"];
                            menu.Font = new Font("Arial", 20, FontStyle.Regular);
                            menu.ForeColor = Color.White;
                            menu.FlatStyle = FlatStyle.Flat;
                            menu.FlatAppearance.BorderSize = 0;
                            menu.TextAlign = ContentAlignment.MiddleLeft;
                            menu.TextImageRelation = TextImageRelation.Overlay;
                            menu.Size = new Size(355, 121);
                            menu.Location = new Point(X, Y);
                            menu.Cursor = Cursors.Hand;
                            menu.Click += Menu_Click;
                            menu.Name = Convert.ToString(jmlMenu);
                            menu.Tag = jmlMenu;
                            X += 412;
                            if (X > 415)
                            {
                                X = 3;
                            }
                            jmlMenu++;
                        }
                    }
                Y += 162;
            }


        }
        private void Menu_Click(object sender, EventArgs e)
        {
            DataTable dtBarang = new DataTable();
            sqlConnect.Open();
            sqlCommand = new MySqlCommand("pSearchBarang", sqlConnect);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("cekNama", tbSearch.Text);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtBarang);
            sqlConnect.Close();

            nama = dtBarang.Rows[Convert.ToInt32(((Button)sender).Tag)]["Nama Barang"].ToString();

            formPembelianAdd formPembelianAdd = new formPembelianAdd();
            Button button = sender as Button;
            //nama =  dtBarang.Rows[Convert.ToInt32(button.Tag)]["Nama Barang"].ToString();
            hbeli = dtBarang.Rows[Convert.ToInt32(button.Tag)]["Harga Beli"].ToString();
            id = dtBarang.Rows[Convert.ToInt32(button.Tag)]["ID Barang"].ToString();
            formPembelianAdd.ShowDialog();

            buatNota();
        }
        public void buatNota()
        {
            panelNota.Controls.Clear();
            DataTable dtSimpan = formPembelianAdd.notaIsi;

            int y = 15;
            for (int i = 0; i < dtSimpan.Rows.Count;i++)
            {
                if (dtSimpan.Rows.Count >0)
                {
                    Label nama = new Label();
                    Label jumlah = new Label();
                    Label harga = new Label();

                    panelNota.Controls.Add(nama);
                    panelNota.Controls.Add(jumlah);
                    panelNota.Controls.Add(harga);

                    nama.Text = dtSimpan.Rows[i]["nama"].ToString();
                    jumlah.Text = dtSimpan.Rows[i]["jumlah"].ToString();
                    harga.Text = dtSimpan.Rows[i]["harga"].ToString();

                    nama.Location = new Point(2,y);
                    harga.Location = new Point(430, y);
                    jumlah.Location = new Point(320, y);

                    nama.Size = new Size(290, 27);
                    harga.AutoSize = true;
                    jumlah.Size = new Size(109, 27);

                    nama.Font = new Font("Arial", 15, FontStyle.Regular);
                    harga.Font = new Font("Arial", 15, FontStyle.Regular);
                    jumlah.Font = new Font("Arial", 15, FontStyle.Regular);

                    nama.ForeColor = Color.Black;
                    jumlah.ForeColor = Color.Black;
                    harga.ForeColor = Color.Black;

                    nama.BackColor = Color.Transparent;
                    jumlah.BackColor = Color.Transparent;
                    harga.BackColor = Color.Transparent;

                    nama.UseCompatibleTextRendering = true;
                    jumlah.UseCompatibleTextRendering = true;
                    harga.UseCompatibleTextRendering = true;

                    nama.AutoEllipsis = true;
                    jumlah.AutoEllipsis = true;
                    harga.AutoEllipsis = true;


                    y += 43;

                    //lbTotal.Text = lbTotal.Text + (int.Parse(dtSimpan.Rows[i]["jumlah"]) * int.Parse(dtSimpan.Rows[i]["harga"]));
                } 
            }
        }
        private void formMenu_Load(object sender, EventArgs e)
        {
            formPembelianAdd.notaIsi = new DataTable();
            cekBuatDT = 0;
            loadDesign();
            buatMenu();
        }

        private void pbSearch_Click(object sender, EventArgs e)
        {
            tbSearch.Select();
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            formMenu formMenu = new formMenu();
            formMenu.ShowDialog();
            this.Close();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {            
            panelMenu.Controls.Clear();
            buatMenu();
        }

        private void pbBack_MouseHover(object sender, EventArgs e)
        {
            pbTxtBack.Visible = true;
        }

        private void pbBack_MouseLeave(object sender, EventArgs e)
        {
            pbTxtBack.Visible= false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            
            sqlConnect.Open();
            sqlCommand = new MySqlCommand("insert into NOTA_PENJUALAN() values('','',"+lbTotal.Text.Replace(",", "").Trim(new char[] { '.', 'R', 'p', ' ', ',' }) + ",'N')", sqlConnect);
            sqlCommand.ExecuteNonQuery();

            for(int i =0;i<formPembelianAdd.notaIsi.Rows.Count;i++) //insert ke barang pembelian
            {
                //sqlCommand = new MySqlCommand("insert into BARANG_PENJUALAN() values('"+lbIDJual.Text+"',''," + lbIDJual.Text.Replace(",", "").Trim(new char[] { '.', 'R', 'p', ' ', ',' }) + ",'N')", sqlConnect);
                //sqlCommand.ExecuteNonQuery();
            }
            sqlConnect.Close();

            cekBuatDT = 0;
            formPembelianAdd.notaIsi = new DataTable();
            Form formBackground = new Form();
            try
            {
                using (formDoneAdd uu = new formDoneAdd())
                {
                    formBackground.StartPosition = FormStartPosition.Manual;
                    formBackground.FormBorderStyle = FormBorderStyle.None;
                    formBackground.Opacity = .30d;
                    formBackground.BackColor = Color.Gray;
                    formBackground.WindowState = FormWindowState.Maximized;
                    formBackground.TopMost = true;
                    formBackground.Location = this.Location;
                    formBackground.ShowInTaskbar = false;
                    formBackground.Show();

                    uu.Owner = formBackground;
                    uu.ShowDialog();

                    formBackground.Dispose();
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {
                formBackground.Dispose();
            }
        }
    }
}
