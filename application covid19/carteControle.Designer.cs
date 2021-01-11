namespace application_covid19
{
    partial class carteControle
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(carteControle));
            this.cin = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nCarte = new System.Windows.Forms.TextBox();
            this.vert = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.reinitialiser = new System.Windows.Forms.Button();
            this.imprimer = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.rouge = new System.Windows.Forms.RadioButton();
            this.orangeF = new System.Windows.Forms.RadioButton();
            this.orange = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // cin
            // 
            this.cin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cin.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cin.ForeColor = System.Drawing.Color.Black;
            this.cin.FormattingEnabled = true;
            this.cin.Location = new System.Drawing.Point(191, 82);
            this.cin.Name = "cin";
            this.cin.Size = new System.Drawing.Size(169, 26);
            this.cin.TabIndex = 4;
            this.cin.SelectedIndexChanged += new System.EventHandler(this.cin_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Traitement donné :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(18, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Durée de traitement:";
            // 
            // nCarte
            // 
            this.nCarte.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nCarte.Location = new System.Drawing.Point(191, 27);
            this.nCarte.Name = "nCarte";
            this.nCarte.Size = new System.Drawing.Size(169, 26);
            this.nCarte.TabIndex = 5;
            // 
            // vert
            // 
            this.vert.AutoSize = true;
            this.vert.BackColor = System.Drawing.Color.Green;
            this.vert.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.vert.ForeColor = System.Drawing.Color.White;
            this.vert.Location = new System.Drawing.Point(191, 136);
            this.vert.Name = "vert";
            this.vert.Size = new System.Drawing.Size(167, 23);
            this.vert.TabIndex = 2;
            this.vert.TabStop = true;
            this.vert.Text = "                                   ";
            this.vert.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(22, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "N° Carte :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(22, 82);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "CIN :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(393, -294);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // reinitialiser
            // 
            this.reinitialiser.BackColor = System.Drawing.Color.Transparent;
            this.reinitialiser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("reinitialiser.BackgroundImage")));
            this.reinitialiser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reinitialiser.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.reinitialiser.ForeColor = System.Drawing.Color.White;
            this.reinitialiser.Location = new System.Drawing.Point(321, 430);
            this.reinitialiser.Name = "reinitialiser";
            this.reinitialiser.Size = new System.Drawing.Size(120, 47);
            this.reinitialiser.TabIndex = 5;
            this.reinitialiser.Text = "réinitialiser";
            this.reinitialiser.UseVisualStyleBackColor = false;
            // 
            // imprimer
            // 
            this.imprimer.BackColor = System.Drawing.Color.Transparent;
            this.imprimer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imprimer.BackgroundImage")));
            this.imprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.imprimer.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.imprimer.ForeColor = System.Drawing.Color.White;
            this.imprimer.Location = new System.Drawing.Point(69, 430);
            this.imprimer.Name = "imprimer";
            this.imprimer.Size = new System.Drawing.Size(120, 47);
            this.imprimer.TabIndex = 5;
            this.imprimer.Text = "imprimer";
            this.imprimer.UseVisualStyleBackColor = false;
            this.imprimer.Click += new System.EventHandler(this.imprimer_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Sitka Small", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(164, 11);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 28);
            this.label5.TabIndex = 0;
            this.label5.Text = "Carte d\'épidémie:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.rouge);
            this.panel1.Controls.Add(this.orangeF);
            this.panel1.Controls.Add(this.orange);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cin);
            this.panel1.Controls.Add(this.nCarte);
            this.panel1.Controls.Add(this.vert);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.panel1.Location = new System.Drawing.Point(69, 96);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(372, 265);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(9, 180);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(133, 66);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // rouge
            // 
            this.rouge.AutoSize = true;
            this.rouge.BackColor = System.Drawing.Color.Red;
            this.rouge.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rouge.ForeColor = System.Drawing.Color.White;
            this.rouge.Location = new System.Drawing.Point(191, 223);
            this.rouge.Name = "rouge";
            this.rouge.Size = new System.Drawing.Size(167, 23);
            this.rouge.TabIndex = 2;
            this.rouge.TabStop = true;
            this.rouge.Text = "                                   ";
            this.rouge.UseVisualStyleBackColor = false;
            // 
            // orangeF
            // 
            this.orangeF.AutoSize = true;
            this.orangeF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.orangeF.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.orangeF.ForeColor = System.Drawing.Color.White;
            this.orangeF.Location = new System.Drawing.Point(191, 194);
            this.orangeF.Name = "orangeF";
            this.orangeF.Size = new System.Drawing.Size(167, 23);
            this.orangeF.TabIndex = 2;
            this.orangeF.TabStop = true;
            this.orangeF.Text = "                                   ";
            this.orangeF.UseVisualStyleBackColor = false;
            // 
            // orange
            // 
            this.orange.AutoSize = true;
            this.orange.BackColor = System.Drawing.Color.Orange;
            this.orange.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.orange.ForeColor = System.Drawing.Color.White;
            this.orange.Location = new System.Drawing.Point(191, 165);
            this.orange.Name = "orange";
            this.orange.Size = new System.Drawing.Size(167, 23);
            this.orange.TabIndex = 2;
            this.orange.TabStop = true;
            this.orange.Text = "                                   ";
            this.orange.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(22, 138);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Code Couleur :";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // carteControle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.imprimer);
            this.Controls.Add(this.reinitialiser);
            this.Name = "carteControle";
            this.Size = new System.Drawing.Size(504, 487);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nCarte;
        private System.Windows.Forms.RadioButton vert;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button reinitialiser;
        private System.Windows.Forms.Button imprimer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.RadioButton rouge;
        private System.Windows.Forms.RadioButton orangeF;
        private System.Windows.Forms.RadioButton orange;
        private System.Windows.Forms.Label label6;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}
