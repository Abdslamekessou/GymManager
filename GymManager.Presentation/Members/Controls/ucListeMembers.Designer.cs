using System.Windows.Forms;

namespace GymManager.Presentation.Members.Controls
{
    partial class ucListeMembers
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
            this.grpHeader = new System.Windows.Forms.GroupBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.cbMemberFilterBy = new System.Windows.Forms.ComboBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearchMember = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.grpMembersTable = new System.Windows.Forms.GroupBox();
            this.dgvMembers = new System.Windows.Forms.DataGridView();
            this.colMemberID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGendor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMemberDetails = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colUpdateMember = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colManagesubscriptions = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cmsMember = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpHeader.SuspendLayout();
            this.grpSearch.SuspendLayout();
            this.grpMembersTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).BeginInit();
            this.cmsMember.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpHeader
            // 
            this.grpHeader.Controls.Add(this.lblTitle);
            this.grpHeader.Controls.Add(this.btnAddMember);
            this.grpHeader.Location = new System.Drawing.Point(15, 10);
            this.grpHeader.Name = "grpHeader";
            this.grpHeader.Size = new System.Drawing.Size(1327, 70);
            this.grpHeader.TabIndex = 0;
            this.grpHeader.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(11, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(201, 54);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Membres";
            // 
            // btnAddMember
            // 
            this.btnAddMember.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMember.Location = new System.Drawing.Point(1161, 20);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(145, 35);
            this.btnAddMember.TabIndex = 1;
            this.btnAddMember.Text = "+ Ajouter";
            this.btnAddMember.UseVisualStyleBackColor = true;
            this.btnAddMember.Click += new System.EventHandler(this.btnAddMember_Click);
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.cbMemberFilterBy);
            this.grpSearch.Controls.Add(this.lblSearch);
            this.grpSearch.Controls.Add(this.txtSearchMember);
            this.grpSearch.Controls.Add(this.lblGender);
            this.grpSearch.Controls.Add(this.cmbGender);
            this.grpSearch.Location = new System.Drawing.Point(15, 90);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(1327, 115);
            this.grpSearch.TabIndex = 1;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Recherche et filtres";
            // 
            // cbMemberFilterBy
            // 
            this.cbMemberFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMemberFilterBy.FormattingEnabled = true;
            this.cbMemberFilterBy.Items.AddRange(new object[] {
            "Aucun",
            "Nom",
            "Phone",
            "Email"});
            this.cbMemberFilterBy.Location = new System.Drawing.Point(24, 55);
            this.cbMemberFilterBy.Name = "cbMemberFilterBy";
            this.cbMemberFilterBy.Size = new System.Drawing.Size(210, 24);
            this.cbMemberFilterBy.TabIndex = 128;
            this.cbMemberFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbMemberFilterBy_SelectedIndexChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(20, 30);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(399, 20);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Rechercher members par : Nom, Email, Phone";
            // 
            // txtSearchMember
            // 
            this.txtSearchMember.Location = new System.Drawing.Point(240, 57);
            this.txtSearchMember.Name = "txtSearchMember";
            this.txtSearchMember.Size = new System.Drawing.Size(179, 22);
            this.txtSearchMember.TabIndex = 1;
            this.txtSearchMember.TextChanged += new System.EventHandler(this.txtSearchMember_TextChanged);
            // 
            // lblGender
            // 
            this.lblGender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(951, 30);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(60, 20);
            this.lblGender.TabIndex = 2;
            this.lblGender.Text = "Genre";
            // 
            // cmbGender
            // 
            this.cmbGender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Tous",
            "Homme",
            "Femme"});
            this.cmbGender.Location = new System.Drawing.Point(951, 55);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(340, 24);
            this.cmbGender.TabIndex = 3;
            this.cmbGender.SelectedIndexChanged += new System.EventHandler(this.cmbGender_SelectedIndexChanged);
            // 
            // grpMembersTable
            // 
            this.grpMembersTable.Controls.Add(this.dgvMembers);
            this.grpMembersTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMembersTable.Location = new System.Drawing.Point(15, 220);
            this.grpMembersTable.Name = "grpMembersTable";
            this.grpMembersTable.Size = new System.Drawing.Size(1327, 359);
            this.grpMembersTable.TabIndex = 2;
            this.grpMembersTable.TabStop = false;
            this.grpMembersTable.Text = "Membres";
            // 
            // dgvMembers
            // 
            this.dgvMembers.AllowUserToAddRows = false;
            this.dgvMembers.AllowUserToDeleteRows = false;
            this.dgvMembers.AllowUserToResizeRows = false;
            this.dgvMembers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMembers.BackgroundColor = System.Drawing.Color.White;
            this.dgvMembers.ColumnHeadersHeight = 40;
            this.dgvMembers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMemberID,
            this.colFullName,
            this.colPhoneNumber,
            this.colEmail,
            this.colGendor,
            this.colMemberDetails,
            this.colUpdateMember,
            this.colManagesubscriptions});
            this.dgvMembers.ContextMenuStrip = this.cmsMember;
            this.dgvMembers.Location = new System.Drawing.Point(18, 35);
            this.dgvMembers.MultiSelect = false;
            this.dgvMembers.Name = "dgvMembers";
            this.dgvMembers.ReadOnly = true;
            this.dgvMembers.RowHeadersVisible = false;
            this.dgvMembers.RowHeadersWidth = 51;
            this.dgvMembers.RowTemplate.Height = 40;
            this.dgvMembers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMembers.Size = new System.Drawing.Size(1289, 309);
            this.dgvMembers.TabIndex = 0;
            this.dgvMembers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMembers_CellContentClick);
            // 
            // colMemberID
            // 
            this.colMemberID.MinimumWidth = 6;
            this.colMemberID.Name = "colMemberID";
            this.colMemberID.ReadOnly = true;
            this.colMemberID.Width = 125;
            // 
            // colFullName
            // 
            this.colFullName.MinimumWidth = 6;
            this.colFullName.Name = "colFullName";
            this.colFullName.ReadOnly = true;
            this.colFullName.Width = 125;
            // 
            // colPhoneNumber
            // 
            this.colPhoneNumber.MinimumWidth = 6;
            this.colPhoneNumber.Name = "colPhoneNumber";
            this.colPhoneNumber.ReadOnly = true;
            this.colPhoneNumber.Width = 125;
            // 
            // colEmail
            // 
            this.colEmail.MinimumWidth = 6;
            this.colEmail.Name = "colEmail";
            this.colEmail.ReadOnly = true;
            this.colEmail.Width = 125;
            // 
            // colGendor
            // 
            this.colGendor.MinimumWidth = 6;
            this.colGendor.Name = "colGendor";
            this.colGendor.ReadOnly = true;
            this.colGendor.Width = 125;
            // 
            // colMemberDetails
            // 
            this.colMemberDetails.MinimumWidth = 6;
            this.colMemberDetails.Name = "colMemberDetails";
            this.colMemberDetails.ReadOnly = true;
            this.colMemberDetails.Width = 125;
            // 
            // colUpdateMember
            // 
            this.colUpdateMember.MinimumWidth = 6;
            this.colUpdateMember.Name = "colUpdateMember";
            this.colUpdateMember.ReadOnly = true;
            this.colUpdateMember.Width = 125;
            // 
            // colManagesubscriptions
            // 
            this.colManagesubscriptions.MinimumWidth = 6;
            this.colManagesubscriptions.Name = "colManagesubscriptions";
            this.colManagesubscriptions.ReadOnly = true;
            this.colManagesubscriptions.Width = 125;
            // 
            // cmsMember
            // 
            this.cmsMember.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsMember.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.cmsMember.Name = "contextMenuStrip1";
            this.cmsMember.Size = new System.Drawing.Size(211, 56);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.deleteToolStripMenuItem.Text = "Supprimer";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // ucListeMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.grpMembersTable);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.grpHeader);
            this.Name = "ucListeMembers";
            this.Size = new System.Drawing.Size(1357, 598);
            this.Load += new System.EventHandler(this.ucListeMembers_Load);
            this.grpHeader.ResumeLayout(false);
            this.grpHeader.PerformLayout();
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.grpMembersTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).EndInit();
            this.cmsMember.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnAddMember;

        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearchMember;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ComboBox cmbGender;

        private System.Windows.Forms.DataGridViewTextBoxColumn colMemberID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGendor;
        private System.Windows.Forms.DataGridViewButtonColumn colMemberDetails;
        private System.Windows.Forms.DataGridViewButtonColumn colUpdateMember;
        private System.Windows.Forms.DataGridViewButtonColumn colManagesubscriptions;






        private System.Windows.Forms.GroupBox grpMembersTable;
        private System.Windows.Forms.DataGridView dgvMembers;


        private System.Windows.Forms.ComboBox cbMemberFilterBy;
        private ContextMenuStrip cmsMember;
        private ToolStripMenuItem deleteToolStripMenuItem;
    }
}