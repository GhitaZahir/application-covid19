using System.Windows.Forms;

namespace application_covid19
{
    partial class listeControle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(listeControle));
            this.panel = new System.Windows.Forms.Panel();
            this.nInfect = new System.Windows.Forms.Label();
            this.nNConfirm = new System.Windows.Forms.Label();
            this.nDeces = new System.Windows.Forms.Label();
            this.nGuerison = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.modifier = new System.Windows.Forms.Button();
            this.supprimer = new System.Windows.Forms.Button();
            this.annuler = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.afficher1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.afficher2 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.afficher3 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.afficher4 = new System.Windows.Forms.Button();
            this.dataVaccin = new System.Windows.Forms.DataGridView();
            this.dataHospitalisation = new System.Windows.Forms.DataGridView();
            this.dataTest = new System.Windows.Forms.DataGridView();
            this.dataCitoyen = new System.Windows.Forms.DataGridView();
            this.panel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataVaccin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataHospitalisation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataCitoyen)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel.BackgroundImage")));
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel.Controls.Add(this.nInfect);
            this.panel.Controls.Add(this.nNConfirm);
            this.panel.Controls.Add(this.nDeces);
            this.panel.Controls.Add(this.nGuerison);
            this.panel.Controls.Add(this.label9);
            this.panel.Controls.Add(this.label8);
            this.panel.Controls.Add(this.label7);
            this.panel.Controls.Add(this.label6);
            this.panel.Controls.Add(this.label5);
            this.panel.Location = new System.Drawing.Point(10, 371);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(366, 135);
            this.panel.TabIndex = 1;
            // 
            // nInfect
            // 
            this.nInfect.AutoSize = true;
            this.nInfect.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nInfect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nInfect.Location = new System.Drawing.Point(253, 9);
            this.nInfect.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nInfect.Name = "nInfect";
            this.nInfect.Size = new System.Drawing.Size(58, 19);
            this.nInfect.TabIndex = 0;
            this.nInfect.Text = "Nonlkk";
            // 
            // nNConfirm
            // 
            this.nNConfirm.AutoSize = true;
            this.nNConfirm.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nNConfirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nNConfirm.Location = new System.Drawing.Point(253, 96);
            this.nNConfirm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nNConfirm.Name = "nNConfirm";
            this.nNConfirm.Size = new System.Drawing.Size(58, 19);
            this.nNConfirm.TabIndex = 0;
            this.nNConfirm.Text = "Nonlkk";
            // 
            // nDeces
            // 
            this.nDeces.AutoSize = true;
            this.nDeces.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nDeces.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nDeces.Location = new System.Drawing.Point(253, 67);
            this.nDeces.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nDeces.Name = "nDeces";
            this.nDeces.Size = new System.Drawing.Size(58, 19);
            this.nDeces.TabIndex = 0;
            this.nDeces.Text = "Nonlkk";
            // 
            // nGuerison
            // 
            this.nGuerison.AutoSize = true;
            this.nGuerison.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nGuerison.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nGuerison.Location = new System.Drawing.Point(253, 38);
            this.nGuerison.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nGuerison.Name = "nGuerison";
            this.nGuerison.Size = new System.Drawing.Size(58, 19);
            this.nGuerison.TabIndex = 0;
            this.nGuerison.Text = "Nonlkk";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label9.Location = new System.Drawing.Point(253, 9);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 19);
            this.label9.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(12, 96);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(224, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "Nombre de cas non confirmés :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(12, 67);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "Nombre de décés :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 38);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Nombre de guérisons :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nombre d\'infections :";
            // 
            // modifier
            // 
            this.modifier.BackColor = System.Drawing.Color.Transparent;
            this.modifier.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("modifier.BackgroundImage")));
            this.modifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modifier.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.modifier.ForeColor = System.Drawing.Color.White;
            this.modifier.Location = new System.Drawing.Point(386, 371);
            this.modifier.Name = "modifier";
            this.modifier.Size = new System.Drawing.Size(107, 41);
            this.modifier.TabIndex = 5;
            this.modifier.Text = "modifier";
            this.modifier.UseVisualStyleBackColor = false;
            // 
            // supprimer
            // 
            this.supprimer.BackColor = System.Drawing.Color.Transparent;
            this.supprimer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("supprimer.BackgroundImage")));
            this.supprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.supprimer.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.supprimer.ForeColor = System.Drawing.Color.White;
            this.supprimer.Location = new System.Drawing.Point(386, 418);
            this.supprimer.Name = "supprimer";
            this.supprimer.Size = new System.Drawing.Size(107, 41);
            this.supprimer.TabIndex = 5;
            this.supprimer.Text = "supprimer";
            this.supprimer.UseVisualStyleBackColor = false;
            // 
            // annuler
            // 
            this.annuler.BackColor = System.Drawing.Color.Transparent;
            this.annuler.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("annuler.BackgroundImage")));
            this.annuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.annuler.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.annuler.ForeColor = System.Drawing.Color.White;
            this.annuler.Location = new System.Drawing.Point(386, 465);
            this.annuler.Name = "annuler";
            this.annuler.Size = new System.Drawing.Size(107, 41);
            this.annuler.TabIndex = 5;
            this.annuler.Text = "annuler";
            this.annuler.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.afficher1);
            this.panel1.Location = new System.Drawing.Point(12, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 140);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(31, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Table de citoyen:";
            // 
            // afficher1
            // 
            this.afficher1.BackColor = System.Drawing.Color.Transparent;
            this.afficher1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.afficher1.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.afficher1.ForeColor = System.Drawing.Color.White;
            this.afficher1.Location = new System.Drawing.Point(56, 50);
            this.afficher1.Name = "afficher1";
            this.afficher1.Size = new System.Drawing.Size(107, 41);
            this.afficher1.TabIndex = 5;
            this.afficher1.Text = "afficher";
            this.afficher1.UseVisualStyleBackColor = false;
            this.afficher1.Click += new System.EventHandler(this.afficher1_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.afficher2);
            this.panel2.Location = new System.Drawing.Point(265, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(228, 141);
            this.panel2.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(61, 13);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Table de test:";
            // 
            // afficher2
            // 
            this.afficher2.BackColor = System.Drawing.Color.Transparent;
            this.afficher2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.afficher2.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.afficher2.ForeColor = System.Drawing.Color.White;
            this.afficher2.Location = new System.Drawing.Point(61, 50);
            this.afficher2.Name = "afficher2";
            this.afficher2.Size = new System.Drawing.Size(107, 41);
            this.afficher2.TabIndex = 5;
            this.afficher2.Text = "afficher";
            this.afficher2.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.afficher3);
            this.panel3.Location = new System.Drawing.Point(10, 207);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(219, 140);
            this.panel3.TabIndex = 6;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(14, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Table d\'hospitalisation:";
            // 
            // afficher3
            // 
            this.afficher3.BackColor = System.Drawing.Color.Transparent;
            this.afficher3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.afficher3.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.afficher3.ForeColor = System.Drawing.Color.White;
            this.afficher3.Location = new System.Drawing.Point(56, 50);
            this.afficher3.Name = "afficher3";
            this.afficher3.Size = new System.Drawing.Size(107, 41);
            this.afficher3.TabIndex = 5;
            this.afficher3.Text = "afficher";
            this.afficher3.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.afficher4);
            this.panel4.Location = new System.Drawing.Point(265, 207);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(228, 140);
            this.panel4.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Small", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(42, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Table de vaccin:";
            // 
            // afficher4
            // 
            this.afficher4.BackColor = System.Drawing.Color.Transparent;
            this.afficher4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.afficher4.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.afficher4.ForeColor = System.Drawing.Color.White;
            this.afficher4.Location = new System.Drawing.Point(61, 50);
            this.afficher4.Name = "afficher4";
            this.afficher4.Size = new System.Drawing.Size(107, 41);
            this.afficher4.TabIndex = 5;
            this.afficher4.Text = "afficher";
            this.afficher4.UseVisualStyleBackColor = false;
            // 
            // dataVaccin
            // 
            this.dataVaccin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(34)))));
            this.dataVaccin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataVaccin.GridColor = System.Drawing.Color.White;
            this.dataVaccin.Location = new System.Drawing.Point(265, 207);
            this.dataVaccin.Name = "dataVaccin";
            this.dataVaccin.Size = new System.Drawing.Size(228, 140);
            this.dataVaccin.TabIndex = 0;
            this.dataVaccin.Text = "dataGridView4";
            // 
            // dataHospitalisation
            // 
            this.dataHospitalisation.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(34)))));
            this.dataHospitalisation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataHospitalisation.GridColor = System.Drawing.Color.White;
            this.dataHospitalisation.Location = new System.Drawing.Point(12, 207);
            this.dataHospitalisation.Name = "dataHospitalisation";
            this.dataHospitalisation.Size = new System.Drawing.Size(219, 140);
            this.dataHospitalisation.TabIndex = 0;
            this.dataHospitalisation.Text = "dataGridView3";
            // 
            // dataTest
            // 
            this.dataTest.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(34)))));
            this.dataTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTest.GridColor = System.Drawing.Color.White;
            this.dataTest.Location = new System.Drawing.Point(265, 28);
            this.dataTest.Name = "dataTest";
            this.dataTest.Size = new System.Drawing.Size(228, 140);
            this.dataTest.TabIndex = 0;
            this.dataTest.Text = "dataGridView2";
            // 
            // dataCitoyen
            // 
            this.dataCitoyen.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(34)))));
            this.dataCitoyen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCitoyen.GridColor = System.Drawing.Color.White;
            this.dataCitoyen.Location = new System.Drawing.Point(12, 28);
            this.dataCitoyen.Name = "dataCitoyen";
            this.dataCitoyen.Size = new System.Drawing.Size(219, 140);
            this.dataCitoyen.TabIndex = 0;
            this.dataCitoyen.Text = "dataGridView1";
            // 
            // listeControle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.annuler);
            this.Controls.Add(this.supprimer);
            this.Controls.Add(this.modifier);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.dataVaccin);
            this.Controls.Add(this.dataHospitalisation);
            this.Controls.Add(this.dataTest);
            this.Controls.Add(this.dataCitoyen);
            this.Name = "listeControle";
            this.Size = new System.Drawing.Size(504, 517);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataVaccin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataHospitalisation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataCitoyen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataCitoyen;
        private System.Windows.Forms.DataGridView dataTest;
        private System.Windows.Forms.DataGridView dataHospitalisation;
        private System.Windows.Forms.DataGridView dataVaccin;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label nInfect;
        private System.Windows.Forms.Label nNConfirm;
        private System.Windows.Forms.Label nDeces;
        private System.Windows.Forms.Label nGuerison;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button modifier;
        private System.Windows.Forms.Button supprimer;
        private System.Windows.Forms.Button annuler;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button afficher1;
        private System.Windows.Forms.Button afficher2;
        private System.Windows.Forms.Button afficher3;
        private System.Windows.Forms.Button afficher4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private readonly PaintEventHandler panel3_Paint;
    }
}
