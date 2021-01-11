﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace application_covid19
{
    public partial class vaccinControle : UserControl
    {
        string vaccination;
        public vaccinControle()
        {
            InitializeComponent();
        }

        private void enregistrer_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3ILBI45\SQLEXPRESS;Initial Catalog=covid19;Integrated Security=True;");
            con.Open();
            SqlCommand command = new SqlCommand("insert into Vaccin values ('" + vaccination + "','" + cause.Text + "')", con);

            command.ExecuteNonQuery();
            MessageBox.Show("les données sont ajoutés avec succés", "Application Covid", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            con.Close();
        }

        private void oui_CheckedChanged(object sender, EventArgs e)
        {
            vaccination = "oui";

        }

        private void non_CheckedChanged(object sender, EventArgs e)
        {
            vaccination = "non";
        }
        public void clearData(Control.ControlCollection cc)
        {
            foreach (Control ctrl in cc)
            {
                TextBox tb = ctrl as TextBox;
                if (tb != null)
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
                if (rtxtbox != null)
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
