namespace GymManager.Presentation.Abonnements.Control
{
    partial class ucListAbonnmentPerson
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.Label lblFilterStatut;
        private System.Windows.Forms.ComboBox cbFilterStatut;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.DataGridView dgvAbonnements;

        private System.Windows.Forms.DataGridViewTextBoxColumn AbonnementID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeAbonnement;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateDebut;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrixPaye;
        private System.Windows.Forms.DataGridViewTextBoxColumn Statut;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.lblFilterStatut = new System.Windows.Forms.Label();
            this.cbFilterStatut = new System.Windows.Forms.ComboBox();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.dgvAbonnements = new System.Windows.Forms.DataGridView();
            this.AbonnementID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeAbonnement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateDebut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrixPaye = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Statut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlpMain.SuspendLayout();
            this.pnlFilter.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbonnements)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.pnlFilter, 0, 0);
            this.tlpMain.Controls.Add(this.pnlGrid, 0, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Margin = new System.Windows.Forms.Padding(0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.Padding = new System.Windows.Forms.Padding(24, 18, 24, 18);
            this.tlpMain.RowCount = 2;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 87F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Size = new System.Drawing.Size(1498, 807);
            this.tlpMain.TabIndex = 0;
            // 
            // pnlFilter
            // 
            this.pnlFilter.BackColor = System.Drawing.Color.White;
            this.pnlFilter.Controls.Add(this.lblFilterStatut);
            this.pnlFilter.Controls.Add(this.cbFilterStatut);
            this.pnlFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFilter.Location = new System.Drawing.Point(24, 18);
            this.pnlFilter.Margin = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Padding = new System.Windows.Forms.Padding(21, 12, 21, 12);
            this.pnlFilter.Size = new System.Drawing.Size(1450, 72);
            this.pnlFilter.TabIndex = 0;
            // 
            // lblFilterStatut
            // 
            this.lblFilterStatut.AutoSize = true;
            this.lblFilterStatut.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblFilterStatut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblFilterStatut.Location = new System.Drawing.Point(21, 21);
            this.lblFilterStatut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFilterStatut.Name = "lblFilterStatut";
            this.lblFilterStatut.Size = new System.Drawing.Size(179, 28);
            this.lblFilterStatut.TabIndex = 0;
            this.lblFilterStatut.Text = "Filtrer par statut :";
            // 
            // cbFilterStatut
            // 
            this.cbFilterStatut.BackColor = System.Drawing.Color.White;
            this.cbFilterStatut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterStatut.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilterStatut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.cbFilterStatut.FormattingEnabled = true;
            this.cbFilterStatut.Items.AddRange(new object[] {
            "Tous",
            "Actif",
            "Annulé",
            "Expiré"});
            this.cbFilterStatut.Location = new System.Drawing.Point(224, 21);
            this.cbFilterStatut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbFilterStatut.Name = "cbFilterStatut";
            this.cbFilterStatut.Size = new System.Drawing.Size(298, 36);
            this.cbFilterStatut.TabIndex = 1;
            this.cbFilterStatut.SelectedIndexChanged += new System.EventHandler(this.cbFilterStatut_SelectedIndexChanged);
            // 
            // pnlGrid
            // 
            this.pnlGrid.BackColor = System.Drawing.Color.White;
            this.pnlGrid.Controls.Add(this.dgvAbonnements);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Location = new System.Drawing.Point(24, 105);
            this.pnlGrid.Margin = new System.Windows.Forms.Padding(0);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlGrid.Size = new System.Drawing.Size(1450, 684);
            this.pnlGrid.TabIndex = 1;
            // 
            // dgvAbonnements
            // 
            this.dgvAbonnements.AllowUserToAddRows = false;
            this.dgvAbonnements.AllowUserToDeleteRows = false;
            this.dgvAbonnements.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(26)))), ((int)(((byte)(45)))));
            this.dgvAbonnements.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAbonnements.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAbonnements.BackgroundColor = System.Drawing.Color.White;
            this.dgvAbonnements.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAbonnements.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAbonnements.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(26)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(26)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAbonnements.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAbonnements.ColumnHeadersHeight = 44;
            this.dgvAbonnements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAbonnements.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AbonnementID,
            this.TypeAbonnement,
            this.DateDebut,
            this.DateFin,
            this.PrixPaye,
            this.Statut});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(26)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAbonnements.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvAbonnements.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAbonnements.EnableHeadersVisualStyles = false;
            this.dgvAbonnements.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(225)))), ((int)(((byte)(230)))));
            this.dgvAbonnements.Location = new System.Drawing.Point(2, 2);
            this.dgvAbonnements.Margin = new System.Windows.Forms.Padding(0);
            this.dgvAbonnements.MultiSelect = false;
            this.dgvAbonnements.Name = "dgvAbonnements";
            this.dgvAbonnements.ReadOnly = true;
            this.dgvAbonnements.RowHeadersVisible = false;
            this.dgvAbonnements.RowHeadersWidth = 62;
            this.dgvAbonnements.RowTemplate.Height = 40;
            this.dgvAbonnements.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAbonnements.Size = new System.Drawing.Size(1446, 680);
            this.dgvAbonnements.TabIndex = 0;
            // 
            // AbonnementID
            // 
            this.AbonnementID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.AbonnementID.DataPropertyName = "AbonnementID";
            this.AbonnementID.HeaderText = "Abonnement ID";
            this.AbonnementID.MinimumWidth = 110;
            this.AbonnementID.Name = "AbonnementID";
            this.AbonnementID.ReadOnly = true;
            this.AbonnementID.Width = 211;
            // 
            // TypeAbonnement
            // 
            this.TypeAbonnement.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TypeAbonnement.DataPropertyName = "TypeAbonnement";
            this.TypeAbonnement.HeaderText = "Type";
            this.TypeAbonnement.MinimumWidth = 130;
            this.TypeAbonnement.Name = "TypeAbonnement";
            this.TypeAbonnement.ReadOnly = true;
            // 
            // DateDebut
            // 
            this.DateDebut.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DateDebut.DataPropertyName = "DateDebut";
            dataGridViewCellStyle3.Format = "dd/mm/yyyy";
            this.DateDebut.DefaultCellStyle = dataGridViewCellStyle3;
            this.DateDebut.HeaderText = "Début";
            this.DateDebut.MinimumWidth = 100;
            this.DateDebut.Name = "DateDebut";
            this.DateDebut.ReadOnly = true;
            this.DateDebut.Width = 120;
            // 
            // DateFin
            // 
            this.DateFin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DateFin.DataPropertyName = "DateFin";
            dataGridViewCellStyle4.Format = "dd/mm/yyyy";
            this.DateFin.DefaultCellStyle = dataGridViewCellStyle4;
            this.DateFin.HeaderText = "Fin";
            this.DateFin.MinimumWidth = 100;
            this.DateFin.Name = "DateFin";
            this.DateFin.ReadOnly = true;
            // 
            // PrixPaye
            // 
            this.PrixPaye.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PrixPaye.DataPropertyName = "PrixPaye";
            this.PrixPaye.HeaderText = "Prix payé";
            this.PrixPaye.MinimumWidth = 110;
            this.PrixPaye.Name = "PrixPaye";
            this.PrixPaye.ReadOnly = true;
            this.PrixPaye.Width = 150;
            // 
            // Statut
            // 
            this.Statut.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Statut.DataPropertyName = "Statut";
            this.Statut.HeaderText = "Statut";
            this.Statut.MinimumWidth = 100;
            this.Statut.Name = "Statut";
            this.Statut.ReadOnly = true;
            this.Statut.Width = 120;
            // 
            // ucListAbonnmentPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.Controls.Add(this.tlpMain);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ucListAbonnmentPerson";
            this.Size = new System.Drawing.Size(1498, 807);
            this.tlpMain.ResumeLayout(false);
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbonnements)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}