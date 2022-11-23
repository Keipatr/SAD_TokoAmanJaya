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

            dgvInven.BackgroundColor = ColorTranslator.FromHtml("#FFC814");
            dgvInven.GridColor = ColorTranslator.FromHtml("#FFC814");
            dgvInven.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#FFC814");
            dgvInven.EnableHeadersVisualStyles = false;
            dgvInven.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#FF9900");
            dgvInven.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvInven.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvInven.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvInven.RowHeadersVisible = false;
        }
        private void formMenu_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#E4EFFF");
            tbSearch.BackColor = ColorTranslator.FromHtml("#FFC814");
            panelSearch.BackColor = ColorTranslator.FromHtml("#FFC814");
            paneldgvSearch.BackColor = ColorTranslator.FromHtml("#FFC814");

            loadTable();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            //if (tbSearch.Text != "")
            //{
            //    pbSearch.Visible = false;
            //}
            //else
            //{
            //    pbSearch.Visible = true;
            //}
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
            }
            catch (Exception ex)
            {

            }
        }
    }
}
