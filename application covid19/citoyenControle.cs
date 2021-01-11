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
    public partial class citoyenControle : UserControl
    {

        String Gender;
        public citoyenControle()
        {
            InitializeComponent();
        }
        private bool isValid()
        {
            if (cin.Text == string.Empty)
            {
                MessageBox.Show("Il faut ajouter la CIN", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void citoyenControle_Load(object sender, EventArgs e)
        {

        }



        
        private void enregistrer_Click(object sender, EventArgs e)
        {
            if (isValid()) {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3ILBI45\SQLEXPRESS;Initial Catalog=covid19;Integrated Security=True;");
                con.Open();
                SqlCommand command = new SqlCommand("insert into Citoyen values ('" + cin.Text + "','" + nom.Text + "','" + prenom.Text + "','" + Gender + "','" + age.Text + "','" + zone.Text + "','" + maladie.Text + "')", con);

                command.ExecuteNonQuery();
                MessageBox.Show("les données sont ajoutés avec succés", "Application Covid", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                con.Close();
            }
            
        }

        private void homme_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Homme";

        }

        private void femme_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Femme";
        }
        public void clearData(Control.ControlCollection cc)
        {
            foreach(Control ctrl in cc)
            {
                TextBox tb = ctrl as TextBox;
                if (tb!=null)
                {
                    tb.Text = null;
                }
                ComboBox cb = ctrl as ComboBox;
                if (cb != null)
                {
                    cb.ResetText();
                    cb.Text = null;
                }
                RichTextBox rtxtbox = ctrl as RichTextBox;
                if ( rtxtbox != null)
                {
                    rtxtbox.Clear();
                }
                if (ctrl is RadioButton)
                {
                    RadioButton rb = ctrl as RadioButton;
                    if (rb.Checked == true)
                    {
                        rb.Checked = false;
                    }
                }

            }
        }

        private void reinitialiser_Click(object sender, EventArgs e)
        {
            clearData(this.Controls);
            
        }


    }
}
