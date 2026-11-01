using System.Windows.Forms;
 namespace GymManager.Presentation
{
    partial class frmListUser
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.gbSearchFilter = new System.Windows.Forms.GroupBox();
            this.lblSearchBy = new System.Windows.Forms.Label();
            this.cbxSearchBy = new System.Windows.Forms.ComboBox();
            this.lblValue = new System.Windows.Forms.Label();
            this.txtSearchValue = new System.Windows.Forms.TextBox();
            this.lblFilterRole = new System.Windows.Forms.Label();
            this.cbxFilterRole = new System.Windows.Forms.ComboBox();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.cmsUserOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiAddUser = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEditUser = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiShowDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiActiver = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDesactiver = new System.Windows.Forms.ToolStripMenuItem();
            this.changerLeMotDePasseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiDeleteUser = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.gbSearchFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.cmsUserOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(30, 19);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(321, 45);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Liste des utilisateurs";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblSubtitle.Location = new System.Drawing.Point(33, 69);
            this.lblSubtitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(501, 25);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Gérez les comptes utilisateurs enregistrés dans le système.";
            // 
            // gbSearchFilter
            // 
            this.gbSearchFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSearchFilter.Controls.Add(this.lblSearchBy);
            this.gbSearchFilter.Controls.Add(this.cbxSearchBy);
            this.gbSearchFilter.Controls.Add(this.lblValue);
            this.gbSearchFilter.Controls.Add(this.txtSearchValue);
            this.gbSearchFilter.Controls.Add(this.lblFilterRole);
            this.gbSearchFilter.Controls.Add(this.cbxFilterRole);
            this.gbSearchFilter.Location = new System.Drawing.Point(30, 115);
            this.gbSearchFilter.Margin = new System.Windows.Forms.Padding(5);
            this.gbSearchFilter.Name = "gbSearchFilter";
            this.gbSearchFilter.Padding = new System.Windows.Forms.Padding(5);
            this.gbSearchFilter.Size = new System.Drawing.Size(1416, 146);
            this.gbSearchFilter.TabIndex = 2;
            this.gbSearchFilter.TabStop = false;
            // 
            // lblSearchBy
            // 
            this.lblSearchBy.AutoSize = true;
            this.lblSearchBy.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSearchBy.Location = new System.Drawing.Point(23, 34);
            this.lblSearchBy.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSearchBy.Name = "lblSearchBy";
            this.lblSearchBy.Size = new System.Drawing.Size(148, 25);
            this.lblSearchBy.TabIndex = 0;
            this.lblSearchBy.Text = "Rechercher par :";
            // 
            // cbxSearchBy
            // 
            this.cbxSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSearchBy.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cbxSearchBy.FormattingEnabled = true;
            this.cbxSearchBy.Items.AddRange(new object[] {
            "None",
            "Nom d\'utilisateur",
            "Nom complet",
            "Utilisateur ID",
            "NomRole"});
            this.cbxSearchBy.Location = new System.Drawing.Point(180, 29);
            this.cbxSearchBy.Margin = new System.Windows.Forms.Padding(5);
            this.cbxSearchBy.Name = "cbxSearchBy";
            this.cbxSearchBy.Size = new System.Drawing.Size(223, 33);
            this.cbxSearchBy.TabIndex = 1;
            this.cbxSearchBy.SelectedIndexChanged += new System.EventHandler(this.cbxSearchBy_SelectedIndexChanged);
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblValue.Location = new System.Drawing.Point(427, 34);
            this.lblValue.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(75, 25);
            this.lblValue.TabIndex = 2;
            this.lblValue.Text = "Valeur :";
            // 
            // txtSearchValue
            // 
            this.txtSearchValue.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtSearchValue.Location = new System.Drawing.Point(510, 29);
            this.txtSearchValue.Margin = new System.Windows.Forms.Padding(5);
            this.txtSearchValue.Name = "txtSearchValue";
            this.txtSearchValue.Size = new System.Drawing.Size(448, 33);
            this.txtSearchValue.TabIndex = 3;
            this.txtSearchValue.TextChanged += new System.EventHandler(this.txtSearchValue_TextChanged);
            this.txtSearchValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchValue_KeyPress);
            // 
            // lblFilterRole
            // 
            this.lblFilterRole.AutoSize = true;
            this.lblFilterRole.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblFilterRole.Location = new System.Drawing.Point(23, 89);
            this.lblFilterRole.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblFilterRole.Name = "lblFilterRole";
            this.lblFilterRole.Size = new System.Drawing.Size(141, 25);
            this.lblFilterRole.TabIndex = 5;
            this.lblFilterRole.Text = "Filtrer par rôle :";
            // 
            // cbxFilterRole
            // 
            this.cbxFilterRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFilterRole.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cbxFilterRole.FormattingEnabled = true;
            this.cbxFilterRole.Items.AddRange(new object[] {
            "Tous les rôles",
            "Admin",
            "Récep"});
            this.cbxFilterRole.Location = new System.Drawing.Point(180, 85);
            this.cbxFilterRole.Margin = new System.Windows.Forms.Padding(5);
            this.cbxFilterRole.Name = "cbxFilterRole";
            this.cbxFilterRole.Size = new System.Drawing.Size(223, 33);
            this.cbxFilterRole.TabIndex = 6;
            this.cbxFilterRole.SelectedIndexChanged += new System.EventHandler(this.cbxFilterRole_SelectedIndexChanged);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddUser.Location = new System.Drawing.Point(1206, 278);
            this.btnAddUser.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(240, 49);
            this.btnAddUser.TabIndex = 3;
            this.btnAddUser.Text = "+ Ajouter un utilisateur";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsers.BackgroundColor = System.Drawing.Color.White;
            this.dgvUsers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.ContextMenuStrip = this.cmsUserOptions;
            this.dgvUsers.Location = new System.Drawing.Point(30, 339);
            this.dgvUsers.Margin = new System.Windows.Forms.Padding(5);
            this.dgvUsers.MultiSelect = false;
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RowHeadersWidth = 51;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(1416, 585);
            this.dgvUsers.TabIndex = 4;
            // 
            // cmsUserOptions
            // 
            this.cmsUserOptions.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsUserOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAddUser,
            this.tsmiEditUser,
            this.tsmiShowDetails,
            this.tsmiActiver,
            this.tsmiDesactiver,
            this.changerLeMotDePasseToolStripMenuItem,
            this.toolStripSeparator1,
            this.tsmiDeleteUser});
            this.cmsUserOptions.Name = "cmsUserOptions";
            this.cmsUserOptions.Size = new System.Drawing.Size(597, 234);
            // 
            // tsmiAddUser
            // 
            this.tsmiAddUser.Name = "tsmiAddUser";
            this.tsmiAddUser.Size = new System.Drawing.Size(596, 32);
            this.tsmiAddUser.Text = "+ Ajouter un utilisateur";
            this.tsmiAddUser.Click += new System.EventHandler(this.tsmiAddUser_Click);
            // 
            // tsmiEditUser
            // 
            this.tsmiEditUser.Name = "tsmiEditUser";
            this.tsmiEditUser.Size = new System.Drawing.Size(596, 32);
            this.tsmiEditUser.Text = "✏ Modifier les données de l\'utilisateur";
            this.tsmiEditUser.Click += new System.EventHandler(this.tsmiEditUser_Click);
            // 
            // tsmiShowDetails
            // 
            this.tsmiShowDetails.Name = "tsmiShowDetails";
            this.tsmiShowDetails.Size = new System.Drawing.Size(596, 32);
            this.tsmiShowDetails.Text = "👁 Afficher les détails de l\'utilisateur";
            this.tsmiShowDetails.Click += new System.EventHandler(this.tsmiShowDetails_Click);
            // 
            // tsmiActiver
            // 
            this.tsmiActiver.Name = "tsmiActiver";
            this.tsmiActiver.Size = new System.Drawing.Size(596, 32);
            this.tsmiActiver.Text = "▶️ Activer";
            this.tsmiActiver.Click += new System.EventHandler(this.tsmiActiver_Click);
            // 
            // tsmiDesactiver
            // 
            this.tsmiDesactiver.Name = "tsmiDesactiver";
            this.tsmiDesactiver.Size = new System.Drawing.Size(596, 32);
            this.tsmiDesactiver.Text = "🚫 Désactiver";
            this.tsmiDesactiver.Click += new System.EventHandler(this.tsmiDesactiver_Click);
            // 
            // changerLeMotDePasseToolStripMenuItem
            // 
            this.changerLeMotDePasseToolStripMenuItem.Name = "changerLeMotDePasseToolStripMenuItem";
            this.changerLeMotDePasseToolStripMenuItem.Size = new System.Drawing.Size(596, 32);
            this.changerLeMotDePasseToolStripMenuItem.Text = "🔄Changer le mot de passe";
            this.changerLeMotDePasseToolStripMenuItem.Click += new System.EventHandler(this.changerLeMotDePasseToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(593, 6);
            // 
            // tsmiDeleteUser
            // 
            this.tsmiDeleteUser.Name = "tsmiDeleteUser";
            this.tsmiDeleteUser.Size = new System.Drawing.Size(596, 32);
            this.tsmiDeleteUser.Text = "🗑 Supprimer l\'utilisateur uniquement s\'il n\'a aucune donnée liée";
            this.tsmiDeleteUser.Click += new System.EventHandler(this.tsmiDeleteUser_Click);
            // 
            // tsmiChangePassword
            // 
            this.tsmiChangePassword.Name = "tsmiChangePassword";
            this.tsmiChangePassword.Size = new System.Drawing.Size(214, 24);
            this.tsmiChangePassword.Text = "Changer le mot de passe";
            // 
            // frmListUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1476, 955);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.gbSearchFilter);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(1340, 896);
            this.Name = "frmListUser";
            this.Padding = new System.Windows.Forms.Padding(30, 22, 30, 22);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liste des utilisateurs";
            this.Load += new System.EventHandler(this.frmListUser_Load);
            this.gbSearchFilter.ResumeLayout(false);
            this.gbSearchFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.cmsUserOptions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.GroupBox gbSearchFilter;
        private System.Windows.Forms.Label lblSearchBy;
        private System.Windows.Forms.ComboBox cbxSearchBy;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.TextBox txtSearchValue;
        private System.Windows.Forms.Label lblFilterRole;
        private System.Windows.Forms.ComboBox cbxFilterRole;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.ContextMenuStrip cmsUserOptions;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddUser;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditUser;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowDetails;
        private System.Windows.Forms.ToolStripMenuItem tsmiActiver;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeleteUser;
        private System.Windows.Forms.ToolStripMenuItem tsmiChangePassword;
        private ToolStripMenuItem changerLeMotDePasseToolStripMenuItem;
        private ToolStripMenuItem tsmiDesactiver;
    }
}