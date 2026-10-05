namespace GymManager.Presentation
{
    partial class ucListTypesAbonnements
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Types d\'abonnements";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(552, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gérez les comptes d\'abonnements enregistrés dans le système";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbFilter);
            this.panel1.Controls.Add(this.btnRechercher);
            this.panel1.Controls.Add(this.txtValeur);
            this.panel1.Controls.Add(this.cbRechercher);
            this.panel1.Controls.Add(this.lblValeur);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(20, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1115, 110);
            this.panel1.TabIndex = 2;
            // 
            // cbFilter
            // 
            this.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilter.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Items.AddRange(new object[] {
            "Tous",
            "Actif",
            "InActif"});
            this.cbFilter.Location = new System.Drawing.Point(160, 60);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(295, 36);
            this.cbFilter.TabIndex = 7;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // btnRechercher
            // 
            this.btnRechercher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRechercher.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRechercher.Location = new System.Drawing.Point(969, 14);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(130, 32);
            this.btnRechercher.TabIndex = 3;
            this.btnRechercher.Text = "Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = true;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // txtValeur
            // 
            this.txtValeur.Enabled = false;
            this.txtValeur.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValeur.Location = new System.Drawing.Point(594, 17);
            this.txtValeur.Name = "txtValeur";
            this.txtValeur.Size = new System.Drawing.Size(341, 34);
            this.txtValeur.TabIndex = 3;
            this.txtValeur.TextChanged += new System.EventHandler(this.txtValeur_TextChanged);
            this.txtValeur.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValeur_KeyPress);
            // 
            // cbRechercher
            // 
            this.cbRechercher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRechercher.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRechercher.FormattingEnabled = true;
            this.cbRechercher.Items.AddRange(new object[] {
            "None",
            "Nom du type d\'abonnement",
            "ID Type d\'abonnement"});
            this.cbRechercher.Location = new System.Drawing.Point(160, 18);
            this.cbRechercher.Name = "cbRechercher";
            this.cbRechercher.Size = new System.Drawing.Size(295, 36);
            this.cbRechercher.TabIndex = 6;
            this.cbRechercher.SelectedIndexChanged += new System.EventHandler(this.cbRechercher_SelectedIndexChanged);
            // 
            // lblValeur
            // 
            this.lblValeur.AutoSize = true;
            this.lblValeur.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValeur.Location = new System.Drawing.Point(512, 20);
            this.lblValeur.Name = "lblValeur";
            this.lblValeur.Size = new System.Drawing.Size(75, 28);
            this.lblValeur.TabIndex = 4;
            this.lblValeur.Text = "Valeur :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 28);
            this.label5.TabIndex = 5;
            this.label5.Text = "Filter par statut :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Rechercher par :";
            // 
            // dgvListTypeAbonnement
            // 
            this.dgvListTypeAbonnement.AllowUserToAddRows = false;
            this.dgvListTypeAbonnement.AllowUserToDeleteRows = false;
            this.dgvListTypeAbonnement.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListTypeAbonnement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListTypeAbonnement.BackgroundColor = System.Drawing.Color.White;
            this.dgvListTypeAbonnement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListTypeAbonnement.ContextMenuStrip = this.cmsabonnement;
            this.dgvListTypeAbonnement.Location = new System.Drawing.Point(20, 260);
            this.dgvListTypeAbonnement.MultiSelect = false;
            this.dgvListTypeAbonnement.Name = "dgvListTypeAbonnement";
            this.dgvListTypeAbonnement.ReadOnly = true;
            this.dgvListTypeAbonnement.RowHeadersVisible = false;
            this.dgvListTypeAbonnement.RowHeadersWidth = 62;
            this.dgvListTypeAbonnement.RowTemplate.Height = 29;
            this.dgvListTypeAbonnement.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListTypeAbonnement.Size = new System.Drawing.Size(1115, 440);
            this.dgvListTypeAbonnement.TabIndex = 3;
            // 
            // cmsabonnement
            // 
            this.cmsabonnement.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsabonnement.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsabonnement.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voirLesDetailsToolStripMenuItem,
            this.modifierToolStripMenuItem,
            this.désactiverToolStripMenuItem,
            this.activerToolStripMenuItem});
            this.cmsabonnement.Name = "cmsabonnement";
            this.cmsabonnement.Size = new System.Drawing.Size(210, 140);
            // 
            // voirLesDetailsToolStripMenuItem
            // 
            this.voirLesDetailsToolStripMenuItem.Name = "voirLesDetailsToolStripMenuItem";
            this.voirLesDetailsToolStripMenuItem.Size = new System.Drawing.Size(209, 34);
            this.voirLesDetailsToolStripMenuItem.Text = "Voir les détails";
            this.voirLesDetailsToolStripMenuItem.Click += new System.EventHandler(this.voirLesDetailsToolStripMenuItem_Click);
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(209, 34);
            this.modifierToolStripMenuItem.Text = "Modifier";
            this.modifierToolStripMenuItem.Click += new System.EventHandler(this.modifierToolStripMenuItem_Click);
            // 
            // désactiverToolStripMenuItem
            // 
            this.désactiverToolStripMenuItem.Name = "désactiverToolStripMenuItem";
            this.désactiverToolStripMenuItem.Size = new System.Drawing.Size(209, 34);
            this.désactiverToolStripMenuItem.Text = "Désactiver";
            this.désactiverToolStripMenuItem.Click += new System.EventHandler(this.désactiverToolStripMenuItem_Click);
            // 
            // activerToolStripMenuItem
            // 
            this.activerToolStripMenuItem.Name = "activerToolStripMenuItem";
            this.activerToolStripMenuItem.Size = new System.Drawing.Size(209, 34);
            this.activerToolStripMenuItem.Text = "Activer";
            this.activerToolStripMenuItem.Click += new System.EventHandler(this.activerToolStripMenuItem_Click);
            // 
            // btnAjouterType
            // 
            this.btnAjouterType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAjouterType.BackColor = System.Drawing.Color.White;
            this.btnAjouterType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouterType.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterType.Location = new System.Drawing.Point(955, 215);
            this.btnAjouterType.Name = "btnAjouterType";
            this.btnAjouterType.Size = new System.Drawing.Size(180, 35);
            this.btnAjouterType.TabIndex = 8;
            this.btnAjouterType.Text = "Ajouter un type";
            this.btnAjouterType.UseVisualStyleBackColor = false;
            this.btnAjouterType.Click += new System.EventHandler(this.btnAjouterType_Click);
            // 
            // ucListTypesAbonnements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAjouterType);
            this.Controls.Add(this.dgvListTypeAbonnement);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
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