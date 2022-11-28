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

        public static string sqlConnection = "server=139.255.11.84;uid=student;pwd=isbmantap;database=SAD_TokoAmanJaya";
        public MySqlConnection sqlConnect = new MySqlConnection(sqlConnection);
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;
        public string sqlQuery;

        
        private void formMenu_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#191A38");
            tbBeli.BackColor = ColorTranslator.FromHtml("#979BC7");
            tbJual.BackColor = ColorTranslator.FromHtml("#979BC7");
            tbQty.BackColor = ColorTranslator.FromHtml("#979BC7");
            tbNama.BackColor = ColorTranslator.FromHtml("#979BC7");
            btnSave.BackColor = ColorTranslator.FromHtml("#979BC7");
            btnCancel.BackColor = ColorTranslator.FromHtml("#F40000");

            tbNama.BorderColor = ColorTranslator.FromHtml("#979BC7");
            tbJual.BorderColor = ColorTranslator.FromHtml("#979BC7");
            tbQty.BorderColor = ColorTranslator.FromHtml("#979BC7");
            tbBeli.BorderColor = ColorTranslator.FromHtml("#979BC7");
            tbNama.BorderFocusColor = ColorTranslator.FromHtml("#979BC7");
            tbJual.BorderFocusColor = ColorTranslator.FromHtml("#979BC7");
            tbBeli.BorderFocusColor = ColorTranslator.FromHtml("#979BC7");
            tbQty.BorderFocusColor = ColorTranslator.FromHtml("#979BC7");


            tbBeli.Texts = formInventory.hargaBeli; 
            tbJual.Texts = formInventory.hargaJual.ToString();
            tbNama.Texts = formInventory.namaBarang.ToString();
            tbQty.Texts = formInventory.jumlahBarang.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
               this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnect.Open();
                sqlCommand = new MySqlCommand("update BARANG set nama_barang = '" + tbNama.Texts + "', stok_barang = '" + tbQty.Texts + "', harga_beli = '" + tbBeli.Texts.Replace(",", "").Trim(new char[] { '.', 'R', 'p', ' ', ',' }) + "', harga_jual = '" + tbJual.Texts.Replace(",", "").Trim(new char[] { '.', 'R', 'p', ' ', ',' }) + "' where id_barang = '" + formInventory.idBarang + "';", sqlConnect);
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!");
            }
            this.Hide();
            formDoneEdit formDoneEdit = new formDoneEdit();
            formDoneEdit.ShowDialog();
            this.Close();
        }

        private void tbQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
