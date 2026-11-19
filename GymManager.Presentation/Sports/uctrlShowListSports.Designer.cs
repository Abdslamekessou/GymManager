
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
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.pnlSports = new System.Windows.Forms.Panel();
            this.dgvSports = new System.Windows.Forms.DataGridView();
            this.cmsSports = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AjouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SportID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SportName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstActif = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pnlActions = new System.Windows.Forms.Panel();
            this.flpActions = new System.Windows.Forms.FlowLayoutPanel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();

            this.tlpMain.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.pnlSports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSports)).BeginInit();
            this.cmsSports.SuspendLayout();
            this.pnlActions.SuspendLayout();
            this.flpActions.SuspendLayout();
            this.SuspendLayout();

            // 
            // tlpMain
            // 
            this.tlpMain.BackColor = System.Drawing.Color.FromArgb(243, 244, 246);
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.lblTitle, 0, 0);
            this.tlpMain.Controls.Add(this.pnlSearch, 0, 1);
            this.tlpMain.Controls.Add(this.pnlSports, 0, 2);
            this.tlpMain.Controls.Add(this.pnlActions, 0, 3);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Margin = new System.Windows.Forms.Padding(0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.Padding = new System.Windows.Forms.Padding(24, 20, 24, 18);
            this.tlpMain.RowCount = 5;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.Size = new System.Drawing.Size(1200, 780);
            this.tlpMain.TabIndex = 0;

            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(16, 26, 45);
            this.lblTitle.Location = new System.Drawing.Point(24, 20);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1152, 52);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "GESTION DES SPORTS";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.Color.White;
            this.pnlSearch.Controls.Add(this.txtSearch);
            this.pnlSearch.Controls.Add(this.lblSearch);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSearch.Location = new System.Drawing.Point(24, 78);
            this.pnlSearch.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Padding = new System.Windows.Forms.Padding(14, 10, 14, 10);
            this.pnlSearch.Size = new System.Drawing.Size(1152, 52);
            this.pnlSearch.TabIndex = 1;

            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(23, 32, 51);
            this.txtSearch.Location = new System.Drawing.Point(328, 18);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(0);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(350, 45);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);

            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            this.lblSearch.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.lblSearch.Location = new System.Drawing.Point(14, 18);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(311, 30);
            this.lblSearch.TabIndex = 1;
            this.lblSearch.Text = "Chercher par Nom de Sport :";

            // 
            // pnlSports
            // 
            this.pnlSports.BackColor = System.Drawing.Color.White;
            this.pnlSports.Controls.Add(this.dgvSports);
            this.pnlSports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSports.Location = new System.Drawing.Point(24, 140);
            this.pnlSports.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSports.Name = "pnlSports";
            this.pnlSports.Padding = new System.Windows.Forms.Padding(1);
            this.pnlSports.Size = new System.Drawing.Size(1152, 544);
            this.pnlSports.TabIndex = 2;

            // 
            // dgvSports
            // 
            this.dgvSports.AllowUserToAddRows = false;
            this.dgvSports.AllowUserToDeleteRows = false;
            this.dgvSports.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSports.BackgroundColor = System.Drawing.Color.White;
            this.dgvSports.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSports.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSports.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;

            // Alternating rows style
            this.dgvSports.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.dgvSports.AlternatingRowsDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(23, 32, 51);
            this.dgvSports.AlternatingRowsDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.dgvSports.AlternatingRowsDefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(23, 32, 51);

            // Column headers style
            this.dgvSports.ColumnHeadersDefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvSports.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(16, 26, 45);
            this.dgvSports.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F,System.Drawing.FontStyle.Bold);
            this.dgvSports.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvSports.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(16, 26, 45);
            this.dgvSports.ColumnHeadersDefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvSports.ColumnHeadersDefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;

            this.dgvSports.ColumnHeadersHeight = 44;
            this.dgvSports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            this.dgvSports.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
        this.SportID,
        this.SportName,
        this.Description,
        this.EstActif
    });

            this.dgvSports.ContextMenuStrip = this.cmsSports;

            // Default cell style
            this.dgvSports.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvSports.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvSports.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvSports.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(23, 32, 51);
            this.dgvSports.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.dgvSports.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvSports.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(23, 32, 51);
            this.dgvSports.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;

            this.dgvSports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSports.EnableHeadersVisualStyles = false;
            this.dgvSports.GridColor = System.Drawing.Color.FromArgb(220, 225, 230);
            this.dgvSports.Location = new System.Drawing.Point(1, 1);
            this.dgvSports.MultiSelect = false;
            this.dgvSports.Name = "dgvSports";
            this.dgvSports.ReadOnly = true;
            this.dgvSports.RowHeadersVisible = false;
            this.dgvSports.RowHeadersWidth = 62;
            this.dgvSports.RowTemplate.Height = 42;
            this.dgvSports.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSports.Size = new System.Drawing.Size(1150, 542);
            this.dgvSports.TabIndex = 0;

            // 
            // cmsSports
            // 
            this.cmsSports.BackColor = System.Drawing.Color.White;
            this.cmsSports.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cmsSports.ForeColor = System.Drawing.Color.FromArgb(23, 32, 51);
            this.cmsSports.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsSports.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
        this.AjouterToolStripMenuItem,
        this.modifierToolStripMenuItem,
        this.toolStripSeparator1,
        this.supprimerToolStripMenuItem
    });
            this.cmsSports.Name = "contextMenuStrip1";
            this.cmsSports.Size = new System.Drawing.Size(181, 106);

            // 
            // AjouterToolStripMenuItem
            // 
            this.AjouterToolStripMenuItem.Image = global::GymManager.Presentation.Properties.Resources.AddAppointment_32;
            this.AjouterToolStripMenuItem.Name = "AjouterToolStripMenuItem";
            this.AjouterToolStripMenuItem.Size = new System.Drawing.Size(180, 32);
            this.AjouterToolStripMenuItem.Text = "Ajouter";
            this.AjouterToolStripMenuItem.Click += new System.EventHandler(this.AjouterToolStripMenuItem_Click);

            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.Image = global::GymManager.Presentation.Properties.Resources.Save_32;
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(180, 32);
            this.modifierToolStripMenuItem.Text = "Modifier";
            this.modifierToolStripMenuItem.Click += new System.EventHandler(this.modifierToolStripMenuItem_Click);

            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);

            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Image = global::GymManager.Presentation.Properties.Resources.Delete_321;
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(180, 32);
            this.supprimerToolStripMenuItem.Text = "Supprimer";
            this.supprimerToolStripMenuItem.Click += new System.EventHandler(this.supprimerToolStripMenuItem_Click);

            // 
            // SportID
            // 
            this.SportID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.SportID.DataPropertyName = "SportID";
            this.SportID.HeaderText = "Sport ID";
            this.SportID.MinimumWidth = 90;
            this.SportID.Name = "SportID";
            this.SportID.ReadOnly = true;
            this.SportID.Width = 135;

            // 
            // SportName
            // 
            this.SportName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.SportName.DataPropertyName = "Nom";
            this.SportName.HeaderText = "Nom du sport";
            this.SportName.MinimumWidth = 150;
            this.SportName.Name = "SportName";
            this.SportName.ReadOnly = true;
            this.SportName.Width = 185;

            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 200;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;

            // 
            // EstActif
            // 
            this.EstActif.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.EstActif.DataPropertyName = "EstActif";
            this.EstActif.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.EstActif.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            this.EstActif.DefaultCellStyle.NullValue = false;
            this.EstActif.HeaderText = "Est actif";
            this.EstActif.MinimumWidth = 90;
            this.EstActif.Name = "EstActif";
            this.EstActif.ReadOnly = true;
            this.EstActif.Width = 99;

            // 
            // pnlActions
            // 
            this.pnlActions.BackColor = System.Drawing.Color.FromArgb(243, 244, 246);
            this.pnlActions.Controls.Add(this.flpActions);
            this.pnlActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlActions.Location = new System.Drawing.Point(24, 684);
            this.pnlActions.Margin = new System.Windows.Forms.Padding(0);
            this.pnlActions.Name = "pnlActions";
            this.pnlActions.Size = new System.Drawing.Size(1152, 58);
            this.pnlActions.TabIndex = 3;

            // 
            // flpActions
            // 
            this.flpActions.Controls.Add(this.btnEdit);
            this.flpActions.Controls.Add(this.btnAdd);
            this.flpActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpActions.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpActions.Location = new System.Drawing.Point(0, 0);
            this.flpActions.Margin = new System.Windows.Forms.Padding(0);
            this.flpActions.Name = "flpActions";
            this.flpActions.Padding = new System.Windows.Forms.Padding(0, 9, 0, 0);
            this.flpActions.Size = new System.Drawing.Size(1152, 58);
            this.flpActions.TabIndex = 0;
            this.flpActions.WrapContents = false;

            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.White;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(220, 225, 230);
            this.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(243, 244, 246);
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEdit.ForeColor = System.Drawing.Color.FromArgb(23, 32, 51);
            this.btnEdit.Location = new System.Drawing.Point(1004, 9);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(148, 40);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Text = "Modifier";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);

            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(29, 78, 216);
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(29, 78, 216);
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(848, 9);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(148, 40);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "+  Ajouter";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            // 
            // uctrlShowListSports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(243, 244, 246);
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
            this.cmsSports.ResumeLayout(false);
            this.pnlActions.ResumeLayout(false);
            this.flpActions.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip cmsSports;
        private System.Windows.Forms.ToolStripMenuItem AjouterToolStripMenuItem;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn SportID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SportName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewCheckBoxColumn EstActif;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
    }
}
