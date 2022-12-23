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
    public partial class formPenjualanAdd : Form
    {
        public formPenjualanAdd()
        {
            InitializeComponent();
        }

        public static string sqlConnection = "server=139.255.11.84;uid=student;pwd=isbmantap;database=SAD_TokoAmanJaya";
        public MySqlConnection sqlConnect = new MySqlConnection(sqlConnection);
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;
        public string sqlQuery; 
        public static DataTable notaIsi = new DataTable();
        private void formMenu_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#191A38");
            tbQty.BackColor = ColorTranslator.FromHtml("#979BC7");
            tbNama.BackColor = ColorTranslator.FromHtml("#979BC7");
            btnSave.BackColor = ColorTranslator.FromHtml("#FFC814");
            btnSave.ForeColor = Color.Black;
            btnCancel.BackColor = ColorTranslator.FromHtml("#979BC7");

            tbNama.BorderColor = ColorTranslator.FromHtml("#979BC7");
            tbQty.BorderColor = ColorTranslator.FromHtml("#979BC7");
            tbNama.BorderFocusColor = ColorTranslator.FromHtml("#979BC7");
            tbQty.BorderFocusColor = ColorTranslator.FromHtml("#979BC7");


            tbNama.Texts = formPenjualan.nama;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
               this.Close();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (int.Parse(tbQty.Texts) <= int.Parse(formPenjualan.dtBarang.Rows[formPenjualan.cek]["QTY"].ToString()))
            {

                if (formPenjualan.cekBuatDT == 0)
                {
                    notaIsi.Columns.Add("id");
                    notaIsi.Columns.Add("nama");
                    notaIsi.Columns.Add("jumlah");
                    notaIsi.Columns.Add("harga");
                    notaIsi.PrimaryKey = new DataColumn[] { notaIsi.Columns["id"] };
                    formPenjualan.cekBuatDT = 1;
                }
                if (notaIsi.Rows.Find(formPenjualan.id) != null)
                {
                    DataRow row = notaIsi.AsEnumerable().SingleOrDefault(r => r.Field<string>("id") == formPenjualan.id);
                    row["jumlah"] = Convert.ToString(Convert.ToInt32(row["jumlah"]) + Convert.ToInt32(tbQty.Texts));
                }
                else
                {
                    notaIsi.Rows.Add(formPenjualan.id, tbNama.Texts, tbQty.Texts, "Rp. " + Convert.ToInt32(formPenjualan.hjual.Replace(",", "").Replace(".", "").Trim(new char[] { '.', 'R', 'p', ' ', ',' })).ToString("#,#"));
                }
                this.Close();

            }
        }

        private void tbQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tbNama_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) || !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) || !char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
        
    }
}
