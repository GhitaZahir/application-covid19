namespace application_covid19
{
    partial class testControle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(testControle));
            this.doute = new System.Windows.Forms.ComboBox();
            this.dateTest = new System.Windows.Forms.TextBox();
            this.negatif = new System.Windows.Forms.RadioButton();
            this.positif = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.reinitialiser = new System.Windows.Forms.Button();
            this.enregistrer = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // doute
            // 
            this.doute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doute.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.doute.ForeColor = System.Drawing.Color.Black;
            this.doute.FormattingEnabled = true;
            this.doute.Location = new System.Drawing.Point(191, 31);
            this.doute.Name = "doute";
            this.doute.Size = new System.Drawing.Size(169, 26);
            this.doute.TabIndex = 4;
            this.doute.Text = "Avoir les symptômes";
            // 
            // dateTest
            // 
            this.dateTest.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateTest.Location = new System.Drawing.Point(191, 196);
            this.dateTest.Name = "dateTest";
            this.dateTest.Size = new System.Drawing.Size(169, 26);
            this.dateTest.TabIndex = 5;
            // 
            // negatif
            // 
            this.negatif.AutoSize = true;
            this.negatif.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.negatif.ForeColor = System.Drawing.Color.White;
            this.negatif.Location = new System.Drawing.Point(191, 134);
            this.negatif.Name = "negatif";
            this.negatif.Size = new System.Drawing.Size(79, 23);
            this.negatif.TabIndex = 3;
            this.negatif.TabStop = true;
            this.negatif.Text = "Négatif";
            this.negatif.UseVisualStyleBackColor = true;
            this.negatif.CheckedChanged += new System.EventHandler(this.negatif_CheckedChanged);
            // 
            // positif
            // 
            this.positif.AutoSize = true;
            this.positif.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.positif.ForeColor = System.Drawing.Color.White;
            this.positif.Location = new System.Drawing.Point(191, 94);
            this.positif.Name = "positif";
            this.positif.Size = new System.Drawing.Size(73, 23);
            this.positif.TabIndex = 2;
            this.positif.TabStop = true;
            this.positif.Text = "Positif";
            this.positif.UseVisualStyleBackColor = true;
            this.positif.CheckedChanged += new System.EventHandler(this.positif_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type de doutes :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Résultat du test:";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(16, 196);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Date du test:";
            // 
            // reinitialiser
            // 
            this.reinitialiser.BackColor = System.Drawing.Color.Transparent;
            this.reinitialiser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("reinitialiser.BackgroundImage")));
            this.reinitialiser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reinitialiser.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.reinitialiser.ForeColor = System.Drawing.Color.White;
            this.reinitialiser.Location = new System.Drawing.Point(320, 425);
            this.reinitialiser.Name = "reinitialiser";
            this.reinitialiser.Size = new System.Drawing.Size(120, 47);
            this.reinitialiser.TabIndex = 5;
            this.reinitialiser.Text = "reinitialiser";
            this.reinitialiser.UseVisualStyleBackColor = false;
            this.reinitialiser.Click += new System.EventHandler(this.reinitialiser_Click);
            // 
            // enregistrer
            // 
            this.enregistrer.BackColor = System.Drawing.Color.Transparent;
            this.enregistrer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("enregistrer.BackgroundImage")));
            this.enregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enregistrer.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.enregistrer.ForeColor = System.Drawing.Color.White;
            this.enregistrer.Location = new System.Drawing.Point(68, 425);
            this.enregistrer.Name = "enregistrer";
            this.enregistrer.Size = new System.Drawing.Size(120, 47);
            this.enregistrer.TabIndex = 5;
            this.enregistrer.Text = "enregistrer";
            this.enregistrer.UseVisualStyleBackColor = false;
            this.enregistrer.Click += new System.EventHandler(this.enregistrer_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Sitka Small", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(129, 2);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(272, 28);
            this.label4.TabIndex = 0;
            this.label4.Text = "Formulaire du test passé:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.doute);
            this.panel1.Controls.Add(this.dateTest);
            this.panel1.Controls.Add(this.negatif);
            this.panel1.Controls.Add(this.positif);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.panel1.Location = new System.Drawing.Point(63, 91);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(377, 257);
            this.panel1.TabIndex = 1;
            // 
            // testControle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.enregistrer);
            this.Controls.Add(this.reinitialiser);
            this.Name = "testControle";
            this.Size = new System.Drawing.Size(504, 487);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox doute;
        private System.Windows.Forms.TextBox dateTest;
        private System.Windows.Forms.RadioButton negatif;
        private System.Windows.Forms.RadioButton positif;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button reinitialiser;
        private System.Windows.Forms.Button enregistrer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
    }
}
