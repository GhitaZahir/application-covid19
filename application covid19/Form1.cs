using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace application_covid19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            citoyen.BringToFront();
        }


        private void citoyen_Click(object sender, EventArgs e)
        {
            testControle1.Hide();
            hospitalisationControle1.Hide();
            vaccinControle1.Hide();
            carteControle1.Hide();
            listeControle1.Hide();
            citoyenControle1.Show();
            citoyen.BringToFront();
        }

        private void test_Click(object sender, EventArgs e)
        {
            citoyenControle1.Hide();
            hospitalisationControle1.Hide();
            vaccinControle1.Hide();
            carteControle1.Hide();
            listeControle1.Hide();
            testControle1.Show();
            testControle1.BringToFront();
        }

        private void close_Click(object sender, EventArgs e)
        {
            DialogResult iExit;

            iExit = MessageBox.Show("Confirmez si vous voulez vraiment annuler", "Application Covid", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (iExit == DialogResult.Yes){
                    Application.Exit();
            }
          
        }

        private void hospitalisation_Click(object sender, EventArgs e)
        {
            testControle1.Hide();
            citoyenControle1.Hide();
            vaccinControle1.Hide();
            carteControle1.Hide();
            listeControle1.Hide();
            hospitalisationControle1.Show();
            hospitalisationControle1.BringToFront();
        }

        private void vaccin_Click(object sender, EventArgs e)
        {
            testControle1.Hide();
            citoyenControle1.Hide();
            hospitalisationControle1.Hide();
            carteControle1.Hide();
            listeControle1.Hide();
            vaccinControle1.Show();
            vaccinControle1.BringToFront();
        }

        private void carte_Click(object sender, EventArgs e)
        {
            testControle1.Hide();
            citoyenControle1.Hide();
            hospitalisationControle1.Hide();
            vaccinControle1.Hide();
            listeControle1.Hide();
            carteControle1.Show();
            carteControle1.BringToFront();
        }

        private void liste_Click(object sender, EventArgs e)
        {
            testControle1.Hide();
            citoyenControle1.Hide();
            hospitalisationControle1.Hide();
            vaccinControle1.Hide();
            carteControle1.Hide();
            listeControle1.Show();
            listeControle1.BringToFront();
        }
    }
}
