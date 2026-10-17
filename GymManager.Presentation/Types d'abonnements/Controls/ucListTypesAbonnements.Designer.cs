
namespace GymManager.Presentation
{
    partial class ucListTypesAbonnements
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

            System.Windows.Forms.DataGridViewCellStyle headerStyle =
                new System.Windows.Forms.DataGridViewCellStyle();

            System.Windows.Forms.DataGridViewCellStyle cellStyle =
                new System.Windows.Forms.DataGridViewCellStyle();

            System.Windows.Forms.DataGridViewCellStyle alternateStyle =
                new System.Windows.Forms.DataGridViewCellStyle();

            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.txtValeur = new System.Windows.Forms.TextBox();
            this.cbRechercher = new System.Windows.Forms.ComboBox();
            this.lblValeur = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvListTypeAbonnement = new System.Windows.Forms.DataGridView();
            this.cmsabonnement = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.voirLesDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.désactiverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAjouterType = new System.Windows.Forms.Button();

            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListTypeAbonnement)).BeginInit();
            this.cmsabonnement.SuspendLayout();
            this.SuspendLayout();

            // 
            // label1 - Page title
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font(
                "Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(26, 26, 26);
            this.label1.Location = new System.Drawing.Point(24, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Types d'abonnements";
            this.label1.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Right;

            // 
            // label2 - Subtitle
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(80, 80, 80);
            this.label2.Location = new System.Drawing.Point(27, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(552, 23);
            this.label2.TabIndex = 1;
            this.label2.Text =
                "Gérez les comptes d'abonnements enregistrés dans le système";

            // 
            // panel1 - Filters
            // 
            this.panel1.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Right;

            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.panel1.Controls.Add(this.cbFilter);
            this.panel1.Controls.Add(this.btnRechercher);
            this.panel1.Controls.Add(this.txtValeur);
            this.panel1.Controls.Add(this.cbRechercher);
            this.panel1.Controls.Add(this.lblValeur);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);

            this.panel1.Location = new System.Drawing.Point(28, 112);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 112);
            this.panel1.TabIndex = 2;

            // 
            // label3 - Search by
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(26, 26, 26);
            this.label3.Location = new System.Drawing.Point(18, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Rechercher par :";

            // 
            // cbRechercher
            // 
            this.cbRechercher.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Left;

            this.cbRechercher.BackColor = System.Drawing.Color.White;
            this.cbRechercher.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRechercher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbRechercher.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbRechercher.ForeColor = System.Drawing.Color.FromArgb(26, 26, 26);
            this.cbRechercher.FormattingEnabled = true;
            this.cbRechercher.Items.AddRange(new object[]
            {
                "None",
                "Nom du type d'abonnement",
                "ID Type d'abonnement"
            });
            this.cbRechercher.Location = new System.Drawing.Point(175, 15);
            this.cbRechercher.Name = "cbRechercher";
            this.cbRechercher.Size = new System.Drawing.Size(280, 31);
            this.cbRechercher.TabIndex = 6;
            this.cbRechercher.SelectedIndexChanged +=
                new System.EventHandler(this.cbRechercher_SelectedIndexChanged);

            // 
            // lblValeur
            // 
            this.lblValeur.AutoSize = true;
            this.lblValeur.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblValeur.ForeColor = System.Drawing.Color.FromArgb(26, 26, 26);
            this.lblValeur.Location = new System.Drawing.Point(480, 19);
            this.lblValeur.Name = "lblValeur";
            this.lblValeur.Size = new System.Drawing.Size(75, 23);
            this.lblValeur.TabIndex = 4;
            this.lblValeur.Text = "Valeur :";

            // 
            // txtValeur
            // 
            this.txtValeur.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Right;

            this.txtValeur.BackColor = System.Drawing.Color.White;
            this.txtValeur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValeur.Enabled = false;
            this.txtValeur.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtValeur.ForeColor = System.Drawing.Color.FromArgb(26, 26, 26);
            this.txtValeur.Location = new System.Drawing.Point(560, 16);
            this.txtValeur.Name = "txtValeur";
            this.txtValeur.Size = new System.Drawing.Size(390, 30);
            this.txtValeur.TabIndex = 3;
            this.txtValeur.TextChanged +=
                new System.EventHandler(this.txtValeur_TextChanged);
            this.txtValeur.KeyPress +=
                new System.Windows.Forms.KeyPressEventHandler(this.txtValeur_KeyPress);

            // 
            // btnRechercher
            // 
            this.btnRechercher.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Right;

            this.btnRechercher.BackColor = System.Drawing.Color.FromArgb(80, 80, 80);
            this.btnRechercher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRechercher.FlatAppearance.BorderSize = 0;
            this.btnRechercher.FlatAppearance.MouseDownBackColor =
                System.Drawing.Color.FromArgb(26, 26, 26);
            this.btnRechercher.FlatAppearance.MouseOverBackColor =
                System.Drawing.Color.FromArgb(60, 60, 60);
            this.btnRechercher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRechercher.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnRechercher.ForeColor = System.Drawing.Color.White;
            this.btnRechercher.Location = new System.Drawing.Point(966, 15);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(118, 34);
            this.btnRechercher.TabIndex = 3;
            this.btnRechercher.Text = "Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = false;
            this.btnRechercher.Click +=
                new System.EventHandler(this.btnRechercher_Click);

            // 
            // label5 - Status filter
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(26, 26, 26);
            this.label5.Location = new System.Drawing.Point(18, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Filtrer par statut :";

            // 
            // cbFilter
            // 
            this.cbFilter.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Left;

            this.cbFilter.BackColor = System.Drawing.Color.White;
            this.cbFilter.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbFilter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbFilter.ForeColor = System.Drawing.Color.FromArgb(26, 26, 26);
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Items.AddRange(new object[]
            {
                "Tous",
                "Actif",
                "InActif"
            });
            this.cbFilter.Location = new System.Drawing.Point(175, 62);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(280, 31);
            this.cbFilter.TabIndex = 7;
            this.cbFilter.SelectedIndexChanged +=
                new System.EventHandler(this.cbFilter_SelectedIndexChanged);

            // 
            // dgvListTypeAbonnement
            // 
            this.dgvListTypeAbonnement.AllowUserToAddRows = false;
            this.dgvListTypeAbonnement.AllowUserToDeleteRows = false;
            this.dgvListTypeAbonnement.AllowUserToResizeRows = false;

            this.dgvListTypeAbonnement.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Bottom |
                System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Right;

            this.dgvListTypeAbonnement.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            this.dgvListTypeAbonnement.BackgroundColor = System.Drawing.Color.White;
            this.dgvListTypeAbonnement.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListTypeAbonnement.CellBorderStyle =
                System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvListTypeAbonnement.ColumnHeadersBorderStyle =
                System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;

            headerStyle.Alignment =
                System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            headerStyle.BackColor = System.Drawing.Color.FromArgb(240, 239, 234);
            headerStyle.Font = new System.Drawing.Font(
                "Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            headerStyle.ForeColor = System.Drawing.Color.FromArgb(26, 26, 26);
            headerStyle.SelectionBackColor = System.Drawing.Color.FromArgb(240, 239, 234);
            headerStyle.SelectionForeColor = System.Drawing.Color.FromArgb(26, 26, 26);
            headerStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;

            this.dgvListTypeAbonnement.ColumnHeadersDefaultCellStyle = headerStyle;
            this.dgvListTypeAbonnement.ColumnHeadersHeight = 42;
            this.dgvListTypeAbonnement.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            cellStyle.Alignment =
                System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            cellStyle.BackColor = System.Drawing.Color.White;
            cellStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            cellStyle.ForeColor = System.Drawing.Color.FromArgb(26, 26, 26);
            cellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(232, 230, 224);
            cellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(26, 26, 26);
            cellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;

            this.dgvListTypeAbonnement.DefaultCellStyle = cellStyle;

            alternateStyle.BackColor = System.Drawing.Color.FromArgb(250, 249, 246);
            alternateStyle.ForeColor = System.Drawing.Color.FromArgb(26, 26, 26);
            alternateStyle.SelectionBackColor = System.Drawing.Color.FromArgb(232, 230, 224);
            alternateStyle.SelectionForeColor = System.Drawing.Color.FromArgb(26, 26, 26);

            this.dgvListTypeAbonnement.AlternatingRowsDefaultCellStyle = alternateStyle;
            this.dgvListTypeAbonnement.EnableHeadersVisualStyles = false;
            this.dgvListTypeAbonnement.GridColor =
                System.Drawing.Color.FromArgb(208, 206, 206);

            this.dgvListTypeAbonnement.Location = new System.Drawing.Point(28, 270);
            this.dgvListTypeAbonnement.MultiSelect = false;
            this.dgvListTypeAbonnement.Name = "dgvListTypeAbonnement";
            this.dgvListTypeAbonnement.ReadOnly = true;
            this.dgvListTypeAbonnement.RowHeadersVisible = false;
            this.dgvListTypeAbonnement.RowTemplate.Height = 40;
            this.dgvListTypeAbonnement.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListTypeAbonnement.Size = new System.Drawing.Size(1100, 420);
            this.dgvListTypeAbonnement.TabIndex = 3;
            this.dgvListTypeAbonnement.ContextMenuStrip = this.cmsabonnement;

            // 
            // cmsabonnement
            // 
            this.cmsabonnement.BackColor = System.Drawing.Color.White;
            this.cmsabonnement.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmsabonnement.ForeColor = System.Drawing.Color.FromArgb(26, 26, 26);
            this.cmsabonnement.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsabonnement.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
            {
                this.voirLesDetailsToolStripMenuItem,
                this.modifierToolStripMenuItem,
                this.désactiverToolStripMenuItem,
                this.activerToolStripMenuItem
            });
            this.cmsabonnement.Name = "cmsabonnement";
            this.cmsabonnement.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.cmsabonnement.Size = new System.Drawing.Size(210, 140);

            // 
            // voirLesDetailsToolStripMenuItem
            // 
            this.voirLesDetailsToolStripMenuItem.Name = "voirLesDetailsToolStripMenuItem";
            this.voirLesDetailsToolStripMenuItem.Size = new System.Drawing.Size(209, 34);
            this.voirLesDetailsToolStripMenuItem.Text = "Voir les détails";
            this.voirLesDetailsToolStripMenuItem.Click +=
                new System.EventHandler(this.voirLesDetailsToolStripMenuItem_Click);

            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(209, 34);
            this.modifierToolStripMenuItem.Text = "Modifier";
            this.modifierToolStripMenuItem.Click +=
                new System.EventHandler(this.modifierToolStripMenuItem_Click);

            // 
            // désactiverToolStripMenuItem
            // 
            this.désactiverToolStripMenuItem.Name = "désactiverToolStripMenuItem";
            this.désactiverToolStripMenuItem.Size = new System.Drawing.Size(209, 34);
            this.désactiverToolStripMenuItem.Text = "Désactiver";
            this.désactiverToolStripMenuItem.Click +=
                new System.EventHandler(this.désactiverToolStripMenuItem_Click);

            // 
            // activerToolStripMenuItem
            // 
            this.activerToolStripMenuItem.Name = "activerToolStripMenuItem";
            this.activerToolStripMenuItem.Size = new System.Drawing.Size(209, 34);
            this.activerToolStripMenuItem.Text = "Activer";
            this.activerToolStripMenuItem.Click +=
                new System.EventHandler(this.activerToolStripMenuItem_Click);

            // 
            // btnAjouterType
            // 
            this.btnAjouterType.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Right;

            this.btnAjouterType.BackColor = System.Drawing.Color.FromArgb(26, 26, 26);
            this.btnAjouterType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAjouterType.FlatAppearance.BorderSize = 0;
            this.btnAjouterType.FlatAppearance.MouseDownBackColor =
                System.Drawing.Color.FromArgb(60, 60, 60);
            this.btnAjouterType.FlatAppearance.MouseOverBackColor =
                System.Drawing.Color.FromArgb(80, 80, 80);
            this.btnAjouterType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouterType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnAjouterType.ForeColor = System.Drawing.Color.White;
            this.btnAjouterType.Location = new System.Drawing.Point(928, 229);
            this.btnAjouterType.Name = "btnAjouterType";
            this.btnAjouterType.Size = new System.Drawing.Size(200, 34);
            this.btnAjouterType.TabIndex = 8;
            this.btnAjouterType.Text = "Ajouter un type";
            this.btnAjouterType.UseVisualStyleBackColor = false;
            this.btnAjouterType.Click +=
                new System.EventHandler(this.btnAjouterType_Click);

            // 
            // ucListTypesAbonnements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(240, 239, 234);
            this.Controls.Add(this.btnAjouterType);
            this.Controls.Add(this.dgvListTypeAbonnement);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ucListTypesAbonnements";
            this.Size = new System.Drawing.Size(1156, 723);
            this.Load +=
                new System.EventHandler(this.ucListTypesAbonnements_Load);

            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListTypeAbonnement)).EndInit();
            this.cmsabonnement.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbRechercher;
        private System.Windows.Forms.Label lblValeur;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.TextBox txtValeur;
        private System.Windows.Forms.DataGridView dgvListTypeAbonnement;
        private System.Windows.Forms.Button btnAjouterType;
        private System.Windows.Forms.ContextMenuStrip cmsabonnement;
        private System.Windows.Forms.ToolStripMenuItem voirLesDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem désactiverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activerToolStripMenuItem;
    }
}
