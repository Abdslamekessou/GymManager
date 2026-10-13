
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pnlSports = new System.Windows.Forms.Panel();
            this.dgvSports = new System.Windows.Forms.DataGridView();
            this.pnlActions = new System.Windows.Forms.Panel();
            this.flpActions = new System.Windows.Forms.FlowLayoutPanel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SportID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SportName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstActif = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tlpMain.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.pnlSports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSports)).BeginInit();
            this.pnlActions.SuspendLayout();
            this.flpActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.BackColor = this.BackColor;
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
            this.tlpMain.Padding = new System.Windows.Forms.Padding(20, 15, 20, 15);
            this.tlpMain.RowCount = 4;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpMain.Size = new System.Drawing.Size(1200, 780);
            this.tlpMain.TabIndex = 0;
            this.tlpMain.Paint += new System.Windows.Forms.PaintEventHandler(this.tlpMain_Paint);
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(55)))), ((int)(((byte)(63)))));
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1160, 55);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Gestion des Sports";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = this.BackColor;
            this.pnlSearch.Controls.Add(this.txtSearch);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSearch.Location = new System.Drawing.Point(20, 80);
            this.pnlSearch.Margin = new System.Windows.Forms.Padding(0, 5, 0, 10);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(1160, 50);
            this.pnlSearch.TabIndex = 1;
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtSearch.Location = new System.Drawing.Point(0, 0);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(0);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(500, 37);
            this.txtSearch.TabIndex = 0;
            // 
            // pnlSports
            // 
            this.pnlSports.BackColor = this.BackColor;
            this.pnlSports.Controls.Add(this.dgvSports);
            this.pnlSports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSports.Location = new System.Drawing.Point(20, 140);
            this.pnlSports.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSports.Name = "pnlSports";
            this.pnlSports.Size = new System.Drawing.Size(1160, 565);
            this.pnlSports.TabIndex = 2;
            // 
            // dgvSports
            // 
            this.dgvSports.AllowUserToAddRows = false;
            this.dgvSports.AllowUserToDeleteRows = false;
            this.dgvSports.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSports.BackgroundColor = this.BackColor;
            this.dgvSports.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(55)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSports.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSports.ColumnHeadersHeight = 45;
            this.dgvSports.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SportID,
            this.SportName,
            this.Description,
            this.EstActif});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(55)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(228)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(55)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSports.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSports.EnableHeadersVisualStyles = false;
            this.dgvSports.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(231)))));
            this.dgvSports.Location = new System.Drawing.Point(0, 0);
            this.dgvSports.MultiSelect = false;
            this.dgvSports.Name = "dgvSports";
            this.dgvSports.ReadOnly = true;
            this.dgvSports.RowHeadersVisible = false;
            this.dgvSports.RowHeadersWidth = 62;
            this.dgvSports.RowTemplate.Height = 42;
            this.dgvSports.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSports.Size = new System.Drawing.Size(1160, 565);
            this.dgvSports.TabIndex = 0;
            // 
            // pnlActions
            // 
            this.pnlActions.BackColor = this.BackColor;
            this.pnlActions.Controls.Add(this.flpActions);
            this.pnlActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlActions.Location = new System.Drawing.Point(20, 705);
            this.pnlActions.Margin = new System.Windows.Forms.Padding(0);
            this.pnlActions.Name = "pnlActions";
            this.pnlActions.Size = new System.Drawing.Size(1160, 60);
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
            this.flpActions.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.flpActions.Size = new System.Drawing.Size(1160, 60);
            this.flpActions.TabIndex = 0;
            this.flpActions.WrapContents = false;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = this.BackColor;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(209)))), ((int)(((byte)(213)))));
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(55)))), ((int)(((byte)(63)))));
            this.btnEdit.Location = new System.Drawing.Point(1020, 5);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(140, 35);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Text = "Modifier";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = this.BackColor;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(209)))), ((int)(((byte)(213)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(55)))), ((int)(((byte)(63)))));
            this.btnAdd.Location = new System.Drawing.Point(872, 5);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(140, 35);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "+  Ajouter";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // SportID
            // 
            this.SportID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.SportID.DataPropertyName = "SportID";
            this.SportID.HeaderText = "Sport ID";
            this.SportID.MinimumWidth = 8;
            this.SportID.Name = "SportID";
            this.SportID.ReadOnly = true;
            this.SportID.Width = 127;
            // 
            // SportName
            // 
            this.SportName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.SportName.DataPropertyName = "Nom";
            this.SportName.HeaderText = "Nom De Sport";
            this.SportName.MinimumWidth = 8;
            this.SportName.Name = "SportName";
            this.SportName.ReadOnly = true;
            this.SportName.Width = 184;
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 8;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // EstActif
            // 
            this.EstActif.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.EstActif.DataPropertyName = "EstActif";
            this.EstActif.HeaderText = "Est Actif";
            this.EstActif.MinimumWidth = 8;
            this.EstActif.Name = "EstActif";
            this.EstActif.ReadOnly = true;
            this.EstActif.Width = 98;
            // 
            // uctrlShowListSports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn SportID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SportName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewCheckBoxColumn EstActif;
    }
}