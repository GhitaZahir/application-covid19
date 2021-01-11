namespace application_covid19
{
    partial class hospitalisationControle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hospitalisationControle));
            this.gravite = new System.Windows.Forms.ComboBox();
            this.deces = new System.Windows.Forms.RadioButton();
            this.guerison = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.enregistrer = new System.Windows.Forms.Button();
            this.reinitialiser = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.traitement = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.duree = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gravite
            // 
            this.gravite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gravite.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gravite.ForeColor = System.Drawing.Color.Black;
            this.gravite.FormattingEnabled = true;
            this.gravite.Items.AddRange(new object[] {
            "Anodin",
            "Dangereux ",
            "Extrémement dangereux"});
            this.gravite.Location = new System.Drawing.Point(191, 31);
            this.gravite.Name = "gravite";
            this.gravite.Size = new System.Drawing.Size(169, 26);
            this.gravite.TabIndex = 4;
            this.gravite.SelectedIndexChanged += new System.EventHandler(this.gravite_SelectedIndexChanged);
            // 
            // deces
            // 
            this.deces.AutoSize = true;
            this.deces.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deces.ForeColor = System.Drawing.Color.White;
            this.deces.Location = new System.Drawing.Point(191, 219);
            this.deces.Name = "deces";
            this.deces.Size = new System.Drawing.Size(67, 23);
            this.deces.TabIndex = 3;
            this.deces.TabStop = true;
            this.deces.Text = "Décés";
            this.deces.UseVisualStyleBackColor = true;
            this.deces.CheckedChanged += new System.EventHandler(this.deces_CheckedChanged);
            // 
            // guerison
            // 
            this.guerison.AutoSize = true;
            this.guerison.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.guerison.ForeColor = System.Drawing.Color.White;
            this.guerison.Location = new System.Drawing.Point(191, 179);
            this.guerison.Name = "guerison";
            this.guerison.Size = new System.Drawing.Size(90, 23);
            this.guerison.TabIndex = 2;
            this.guerison.TabStop = true;
            this.guerison.Text = "Guérison";
            this.guerison.UseVisualStyleBackColor = true;
            this.guerison.CheckedChanged += new System.EventHandler(this.guerison_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gravité de cas :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 181);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Résultat final:";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Sitka Small", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(93, 10);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(311, 28);
            this.label4.TabIndex = 0;
            this.label4.Text = "Formulaire d\'hospitalisation:";
            // 
            // enregistrer
            // 
            this.enregistrer.BackColor = System.Drawing.Color.Transparent;
            this.enregistrer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("enregistrer.BackgroundImage")));
            this.enregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enregistrer.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.enregistrer.ForeColor = System.Drawing.Color.White;
            this.enregistrer.Location = new System.Drawing.Point(69, 431);
            this.enregistrer.Name = "enregistrer";
            this.enregistrer.Size = new System.Drawing.Size(120, 47);
            this.enregistrer.TabIndex = 5;
            this.enregistrer.Text = "enregistrer";
            this.enregistrer.UseVisualStyleBackColor = false;
            this.enregistrer.Click += new System.EventHandler(this.enregistrer_Click);
            // 
            // reinitialiser
            // 
            this.reinitialiser.BackColor = System.Drawing.Color.Transparent;
            this.reinitialiser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("reinitialiser.BackgroundImage")));
            this.reinitialiser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reinitialiser.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.reinitialiser.ForeColor = System.Drawing.Color.White;
            this.reinitialiser.Location = new System.Drawing.Point(321, 431);
            this.reinitialiser.Name = "reinitialiser";
            this.reinitialiser.Size = new System.Drawing.Size(120, 47);
            this.reinitialiser.TabIndex = 5;
            this.reinitialiser.Text = "réinitialiser";
            this.reinitialiser.UseVisualStyleBackColor = false;
            this.reinitialiser.Click += new System.EventHandler(this.reinitialiser_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.traitement);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.duree);
            this.panel1.Controls.Add(this.gravite);
            this.panel1.Controls.Add(this.deces);
            this.panel1.Controls.Add(this.guerison);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.panel1.Location = new System.Drawing.Point(64, 97);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(377, 265);
            this.panel1.TabIndex = 1;
            // 
            // traitement
            // 
            this.traitement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.traitement.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.traitement.ForeColor = System.Drawing.Color.Black;
            this.traitement.FormattingEnabled = true;
            this.traitement.Items.AddRange(new object[] {
            "Confinement",
            "Médicaments + Confinement",
            "Réanimation",
            "Incubation"});
            this.traitement.Location = new System.Drawing.Point(191, 82);
            this.traitement.Name = "traitement";
            this.traitement.Size = new System.Drawing.Size(169, 26);
            this.traitement.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(16, 84);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Traitement donné :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(18, 132);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Durée de traitement:";
            // 
            // duree
            // 
            this.duree.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.duree.Location = new System.Drawing.Point(191, 132);
            this.duree.Name = "duree";
            this.duree.Size = new System.Drawing.Size(169, 26);
            this.duree.TabIndex = 5;
            // 
            // hospitalisationControle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.reinitialiser);
            this.Controls.Add(this.enregistrer);
            this.Controls.Add(this.label4);
            this.Name = "hospitalisationControle";
            this.Size = new System.Drawing.Size(504, 487);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox gravite;
        private System.Windows.Forms.RadioButton deces;
        private System.Windows.Forms.RadioButton guerison;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button enregistrer;
        private System.Windows.Forms.Button reinitialiser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox traitement;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox duree;
    }
}
