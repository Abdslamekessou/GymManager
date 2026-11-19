
namespace GymManager.Presentation.Utilisateurs.Controls
{
    partial class ucListeUtilisateurs
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlActions;
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

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxFilterRole = new System.Windows.Forms.ComboBox();
            this.txtSearchValue = new System.Windows.Forms.TextBox();
            this.cbxSearchBy = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlActions = new System.Windows.Forms.Panel();
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
            this.UtilisateurID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonneID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomComplet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomUtilisateur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Etat = new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.tlpMain.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnlActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.cmsUserOptions.SuspendLayout();
            this.SuspendLayout();

            // 
            // tlpMain
            // 
            this.tlpMain.BackColor = System.Drawing.Color.FromArgb(243, 244, 246);
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(
                    System.Windows.Forms.SizeType.Percent, 100F));

            this.tlpMain.Controls.Add(this.pnlHeader, 0, 0);
            this.tlpMain.Controls.Add(this.groupBox1, 0, 1);
            this.tlpMain.Controls.Add(this.pnlActions, 0, 2);
            this.tlpMain.Controls.Add(this.dgvUsers, 0, 3);

            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Margin = new System.Windows.Forms.Padding(0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.Padding = new System.Windows.Forms.Padding(22, 18, 22, 18);
            this.tlpMain.RowCount = 4;

            this.tlpMain.RowStyles.Add(
                new System.Windows.Forms.RowStyle(
                    System.Windows.Forms.SizeType.Absolute, 88F));

            this.tlpMain.RowStyles.Add(
                new System.Windows.Forms.RowStyle(
                    System.Windows.Forms.SizeType.Absolute, 104F));

            this.tlpMain.RowStyles.Add(
                new System.Windows.Forms.RowStyle(
                    System.Windows.Forms.SizeType.Absolute, 58F));

            this.tlpMain.RowStyles.Add(
                new System.Windows.Forms.RowStyle(
                    System.Windows.Forms.SizeType.Percent, 100F));

            this.tlpMain.Size = new System.Drawing.Size(1404, 751);
            this.tlpMain.TabIndex = 0;

            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.Transparent;
            this.pnlHeader.Controls.Add(this.label1);
            this.pnlHeader.Controls.Add(this.label2);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHeader.Location = new System.Drawing.Point(22, 18);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1360, 80);
            this.pnlHeader.TabIndex = 0;

            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font(
                "Segoe UI", 21F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(16, 26, 45);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(423, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Liste des utilisateurs";

            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.label2.Location = new System.Drawing.Point(3, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(514, 28);
            this.label2.TabIndex = 1;
            this.label2.Text =
                "Gérez les comptes utilisateurs enregistrés dans le système.";

            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.cbxFilterRole);
            this.groupBox1.Controls.Add(this.txtSearchValue);
            this.groupBox1.Controls.Add(this.cbxSearchBy);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(23, 32, 51);
            this.groupBox1.Location = new System.Drawing.Point(22, 106);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(14, 12, 14, 12);
            this.groupBox1.Size = new System.Drawing.Size(1360, 94);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;

            // 
            // cbxFilterRole
            // 
            this.cbxFilterRole.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.cbxFilterRole.Font = new System.Drawing.Font(
                "Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            this.cbxFilterRole.FormattingEnabled = true;
            this.cbxFilterRole.Items.AddRange(new object[] {
                "Tous les rôles",
                "Admin",
                "Récep"
            });

            this.cbxFilterRole.Location = new System.Drawing.Point(471, 46);
            this.cbxFilterRole.Name = "cbxFilterRole";
            this.cbxFilterRole.Size = new System.Drawing.Size(301, 40);
            this.cbxFilterRole.TabIndex = 6;
            this.cbxFilterRole.SelectedIndexChanged +=
                new System.EventHandler(this.cbxFilterRole_SelectedIndexChanged);

            // 
            // txtSearchValue
            // 
            this.txtSearchValue.BackColor = System.Drawing.Color.White;
            this.txtSearchValue.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            this.txtSearchValue.Font = new System.Drawing.Font(
                "Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            this.txtSearchValue.ForeColor =
                System.Drawing.Color.FromArgb(23, 32, 51);

            this.txtSearchValue.Location = new System.Drawing.Point(471, 46);
            this.txtSearchValue.Name = "txtSearchValue";
            this.txtSearchValue.Size = new System.Drawing.Size(533, 39);
            this.txtSearchValue.TabIndex = 5;

            this.txtSearchValue.TextChanged +=
                new System.EventHandler(this.txtSearchValue_TextChanged);

            this.txtSearchValue.KeyPress +=
                new System.Windows.Forms.KeyPressEventHandler(
                    this.txtSearchValue_KeyPress);

            // 
            // cbxSearchBy
            // 
            this.cbxSearchBy.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbxSearchBy.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.cbxSearchBy.Font = new System.Drawing.Font(
                "Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            this.cbxSearchBy.FormattingEnabled = true;
            this.cbxSearchBy.Items.AddRange(new object[] {
                "None",
                "Nom d'utilisateur",
                "Nom complet",
                "Utilisateur ID",
                "Role"
            });

            this.cbxSearchBy.Location = new System.Drawing.Point(167, 46);
            this.cbxSearchBy.Name = "cbxSearchBy";
            this.cbxSearchBy.Size = new System.Drawing.Size(280, 40);
            this.cbxSearchBy.TabIndex = 4;

            this.cbxSearchBy.SelectedIndexChanged +=
                new System.EventHandler(this.cbxSearchBy_SelectedIndexChanged);

            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font(
                "Segoe UI", 12F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            this.label3.ForeColor =
                System.Drawing.Color.FromArgb(71, 85, 105);

            this.label3.Location = new System.Drawing.Point(20, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Filtrer par :";

            // 
            // pnlActions
            // 
            this.pnlActions.BackColor = System.Drawing.Color.FromArgb(243, 244, 246);
            this.pnlActions.Controls.Add(this.btnAddUser);
            this.pnlActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlActions.Location = new System.Drawing.Point(22, 210);
            this.pnlActions.Margin = new System.Windows.Forms.Padding(0);
            this.pnlActions.Name = "pnlActions";
            this.pnlActions.Size = new System.Drawing.Size(1360, 58);
            this.pnlActions.TabIndex = 2;

            // 
            // btnAddUser
            // 
            this.btnAddUser.Anchor =
                ((System.Windows.Forms.AnchorStyles)
                ((System.Windows.Forms.AnchorStyles.Top |
                  System.Windows.Forms.AnchorStyles.Right)));

            this.btnAddUser.BackColor =
                System.Drawing.Color.FromArgb(37, 99, 235);

            this.btnAddUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddUser.FlatAppearance.BorderSize = 0;

            this.btnAddUser.FlatAppearance.MouseDownBackColor =
                System.Drawing.Color.FromArgb(29, 78, 216);

            this.btnAddUser.FlatAppearance.MouseOverBackColor =
                System.Drawing.Color.FromArgb(29, 78, 216);

            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            this.btnAddUser.Font = new System.Drawing.Font(
                "Segoe UI", 10F, System.Drawing.FontStyle.Bold);

            this.btnAddUser.ForeColor = System.Drawing.Color.White;
            this.btnAddUser.Location = new System.Drawing.Point(1090, 7);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(270, 44);
            this.btnAddUser.TabIndex = 3;
            this.btnAddUser.Text = "+   Ajouter un utilisateur";
            this.btnAddUser.UseVisualStyleBackColor = false;

            this.btnAddUser.Click +=
                new System.EventHandler(this.btnAddUser_Click);

            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.AllowUserToResizeRows = false;

            this.dgvUsers.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            this.dgvUsers.BackgroundColor = System.Drawing.Color.White;
            this.dgvUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;

            this.dgvUsers.CellBorderStyle =
                System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;

            this.dgvUsers.ColumnHeadersBorderStyle =
                System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            //

            // Default cell style
            dgvUsers.DefaultCellStyle.Alignment =
                System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;

            dgvUsers.DefaultCellStyle.BackColor =
                System.Drawing.Color.White;

            dgvUsers.DefaultCellStyle.ForeColor =
                System.Drawing.Color.FromArgb(23, 32, 51);

            dgvUsers.DefaultCellStyle.Font =
                new System.Drawing.Font("Segoe UI", 11F);

            dgvUsers.DefaultCellStyle.Padding =
                new System.Windows.Forms.Padding(8, 0, 8, 0);

            dgvUsers.DefaultCellStyle.SelectionBackColor =
                System.Drawing.Color.FromArgb(226, 232, 240);

            dgvUsers.DefaultCellStyle.SelectionForeColor =
                System.Drawing.Color.FromArgb(16, 26, 45);

            dgvUsers.DefaultCellStyle.WrapMode =
                System.Windows.Forms.DataGridViewTriState.False;

            // Alternating rows style
            dgvUsers.AlternatingRowsDefaultCellStyle.BackColor =
                System.Drawing.Color.FromArgb(248, 250, 252);

            dgvUsers.AlternatingRowsDefaultCellStyle.ForeColor =
                System.Drawing.Color.FromArgb(23, 32, 51);

            dgvUsers.AlternatingRowsDefaultCellStyle.SelectionBackColor =
                System.Drawing.Color.FromArgb(226, 232, 240);

            dgvUsers.AlternatingRowsDefaultCellStyle.SelectionForeColor =
                System.Drawing.Color.FromArgb(16, 26, 45);

            // General settings
            dgvUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvUsers.EnableHeadersVisualStyles = false;

            dgvUsers.GridColor =
                System.Drawing.Color.FromArgb(220, 225, 230);

            dgvUsers.Location = new System.Drawing.Point(22, 268);
            dgvUsers.Margin = new System.Windows.Forms.Padding(0);
            dgvUsers.MultiSelect = false;
            dgvUsers.Name = "dgvUsers";
            dgvUsers.ReadOnly = true;
            dgvUsers.RowHeadersVisible = false;
            dgvUsers.RowHeadersWidth = 62;

            // Rows default style
            dgvUsers.RowsDefaultCellStyle.SelectionBackColor =
                System.Drawing.SystemColors.GradientActiveCaption;

            dgvUsers.RowTemplate.Height = 40;

            dgvUsers.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            dgvUsers.Size = new System.Drawing.Size(1360, 465);
            dgvUsers.TabIndex = 4;

            dgvUsers.CellMouseDown +=
                new System.Windows.Forms.DataGridViewCellMouseEventHandler(
                    dgvUsers_CellMouseDown);

            // Column headers style
            this.dgvUsers.ColumnHeadersDefaultCellStyle.Alignment =
                System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;

            this.dgvUsers.ColumnHeadersDefaultCellStyle.BackColor =
                System.Drawing.Color.FromArgb(16, 26, 45);

            this.dgvUsers.ColumnHeadersDefaultCellStyle.ForeColor =
                System.Drawing.Color.White;

            this.dgvUsers.ColumnHeadersDefaultCellStyle.Font =
                new System.Drawing.Font(
                    "Segoe UI", 10F, System.Drawing.FontStyle.Bold);

            this.dgvUsers.ColumnHeadersDefaultCellStyle.Padding =
                new System.Windows.Forms.Padding(8, 0, 8, 0);

            this.dgvUsers.ColumnHeadersDefaultCellStyle.SelectionBackColor =
                System.Drawing.Color.FromArgb(16, 26, 45);

            this.dgvUsers.ColumnHeadersDefaultCellStyle.SelectionForeColor =
                System.Drawing.Color.White;

            this.dgvUsers.ColumnHeadersDefaultCellStyle.WrapMode =
                System.Windows.Forms.DataGridViewTriState.True;

            this.dgvUsers.ColumnHeadersHeight = 44;

            this.dgvUsers.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            // Columns
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.UtilisateurID,
                this.PersonneID,
                this.NomComplet,
                this.NomUtilisateur,
                this.NomRole,
                this.Etat
            });

            this.dgvUsers.ContextMenuStrip = this.cmsUserOptions;

            // 
            // cmsUserOptions
            // 
            this.cmsUserOptions.BackColor = System.Drawing.Color.White;
            this.cmsUserOptions.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cmsUserOptions.ForeColor =
                System.Drawing.Color.FromArgb(23, 32, 51);

            this.cmsUserOptions.ImageScalingSize =
                new System.Drawing.Size(20, 20);

            this.cmsUserOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.tsmiAddUser,
                this.tsmiEditUser,
                this.tsmiShowDetails,
                this.tsmiActiver,
                this.tsmiDesactiver,
                this.changerLeMotDePasseToolStripMenuItem,
                this.toolStripSeparator1,
                this.tsmiDeleteUser
            });

            this.cmsUserOptions.Name = "cmsUserOptions";
            this.cmsUserOptions.Size = new System.Drawing.Size(472, 234);

            this.cmsUserOptions.Opening +=
                new System.ComponentModel.CancelEventHandler(
                    this.cmsUserOptions_Opening);

            // 
            // tsmiAddUser
            // 
            this.tsmiAddUser.Name = "tsmiAddUser";
            this.tsmiAddUser.Size = new System.Drawing.Size(471, 32);
            this.tsmiAddUser.Text = "+   Ajouter un utilisateur";

            this.tsmiAddUser.Click +=
                new System.EventHandler(this.tsmiAddUser_Click);

            // 
            // tsmiEditUser
            // 
            this.tsmiEditUser.Name = "tsmiEditUser";
            this.tsmiEditUser.Size = new System.Drawing.Size(471, 32);
            this.tsmiEditUser.Text = "Modifier les données de l'utilisateur";

            this.tsmiEditUser.Click +=
                new System.EventHandler(this.tsmiEditUser_Click);

            // 
            // tsmiShowDetails
            // 
            this.tsmiShowDetails.Name = "tsmiShowDetails";
            this.tsmiShowDetails.Size = new System.Drawing.Size(471, 32);
            this.tsmiShowDetails.Text = "Afficher les détails de l'utilisateur";

            this.tsmiShowDetails.Click +=
                new System.EventHandler(this.tsmiShowDetails_Click);

            // 
            // tsmiActiver
            // 
            this.tsmiActiver.Name = "tsmiActiver";
            this.tsmiActiver.Size = new System.Drawing.Size(471, 32);
            this.tsmiActiver.Text = "Activer";

            this.tsmiActiver.Click +=
                new System.EventHandler(this.tsmiActiver_Click);

            // 
            // tsmiDesactiver
            // 
            this.tsmiDesactiver.Name = "tsmiDesactiver";
            this.tsmiDesactiver.Size = new System.Drawing.Size(471, 32);
            this.tsmiDesactiver.Text = "Désactiver";

            this.tsmiDesactiver.Click +=
                new System.EventHandler(this.tsmiDesactiver_Click);

            // 
            // changerLeMotDePasseToolStripMenuItem
            // 
            this.changerLeMotDePasseToolStripMenuItem.Name =
                "changerLeMotDePasseToolStripMenuItem";

            this.changerLeMotDePasseToolStripMenuItem.Size =
                new System.Drawing.Size(471, 32);

            this.changerLeMotDePasseToolStripMenuItem.Text =
                "Changer le mot de passe";

            this.changerLeMotDePasseToolStripMenuItem.Click +=
                new System.EventHandler(
                    this.changerLeMotDePasseToolStripMenuItem_Click);

            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(468, 6);

            // 
            // tsmiDeleteUser
            // 
            this.tsmiDeleteUser.ForeColor =
                System.Drawing.Color.FromArgb(220, 38, 38);

            this.tsmiDeleteUser.Name = "tsmiDeleteUser";
            this.tsmiDeleteUser.Size = new System.Drawing.Size(471, 32);

            this.tsmiDeleteUser.Text =
                "Supprimer l'utilisateur (si aucune donnée liée)";

            this.tsmiDeleteUser.Click +=
                new System.EventHandler(this.tsmiDeleteUser_Click);

            // 
            // UtilisateurID
            // 
            this.UtilisateurID.AutoSizeMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;

            this.UtilisateurID.DataPropertyName = "UtilisateurID";
            this.UtilisateurID.HeaderText = "Utilisateur ID";
            this.UtilisateurID.MinimumWidth = 8;
            this.UtilisateurID.Name = "UtilisateurID";
            this.UtilisateurID.ReadOnly = true;
            this.UtilisateurID.Width = 178;

            // 
            // PersonneID
            // 
            this.PersonneID.AutoSizeMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;

            this.PersonneID.DataPropertyName = "PersonneID";
            this.PersonneID.HeaderText = "Personne ID";
            this.PersonneID.MinimumWidth = 8;
            this.PersonneID.Name = "PersonneID";
            this.PersonneID.ReadOnly = true;
            this.PersonneID.Width = 170;

            // 
            // NomComplet
            // 
            this.NomComplet.AutoSizeMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;

            this.NomComplet.DataPropertyName = "NomComplet";
            this.NomComplet.HeaderText = "Nom et Prénom";
            this.NomComplet.MinimumWidth = 8;
            this.NomComplet.Name = "NomComplet";
            this.NomComplet.ReadOnly = true;

            // 
            // NomUtilisateur
            // 
            this.NomUtilisateur.AutoSizeMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;

            this.NomUtilisateur.DataPropertyName = "NomUtilisateur";
            this.NomUtilisateur.HeaderText = "Nom d' Utilisateur";
            this.NomUtilisateur.MinimumWidth = 180;
            this.NomUtilisateur.Name = "NomUtilisateur";
            this.NomUtilisateur.ReadOnly = true;

            // 
            // NomRole
            // 
            this.NomRole.AutoSizeMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;

            this.NomRole.DataPropertyName = "NomRole";
            this.NomRole.HeaderText = "Role";
            this.NomRole.MinimumWidth = 150;
            this.NomRole.Name = "NomRole";
            this.NomRole.ReadOnly = true;

            // 
            // Etat
            // 
            this.Etat.AutoSizeMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;

            this.Etat.DataPropertyName = "Etat";
            this.Etat.HeaderText = "Etat";
            this.Etat.MinimumWidth = 8;
            this.Etat.Name = "Etat";
            this.Etat.ReadOnly = true;
            this.Etat.Width = 96;

            // 
            // ucListeUtilisateurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(243, 244, 246);

            this.Controls.Add(this.tlpMain);

            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "ucListeUtilisateurs";
            this.Size = new System.Drawing.Size(1404, 751);

            this.Load +=
                new System.EventHandler(this.ucListeUtilisateurs_Load);

            this.tlpMain.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlActions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.cmsUserOptions.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn UtilisateurID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonneID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomComplet;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomUtilisateur;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn Etat;
    }
}
