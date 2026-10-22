namespace GymManager.Presentation.Abonnements
{
    partial class frmAjouterAbonnemnt
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.ucMemberCardWithFilter1 = new GymManager.Presentation.Members.Controls.ucMemberCardWithFilter();
            this.ucAbonnementInfo1 = new GymManager.Presentation.Abonnements.Control.ucAbonnementInfo();
            this.SuspendLayout();
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(939, 717);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(150, 49);
            this.btnAnnuler.TabIndex = 20;
            this.btnAnnuler.Text = "[ Annuler ]";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(1097, 717);
            this.btnEnregistrer.Margin = new System.Windows.Forms.Padding(4);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(150, 49);
            this.btnEnregistrer.TabIndex = 21;
            this.btnEnregistrer.Text = "[ Enregistrer ]";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // ucMemberCardWithFilter1
            // 
            this.ucMemberCardWithFilter1.FilterEnabled = true;
            this.ucMemberCardWithFilter1.Location = new System.Drawing.Point(24, 14);
            this.ucMemberCardWithFilter1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ucMemberCardWithFilter1.Name = "ucMemberCardWithFilter1";
            this.ucMemberCardWithFilter1.Size = new System.Drawing.Size(1249, 392);
            this.ucMemberCardWithFilter1.TabIndex = 1;
            // 
            // ucAbonnementInfo1
            // 
            this.ucAbonnementInfo1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucAbonnementInfo1.IsUpdateMode = false;
            this.ucAbonnementInfo1.Location = new System.Drawing.Point(24, 413);
            this.ucAbonnementInfo1.Name = "ucAbonnementInfo1";
            this.ucAbonnementInfo1.Size = new System.Drawing.Size(1223, 287);
            this.ucAbonnementInfo1.TabIndex = 0;
            this.ucAbonnementInfo1.Load += new System.EventHandler(this.ucAbonnementInfo1_Load);
            // 
            // frmAjouterAbonnemnt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1584, 798);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.ucMemberCardWithFilter1);
            this.Controls.Add(this.ucAbonnementInfo1);
            this.Name = "frmAjouterAbonnemnt";
            this.Text = "frmAjouterAbonnemnt";
            this.Load += new System.EventHandler(this.frmAjouterAbonnemnt_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Control.ucAbonnementInfo ucAbonnementInfo1;
        private Members.Controls.ucMemberCardWithFilter ucMemberCardWithFilter1;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnEnregistrer;
    }
}