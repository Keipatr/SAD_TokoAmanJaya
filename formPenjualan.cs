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
        public static string sqlConnection = "server=127.0.0.1;uid=root;pwd=;database=sad_tokoamanjaya";
       // public static string sqlConnection = "server=139.255.11.84;uid=student;pwd=isbmantap;database=SAD_TokoAmanJaya";
        public MySqlConnection sqlConnect = new MySqlConnection(sqlConnection);
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;
        public string sqlQuery;

        public int jumlahBarang = 0;
        public int X = 0;
        public int Y = 0;
        public int jmlMenu = 0;
        public DataTable dtBarang = new DataTable();

        public Dictionary<Button, Label> mappingPlus = new Dictionary<Button, Label>();
        public Dictionary<Button, Label> mappingMinus = new Dictionary<Button, Label>();

        //public Label[] lbNama;
        //public Label[] lbQty;
        //public Label[] lbHarga;
        //public Label[] lbJumlah;
        //public Button[] btnMinus;
        //public Button[] btnPlus;

        public Label lbNama = new Label();
        public Label lbQty = new Label();
        public Label lbHarga = new Label();
        public Label lbJumlah = new Label();
        public Button btnMinus = new Button();
        public Button btnPlus = new Button();

        public PictureBox menu = new PictureBox();
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
            sqlCommand = new MySqlCommand("select fAutogenIDJual()", sqlConnect);            
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtIdNota);
            sqlConnect.Close();
            lbIDJual.Text = dtIdNota.Rows[0][0].ToString();
        }

        public void buatMenu()
        {
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

            lbTextTotal.Text = dtBarang.Rows[0]["QTY"].ToString();
            jmlMenu = 0;
            //Label[] lbNama = new Label[jumlahBarang];
            //Label[] lbQty = new Label[jumlahBarang];
            //Label[] lbHarga = new Label[jumlahBarang];
            //Label[] lbJumlah = new Label[jumlahBarang];
            //Button[] btnMinus = new Button[jumlahBarang];
            //Button[] btnPlus = new Button[jumlahBarang];
            //Dictionary<Button, Label> mappingPlus = new Dictionary<Button, Label>();
            //Dictionary<Button, Label> mappingMinus = new Dictionary<Button, Label>();

            for (int i = 0; i < dtBarang.Rows.Count / 2; i++) // dtBarang.Rows.Count/2 
            {
                for (int j = 0; j < 2; j++)
                {
                    if (dtBarang.Rows[jmlMenu]["QTY"].ToString() != "0" && dtBarang.Rows.Count > 0)
                    {
                        menu = new PictureBox();
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
                        //Label[] lbNama = new Label[jumlahBarang];
                        //Label[] lbQty = new Label[jumlahBarang];
                        //Label[] lbHarga = new Label[jumlahBarang];
                        //Label[] lbJumlah = new Label[jumlahBarang];
                        //Button[] btnMinus = new Button[jumlahBarang];
                        //Button[] btnPlus = new Button[jumlahBarang];

                        //lbNama[jmlMenu] = new System.Windows.Forms.Label();
                        //lbQty[jmlMenu] = new System.Windows.Forms.Label();
                        //lbHarga[jmlMenu] = new System.Windows.Forms.Label();
                        //lbJumlah[jmlMenu] = new System.Windows.Forms.Label();
                        //btnMinus[jmlMenu] = new System.Windows.Forms.Button();
                        //btnPlus[jmlMenu] = new System.Windows.Forms.Button();

                        lbNama = new Label();
                        lbQty = new Label();
                        lbHarga = new Label();
                        lbJumlah = new Label();
                        btnMinus = new Button();
                        btnPlus = new Button();

                        menu.Controls.Add(btnMinus);
                        menu.Controls.Add(btnPlus);
                        menu.Controls.Add(lbJumlah);
                        menu.Controls.Add(lbHarga);
                        menu.Controls.Add(lbQty);
                        menu.Controls.Add(lbNama);

                        //menu.Controls.Add(lbQty);
                        //menu.Controls.Add(lbHarga);
                        //menu.Controls.Add(lbJumlah);
                        //menu.Controls.Add(btnPlus);
                        //menu.Controls.Add(btnMinus);

                        lbNama.BackColor = ColorTranslator.FromHtml("#32324E");
                        lbQty.BackColor = ColorTranslator.FromHtml("#32324E");
                        lbHarga.BackColor = ColorTranslator.FromHtml("#32324E");
                        lbJumlah.BackColor = ColorTranslator.FromHtml("#32324E");
                        btnPlus.BackColor = ColorTranslator.FromHtml("#32324E");
                        btnMinus.BackColor = ColorTranslator.FromHtml("#32324E");

                        lbNama.ForeColor = Color.White;
                        lbQty.ForeColor = Color.White;
                        lbHarga.ForeColor = Color.White;
                        lbJumlah.ForeColor = Color.White;

                        lbNama.Font = new Font("Arial", 19, FontStyle.Regular);
                        lbQty.Font = new Font("Arial", 19, FontStyle.Regular);
                        lbHarga.Font = new Font("Arial", 19, FontStyle.Regular);
                        lbJumlah.Font = new Font("Arial", 19, FontStyle.Regular);

                        lbNama.Location = new Point(9,15);
                        lbQty.Location = new Point(9, 44);
                        lbHarga.Location = new Point(9, 73);
                        lbJumlah.Location = new Point(263, 72);
                        btnPlus.Location = new Point(296, 75);
                        btnMinus.Location = new Point(229, 75);

                        lbNama.Size = new Size(356, 121);
                        lbQty.Size = new Size(313, 32);
                        lbHarga.Size = new Size(133, 32);
                        lbJumlah.Size = new Size(39, 42);
                        btnPlus.Size = new Size(32, 32);
                        btnMinus.Size = new Size(32, 32);

                        lbNama.Text = dtBarang.Rows[jmlMenu]["Nama Barang"].ToString();
                        lbQty.Text = "QTY : "+dtBarang.Rows[jmlMenu]["QTY"].ToString();
                        lbHarga.Text = dtBarang.Rows[jmlMenu]["Harga Jual"].ToString();
                        lbJumlah.Text = "0";

                        btnPlus.Image = Properties.Resources.logoPlus;
                        btnMinus.Image = Properties.Resources.logoMinus;

                        btnPlus.FlatAppearance.BorderSize = 0;
                        btnPlus.FlatStyle = FlatStyle.Flat;
                        btnMinus.FlatAppearance.BorderSize = 0;
                        btnMinus.FlatStyle = FlatStyle.Flat;
                        btnMinus.Cursor = Cursors.Hand;
                        btnPlus.Cursor = Cursors.Hand;

                        btnPlus.Click += new EventHandler( btnPlus_Click);
                        btnMinus.Click += new EventHandler(BtnMinus_Click);

                        lbNama.Name = Convert.ToString(jmlMenu);
                        lbQty.Name = Convert.ToString(jmlMenu);
                        lbHarga.Name = Convert.ToString(jmlMenu);
                        lbJumlah.Name = Convert.ToString(jmlMenu);
                        btnPlus.Name = Convert.ToString(jmlMenu);
                        btnMinus.Name = Convert.ToString(jmlMenu);

                        //mappingPlus[btnPlus] = lbJumlah;
                        //mappingMinus[btnMinus] = lbJumlah;
                    }
                    jmlMenu++;
                }
                Y += 162;
            }
            /*
            for (int i =0;i< dtBarang.Rows.Count;i++)
            {
                if (dtBarang.Rows[jmlMenu]["QTY"].ToString() != "0" && dtBarang.Rows.Count > 0)
                {
                    menu = new PictureBox();
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
                    //Label[] lbNama = new Label[jumlahBarang];
                    //Label[] lbQty = new Label[jumlahBarang];
                    //Label[] lbHarga = new Label[jumlahBarang];
                    //Label[] lbJumlah = new Label[jumlahBarang];
                    //Button[] btnMinus = new Button[jumlahBarang];
                    //Button[] btnPlus = new Button[jumlahBarang];

                    lbNama[jmlMenu] = new System.Windows.Forms.Label();
                    lbQty[jmlMenu] = new System.Windows.Forms.Label();
                    lbHarga[jmlMenu] = new System.Windows.Forms.Label();
                    lbJumlah[jmlMenu] = new System.Windows.Forms.Label();
                    btnMinus[jmlMenu] = new System.Windows.Forms.Button();
                    btnPlus[jmlMenu] = new System.Windows.Forms.Button();

                    menu.Controls.Add(btnMinus[jmlMenu]);
                    menu.Controls.Add(btnPlus[jmlMenu]);
                    menu.Controls.Add(lbJumlah[jmlMenu]);
                    menu.Controls.Add(lbHarga[jmlMenu]);
                    menu.Controls.Add(lbQty[jmlMenu]);
                    menu.Controls.Add(lbNama[jmlMenu]);
                    //menu.Controls.Add(lbQty);
                    //menu.Controls.Add(lbHarga);
                    //menu.Controls.Add(lbJumlah);
                    //menu.Controls.Add(btnPlus);
                    //menu.Controls.Add(btnMinus);

                    lbNama[jmlMenu].BackColor = ColorTranslator.FromHtml("#32324E");
                    lbQty[jmlMenu].BackColor = ColorTranslator.FromHtml("#32324E");
                    lbHarga[jmlMenu].BackColor = ColorTranslator.FromHtml("#32324E");
                    lbJumlah[jmlMenu].BackColor = ColorTranslator.FromHtml("#32324E");

                    lbNama[jmlMenu].ForeColor = Color.White;
                    lbQty[jmlMenu].ForeColor = Color.White;
                    lbHarga[jmlMenu].ForeColor = Color.White;
                    lbJumlah[jmlMenu].ForeColor = Color.White;

                    lbNama[jmlMenu].Font = new Font("Arial", 20, FontStyle.Regular);
                    lbQty[jmlMenu].Font = new Font("Arial", 20, FontStyle.Regular);
                    lbHarga[jmlMenu].Font = new Font("Arial", 20, FontStyle.Regular);
                    lbJumlah[jmlMenu].Font = new Font("Arial", 20, FontStyle.Regular);

                    lbNama[jmlMenu].Location = new Point(9, 15);
                    lbQty[jmlMenu].Location = new Point(9, 44);
                    lbHarga[jmlMenu].Location = new Point(9, 73);
                    lbJumlah[jmlMenu].Location = new Point(272, 72);
                    btnPlus[jmlMenu].Location = new Point(305, 75);
                    btnMinus[jmlMenu].Location = new Point(238, 75);

                    lbNama[jmlMenu].Size = new Size(356, 121);
                    lbQty[jmlMenu].Size = new Size(313, 32);
                    lbHarga[jmlMenu].Size = new Size(133, 32);
                    lbJumlah[jmlMenu].Size = new Size(39, 42);
                    btnPlus[jmlMenu].Size = new Size(32, 32);
                    btnMinus[jmlMenu].Size = new Size(32, 32);

                    lbNama[jmlMenu].Text = dtBarang.Rows[i]["Nama Barang"].ToString();
                    lbQty[jmlMenu].Text = "QTY : " + dtBarang.Rows[i]["QTY"].ToString();
                    lbHarga[jmlMenu].Text = dtBarang.Rows[i]["Harga Jual"].ToString();
                    lbJumlah[jmlMenu].Text = "0";

                    btnPlus[jmlMenu].Image = Properties.Resources.logoPlus;
                    btnMinus[jmlMenu].Image = Properties.Resources.logoMinus;
                    btnPlus[jmlMenu].BackColor = ColorTranslator.FromHtml("#32324E");
                    btnMinus[jmlMenu].BackColor = ColorTranslator.FromHtml("#32324E");

                    btnPlus[jmlMenu].FlatAppearance.BorderSize = 0;
                    btnPlus[jmlMenu].FlatStyle = FlatStyle.Flat;
                    btnMinus[jmlMenu].FlatAppearance.BorderSize = 0;
                    btnMinus[jmlMenu].FlatStyle = FlatStyle.Flat;
                    btnMinus[jmlMenu].Cursor = Cursors.Hand;
                    btnPlus[jmlMenu].Cursor = Cursors.Hand;

                    btnPlus[jmlMenu].Click += btnPlus_Click;
                    btnMinus[jmlMenu].Click += BtnMinus_Click;
                    Y += 162;
                }
                jmlMenu++;
            }*/
        }

        private void BtnMinus_Click(object sender, EventArgs e)
        {
           for (int i = 0; i < dtBarang.Rows.Count; i++)
            {
                if (lbJumlah.Name == ((Button)sender).Name)
                {
                    lbJumlah.Text = "1";
                }
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            //lbJumlah[jmlMenu] = new System.Windows.Forms.Label();
            //lbJumlah[jmlMenu].Text = Convert.ToString(int.Parse(lbJumlah[jmlMenu].Text) + 1);
            MessageBox.Show(((System.Windows.Forms.Button)sender).Name + " clicked");
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
            menu.Dispose();
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
            {
                //sqlCommand = new MySqlCommand("insert into BARANG_PENJUALAN() values('"+lbIDJual.Text+"',''," + lbIDJual.Text.Replace(",", "").Trim(new char[] { '.', 'R', 'p', ' ', ',' }) + ",'N')", sqlConnect);
                //sqlCommand.ExecuteNonQuery();
            }
            sqlConnect.Close();
        }
    }
}
