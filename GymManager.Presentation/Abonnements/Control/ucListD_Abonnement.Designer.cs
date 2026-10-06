namespace GymManager.Presentation.Abonnements
{
    partial class ucListD_Abonnement
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.lblRechercherPar = new System.Windows.Forms.Label();
            this.cbRechercherPar = new System.Windows.Forms.ComboBox();
            this.lblValeur = new System.Windows.Forms.Label();
            this.txtValeur = new System.Windows.Forms.TextBox();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.lblFilterStatut = new System.Windows.Forms.Label();
            this.cbFilterStatut = new System.Windows.Forms.ComboBox();
            this.btnAjouterAbonnement = new System.Windows.Forms.Button();
            this.dgvAbonnements = new System.Windows.Forms.DataGridView();
            this.cmsAbonnements = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiAjouterAbonnement = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRenouveler = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAnnuler = new System.Windows.Forms.ToolStripMenuItem();
            this.gbSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbonnements)).BeginInit();
            this.cmsAbonnements.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(256, 48);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Abonnements";
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblSubTitle.Location = new System.Drawing.Point(22, 50);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(857, 25);
            this.lblSubTitle.TabIndex = 1;
            this.lblSubTitle.Text = "Cet écran permet à l\'utilisateur autorisé de consulter et gérer la liste des abon" +
    "nements des membres.";
            // 
            // gbSearch
            // 
            this.gbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSearch.Controls.Add(this.lblRechercherPar);
            this.gbSearch.Controls.Add(this.cbRechercherPar);
            this.gbSearch.Controls.Add(this.lblValeur);
            this.gbSearch.Controls.Add(this.txtValeur);
            this.gbSearch.Controls.Add(this.btnRechercher);
            this.gbSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.gbSearch.Location = new System.Drawing.Point(25, 80);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(1025, 105);
            this.gbSearch.TabIndex = 2;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = " Recherche ";
            // 
            // lblRechercherPar
            // 
            this.lblRechercherPar.AutoSize = true;
            this.lblRechercherPar.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblRechercherPar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblRechercherPar.Location = new System.Drawing.Point(20, 28);
            this.lblRechercherPar.Name = "lblRechercherPar";
            this.lblRechercherPar.Size = new System.Drawing.Size(148, 25);
            this.lblRechercherPar.TabIndex = 0;
            this.lblRechercherPar.Text = "Rechercher par :";
            // 
            // cbRechercherPar
            // 
            this.cbRechercherPar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRechercherPar.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cbRechercherPar.FormattingEnabled = true;
            this.cbRechercherPar.Items.AddRange(new object[] {
            "Nom du membre",
            "ID"});
            this.cbRechercherPar.Location = new System.Drawing.Point(135, 25);
            this.cbRechercherPar.Name = "cbRechercherPar";
            this.cbRechercherPar.Size = new System.Drawing.Size(260, 33);
            this.cbRechercherPar.TabIndex = 1;
            this.cbRechercherPar.SelectedIndexChanged += new System.EventHandler(this.cbRechercherPar_SelectedIndexChanged_1);
            // 
            // lblValeur
            // 
            this.lblValeur.AutoSize = true;
            this.lblValeur.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblValeur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblValeur.Location = new System.Drawing.Point(20, 65);
            this.lblValeur.Name = "lblValeur";
            this.lblValeur.Size = new System.Drawing.Size(75, 25);
            this.lblValeur.TabIndex = 2;
            this.lblValeur.Text = "Valeur :";
            // 
            // txtValeur
            // 
            this.txtValeur.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtValeur.Location = new System.Drawing.Point(135, 62);
            this.txtValeur.Name = "txtValeur";
            this.txtValeur.Size = new System.Drawing.Size(260, 33);
            this.txtValeur.TabIndex = 3;
            this.txtValeur.TextChanged += new System.EventHandler(this.txtValeur_TextChanged_1);
            this.txtValeur.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValeur_KeyPress_1);
            // 
            // btnRechercher
            // 
            this.btnRechercher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRechercher.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRechercher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRechercher.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnRechercher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnRechercher.Location = new System.Drawing.Point(415, 60);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(120, 29);
            this.btnRechercher.TabIndex = 4;
            this.btnRechercher.Text = "Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = true;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click_1);
            // 
            // lblFilterStatut
            // 
            this.lblFilterStatut.AutoSize = true;
            this.lblFilterStatut.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilterStatut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblFilterStatut.Location = new System.Drawing.Point(25, 203);
            this.lblFilterStatut.Name = "lblFilterStatut";
            this.lblFilterStatut.Size = new System.Drawing.Size(155, 25);
            this.lblFilterStatut.TabIndex = 3;
            this.lblFilterStatut.Text = "Filtrer par statut :";
            // 
            // cbFilterStatut
            // 
            this.cbFilterStatut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterStatut.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cbFilterStatut.FormattingEnabled = true;
            this.cbFilterStatut.Items.AddRange(new object[] {
            "Tous",
            "Actif",
            "Inactif",
            "Expiré"});
            this.cbFilterStatut.Location = new System.Drawing.Point(140, 200);
            this.cbFilterStatut.Name = "cbFilterStatut";
            this.cbFilterStatut.Size = new System.Drawing.Size(180, 33);
            this.cbFilterStatut.TabIndex = 4;
            this.cbFilterStatut.SelectedIndexChanged += new System.EventHandler(this.cbFilterStatut_SelectedIndexChanged_1);
            // 
            // btnAjouterAbonnement
            // 
            this.btnAjouterAbonnement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAjouterAbonnement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAjouterAbonnement.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAjouterAbonnement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouterAbonnement.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnAjouterAbonnement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnAjouterAbonnement.Location = new System.Drawing.Point(850, 196);
            this.btnAjouterAbonnement.Name = "btnAjouterAbonnement";
            this.btnAjouterAbonnement.Size = new System.Drawing.Size(200, 32);
            this.btnAjouterAbonnement.TabIndex = 5;
            this.btnAjouterAbonnement.Text = "Ajouter un abonnement";
            this.btnAjouterAbonnement.UseVisualStyleBackColor = true;
            this.btnAjouterAbonnement.Click += new System.EventHandler(this.btnAjouterAbonnement_Click);
            // 
            // dgvAbonnements
            // 
            this.dgvAbonnements.AllowUserToAddRows = false;
            this.dgvAbonnements.AllowUserToDeleteRows = false;
            this.dgvAbonnements.AllowUserToResizeRows = false;
            this.dgvAbonnements.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAbonnements.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAbonnements.BackgroundColor = System.Drawing.Color.White;
            this.dgvAbonnements.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvAbonnements.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAbonnements.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAbonnements.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAbonnements.ColumnHeadersHeight = 35;
            this.dgvAbonnements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAbonnements.ContextMenuStrip = this.cmsAbonnements;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAbonnements.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAbonnements.EnableHeadersVisualStyles = false;
            this.dgvAbonnements.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dgvAbonnements.Location = new System.Drawing.Point(25, 238);
            this.dgvAbonnements.MultiSelect = false;
            this.dgvAbonnements.Name = "dgvAbonnements";
            this.dgvAbonnements.ReadOnly = true;
            this.dgvAbonnements.RowHeadersVisible = false;
            this.dgvAbonnements.RowHeadersWidth = 62;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.dgvAbonnements.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAbonnements.RowTemplate.Height = 32;
            this.dgvAbonnements.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAbonnements.Size = new System.Drawing.Size(1025, 445);
            this.dgvAbonnements.TabIndex = 6;
            // 
            // cmsAbonnements
            // 
            this.cmsAbonnements.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cmsAbonnements.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsAbonnements.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAjouterAbonnement,
            this.tsmiDetails,
            this.tsmiRenouveler,
            this.tsmiAnnuler});
            this.cmsAbonnements.Name = "cmsAbonnements";
            this.cmsAbonnements.ShowImageMargin = false;
            this.cmsAbonnements.Size = new System.Drawing.Size(261, 165);
            // 
            // tsmiAjouterAbonnement
            // 
            this.tsmiAjouterAbonnement.Name = "tsmiAjouterAbonnement";
            this.tsmiAjouterAbonnement.Size = new System.Drawing.Size(260, 32);
            this.tsmiAjouterAbonnement.Text = "Ajouter un abonnement";
            // 
            // tsmiDetails
            // 
            this.tsmiDetails.Name = "tsmiDetails";
            this.tsmiDetails.Size = new System.Drawing.Size(260, 32);
            this.tsmiDetails.Text = "Détails";
            this.tsmiDetails.Click += new System.EventHandler(this.tsmiDetails_Click_1);
            // 
            // tsmiRenouveler
            // 
            this.tsmiRenouveler.Name = "tsmiRenouveler";
            this.tsmiRenouveler.Size = new System.Drawing.Size(260, 32);
            this.tsmiRenouveler.Text = "Renouveler";
            this.tsmiRenouveler.Click += new System.EventHandler(this.tsmiRenouveler_Click_1);
            // 
            // tsmiAnnuler
            // 
            this.tsmiAnnuler.Name = "tsmiAnnuler";
            this.tsmiAnnuler.Size = new System.Drawing.Size(260, 32);
            this.tsmiAnnuler.Text = "Annuler";
            this.tsmiAnnuler.Click += new System.EventHandler(this.tsmiAnnuler_Click_1);
            // 
            // ucListD_Abonnement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.dgvAbonnements);
            this.Controls.Add(this.btnAjouterAbonnement);
            this.Controls.Add(this.cbFilterStatut);
            this.Controls.Add(this.lblFilterStatut);
            this.Controls.Add(this.gbSearch);
            this.Controls.Add(this.lblSubTitle);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.Name = "ucListD_Abonnement";
            this.Size = new System.Drawing.Size(1075, 706);
            this.Load += new System.EventHandler(this.ucListD_Abonnement_Load);
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbonnements)).EndInit();
            this.cmsAbonnements.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.Label lblRechercherPar;
        private System.Windows.Forms.ComboBox cbRechercherPar;
        private System.Windows.Forms.Label lblValeur;
        private System.Windows.Forms.TextBox txtValeur;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.Label lblFilterStatut;
        private System.Windows.Forms.ComboBox cbFilterStatut;
        private System.Windows.Forms.Button btnAjouterAbonnement;
        private System.Windows.Forms.DataGridView dgvAbonnements;
        private System.Windows.Forms.ContextMenuStrip cmsAbonnements;
        private System.Windows.Forms.ToolStripMenuItem tsmiAjouterAbonnement;
        private System.Windows.Forms.ToolStripMenuItem tsmiDetails;
        private System.Windows.Forms.ToolStripMenuItem tsmiRenouveler;
        private System.Windows.Forms.ToolStripMenuItem tsmiAnnuler;
    }
}