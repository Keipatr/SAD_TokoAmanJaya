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
    public partial class formEditBarang : Form
    {
        public formEditBarang()
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
            this.BackColor = ColorTranslator.FromHtml("#191A38");
            tbHargaBeli.BackColor = ColorTranslator.FromHtml("#979BC7");
            tbHargaJual.BackColor = ColorTranslator.FromHtml("#979BC7");
            tbJumlah.BackColor = ColorTranslator.FromHtml("#979BC7");
            tbNamaBarang.BackColor = ColorTranslator.FromHtml("#979BC7");
            btnSave.BackColor = ColorTranslator.FromHtml("#979BC7");
            btnCancel.BackColor = ColorTranslator.FromHtml("#F40000");

            tbNamaBarang.Text = formInventory.namaBarang;
            tbJumlah.Text = formInventory.jumlahBarang.ToString();
            tbHargaJual.Text = formInventory.hargaJual.ToString();
            tbHargaBeli.Text = formInventory.hargaBeli.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
               this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            sqlCommand = new MySqlCommand("pEditBarang", sqlConnect);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("parID", formInventory.idBarang);
            sqlCommand.Parameters.AddWithValue("parNama", tbNamaBarang.Text);
            sqlCommand.Parameters.AddWithValue("parBeli", tbHargaBeli);
            sqlCommand.Parameters.AddWithValue("parJual", tbHargaJual);
            sqlCommand.Parameters.AddWithValue("parStok", tbJumlah);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
        }
    }
}
