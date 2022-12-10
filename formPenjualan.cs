using System;
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
    public partial class formPenjualan : Form
    {
        public formPenjualan()
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
        public static string hjual = "";
        public static string id = "";
        public int jumlahBarang = 0;
        public int X = 0;
        public int Y = 0;
        public int jmlMenu = 0;
        public int sum =0;
        public static DataTable dtBarang = new DataTable();
        public static DataTable dtJumlahBarang = new DataTable();
        public DataTable dtSimpan;

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
            pnlKotak.BackColor = ColorTranslator.FromHtml("#FFC814");
            lbTextTotal.BackColor = ColorTranslator.FromHtml("#FFC814");
            lbTotal.BackColor = ColorTranslator.FromHtml("#FFC814");
            lbTotal.Text = "";
            btnSubmit.BackColor = ColorTranslator.FromHtml("#32324E");
            pbGarisAtas.BackColor = ColorTranslator.FromHtml("#32324E");
            panelMenu.BackColor = ColorTranslator.FromHtml("#E4EFFF");

            DataTable dtIdNota = new DataTable();
            sqlConnect.Open();
            sqlCommand = new MySqlCommand("select fAutogenIDJual()", sqlConnect);            
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtIdNota);
            sqlConnect.Close();
            lbIDJual.Text = dtIdNota.Rows[0][0].ToString();
        }

        public void buatMenu()
        {
            dtBarang = new DataTable();
            sqlConnect.Open();
            sqlCommand = new MySqlCommand("pSearchBarang", sqlConnect);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("cekNama", tbSearch.Text);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtBarang);
            sqlConnect.Close();
            X = 3;
            Y = 12;

            jmlMenu = 0;
            for (int i = 0; i < (dtBarang.Rows.Count / 2)+1; i++)
            {
                
                    for (int j = 0; j < 2; j++)
                    {
                        if (dtBarang.Rows.Count > 0 && jmlMenu < dtBarang.Rows.Count && int.Parse(dtBarang.Rows[jmlMenu]["QTY"].ToString()) >0)
                        {
                            menu = new Button();
                            panelMenu.Controls.Add(menu);
                            menu.Image = Properties.Resources.Kotak_Barang_1;
                            menu.Text = dtBarang.Rows[jmlMenu]["Nama Barang"].ToString() + "\nQTY : " + dtBarang.Rows[jmlMenu]["QTY"] + "\nRp "+ Convert.ToInt64(dtBarang.Rows[jmlMenu]["Harga Jual"].ToString().Replace(",", "").Replace(".", "").Trim(new char[] { '.', 'R', 'p', ' ', ',' })).ToString("#,#");
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

            formPenjualanAdd formPenjualanAdd = new formPenjualanAdd();
            Button button = sender as Button;
            hjual = dtBarang.Rows[Convert.ToInt32(button.Tag)]["Harga Jual"].ToString();
            id = dtBarang.Rows[Convert.ToInt32(button.Tag)]["ID Barang"].ToString();
            formPenjualanAdd.ShowDialog();

            buatNota();
        }
        public void buatNota()
        {
            panelNota.Controls.Clear();
            dtSimpan = formPenjualanAdd.notaIsi;
            sum = 0;
            int y = 15;
            for (int i = 0; i < dtSimpan.Rows.Count;i++)
            {
                if (dtSimpan.Rows.Count >0)
                {
                    
                    Label nama = new Label();
                    Label jumlah = new Label();
                    Label harga = new Label();
                    PictureBox silang = new PictureBox();

                    panelNota.Controls.Add(nama);
                    panelNota.Controls.Add(jumlah);
                    panelNota.Controls.Add(harga);
                    panelNota.Controls.Add(silang);

                    silang.Image = Properties.Resources.maki_cross;
                    silang.SizeMode = PictureBoxSizeMode.StretchImage;
                    silang.Size = new Size(22, 23);
                    silang.Location = new Point(2, y);
                    silang.Tag = i;
                    silang.Name = i.ToString();
                    silang.Cursor = Cursors.Hand;
                    silang.Click += Silang_Click;
                    silang.BringToFront();

                    nama.Text = dtSimpan.Rows[i]["nama"].ToString();
                    jumlah.Text = dtSimpan.Rows[i]["jumlah"].ToString();
                    harga.Text = dtSimpan.Rows[i]["harga"].ToString();

                    nama.Location = new Point(24,y);
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
                    
                }
                
            }
            for (int j = 0; j < dtSimpan.Rows.Count; j++)
            {
                sum += (int.Parse(dtSimpan.Rows[j]["jumlah"].ToString()) * int.Parse(dtSimpan.Rows[j]["harga"].ToString().Replace(",", "").Replace(".", "").Trim(new char[] { '.', 'R', 'p', ' ', ',' })));
            }
            if (formPenjualanAdd.notaIsi.Rows.Count == 0)
            {
                lbTotal.Text = "";
            }
            else
            {
                lbTotal.Text = "Rp. " + sum.ToString("#,#");
            }

        }

        private void Silang_Click(object sender, EventArgs e)
        {
            formPenjualanAdd.notaIsi.Rows.Remove(formPenjualanAdd.notaIsi.Rows[int.Parse(((PictureBox)sender).Name)]);
            if (formPenjualanAdd.notaIsi.Rows.Count == 0)
            {
                lbTotal.Text= "";
            }
            buatNota();
        }

        private void formMenu_Load(object sender, EventArgs e)
        {
            formPenjualanAdd.notaIsi = new DataTable();
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

            //sqlConnect.Open();
            ////MessageBox.Show("insert into NOTA_PENJUALAN() values('" + lbIDJual.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "'," + lbTotal.Text.Replace(",", "").Replace(".", "").Trim(new char[] { '.', 'R', 'p', ' ', ',' }) + ",'N')");
            //sqlCommand = new MySqlCommand("insert into NOTA_PENJUALAN() values('"+lbIDJual.Text+"','"+ DateTime.Now.ToString("yyyy-MM-dd") +"',"+lbTotal.Text.Replace(",", "").Replace(".", "").Trim(new char[] { '.', 'R', 'p', ' ', ',' }) + ",'N')", sqlConnect);
            //sqlCommand.ExecuteNonQuery();
            //sqlConnect.Close();

            sqlConnect.Open();
            for (int i = 0; i < formPenjualanAdd.notaIsi.Rows.Count; i++) //insert ke barang PENJUALAN
            {
                if (i == 0)
                {
                    //MessageBox.Show("insert into NOTA_PENJUALAN() values('" + lbIDJual.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "'," + lbTotal.Text.Replace(",", "").Replace(".", "").Trim(new char[] { '.', 'R', 'p', ' ', ',' }) + ",'N')");
                    sqlCommand = new MySqlCommand("insert into NOTA_PENJUALAN() values('" + lbIDJual.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "'," + lbTotal.Text.Replace(",", "").Replace(".", "").Trim(new char[] { '.', 'R', 'p', ' ', ',' }) + ",'N')", sqlConnect);
                    sqlCommand.ExecuteNonQuery();
                }
                sqlCommand = new MySqlCommand("insert into BARANG_PENJUALAN() values('" + lbIDJual.Text + "','" + formPenjualanAdd.notaIsi.Rows[i]["id"].ToString() + "','" + formPenjualanAdd.notaIsi.Rows[i]["jumlah"].ToString() + "','" + formPenjualanAdd.notaIsi.Rows[i]["harga"].ToString().Replace(",", "").Replace(".", "").Trim(new char[] { '.', 'R', 'p', ' ', ',' }) + "'," + lbTotal.Text.Replace(",", "").Replace(".", "").Trim(new char[] { '.', 'R', 'p', ' ', ',' }) + ",'N')", sqlConnect);
                //MessageBox.Show("insert into BARANG_PENJUALAN() values('"+lbIDJual.Text+"', '"+formPenjualanAdd.notaIsi.Rows[i]["id"].ToString()+"', "+formPenjualanAdd.notaIsi.Rows[i]["jumlah"].ToString()+", "+formPenjualanAdd.notaIsi.Rows[i]["harga"].ToString().Replace(",", "").Replace(".", "").Trim(new char[] { '.', 'R', 'p', ' ', ',' }) + ", " + lbTotal.Text.Replace(", ", "").Replace(".", "").Trim(new char[] { '.', 'R', 'p', ' ', ',' }) + ", 'N')");
                sqlCommand.ExecuteNonQuery();
            }
            sqlConnect.Close();

            cekBuatDT = 0;
            formPenjualanAdd.notaIsi = new DataTable();
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
            
            DataTable dtIdNota = new DataTable();
            sqlConnect.Open();
            sqlCommand = new MySqlCommand("select fAutogenIDJual()", sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtIdNota);
            sqlConnect.Close();
            lbIDJual.Text = dtIdNota.Rows[0][0].ToString();
            
            panelMenu.Controls.Clear();
            buatMenu();
            buatNota();
        }
    }
}
