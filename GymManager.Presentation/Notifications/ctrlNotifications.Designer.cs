
namespace GymManager.Presentation.Notifications
{
    partial class ctrlNotifications
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlFilters;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label lblExportStatus;
        private System.Windows.Forms.ComboBox cbExportStatus;
        private FontAwesome.Sharp.IconButton btnMarkAllRead;
        private System.Windows.Forms.DataGridView dgvNotifications;

        private System.Windows.Forms.DataGridViewTextBoxColumn colMemberName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSport;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubscriptionType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReadStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExportStatus;

        private System.Windows.Forms.DataGridViewTextBoxColumn MemberName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sport;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubscriptionType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReadStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Exportation;
        private System.Windows.Forms.DataGridViewButtonColumn colMarkAsRead;
        private System.Windows.Forms.DataGridViewButtonColumn colDetails;

        private FontAwesome.Sharp.IconButton btnSearch;
        private FontAwesome.Sharp.IconButton btnExport;
        private System.Windows.Forms.FolderBrowserDialog fbdExportExcel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlFilters = new System.Windows.Forms.Panel();
            this.btnSearch = new FontAwesome.Sharp.IconButton();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.lblExportStatus = new System.Windows.Forms.Label();
            this.cbExportStatus = new System.Windows.Forms.ComboBox();
            this.btnMarkAllRead = new FontAwesome.Sharp.IconButton();
            this.btnExport = new FontAwesome.Sharp.IconButton();
            this.dgvNotifications = new System.Windows.Forms.DataGridView();
            this.MemberName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubscriptionType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReadStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Exportation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMarkAsRead = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colDetails = new System.Windows.Forms.DataGridViewButtonColumn();
            this.fbdExportExcel = new System.Windows.Forms.FolderBrowserDialog();
            this.iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            this.pnlFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotifications)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(26)))), ((int)(((byte)(45)))));
            this.lblTitle.Location = new System.Drawing.Point(30, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(621, 57);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "GESTION DES NOTIFICATIONS";
            // 
            // pnlFilters
            // 
            this.pnlFilters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFilters.BackColor = System.Drawing.Color.White;
            this.pnlFilters.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFilters.Controls.Add(this.btnSearch);
            this.pnlFilters.Controls.Add(this.lblStatus);
            this.pnlFilters.Controls.Add(this.cbStatus);
            this.pnlFilters.Controls.Add(this.lblExportStatus);
            this.pnlFilters.Controls.Add(this.cbExportStatus);
            this.pnlFilters.Controls.Add(this.btnMarkAllRead);
            this.pnlFilters.Controls.Add(this.btnExport);
            this.pnlFilters.Location = new System.Drawing.Point(30, 90);
            this.pnlFilters.Name = "pnlFilters";
            this.pnlFilters.Size = new System.Drawing.Size(1525, 112);
            this.pnlFilters.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(26)))), ((int)(((byte)(45)))));
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnSearch.IconColor = System.Drawing.Color.White;
            this.btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearch.IconSize = 20;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(515, 42);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(125, 38);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Chercher";
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.lblStatus.Location = new System.Drawing.Point(22, 14);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(171, 28);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Statut de lecture";
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Tous",
            "Lu",
            "Non Lu"});
            this.cbStatus.Location = new System.Drawing.Point(22, 43);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(225, 36);
            this.cbStatus.TabIndex = 1;
            // 
            // lblExportStatus
            // 
            this.lblExportStatus.AutoSize = true;
            this.lblExportStatus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblExportStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.lblExportStatus.Location = new System.Drawing.Point(270, 14);
            this.lblExportStatus.Name = "lblExportStatus";
            this.lblExportStatus.Size = new System.Drawing.Size(206, 28);
            this.lblExportStatus.TabIndex = 2;
            this.lblExportStatus.Text = "Statut d\'exportation";
            // 
            // cbExportStatus
            // 
            this.cbExportStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbExportStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbExportStatus.FormattingEnabled = true;
            this.cbExportStatus.Items.AddRange(new object[] {
            "Tous",
            "Exporté",
            "Non Exporté"});
            this.cbExportStatus.Location = new System.Drawing.Point(270, 43);
            this.cbExportStatus.Name = "cbExportStatus";
            this.cbExportStatus.Size = new System.Drawing.Size(225, 36);
            this.cbExportStatus.TabIndex = 3;
            // 
            // btnMarkAllRead
            // 
            this.btnMarkAllRead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(26)))), ((int)(((byte)(45)))));
            this.btnMarkAllRead.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMarkAllRead.FlatAppearance.BorderSize = 0;
            this.btnMarkAllRead.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarkAllRead.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnMarkAllRead.ForeColor = System.Drawing.Color.White;
            this.btnMarkAllRead.IconChar = FontAwesome.Sharp.IconChar.CheckDouble;
            this.btnMarkAllRead.IconColor = System.Drawing.Color.White;
            this.btnMarkAllRead.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMarkAllRead.IconSize = 19;
            this.btnMarkAllRead.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMarkAllRead.Location = new System.Drawing.Point(990, 42);
            this.btnMarkAllRead.Name = "btnMarkAllRead";
            this.btnMarkAllRead.Size = new System.Drawing.Size(230, 38);
            this.btnMarkAllRead.TabIndex = 6;
            this.btnMarkAllRead.Text = "Tout marquer comme lu";
            this.btnMarkAllRead.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMarkAllRead.UseVisualStyleBackColor = false;
            this.btnMarkAllRead.Click += new System.EventHandler(this.btnMarkAllRead_Click);
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(26)))), ((int)(((byte)(45)))));
            this.btnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.btnExport.IconColor = System.Drawing.Color.White;
            this.btnExport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExport.IconSize = 19;
            this.btnExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExport.Location = new System.Drawing.Point(1240, 42);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(240, 38);
            this.btnExport.TabIndex = 7;
            this.btnExport.Text = "Exporter vers Excel";
            this.btnExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // dgvNotifications
            // 
            this.dgvNotifications.AllowUserToAddRows = false;
            this.dgvNotifications.AllowUserToDeleteRows = false;
            this.dgvNotifications.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.dgvNotifications.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNotifications.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNotifications.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNotifications.BackgroundColor = System.Drawing.Color.White;
            this.dgvNotifications.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvNotifications.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(26)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(26)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNotifications.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNotifications.ColumnHeadersHeight = 44;
            this.dgvNotifications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvNotifications.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MemberName,
            this.Sport,
            this.SubscriptionType,
            this.Status,
            this.ReadStatus,
            this.Exportation,
            this.colMarkAsRead,
            this.colDetails});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNotifications.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvNotifications.EnableHeadersVisualStyles = false;
            this.dgvNotifications.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.dgvNotifications.Location = new System.Drawing.Point(30, 225);
            this.dgvNotifications.MultiSelect = false;
            this.dgvNotifications.Name = "dgvNotifications";
            this.dgvNotifications.ReadOnly = true;
            this.dgvNotifications.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvNotifications.RowHeadersVisible = false;
            this.dgvNotifications.RowHeadersWidth = 62;
            this.dgvNotifications.RowTemplate.Height = 42;
            this.dgvNotifications.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNotifications.Size = new System.Drawing.Size(1525, 650);
            this.dgvNotifications.TabIndex = 2;
            // 
            // MemberName
            // 
            this.MemberName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MemberName.DataPropertyName = "Adhérent";
            this.MemberName.FillWeight = 120F;
            this.MemberName.HeaderText = "Nom d\'adhérent";
            this.MemberName.MinimumWidth = 100;
            this.MemberName.Name = "MemberName";
            this.MemberName.ReadOnly = true;
            // 
            // Sport
            // 
            this.Sport.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Sport.DataPropertyName = "Sport";
            this.Sport.FillWeight = 90F;
            this.Sport.HeaderText = "Sport";
            this.Sport.MinimumWidth = 80;
            this.Sport.Name = "Sport";
            this.Sport.ReadOnly = true;
            // 
            // SubscriptionType
            // 
            this.SubscriptionType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SubscriptionType.DataPropertyName = "Type d\'Abonnement";
            this.SubscriptionType.FillWeight = 120F;
            this.SubscriptionType.HeaderText = "Type d\'abonnement";
            this.SubscriptionType.MinimumWidth = 120;
            this.SubscriptionType.Name = "SubscriptionType";
            this.SubscriptionType.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Status.DataPropertyName = "Status d\'Abonnement";
            this.Status.FillWeight = 90F;
            this.Status.HeaderText = "Statut";
            this.Status.MinimumWidth = 90;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // ReadStatus
            // 
            this.ReadStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ReadStatus.DataPropertyName = "Lu Status";
            this.ReadStatus.FillWeight = 80F;
            this.ReadStatus.HeaderText = "Lecture";
            this.ReadStatus.MinimumWidth = 80;
            this.ReadStatus.Name = "ReadStatus";
            this.ReadStatus.ReadOnly = true;
            // 
            // Exportation
            // 
            this.Exportation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Exportation.DataPropertyName = "Exportation";
            this.Exportation.FillWeight = 90F;
            this.Exportation.HeaderText = "Exportation";
            this.Exportation.MinimumWidth = 90;
            this.Exportation.Name = "Exportation";
            this.Exportation.ReadOnly = true;
            // 
            // colMarkAsRead
            // 
            this.colMarkAsRead.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(26)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(26)))), ((int)(((byte)(45)))));
            this.colMarkAsRead.DefaultCellStyle = dataGridViewCellStyle3;
            this.colMarkAsRead.FillWeight = 130F;
            this.colMarkAsRead.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colMarkAsRead.HeaderText = "Actions";
            this.colMarkAsRead.MinimumWidth = 140;
            this.colMarkAsRead.Name = "colMarkAsRead";
            this.colMarkAsRead.ReadOnly = true;
            this.colMarkAsRead.Text = "✓  Marquer comme lu";
            this.colMarkAsRead.UseColumnTextForButtonValue = true;
            // 
            // colDetails
            // 
            this.colDetails.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDetails.DefaultCellStyle = dataGridViewCellStyle3;
            this.colDetails.FillWeight = 70F;
            this.colDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colDetails.HeaderText = "Détails";
            this.colDetails.MinimumWidth = 75;
            this.colDetails.Name = "colDetails";
            this.colDetails.ReadOnly = true;
            this.colDetails.Text = "◉  Détail";
            this.colDetails.UseColumnTextForButtonValue = true;
            // 
            // iconMenuItem1
            // 
            this.iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconMenuItem1.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem1.Name = "iconMenuItem1";
            this.iconMenuItem1.Size = new System.Drawing.Size(32, 19);
            this.iconMenuItem1.Text = "iconMenuItem1";
            // 
            // ctrlNotifications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.Controls.Add(this.dgvNotifications);
            this.Controls.Add(this.pnlFilters);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ctrlNotifications";
            this.Size = new System.Drawing.Size(1587, 921);
            this.Load += new System.EventHandler(this.ctrlNotifications_Load);
            this.pnlFilters.ResumeLayout(false);
            this.pnlFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotifications)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
    }
}
