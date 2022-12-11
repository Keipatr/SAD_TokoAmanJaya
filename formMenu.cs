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
    public partial class formMenu : Form
    {
        public formMenu()
        {
            InitializeComponent();
        }

        public static string sqlConnection = "server=localhost;uid=root;pwd=; database=premier_league";
        public MySqlConnection sqlConnect = new MySqlConnection(sqlConnection);
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;
        public string sqlQuery;
        private void formMenu_Load(object sender, EventArgs e)
        {
            btnHistory.BackColor = Color.Red;
            btnHistory.BorderColor = Color.Red;
            btnHistory.Cursor = Cursors.Hand;

            btnLaporan.BackColor = Color.Red;
            btnLaporan.BorderColor = Color.Red;
            btnLaporan.Cursor = Cursors.Hand;

            btnInven.BackColor = Color.Red;
            btnInven.BorderColor = Color.Red;
            btnInven.Cursor = Cursors.Hand;

            btnPenjualan.BackColor = Color.Red;
            btnPenjualan.BorderColor = Color.Red;
            btnPenjualan.Cursor = Cursors.Hand;

            btnPembelian.BackColor = Color.Red;
            btnPembelian.BorderColor = Color.Red;
            btnPembelian.Cursor = Cursors.Hand;
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            this.Hide();
            formHistory formHistory = new formHistory();
            formHistory.ShowDialog();
            this.Close();
        }

        private void btnLaporan_Click(object sender, EventArgs e)
        {
            this.Hide();
            formLaporan formLaporan = new formLaporan();
            formLaporan.ShowDialog();
            this.Close();
        }

        private void btnInven_Click(object sender, EventArgs e)
        {
            this.Hide();
            formInventory formInventory = new formInventory();
            formInventory.ShowDialog();
            this.Close();
        }

        private void btnPembelian_Click(object sender, EventArgs e)
        {
            this.Hide();
            formPembelian formPembelian = new formPembelian();
            formPembelian.ShowDialog();
            this.Close();
        }

        private void btnPenjualan_Click(object sender, EventArgs e)
        {
            this.Hide();
            formPenjualan formPenjualan = new formPenjualan();
            formPenjualan.ShowDialog();
            this.Close();
        }
    }
}
