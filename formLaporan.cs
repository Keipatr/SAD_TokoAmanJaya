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
    public partial class formLaporan : Form
    {
        public formLaporan()
        {
            InitializeComponent();
        }

        public static string sqlConnection = "server=139.255.11.84;uid=student;pwd=isbmantap;database=SAD_TokoAmanJaya";
        public MySqlConnection sqlConnect = new MySqlConnection(sqlConnection);
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;
        public string sqlQuery;
        public int jumlah;

        public DataTable dtBarang;

        bool isChecked = false;

        public void loadTable()
        {
            try
            {
                sqlConnect.Open();
                DataTable dtBarang = new DataTable();
                sqlQuery = "select * from v_history_barang";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtBarang);
                dgvInven.DataSource = dtBarang;
                sqlConnect.Close();
                jumlah = dtBarang.Rows.Count;
            }
            catch (Exception ex)
            {

            }

            //dgvInven.Columns[1].DefaultCellStyle.Format = "yyyy-MM-dd";
               
            //DataGridViewColumn no = dgvInven.Columns[0];
            //no.Width = 80;
            //DataGridViewColumn tanggalUkur = dgvInven.Columns[1];
            //tanggalUkur.Width = 210;
            //DataGridViewColumn idUkurs = dgvInven.Columns[2];
            //idUkurs.Width = 190;
            //DataGridViewColumn namaUkur = dgvInven.Columns[3];
            //namaUkur.Width = 420;
            //DataGridViewColumn plusUkur = dgvInven.Columns[4];
            //plusUkur.Width = 110;
            //DataGridViewColumn minusUkur = dgvInven.Columns[5];
            //minusUkur.Width = 110;
            //dgvInven.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dgvInven.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dgvInven.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //for (int i = 4; i <= 6; i++)
            //    dgvInven.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        public void loadDesign()
        {
            this.BackColor = ColorTranslator.FromHtml("#E4EFFF");

            paneldgvSearch.BackColor = ColorTranslator.FromHtml("#FFC814");
            dgvInven.BackgroundColor = ColorTranslator.FromHtml("#FFC814");
            dgvInven.GridColor = Color.Black; //ColorTranslator.FromHtml("#FFC814");
            dgvInven.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#FFC814");
            dgvInven.EnableHeadersVisualStyles = false;
            dgvInven.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#FF9900");
            this.dgvInven.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            this.dgvInven.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            this.dgvInven.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvInven.RowHeadersVisible = false;

            lbLogo.ForeColor = ColorTranslator.FromHtml("#FFC814");

            dtpAwal.CustomFormat = " ";
            dtpAkhir.CustomFormat = " ";
            dtpAwal.SkinColor = ColorTranslator.FromHtml("#979BC7");
            dtpAkhir.SkinColor = ColorTranslator.FromHtml("#979BC7");

            rbBeli.UnCheckedColor = ColorTranslator.FromHtml("#979BC7");
            rbJual.UnCheckedColor = ColorTranslator.FromHtml("#979BC7");
            rbBeli.BackColor = ColorTranslator.FromHtml("#E4EFFF");
            rbJual.BackColor = ColorTranslator.FromHtml("#E4EFFF");


        }
        private void formMenu_Load(object sender, EventArgs e)
        {
            loadDesign();

            loadTable();
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            formMenu formMenu = new formMenu();
            formMenu.ShowDialog();
            this.Close();
        }

        private void pbBack_MouseHover(object sender, EventArgs e)
        {
            pbTxtBack.Visible = true;
        }

        private void pbBack_MouseLeave(object sender, EventArgs e)
        {
            pbTxtBack.Visible= false;
        }
        
            
        private void dtpAwal_ValueChanged(object sender, EventArgs e)
        {
            dtpAwal.CustomFormat = "dd MMMM yyyy";
            if (rbBeli.Checked == true)
            {
                sqlConnect.Open();
                DataTable dtBarang = new DataTable();
                sqlQuery = "select * from v_history_barang where keterangan = 'Pembelian' and Tanggal between '" + dtpAwal.Value.ToString("yyyy-MM-dd") + "' and '" + dtpAkhir.Value.ToString("yyyy-MM-dd") + "';";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtBarang);
                dgvInven.DataSource = dtBarang;
                sqlConnect.Close();
            }
            else if (rbJual.Checked == true)
            {
                sqlConnect.Open();
                DataTable dtBarang = new DataTable();
                sqlQuery = "select * from v_history_barang where keterangan = 'PENJUALAN' and Tanggal between '" + dtpAwal.Value.ToString("yyyy-MM-dd") + "' and '" + dtpAkhir.Value.ToString("yyyy-MM-dd") + "';";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtBarang);
                dgvInven.DataSource = dtBarang;
                sqlConnect.Close();
            }

        }

        private void dtpAkhir_ValueChanged(object sender, EventArgs e)
        {
            dtpAkhir.CustomFormat = "dd MMMM yyyy";
            if (rbBeli.Checked == true)
            {
                sqlConnect.Open();
                DataTable dtBarang = new DataTable();
                sqlQuery = "select * from v_history_barang where keterangan = 'Pembelian' and Tanggal between '" + dtpAwal.Value.ToString("yyyy-MM-dd") + "' and '" + dtpAkhir.Value.ToString("yyyy-MM-dd") + "';";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtBarang);
                dgvInven.DataSource = dtBarang;
                sqlConnect.Close();
            }
            else if (rbJual.Checked == true)
            {
                sqlConnect.Open();
                DataTable dtBarang = new DataTable();
                sqlQuery = "select * from v_history_barang where keterangan = 'PENJUALAN' and Tanggal between '" + dtpAwal.Value.ToString("yyyy-MM-dd") + "' and '" + dtpAkhir.Value.ToString("yyyy-MM-dd") + "';";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtBarang);
                dgvInven.DataSource = dtBarang;
                sqlConnect.Close();
            }
            else
            {
                sqlConnect.Open();
                DataTable dtBarang = new DataTable();
                sqlQuery = "select * from v_history_barang where Tanggal between '" + dtpAwal.Value.ToString("yyyy-MM-dd") + "' and '" + dtpAkhir.Value.ToString("yyyy-MM-dd") + "';";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtBarang);
                dgvInven.DataSource = dtBarang;
                sqlConnect.Close();
            }
        }

        private void rbJual_CheckedChanged(object sender, EventArgs e)
        {
            isChecked = rbJual.Checked;
            sqlConnect.Open();
            DataTable dtBarang = new DataTable();
            sqlQuery = "select * from v_history_barang where keterangan = 'PENJUALAN' and Tanggal between '"+dtpAwal.Value.ToString("yyyy-MM-dd") +"' and '"+dtpAkhir.Value.ToString("yyyy-MM-dd") +"';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtBarang);
            dgvInven.DataSource = dtBarang;
            sqlConnect.Close();
            if (rbBeli.Checked == false && rbJual.Checked == false)
            {
                sqlConnect.Open();
                dtBarang = new DataTable();
                sqlQuery = "select * from v_history_barang where Tanggal between '" + dtpAwal.Value.ToString("yyyy-MM-dd") + "' and '" + dtpAkhir.Value.ToString("yyyy-MM-dd") + "';";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtBarang);
                dgvInven.DataSource = dtBarang;
                sqlConnect.Close();
            }
            else if (dtpAwal.CustomFormat == " " && dtpAkhir.CustomFormat == " ")
            {
                if (rbJual.Checked == true)
                {
                    sqlConnect.Open();
                    dtBarang = new DataTable();
                    sqlQuery = "select * from v_history_barang where keterangan = 'PENJUALAN';";
                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    sqlAdapter = new MySqlDataAdapter(sqlCommand);
                    sqlAdapter.Fill(dtBarang);
                    dgvInven.DataSource = dtBarang;
                    sqlConnect.Close();
                }
                else if (rbBeli.Checked == true)
                {
                    sqlConnect.Open();
                    dtBarang = new DataTable();
                    sqlQuery = "select * from v_history_barang where keterangan = 'PEMBELIAN';";
                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    sqlAdapter = new MySqlDataAdapter(sqlCommand);
                    sqlAdapter.Fill(dtBarang);
                    dgvInven.DataSource = dtBarang;
                    sqlConnect.Close();
                }
                else if (rbBeli.Checked == false && rbJual.Checked == false)
                {
                    sqlConnect.Open();
                    dtBarang = new DataTable();
                    sqlQuery = "select * from v_history_barang";
                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    sqlAdapter = new MySqlDataAdapter(sqlCommand);
                    sqlAdapter.Fill(dtBarang);
                    dgvInven.DataSource = dtBarang;
                    sqlConnect.Close();
                }
            }
        }

        private void rbBeli_CheckedChanged(object sender, EventArgs e)
        {
            isChecked = rbBeli.Checked;
            sqlConnect.Open();
                DataTable dtBarang = new DataTable();
                sqlQuery = "select * from v_history_barang where keterangan = 'Pembelian' and Tanggal between '" + dtpAwal.Value.ToString("yyyy-MM-dd") + "' and '" + dtpAkhir.Value.ToString("yyyy-MM-dd") + "';";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtBarang);
                dgvInven.DataSource = dtBarang;
                sqlConnect.Close();

            if (rbBeli.Checked == false && rbJual.Checked == false)
            {
                sqlConnect.Open();
                dtBarang = new DataTable();
                sqlQuery = "select * from v_history_barang where Tanggal between '" + dtpAwal.Value.ToString("yyyy-MM-dd") + "' and '" + dtpAkhir.Value.ToString("yyyy-MM-dd") + "';";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtBarang);
                dgvInven.DataSource = dtBarang;
                sqlConnect.Close();
            }
            else if (dtpAwal.CustomFormat == " " && dtpAkhir.CustomFormat == " ")
            {
                if (rbJual.Checked == true)
                {
                    sqlConnect.Open();
                    dtBarang = new DataTable();
                    sqlQuery = "select * from v_history_barang where keterangan = 'PENJUALAN';";
                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    sqlAdapter = new MySqlDataAdapter(sqlCommand);
                    sqlAdapter.Fill(dtBarang);
                    dgvInven.DataSource = dtBarang;
                    sqlConnect.Close();
                }
                else if (rbBeli.Checked == true)
                {
                    sqlConnect.Open();
                    dtBarang = new DataTable();
                    sqlQuery = "select * from v_history_barang where keterangan = 'PEMBELIAN';";
                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    sqlAdapter = new MySqlDataAdapter(sqlCommand);
                    sqlAdapter.Fill(dtBarang);
                    dgvInven.DataSource = dtBarang;
                    sqlConnect.Close();
                }
                else if (rbBeli.Checked == false && rbJual.Checked == false)
                {
                    sqlConnect.Open();
                    dtBarang = new DataTable();
                    sqlQuery = "select * from v_history_barang";
                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    sqlAdapter = new MySqlDataAdapter(sqlCommand);
                    sqlAdapter.Fill(dtBarang);
                    dgvInven.DataSource = dtBarang;
                    sqlConnect.Close();
                }
            }
        }

        private void rbJual_Click(object sender, EventArgs e)
        {
            if (rbJual.Checked && !isChecked)
                rbJual.Checked = false;
            else
            {
                rbJual.Checked = true;
                isChecked = false;
            }
            if (rbBeli.Checked == false && rbJual.Checked == false && dtpAwal.CustomFormat == " " && dtpAkhir.CustomFormat == " ")
            {
                sqlConnect.Open();
                DataTable dtBarang = new DataTable();
                sqlQuery = "select * from v_history_barang;";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtBarang);
                dgvInven.DataSource = dtBarang;
                sqlConnect.Close();
            }
        }

        private void rbBeli_Click(object sender, EventArgs e)
        {
            if(rbBeli.Checked && !isChecked)
                rbBeli.Checked = false;
            else
            {
                rbBeli.Checked = true;
                isChecked = false;
            }
            if (rbBeli.Checked == false && rbJual.Checked == false && dtpAwal.CustomFormat == " " && dtpAkhir.CustomFormat == " ")
            {
                sqlConnect.Open();
                DataTable dtBarang = new DataTable();
                sqlQuery = "select * from v_history_barang;";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtBarang);
                dgvInven.DataSource = dtBarang;
                sqlConnect.Close();
            }
        }
    }
}
