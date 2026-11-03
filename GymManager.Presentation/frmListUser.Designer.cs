
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GymManager.Presentation
{
    partial class frmListUser
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.gbSearchFilter = new System.Windows.Forms.GroupBox();
            this.lblSearchBy = new System.Windows.Forms.Label();
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
            this.tsmiChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.gbSearchFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.cmsUserOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.lblTitle.Location = new System.Drawing.Point(24, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(360, 48);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Liste des utilisateurs";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblSubtitle.Location = new System.Drawing.Point(27, 60);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(471, 25);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Gérez les comptes utilisateurs enregistrés dans le système.";
            // 
            // gbSearchFilter
            // 
            this.gbSearchFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSearchFilter.Controls.Add(this.lblSearchBy);
            this.gbSearchFilter.Controls.Add(this.cbxSearchBy);
            this.gbSearchFilter.Controls.Add(this.txtSearchValue);
            this.gbSearchFilter.Controls.Add(this.cbxFilterRole);
            this.gbSearchFilter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.gbSearchFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(75)))));
            this.gbSearchFilter.Location = new System.Drawing.Point(24, 100);
            this.gbSearchFilter.Name = "gbSearchFilter";
            this.gbSearchFilter.Padding = new System.Windows.Forms.Padding(12);
            this.gbSearchFilter.Size = new System.Drawing.Size(1160, 95);
            this.gbSearchFilter.TabIndex = 2;
            this.gbSearchFilter.TabStop = false;
            this.gbSearchFilter.Text = "Recherche et filtrage";
            // 
            // lblSearchBy
            // 
            this.lblSearchBy.AutoSize = true;
            this.lblSearchBy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSearchBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(75)))));
            this.lblSearchBy.Location = new System.Drawing.Point(20, 38);
            this.lblSearchBy.Name = "lblSearchBy";
            this.lblSearchBy.Size = new System.Drawing.Size(96, 25);
            this.lblSearchBy.TabIndex = 0;
            this.lblSearchBy.Text = "Filtrer par :";
            // 
            // cbxSearchBy
            // 
            this.cbxSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSearchBy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbxSearchBy.FormattingEnabled = true;
            this.cbxSearchBy.Items.AddRange(new object[] {
            "None",
            "Nom d\'utilisateur",
            "Nom complet",
            "Utilisateur ID",
            "Role"});
            this.cbxSearchBy.Location = new System.Drawing.Point(110, 34);
            this.cbxSearchBy.Name = "cbxSearchBy";
            this.cbxSearchBy.Size = new System.Drawing.Size(240, 33);
            this.cbxSearchBy.TabIndex = 1;
            this.cbxSearchBy.SelectedIndexChanged += new System.EventHandler(this.cbxSearchBy_SelectedIndexChanged);
            // 
            // txtSearchValue
            // 
            this.txtSearchValue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearchValue.Location = new System.Drawing.Point(390, 34);
            this.txtSearchValue.Name = "txtSearchValue";
            this.txtSearchValue.Size = new System.Drawing.Size(330, 31);
            this.txtSearchValue.TabIndex = 3;
            this.txtSearchValue.TextChanged += new System.EventHandler(this.txtSearchValue_TextChanged);
            this.txtSearchValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchValue_KeyPress);
            // 
            // cbxFilterRole
            // 
            this.cbxFilterRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFilterRole.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbxFilterRole.FormattingEnabled = true;
            this.cbxFilterRole.Items.AddRange(new object[] {
            "Tous les rôles",
            "Admin",
            "Récep"});
            this.cbxFilterRole.Location = new System.Drawing.Point(390, 34);
            this.cbxFilterRole.Name = "cbxFilterRole";
            this.cbxFilterRole.Size = new System.Drawing.Size(330, 33);
            this.cbxFilterRole.TabIndex = 6;
            this.cbxFilterRole.SelectedIndexChanged += new System.EventHandler(this.cbxFilterRole_SelectedIndexChanged);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(110)))), ((int)(((byte)(190)))));
            this.btnAddUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddUser.FlatAppearance.BorderSize = 0;
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddUser.ForeColor = System.Drawing.Color.White;
            this.btnAddUser.Location = new System.Drawing.Point(944, 215);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(240, 42);
            this.btnAddUser.TabIndex = 3;
            this.btnAddUser.Text = "+ Ajouter un utilisateur";
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.dgvUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsers.BackgroundColor = System.Drawing.Color.White;
            this.dgvUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUsers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvUsers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUsers.ColumnHeadersHeight = 42;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvUsers.ContextMenuStrip = this.cmsUserOptions;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(235)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsers.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUsers.EnableHeadersVisualStyles = false;
            this.dgvUsers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(234)))), ((int)(((byte)(239)))));
            this.dgvUsers.Location = new System.Drawing.Point(24, 270);
            this.dgvUsers.MultiSelect = false;
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RowHeadersVisible = false;
            this.dgvUsers.RowHeadersWidth = 62;
            this.dgvUsers.RowTemplate.Height = 35;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(1160, 450);
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
            // tsmiChangePassword
            // 
            this.tsmiChangePassword.Name = "tsmiChangePassword";
            this.tsmiChangePassword.Size = new System.Drawing.Size(214, 24);
            this.tsmiChangePassword.Text = "Changer le mot de passe";
            // 
            // frmListUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1208, 760);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.gbSearchFilter);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "frmListUser";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liste des utilisateurs";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
        private System.Windows.Forms.TextBox txtSearchValue;
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
        private System.Windows.Forms.ToolStripMenuItem changerLeMotDePasseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiDesactiver;
    }
}
