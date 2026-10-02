namespace GymManager.Presentation.Notifications
{
    partial class ctrlNotifications
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlFilters;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label lblExportStatus;
        private System.Windows.Forms.ComboBox cbExportStatus;
        private System.Windows.Forms.Button btnMarkAllRead;
        private System.Windows.Forms.Button btnExport;

        private System.Windows.Forms.DataGridView dgvNotifications;

        private System.Windows.Forms.DataGridViewTextBoxColumn colMemberName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSport;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubscriptionType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReadStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExportStatus;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
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
        /// Required method for Designer support.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlFilters = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.lblExportStatus = new System.Windows.Forms.Label();
            this.cbExportStatus = new System.Windows.Forms.ComboBox();
            this.btnMarkAllRead = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.dgvNotifications = new System.Windows.Forms.DataGridView();
            this.MemberName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubscriptionType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReadStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Exportation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMarkAsRead = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colDetails = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pnlFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotifications)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
            this.lblTitle.Location = new System.Drawing.Point(39, 33);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(525, 48);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "GESTION DES NOTIFICATIONS";
            // 
            // pnlFilters
            // 
            this.pnlFilters.BackColor = System.Drawing.Color.White;
            this.pnlFilters.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFilters.Controls.Add(this.btnSearch);
            this.pnlFilters.Controls.Add(this.lblStatus);
            this.pnlFilters.Controls.Add(this.cbStatus);
            this.pnlFilters.Controls.Add(this.lblExportStatus);
            this.pnlFilters.Controls.Add(this.cbExportStatus);
            this.pnlFilters.Controls.Add(this.btnMarkAllRead);
            this.pnlFilters.Controls.Add(this.btnExport);
            this.pnlFilters.Location = new System.Drawing.Point(39, 100);
            this.pnlFilters.Margin = new System.Windows.Forms.Padding(4);
            this.pnlFilters.Name = "pnlFilters";
            this.pnlFilters.Size = new System.Drawing.Size(1388, 166);
            this.pnlFilters.TabIndex = 1;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblStatus.Location = new System.Drawing.Point(26, 24);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(144, 25);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Statut de Lecture";
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Tous",
            "Lu",
            "Non Lu"});
            this.cbStatus.Location = new System.Drawing.Point(26, 53);
            this.cbStatus.Margin = new System.Windows.Forms.Padding(4);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(230, 28);
            this.cbStatus.TabIndex = 1;
            // 
            // lblExportStatus
            // 
            this.lblExportStatus.AutoSize = true;
            this.lblExportStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblExportStatus.Location = new System.Drawing.Point(296, 24);
            this.lblExportStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExportStatus.Name = "lblExportStatus";
            this.lblExportStatus.Size = new System.Drawing.Size(174, 25);
            this.lblExportStatus.TabIndex = 2;
            this.lblExportStatus.Text = "Statut d\' Exportation";
            // 
            // cbExportStatus
            // 
            this.cbExportStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbExportStatus.FormattingEnabled = true;
            this.cbExportStatus.Items.AddRange(new object[] {
            "Tous",
            "Exporté",
            "Non Exporté"});
            this.cbExportStatus.Location = new System.Drawing.Point(296, 53);
            this.cbExportStatus.Margin = new System.Windows.Forms.Padding(4);
            this.cbExportStatus.Name = "cbExportStatus";
            this.cbExportStatus.Size = new System.Drawing.Size(230, 28);
            this.cbExportStatus.TabIndex = 3;
            // 
            // btnMarkAllRead
            // 
            this.btnMarkAllRead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
            this.btnMarkAllRead.FlatAppearance.BorderSize = 0;
            this.btnMarkAllRead.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarkAllRead.ForeColor = System.Drawing.Color.White;
            this.btnMarkAllRead.Location = new System.Drawing.Point(924, 53);
            this.btnMarkAllRead.Margin = new System.Windows.Forms.Padding(4);
            this.btnMarkAllRead.Name = "btnMarkAllRead";
            this.btnMarkAllRead.Size = new System.Drawing.Size(219, 40);
            this.btnMarkAllRead.TabIndex = 6;
            this.btnMarkAllRead.Text = "Tout marquer comme lu";
            this.btnMarkAllRead.UseVisualStyleBackColor = false;
            this.btnMarkAllRead.Click += new System.EventHandler(this.btnMarkAllRead_Click);
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(1169, 53);
            this.btnExport.Margin = new System.Windows.Forms.Padding(4);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(206, 40);
            this.btnExport.TabIndex = 7;
            this.btnExport.Text = "Exporter vers Excel";
            this.btnExport.UseVisualStyleBackColor = false;
            // 
            // dgvNotifications
            // 
            this.dgvNotifications.AllowUserToAddRows = false;
            this.dgvNotifications.AllowUserToDeleteRows = false;
            this.dgvNotifications.AllowUserToResizeRows = false;
            this.dgvNotifications.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvNotifications.BackgroundColor = System.Drawing.Color.White;
            this.dgvNotifications.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvNotifications.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNotifications.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvNotifications.ColumnHeadersHeight = 40;
            this.dgvNotifications.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MemberName,
            this.Sport,
            this.SubscriptionType,
            this.Status,
            this.ReadStatus,
            this.Exportation,
            this.colMarkAsRead,
            this.colDetails});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNotifications.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvNotifications.EnableHeadersVisualStyles = false;
            this.dgvNotifications.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(224)))), ((int)(((byte)(226)))));
            this.dgvNotifications.Location = new System.Drawing.Point(39, 300);
            this.dgvNotifications.Margin = new System.Windows.Forms.Padding(4);
            this.dgvNotifications.Name = "dgvNotifications";
            this.dgvNotifications.ReadOnly = true;
            this.dgvNotifications.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvNotifications.RowHeadersVisible = false;
            this.dgvNotifications.RowHeadersWidth = 62;
            this.dgvNotifications.RowTemplate.Height = 50;
            this.dgvNotifications.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNotifications.Size = new System.Drawing.Size(1388, 644);
            this.dgvNotifications.TabIndex = 2;
            // 
            // MemberName
            // 
            this.MemberName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MemberName.DataPropertyName = "MemberName";
            this.MemberName.HeaderText = "Nom d\'adhérent\n";
            this.MemberName.MinimumWidth = 8;
            this.MemberName.Name = "MemberName";
            this.MemberName.ReadOnly = true;
            // 
            // Sport
            // 
            this.Sport.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Sport.DataPropertyName = "Sport";
            this.Sport.HeaderText = "Sport";
            this.Sport.MinimumWidth = 8;
            this.Sport.Name = "Sport";
            this.Sport.ReadOnly = true;
            // 
            // SubscriptionType
            // 
            this.SubscriptionType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SubscriptionType.DataPropertyName = "SubscriptionType";
            this.SubscriptionType.HeaderText = "Type d\' Abonnement";
            this.SubscriptionType.MinimumWidth = 8;
            this.SubscriptionType.Name = "SubscriptionType";
            this.SubscriptionType.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "AbonnementStatus";
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 8;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // ReadStatus
            // 
            this.ReadStatus.DataPropertyName = "ReadStatus";
            this.ReadStatus.HeaderText = "Lecture";
            this.ReadStatus.MinimumWidth = 8;
            this.ReadStatus.Name = "ReadStatus";
            this.ReadStatus.ReadOnly = true;
            this.ReadStatus.Width = 110;
            // 
            // Exportation
            // 
            this.Exportation.DataPropertyName = "Exportation";
            this.Exportation.HeaderText = "Exportation";
            this.Exportation.MinimumWidth = 8;
            this.Exportation.Name = "Exportation";
            this.Exportation.ReadOnly = true;
            this.Exportation.Width = 148;
            // 
            // colMarkAsRead
            // 
            this.colMarkAsRead.HeaderText = "Actions";
            this.colMarkAsRead.MinimumWidth = 8;
            this.colMarkAsRead.Name = "colMarkAsRead";
            this.colMarkAsRead.ReadOnly = true;
            this.colMarkAsRead.Text = "Marquer comme lu";
            this.colMarkAsRead.UseColumnTextForButtonValue = true;
            this.colMarkAsRead.Width = 81;
            // 
            // colDetails
            // 
            this.colDetails.HeaderText = "Détails";
            this.colDetails.MinimumWidth = 8;
            this.colDetails.Name = "colDetails";
            this.colDetails.ReadOnly = true;
            this.colDetails.Text = "Détail";
            this.colDetails.UseColumnTextForButtonValue = true;
            this.colDetails.Width = 75;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(557, 53);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(120, 38);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Chercher";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // ctrlNotifications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(239)))), ((int)(((byte)(234)))));
            this.Controls.Add(this.dgvNotifications);
            this.Controls.Add(this.pnlFilters);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ctrlNotifications";
            this.Size = new System.Drawing.Size(1480, 969);
            this.Load += new System.EventHandler(this.ctrlNotifications_Load);
            this.pnlFilters.ResumeLayout(false);
            this.pnlFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotifications)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn MemberName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sport;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubscriptionType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReadStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Exportation;
        private System.Windows.Forms.DataGridViewButtonColumn colMarkAsRead;
        private System.Windows.Forms.DataGridViewButtonColumn colDetails;
        private System.Windows.Forms.Button btnSearch;
    }
}