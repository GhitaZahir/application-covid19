using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlServerCe;

namespace application_covid19
{
    public partial class carteControle : UserControl
    {
        string color;
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3ILBI45\SQLEXPRESS;Initial Catalog=covid19;Integrated Security=True;");
        public carteControle()
        {
            InitializeComponent();
        }

        private void cin_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            SqlCommand command = new SqlCommand("SELECT * FROM Citoyen where cin1 = '" + cin.Text + "'", con);
            con.Open();
            
            

        }

        private void imprimer_Click(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }
    }
}
