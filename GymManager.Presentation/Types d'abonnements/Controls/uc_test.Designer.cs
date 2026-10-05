namespace GymManager.Presentation.Types_d_abonnements.Controls
{
    partial class uc_Test
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.txtValeur = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.cbRechercher = new System.Windows.Forms.ComboBox();
            this.btnAjouterType = new System.Windows.Forms.Button();
            this.dgvListTypeAbonnement = new System.Windows.Forms.DataGridView();
            this.cmsabonnement = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.voirLesDétailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desactiverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListTypeAbonnement)).BeginInit();
            this.cmsabonnement.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(411, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Types d\'abonnements";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(625, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gérez les comptes d\'abonnements enregistrés dans le système";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnRechercher);
            this.panel1.Controls.Add(this.txtValeur);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbFilter);
            this.panel1.Controls.Add(this.cbRechercher);
            this.panel1.Location = new System.Drawing.Point(34, 138);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1063, 115);
            this.panel1.TabIndex = 2;
            // 
            // btnRechercher
            // 
            this.btnRechercher.Location = new System.Drawing.Point(888, 11);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(123, 33);
            this.btnRechercher.TabIndex = 5;
            this.btnRechercher.Text = "Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = true;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // txtValeur
            // 
            this.txtValeur.Location = new System.Drawing.Point(546, 14);
            this.txtValeur.Name = "txtValeur";
            this.txtValeur.Size = new System.Drawing.Size(276, 26);
            this.txtValeur.TabIndex = 4;
            this.txtValeur.TextChanged += new System.EventHandler(this.txtValeur_TextChanged);
            this.txtValeur.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValeur_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Filter Par Statut:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Recharche Par :";
            // 
            // cbFilter
            // 
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Items.AddRange(new object[] {
            "Tous",
            "Actif",
            "InActif"});
            this.cbFilter.Location = new System.Drawing.Point(179, 73);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(313, 28);
            this.cbFilter.TabIndex = 1;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // cbRechercher
            // 
            this.cbRechercher.FormattingEnabled = true;
            this.cbRechercher.Items.AddRange(new object[] {
            "None",
            "Nom du type d\'abonnement",
            "ID Type d\'abonnement"});
            this.cbRechercher.Location = new System.Drawing.Point(179, 14);
            this.cbRechercher.Name = "cbRechercher";
            this.cbRechercher.Size = new System.Drawing.Size(313, 28);
            this.cbRechercher.TabIndex = 0;
            this.cbRechercher.SelectedIndexChanged += new System.EventHandler(this.cbRechercher_SelectedIndexChanged);
            // 
            // btnAjouterType
            // 
            this.btnAjouterType.Location = new System.Drawing.Point(900, 277);
            this.btnAjouterType.Name = "btnAjouterType";
            this.btnAjouterType.Size = new System.Drawing.Size(197, 33);
            this.btnAjouterType.TabIndex = 6;
            this.btnAjouterType.Text = "Ajouter un type";
            this.btnAjouterType.UseVisualStyleBackColor = true;
            this.btnAjouterType.Click += new System.EventHandler(this.btnAjouterType_Click);
            // 
            // dgvListTypeAbonnement
            // 
            this.dgvListTypeAbonnement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListTypeAbonnement.ContextMenuStrip = this.cmsabonnement;
            this.dgvListTypeAbonnement.Location = new System.Drawing.Point(34, 327);
            this.dgvListTypeAbonnement.Name = "dgvListTypeAbonnement";
            this.dgvListTypeAbonnement.RowHeadersWidth = 62;
            this.dgvListTypeAbonnement.RowTemplate.Height = 28;
            this.dgvListTypeAbonnement.Size = new System.Drawing.Size(1063, 335);
            this.dgvListTypeAbonnement.TabIndex = 7;
            // 
            // cmsabonnement
            // 
            this.cmsabonnement.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsabonnement.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voirLesDétailsToolStripMenuItem,
            this.modifierToolStripMenuItem,
            this.activerToolStripMenuItem,
            this.desactiverToolStripMenuItem});
            this.cmsabonnement.Name = "cmsabonnement";
            this.cmsabonnement.Size = new System.Drawing.Size(198, 132);
            // 
            // voirLesDétailsToolStripMenuItem
            // 
            this.voirLesDétailsToolStripMenuItem.Name = "voirLesDétailsToolStripMenuItem";
            this.voirLesDétailsToolStripMenuItem.Size = new System.Drawing.Size(197, 32);
            this.voirLesDétailsToolStripMenuItem.Text = "Voir les détails";
            this.voirLesDétailsToolStripMenuItem.Click += new System.EventHandler(this.voirLesDétailsToolStripMenuItem_Click);
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(197, 32);
            this.modifierToolStripMenuItem.Text = "Modifier";
            this.modifierToolStripMenuItem.Click += new System.EventHandler(this.modifierToolStripMenuItem_Click);
            // 
            // activerToolStripMenuItem
            // 
            this.activerToolStripMenuItem.Name = "activerToolStripMenuItem";
            this.activerToolStripMenuItem.Size = new System.Drawing.Size(197, 32);
            this.activerToolStripMenuItem.Text = "Activer";
            this.activerToolStripMenuItem.Click += new System.EventHandler(this.activerToolStripMenuItem_Click);
            // 
            // desactiverToolStripMenuItem
            // 
            this.desactiverToolStripMenuItem.Name = "desactiverToolStripMenuItem";
            this.desactiverToolStripMenuItem.Size = new System.Drawing.Size(197, 32);
            this.desactiverToolStripMenuItem.Text = "Desactiver";
            this.desactiverToolStripMenuItem.Click += new System.EventHandler(this.desactiverToolStripMenuItem_Click);
            // 
            // uc_Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvListTypeAbonnement);
            this.Controls.Add(this.btnAjouterType);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "uc_Test";
            this.Size = new System.Drawing.Size(1125, 678);
            this.Load += new System.EventHandler(this.uc_Test_Load);
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
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.ComboBox cbRechercher;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValeur;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.Button btnAjouterType;
        private System.Windows.Forms.DataGridView dgvListTypeAbonnement;
        private System.Windows.Forms.ContextMenuStrip cmsabonnement;
        private System.Windows.Forms.ToolStripMenuItem voirLesDétailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desactiverToolStripMenuItem;
    }
}
