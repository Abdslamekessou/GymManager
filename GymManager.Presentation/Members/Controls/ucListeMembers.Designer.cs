
using System.Drawing;
using System.Windows.Forms;

namespace GymManager.Presentation.Members.Controls
{
    partial class ucListeMembers
    {
        private System.ComponentModel.IContainer components = null;

        private GroupBox grpHeader;
        private Label lblTitle;
        private Button btnAddMember;
        private GroupBox grpSearch;
        private ComboBox cbMemberFilterBy;
        private Label lblSearch;
        private TextBox txtSearchMember;
        private ComboBox cmbGender;
        private GroupBox grpMembersTable;
        private DataGridView dgvMembers;

        private DataGridViewTextBoxColumn colMemberID;
        private DataGridViewTextBoxColumn colFullName;
        private DataGridViewTextBoxColumn colPhoneNumber;
        private DataGridViewTextBoxColumn colEmail;
        private DataGridViewTextBoxColumn colGendor;
        private DataGridViewButtonColumn colMemberDetails;
        private DataGridViewButtonColumn colUpdateMember;
        private DataGridViewButtonColumn colManagesubscriptions;

        private ContextMenuStrip cmsMember;
        private ToolStripMenuItem showDetailsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem AddNewtoolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem sendEmailToolStripMenuItem;
        private ToolStripMenuItem phoneCallToolStripMenuItem;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpHeader = new System.Windows.Forms.GroupBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.cbMemberFilterBy = new System.Windows.Forms.ComboBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearchMember = new System.Windows.Forms.TextBox();
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
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.AddNewtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sendEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phoneCallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpHeader.SuspendLayout();
            this.grpSearch.SuspendLayout();
            this.grpMembersTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).BeginInit();
            this.cmsMember.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpHeader
            // 
            this.grpHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpHeader.BackColor = System.Drawing.Color.White;
            this.grpHeader.Controls.Add(this.lblTitle);
            this.grpHeader.Controls.Add(this.btnAddMember);
            this.grpHeader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.grpHeader.Location = new System.Drawing.Point(24, 12);
            this.grpHeader.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.grpHeader.Name = "grpHeader";
            this.grpHeader.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.grpHeader.Size = new System.Drawing.Size(1479, 98);
            this.grpHeader.TabIndex = 3;
            this.grpHeader.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(26)))), ((int)(((byte)(45)))));
            this.lblTitle.Location = new System.Drawing.Point(12, 35);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(500, 55);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "GESTION DES MEMBRES";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAddMember
            // 
            this.btnAddMember.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnAddMember.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddMember.FlatAppearance.BorderSize = 0;
            this.btnAddMember.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(78)))), ((int)(((byte)(216)))));
            this.btnAddMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMember.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddMember.ForeColor = System.Drawing.Color.White;
            this.btnAddMember.Location = new System.Drawing.Point(1319, 26);
            this.btnAddMember.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(140, 38);
            this.btnAddMember.TabIndex = 1;
            this.btnAddMember.Text = "+  Ajouter";
            this.btnAddMember.UseVisualStyleBackColor = false;
            this.btnAddMember.Click += new System.EventHandler(this.btnAddMember_Click);
            // 
            // grpSearch
            // 
            this.grpSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpSearch.BackColor = System.Drawing.Color.White;
            this.grpSearch.Controls.Add(this.cbMemberFilterBy);
            this.grpSearch.Controls.Add(this.lblSearch);
            this.grpSearch.Controls.Add(this.txtSearchMember);
            this.grpSearch.Controls.Add(this.cmbGender);
            this.grpSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.grpSearch.Location = new System.Drawing.Point(24, 107);
            this.grpSearch.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.grpSearch.Size = new System.Drawing.Size(1479, 120);
            this.grpSearch.TabIndex = 1;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Recherche et filtres";
            // 
            // cbMemberFilterBy
            // 
            this.cbMemberFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMemberFilterBy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMemberFilterBy.FormattingEnabled = true;
            this.cbMemberFilterBy.Items.AddRange(new object[] {
            "Aucun",
            "Nom Complet",
            "Phone",
            "Email",
            "Genre"});
            this.cbMemberFilterBy.Location = new System.Drawing.Point(20, 64);
            this.cbMemberFilterBy.Margin = new System.Windows.Forms.Padding(0);
            this.cbMemberFilterBy.Name = "cbMemberFilterBy";
            this.cbMemberFilterBy.Size = new System.Drawing.Size(180, 40);
            this.cbMemberFilterBy.TabIndex = 128;
            this.cbMemberFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbMemberFilterBy_SelectedIndexChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblSearch.Location = new System.Drawing.Point(16, 32);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(291, 28);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Rechercher les membres par :";
            // 
            // txtSearchMember
            // 
            this.txtSearchMember.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchMember.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchMember.Location = new System.Drawing.Point(208, 64);
            this.txtSearchMember.Margin = new System.Windows.Forms.Padding(0);
            this.txtSearchMember.Name = "txtSearchMember";
            this.txtSearchMember.Size = new System.Drawing.Size(382, 39);
            this.txtSearchMember.TabIndex = 1;
            this.txtSearchMember.TextChanged += new System.EventHandler(this.txtSearchMember_TextChanged);
            // 
            // cmbGender
            // 
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Tous",
            "Homme",
            "Femme"});
            this.cmbGender.Location = new System.Drawing.Point(208, 65);
            this.cmbGender.Margin = new System.Windows.Forms.Padding(0);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(382, 38);
            this.cmbGender.TabIndex = 3;
            this.cmbGender.SelectedIndexChanged += new System.EventHandler(this.cmbGender_SelectedIndexChanged);
            // 
            // grpMembersTable
            // 
            this.grpMembersTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpMembersTable.BackColor = System.Drawing.Color.White;
            this.grpMembersTable.Controls.Add(this.dgvMembers);
            this.grpMembersTable.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpMembersTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.grpMembersTable.Location = new System.Drawing.Point(24, 224);
            this.grpMembersTable.Margin = new System.Windows.Forms.Padding(0);
            this.grpMembersTable.Name = "grpMembersTable";
            this.grpMembersTable.Padding = new System.Windows.Forms.Padding(8);
            this.grpMembersTable.Size = new System.Drawing.Size(1479, 500);
            this.grpMembersTable.TabIndex = 2;
            this.grpMembersTable.TabStop = false;
            this.grpMembersTable.Text = "Membres";
            // 
            // dgvMembers
            // 
            this.dgvMembers.AllowUserToAddRows = false;
            this.dgvMembers.AllowUserToDeleteRows = false;
            this.dgvMembers.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.dgvMembers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvMembers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMembers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMembers.BackgroundColor = System.Drawing.Color.White;
            this.dgvMembers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMembers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMembers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(26)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(26)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMembers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvMembers.ColumnHeadersHeight = 44;
            this.dgvMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
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
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMembers.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvMembers.EnableHeadersVisualStyles = false;
            this.dgvMembers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(225)))), ((int)(((byte)(230)))));
            this.dgvMembers.Location = new System.Drawing.Point(12, 40);
            this.dgvMembers.MultiSelect = false;
            this.dgvMembers.Name = "dgvMembers";
            this.dgvMembers.ReadOnly = true;
            this.dgvMembers.RowHeadersVisible = false;
            this.dgvMembers.RowHeadersWidth = 62;
            this.dgvMembers.RowTemplate.Height = 42;
            this.dgvMembers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMembers.Size = new System.Drawing.Size(1450, 440);
            this.dgvMembers.TabIndex = 0;
            this.dgvMembers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMembers_CellContentClick);
            // 
            // colMemberID
            // 
            this.colMemberID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colMemberID.FillWeight = 55F;
            this.colMemberID.HeaderText = "Member ID";
            this.colMemberID.MinimumWidth = 70;
            this.colMemberID.Name = "colMemberID";
            this.colMemberID.ReadOnly = true;
            this.colMemberID.Width = 165;
            // 
            // colFullName
            // 
            this.colFullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colFullName.HeaderText = "Nom complet";
            this.colFullName.MinimumWidth = 120;
            this.colFullName.Name = "colFullName";
            this.colFullName.ReadOnly = true;
            // 
            // colPhoneNumber
            // 
            this.colPhoneNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colPhoneNumber.FillWeight = 90F;
            this.colPhoneNumber.HeaderText = "Téléphone";
            this.colPhoneNumber.MinimumWidth = 100;
            this.colPhoneNumber.Name = "colPhoneNumber";
            this.colPhoneNumber.ReadOnly = true;
            this.colPhoneNumber.Width = 156;
            // 
            // colEmail
            // 
            this.colEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colEmail.FillWeight = 120F;
            this.colEmail.HeaderText = "Email";
            this.colEmail.MinimumWidth = 120;
            this.colEmail.Name = "colEmail";
            this.colEmail.ReadOnly = true;
            // 
            // colGendor
            // 
            this.colGendor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colGendor.FillWeight = 55F;
            this.colGendor.HeaderText = "Genre";
            this.colGendor.MinimumWidth = 65;
            this.colGendor.Name = "colGendor";
            this.colGendor.ReadOnly = true;
            this.colGendor.Width = 115;
            // 
            // colMemberDetails
            // 
            this.colMemberDetails.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.colMemberDetails.DefaultCellStyle = dataGridViewCellStyle7;
            this.colMemberDetails.FillWeight = 70F;
            this.colMemberDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colMemberDetails.HeaderText = "Détails";
            this.colMemberDetails.MinimumWidth = 75;
            this.colMemberDetails.Name = "colMemberDetails";
            this.colMemberDetails.ReadOnly = true;
            this.colMemberDetails.Text = "Détail";
            this.colMemberDetails.UseColumnTextForButtonValue = true;
            this.colMemberDetails.Visible = false;
            // 
            // colUpdateMember
            // 
            this.colUpdateMember.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colUpdateMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colUpdateMember.HeaderText = "Modifier";
            this.colUpdateMember.MinimumWidth = 75;
            this.colUpdateMember.Name = "colUpdateMember";
            this.colUpdateMember.ReadOnly = true;
            this.colUpdateMember.Text = "Modifier";
            this.colUpdateMember.UseColumnTextForButtonValue = true;
            this.colUpdateMember.Visible = false;
            // 
            // colManagesubscriptions
            // 
            this.colManagesubscriptions.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colManagesubscriptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colManagesubscriptions.HeaderText = "Abonnements";
            this.colManagesubscriptions.MinimumWidth = 100;
            this.colManagesubscriptions.Name = "colManagesubscriptions";
            this.colManagesubscriptions.ReadOnly = true;
            this.colManagesubscriptions.Text = "Gérer";
            this.colManagesubscriptions.UseColumnTextForButtonValue = true;
            this.colManagesubscriptions.Visible = false;
            this.colManagesubscriptions.Width = 149;
            // 
            // cmsMember
            // 
            this.cmsMember.BackColor = System.Drawing.Color.White;
            this.cmsMember.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmsMember.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.cmsMember.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsMember.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsToolStripMenuItem,
            this.toolStripSeparator2,
            this.AddNewtoolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolStripMenuItem1,
            this.toolStripSeparator1,
            this.sendEmailToolStripMenuItem,
            this.phoneCallToolStripMenuItem});
            this.cmsMember.Name = "cmsMember";
            this.cmsMember.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.cmsMember.Size = new System.Drawing.Size(261, 256);
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.Image = global::GymManager.Presentation.Properties.Resources.PersonDetails_32;
            this.showDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(260, 40);
            this.showDetailsToolStripMenuItem.Text = "&Show Details";
            this.showDetailsToolStripMenuItem.Click += new System.EventHandler(this.showDetailsToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(257, 6);
            // 
            // AddNewtoolStripMenuItem
            // 
            this.AddNewtoolStripMenuItem.Image = global::GymManager.Presentation.Properties.Resources.AddPerson_32;
            this.AddNewtoolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.AddNewtoolStripMenuItem.Name = "AddNewtoolStripMenuItem";
            this.AddNewtoolStripMenuItem.Size = new System.Drawing.Size(260, 40);
            this.AddNewtoolStripMenuItem.Text = "Add &New Member";
            this.AddNewtoolStripMenuItem.Click += new System.EventHandler(this.AddNewtoolStripMenuItem_Click_1);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = global::GymManager.Presentation.Properties.Resources.edit_32;
            this.editToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(260, 40);
            this.editToolStripMenuItem.Text = "&Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = global::GymManager.Presentation.Properties.Resources.Delete_32;
            this.toolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(260, 40);
            this.toolStripMenuItem1.Text = "&Delete";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(257, 6);
            // 
            // sendEmailToolStripMenuItem
            // 
            this.sendEmailToolStripMenuItem.Image = global::GymManager.Presentation.Properties.Resources.send_email_32;
            this.sendEmailToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
            this.sendEmailToolStripMenuItem.Size = new System.Drawing.Size(260, 40);
            this.sendEmailToolStripMenuItem.Text = "Send E&mail";
            // 
            // phoneCallToolStripMenuItem
            // 
            this.phoneCallToolStripMenuItem.Image = global::GymManager.Presentation.Properties.Resources.Phone_32;
            this.phoneCallToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.phoneCallToolStripMenuItem.Name = "phoneCallToolStripMenuItem";
            this.phoneCallToolStripMenuItem.Size = new System.Drawing.Size(260, 40);
            this.phoneCallToolStripMenuItem.Text = "Phone &Call";
            // 
            // ucListeMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.Controls.Add(this.grpMembersTable);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.grpHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "ucListeMembers";
            this.Size = new System.Drawing.Size(1527, 748);
            this.Load += new System.EventHandler(this.ucListeMembers_Load);
            this.grpHeader.ResumeLayout(false);
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.grpMembersTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).EndInit();
            this.cmsMember.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
