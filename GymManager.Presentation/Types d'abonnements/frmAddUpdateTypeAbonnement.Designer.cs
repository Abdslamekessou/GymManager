namespace GymManager.Presentation.Types_d_abonnements
{
    partial class frmAddUpdateTypeAbonnement
    {
        /// 
        /// Required designer variable.
        /// 
        private System.ComponentModel.IContainer components = null;

        /// 
        /// Clean up any resources being used.
        /// 
        /// true if managed resources should be disposed; otherwise, false.
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// 
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// 
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblSport = new System.Windows.Forms.Label();
            this.cbSport = new System.Windows.Forms.ComboBox();
            this.lblDuree = new System.Windows.Forms.Label();
            this.txtDureeEnJour = new System.Windows.Forms.TextBox();
            this.lblPrix = new System.Windows.Forms.Label();
            this.txtPrix = new System.Windows.Forms.TextBox();
            this.lblDA = new System.Windows.Forms.Label();
            this.lblTypeSeances = new System.Windows.Forms.Label();
            this.rbLimite = new System.Windows.Forms.RadioButton();
            this.rbIllimite = new System.Windows.Forms.RadioButton();
            this.lblNombreSeances = new System.Windows.Forms.Label();
            this.txtNombreDeSeances = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblStatut = new System.Windows.Forms.Label();
            this.cbStatut = new System.Windows.Forms.ComboBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.lblNom);
            this.gbInfo.Controls.Add(this.txtNom);
            this.gbInfo.Controls.Add(this.lblSport);
            this.gbInfo.Controls.Add(this.cbSport);
            this.gbInfo.Controls.Add(this.lblDuree);
            this.gbInfo.Controls.Add(this.txtDureeEnJour);
            this.gbInfo.Controls.Add(this.lblPrix);
            this.gbInfo.Controls.Add(this.txtPrix);
            this.gbInfo.Controls.Add(this.lblDA);
            this.gbInfo.Controls.Add(this.lblTypeSeances);
            this.gbInfo.Controls.Add(this.rbLimite);
            this.gbInfo.Controls.Add(this.rbIllimite);
            this.gbInfo.Controls.Add(this.lblNombreSeances);
            this.gbInfo.Controls.Add(this.txtNombreDeSeances);
            this.gbInfo.Controls.Add(this.lblDescription);
            this.gbInfo.Controls.Add(this.txtDescription);
            this.gbInfo.Controls.Add(this.lblStatut);
            this.gbInfo.Controls.Add(this.cbStatut);
            this.gbInfo.Controls.Add(this.btnAnnuler);
            this.gbInfo.Controls.Add(this.btnEnregistrer);
            this.gbInfo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInfo.Location = new System.Drawing.Point(18, 18);
            this.gbInfo.Margin = new System.Windows.Forms.Padding(4);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Padding = new System.Windows.Forms.Padding(4);
            this.gbInfo.Size = new System.Drawing.Size(1140, 614);
            this.gbInfo.TabIndex = 0;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "INFORMATIONS DU TYPE D\'ABONNEMENT";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(30, 51);
            this.lblNom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(65, 28);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Nom :";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(270, 47);
            this.txtNom.Margin = new System.Windows.Forms.Padding(4);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(823, 34);
            this.txtNom.TabIndex = 1;
            this.txtNom.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateEmptyTextBox);
            // 
            // lblSport
            // 
            this.lblSport.AutoSize = true;
            this.lblSport.Location = new System.Drawing.Point(30, 102);
            this.lblSport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSport.Name = "lblSport";
            this.lblSport.Size = new System.Drawing.Size(70, 28);
            this.lblSport.TabIndex = 2;
            this.lblSport.Text = "Sport :";
            // 
            // cbSport
            // 
            this.cbSport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSport.FormattingEnabled = true;
            this.cbSport.Location = new System.Drawing.Point(270, 98);
            this.cbSport.Margin = new System.Windows.Forms.Padding(4);
            this.cbSport.Name = "cbSport";
            this.cbSport.Size = new System.Drawing.Size(268, 36);
            this.cbSport.TabIndex = 3;
            // 
            // lblDuree
            // 
            this.lblDuree.AutoSize = true;
            this.lblDuree.Location = new System.Drawing.Point(30, 153);
            this.lblDuree.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDuree.Name = "lblDuree";
            this.lblDuree.Size = new System.Drawing.Size(133, 28);
            this.lblDuree.TabIndex = 4;
            this.lblDuree.Text = "Durée (jours) :";
            // 
            // txtDureeEnJour
            // 
            this.txtDureeEnJour.Location = new System.Drawing.Point(270, 149);
            this.txtDureeEnJour.Margin = new System.Windows.Forms.Padding(4);
            this.txtDureeEnJour.Name = "txtDureeEnJour";
            this.txtDureeEnJour.Size = new System.Drawing.Size(126, 34);
            this.txtDureeEnJour.TabIndex = 5;
            this.txtDureeEnJour.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressNumber);
            this.txtDureeEnJour.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateEmptyTextBox);
            // 
            // lblPrix
            // 
            this.lblPrix.AutoSize = true;
            this.lblPrix.Location = new System.Drawing.Point(30, 205);
            this.lblPrix.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrix.Name = "lblPrix";
            this.lblPrix.Size = new System.Drawing.Size(53, 28);
            this.lblPrix.TabIndex = 6;
            this.lblPrix.Text = "Prix :";
            // 
            // txtPrix
            // 
            this.txtPrix.Location = new System.Drawing.Point(270, 200);
            this.txtPrix.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrix.Name = "txtPrix";
            this.txtPrix.Size = new System.Drawing.Size(126, 34);
            this.txtPrix.TabIndex = 7;
            this.txtPrix.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressNumber);
            this.txtPrix.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateEmptyTextBox);
            // 
            // lblDA
            // 
            this.lblDA.AutoSize = true;
            this.lblDA.Location = new System.Drawing.Point(408, 205);
            this.lblDA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDA.Name = "lblDA";
            this.lblDA.Size = new System.Drawing.Size(54, 28);
            this.lblDA.TabIndex = 8;
            this.lblDA.Text = "DA »";
            // 
            // lblTypeSeances
            // 
            this.lblTypeSeances.AutoSize = true;
            this.lblTypeSeances.Location = new System.Drawing.Point(30, 256);
            this.lblTypeSeances.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTypeSeances.Name = "lblTypeSeances";
            this.lblTypeSeances.Size = new System.Drawing.Size(160, 28);
            this.lblTypeSeances.TabIndex = 9;
            this.lblTypeSeances.Text = "Type de séances :";
            // 
            // rbLimite
            // 
            this.rbLimite.AutoSize = true;
            this.rbLimite.Checked = true;
            this.rbLimite.Location = new System.Drawing.Point(270, 253);
            this.rbLimite.Margin = new System.Windows.Forms.Padding(4);
            this.rbLimite.Name = "rbLimite";
            this.rbLimite.Size = new System.Drawing.Size(90, 32);
            this.rbLimite.TabIndex = 10;
            this.rbLimite.TabStop = true;
            this.rbLimite.Text = "Limité";
            this.rbLimite.UseVisualStyleBackColor = true;
            this.rbLimite.CheckedChanged += new System.EventHandler(this.rbLimite_CheckedChanged);
            // 
            // rbIllimite
            // 
            this.rbIllimite.AutoSize = true;
            this.rbIllimite.Location = new System.Drawing.Point(398, 253);
            this.rbIllimite.Margin = new System.Windows.Forms.Padding(4);
            this.rbIllimite.Name = "rbIllimite";
            this.rbIllimite.Size = new System.Drawing.Size(96, 32);
            this.rbIllimite.TabIndex = 11;
            this.rbIllimite.Text = "Illimité";
            this.rbIllimite.UseVisualStyleBackColor = true;
            this.rbIllimite.CheckedChanged += new System.EventHandler(this.rbIllimite_CheckedChanged);
            // 
            // lblNombreSeances
            // 
            this.lblNombreSeances.AutoSize = true;
            this.lblNombreSeances.Location = new System.Drawing.Point(30, 307);
            this.lblNombreSeances.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreSeances.Name = "lblNombreSeances";
            this.lblNombreSeances.Size = new System.Drawing.Size(192, 28);
            this.lblNombreSeances.TabIndex = 12;
            this.lblNombreSeances.Text = "Nombre de séances :";
            // 
            // txtNombreDeSeances
            // 
            this.txtNombreDeSeances.Location = new System.Drawing.Point(270, 303);
            this.txtNombreDeSeances.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreDeSeances.Name = "txtNombreDeSeances";
            this.txtNombreDeSeances.Size = new System.Drawing.Size(126, 34);
            this.txtNombreDeSeances.TabIndex = 13;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(30, 358);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(121, 28);
            this.lblDescription.TabIndex = 14;
            this.lblDescription.Text = "Description :";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(270, 354);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(823, 115);
            this.txtDescription.TabIndex = 15;
            // 
            // lblStatut
            // 
            this.lblStatut.AutoSize = true;
            this.lblStatut.Location = new System.Drawing.Point(30, 490);
            this.lblStatut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatut.Name = "lblStatut";
            this.lblStatut.Size = new System.Drawing.Size(73, 28);
            this.lblStatut.TabIndex = 16;
            this.lblStatut.Text = "Statut :";
            // 
            // cbStatut
            // 
            this.cbStatut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatut.FormattingEnabled = true;
            this.cbStatut.Items.AddRange(new object[] {
            "Actif",
            "InActif"});
            this.cbStatut.Location = new System.Drawing.Point(270, 485);
            this.cbStatut.Margin = new System.Windows.Forms.Padding(4);
            this.cbStatut.Name = "cbStatut";
            this.cbStatut.Size = new System.Drawing.Size(208, 36);
            this.cbStatut.TabIndex = 17;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(788, 541);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(150, 47);
            this.btnAnnuler.TabIndex = 18;
            this.btnAnnuler.Text = "[ Annuler ]";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(945, 541);
            this.btnEnregistrer.Margin = new System.Windows.Forms.Padding(4);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(150, 47);
            this.btnEnregistrer.TabIndex = 19;
            this.btnEnregistrer.Text = "[ Enregistrer ]";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAddUpdateTypeAbonnement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1176, 649);
            this.Controls.Add(this.gbInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmAddUpdateTypeAbonnement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajouter un type d\'abonnement";
            this.Load += new System.EventHandler(this.frmAddUpdateTypeAbonnement_Load);
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblSport;
        private System.Windows.Forms.ComboBox cbSport;
        private System.Windows.Forms.Label lblDuree;
        private System.Windows.Forms.TextBox txtDureeEnJour;
        private System.Windows.Forms.Label lblPrix;
        private System.Windows.Forms.TextBox txtPrix;
        private System.Windows.Forms.Label lblDA;
        private System.Windows.Forms.Label lblTypeSeances;
        private System.Windows.Forms.RadioButton rbLimite;
        private System.Windows.Forms.RadioButton rbIllimite;
        private System.Windows.Forms.Label lblNombreSeances;
        private System.Windows.Forms.TextBox txtNombreDeSeances;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblStatut;
        private System.Windows.Forms.ComboBox cbStatut;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}