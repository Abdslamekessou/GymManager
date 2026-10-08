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
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblFilterRole = new System.Windows.Forms.Label();
            this.cbxFilterRole = new System.Windows.Forms.ComboBox();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.cmsUserOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiAddUser = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEditUser = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiShowDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiToggleStatus = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiDeleteUser = new System.Windows.Forms.ToolStripMenuItem();
            this.gbSearchFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.cmsUserOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(23, 15);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(278, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Liste des utilisateurs";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblSubtitle.Location = new System.Drawing.Point(26, 55);
            this.lblSubtitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(414, 21);
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
            this.gbSearchFilter.Controls.Add(this.btnSearch);
            this.gbSearchFilter.Controls.Add(this.lblFilterRole);
            this.gbSearchFilter.Controls.Add(this.cbxFilterRole);
            this.gbSearchFilter.Location = new System.Drawing.Point(23, 92);
            this.gbSearchFilter.Margin = new System.Windows.Forms.Padding(4);
            this.gbSearchFilter.Name = "gbSearchFilter";
            this.gbSearchFilter.Padding = new System.Windows.Forms.Padding(4);
            this.gbSearchFilter.Size = new System.Drawing.Size(1101, 117);
            this.gbSearchFilter.TabIndex = 2;
            this.gbSearchFilter.TabStop = false;
            // 
            // lblSearchBy
            // 
            this.lblSearchBy.AutoSize = true;
            this.lblSearchBy.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSearchBy.Location = new System.Drawing.Point(18, 27);
            this.lblSearchBy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearchBy.Name = "lblSearchBy";
            this.lblSearchBy.Size = new System.Drawing.Size(122, 21);
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
            this.cbxSearchBy.Location = new System.Drawing.Point(140, 23);
            this.cbxSearchBy.Margin = new System.Windows.Forms.Padding(4);
            this.cbxSearchBy.Name = "cbxSearchBy";
            this.cbxSearchBy.Size = new System.Drawing.Size(174, 29);
            this.cbxSearchBy.TabIndex = 1;
            this.cbxSearchBy.SelectedIndexChanged += new System.EventHandler(this.cbxSearchBy_SelectedIndexChanged);
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblValue.Location = new System.Drawing.Point(332, 27);
            this.lblValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(61, 21);
            this.lblValue.TabIndex = 2;
            this.lblValue.Text = "Valeur :";
            // 
            // txtSearchValue
            // 
            this.txtSearchValue.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtSearchValue.Location = new System.Drawing.Point(397, 23);
            this.txtSearchValue.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchValue.Name = "txtSearchValue";
            this.txtSearchValue.Size = new System.Drawing.Size(349, 29);
            this.txtSearchValue.TabIndex = 3;
            this.txtSearchValue.TextChanged += new System.EventHandler(this.txtSearchValue_TextChanged);
            this.txtSearchValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchValue_KeyPress);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSearch.Location = new System.Drawing.Point(758, 21);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(128, 36);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "🔍 Rechercher";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // lblFilterRole
            // 
            this.lblFilterRole.AutoSize = true;
            this.lblFilterRole.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblFilterRole.Location = new System.Drawing.Point(18, 71);
            this.lblFilterRole.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFilterRole.Name = "lblFilterRole";
            this.lblFilterRole.Size = new System.Drawing.Size(116, 21);
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
            this.cbxFilterRole.Location = new System.Drawing.Point(140, 68);
            this.cbxFilterRole.Margin = new System.Windows.Forms.Padding(4);
            this.cbxFilterRole.Name = "cbxFilterRole";
            this.cbxFilterRole.Size = new System.Drawing.Size(174, 29);
            this.cbxFilterRole.TabIndex = 6;
            this.cbxFilterRole.SelectedIndexChanged += new System.EventHandler(this.cbxFilterRole_SelectedIndexChanged);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddUser.Location = new System.Drawing.Point(938, 222);
            this.btnAddUser.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(187, 39);
            this.btnAddUser.TabIndex = 3;
            this.btnAddUser.Text = "+ Ajouter un utilisateur";
            this.btnAddUser.UseVisualStyleBackColor = true;
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
            this.dgvUsers.Location = new System.Drawing.Point(23, 271);
            this.dgvUsers.Margin = new System.Windows.Forms.Padding(4);
            this.dgvUsers.MultiSelect = false;
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RowHeadersWidth = 51;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(1101, 468);
            this.dgvUsers.TabIndex = 4;
            // 
            // cmsUserOptions
            // 
            this.cmsUserOptions.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsUserOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAddUser,
            this.tsmiEditUser,
            this.tsmiShowDetails,
            this.tsmiToggleStatus,
            this.toolStripSeparator1,
            this.tsmiDeleteUser});
            this.cmsUserOptions.Name = "cmsUserOptions";
            this.cmsUserOptions.Size = new System.Drawing.Size(509, 130);
            // 
            // tsmiAddUser
            // 
            this.tsmiAddUser.Name = "tsmiAddUser";
            this.tsmiAddUser.Size = new System.Drawing.Size(508, 24);
            this.tsmiAddUser.Text = "+ Ajouter un utilisateur";
            // 
            // tsmiEditUser
            // 
            this.tsmiEditUser.Name = "tsmiEditUser";
            this.tsmiEditUser.Size = new System.Drawing.Size(508, 24);
            this.tsmiEditUser.Text = "✏ Modifier les données de l\'utilisateur";
            // 
            // tsmiShowDetails
            // 
            this.tsmiShowDetails.Name = "tsmiShowDetails";
            this.tsmiShowDetails.Size = new System.Drawing.Size(508, 24);
            this.tsmiShowDetails.Text = "👁 Afficher les détails de l\'utilisateur";
            // 
            // tsmiToggleStatus
            // 
            this.tsmiToggleStatus.Name = "tsmiToggleStatus";
            this.tsmiToggleStatus.Size = new System.Drawing.Size(508, 24);
            this.tsmiToggleStatus.Text = "🔄 Activer / Désactiver le compte utilisateur";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(505, 6);
            // 
            // tsmiDeleteUser
            // 
            this.tsmiDeleteUser.Name = "tsmiDeleteUser";
            this.tsmiDeleteUser.Size = new System.Drawing.Size(508, 24);
            this.tsmiDeleteUser.Text = "🗑 Supprimer l\'utilisateur uniquement s\'il n\'a aucune donnée liée";
            // 
            // frmListUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1148, 764);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.gbSearchFilter);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1047, 728);
            this.Name = "frmListUser";
            this.Padding = new System.Windows.Forms.Padding(23, 18, 23, 18);
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
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblFilterRole;
        private System.Windows.Forms.ComboBox cbxFilterRole;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.ContextMenuStrip cmsUserOptions;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddUser;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditUser;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowDetails;
        private System.Windows.Forms.ToolStripMenuItem tsmiToggleStatus;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeleteUser;
    }
}