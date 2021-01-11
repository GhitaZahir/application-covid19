namespace application_covid19
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.citoyen = new System.Windows.Forms.Button();
            this.test = new System.Windows.Forms.Button();
            this.hospitalisation = new System.Windows.Forms.Button();
            this.vaccin = new System.Windows.Forms.Button();
            this.carte = new System.Windows.Forms.Button();
            this.liste = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.PictureBox();
            this.citoyenControle1 = new application_covid19.citoyenControle();
            this.testControle1 = new application_covid19.testControle();
            this.hospitalisationControle1 = new application_covid19.hospitalisationControle();
            this.vaccinControle1 = new application_covid19.vaccinControle();
            this.carteControle1 = new application_covid19.carteControle();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.citoyen);
            this.panel1.Controls.Add(this.test);
            this.panel1.Controls.Add(this.hospitalisation);
            this.panel1.Controls.Add(this.vaccin);
            this.panel1.Controls.Add(this.carte);
            this.panel1.Controls.Add(this.liste);
            this.panel1.Location = new System.Drawing.Point(1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(175, 602);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // citoyen
            // 
            this.citoyen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.citoyen.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.citoyen.ForeColor = System.Drawing.Color.White;
            this.citoyen.Location = new System.Drawing.Point(-2, 136);
            this.citoyen.Name = "citoyen";
            this.citoyen.Size = new System.Drawing.Size(174, 69);
            this.citoyen.TabIndex = 5;
            this.citoyen.Text = "Citoyen";
            this.citoyen.UseVisualStyleBackColor = true;
            this.citoyen.Click += new System.EventHandler(this.citoyen_Click);
            // 
            // test
            // 
            this.test.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.test.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.test.ForeColor = System.Drawing.Color.White;
            this.test.Location = new System.Drawing.Point(0, 202);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(174, 69);
            this.test.TabIndex = 5;
            this.test.Text = "Test";
            this.test.UseVisualStyleBackColor = true;
            this.test.Click += new System.EventHandler(this.test_Click);
            // 
            // hospitalisation
            // 
            this.hospitalisation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hospitalisation.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.hospitalisation.ForeColor = System.Drawing.Color.White;
            this.hospitalisation.Location = new System.Drawing.Point(-1, 267);
            this.hospitalisation.Name = "hospitalisation";
            this.hospitalisation.Size = new System.Drawing.Size(174, 69);
            this.hospitalisation.TabIndex = 5;
            this.hospitalisation.Text = "Hospitalisation";
            this.hospitalisation.UseVisualStyleBackColor = true;
            this.hospitalisation.Click += new System.EventHandler(this.hospitalisation_Click);
            // 
            // vaccin
            // 
            this.vaccin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vaccin.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.vaccin.ForeColor = System.Drawing.Color.White;
            this.vaccin.Location = new System.Drawing.Point(0, 333);
            this.vaccin.Name = "vaccin";
            this.vaccin.Size = new System.Drawing.Size(174, 69);
            this.vaccin.TabIndex = 5;
            this.vaccin.Text = "Vaccin";
            this.vaccin.UseVisualStyleBackColor = true;
            this.vaccin.Click += new System.EventHandler(this.vaccin_Click);
            // 
            // carte
            // 
            this.carte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.carte.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.carte.ForeColor = System.Drawing.Color.White;
            this.carte.Location = new System.Drawing.Point(0, 399);
            this.carte.Name = "carte";
            this.carte.Size = new System.Drawing.Size(174, 69);
            this.carte.TabIndex = 5;
            this.carte.Text = "Carte D\'épidémie";
            this.carte.UseVisualStyleBackColor = true;
            this.carte.Click += new System.EventHandler(this.carte_Click);
            // 
            // liste
            // 
            this.liste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.liste.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.liste.ForeColor = System.Drawing.Color.White;
            this.liste.Location = new System.Drawing.Point(-2, 465);
            this.liste.Name = "liste";
            this.liste.Size = new System.Drawing.Size(174, 70);
            this.liste.TabIndex = 5;
            this.liste.Text = "Liste et statistiques";
            this.liste.UseVisualStyleBackColor = true;
            this.liste.Click += new System.EventHandler(this.liste_Click);
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.Location = new System.Drawing.Point(850, 12);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(28, 27);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.close.TabIndex = 3;
            this.close.TabStop = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // citoyenControle1
            // 
            this.citoyenControle1.BackColor = System.Drawing.Color.Transparent;
            this.citoyenControle1.Location = new System.Drawing.Point(258, 14);
            this.citoyenControle1.Name = "citoyenControle1";
            this.citoyenControle1.Size = new System.Drawing.Size(504, 487);
            this.citoyenControle1.TabIndex = 4;
            // 
            // testControle1
            // 
            this.testControle1.BackColor = System.Drawing.Color.Transparent;
            this.testControle1.Location = new System.Drawing.Point(258, 9);
            this.testControle1.Name = "testControle1";
            this.testControle1.Size = new System.Drawing.Size(504, 487);
            this.testControle1.TabIndex = 5;
            // 
            // hospitalisationControle1
            // 
            this.hospitalisationControle1.BackColor = System.Drawing.Color.Transparent;
            this.hospitalisationControle1.Location = new System.Drawing.Point(258, 14);
            this.hospitalisationControle1.Name = "hospitalisationControle1";
            this.hospitalisationControle1.Size = new System.Drawing.Size(504, 487);
            this.hospitalisationControle1.TabIndex = 6;
            // 
            // vaccinControle1
            // 
            this.vaccinControle1.BackColor = System.Drawing.Color.Transparent;
            this.vaccinControle1.Location = new System.Drawing.Point(240, 14);
            this.vaccinControle1.Name = "vaccinControle1";
            this.vaccinControle1.Size = new System.Drawing.Size(504, 487);
            this.vaccinControle1.TabIndex = 7;
            // 
            // carteControle1
            // 
            this.carteControle1.BackColor = System.Drawing.Color.Transparent;
            this.carteControle1.Location = new System.Drawing.Point(258, 14);
            this.carteControle1.Name = "carteControle1";
            this.carteControle1.Size = new System.Drawing.Size(504, 487);
            this.carteControle1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(890, 533);
            this.Controls.Add(this.carteControle1);
            this.Controls.Add(this.vaccinControle1);
            this.Controls.Add(this.hospitalisationControle1);
            this.Controls.Add(this.testControle1);
            this.Controls.Add(this.citoyenControle1);
            this.Controls.Add(this.close);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button citoyen;
        private System.Windows.Forms.Button test;
        private System.Windows.Forms.Button hospitalisation;
        private System.Windows.Forms.Button vaccin;
        private System.Windows.Forms.Button carte;
        private System.Windows.Forms.Button liste;
        private System.Windows.Forms.PictureBox close;
        private citoyenControle citoyenControle1;
        private testControle testControle1;
        private hospitalisationControle hospitalisationControle1;
        private vaccinControle vaccinControle1;
        private carteControle carteControle1;
        private listeControle listeControle1;
    }
}

