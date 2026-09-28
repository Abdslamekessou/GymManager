namespace GymManager.Presentation.Notifications
{
    partial class ctrlNotifications
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlFilters;

        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.ComboBox cbReadStatus;
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

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlFilters = new System.Windows.Forms.Panel();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.cbReadStatus = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnMarkAllRead = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.dgvNotifications = new System.Windows.Forms.DataGridView();
            this.colDetails = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colMarkAsRead = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnlFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotifications)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
            this.lblTitle.Location = new System.Drawing.Point(30, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(514, 54);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Gestions des Notifications";
            // 
            // pnlFilters
            // 
            this.pnlFilters.BackColor = System.Drawing.Color.White;
            this.pnlFilters.Controls.Add(this.cbStatus);
            this.pnlFilters.Controls.Add(this.cbReadStatus);
            this.pnlFilters.Controls.Add(this.txtSearch);
            this.pnlFilters.Controls.Add(this.btnMarkAllRead);
            this.pnlFilters.Controls.Add(this.btnExport);
            this.pnlFilters.Location = new System.Drawing.Point(17, 82);
            this.pnlFilters.Name = "pnlFilters";
            this.pnlFilters.Size = new System.Drawing.Size(1426, 125);
            this.pnlFilters.TabIndex = 1;
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Tous",
            "Actif",
            "Expiré"});
            this.cbStatus.Location = new System.Drawing.Point(20, 20);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(270, 36);
            this.cbStatus.TabIndex = 0;
            // 
            // cbReadStatus
            // 
            this.cbReadStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbReadStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbReadStatus.FormattingEnabled = true;
            this.cbReadStatus.Items.AddRange(new object[] {
            "Tous",
            "Lu",
            "Non lu"});
            this.cbReadStatus.Location = new System.Drawing.Point(310, 20);
            this.cbReadStatus.Name = "cbReadStatus";
            this.cbReadStatus.Size = new System.Drawing.Size(270, 36);
            this.cbReadStatus.TabIndex = 1;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearch.ForeColor = System.Drawing.Color.Gray;
            this.txtSearch.Location = new System.Drawing.Point(600, 20);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(515, 34);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.Text = "Rechercher une notification...";
            // 
            // btnMarkAllRead
            // 
            this.btnMarkAllRead.BackColor = System.Drawing.Color.White;
            this.btnMarkAllRead.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(208)))));
            this.btnMarkAllRead.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarkAllRead.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnMarkAllRead.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
            this.btnMarkAllRead.Location = new System.Drawing.Point(20, 70);
            this.btnMarkAllRead.Name = "btnMarkAllRead";
            this.btnMarkAllRead.Size = new System.Drawing.Size(250, 38);
            this.btnMarkAllRead.TabIndex = 3;
            this.btnMarkAllRead.Text = "Tout marquer comme lu";
            this.btnMarkAllRead.UseVisualStyleBackColor = false;
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.White;
            this.btnExport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(208)))));
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnExport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
            this.btnExport.Location = new System.Drawing.Point(955, 70);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(160, 38);
            this.btnExport.TabIndex = 4;
            this.btnExport.Text = "Exporter vers Excel";
            this.btnExport.UseVisualStyleBackColor = false;
            // 
            // dgvNotifications
            // 
            this.dgvNotifications.AllowUserToAddRows = false;
            this.dgvNotifications.AllowUserToDeleteRows = false;
            this.dgvNotifications.AllowUserToResizeRows = false;
            this.dgvNotifications.BackgroundColor = System.Drawing.Color.White;
            this.dgvNotifications.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvNotifications.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNotifications.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNotifications.ColumnHeadersHeight = 30;
            this.dgvNotifications.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDetails,
            this.colMarkAsRead});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNotifications.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNotifications.EnableHeadersVisualStyles = false;
            this.dgvNotifications.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(224)))), ((int)(((byte)(226)))));
            this.dgvNotifications.Location = new System.Drawing.Point(30, 225);
            this.dgvNotifications.Name = "dgvNotifications";
            this.dgvNotifications.ReadOnly = true;
            this.dgvNotifications.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvNotifications.RowHeadersVisible = false;
            this.dgvNotifications.RowHeadersWidth = 62;
            this.dgvNotifications.RowTemplate.Height = 50;
            this.dgvNotifications.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNotifications.Size = new System.Drawing.Size(1413, 483);
            this.dgvNotifications.TabIndex = 2;
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
            // 
            // ctrlNotifications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pnlFilters);
            this.Controls.Add(this.dgvNotifications);
            this.Name = "ctrlNotifications";
            this.Size = new System.Drawing.Size(1495, 768);
            this.Load += new System.EventHandler(this.ctrlNotifications_Load);
            this.pnlFilters.ResumeLayout(false);
            this.pnlFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotifications)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewButtonColumn colDetails;
        private System.Windows.Forms.DataGridViewButtonColumn colMarkAsRead;
    }
}