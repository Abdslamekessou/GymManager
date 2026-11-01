
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

            System.Windows.Forms.DataGridViewCellStyle alternatingStyle =
                new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle headerStyle =
                new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle defaultStyle =
                new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle rowsStyle =
                new System.Windows.Forms.DataGridViewCellStyle();

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
            this.lblTitle.Font = new System.Drawing.Font(
                "Segoe UI", 21F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(23, 32, 51);
            this.lblTitle.Location = new System.Drawing.Point(24, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(287, 47);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Abonnements";

            // 
            // lblSubTitle
            // 
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSubTitle.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblSubTitle.Location = new System.Drawing.Point(28, 68);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(700, 21);
            this.lblSubTitle.TabIndex = 1;
            this.lblSubTitle.Text =
                "Consultez et gérez les abonnements des membres.";

            // 
            // gbSearch
            // 
            this.gbSearch.Anchor = (
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Right);

            this.gbSearch.BackColor = System.Drawing.Color.White;
            this.gbSearch.Controls.Add(this.lblRechercherPar);
            this.gbSearch.Controls.Add(this.cbRechercherPar);
            this.gbSearch.Controls.Add(this.lblValeur);
            this.gbSearch.Controls.Add(this.txtValeur);
            this.gbSearch.Controls.Add(this.lblFilterStatut);
            this.gbSearch.Controls.Add(this.cbFilterStatut);

            this.gbSearch.Font = new System.Drawing.Font(
                "Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.gbSearch.ForeColor = System.Drawing.Color.FromArgb(23, 32, 51);
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
            this.lblRechercherPar.Font = new System.Drawing.Font(
                "Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblRechercherPar.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.lblRechercherPar.Location = new System.Drawing.Point(18, 30);
            this.lblRechercherPar.Name = "lblRechercherPar";
            this.lblRechercherPar.Size = new System.Drawing.Size(115, 20);
            this.lblRechercherPar.TabIndex = 0;
            this.lblRechercherPar.Text = "Rechercher par :";

            // 
            // cbRechercherPar
            // 
            this.cbRechercherPar.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRechercherPar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbRechercherPar.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cbRechercherPar.ForeColor = System.Drawing.Color.FromArgb(23, 32, 51);
            this.cbRechercherPar.FormattingEnabled = true;
            this.cbRechercherPar.Items.AddRange(new object[] {
                "Nom du membre",
                "ID"
            });
            this.cbRechercherPar.Location = new System.Drawing.Point(145, 26);
            this.cbRechercherPar.Name = "cbRechercherPar";
            this.cbRechercherPar.Size = new System.Drawing.Size(245, 29);
            this.cbRechercherPar.TabIndex = 1;
            this.cbRechercherPar.SelectedIndexChanged +=
                new System.EventHandler(this.cbRechercherPar_SelectedIndexChanged_1);

            // 
            // lblValeur
            // 
            this.lblValeur.AutoSize = true;
            this.lblValeur.Font = new System.Drawing.Font(
                "Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblValeur.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.lblValeur.Location = new System.Drawing.Point(415, 30);
            this.lblValeur.Name = "lblValeur";
            this.lblValeur.Size = new System.Drawing.Size(57, 20);
            this.lblValeur.TabIndex = 2;
            this.lblValeur.Text = "Valeur :";

            // 
            // txtValeur
            // 
            this.txtValeur.Anchor = (
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Right);

            this.txtValeur.BackColor = System.Drawing.Color.White;
            this.txtValeur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValeur.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtValeur.ForeColor = System.Drawing.Color.FromArgb(23, 32, 51);
            this.txtValeur.Location = new System.Drawing.Point(485, 27);
            this.txtValeur.Name = "txtValeur";
            this.txtValeur.Size = new System.Drawing.Size(510, 29);
            this.txtValeur.TabIndex = 3;
            this.txtValeur.TextChanged +=
                new System.EventHandler(this.txtValeur_TextChanged_1);
            this.txtValeur.KeyPress +=
                new System.Windows.Forms.KeyPressEventHandler(this.txtValeur_KeyPress_1);

            // 
            // lblFilterStatut
            // 
            this.lblFilterStatut.AutoSize = true;
            this.lblFilterStatut.Font = new System.Drawing.Font(
                "Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFilterStatut.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.lblFilterStatut.Location = new System.Drawing.Point(18, 78);
            this.lblFilterStatut.Name = "lblFilterStatut";
            this.lblFilterStatut.Size = new System.Drawing.Size(120, 20);
            this.lblFilterStatut.TabIndex = 4;
            this.lblFilterStatut.Text = "Filtrer par statut :";

            // 
            // cbFilterStatut
            // 
            this.cbFilterStatut.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterStatut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbFilterStatut.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cbFilterStatut.ForeColor = System.Drawing.Color.FromArgb(23, 32, 51);
            this.cbFilterStatut.FormattingEnabled = true;
            this.cbFilterStatut.Items.AddRange(new object[] {
                "Tous",
                "Actif",
                "Annulé",
                "Expiré"
            });
            this.cbFilterStatut.Location = new System.Drawing.Point(145, 74);
            this.cbFilterStatut.Name = "cbFilterStatut";
            this.cbFilterStatut.Size = new System.Drawing.Size(245, 29);
            this.cbFilterStatut.TabIndex = 5;
            this.cbFilterStatut.SelectedIndexChanged +=
                new System.EventHandler(this.cbFilterStatut_SelectedIndexChanged_1);

            // 
            // btnAjouterAbonnement
            // 
            this.btnAjouterAbonnement.Anchor = (
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Right);

            this.btnAjouterAbonnement.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnAjouterAbonnement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAjouterAbonnement.FlatAppearance.BorderSize = 0;
            this.btnAjouterAbonnement.FlatAppearance.MouseDownBackColor =
                System.Drawing.Color.FromArgb(29, 78, 216);
            this.btnAjouterAbonnement.FlatAppearance.MouseOverBackColor =
                System.Drawing.Color.FromArgb(59, 130, 246);
            this.btnAjouterAbonnement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouterAbonnement.Font = new System.Drawing.Font(
                "Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnAjouterAbonnement.ForeColor = System.Drawing.Color.White;
            this.btnAjouterAbonnement.Location = new System.Drawing.Point(827, 245);
            this.btnAjouterAbonnement.Name = "btnAjouterAbonnement";
            this.btnAjouterAbonnement.Size = new System.Drawing.Size(220, 38);
            this.btnAjouterAbonnement.TabIndex = 5;
            this.btnAjouterAbonnement.Text = "+  Ajouter un abonnement";
            this.btnAjouterAbonnement.UseVisualStyleBackColor = false;
            this.btnAjouterAbonnement.Click +=
                new System.EventHandler(this.btnAjouterAbonnement_Click);

            // 
            // dgvAbonnements
            // 
            this.dgvAbonnements.AllowUserToAddRows = false;
            this.dgvAbonnements.AllowUserToDeleteRows = false;
            this.dgvAbonnements.AllowUserToResizeRows = false;

            alternatingStyle.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            alternatingStyle.ForeColor = System.Drawing.Color.FromArgb(23, 32, 51);
            alternatingStyle.SelectionBackColor = System.Drawing.Color.FromArgb(219, 234, 254);
            alternatingStyle.SelectionForeColor = System.Drawing.Color.FromArgb(23, 32, 51);

            this.dgvAbonnements.AlternatingRowsDefaultCellStyle = alternatingStyle;

            this.dgvAbonnements.Anchor = (
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Bottom |
                System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Right);

            this.dgvAbonnements.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            this.dgvAbonnements.BackgroundColor = System.Drawing.Color.White;
            this.dgvAbonnements.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAbonnements.CellBorderStyle =
                System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAbonnements.ColumnHeadersBorderStyle =
                System.Windows.Forms.DataGridViewHeaderBorderStyle.None;

            headerStyle.Alignment =
                System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            headerStyle.BackColor = System.Drawing.Color.FromArgb(16, 26, 45);
            headerStyle.Font = new System.Drawing.Font(
                "Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            headerStyle.ForeColor = System.Drawing.Color.White;
            headerStyle.SelectionBackColor = System.Drawing.Color.FromArgb(16, 26, 45);
            headerStyle.SelectionForeColor = System.Drawing.Color.White;
            headerStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;

            this.dgvAbonnements.ColumnHeadersDefaultCellStyle = headerStyle;
            this.dgvAbonnements.ColumnHeadersHeight = 44;
            this.dgvAbonnements.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            this.dgvAbonnements.ContextMenuStrip = this.cmsAbonnements;

            defaultStyle.Alignment =
                System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            defaultStyle.BackColor = System.Drawing.Color.White;
            defaultStyle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            defaultStyle.ForeColor = System.Drawing.Color.FromArgb(23, 32, 51);
            defaultStyle.SelectionBackColor = System.Drawing.Color.FromArgb(219, 234, 254);
            defaultStyle.SelectionForeColor = System.Drawing.Color.FromArgb(23, 32, 51);
            defaultStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;

            this.dgvAbonnements.DefaultCellStyle = defaultStyle;
            this.dgvAbonnements.EnableHeadersVisualStyles = false;
            this.dgvAbonnements.GridColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.dgvAbonnements.Location = new System.Drawing.Point(28, 295);
            this.dgvAbonnements.MultiSelect = false;
            this.dgvAbonnements.Name = "dgvAbonnements";
            this.dgvAbonnements.ReadOnly = true;
            this.dgvAbonnements.RowHeadersVisible = false;
            this.dgvAbonnements.RowHeadersWidth = 51;

            rowsStyle.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.dgvAbonnements.RowsDefaultCellStyle = rowsStyle;

            this.dgvAbonnements.RowTemplate.Height = 42;
            this.dgvAbonnements.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAbonnements.Size = new System.Drawing.Size(1019, 388);
            this.dgvAbonnements.TabIndex = 6;

            // 
            // cmsAbonnements
            // 
            this.cmsAbonnements.BackColor = System.Drawing.Color.White;
            this.cmsAbonnements.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cmsAbonnements.ForeColor = System.Drawing.Color.FromArgb(23, 32, 51);
            this.cmsAbonnements.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsAbonnements.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.tsmiAjouterAbonnement,
                this.tsmiDetails,
                this.tsmiRenouveler,
                this.tsmiAnnuler
            });
            this.cmsAbonnements.Name = "cmsAbonnements";
            this.cmsAbonnements.ShowImageMargin = false;
            this.cmsAbonnements.Size = new System.Drawing.Size(268, 140);

            // 
            // tsmiAjouterAbonnement
            // 
            this.tsmiAjouterAbonnement.Name = "tsmiAjouterAbonnement";
            this.tsmiAjouterAbonnement.Size = new System.Drawing.Size(267, 34);
            this.tsmiAjouterAbonnement.Text = "Ajouter un abonnement";

            // 
            // tsmiDetails
            // 
            this.tsmiDetails.Name = "tsmiDetails";
            this.tsmiDetails.Size = new System.Drawing.Size(267, 34);
            this.tsmiDetails.Text = "Détails";
            this.tsmiDetails.Click +=
                new System.EventHandler(this.tsmiDetails_Click_1);

            // 
            // tsmiRenouveler
            // 
            this.tsmiRenouveler.Name = "tsmiRenouveler";
            this.tsmiRenouveler.Size = new System.Drawing.Size(267, 34);
            this.tsmiRenouveler.Text = "Renouveler";
            this.tsmiRenouveler.Click +=
                new System.EventHandler(this.tsmiRenouveler_Click_1);

            // 
            // tsmiAnnuler
            // 
            this.tsmiAnnuler.Name = "tsmiAnnuler";
            this.tsmiAnnuler.Size = new System.Drawing.Size(267, 34);
            this.tsmiAnnuler.Text = "Annuler";
            this.tsmiAnnuler.Click +=
                new System.EventHandler(this.tsmiAnnuler_Click_1);

            // 
            // ucListD_Abonnement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(243, 244, 246);

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
