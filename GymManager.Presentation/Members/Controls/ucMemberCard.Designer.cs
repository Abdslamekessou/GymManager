namespace GymManager.Presentation.Members.Controls
{
    partial class ucMemberCard
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rbActif = new System.Windows.Forms.RadioButton();
            this.rbInActif = new System.Windows.Forms.RadioButton();
            this.lblStatusTitle = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.ucPersonCard1 = new GymManager.Presentation.Personnes.Controls.ucPersonCard();
            this.SuspendLayout();
            // 
            // rbActif
            // 
            this.rbActif.AutoSize = true;
            this.rbActif.Checked = true;
            this.rbActif.Location = new System.Drawing.Point(651, 195);
            this.rbActif.Name = "rbActif";
            this.rbActif.Size = new System.Drawing.Size(53, 20);
            this.rbActif.TabIndex = 11;
            this.rbActif.TabStop = true;
            this.rbActif.Text = "Actif";
            this.rbActif.UseVisualStyleBackColor = true;
            // 
            // rbInActif
            // 
            this.rbInActif.AutoSize = true;
            this.rbInActif.Location = new System.Drawing.Point(710, 195);
            this.rbInActif.Name = "rbInActif";
            this.rbInActif.Size = new System.Drawing.Size(80, 20);
            this.rbInActif.TabIndex = 12;
            this.rbInActif.Text = "Pas Actif";
            this.rbInActif.UseVisualStyleBackColor = true;
            // 
            // lblStatusTitle
            // 
            this.lblStatusTitle.AutoSize = true;
            this.lblStatusTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblStatusTitle.Location = new System.Drawing.Point(649, 192);
            this.lblStatusTitle.Name = "lblStatusTitle";
            this.lblStatusTitle.Size = new System.Drawing.Size(56, 23);
            this.lblStatusTitle.TabIndex = 14;
            this.lblStatusTitle.Text = "Status";
            this.lblStatusTitle.Visible = false;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblStatus.Location = new System.Drawing.Point(806, 192);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(53, 23);
            this.lblStatus.TabIndex = 15;
            this.lblStatus.Text = "[ ??? ]";
            this.lblStatus.Visible = false;
            // 
            // ucPersonCard1
            // 
            this.ucPersonCard1.AutoSize = true;
            this.ucPersonCard1.Location = new System.Drawing.Point(3, 33);
            this.ucPersonCard1.Name = "ucPersonCard1";
            this.ucPersonCard1.Size = new System.Drawing.Size(1083, 202);
            this.ucPersonCard1.TabIndex = 0;
            this.ucPersonCard1.Tilte = "INFORMATIONS INFORMATIONS INFORMATIONS INFORMATIONS DE LA PERSONNE";
            // 
            // ucMemberCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblStatusTitle);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.rbInActif);
            this.Controls.Add(this.rbActif);
            this.Controls.Add(this.ucPersonCard1);
            this.Name = "ucMemberCard";
            this.Size = new System.Drawing.Size(1107, 253);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Personnes.Controls.ucPersonCard ucPersonCard1;
        private System.Windows.Forms.RadioButton rbActif;
        private System.Windows.Forms.RadioButton rbInActif;
        private System.Windows.Forms.Label lblStatusTitle;
        private System.Windows.Forms.Label lblStatus;
    }
}
