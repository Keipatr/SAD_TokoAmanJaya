﻿using System;
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
    public partial class formPembelianAdd : Form
    {
        public formPembelianAdd()
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
            tbQty.BackColor = ColorTranslator.FromHtml("#979BC7");
            tbNama.BackColor = ColorTranslator.FromHtml("#979BC7");
            btnSave.BackColor = ColorTranslator.FromHtml("#979BC7");
            btnCancel.BackColor = ColorTranslator.FromHtml("#F40000");

            tbNama.BorderColor = ColorTranslator.FromHtml("#979BC7");
            tbQty.BorderColor = ColorTranslator.FromHtml("#979BC7");
            tbBeli.BorderColor = ColorTranslator.FromHtml("#979BC7");
            tbNama.BorderFocusColor = ColorTranslator.FromHtml("#979BC7");
            tbBeli.BorderFocusColor = ColorTranslator.FromHtml("#979BC7");
            tbQty.BorderFocusColor = ColorTranslator.FromHtml("#979BC7");


            tbBeli.Texts = formPembelian.hbeli;
            tbNama.Texts = formPembelian.nama;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
               this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbNama.Texts.Replace(",", "").Trim(new char[] { '.', 'R', 'p', ' ', ',' }) != formPembelian.hbeli.Replace(",", "").Trim(new char[] { '.', 'R', 'p', ' ', ',' }))
            {
                sqlConnect.Open();                
                sqlCommand = new MySqlCommand("update BARANG set harga_beli = '"+ tbBeli.Texts.Replace(",", "").Trim(new char[] { '.', 'R', 'p', ' ', ',' }) + "' where id_barang = '"+formPembelian.id+"';", sqlConnect);
                sqlCommand.ExecuteNonQuery();
            }
            DataTable notaIsi = new DataTable();
            notaIsi.Columns.Add("id");
            notaIsi.Columns.Add("nama");
            notaIsi.Columns.Add("jumlah");
            notaIsi.Columns.Add("harga");

            this.Close();
        }

        private void tbQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tbNama_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) || !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) || !char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }
    }
}
