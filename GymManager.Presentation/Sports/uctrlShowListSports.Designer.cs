namespace GymManager.Presentation.Sports
{
    partial class uctrlShowListSports
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel pnlSports;
        private System.Windows.Forms.DataGridView dgvSports;
        private System.Windows.Forms.Panel pnlActions;
        private System.Windows.Forms.FlowLayoutPanel flpActions;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;

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

            System.Windows.Forms.DataGridViewCellStyle headerStyle =
                new System.Windows.Forms.DataGridViewCellStyle();

            System.Windows.Forms.DataGridViewCellStyle cellStyle =
                new System.Windows.Forms.DataGridViewCellStyle();

            System.Windows.Forms.DataGridViewCellStyle alternatingStyle =
                new System.Windows.Forms.DataGridViewCellStyle();

            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pnlSports = new System.Windows.Forms.Panel();
            this.dgvSports = new System.Windows.Forms.DataGridView();
            this.SportID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SportName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstActif = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pnlActions = new System.Windows.Forms.Panel();
            this.flpActions = new System.Windows.Forms.FlowLayoutPanel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmsSports = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.supprimmerToolStripMenuItem =
                new System.Windows.Forms.ToolStripMenuItem();

            this.tlpMain.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.pnlSports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSports)).BeginInit();
            this.pnlActions.SuspendLayout();
            this.flpActions.SuspendLayout();
            this.cmsSports.SuspendLayout();
            this.SuspendLayout();

            // 
            // tlpMain
            // 
            this.tlpMain.BackColor = System.Drawing.Color.FromArgb(240, 239, 234);
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(
                    System.Windows.Forms.SizeType.Percent, 100F));

            this.tlpMain.Controls.Add(this.lblTitle, 0, 0);
            this.tlpMain.Controls.Add(this.pnlSearch, 0, 1);
            this.tlpMain.Controls.Add(this.pnlSports, 0, 2);
            this.tlpMain.Controls.Add(this.pnlActions, 0, 3);

            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Margin = new System.Windows.Forms.Padding(0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.Padding = new System.Windows.Forms.Padding(24, 20, 24, 20);

            this.tlpMain.RowCount = 4;
            this.tlpMain.RowStyles.Add(
                new System.Windows.Forms.RowStyle(
                    System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpMain.RowStyles.Add(
                new System.Windows.Forms.RowStyle(
                    System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpMain.RowStyles.Add(
                new System.Windows.Forms.RowStyle(
                    System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(
                new System.Windows.Forms.RowStyle(
                    System.Windows.Forms.SizeType.Absolute, 56F));

            this.tlpMain.Size = new System.Drawing.Size(1200, 780);
            this.tlpMain.TabIndex = 0;

            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font(
                "Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(26, 26, 26);
            this.lblTitle.Location = new System.Drawing.Point(24, 20);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1152, 55);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "GESTION DES SPORTS";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);

            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.Color.FromArgb(240, 239, 234);
            this.pnlSearch.Controls.Add(this.txtSearch);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSearch.Location = new System.Drawing.Point(24, 80);
            this.pnlSearch.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(1152, 52);
            this.pnlSearch.TabIndex = 1;

            // 
            // txtSearch
            // 
            this.txtSearch.Anchor =
                System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Top;

            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(26, 26, 26);
            this.txtSearch.Location = new System.Drawing.Point(0, 4);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(0);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(500, 30);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged +=
                new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyPress +=
                new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);

            // 
            // pnlSports
            // 
            this.pnlSports.BackColor = System.Drawing.Color.White;
            this.pnlSports.Controls.Add(this.dgvSports);
            this.pnlSports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSports.Location = new System.Drawing.Point(24, 140);
            this.pnlSports.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSports.Name = "pnlSports";
            this.pnlSports.Padding = new System.Windows.Forms.Padding(0);
            this.pnlSports.Size = new System.Drawing.Size(1152, 564);
            this.pnlSports.TabIndex = 2;

            // 
            // dgvSports
            // 
            this.dgvSports.AllowUserToAddRows = false;
            this.dgvSports.AllowUserToDeleteRows = false;
            this.dgvSports.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSports.BackgroundColor = System.Drawing.Color.White;
            this.dgvSports.BorderStyle = System.Windows.Forms.BorderStyle.None;

            // Header styling
            headerStyle.Alignment =
                System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            headerStyle.BackColor = System.Drawing.Color.FromArgb(245, 244, 240);
            headerStyle.Font = new System.Drawing.Font(
                "Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            headerStyle.ForeColor = System.Drawing.Color.FromArgb(26, 26, 26);
            headerStyle.SelectionBackColor =
                System.Drawing.Color.FromArgb(245, 244, 240);
            headerStyle.SelectionForeColor =
                System.Drawing.Color.FromArgb(26, 26, 26);
            headerStyle.WrapMode =
                System.Windows.Forms.DataGridViewTriState.True;

            this.dgvSports.ColumnHeadersDefaultCellStyle = headerStyle;
            this.dgvSports.ColumnHeadersHeight = 42;
            this.dgvSports.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            // Existing columns and bindings
            this.dgvSports.Columns.AddRange(
                new System.Windows.Forms.DataGridViewColumn[]
                {
                    this.SportID,
                    this.SportName,
                    this.Description,
                    this.EstActif
                });

            // Default cell styling
            cellStyle.Alignment =
                System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            cellStyle.BackColor = System.Drawing.Color.White;
            cellStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            cellStyle.ForeColor = System.Drawing.Color.FromArgb(26, 26, 26);
            cellStyle.SelectionBackColor =
                System.Drawing.Color.FromArgb(232, 230, 224);
            cellStyle.SelectionForeColor =
                System.Drawing.Color.FromArgb(26, 26, 26);
            cellStyle.WrapMode =
                System.Windows.Forms.DataGridViewTriState.False;
            cellStyle.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);

            this.dgvSports.DefaultCellStyle = cellStyle;

            // Alternating row styling
            alternatingStyle.BackColor =
                System.Drawing.Color.FromArgb(250, 249, 246);
            alternatingStyle.ForeColor =
                System.Drawing.Color.FromArgb(26, 26, 26);
            alternatingStyle.SelectionBackColor =
                System.Drawing.Color.FromArgb(232, 230, 224);
            alternatingStyle.SelectionForeColor =
                System.Drawing.Color.FromArgb(26, 26, 26);

            this.dgvSports.AlternatingRowsDefaultCellStyle = alternatingStyle;

            this.dgvSports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSports.EnableHeadersVisualStyles = false;
            this.dgvSports.GridColor = System.Drawing.Color.FromArgb(208, 206, 206);
            this.dgvSports.Location = new System.Drawing.Point(0, 0);
            this.dgvSports.MultiSelect = false;
            this.dgvSports.Name = "dgvSports";
            this.dgvSports.ReadOnly = true;
            this.dgvSports.RowHeadersVisible = false;
            this.dgvSports.RowTemplate.Height = 40;
            this.dgvSports.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSports.Size = new System.Drawing.Size(1152, 564);
            this.dgvSports.TabIndex = 0;

            // 
            // SportID
            // 
            this.SportID.AutoSizeMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.SportID.DataPropertyName = "SportID";
            this.SportID.HeaderText = "Sport ID";
            this.SportID.MinimumWidth = 8;
            this.SportID.Name = "SportID";
            this.SportID.ReadOnly = true;
            this.SportID.Width = 121;

            // 
            // SportName
            // 
            this.SportName.AutoSizeMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.SportName.DataPropertyName = "Nom";
            this.SportName.HeaderText = "Nom De Sport";
            this.SportName.MinimumWidth = 8;
            this.SportName.Name = "SportName";
            this.SportName.ReadOnly = true;
            this.SportName.Width = 175;

            // 
            // Description
            // 
            this.Description.AutoSizeMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 8;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;

            // 
            // EstActif
            // 
            this.EstActif.AutoSizeMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.EstActif.DataPropertyName = "EstActif";
            this.EstActif.HeaderText = "Est Actif";
            this.EstActif.MinimumWidth = 8;
            this.EstActif.Name = "EstActif";
            this.EstActif.ReadOnly = true;
            this.EstActif.Width = 88;

            // 
            // pnlActions
            // 
            this.pnlActions.BackColor = System.Drawing.Color.FromArgb(240, 239, 234);
            this.pnlActions.Controls.Add(this.flpActions);
            this.pnlActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlActions.Location = new System.Drawing.Point(24, 704);
            this.pnlActions.Margin = new System.Windows.Forms.Padding(0);
            this.pnlActions.Name = "pnlActions";
            this.pnlActions.Size = new System.Drawing.Size(1152, 56);
            this.pnlActions.TabIndex = 3;

            // 
            // flpActions
            // 
            this.flpActions.Controls.Add(this.btnEdit);
            this.flpActions.Controls.Add(this.btnAdd);
            this.flpActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpActions.FlowDirection =
                System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpActions.Location = new System.Drawing.Point(0, 0);
            this.flpActions.Margin = new System.Windows.Forms.Padding(0);
            this.flpActions.Name = "flpActions";
            this.flpActions.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.flpActions.Size = new System.Drawing.Size(1152, 56);
            this.flpActions.TabIndex = 0;
            this.flpActions.WrapContents = false;

            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.White;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatAppearance.BorderColor =
                System.Drawing.Color.FromArgb(208, 206, 206);
            this.btnEdit.FlatAppearance.BorderSize = 1;
            this.btnEdit.FlatAppearance.MouseDownBackColor =
                System.Drawing.Color.FromArgb(232, 230, 224);
            this.btnEdit.FlatAppearance.MouseOverBackColor =
                System.Drawing.Color.FromArgb(245, 244, 240);
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnEdit.ForeColor = System.Drawing.Color.FromArgb(26, 26, 26);
            this.btnEdit.Location = new System.Drawing.Point(1012, 8);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(140, 38);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Text = "Modifier";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);

            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderColor =
                System.Drawing.Color.FromArgb(208, 206, 206);
            this.btnAdd.FlatAppearance.BorderSize = 1;
            this.btnAdd.FlatAppearance.MouseDownBackColor =
                System.Drawing.Color.FromArgb(232, 230, 224);
            this.btnAdd.FlatAppearance.MouseOverBackColor =
                System.Drawing.Color.FromArgb(245, 244, 240);
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(26, 26, 26);
            this.btnAdd.Location = new System.Drawing.Point(864, 8);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(140, 38);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "+  Ajouter";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            // 
            // cmsSports
            // 
            this.cmsSports.BackColor = System.Drawing.Color.White;
            this.cmsSports.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmsSports.ForeColor = System.Drawing.Color.FromArgb(26, 26, 26);
            this.cmsSports.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsSports.Items.AddRange(
                new System.Windows.Forms.ToolStripItem[]
                {
                    this.supprimmerToolStripMenuItem
                });
            this.cmsSports.Name = "contextMenuStrip1";
            this.cmsSports.Size = new System.Drawing.Size(184, 36);

            // 
            // supprimmerToolStripMenuItem
            // 
            this.supprimmerToolStripMenuItem.Name = "supprimmerToolStripMenuItem";
            this.supprimmerToolStripMenuItem.Size = new System.Drawing.Size(183, 32);
            this.supprimmerToolStripMenuItem.Text = "Supprimmer";
            this.supprimmerToolStripMenuItem.Click +=
                new System.EventHandler(this.supprimmerToolStripMenuItem_Click);

            // 
            // uctrlShowListSports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(240, 239, 234);
            this.Controls.Add(this.tlpMain);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "uctrlShowListSports";
            this.Size = new System.Drawing.Size(1200, 780);

            this.tlpMain.ResumeLayout(false);
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.pnlSports.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSports)).EndInit();
            this.pnlActions.ResumeLayout(false);
            this.flpActions.ResumeLayout(false);
            this.cmsSports.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn SportID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SportName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewCheckBoxColumn EstActif;
        private System.Windows.Forms.ContextMenuStrip cmsSports;
        private System.Windows.Forms.ToolStripMenuItem supprimmerToolStripMenuItem;
    }
}
