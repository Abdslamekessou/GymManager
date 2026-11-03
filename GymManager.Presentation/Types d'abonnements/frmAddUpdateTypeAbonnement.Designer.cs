
namespace GymManager.Presentation.Types_d_abonnements
{
    partial class frmAddUpdateTypeAbonnement
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

        #region Windows Form Designer generated code

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
            this.gbInfo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gbInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.gbInfo.Location = new System.Drawing.Point(18, 18);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(1140, 646);
            this.gbInfo.TabIndex = 0;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "INFORMATIONS DU TYPE D\'ABONNEMENT";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.lblNom.Location = new System.Drawing.Point(30, 52);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(79, 32);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Nom :";
            // 
            // txtNom
            // 
            this.txtNom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNom.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNom.Location = new System.Drawing.Point(270, 48);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(350, 37);
            this.txtNom.TabIndex = 1;
            this.txtNom.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateEmptyTextBox);
            // 
            // lblSport
            // 
            this.lblSport.AutoSize = true;
            this.lblSport.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSport.Location = new System.Drawing.Point(30, 112);
            this.lblSport.Name = "lblSport";
            this.lblSport.Size = new System.Drawing.Size(83, 32);
            this.lblSport.TabIndex = 2;
            this.lblSport.Text = "Sport :";
            // 
            // cbSport
            // 
            this.cbSport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSport.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSport.FormattingEnabled = true;
            this.cbSport.Location = new System.Drawing.Point(270, 108);
            this.cbSport.Name = "cbSport";
            this.cbSport.Size = new System.Drawing.Size(350, 40);
            this.cbSport.TabIndex = 3;
            this.cbSport.SelectedIndexChanged += new System.EventHandler(this.cbSport_SelectedIndexChanged);
            // 
            // lblDuree
            // 
            this.lblDuree.AutoSize = true;
            this.lblDuree.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuree.Location = new System.Drawing.Point(30, 172);
            this.lblDuree.Name = "lblDuree";
            this.lblDuree.Size = new System.Drawing.Size(164, 32);
            this.lblDuree.TabIndex = 4;
            this.lblDuree.Text = "Durée (jours) :";
            // 
            // txtDureeEnJour
            // 
            this.txtDureeEnJour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDureeEnJour.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDureeEnJour.Location = new System.Drawing.Point(270, 170);
            this.txtDureeEnJour.Name = "txtDureeEnJour";
            this.txtDureeEnJour.Size = new System.Drawing.Size(150, 37);
            this.txtDureeEnJour.TabIndex = 5;
            this.txtDureeEnJour.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressNumber);
            this.txtDureeEnJour.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateEmptyTextBox);
            // 
            // lblPrix
            // 
            this.lblPrix.AutoSize = true;
            this.lblPrix.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrix.Location = new System.Drawing.Point(570, 172);
            this.lblPrix.Name = "lblPrix";
            this.lblPrix.Size = new System.Drawing.Size(64, 32);
            this.lblPrix.TabIndex = 6;
            this.lblPrix.Text = "Prix :";
            // 
            // txtPrix
            // 
            this.txtPrix.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrix.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrix.Location = new System.Drawing.Point(814, 170);
            this.txtPrix.Name = "txtPrix";
            this.txtPrix.Size = new System.Drawing.Size(150, 37);
            this.txtPrix.TabIndex = 7;
            this.txtPrix.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressNumber);
            this.txtPrix.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateEmptyTextBox);
            // 
            // lblDA
            // 
            this.lblDA.AutoSize = true;
            this.lblDA.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblDA.Location = new System.Drawing.Point(972, 174);
            this.lblDA.Name = "lblDA";
            this.lblDA.Size = new System.Drawing.Size(39, 28);
            this.lblDA.TabIndex = 8;
            this.lblDA.Text = "DA";
            // 
            // lblTypeSeances
            // 
            this.lblTypeSeances.AutoSize = true;
            this.lblTypeSeances.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeSeances.Location = new System.Drawing.Point(30, 232);
            this.lblTypeSeances.Name = "lblTypeSeances";
            this.lblTypeSeances.Size = new System.Drawing.Size(201, 32);
            this.lblTypeSeances.TabIndex = 9;
            this.lblTypeSeances.Text = "Type de séances :";
            // 
            // rbLimite
            // 
            this.rbLimite.AutoSize = true;
            this.rbLimite.Checked = true;
            this.rbLimite.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rbLimite.Location = new System.Drawing.Point(270, 230);
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
            this.rbIllimite.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rbIllimite.Location = new System.Drawing.Point(390, 230);
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
            this.lblNombreSeances.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreSeances.Location = new System.Drawing.Point(570, 232);
            this.lblNombreSeances.Name = "lblNombreSeances";
            this.lblNombreSeances.Size = new System.Drawing.Size(238, 32);
            this.lblNombreSeances.TabIndex = 12;
            this.lblNombreSeances.Text = "Nombre de séances :";
            // 
            // txtNombreDeSeances
            // 
            this.txtNombreDeSeances.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreDeSeances.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreDeSeances.Location = new System.Drawing.Point(814, 232);
            this.txtNombreDeSeances.Name = "txtNombreDeSeances";
            this.txtNombreDeSeances.Size = new System.Drawing.Size(150, 37);
            this.txtNombreDeSeances.TabIndex = 13;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(30, 292);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(147, 32);
            this.lblDescription.TabIndex = 14;
            this.lblDescription.Text = "Description :";
            // 
            // txtDescription
            // 
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(270, 288);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(823, 130);
            this.txtDescription.TabIndex = 15;
            // 
            // lblStatut
            // 
            this.lblStatut.AutoSize = true;
            this.lblStatut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatut.Location = new System.Drawing.Point(30, 458);
            this.lblStatut.Name = "lblStatut";
            this.lblStatut.Size = new System.Drawing.Size(88, 32);
            this.lblStatut.TabIndex = 16;
            this.lblStatut.Text = "Statut :";
            // 
            // cbStatut
            // 
            this.cbStatut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatut.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatut.FormattingEnabled = true;
            this.cbStatut.Items.AddRange(new object[] {
            "Actif",
            "InActif"});
            this.cbStatut.Location = new System.Drawing.Point(270, 454);
            this.cbStatut.Name = "cbStatut";
            this.cbStatut.Size = new System.Drawing.Size(250, 40);
            this.cbStatut.TabIndex = 17;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.Color.White;
            this.btnAnnuler.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(225)))), ((int)(((byte)(230)))));
            this.btnAnnuler.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.btnAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnuler.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnAnnuler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.btnAnnuler.Location = new System.Drawing.Point(770, 555);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(150, 45);
            this.btnAnnuler.TabIndex = 18;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnEnregistrer.FlatAppearance.BorderSize = 0;
            this.btnEnregistrer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(78)))), ((int)(((byte)(216)))));
            this.btnEnregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnregistrer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEnregistrer.ForeColor = System.Drawing.Color.White;
            this.btnEnregistrer.Location = new System.Drawing.Point(940, 555);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(153, 45);
            this.btnEnregistrer.TabIndex = 19;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = false;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAddUpdateTypeAbonnement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(1176, 683);
            this.Controls.Add(this.gbInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
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
