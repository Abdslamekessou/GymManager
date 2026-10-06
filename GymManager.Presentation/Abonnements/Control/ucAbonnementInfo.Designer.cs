namespace GymManager.Presentation.Abonnements.Control
{
    partial class ucAbonnementInfo
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

        #region Component Designer generated code

        ///  
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// 
        private void InitializeComponent()
        {
            this.gbInfoAbonnement = new System.Windows.Forms.GroupBox();
            this.lblTypeAbonnement = new System.Windows.Forms.Label();
            this.cbTypeAbonnement = new System.Windows.Forms.ComboBox();
            this.lblDateDebut = new System.Windows.Forms.Label();
            this.dtpDateDebut = new System.Windows.Forms.DateTimePicker();
            this.lblPrixPaye = new System.Windows.Forms.Label();
            this.txtPrixPaye = new System.Windows.Forms.TextBox();
            this.lblDevise = new System.Windows.Forms.Label();
            this.lblStatut = new System.Windows.Forms.Label();
            this.cbStatut = new System.Windows.Forms.ComboBox();
            this.lblSport = new System.Windows.Forms.Label();
            this.txtSport = new System.Windows.Forms.TextBox();
            this.lblSportReadOnly = new System.Windows.Forms.Label();
            this.lblDateFin = new System.Windows.Forms.Label();
            this.dtpDateFin = new System.Windows.Forms.DateTimePicker();
            this.lblDateFinAutomatique = new System.Windows.Forms.Label();
            this.lblNombreSeances = new System.Windows.Forms.Label();
            this.txtNombreSeances = new System.Windows.Forms.TextBox();
            this.lblSeancesReadOnly = new System.Windows.Forms.Label();
            this.gbInfoAbonnement.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbInfoAbonnement
            // 
            this.gbInfoAbonnement.BackColor = System.Drawing.Color.White;
            this.gbInfoAbonnement.Controls.Add(this.lblTypeAbonnement);
            this.gbInfoAbonnement.Controls.Add(this.cbTypeAbonnement);
            this.gbInfoAbonnement.Controls.Add(this.lblDateDebut);
            this.gbInfoAbonnement.Controls.Add(this.dtpDateDebut);
            this.gbInfoAbonnement.Controls.Add(this.lblPrixPaye);
            this.gbInfoAbonnement.Controls.Add(this.txtPrixPaye);
            this.gbInfoAbonnement.Controls.Add(this.lblDevise);
            this.gbInfoAbonnement.Controls.Add(this.lblStatut);
            this.gbInfoAbonnement.Controls.Add(this.cbStatut);
            this.gbInfoAbonnement.Controls.Add(this.lblSport);
            this.gbInfoAbonnement.Controls.Add(this.txtSport);
            this.gbInfoAbonnement.Controls.Add(this.lblSportReadOnly);
            this.gbInfoAbonnement.Controls.Add(this.lblDateFin);
            this.gbInfoAbonnement.Controls.Add(this.dtpDateFin);
            this.gbInfoAbonnement.Controls.Add(this.lblDateFinAutomatique);
            this.gbInfoAbonnement.Controls.Add(this.lblNombreSeances);
            this.gbInfoAbonnement.Controls.Add(this.txtNombreSeances);
            this.gbInfoAbonnement.Controls.Add(this.lblSeancesReadOnly);
            this.gbInfoAbonnement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbInfoAbonnement.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInfoAbonnement.Location = new System.Drawing.Point(0, 0);
            this.gbInfoAbonnement.Name = "gbInfoAbonnement";
            this.gbInfoAbonnement.Size = new System.Drawing.Size(900, 200);
            this.gbInfoAbonnement.TabIndex = 0;
            this.gbInfoAbonnement.TabStop = false;
            this.gbInfoAbonnement.Text = "INFORMATIONS DE L\'ABONNEMENT";
            // 
            // lblTypeAbonnement
            // 
            this.lblTypeAbonnement.AutoSize = true;
            this.lblTypeAbonnement.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeAbonnement.Location = new System.Drawing.Point(20, 35);
            this.lblTypeAbonnement.Name = "lblTypeAbonnement";
            this.lblTypeAbonnement.Size = new System.Drawing.Size(195, 28);
            this.lblTypeAbonnement.TabIndex = 0;
            this.lblTypeAbonnement.Text = "Type d\'abonnement :";
            // 
            // cbTypeAbonnement
            // 
            this.cbTypeAbonnement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTypeAbonnement.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTypeAbonnement.FormattingEnabled = true;
            this.cbTypeAbonnement.Location = new System.Drawing.Point(160, 32);
            this.cbTypeAbonnement.Name = "cbTypeAbonnement";
            this.cbTypeAbonnement.Size = new System.Drawing.Size(200, 36);
            this.cbTypeAbonnement.TabIndex = 1;
            this.cbTypeAbonnement.SelectedIndexChanged += new System.EventHandler(this.cbTypeAbonnement_SelectedIndexChanged);
            // 
            // lblDateDebut
            // 
            this.lblDateDebut.AutoSize = true;
            this.lblDateDebut.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateDebut.Location = new System.Drawing.Point(20, 75);
            this.lblDateDebut.Name = "lblDateDebut";
            this.lblDateDebut.Size = new System.Drawing.Size(146, 28);
            this.lblDateDebut.TabIndex = 2;
            this.lblDateDebut.Text = "Date de début :";
            // 
            // dtpDateDebut
            // 
            this.dtpDateDebut.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateDebut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateDebut.Location = new System.Drawing.Point(160, 72);
            this.dtpDateDebut.Name = "dtpDateDebut";
            this.dtpDateDebut.Size = new System.Drawing.Size(200, 33);
            this.dtpDateDebut.TabIndex = 3;
            this.dtpDateDebut.ValueChanged += new System.EventHandler(this.dtpDateDebut_ValueChanged);
            // 
            // lblPrixPaye
            // 
            this.lblPrixPaye.AutoSize = true;
            this.lblPrixPaye.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrixPaye.Location = new System.Drawing.Point(20, 115);
            this.lblPrixPaye.Name = "lblPrixPaye";
            this.lblPrixPaye.Size = new System.Drawing.Size(100, 28);
            this.lblPrixPaye.TabIndex = 4;
            this.lblPrixPaye.Text = "Prix payé :";
            // 
            // txtPrixPaye
            // 
            this.txtPrixPaye.Enabled = false;
            this.txtPrixPaye.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrixPaye.Location = new System.Drawing.Point(160, 112);
            this.txtPrixPaye.Name = "txtPrixPaye";
            this.txtPrixPaye.Size = new System.Drawing.Size(160, 33);
            this.txtPrixPaye.TabIndex = 5;
            // 
            // lblDevise
            // 
            this.lblDevise.AutoSize = true;
            this.lblDevise.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDevise.Location = new System.Drawing.Point(328, 115);
            this.lblDevise.Name = "lblDevise";
            this.lblDevise.Size = new System.Drawing.Size(39, 28);
            this.lblDevise.TabIndex = 6;
            this.lblDevise.Text = "DA";
            // 
            // lblStatut
            // 
            this.lblStatut.AutoSize = true;
            this.lblStatut.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatut.Location = new System.Drawing.Point(20, 155);
            this.lblStatut.Name = "lblStatut";
            this.lblStatut.Size = new System.Drawing.Size(73, 28);
            this.lblStatut.TabIndex = 7;
            this.lblStatut.Text = "Statut :";
            // 
            // cbStatut
            // 
            this.cbStatut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatut.Enabled = false;
            this.cbStatut.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatut.FormattingEnabled = true;
            this.cbStatut.Items.AddRange(new object[] {
            "Actif",
            "Inactif"});
            this.cbStatut.Location = new System.Drawing.Point(160, 152);
            this.cbStatut.Name = "cbStatut";
            this.cbStatut.Size = new System.Drawing.Size(200, 36);
            this.cbStatut.TabIndex = 8;
            // 
            // lblSport
            // 
            this.lblSport.AutoSize = true;
            this.lblSport.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSport.Location = new System.Drawing.Point(420, 35);
            this.lblSport.Name = "lblSport";
            this.lblSport.Size = new System.Drawing.Size(70, 28);
            this.lblSport.TabIndex = 9;
            this.lblSport.Text = "Sport :";
            // 
            // txtSport
            // 
            this.txtSport.Enabled = false;
            this.txtSport.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSport.Location = new System.Drawing.Point(570, 32);
            this.txtSport.Name = "txtSport";
            this.txtSport.ReadOnly = true;
            this.txtSport.Size = new System.Drawing.Size(200, 33);
            this.txtSport.TabIndex = 10;
            // 
            // lblSportReadOnly
            // 
            this.lblSportReadOnly.AutoSize = true;
            this.lblSportReadOnly.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSportReadOnly.Location = new System.Drawing.Point(780, 37);
            this.lblSportReadOnly.Name = "lblSportReadOnly";
            this.lblSportReadOnly.Size = new System.Drawing.Size(113, 25);
            this.lblSportReadOnly.TabIndex = 11;
            this.lblSportReadOnly.Text = "Lecture seule";
            // 
            // lblDateFin
            // 
            this.lblDateFin.AutoSize = true;
            this.lblDateFin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateFin.Location = new System.Drawing.Point(420, 75);
            this.lblDateFin.Name = "lblDateFin";
            this.lblDateFin.Size = new System.Drawing.Size(116, 28);
            this.lblDateFin.TabIndex = 12;
            this.lblDateFin.Text = "Date de fin :";
            // 
            // dtpDateFin
            // 
            this.dtpDateFin.Enabled = false;
            this.dtpDateFin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateFin.Location = new System.Drawing.Point(570, 72);
            this.dtpDateFin.Name = "dtpDateFin";
            this.dtpDateFin.Size = new System.Drawing.Size(200, 33);
            this.dtpDateFin.TabIndex = 13;
            // 
            // lblDateFinAutomatique
            // 
            this.lblDateFinAutomatique.AutoSize = true;
            this.lblDateFinAutomatique.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateFinAutomatique.Location = new System.Drawing.Point(780, 77);
            this.lblDateFinAutomatique.Name = "lblDateFinAutomatique";
            this.lblDateFinAutomatique.Size = new System.Drawing.Size(116, 25);
            this.lblDateFinAutomatique.TabIndex = 14;
            this.lblDateFinAutomatique.Text = "Automatique";
            // 
            // lblNombreSeances
            // 
            this.lblNombreSeances.AutoSize = true;
            this.lblNombreSeances.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreSeances.Location = new System.Drawing.Point(420, 115);
            this.lblNombreSeances.Name = "lblNombreSeances";
            this.lblNombreSeances.Size = new System.Drawing.Size(192, 28);
            this.lblNombreSeances.TabIndex = 15;
            this.lblNombreSeances.Text = "Nombre de séances :";
            // 
            // txtNombreSeances
            // 
            this.txtNombreSeances.Enabled = false;
            this.txtNombreSeances.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreSeances.Location = new System.Drawing.Point(570, 112);
            this.txtNombreSeances.Name = "txtNombreSeances";
            this.txtNombreSeances.ReadOnly = true;
            this.txtNombreSeances.Size = new System.Drawing.Size(200, 33);
            this.txtNombreSeances.TabIndex = 16;
            // 
            // lblSeancesReadOnly
            // 
            this.lblSeancesReadOnly.AutoSize = true;
            this.lblSeancesReadOnly.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeancesReadOnly.Location = new System.Drawing.Point(780, 117);
            this.lblSeancesReadOnly.Name = "lblSeancesReadOnly";
            this.lblSeancesReadOnly.Size = new System.Drawing.Size(113, 25);
            this.lblSeancesReadOnly.TabIndex = 17;
            this.lblSeancesReadOnly.Text = "Lecture seule";
            // 
            // ucAbonnementInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbInfoAbonnement);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ucAbonnementInfo";
            this.Size = new System.Drawing.Size(900, 200);
            this.Load += new System.EventHandler(this.ucAbonnementInfo_Load);
            this.gbInfoAbonnement.ResumeLayout(false);
            this.gbInfoAbonnement.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbInfoAbonnement;
        private System.Windows.Forms.Label lblTypeAbonnement;
        private System.Windows.Forms.ComboBox cbTypeAbonnement;
        private System.Windows.Forms.Label lblDateDebut;
        private System.Windows.Forms.DateTimePicker dtpDateDebut;
        private System.Windows.Forms.Label lblPrixPaye;
        private System.Windows.Forms.TextBox txtPrixPaye;
        private System.Windows.Forms.Label lblDevise;
        private System.Windows.Forms.Label lblStatut;
        private System.Windows.Forms.ComboBox cbStatut;
        private System.Windows.Forms.Label lblSport;
        private System.Windows.Forms.TextBox txtSport;
        private System.Windows.Forms.Label lblSportReadOnly;
        private System.Windows.Forms.Label lblDateFin;
        private System.Windows.Forms.DateTimePicker dtpDateFin;
        private System.Windows.Forms.Label lblDateFinAutomatique;
        private System.Windows.Forms.Label lblNombreSeances;
        private System.Windows.Forms.TextBox txtNombreSeances;
        private System.Windows.Forms.Label lblSeancesReadOnly;
    }
}