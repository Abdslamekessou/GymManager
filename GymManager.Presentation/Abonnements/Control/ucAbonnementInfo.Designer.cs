
namespace GymManager.Presentation.Abonnements.Control
{
    partial class ucAbonnementInfo
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

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
            this.gbInfoAbonnement.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.gbInfoAbonnement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(26)))), ((int)(((byte)(45)))));
            this.gbInfoAbonnement.Location = new System.Drawing.Point(0, 0);
            this.gbInfoAbonnement.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbInfoAbonnement.Name = "gbInfoAbonnement";
            this.gbInfoAbonnement.Padding = new System.Windows.Forms.Padding(27, 21, 27, 18);
            this.gbInfoAbonnement.Size = new System.Drawing.Size(1398, 341);
            this.gbInfoAbonnement.TabIndex = 0;
            this.gbInfoAbonnement.TabStop = false;
            this.gbInfoAbonnement.Text = "  INFORMATIONS DE L\'ABONNEMENT";
            this.gbInfoAbonnement.Enter += new System.EventHandler(this.gbInfoAbonnement_Enter);
            // 
            // lblTypeAbonnement
            // 
            this.lblTypeAbonnement.AutoSize = true;
            this.lblTypeAbonnement.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeAbonnement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblTypeAbonnement.Location = new System.Drawing.Point(33, 64);
            this.lblTypeAbonnement.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTypeAbonnement.Name = "lblTypeAbonnement";
            this.lblTypeAbonnement.Size = new System.Drawing.Size(195, 28);
            this.lblTypeAbonnement.TabIndex = 0;
            this.lblTypeAbonnement.Text = "Type d\'abonnement";
            // 
            // cbTypeAbonnement
            // 
            this.cbTypeAbonnement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTypeAbonnement.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTypeAbonnement.FormattingEnabled = true;
            this.cbTypeAbonnement.Location = new System.Drawing.Point(248, 65);
            this.cbTypeAbonnement.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbTypeAbonnement.Name = "cbTypeAbonnement";
            this.cbTypeAbonnement.Size = new System.Drawing.Size(320, 36);
            this.cbTypeAbonnement.TabIndex = 1;
            this.cbTypeAbonnement.SelectedIndexChanged += new System.EventHandler(this.cbTypeAbonnement_SelectedIndexChanged);
            // 
            // lblDateDebut
            // 
            this.lblDateDebut.AutoSize = true;
            this.lblDateDebut.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateDebut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblDateDebut.Location = new System.Drawing.Point(33, 129);
            this.lblDateDebut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateDebut.Name = "lblDateDebut";
            this.lblDateDebut.Size = new System.Drawing.Size(143, 28);
            this.lblDateDebut.TabIndex = 2;
            this.lblDateDebut.Text = "Date de début";
            // 
            // dtpDateDebut
            // 
            this.dtpDateDebut.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateDebut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateDebut.Location = new System.Drawing.Point(248, 130);
            this.dtpDateDebut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpDateDebut.Name = "dtpDateDebut";
            this.dtpDateDebut.Size = new System.Drawing.Size(320, 34);
            this.dtpDateDebut.TabIndex = 3;
            this.dtpDateDebut.ValueChanged += new System.EventHandler(this.dtpDateDebut_ValueChanged);
            // 
            // lblPrixPaye
            // 
            this.lblPrixPaye.AutoSize = true;
            this.lblPrixPaye.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrixPaye.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblPrixPaye.Location = new System.Drawing.Point(33, 194);
            this.lblPrixPaye.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrixPaye.Name = "lblPrixPaye";
            this.lblPrixPaye.Size = new System.Drawing.Size(95, 28);
            this.lblPrixPaye.TabIndex = 4;
            this.lblPrixPaye.Text = "Prix payé";
            // 
            // txtPrixPaye
            // 
            this.txtPrixPaye.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.txtPrixPaye.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrixPaye.Enabled = false;
            this.txtPrixPaye.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrixPaye.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.txtPrixPaye.Location = new System.Drawing.Point(248, 196);
            this.txtPrixPaye.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrixPaye.Name = "txtPrixPaye";
            this.txtPrixPaye.Size = new System.Drawing.Size(262, 34);
            this.txtPrixPaye.TabIndex = 5;
            // 
            // lblDevise
            // 
            this.lblDevise.AutoSize = true;
            this.lblDevise.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDevise.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblDevise.Location = new System.Drawing.Point(518, 202);
            this.lblDevise.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDevise.Name = "lblDevise";
            this.lblDevise.Size = new System.Drawing.Size(38, 25);
            this.lblDevise.TabIndex = 6;
            this.lblDevise.Text = "DA";
            // 
            // lblStatut
            // 
            this.lblStatut.AutoSize = true;
            this.lblStatut.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblStatut.Location = new System.Drawing.Point(33, 258);
            this.lblStatut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatut.Name = "lblStatut";
            this.lblStatut.Size = new System.Drawing.Size(65, 28);
            this.lblStatut.TabIndex = 7;
            this.lblStatut.Text = "Statut";
            // 
            // cbStatut
            // 
            this.cbStatut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatut.Enabled = false;
            this.cbStatut.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatut.FormattingEnabled = true;
            this.cbStatut.Items.AddRange(new object[] {
            "Actif",
            "Inactif"});
            this.cbStatut.Location = new System.Drawing.Point(248, 258);
            this.cbStatut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbStatut.Name = "cbStatut";
            this.cbStatut.Size = new System.Drawing.Size(320, 36);
            this.cbStatut.TabIndex = 8;
            // 
            // lblSport
            // 
            this.lblSport.AutoSize = true;
            this.lblSport.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblSport.Location = new System.Drawing.Point(630, 64);
            this.lblSport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSport.Name = "lblSport";
            this.lblSport.Size = new System.Drawing.Size(62, 28);
            this.lblSport.TabIndex = 9;
            this.lblSport.Text = "Sport";
            // 
            // txtSport
            // 
            this.txtSport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.txtSport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSport.Enabled = false;
            this.txtSport.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.txtSport.Location = new System.Drawing.Point(854, 67);
            this.txtSport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSport.Name = "txtSport";
            this.txtSport.ReadOnly = true;
            this.txtSport.Size = new System.Drawing.Size(299, 34);
            this.txtSport.TabIndex = 10;
            // 
            // lblSportReadOnly
            // 
            this.lblSportReadOnly.AutoSize = true;
            this.lblSportReadOnly.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblSportReadOnly.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblSportReadOnly.Location = new System.Drawing.Point(1169, 73);
            this.lblSportReadOnly.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSportReadOnly.Name = "lblSportReadOnly";
            this.lblSportReadOnly.Size = new System.Drawing.Size(101, 21);
            this.lblSportReadOnly.TabIndex = 11;
            this.lblSportReadOnly.Text = "Lecture seule";
            // 
            // lblDateFin
            // 
            this.lblDateFin.AutoSize = true;
            this.lblDateFin.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateFin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblDateFin.Location = new System.Drawing.Point(630, 129);
            this.lblDateFin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateFin.Name = "lblDateFin";
            this.lblDateFin.Size = new System.Drawing.Size(113, 28);
            this.lblDateFin.TabIndex = 12;
            this.lblDateFin.Text = "Date de fin";
            // 
            // dtpDateFin
            // 
            this.dtpDateFin.Enabled = false;
            this.dtpDateFin.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateFin.Location = new System.Drawing.Point(854, 132);
            this.dtpDateFin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpDateFin.Name = "dtpDateFin";
            this.dtpDateFin.Size = new System.Drawing.Size(298, 34);
            this.dtpDateFin.TabIndex = 13;
            // 
            // lblDateFinAutomatique
            // 
            this.lblDateFinAutomatique.AutoSize = true;
            this.lblDateFinAutomatique.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblDateFinAutomatique.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblDateFinAutomatique.Location = new System.Drawing.Point(1169, 138);
            this.lblDateFinAutomatique.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateFinAutomatique.Name = "lblDateFinAutomatique";
            this.lblDateFinAutomatique.Size = new System.Drawing.Size(100, 21);
            this.lblDateFinAutomatique.TabIndex = 14;
            this.lblDateFinAutomatique.Text = "Automatique";
            // 
            // lblNombreSeances
            // 
            this.lblNombreSeances.AutoSize = true;
            this.lblNombreSeances.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreSeances.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblNombreSeances.Location = new System.Drawing.Point(630, 194);
            this.lblNombreSeances.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreSeances.Name = "lblNombreSeances";
            this.lblNombreSeances.Size = new System.Drawing.Size(193, 28);
            this.lblNombreSeances.TabIndex = 15;
            this.lblNombreSeances.Text = "Nombre de séances";
            // 
            // txtNombreSeances
            // 
            this.txtNombreSeances.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.txtNombreSeances.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreSeances.Enabled = false;
            this.txtNombreSeances.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreSeances.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.txtNombreSeances.Location = new System.Drawing.Point(854, 198);
            this.txtNombreSeances.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombreSeances.Name = "txtNombreSeances";
            this.txtNombreSeances.ReadOnly = true;
            this.txtNombreSeances.Size = new System.Drawing.Size(299, 34);
            this.txtNombreSeances.TabIndex = 16;
            // 
            // lblSeancesReadOnly
            // 
            this.lblSeancesReadOnly.AutoSize = true;
            this.lblSeancesReadOnly.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblSeancesReadOnly.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblSeancesReadOnly.Location = new System.Drawing.Point(1169, 204);
            this.lblSeancesReadOnly.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSeancesReadOnly.Name = "lblSeancesReadOnly";
            this.lblSeancesReadOnly.Size = new System.Drawing.Size(101, 21);
            this.lblSeancesReadOnly.TabIndex = 17;
            this.lblSeancesReadOnly.Text = "Lecture seule";
            // 
            // ucAbonnementInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.Controls.Add(this.gbInfoAbonnement);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ucAbonnementInfo";
            this.Size = new System.Drawing.Size(1398, 341);
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
