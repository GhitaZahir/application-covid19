using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlServerCe;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace application_covid19
{
    
    public partial class carteForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3ILBI45\SQLEXPRESS;Initial Catalog=covid19;Integrated Security=True;");
       

        public carteForm()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            DialogResult Exit;

            Exit = MessageBox.Show("Confirmez si vous voulez vraiment annuler", "Application Covid", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (Exit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        Bitmap bmp;
        private void imprimer(object sender, EventArgs e)
        {
            if (isValid()) { 
                Graphics g = this.CreateGraphics();
                bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
                Graphics mg = Graphics.FromImage(bmp);
                mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
                printPreviewDialog1.ShowDialog();
            }

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            

            e.Graphics.DrawImage(bmp, 25, 25, bmp.Width,bmp.Height);
        }

        private void cin1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCeConnection con = new SqlCeConnection(@"Data Source=DESKTOP-3ILBI45\SQLEXPRESS;Initial Catalog=covid19;Integrated Security=True;");
            SqlCeCommand command = new SqlCeCommand("SELECT * FROM Citoyen where CIN ='" + cin1.Text + "'", con);
            con.Open();
            command.ExecuteNonQuery();
            SqlCeDataReader dr;
            dr = command.ExecuteReader();
            while (dr.Read())
            {
               
                string nom = (string)dr["Nom"].ToString();
                nom1.Text = nom;
                string prenom = (string)dr["Prénom"].ToString();
                prenom1.Text = prenom;
                string zone = (string)dr["Zone"].ToString();
                zone1.Text = zone;

            }
            con.Close();
        }

        private bool isValid()
        {
            if (vert.CheckState == CheckState.Unchecked && jaune.CheckState == CheckState.Unchecked && orange.CheckState == CheckState.Unchecked && rouge.CheckState == CheckState.Unchecked)
            {
                MessageBox.Show("Veuillez selectioner le Code Couleur !! ", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }else if(etat1.SelectedIndex==-1){
                MessageBox.Show("Veuillez selectioner l'état !! ", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void imprimer_Click_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                Graphics g = this.CreateGraphics();
                bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
                Graphics mg = Graphics.FromImage(bmp);
                mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.ShowDialog();
                
            }
        }

        private void carteForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
