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

        public static string sqlConnection = "server=139.255.11.84;uid=student;pwd=isbmantap;database=SAD_TokoAmanJaya";
        public MySqlConnection sqlConnect = new MySqlConnection(sqlConnection);
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;
        public string sqlQuery;
     
        public int X = 0;
        public int Y = 0;
        public int jmlMenu = 0;
        public DataTable dtBarang = new DataTable();
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
        }

        public void buatMenu()
        {

            try
            {
                sqlConnect.Open();
                DataTable dtBarang = new DataTable();
                sqlCommand = new MySqlCommand("pSearchBarang", sqlConnect);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("cekNama", tbSearch.Text);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtBarang);
                sqlConnect.Close();

                
            }
            catch (Exception ex)
            {

            }
            X = 3;
            Y = 12;
            try
            {


                for (int i = 0; i < 5; i++) // dtBarang.Rows.Count/2
                {
                    for (int j = 0; j < 2; j++)
                    {
                        //if (dtBarang.Rows[jmlMenu]["QTY"].ToString() == "0")
                        {
                            PictureBox menu = new PictureBox();
                            panelMenu.Controls.Add(menu);
                            menu.Image = Properties.Resources.Kotak_Barang_1;
                            menu.Size = new Size(356, 121);
                            menu.SizeMode = PictureBoxSizeMode.StretchImage;
                            menu.Location = new Point(X, Y);
                            X += 412;
                            if (X > 415)
                            {
                                X = 3;
                            }
                            Label lbNama = new Label();
                            Label lbQty = new Label();
                            Label lbHarga = new Label();
                            Label lbJumlah = new Label();
                            Button btnMinus = new Button();
                            Button btnPlus = new Button();

                            menu.Controls.Add(lbNama);
                            menu.Controls.Add(lbQty);
                            menu.Controls.Add(lbHarga);
                            menu.Controls.Add(lbJumlah);
                            menu.Controls.Add(btnPlus);
                            menu.Controls.Add(btnMinus);

                            lbNama.BackColor = ColorTranslator.FromHtml("#32324E");
                            lbQty.BackColor = ColorTranslator.FromHtml("#32324E");
                            lbHarga.BackColor = ColorTranslator.FromHtml("#32324E");
                            lbJumlah.BackColor = ColorTranslator.FromHtml("#32324E");

                            //lbNama.Text = dtBarang.Rows[0][0].ToString();
                            //lbQty.Text = dtBarang.Rows[0][0].ToString();
                            //lbHarga.Text = dtBarang.Rows[0][0].ToString();
                            //lbJumlah.Text = dtBarang.Rows[0][0].ToString();

                            btnPlus.Image = Properties.Resources.logoPlus;
                            btnMinus.Image = Properties.Resources.logoMinus;

                            btnPlus.FlatAppearance.BorderSize = 0;
                            btnPlus.FlatStyle = FlatStyle.Flat;
                            btnMinus.FlatAppearance.BorderSize = 0;
                            btnMinus.FlatStyle = FlatStyle.Flat;
                            btnMinus.Cursor = Cursors.Hand;
                            btnPlus.Cursor = Cursors.Hand;

                        }
                        jmlMenu++;
                    }
                    Y += 162;
                }
            }
            catch (Exception ex)
            {

            }

        }
        private void formMenu_Load(object sender, EventArgs e)
        {
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
            sqlCommand = new MySqlCommand("insert into NOTA_PENJUALAN() values('','',"+lbIDJual.Text.Replace(",", "").Trim(new char[] { '.', 'R', 'p', ' ', ',' }) + ",'N')", sqlConnect);
            sqlCommand.ExecuteNonQuery();

            //for(int i =0;i<count;i++) insert ke barang pembelian
            sqlConnect.Close();
        }
    }
}
