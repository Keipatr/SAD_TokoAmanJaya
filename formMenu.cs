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


        private void pbInven_Click(object sender, EventArgs e)
        {
            this.Hide();
            formInventory formInventory = new formInventory();
            formInventory.ShowDialog();
            this.Close();
        }

        private void pbJual_Click(object sender, EventArgs e)
        {
            this.Hide();
            formPenjualan formPenjualan = new formPenjualan();
            formPenjualan.ShowDialog();
            this.Close();
        }

        private void pbBeli_Click(object sender, EventArgs e)
        {

        }

        private void pbLaporan_Click(object sender, EventArgs e)
        {

        }

        private void pbHistory_Click(object sender, EventArgs e)
        {

        }

    }
}
