namespace GymManager.Presentation.Utilisateurs.Controls
{
    partial class ucListeUtilisateurs
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxSearchBy = new System.Windows.Forms.ComboBox();
            this.txtSearchValue = new System.Windows.Forms.TextBox();
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
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.cmsUserOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Liste des utilisateurs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(450, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gérez les comptes utilisateurs enregistrés dans le système.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxFilterRole);
            this.groupBox1.Controls.Add(this.txtSearchValue);
            this.groupBox1.Controls.Add(this.cbxSearchBy);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(18, 131);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1364, 98);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recherche et filtrage";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Filtre Par:";
            // 
            // cbxSearchBy
            // 
            this.cbxSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSearchBy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSearchBy.FormattingEnabled = true;
            this.cbxSearchBy.Items.AddRange(new object[] {
            "None",
            "Nom d\'utilisateur",
            "Nom complet",
            "Utilisateur ID",
            "Role"});
            this.cbxSearchBy.Location = new System.Drawing.Point(121, 42);
            this.cbxSearchBy.Name = "cbxSearchBy";
            this.cbxSearchBy.Size = new System.Drawing.Size(282, 33);
            this.cbxSearchBy.TabIndex = 4;
            this.cbxSearchBy.SelectedIndexChanged += new System.EventHandler(this.cbxSearchBy_SelectedIndexChanged);
            // 
            // txtSearchValue
            // 
            this.txtSearchValue.Location = new System.Drawing.Point(471, 42);
            this.txtSearchValue.Multiline = true;
            this.txtSearchValue.Name = "txtSearchValue";
            this.txtSearchValue.Size = new System.Drawing.Size(298, 33);
            this.txtSearchValue.TabIndex = 5;
            this.txtSearchValue.TextChanged += new System.EventHandler(this.txtSearchValue_TextChanged);
            this.txtSearchValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchValue_KeyPress);
            // 
            // cbxFilterRole
            // 
            this.cbxFilterRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFilterRole.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxFilterRole.FormattingEnabled = true;
            this.cbxFilterRole.Items.AddRange(new object[] {
            "Tous les rôles",
            "Admin",
            "Récep"});
            this.cbxFilterRole.Location = new System.Drawing.Point(471, 42);
            this.cbxFilterRole.Name = "cbxFilterRole";
            this.cbxFilterRole.Size = new System.Drawing.Size(298, 33);
            this.cbxFilterRole.TabIndex = 6;
            this.cbxFilterRole.SelectedIndexChanged += new System.EventHandler(this.cbxFilterRole_SelectedIndexChanged);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.Location = new System.Drawing.Point(1129, 247);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(253, 51);
            this.btnAddUser.TabIndex = 3;
            this.btnAddUser.Text = "+ Ajouter un utilisateur";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.BackgroundColor = System.Drawing.Color.White;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.ContextMenuStrip = this.cmsUserOptions;
            this.dgvUsers.Location = new System.Drawing.Point(18, 324);
            this.dgvUsers.MultiSelect = false;
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RowHeadersWidth = 62;
            this.dgvUsers.RowTemplate.Height = 28;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(1364, 408);
            this.dgvUsers.TabIndex = 4;
            this.dgvUsers.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvUsers_CellMouseDown);
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
            this.cmsUserOptions.Size = new System.Drawing.Size(441, 234);
            this.cmsUserOptions.Opening += new System.ComponentModel.CancelEventHandler(this.cmsUserOptions_Opening);
            // 
            // tsmiAddUser
            // 
            this.tsmiAddUser.Name = "tsmiAddUser";
            this.tsmiAddUser.Size = new System.Drawing.Size(440, 32);
            this.tsmiAddUser.Text = "+ Ajouter un utilisateur";
            this.tsmiAddUser.Click += new System.EventHandler(this.tsmiAddUser_Click);
            // 
            // tsmiEditUser
            // 
            this.tsmiEditUser.Name = "tsmiEditUser";
            this.tsmiEditUser.Size = new System.Drawing.Size(440, 32);
            this.tsmiEditUser.Text = "Modifier les données de l\'utilisateur";
            this.tsmiEditUser.Click += new System.EventHandler(this.tsmiEditUser_Click);
            // 
            // tsmiShowDetails
            // 
            this.tsmiShowDetails.Name = "tsmiShowDetails";
            this.tsmiShowDetails.Size = new System.Drawing.Size(440, 32);
            this.tsmiShowDetails.Text = "Afficher les détails de l\'utilisateur";
            this.tsmiShowDetails.Click += new System.EventHandler(this.tsmiShowDetails_Click);
            // 
            // tsmiActiver
            // 
            this.tsmiActiver.Name = "tsmiActiver";
            this.tsmiActiver.Size = new System.Drawing.Size(440, 32);
            this.tsmiActiver.Text = "Activer";
            this.tsmiActiver.Click += new System.EventHandler(this.tsmiActiver_Click);
            // 
            // tsmiDesactiver
            // 
            this.tsmiDesactiver.Name = "tsmiDesactiver";
            this.tsmiDesactiver.Size = new System.Drawing.Size(440, 32);
            this.tsmiDesactiver.Text = "Désactiver";
            this.tsmiDesactiver.Click += new System.EventHandler(this.tsmiDesactiver_Click);
            // 
            // changerLeMotDePasseToolStripMenuItem
            // 
            this.changerLeMotDePasseToolStripMenuItem.Name = "changerLeMotDePasseToolStripMenuItem";
            this.changerLeMotDePasseToolStripMenuItem.Size = new System.Drawing.Size(440, 32);
            this.changerLeMotDePasseToolStripMenuItem.Text = "Changer le mot de passe";
            this.changerLeMotDePasseToolStripMenuItem.Click += new System.EventHandler(this.changerLeMotDePasseToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(437, 6);
            // 
            // tsmiDeleteUser
            // 
            this.tsmiDeleteUser.Name = "tsmiDeleteUser";
            this.tsmiDeleteUser.Size = new System.Drawing.Size(440, 32);
            this.tsmiDeleteUser.Text = "Supprimer l\'utilisateur (si aucune donnée liée)";
            this.tsmiDeleteUser.Click += new System.EventHandler(this.tsmiDeleteUser_Click);
            // 
            // ucListeUtilisateurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ucListeUtilisateurs";
            this.Size = new System.Drawing.Size(1404, 751);
            this.Load += new System.EventHandler(this.ucListeUtilisateurs_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.cmsUserOptions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxSearchBy;
        private System.Windows.Forms.TextBox txtSearchValue;
        private System.Windows.Forms.ComboBox cbxFilterRole;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.ContextMenuStrip cmsUserOptions;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddUser;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditUser;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowDetails;
        private System.Windows.Forms.ToolStripMenuItem tsmiActiver;
        private System.Windows.Forms.ToolStripMenuItem tsmiDesactiver;
        private System.Windows.Forms.ToolStripMenuItem changerLeMotDePasseToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeleteUser;
    }
}