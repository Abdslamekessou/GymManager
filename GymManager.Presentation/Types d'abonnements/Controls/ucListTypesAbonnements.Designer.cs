
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbFilter = new System.Windows.Forms.ComboBox();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.label1.Location = new System.Drawing.Point(24, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(456, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Types d\'abonnements";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.label2.Location = new System.Drawing.Point(28, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(524, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gérez les types d\'abonnements enregistrés dans le système";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbFilter);
            this.panel1.Controls.Add(this.txtValeur);
            this.panel1.Controls.Add(this.cbRechercher);
            this.panel1.Controls.Add(this.lblValeur);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(28, 108);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(14);
            this.panel1.Size = new System.Drawing.Size(1100, 112);
            this.panel1.TabIndex = 2;
            // 
            // cbFilter
            // 
            this.cbFilter.BackColor = System.Drawing.Color.White;
            this.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbFilter.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Items.AddRange(new object[] {
            "Tous",
            "Actif",
            "InActif"});
            this.cbFilter.Location = new System.Drawing.Point(190, 64);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(285, 38);
            this.cbFilter.TabIndex = 7;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // txtValeur
            // 
            this.txtValeur.BackColor = System.Drawing.Color.White;
            this.txtValeur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValeur.Enabled = false;
            this.txtValeur.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValeur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.txtValeur.Location = new System.Drawing.Point(599, 17);
            this.txtValeur.MaxLength = 2000;
            this.txtValeur.Name = "txtValeur";
            this.txtValeur.Size = new System.Drawing.Size(412, 39);
            this.txtValeur.TabIndex = 3;
            this.txtValeur.TextChanged += new System.EventHandler(this.txtValeur_TextChanged);
            this.txtValeur.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValeur_KeyPress);
            // 
            // cbRechercher
            // 
            this.cbRechercher.BackColor = System.Drawing.Color.White;
            this.cbRechercher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRechercher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbRechercher.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRechercher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.cbRechercher.FormattingEnabled = true;
            this.cbRechercher.Items.AddRange(new object[] {
            "Nom du type d\'abonnement",
            "ID Type d\'abonnement",
            "Statut"});
            this.cbRechercher.Location = new System.Drawing.Point(190, 19);
            this.cbRechercher.Name = "cbRechercher";
            this.cbRechercher.Size = new System.Drawing.Size(285, 38);
            this.cbRechercher.TabIndex = 6;
            this.cbRechercher.SelectedIndexChanged += new System.EventHandler(this.cbRechercher_SelectedIndexChanged);
            // 
            // lblValeur
            // 
            this.lblValeur.AutoSize = true;
            this.lblValeur.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValeur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblValeur.Location = new System.Drawing.Point(517, 19);
            this.lblValeur.Name = "lblValeur";
            this.lblValeur.Size = new System.Drawing.Size(82, 28);
            this.lblValeur.TabIndex = 4;
            this.lblValeur.Text = "Valeur :";
            this.lblValeur.Click += new System.EventHandler(this.lblValeur_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.label5.Location = new System.Drawing.Point(18, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 28);
            this.label5.TabIndex = 5;
            this.label5.Text = "Filtrer par statut :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.label3.Location = new System.Drawing.Point(18, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Rechercher par :";
            // 
            // dgvListTypeAbonnement
            // 
            this.dgvListTypeAbonnement.AllowUserToAddRows = false;
            this.dgvListTypeAbonnement.AllowUserToDeleteRows = false;
            this.dgvListTypeAbonnement.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.dgvListTypeAbonnement.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListTypeAbonnement.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListTypeAbonnement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListTypeAbonnement.BackgroundColor = System.Drawing.Color.White;
            this.dgvListTypeAbonnement.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListTypeAbonnement.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(26)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(26)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListTypeAbonnement.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListTypeAbonnement.ColumnHeadersHeight = 44;
            this.dgvListTypeAbonnement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvListTypeAbonnement.ContextMenuStrip = this.cmsabonnement;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListTypeAbonnement.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListTypeAbonnement.EnableHeadersVisualStyles = false;
            this.dgvListTypeAbonnement.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.dgvListTypeAbonnement.Location = new System.Drawing.Point(28, 278);
            this.dgvListTypeAbonnement.MultiSelect = false;
            this.dgvListTypeAbonnement.Name = "dgvListTypeAbonnement";
            this.dgvListTypeAbonnement.ReadOnly = true;
            this.dgvListTypeAbonnement.RowHeadersVisible = false;
            this.dgvListTypeAbonnement.RowHeadersWidth = 62;
            this.dgvListTypeAbonnement.RowTemplate.Height = 42;
            this.dgvListTypeAbonnement.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListTypeAbonnement.Size = new System.Drawing.Size(1100, 417);
            this.dgvListTypeAbonnement.TabIndex = 3;
            // 
            // cmsabonnement
            // 
            this.cmsabonnement.BackColor = System.Drawing.Color.White;
            this.cmsabonnement.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cmsabonnement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.cmsabonnement.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsabonnement.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voirLesDetailsToolStripMenuItem,
            this.modifierToolStripMenuItem,
            this.désactiverToolStripMenuItem,
            this.activerToolStripMenuItem});
            this.cmsabonnement.Name = "cmsabonnement";
            this.cmsabonnement.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.cmsabonnement.Size = new System.Drawing.Size(207, 132);
            // 
            // voirLesDetailsToolStripMenuItem
            // 
            this.voirLesDetailsToolStripMenuItem.Name = "voirLesDetailsToolStripMenuItem";
            this.voirLesDetailsToolStripMenuItem.Size = new System.Drawing.Size(206, 32);
            this.voirLesDetailsToolStripMenuItem.Text = "Voir les détails";
            this.voirLesDetailsToolStripMenuItem.Click += new System.EventHandler(this.voirLesDetailsToolStripMenuItem_Click);
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(206, 32);
            this.modifierToolStripMenuItem.Text = "Modifier";
            this.modifierToolStripMenuItem.Click += new System.EventHandler(this.modifierToolStripMenuItem_Click);
            // 
            // désactiverToolStripMenuItem
            // 
            this.désactiverToolStripMenuItem.Name = "désactiverToolStripMenuItem";
            this.désactiverToolStripMenuItem.Size = new System.Drawing.Size(206, 32);
            this.désactiverToolStripMenuItem.Text = "Désactiver";
            this.désactiverToolStripMenuItem.Click += new System.EventHandler(this.désactiverToolStripMenuItem_Click);
            // 
            // activerToolStripMenuItem
            // 
            this.activerToolStripMenuItem.Name = "activerToolStripMenuItem";
            this.activerToolStripMenuItem.Size = new System.Drawing.Size(206, 32);
            this.activerToolStripMenuItem.Text = "Activer";
            this.activerToolStripMenuItem.Click += new System.EventHandler(this.activerToolStripMenuItem_Click);
            // 
            // btnAjouterType
            // 
            this.btnAjouterType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAjouterType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnAjouterType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAjouterType.FlatAppearance.BorderSize = 0;
            this.btnAjouterType.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(78)))), ((int)(((byte)(216)))));
            this.btnAjouterType.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.btnAjouterType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouterType.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnAjouterType.ForeColor = System.Drawing.Color.White;
            this.btnAjouterType.Location = new System.Drawing.Point(928, 229);
            this.btnAjouterType.Name = "btnAjouterType";
            this.btnAjouterType.Size = new System.Drawing.Size(200, 36);
            this.btnAjouterType.TabIndex = 8;
            this.btnAjouterType.Text = "+  Ajouter un type";
            this.btnAjouterType.UseVisualStyleBackColor = false;
            this.btnAjouterType.Click += new System.EventHandler(this.btnAjouterType_Click);
            // 
            // ucListTypesAbonnements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.Controls.Add(this.btnAjouterType);
            this.Controls.Add(this.dgvListTypeAbonnement);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ucListTypesAbonnements";
            this.Size = new System.Drawing.Size(1156, 723);
            this.Load += new System.EventHandler(this.ucListTypesAbonnements_Load);
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
