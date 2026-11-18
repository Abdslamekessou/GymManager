
namespace GymManager.Presentation.Abonnements
{
    partial class ucListD_Abonnement
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.lblRechercherPar = new System.Windows.Forms.Label();
            this.cbRechercherPar = new System.Windows.Forms.ComboBox();
            this.lblValeur = new System.Windows.Forms.Label();
            this.txtValeur = new System.Windows.Forms.TextBox();
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
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.lblTitle.Location = new System.Drawing.Point(24, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(300, 57);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Abonnements";
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSubTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblSubTitle.Location = new System.Drawing.Point(28, 68);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(437, 25);
            this.lblSubTitle.TabIndex = 1;
            this.lblSubTitle.Text = "Consultez et gérez les abonnements des membres.";
            // 
            // gbSearch
            // 
            this.gbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSearch.BackColor = System.Drawing.Color.White;
            this.gbSearch.Controls.Add(this.lblRechercherPar);
            this.gbSearch.Controls.Add(this.cbRechercherPar);
            this.gbSearch.Controls.Add(this.lblValeur);
            this.gbSearch.Controls.Add(this.txtValeur);
            this.gbSearch.Controls.Add(this.lblFilterStatut);
            this.gbSearch.Controls.Add(this.cbFilterStatut);
            this.gbSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.gbSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.gbSearch.Location = new System.Drawing.Point(28, 108);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(1019, 125);
            this.gbSearch.TabIndex = 2;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "Recherche et filtres";
            // 
            // lblRechercherPar
            // 
            this.lblRechercherPar.AutoSize = true;
            this.lblRechercherPar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRechercherPar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblRechercherPar.Location = new System.Drawing.Point(18, 30);
            this.lblRechercherPar.Name = "lblRechercherPar";
            this.lblRechercherPar.Size = new System.Drawing.Size(166, 28);
            this.lblRechercherPar.TabIndex = 0;
            this.lblRechercherPar.Text = "Rechercher par :";
            // 
            // cbRechercherPar
            // 
            this.cbRechercherPar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRechercherPar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbRechercherPar.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRechercherPar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.cbRechercherPar.FormattingEnabled = true;
            this.cbRechercherPar.Items.AddRange(new object[] {
            "Nom du membre",
            "ID"});
            this.cbRechercherPar.Location = new System.Drawing.Point(213, 30);
            this.cbRechercherPar.Name = "cbRechercherPar";
            this.cbRechercherPar.Size = new System.Drawing.Size(245, 38);
            this.cbRechercherPar.TabIndex = 1;
            this.cbRechercherPar.SelectedIndexChanged += new System.EventHandler(this.cbRechercherPar_SelectedIndexChanged_1);
            // 
            // lblValeur
            // 
            this.lblValeur.AutoSize = true;
            this.lblValeur.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValeur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblValeur.Location = new System.Drawing.Point(484, 30);
            this.lblValeur.Name = "lblValeur";
            this.lblValeur.Size = new System.Drawing.Size(82, 28);
            this.lblValeur.TabIndex = 2;
            this.lblValeur.Text = "Valeur :";
            // 
            // txtValeur
            // 
            this.txtValeur.BackColor = System.Drawing.Color.White;
            this.txtValeur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValeur.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValeur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.txtValeur.Location = new System.Drawing.Point(572, 31);
            this.txtValeur.Name = "txtValeur";
            this.txtValeur.Size = new System.Drawing.Size(431, 37);
            this.txtValeur.TabIndex = 3;
            this.txtValeur.TextChanged += new System.EventHandler(this.txtValeur_TextChanged_1);
            this.txtValeur.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValeur_KeyPress_1);
            // 
            // lblFilterStatut
            // 
            this.lblFilterStatut.AutoSize = true;
            this.lblFilterStatut.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilterStatut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblFilterStatut.Location = new System.Drawing.Point(18, 78);
            this.lblFilterStatut.Name = "lblFilterStatut";
            this.lblFilterStatut.Size = new System.Drawing.Size(179, 28);
            this.lblFilterStatut.TabIndex = 4;
            this.lblFilterStatut.Text = "Filtrer par statut :";
            // 
            // cbFilterStatut
            // 
            this.cbFilterStatut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterStatut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbFilterStatut.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilterStatut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.cbFilterStatut.FormattingEnabled = true;
            this.cbFilterStatut.Items.AddRange(new object[] {
            "Tous",
            "Actif",
            "Annulé",
            "Expiré"});
            this.cbFilterStatut.Location = new System.Drawing.Point(213, 78);
            this.cbFilterStatut.Name = "cbFilterStatut";
            this.cbFilterStatut.Size = new System.Drawing.Size(245, 38);
            this.cbFilterStatut.TabIndex = 5;
            this.cbFilterStatut.SelectedIndexChanged += new System.EventHandler(this.cbFilterStatut_SelectedIndexChanged_1);
            // 
            // btnAjouterAbonnement
            // 
            this.btnAjouterAbonnement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAjouterAbonnement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnAjouterAbonnement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAjouterAbonnement.FlatAppearance.BorderSize = 0;
            this.btnAjouterAbonnement.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(78)))), ((int)(((byte)(216)))));
            this.btnAjouterAbonnement.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.btnAjouterAbonnement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouterAbonnement.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnAjouterAbonnement.ForeColor = System.Drawing.Color.White;
            this.btnAjouterAbonnement.Location = new System.Drawing.Point(827, 245);
            this.btnAjouterAbonnement.Name = "btnAjouterAbonnement";
            this.btnAjouterAbonnement.Size = new System.Drawing.Size(220, 38);
            this.btnAjouterAbonnement.TabIndex = 5;
            this.btnAjouterAbonnement.Text = "+  Ajouter un abonnement";
            this.btnAjouterAbonnement.UseVisualStyleBackColor = false;
            this.btnAjouterAbonnement.Click += new System.EventHandler(this.btnAjouterAbonnement_Click);
            // 
            // dgvAbonnements
            // 
            this.dgvAbonnements.AllowUserToAddRows = false;
            this.dgvAbonnements.AllowUserToDeleteRows = false;
            this.dgvAbonnements.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.dgvAbonnements.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAbonnements.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAbonnements.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAbonnements.BackgroundColor = System.Drawing.Color.White;
            this.dgvAbonnements.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAbonnements.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAbonnements.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(26)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(26)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAbonnements.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAbonnements.ColumnHeadersHeight = 44;
            this.dgvAbonnements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAbonnements.ContextMenuStrip = this.cmsAbonnements;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAbonnements.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAbonnements.EnableHeadersVisualStyles = false;
            this.dgvAbonnements.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.dgvAbonnements.Location = new System.Drawing.Point(28, 295);
            this.dgvAbonnements.MultiSelect = false;
            this.dgvAbonnements.Name = "dgvAbonnements";
            this.dgvAbonnements.ReadOnly = true;
            this.dgvAbonnements.RowHeadersVisible = false;
            this.dgvAbonnements.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.dgvAbonnements.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAbonnements.RowTemplate.Height = 42;
            this.dgvAbonnements.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAbonnements.Size = new System.Drawing.Size(1019, 388);
            this.dgvAbonnements.TabIndex = 6;
            // 
            // cmsAbonnements
            // 
            this.cmsAbonnements.BackColor = System.Drawing.Color.White;
            this.cmsAbonnements.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cmsAbonnements.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.cmsAbonnements.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsAbonnements.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAjouterAbonnement,
            this.tsmiDetails,
            this.tsmiRenouveler,
            this.tsmiAnnuler});
            this.cmsAbonnements.Name = "cmsAbonnements";
            this.cmsAbonnements.ShowImageMargin = false;
            this.cmsAbonnements.Size = new System.Drawing.Size(261, 132);
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
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.Controls.Add(this.dgvAbonnements);
            this.Controls.Add(this.btnAjouterAbonnement);
            this.Controls.Add(this.gbSearch);
            this.Controls.Add(this.lblSubTitle);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.Margin = new System.Windows.Forms.Padding(0);
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
