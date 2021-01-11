using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace application_covid19
{
    public partial class listeControle : UserControl
    {
        public listeControle()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3ILBI45\SQLEXPRESS;Initial Catalog=covid19;Integrated Security=True;");
        

        private void afficher1_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            label1.Hide();
            afficher1.Hide();
            BringData1();
        }

        void BringData1()
        {
            SqlCommand command = new SqlCommand("select * from Citoyen", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataCitoyen.DataSource = dt;
        }

      
    }
}
