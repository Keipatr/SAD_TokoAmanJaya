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
    public partial class formAdd : Form
    {
        public formAdd()
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
            btnSave.BackColor = ColorTranslator.FromHtml("#FFC814");
            btnSave.ForeColor = Color.Black;
            btnCancel.BackColor = ColorTranslator.FromHtml("#979BC7");
            cbKategori.BackColor = ColorTranslator.FromHtml("#979BC7");
            cbKategori.ListBackColor = ColorTranslator.FromHtml("#979BC7");
            cbKategori.IconColor = ColorTranslator.FromHtml("#000000");

            tbNama.BorderColor = ColorTranslator.FromHtml("#979BC7");
            tbJual.BorderColor = ColorTranslator.FromHtml("#979BC7");
            tbQty.BorderColor = ColorTranslator.FromHtml("#979BC7");
            tbBeli.BorderColor = ColorTranslator.FromHtml("#979BC7");
            tbNama.BorderFocusColor = ColorTranslator.FromHtml("#979BC7");
            tbJual.BorderFocusColor = ColorTranslator.FromHtml("#979BC7");
            tbBeli.BorderFocusColor = ColorTranslator.FromHtml("#979BC7");
            tbQty.BorderFocusColor = ColorTranslator.FromHtml("#979BC7");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
               this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cbKategori.Texts == "Pilih Kategori" || tbNama.Texts == "" || tbQty.Texts == "" || tbBeli.Texts == "" || tbJual.Texts == "" )
            {
                Form formBackground = new Form();
                try
                {
                    using (formSalah uu = new formSalah())
                    {
                        formBackground.StartPosition = FormStartPosition.Manual;
                        formBackground.FormBorderStyle = FormBorderStyle.None;
                        formBackground.Opacity = .30d;
                        formBackground.BackColor = Color.Gray;
                        formBackground.WindowState = FormWindowState.Maximized;
                        formBackground.TopMost = true;
                        formBackground.Location = this.Location;
                        formBackground.ShowInTaskbar = false;
                        formBackground.Show();

                        uu.Owner = formBackground;
                        uu.ShowDialog();

                        formBackground.Dispose();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    formBackground.Dispose();
                }
            }
            else
            {
                try
                {
                    sqlConnect.Open();
                    sqlCommand = new MySqlCommand("insert into BARANG() values('', '" + tbNama.Texts + "', '" + cbKategori.Texts + "', '" + tbBeli.Texts.Replace(",", "").Trim(new char[] { '.', 'R', 'p', ' ', ',' }) + "', '" + tbJual.Texts.Replace(",", "").Trim(new char[] { '.', 'R', 'p', ' ', ',' }) + "', '" + tbQty.Texts + "', '1', 'N');", sqlConnect);
                    sqlCommand.ExecuteNonQuery();
                    sqlConnect.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR!");
                }
                this.Hide();
                Form formBackground = new Form();
                try
                {
                    using (formDoneAdd uu = new formDoneAdd())
                    {
                        formBackground.StartPosition = FormStartPosition.Manual;
                        formBackground.FormBorderStyle = FormBorderStyle.None;
                        formBackground.Opacity = .30d;
                        formBackground.BackColor = Color.Gray;
                        formBackground.WindowState = FormWindowState.Maximized;
                        formBackground.TopMost = true;
                        formBackground.Location = this.Location;
                        formBackground.ShowInTaskbar = false;
                        formBackground.Show();

                        uu.Owner = formBackground;
                        uu.ShowDialog();

                        formBackground.Dispose();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    formBackground.Dispose();
                }
                this.Close();

            }
        }

        private void tbQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tbBeli_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tbJual_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
