using System;

namespace application_covid19
{
    partial class citoyenControle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(citoyenControle));
            this.label1 = new System.Windows.Forms.Label();
            this.maladie = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.prenom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nom = new System.Windows.Forms.TextBox();
            this.cin = new System.Windows.Forms.TextBox();
            this.zone = new System.Windows.Forms.ComboBox();
            this.age = new System.Windows.Forms.TextBox();
            this.femme = new System.Windows.Forms.RadioButton();
            this.homme = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.enregistrer = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.reinitialiser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 261);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zone de vie:";
            // 
            // maladie
            // 
            this.maladie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maladie.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.maladie.ForeColor = System.Drawing.Color.Black;
            this.maladie.FormattingEnabled = true;
            this.maladie.Items.AddRange(new object[] {
            "Pas de maladie",
            "Maladie de Foie",
            "Maladie de Reins",
            "Maladie de Coeur",
            "Maladie de Poumons",
            "Autres maladies chroniques"});
            this.maladie.Location = new System.Drawing.Point(169, 304);
            this.maladie.Name = "maladie";
            this.maladie.Size = new System.Drawing.Size(169, 26);
            this.maladie.TabIndex = 4;
            this.maladie.Text = "Pas de maladie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nom:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(16, 311);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Maladie:";
            // 
            // comboBox2
            // 
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox2.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comboBox2.ForeColor = System.Drawing.Color.Black;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(165, 420);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(169, 26);
            this.comboBox2.TabIndex = 4;
            this.comboBox2.Text = "Avoir les symptômes";
            // 
            // prenom
            // 
            this.prenom.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.prenom.Location = new System.Drawing.Point(169, 121);
            this.prenom.Name = "prenom";
            this.prenom.Size = new System.Drawing.Size(169, 26);
            this.prenom.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(16, 127);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Prénom:";
            // 
            // nom
            // 
            this.nom.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nom.Location = new System.Drawing.Point(169, 73);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(169, 26);
            this.nom.TabIndex = 5;
            // 
            // cin
            // 
            this.cin.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cin.Location = new System.Drawing.Point(169, 27);
            this.cin.Name = "cin";
            this.cin.Size = new System.Drawing.Size(169, 26);
            this.cin.TabIndex = 5;
            this.cin.TextChanged += new System.EventHandler(this.cin_TextChanged);
            // 
            // zone
            // 
            this.zone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zone.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.zone.ForeColor = System.Drawing.Color.Black;
            this.zone.FormattingEnabled = true;
            this.zone.Items.AddRange(new object[] {
            "zone1",
            "zone2",
            "zone3",
            "zone4"});
            this.zone.Location = new System.Drawing.Point(169, 254);
            this.zone.Name = "zone";
            this.zone.Size = new System.Drawing.Size(169, 26);
            this.zone.TabIndex = 4;
            // 
            // age
            // 
            this.age.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.age.Location = new System.Drawing.Point(169, 207);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(169, 26);
            this.age.TabIndex = 5;
            // 
            // femme
            // 
            this.femme.AutoSize = true;
            this.femme.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.femme.ForeColor = System.Drawing.Color.White;
            this.femme.Location = new System.Drawing.Point(259, 169);
            this.femme.Name = "femme";
            this.femme.Size = new System.Drawing.Size(78, 23);
            this.femme.TabIndex = 3;
            this.femme.TabStop = true;
            this.femme.Text = "Femme";
            this.femme.UseVisualStyleBackColor = true;
            this.femme.CheckedChanged += new System.EventHandler(this.femme_CheckedChanged);
            // 
            // homme
            // 
            this.homme.AutoSize = true;
            this.homme.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.homme.ForeColor = System.Drawing.Color.White;
            this.homme.Location = new System.Drawing.Point(169, 169);
            this.homme.Name = "homme";
            this.homme.Size = new System.Drawing.Size(80, 23);
            this.homme.TabIndex = 2;
            this.homme.TabStop = true;
            this.homme.Text = "Homme";
            this.homme.UseVisualStyleBackColor = true;
            this.homme.CheckedChanged += new System.EventHandler(this.homme_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(16, 33);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "CIN :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(16, 171);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Sexe:";
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(16, 213);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "Age:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Sitka Small", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(144, 2);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(245, 28);
            this.label8.TabIndex = 0;
            this.label8.Text = "Formulaire du citoyen:";
            // 
            // enregistrer
            // 
            this.enregistrer.BackColor = System.Drawing.Color.Transparent;
            this.enregistrer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("enregistrer.BackgroundImage")));
            this.enregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enregistrer.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.enregistrer.ForeColor = System.Drawing.Color.White;
            this.enregistrer.Location = new System.Drawing.Point(72, 429);
            this.enregistrer.Name = "enregistrer";
            this.enregistrer.Size = new System.Drawing.Size(121, 47);
            this.enregistrer.TabIndex = 5;
            this.enregistrer.Text = "enregistrer";
            this.enregistrer.UseVisualStyleBackColor = false;
            this.enregistrer.Click += new System.EventHandler(this.enregistrer_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.maladie);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.prenom);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.nom);
            this.panel1.Controls.Add(this.cin);
            this.panel1.Controls.Add(this.zone);
            this.panel1.Controls.Add(this.age);
            this.panel1.Controls.Add(this.femme);
            this.panel1.Controls.Add(this.homme);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.panel1.Location = new System.Drawing.Point(72, 41);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(363, 368);
            this.panel1.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(16, 261);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 19);
            this.label10.TabIndex = 0;
            this.label10.Text = "Zone de vie:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(16, 311);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 19);
            this.label9.TabIndex = 0;
            this.label9.Text = "Maladie:";
            // 
            // reinitialiser
            // 
            this.reinitialiser.BackColor = System.Drawing.Color.Transparent;
            this.reinitialiser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("reinitialiser.BackgroundImage")));
            this.reinitialiser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reinitialiser.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.reinitialiser.ForeColor = System.Drawing.Color.White;
            this.reinitialiser.Location = new System.Drawing.Point(315, 429);
            this.reinitialiser.Name = "reinitialiser";
            this.reinitialiser.Size = new System.Drawing.Size(120, 47);
            this.reinitialiser.TabIndex = 5;
            this.reinitialiser.Text = "réinitialiser";
            this.reinitialiser.UseVisualStyleBackColor = false;
            this.reinitialiser.Click += new System.EventHandler(this.reinitialiser_Click);
            // 
            // citoyenControle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.reinitialiser);
            this.Controls.Add(this.enregistrer);
            this.Controls.Add(this.label8);
            this.Name = "citoyenControle";
            this.Size = new System.Drawing.Size(504, 487);
            this.Load += new System.EventHandler(this.citoyenControle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void cin_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox maladie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox prenom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nom;
        private System.Windows.Forms.TextBox cin;
        private System.Windows.Forms.ComboBox zone;
        private System.Windows.Forms.TextBox age;
        private System.Windows.Forms.RadioButton femme;
        private System.Windows.Forms.RadioButton homme;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button enregistrer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button reinitialiser;
    }
}
