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
    public partial class formInventory : Form
    {
        public formInventory()
        {
            InitializeComponent();
        }

        public static string sqlConnection = "server=139.255.11.84;uid=student;pwd=isbmantap;database=SAD_TokoAmanJaya";
        public MySqlConnection sqlConnect = new MySqlConnection(sqlConnection);
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;
        public string sqlQuery;

        public static string idBarang = "";
        public static string namaBarang = "";
        public static string jumlahBarang ="";
        public static string hargaBeli = "";
        public static string hargaJual = "";

        public void loadTable()
        {
            sqlConnect.Open();
            DataTable dtBarang = new DataTable();
            sqlCommand = new MySqlCommand("pSearchBarang", sqlConnect);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("cekNama", tbSearch.Text);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtBarang);
            dgvInven.DataSource = dtBarang;

            sqlConnect.Close();

            DataGridViewColumn no = dgvInven.Columns[0];
            no.Width = 60;
            DataGridViewColumn idUkur = dgvInven.Columns[1];
            idUkur.Width = 180;
            DataGridViewColumn namaUkur = dgvInven.Columns[2];
            namaUkur.Width = 350;
            dgvInven.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvInven.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            for (int i = 3;i<=5;i++)
                dgvInven.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            idBarang = dgvInven.CurrentRow.Cells["ID Barang"].Value.ToString();
            namaBarang = dgvInven.CurrentRow.Cells["Nama Barang"].Value.ToString();
            jumlahBarang = dgvInven.CurrentRow.Cells["QTY"].Value.ToString();
            hargaBeli = dgvInven.CurrentRow.Cells["Harga Beli"].Value.ToString();
            hargaJual = dgvInven.CurrentRow.Cells["Harga Jual"].Value.ToString();
        }
        public void loadDesign()
        {
            this.BackColor = ColorTranslator.FromHtml("#E4EFFF");
            tbSearchs.BackColor = ColorTranslator.FromHtml("#FFC814");
            tbSearchs.BorderColor = ColorTranslator.FromHtml("#FFC814");
            tbSearchs.BorderFocusColor = ColorTranslator.FromHtml("#FFC814");
            tbSearchs.Enabled = false;
            tbSearch.BackColor = ColorTranslator.FromHtml("#FFC814");

            pbSearch.BackColor = ColorTranslator.FromHtml("#FFC814");
            paneldgvSearch.BackColor = ColorTranslator.FromHtml("#FFC814");
            dgvInven.BackgroundColor = ColorTranslator.FromHtml("#FFC814");
            dgvInven.GridColor = ColorTranslator.FromHtml("#FFC814");
            dgvInven.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#FFC814");
            dgvInven.EnableHeadersVisualStyles = false;
            dgvInven.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#FF9900");
            dgvInven.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvInven.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvInven.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvInven.RowHeadersVisible = false;

            //pbTxtAdd.BackColor = ColorTranslator.FromHtml("#0E2A4E");
            //pbTxtBack.BackColor = ColorTranslator.FromHtml("#0E2A4E");
            //pbTxtEdit.BackColor = ColorTranslator.FromHtml("#0E2A4E");

            lbLogo.ForeColor = ColorTranslator.FromHtml("#FFC814");
            btnMinim.BackColor = ColorTranslator.FromHtml("#F40000");
        }
        private void formMenu_Load(object sender, EventArgs e)
        {
            loadDesign();

            loadTable();
        }

        private void pbSearch_Click(object sender, EventArgs e)
        {
            tbSearch.Select();
        }

        private void dgvInven_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow selectedRow = dgvInven.Rows[index];
                tbSearch.Text = selectedRow.Cells[2].Value.ToString();

                idBarang = selectedRow.Cells["ID Barang"].Value.ToString();
                namaBarang = selectedRow.Cells["Nama Barang"].Value.ToString();
                jumlahBarang = selectedRow.Cells["QTY"].Value.ToString();
                hargaBeli = selectedRow.Cells["Harga Beli"].Value.ToString();
                hargaJual = selectedRow.Cells["Harga Jual"].Value.ToString();
            }
            catch (Exception ex)
            {

            }
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            formMenu formMenu = new formMenu();
            formMenu.ShowDialog();
            this.Close();
        }

        private void pbEdit_Click(object sender, EventArgs e)
        {
            formEditBarang formEditBarang = new formEditBarang();
            formEditBarang.ShowDialog();
        }

        private void pbAdd_Click(object sender, EventArgs e)
        {
            formAdd formAdd = new formAdd();
            formAdd.ShowDialog();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            loadTable();
        }

        private void dgvInven_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow selectedRow = dgvInven.Rows[index];
                tbSearch.Text = selectedRow.Cells[2].Value.ToString();

                idBarang = selectedRow.Cells["ID Barang"].Value.ToString();
                namaBarang = selectedRow.Cells["Nama Barang"].Value.ToString();
                jumlahBarang = selectedRow.Cells["QTY"].Value.ToString();
                hargaBeli = selectedRow.Cells["Harga Beli"].Value.ToString();
                hargaJual = selectedRow.Cells["Harga Jual"].Value.ToString();
            }
            catch (Exception ex)
            {

            }
        }

        private void pbEdit_MouseHover(object sender, EventArgs e)
        {
            pbTxtEdit.Visible = true;
        }

        private void pbEdit_MouseLeave(object sender, EventArgs e)
        {
            pbTxtEdit.Visible = false;
        }

        private void pbBack_MouseHover(object sender, EventArgs e)
        {
            pbTxtBack.Visible = true;
        }

        private void pbBack_MouseLeave(object sender, EventArgs e)
        {
            pbTxtBack.Visible= false;
        }

        private void pbAdd_MouseHover(object sender, EventArgs e)
        {
            pbTxtAdd.Visible = true;
        }

        private void pbAdd_MouseLeave(object sender, EventArgs e)
        {
            pbTxtAdd.Visible = false;
        }
    }
}
