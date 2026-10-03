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

            this.colFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGendor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMemberDetails = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colUpdateMember = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colManagesubscriptions = new System.Windows.Forms.DataGridViewButtonColumn();

            this.dgvMembers = new System.Windows.Forms.DataGridView();
            this.grpHeader.SuspendLayout();
            this.grpSearch.SuspendLayout();
            this.grpMembersTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).BeginInit();
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
            dgvMembers.AutoGenerateColumns = false;

            this.dgvMembers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMembers.BackgroundColor = System.Drawing.Color.White;
            this.dgvMembers.ColumnHeadersHeight = 40;

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

            // 
            // dgvMembers  "Columns"
            // 
            this.colFullName.HeaderText = "Nom";
            this.colFullName.Name = "colFullName";
            this.colFullName.DataPropertyName = "NomComplet";
            this.colFullName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


            this.colPhoneNumber.HeaderText = "Téléphone";
            this.colPhoneNumber.Name = "colPhoneNumber";
            this.colPhoneNumber.DataPropertyName = "NumeroTelephone";
            this.colPhoneNumber.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


            this.colEmail.HeaderText = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.DataPropertyName = "Email";
            this.colEmail.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            this.colGendor.HeaderText = "Genre";
            this.colGendor.Name = "colGendor";
            this.colGendor.DataPropertyName = "Genre";
            this.colGendor.Width = 110;


            this.colMemberDetails.HeaderText = "Action";
            this.colMemberDetails.Name = "colMemberDetails";

            this.colUpdateMember.HeaderText = "Action";
            this.colUpdateMember.Name = "colUpdateMember";
            this.colUpdateMember.Width = 110;


            this.colManagesubscriptions.HeaderText = "Abonnements";
            this.colManagesubscriptions.Name = "colManagesubscriptions";
            this.colManagesubscriptions.Text = "Gérer";
            this.colManagesubscriptions.UseColumnTextForButtonValue = true;
            this.colManagesubscriptions.Width = 110;


            // Add columns to DataGridView
            this.dgvMembers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[]
            {
    this.colFullName,
    this.colPhoneNumber,
    this.colEmail,
    this.colGendor,
    this.colMemberDetails,
    this.colUpdateMember,
    this.colManagesubscriptions
            });

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
    }
}