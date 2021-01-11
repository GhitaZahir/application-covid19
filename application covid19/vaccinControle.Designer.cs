namespace application_covid19
{
    partial class vaccinControle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(vaccinControle));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cause = new System.Windows.Forms.TextBox();
            this.non = new System.Windows.Forms.RadioButton();
            this.oui = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.reinitialiser = new System.Windows.Forms.Button();
            this.enregistrer = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            // cause
            // 
            this.cause.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cause.Location = new System.Drawing.Point(41, 154);
            this.cause.Multiline = true;
            this.cause.Name = "cause";
            this.cause.Size = new System.Drawing.Size(297, 84);
            this.cause.TabIndex = 5;
            // 
            // non
            // 
            this.non.AutoSize = true;
            this.non.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.non.ForeColor = System.Drawing.Color.White;
            this.non.Location = new System.Drawing.Point(209, 70);
            this.non.Name = "non";
            this.non.Size = new System.Drawing.Size(55, 23);
            this.non.TabIndex = 3;
            this.non.TabStop = true;
            this.non.Text = "Non";
            this.non.UseVisualStyleBackColor = true;
            this.non.CheckedChanged += new System.EventHandler(this.non_CheckedChanged);
            // 
            // oui
            // 
            this.oui.AutoSize = true;
            this.oui.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.oui.ForeColor = System.Drawing.Color.White;
            this.oui.Location = new System.Drawing.Point(121, 70);
            this.oui.Name = "oui";
            this.oui.Size = new System.Drawing.Size(51, 23);
            this.oui.TabIndex = 2;
            this.oui.TabStop = true;
            this.oui.Text = "Oui";
            this.oui.UseVisualStyleBackColor = true;
            this.oui.CheckedChanged += new System.EventHandler(this.oui_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(66, 26);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(247, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Voulez-vous vous vacciner ?";
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
            this.reinitialiser.Click += new System.EventHandler(this.reinitialiser_Click);
            // 
            // enregistrer
            // 
            this.enregistrer.BackColor = System.Drawing.Color.Transparent;
            this.enregistrer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("enregistrer.BackgroundImage")));
            this.enregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enregistrer.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.enregistrer.ForeColor = System.Drawing.Color.White;
            this.enregistrer.Location = new System.Drawing.Point(69, 430);
            this.enregistrer.Name = "enregistrer";
            this.enregistrer.Size = new System.Drawing.Size(120, 47);
            this.enregistrer.TabIndex = 5;
            this.enregistrer.Text = "enregistrer";
            this.enregistrer.UseVisualStyleBackColor = false;
            this.enregistrer.Click += new System.EventHandler(this.enregistrer_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Sitka Small", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(132, 11);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(239, 28);
            this.label5.TabIndex = 0;
            this.label5.Text = "Formulaire de vaccin :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cause);
            this.panel1.Controls.Add(this.non);
            this.panel1.Controls.Add(this.oui);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.panel1.Location = new System.Drawing.Point(64, 96);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(377, 265);
            this.panel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(41, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(297, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Si non veuillez nous dire pourquoi?";
            // 
            // vaccinControle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.enregistrer);
            this.Controls.Add(this.reinitialiser);
            this.Name = "vaccinControle";
            this.Size = new System.Drawing.Size(504, 487);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cause;
        private System.Windows.Forms.RadioButton non;
        private System.Windows.Forms.RadioButton oui;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button reinitialiser;
        private System.Windows.Forms.Button enregistrer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
    }
}
