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
using System.Drawing.Text;

namespace POSTOKOAMANJAYA
{
    public partial class formPenjualan : Form
    {
        public formPenjualan()
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
            this.BackColor = ColorTranslator.FromHtml("#E4EFFF");
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile("Properties.Resources.Mukta_Regular");
            label1.Font = new Font(pfc.Families[0],40);

        }
    }
}
