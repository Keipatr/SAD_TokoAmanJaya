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
    public partial class formHistory : Form
    {
        public formHistory()
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
            }
            catch (Exception ex)
            {

            }
            //DataGridViewColumn no = dgvInven.Columns[0];
            //no.Width = 60;
            //DataGridViewColumn idUkur = dgvInven.Columns[1];
            //idUkur.Width = 180;
            //DataGridViewColumn namaUkur = dgvInven.Columns[2];
            //namaUkur.Width = 350;
            //dgvInven.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dgvInven.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //for (int i = 3;i<=5;i++)
            //    dgvInven.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        public void loadDesign()
        {
            this.BackColor = ColorTranslator.FromHtml("#E4EFFF");

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

            lbLogo.ForeColor = ColorTranslator.FromHtml("#FFC814");

            dtpAwal.CustomFormat = " ";
            dtpAkhir.CustomFormat = " ";
            dtpAwal.SkinColor = ColorTranslator.FromHtml("#979BC7");
            dtpAkhir.SkinColor = ColorTranslator.FromHtml("#979BC7");

            rbBeli.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#979BC7");
            rbJual.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#979BC7");
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
        }

        private void dtpAkhir_ValueChanged(object sender, EventArgs e)
        {
            dtpAkhir.CustomFormat = "dd MMMM yyyy";
        }
    }
}
