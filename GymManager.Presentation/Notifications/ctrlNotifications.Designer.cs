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
        private System.Windows.Forms.Label lblReadStatus;
        private System.Windows.Forms.ComboBox cbReadStatus;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnMarkAllRead;
        private System.Windows.Forms.Button btnExport;

        private System.Windows.Forms.DataGridView dgvNotifications;

        private System.Windows.Forms.DataGridViewTextBoxColumn colMemberName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSport;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubscriptionType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReadStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExportStatus;
        private System.Windows.Forms.DataGridViewButtonColumn colDetails;
        private System.Windows.Forms.DataGridViewButtonColumn colMarkAsRead;

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
            this.components = new System.ComponentModel.Container();

            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 =
                new System.Windows.Forms.DataGridViewCellStyle();

            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 =
                new System.Windows.Forms.DataGridViewCellStyle();

            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlFilters = new System.Windows.Forms.Panel();

            this.lblStatus = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();

            this.lblReadStatus = new System.Windows.Forms.Label();
            this.cbReadStatus = new System.Windows.Forms.ComboBox();

            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();

            this.btnMarkAllRead = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();

            this.dgvNotifications = new System.Windows.Forms.DataGridView();

            this.colMemberName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubscriptionType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReadStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExportStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDetails = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colMarkAsRead = new System.Windows.Forms.DataGridViewButtonColumn();

            this.pnlFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotifications)).BeginInit();
            this.SuspendLayout();

            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font(
                "Segoe UI",
                18F,
                System.Drawing.FontStyle.Bold);

            this.lblTitle.ForeColor =
                System.Drawing.Color.FromArgb(
                    ((int)(((byte)(45)))),
                    ((int)(((byte)(65)))),
                    ((int)(((byte)(75)))));

            this.lblTitle.Location = new System.Drawing.Point(30, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(305, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "GESTION DES NOTIFICATIONS";

            // 
            // pnlFilters
            // 
            this.pnlFilters.BackColor = System.Drawing.Color.White;
            this.pnlFilters.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFilters.Controls.Add(this.lblStatus);
            this.pnlFilters.Controls.Add(this.cbStatus);
            this.pnlFilters.Controls.Add(this.lblReadStatus);
            this.pnlFilters.Controls.Add(this.cbReadStatus);
            this.pnlFilters.Controls.Add(this.lblSearch);
            this.pnlFilters.Controls.Add(this.txtSearch);
            this.pnlFilters.Controls.Add(this.btnMarkAllRead);
            this.pnlFilters.Controls.Add(this.btnExport);

            this.pnlFilters.Location = new System.Drawing.Point(30, 75);
            this.pnlFilters.Name = "pnlFilters";
            this.pnlFilters.Size = new System.Drawing.Size(1413, 125);
            this.pnlFilters.TabIndex = 1;

            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font(
                "Segoe UI",
                9F,
                System.Drawing.FontStyle.Regular);

            this.lblStatus.Location = new System.Drawing.Point(20, 18);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(42, 15);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Statut";

            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[]
            {
                "Tous",
                "Actif",
                "Expiré"
            });

            this.cbStatus.Location = new System.Drawing.Point(20, 40);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(180, 23);
            this.cbStatus.TabIndex = 1;

            // 
            // lblReadStatus
            // 
            this.lblReadStatus.AutoSize = true;
            this.lblReadStatus.Font = new System.Drawing.Font(
                "Segoe UI",
                9F,
                System.Drawing.FontStyle.Regular);

            this.lblReadStatus.Location = new System.Drawing.Point(230, 18);
            this.lblReadStatus.Name = "lblReadStatus";
            this.lblReadStatus.Size = new System.Drawing.Size(83, 15);
            this.lblReadStatus.TabIndex = 2;
            this.lblReadStatus.Text = "Statut de lecture";

            // 
            // cbReadStatus
            // 
            this.cbReadStatus.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.cbReadStatus.FormattingEnabled = true;
            this.cbReadStatus.Items.AddRange(new object[]
            {
                "Tous",
                "Lu",
                "Non lu"
            });

            this.cbReadStatus.Location = new System.Drawing.Point(230, 40);
            this.cbReadStatus.Name = "cbReadStatus";
            this.cbReadStatus.Size = new System.Drawing.Size(180, 23);
            this.cbReadStatus.TabIndex = 3;

            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font(
                "Segoe UI",
                9F,
                System.Drawing.FontStyle.Regular);

            this.lblSearch.Location = new System.Drawing.Point(440, 18);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(42, 15);
            this.lblSearch.TabIndex = 4;
            this.lblSearch.Text = "Rechercher";

            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(440, 40);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(260, 23);
            this.txtSearch.TabIndex = 5;

            // 
            // btnMarkAllRead
            // 
            this.btnMarkAllRead.BackColor =
                System.Drawing.Color.FromArgb(
                    ((int)(((byte)(45)))),
                    ((int)(((byte)(65)))),
                    ((int)(((byte)(75)))));

            this.btnMarkAllRead.FlatAppearance.BorderSize = 0;
            this.btnMarkAllRead.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnMarkAllRead.ForeColor = System.Drawing.Color.White;

            this.btnMarkAllRead.Location =
                new System.Drawing.Point(1020, 38);

            this.btnMarkAllRead.Name = "btnMarkAllRead";
            this.btnMarkAllRead.Size = new System.Drawing.Size(170, 30);
            this.btnMarkAllRead.TabIndex = 6;
            this.btnMarkAllRead.Text = "Tout marquer comme lu";
            this.btnMarkAllRead.UseVisualStyleBackColor = false;

            // 
            // btnExport
            // 
            this.btnExport.BackColor =
                System.Drawing.Color.FromArgb(
                    ((int)(((byte)(80)))),
                    ((int)(((byte)(80)))),
                    ((int)(((byte)(80)))));

            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnExport.ForeColor = System.Drawing.Color.White;

            this.btnExport.Location =
                new System.Drawing.Point(1210, 38);

            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(160, 30);
            this.btnExport.TabIndex = 7;
            this.btnExport.Text = "Exporter vers Excel";
            this.btnExport.UseVisualStyleBackColor = false;

            // 
            // dgvNotifications
            // 
            this.dgvNotifications.AllowUserToAddRows = false;
            this.dgvNotifications.AllowUserToDeleteRows = false;
            this.dgvNotifications.AllowUserToResizeRows = false;
            this.dgvNotifications.BackgroundColor = System.Drawing.Color.White;
            this.dgvNotifications.AutoGenerateColumns = false;
            


            this.dgvNotifications.CellBorderStyle =
                System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;

            this.dgvNotifications.ColumnHeadersBorderStyle =
                System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;

            dataGridViewCellStyle1.Alignment =
                System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;

            dataGridViewCellStyle1.BackColor =
                System.Drawing.Color.FromArgb(
                    ((int)(((byte)(245)))),
                    ((int)(((byte)(245)))),
                    ((int)(((byte)(245)))));

            dataGridViewCellStyle1.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F,
                    System.Drawing.FontStyle.Bold);

            dataGridViewCellStyle1.ForeColor =
                System.Drawing.Color.FromArgb(
                    ((int)(((byte)(45)))),
                    ((int)(((byte)(65)))),
                    ((int)(((byte)(75)))));

            dataGridViewCellStyle1.SelectionBackColor =
                System.Drawing.SystemColors.Highlight;

            dataGridViewCellStyle1.SelectionForeColor =
                System.Drawing.SystemColors.HighlightText;

            dataGridViewCellStyle1.WrapMode =
                System.Windows.Forms.DataGridViewTriState.True;

            this.dgvNotifications.ColumnHeadersDefaultCellStyle =
                dataGridViewCellStyle1;

            this.dgvNotifications.ColumnHeadersHeight = 30;

            this.dgvNotifications.Columns.AddRange(
                new System.Windows.Forms.DataGridViewColumn[]
                {
                    this.colMemberName,
                    this.colSport,
                    this.colSubscriptionType,
                    this.colStatus,
                    this.colReadStatus,
                    this.colExportStatus,
                    this.colDetails,
                    this.colMarkAsRead
                });

            dataGridViewCellStyle2.Alignment =
                System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;

            dataGridViewCellStyle2.BackColor =
                System.Drawing.Color.White;

            dataGridViewCellStyle2.Font =
                new System.Drawing.Font("Segoe UI", 9.5F);

            dataGridViewCellStyle2.ForeColor =
                System.Drawing.Color.FromArgb(
                    ((int)(((byte)(45)))),
                    ((int)(((byte)(65)))),
                    ((int)(((byte)(75)))));

            dataGridViewCellStyle2.SelectionBackColor =
                System.Drawing.Color.FromArgb(
                    ((int)(((byte)(235)))),
                    ((int)(((byte)(239)))),
                    ((int)(((byte)(241)))));

            dataGridViewCellStyle2.SelectionForeColor =
                System.Drawing.Color.FromArgb(
                    ((int)(((byte)(45)))),
                    ((int)(((byte)(65)))),
                    ((int)(((byte)(75)))));

            dataGridViewCellStyle2.WrapMode =
                System.Windows.Forms.DataGridViewTriState.False;

            this.dgvNotifications.DefaultCellStyle =
                dataGridViewCellStyle2;

            this.dgvNotifications.EnableHeadersVisualStyles = false;

            this.dgvNotifications.GridColor =
                System.Drawing.Color.FromArgb(
                    ((int)(((byte)(220)))),
                    ((int)(((byte)(224)))),
                    ((int)(((byte)(226)))));

            this.dgvNotifications.Location =
                new System.Drawing.Point(30, 225);

            this.dgvNotifications.Name = "dgvNotifications";
            this.dgvNotifications.ReadOnly = true;
            this.dgvNotifications.RightToLeft =
                System.Windows.Forms.RightToLeft.No;

            this.dgvNotifications.RowHeadersVisible = false;
            this.dgvNotifications.RowHeadersWidth = 62;
            this.dgvNotifications.RowTemplate.Height = 50;

            this.dgvNotifications.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            this.dgvNotifications.Size =
                new System.Drawing.Size(1413, 483);

            this.dgvNotifications.TabIndex = 2;

            // 
            // colMemberName
            // 
            this.colMemberName.DataPropertyName = "MemberName";
            this.colMemberName.HeaderText = "Nom d'adhérent";
            this.colMemberName.Name = "colMemberName";
            this.colMemberName.ReadOnly = true;
            this.colMemberName.Width = 180;

            // 
            // colSport
            // 
            this.colSport.DataPropertyName = "Sport";
            this.colSport.HeaderText = "Sport";
            this.colSport.Name = "colSport";
            this.colSport.ReadOnly = true;
            this.colSport.Width = 140;

            // 
            // colSubscriptionType
            // 
            this.colSubscriptionType.DataPropertyName = "SubscriptionType";
            this.colSubscriptionType.HeaderText = "Type d'abonnement";
            this.colSubscriptionType.Name = "colSubscriptionType";
            this.colSubscriptionType.ReadOnly = true;
            this.colSubscriptionType.Width = 160;

            // 
            // colStatus
            // 
            this.colStatus.DataPropertyName = "Status";
            this.colStatus.HeaderText = "Statut";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            this.colStatus.Width = 110;

            // 
            // colReadStatus
            // 
            this.colReadStatus.DataPropertyName = "ReadStatus";
            this.colReadStatus.HeaderText = "Lecture";
            this.colReadStatus.Name = "colReadStatus";
            this.colReadStatus.ReadOnly = true;
            this.colReadStatus.Width = 100;

            // 
            // colExportStatus
            // 
            this.colExportStatus.DataPropertyName = "ExportStatus";
            this.colExportStatus.HeaderText = "Exportation";
            this.colExportStatus.Name = "colExportStatus";
            this.colExportStatus.ReadOnly = true;
            this.colExportStatus.Width = 120;

            // 
            // colDetails
            // 
            this.colDetails.HeaderText = "Détails";
            this.colDetails.Name = "colDetails";
            this.colDetails.ReadOnly = true;
            this.colDetails.Text = "Détail";
            this.colDetails.UseColumnTextForButtonValue = true;
            this.colDetails.Width = 85;

            // 
            // colMarkAsRead
            // 
            this.colMarkAsRead.HeaderText = "Actions";
            this.colMarkAsRead.Name = "colMarkAsRead";
            this.colMarkAsRead.ReadOnly = true;
            this.colMarkAsRead.Text = "Marquer comme lu";
            this.colMarkAsRead.UseColumnTextForButtonValue = true;
            this.colMarkAsRead.Width = 140;

            // 
            // ctrlNotifications
            // 
            this.AutoScaleDimensions =
                new System.Drawing.SizeF(7F, 15F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.BackColor =
                System.Drawing.Color.FromArgb(
                    ((int)(((byte)(240)))),
                    ((int)(((byte)(239)))),
                    ((int)(((byte)(234)))));

            this.Controls.Add(this.dgvNotifications);
            this.Controls.Add(this.pnlFilters);
            this.Controls.Add(this.lblTitle);

            this.Name = "ctrlNotifications";
            this.Size = new System.Drawing.Size(1475, 750);

            this.pnlFilters.ResumeLayout(false);
            this.pnlFilters.PerformLayout();

            ((System.ComponentModel.ISupportInitialize)(this.dgvNotifications)).EndInit();

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}