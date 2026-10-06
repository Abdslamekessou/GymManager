namespace GymManager.Presentation.Members
{
    partial class frmAddUpdateMember
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.rbInActif = new System.Windows.Forms.RadioButton();
            this.rbActif = new System.Windows.Forms.RadioButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.ucAbonnementInfo1 = new GymManager.Presentation.Abonnements.Control.ucAbonnementInfo();
            this.ucPersonCardWithFilter1 = new GymManager.Presentation.Personnes.Controls.ucPersonCardWithFilter();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCancel.Location = new System.Drawing.Point(904, 674);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(105, 40);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSave.Location = new System.Drawing.Point(1019, 674);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 40);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Enregistrer";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // rbInActif
            // 
            this.rbInActif.AutoSize = true;
            this.rbInActif.Location = new System.Drawing.Point(754, 324);
            this.rbInActif.Name = "rbInActif";
            this.rbInActif.Size = new System.Drawing.Size(80, 20);
            this.rbInActif.TabIndex = 9;
            this.rbInActif.Text = "Pas Actif";
            this.rbInActif.UseVisualStyleBackColor = true;
            // 
            // rbActif
            // 
            this.rbActif.AutoSize = true;
            this.rbActif.Checked = true;
            this.rbActif.Location = new System.Drawing.Point(680, 324);
            this.rbActif.Name = "rbActif";
            this.rbActif.Size = new System.Drawing.Size(53, 20);
            this.rbActif.TabIndex = 10;
            this.rbActif.TabStop = true;
            this.rbActif.Text = "Actif";
            this.rbActif.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(28, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(391, 37);
            this.lblTitle.TabIndex = 11;
            this.lblTitle.Text = "👤 AJOUTER UNE PERSONNE";
            // 
            // ucAbonnementInfo1
            // 
            this.ucAbonnementInfo1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucAbonnementInfo1.IsUpdateMode = false;
            this.ucAbonnementInfo1.Location = new System.Drawing.Point(24, 367);
            this.ucAbonnementInfo1.Name = "ucAbonnementInfo1";
            this.ucAbonnementInfo1.Size = new System.Drawing.Size(1363, 301);
            this.ucAbonnementInfo1.TabIndex = 1;
            // 
            // ucPersonCardWithFilter1
            // 
            this.ucPersonCardWithFilter1.AutoSize = true;
            this.ucPersonCardWithFilter1.FilterEnabled = true;
            this.ucPersonCardWithFilter1.Location = new System.Drawing.Point(24, 33);
            this.ucPersonCardWithFilter1.Name = "ucPersonCardWithFilter1";
            this.ucPersonCardWithFilter1.ShowAddPerson = true;
            this.ucPersonCardWithFilter1.Size = new System.Drawing.Size(1105, 328);
            this.ucPersonCardWithFilter1.TabIndex = 0;
            // 
            // frmAddUpdateMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1739, 716);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.rbActif);
            this.Controls.Add(this.rbInActif);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.ucAbonnementInfo1);
            this.Controls.Add(this.ucPersonCardWithFilter1);
            this.Name = "frmAddUpdateMember";
            this.Text = "frmAddUpdateMember";
            this.Load += new System.EventHandler(this.frmAddUpdateMember_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Personnes.Controls.ucPersonCardWithFilter ucPersonCardWithFilter1;
        private Abonnements.Control.ucAbonnementInfo ucAbonnementInfo1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RadioButton rbInActif;
        private System.Windows.Forms.RadioButton rbActif;
        private System.Windows.Forms.Label lblTitle;
    }
}