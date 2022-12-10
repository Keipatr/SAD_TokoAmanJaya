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
    public partial class formLaporan : Form
    {
        public formLaporan()
        {
            InitializeComponent();
        }

        public static string sqlConnection = "server=139.255.11.84;uid=student;pwd=isbmantap;database=SAD_TokoAmanJaya";
        public MySqlConnection sqlConnect = new MySqlConnection(sqlConnection);
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;
        public string sqlQuery;
        public int jumlah;
        public int sum = 0;

        public DataTable dtBarang;
        

        public void loadTable()
        {
            
                sqlConnect.Open();
                dtBarang = new DataTable();
                sqlQuery = "select row_number() over (order by nj.TANGGAL_PENJUALAN) as No, nj.TANGGAL_PENJUALAN as 'Tanggal',nj.ID_NOTAPENJUALAN as 'ID Nota',  b.ID_BARANG as 'ID Barang', b.NAMA_BARANG as 'Nama Barang', bj.jml_jual as 'QTY', concat('Rp',format((bj.JML_JUAL * bj.HARGA_JUAL),0)) as 'Jumlah' from NOTA_PENJUALAN nj, BARANG_PENJUALAN bj, BARANG b where bj.ID_BARANG = b.ID_BARANG and nj.ID_NOTAPENJUALAN = bj.ID_NOTAPENJUALAN and substring(nj.ID_NOTAPENJUALAN,1,1) = 'J';";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtBarang);
                sqlConnect.Close();
                dgvInven.DataSource = dtBarang;

                if (dtBarang.Columns.Count > 0)
                {
                    if (dtBarang.Rows.Count > 0)
                    {
                        for (int i = 0; i < dtBarang.Rows.Count; i++)
                        {
                            sum += int.Parse(dtBarang.Rows[i]["Jumlah"].ToString().Replace(",", "").Replace(".", "").Trim(new char[] { '.', 'R', 'p', ' ', ',' }));
                        }
                        DataRow row = dtBarang.NewRow();
                        row[3] = "TOTAL";
                        row[4] = "PEMASUKAN";
                        row[6] = "Rp" + sum.ToString("#,#").Replace(".", ",");
                        dtBarang.Rows.Add(row);
                    }
                    dgvInven.Columns.Cast<DataGridViewColumn>().ToList().ForEach(f => f.SortMode = DataGridViewColumnSortMode.NotSortable);


                    dgvInven.Columns[1].DefaultCellStyle.Format = "yyyy-MM-dd";

                    DataGridViewColumn no = dgvInven.Columns[0];
                    no.Width = 60;
                    DataGridViewColumn tanggalUkur = dgvInven.Columns[1];
                    tanggalUkur.Width = 170;
                    DataGridViewColumn idUkurs = dgvInven.Columns[2];
                    idUkurs.Width = 150;
                    DataGridViewColumn namaUkur = dgvInven.Columns[3];
                    namaUkur.Width = 150;
                    DataGridViewColumn plusUkur = dgvInven.Columns[4];
                    plusUkur.Width = 400;
                    DataGridViewColumn minusUkur = dgvInven.Columns[5];
                    minusUkur.Width = 70;
                    DataGridViewColumn jmlUkur = dgvInven.Columns[6];
                    jmlUkur.Width = 200;
                    dgvInven.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dgvInven.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dgvInven.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dgvInven.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dgvInven.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
        }
        
        public void loadDesign()
        {
            this.BackColor = ColorTranslator.FromHtml("#E4EFFF");

            paneldgvSearch.BackColor = ColorTranslator.FromHtml("#FFC814");
            dgvInven.BackgroundColor = ColorTranslator.FromHtml("#FFC814");
            dgvInven.GridColor = Color.Black; //ColorTranslator.FromHtml("#FFC814");
            dgvInven.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#FFC814");
            dgvInven.EnableHeadersVisualStyles = false;
            dgvInven.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#FF9900");
            this.dgvInven.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            this.dgvInven.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            this.dgvInven.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvInven.RowHeadersVisible = false;

            lbLogo.ForeColor = ColorTranslator.FromHtml("#FFC814");

            dtpAwal.CustomFormat = " ";
            dtpAkhir.CustomFormat = " ";
            dtpAwal.SkinColor = ColorTranslator.FromHtml("#979BC7");
            dtpAkhir.SkinColor = ColorTranslator.FromHtml("#979BC7");

            rbBeli.UnCheckedColor = ColorTranslator.FromHtml("#979BC7");
            rbJual.UnCheckedColor = ColorTranslator.FromHtml("#979BC7");
            rbBeli.BackColor = ColorTranslator.FromHtml("#E4EFFF");
            rbJual.BackColor = ColorTranslator.FromHtml("#E4EFFF");

            this.dgvInven.DefaultCellStyle.SelectionBackColor = this.dgvInven.DefaultCellStyle.BackColor;
            this.dgvInven.DefaultCellStyle.SelectionForeColor = this.dgvInven.DefaultCellStyle.ForeColor;
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


            if (rbBeli.Checked == true)
            {
                sum = 0;
                sqlConnect.Open();
                 dtBarang = new DataTable();
                sqlQuery = "pLaporanPembelian";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("parTglStart", dtpAwal.Value.ToString("yyyy-MM-dd"));
                sqlCommand.Parameters.AddWithValue("parTglEnd", dtpAkhir.Value.ToString("yyyy-MM-dd"));
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtBarang);
                dgvInven.DataSource = dtBarang;
                sqlConnect.Close();

                if (dtBarang.Rows.Count > 0)
                {
                    for (int i = 0; i < dtBarang.Rows.Count; i++)
                    {
                        sum += int.Parse(dtBarang.Rows[i]["Jumlah"].ToString().Replace(",", "").Replace(".", "").Trim(new char[] { '.', 'R', 'p', ' ', ',' }));
                    }
                    DataRow row = dtBarang.NewRow();
                    row[3] = "TOTAL";
                    row[4] = "PENGELUARAN";
                    row[6] = "Rp" + sum.ToString("#,#").Replace(".", ",");
                    dtBarang.Rows.Add(row);
                }
            }
            else if (rbJual.Checked == true)
            {
                sum = 0;
                sqlConnect.Open();
                dtBarang = new DataTable();
                sqlQuery = "pLaporanPenjualan";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("parTglStart", dtpAwal.Value.ToString("yyyy-MM-dd"));
                sqlCommand.Parameters.AddWithValue("parTglEnd", dtpAkhir.Value.ToString("yyyy-MM-dd"));
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtBarang);
                dgvInven.DataSource = dtBarang;
                sqlConnect.Close();

                if (dtBarang.Rows.Count > 0)
                {
                    for (int i = 0; i < dtBarang.Rows.Count; i++)
                    {
                        sum += int.Parse(dtBarang.Rows[i]["Jumlah"].ToString().Replace(",", "").Replace(".", "").Trim(new char[] { '.', 'R', 'p', ' ', ',' }));
                    }
                    DataRow row = dtBarang.NewRow();
                    row[3] = "TOTAL";
                    row[4] = "PEMASUKAN";
                    row[6] = "Rp" + sum.ToString("#,#").Replace(".", ",");
                    dtBarang.Rows.Add(row);
                }
            }
        }

        private void dtpAkhir_ValueChanged(object sender, EventArgs e)
        {
            dtpAkhir.CustomFormat = "dd MMMM yyyy";


            if (rbBeli.Checked == true)
            {
                sum = 0;
                sqlConnect.Open();
                dtBarang = new DataTable();
                sqlQuery = "pLaporanPembelian";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("parTglStart", dtpAwal.Value.ToString("yyyy-MM-dd"));
                sqlCommand.Parameters.AddWithValue("parTglEnd", dtpAkhir.Value.ToString("yyyy-MM-dd"));
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtBarang);
                dgvInven.DataSource = dtBarang;
                sqlConnect.Close();

                if (dtBarang.Rows.Count > 0)
                {
                    for (int i = 0; i < dtBarang.Rows.Count; i++)
                    {
                        sum += int.Parse(dtBarang.Rows[i]["Jumlah"].ToString().Replace(",", "").Replace(".", "").Trim(new char[] { '.', 'R', 'p', ' ', ',' }));
                    }
                    DataRow row = dtBarang.NewRow();
                    row[3] = "TOTAL";
                    row[4] = "PENGELUARAN";
                    row[6] = "Rp" + sum.ToString("#,#").Replace(".", ",");
                    dtBarang.Rows.Add(row);
                }
            }
            else if (rbJual.Checked == true)
            {
                sum = 0;
                sqlConnect.Open();
                dtBarang = new DataTable();
                sqlQuery = "pLaporanPenjualan";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("parTglStart", dtpAwal.Value.ToString("yyyy-MM-dd"));
                sqlCommand.Parameters.AddWithValue("parTglEnd", dtpAkhir.Value.ToString("yyyy-MM-dd"));
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtBarang);
                dgvInven.DataSource = dtBarang;
                sqlConnect.Close();

                if (dtBarang.Rows.Count > 0)
                {
                    for (int i = 0; i < dtBarang.Rows.Count; i++)
                    {
                        sum += int.Parse(dtBarang.Rows[i]["Jumlah"].ToString().Replace(",", "").Replace(".", "").Trim(new char[] { '.', 'R', 'p', ' ', ',' }));
                    }
                    DataRow row = dtBarang.NewRow();
                    row[3] = "TOTAL";
                    row[4] = "PEMASUKAN";
                    row[6] = "Rp" + sum.ToString("#,#").Replace(".", ",");
                    dtBarang.Rows.Add(row);
                }
            }
        }

        private void rbJual_CheckedChanged(object sender, EventArgs e)
        {
            if (rbJual.Checked == true && dtpAwal.CustomFormat ==" " && dtpAkhir.CustomFormat == " ")
            {
                sum = 0;
                sqlConnect.Open();
                dtBarang = new DataTable();
                sqlQuery = "select row_number() over (order by nj.TANGGAL_PENJUALAN) as No, nj.TANGGAL_PENJUALAN as 'Tanggal',nj.ID_NOTAPENJUALAN as 'ID Nota',  b.ID_BARANG as 'ID Barang', b.NAMA_BARANG as 'Nama Barang', bj.jml_jual as 'QTY', concat('Rp',format((bj.JML_JUAL * bj.HARGA_JUAL),0)) as 'Jumlah' from NOTA_PENJUALAN nj, BARANG_PENJUALAN bj, BARANG b where bj.ID_BARANG = b.ID_BARANG and nj.ID_NOTAPENJUALAN = bj.ID_NOTAPENJUALAN and substring(nj.ID_NOTAPENJUALAN,1,1) = 'J';";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtBarang);
                sqlConnect.Close();
                dgvInven.DataSource = dtBarang;

                if (dtBarang.Rows.Count > 0)
                {
                    for (int i = 0; i < dtBarang.Rows.Count; i++)
                    {
                        sum += int.Parse(dtBarang.Rows[i]["Jumlah"].ToString().Replace(",", "").Replace(".", "").Trim(new char[] { '.', 'R', 'p', ' ', ',' }));
                    }
                    DataRow row = dtBarang.NewRow();
                    row[3] = "TOTAL";
                    row[4] = "PEMASUKAN";
                    row[6] = "Rp" + sum.ToString("#,#").Replace(".", ",");
                    dtBarang.Rows.Add(row);
                }
            }
            else if (rbBeli.Checked == true && dtpAwal.CustomFormat == " " && dtpAkhir.CustomFormat == " ")
            {
                sum = 0;
                sqlConnect.Open();
                dtBarang = new DataTable();
                sqlQuery = "select row_number() over (order by nb.TANGGAL_PEMBELIAN) as No,  nb.TANGGAL_PEMBELIAN as 'Tanggal',  nb.ID_NOTAPEMBELIAN as 'ID Nota',  b.ID_BARANG as 'ID Barang',  b.NAMA_BARANG as 'Nama Barang',  bb.JML_BELI as 'QTY', concat('Rp ',format((bb.JML_BELI * bb.HARGA_BELI),0)) as 'Jumlah' from NOTA_PEMBELIAN nb, BARANG_PEMBELIAN bb, BARANG b where bb.ID_BARANG = b.ID_BARANG and nb.ID_NOTAPEMBELIAN = bb.ID_NOTAPEMBELIAN and substring(nb.ID_NOTAPEMBELIAN,1,1) = 'B';";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtBarang);
                sqlConnect.Close();
                dgvInven.DataSource = dtBarang;

                if (dtBarang.Rows.Count > 0)
                {
                    for (int i = 0; i < dtBarang.Rows.Count; i++)
                    {
                        sum += int.Parse(dtBarang.Rows[i]["Jumlah"].ToString().Replace(",", "").Replace(".", "").Trim(new char[] { '.', 'R', 'p', ' ', ',' }));
                    }
                    DataRow row = dtBarang.NewRow();
                    row[3] = "TOTAL";
                    row[4] = "PENGELUARAN";
                    row[6] = "Rp" + sum.ToString("#,#").Replace(".", ",");
                    dtBarang.Rows.Add(row);
                }
            }
            else if (rbBeli.Checked == true && (dtpAwal.CustomFormat != " " || dtpAkhir.CustomFormat != " "))
            {
                sum = 0;
                sqlConnect.Open();
                dtBarang = new DataTable();
                sqlQuery = "pLaporanPembelian";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("parTglStart", dtpAwal.Value.ToString("yyyy-MM-dd"));
                sqlCommand.Parameters.AddWithValue("parTglEnd", dtpAkhir.Value.ToString("yyyy-MM-dd"));
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtBarang);
                dgvInven.DataSource = dtBarang;
                sqlConnect.Close();

                if (dtBarang.Rows.Count > 0)
                {
                    for (int i = 0; i < dtBarang.Rows.Count; i++)
                    {
                        sum += int.Parse(dtBarang.Rows[i]["Jumlah"].ToString().Replace(",", "").Replace(".", "").Trim(new char[] { '.', 'R', 'p', ' ', ',' }));
                    }
                    DataRow row = dtBarang.NewRow();
                    row[3] = "TOTAL";
                    row[4] = "PENGELUARAN";
                    row[6] = "Rp" + sum.ToString("#,#").Replace(".", ",");
                    dtBarang.Rows.Add(row);
                }
            }
            else if (rbJual.Checked == true && (dtpAwal.CustomFormat != " " || dtpAkhir.CustomFormat != " "))
            {
                sum = 0;
                sqlConnect.Open();
                dtBarang = new DataTable();
                sqlQuery = "pLaporanPenjualan";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("parTglStart", dtpAwal.Value.ToString("yyyy-MM-dd"));
                sqlCommand.Parameters.AddWithValue("parTglEnd", dtpAkhir.Value.ToString("yyyy-MM-dd"));
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtBarang);
                dgvInven.DataSource = dtBarang;
                sqlConnect.Close();

                if (dtBarang.Rows.Count > 0)
                {
                    for (int i = 0; i < dtBarang.Rows.Count; i++)
                    {
                        sum += int.Parse(dtBarang.Rows[i]["Jumlah"].ToString().Replace(",", "").Replace(".", "").Trim(new char[] { '.', 'R', 'p', ' ', ',' }));
                    }
                    DataRow row = dtBarang.NewRow();
                    row[3] = "TOTAL";
                    row[4] = "PEMASUKAN";
                    row[6] = "Rp" + sum.ToString("#,#").Replace(".", ",");
                    dtBarang.Rows.Add(row);
                }
            }
        }

        private void rbBeli_CheckedChanged(object sender, EventArgs e)
        {
            if (rbJual.Checked == true && dtpAwal.CustomFormat == " " && dtpAkhir.CustomFormat == " ")
            {
                sum = 0;
                sqlConnect.Open();
                dtBarang = new DataTable();
                sqlQuery = "select row_number() over (order by nj.TANGGAL_PENJUALAN) as No, nj.TANGGAL_PENJUALAN as 'Tanggal',nj.ID_NOTAPENJUALAN as 'ID Nota',  b.ID_BARANG as 'ID Barang', b.NAMA_BARANG as 'Nama Barang', bj.jml_jual as 'QTY', concat('Rp',format((bj.JML_JUAL * bj.HARGA_JUAL),0)) as 'Jumlah' from NOTA_PENJUALAN nj, BARANG_PENJUALAN bj, BARANG b where bj.ID_BARANG = b.ID_BARANG and nj.ID_NOTAPENJUALAN = bj.ID_NOTAPENJUALAN and substring(nj.ID_NOTAPENJUALAN,1,1) = 'J';";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtBarang);
                sqlConnect.Close();
                dgvInven.DataSource = dtBarang;

                if (dtBarang.Rows.Count > 0)
                {
                    for (int i = 0; i < dtBarang.Rows.Count; i++)
                    {
                        sum += int.Parse(dtBarang.Rows[i]["Jumlah"].ToString().Replace(",", "").Replace(".", "").Trim(new char[] { '.', 'R', 'p', ' ', ',' }));
                    }
                    DataRow row = dtBarang.NewRow();
                    row[3] = "TOTAL";
                    row[4] = "PEMASUKAN";
                    row[6] = "Rp" + sum.ToString("#,#").Replace(".", ",");
                    dtBarang.Rows.Add(row);
                }
            }
            else if (rbBeli.Checked == true && dtpAwal.CustomFormat == " " && dtpAkhir.CustomFormat == " ")
            {
                sum = 0;
                sqlConnect.Open();
                dtBarang = new DataTable();
                sqlQuery = "select row_number() over (order by nb.TANGGAL_PEMBELIAN) as No,  nb.TANGGAL_PEMBELIAN as 'Tanggal',  nb.ID_NOTAPEMBELIAN as 'ID Nota',  b.ID_BARANG as 'ID Barang',  b.NAMA_BARANG as 'Nama Barang',  bb.JML_BELI as 'QTY', concat('Rp ',format((bb.JML_BELI * bb.HARGA_BELI),0)) as 'Jumlah' from NOTA_PEMBELIAN nb, BARANG_PEMBELIAN bb, BARANG b where bb.ID_BARANG = b.ID_BARANG and nb.ID_NOTAPEMBELIAN = bb.ID_NOTAPEMBELIAN and substring(nb.ID_NOTAPEMBELIAN,1,1) = 'B';";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtBarang);
                sqlConnect.Close();
                dgvInven.DataSource = dtBarang;

                if (dtBarang.Rows.Count > 0)
                {
                    for (int i = 0; i < dtBarang.Rows.Count; i++)
                    {
                        sum += int.Parse(dtBarang.Rows[i]["Jumlah"].ToString().Replace(",", "").Replace(".", "").Trim(new char[] { '.', 'R', 'p', ' ', ',' }));
                    }
                    DataRow row = dtBarang.NewRow();
                    row[3] = "TOTAL";
                    row[4] = "PENGELUARAN";
                    row[6] = "Rp" + sum.ToString("#,#").Replace(".", ",");
                    dtBarang.Rows.Add(row);
                }
            }
            else if (rbBeli.Checked == true && (dtpAwal.CustomFormat != " " || dtpAkhir.CustomFormat != " "))
            {
                sum = 0;
                sqlConnect.Open();
                dtBarang = new DataTable();
                sqlQuery = "pLaporanPembelian";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("parTglStart", dtpAwal.Value.ToString("yyyy-MM-dd"));
                sqlCommand.Parameters.AddWithValue("parTglEnd", dtpAkhir.Value.ToString("yyyy-MM-dd"));
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtBarang);
                dgvInven.DataSource = dtBarang;
                sqlConnect.Close();

                if (dtBarang.Rows.Count > 0)
                {
                    for (int i = 0; i < dtBarang.Rows.Count; i++)
                    {
                        sum += int.Parse(dtBarang.Rows[i]["Jumlah"].ToString().Replace(",", "").Replace(".", "").Trim(new char[] { '.', 'R', 'p', ' ', ',' }));
                    }
                    DataRow row = dtBarang.NewRow();
                    row[3] = "TOTAL";
                    row[4] = "PENGELUARAN";
                    row[6] = "Rp" + sum.ToString("#,#").Replace(".", ",");
                    dtBarang.Rows.Add(row);
                }
            }
            else if (rbJual.Checked == true && (dtpAwal.CustomFormat != " " || dtpAkhir.CustomFormat != " "))
            {
                sum = 0;
                sqlConnect.Open();
                dtBarang = new DataTable();
                sqlQuery = "pLaporanPenjualan";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("parTglStart", dtpAwal.Value.ToString("yyyy-MM-dd"));
                sqlCommand.Parameters.AddWithValue("parTglEnd", dtpAkhir.Value.ToString("yyyy-MM-dd"));
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtBarang);
                dgvInven.DataSource = dtBarang;
                sqlConnect.Close();

                if (dtBarang.Rows.Count > 0)
                {
                    for (int i = 0; i < dtBarang.Rows.Count; i++)
                    {
                        sum += int.Parse(dtBarang.Rows[i]["Jumlah"].ToString().Replace(",", "").Replace(".", "").Trim(new char[] { '.', 'R', 'p', ' ', ',' }));
                    }
                    DataRow row = dtBarang.NewRow();
                    row[3] = "TOTAL";
                    row[4] = "PEMASUKAN";
                    row[6] = "Rp" + sum.ToString("#,#").Replace(".", ",");
                    dtBarang.Rows.Add(row);
                }
            }
            
        }

        private void dgvInven_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (dtBarang.Rows.Count >0)
            {
                if (e.ColumnIndex == 0 && e.RowIndex == dtBarang.Rows.Count - 1)
                {
                    e.AdvancedBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.None;
                    e.CellStyle.BackColor = ColorTranslator.FromHtml("#FF9900");
                    e.CellStyle.SelectionBackColor = ColorTranslator.FromHtml("#FF9900");
                    e.CellStyle.SelectionForeColor = this.dgvInven.DefaultCellStyle.ForeColor;
                }
                if (e.ColumnIndex == 1 && e.RowIndex == dtBarang.Rows.Count - 1)
                {
                    e.AdvancedBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.None;
                    e.CellStyle.BackColor = ColorTranslator.FromHtml("#FF9900");
                    e.CellStyle.SelectionBackColor = ColorTranslator.FromHtml("#FF9900");
                    e.CellStyle.SelectionForeColor = this.dgvInven.DefaultCellStyle.ForeColor;
                }
                if (e.ColumnIndex == 2 && e.RowIndex == dtBarang.Rows.Count - 1)
                {
                    e.AdvancedBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.None;
                    e.CellStyle.BackColor = ColorTranslator.FromHtml("#FF9900");
                    e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    e.CellStyle.Font = new Font(dgvInven.DefaultCellStyle.Font, FontStyle.Bold);
                    e.CellStyle.SelectionBackColor = ColorTranslator.FromHtml("#FF9900");
                    e.CellStyle.SelectionForeColor = this.dgvInven.DefaultCellStyle.ForeColor;
                }
                if (e.ColumnIndex == 3 && e.RowIndex == dtBarang.Rows.Count - 1)
                {
                    e.AdvancedBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.None;
                    e.CellStyle.BackColor = ColorTranslator.FromHtml("#FF9900");

                    e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    e.CellStyle.Font = new Font(dgvInven.DefaultCellStyle.Font, FontStyle.Bold);
                    e.CellStyle.SelectionBackColor = ColorTranslator.FromHtml("#FF9900");
                    e.CellStyle.SelectionForeColor = this.dgvInven.DefaultCellStyle.ForeColor;
                }
                if (e.ColumnIndex == 4 && e.RowIndex == dtBarang.Rows.Count - 1)
                {
                    e.AdvancedBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.None;
                    e.CellStyle.BackColor = ColorTranslator.FromHtml("#FF9900");

                    e.CellStyle.SelectionBackColor = ColorTranslator.FromHtml("#FF9900");
                    e.CellStyle.SelectionForeColor = this.dgvInven.DefaultCellStyle.ForeColor;
                    e.CellStyle.Font = new Font(dgvInven.DefaultCellStyle.Font, FontStyle.Bold);
                }
                if (e.ColumnIndex == 5 && e.RowIndex == dtBarang.Rows.Count - 1)
                {
                    e.CellStyle.BackColor = ColorTranslator.FromHtml("#FF9900");
                    e.CellStyle.SelectionBackColor = ColorTranslator.FromHtml("#FF9900");
                    e.CellStyle.SelectionForeColor = this.dgvInven.DefaultCellStyle.ForeColor;
                }
                if (e.ColumnIndex == 6 && e.RowIndex == dtBarang.Rows.Count - 1)
                {
                    e.CellStyle.BackColor = ColorTranslator.FromHtml("#FF9900");
                    e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    e.CellStyle.Font = new Font(dgvInven.DefaultCellStyle.Font, FontStyle.Bold);
                    e.CellStyle.SelectionBackColor = ColorTranslator.FromHtml("#FF9900");
                    e.CellStyle.SelectionForeColor = this.dgvInven.DefaultCellStyle.ForeColor;
                }
            }
        }
    }
}
