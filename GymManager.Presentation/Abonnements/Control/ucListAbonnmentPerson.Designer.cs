namespace GymManager.Presentation.Abonnements.Control
{
    partial class ucListAbonnmentPerson
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvAbonnements = new System.Windows.Forms.DataGridView();
            this.cbFilterStatut = new System.Windows.Forms.ComboBox();
            this.lblFilterStatut = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbonnements)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAbonnements
            // 
            this.dgvAbonnements.AllowUserToAddRows = false;
            this.dgvAbonnements.AllowUserToDeleteRows = false;
            this.dgvAbonnements.AllowUserToResizeRows = false;
            this.dgvAbonnements.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAbonnements.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAbonnements.BackgroundColor = System.Drawing.Color.White;
            this.dgvAbonnements.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvAbonnements.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAbonnements.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAbonnements.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvAbonnements.ColumnHeadersHeight = 35;
            this.dgvAbonnements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAbonnements.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvAbonnements.EnableHeadersVisualStyles = false;
            this.dgvAbonnements.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dgvAbonnements.Location = new System.Drawing.Point(3, 52);
            this.dgvAbonnements.MultiSelect = false;
            this.dgvAbonnements.Name = "dgvAbonnements";
            this.dgvAbonnements.ReadOnly = true;
            this.dgvAbonnements.RowHeadersVisible = false;
            this.dgvAbonnements.RowHeadersWidth = 62;
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.dgvAbonnements.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvAbonnements.RowTemplate.Height = 32;
            this.dgvAbonnements.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAbonnements.Size = new System.Drawing.Size(978, 442);
            this.dgvAbonnements.TabIndex = 9;
            // 
            // cbFilterStatut
            // 
            this.cbFilterStatut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterStatut.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cbFilterStatut.FormattingEnabled = true;
            this.cbFilterStatut.Items.AddRange(new object[] {
            "Tous",
            "Actif",
            "Annulé",
            "Expiré"});
            this.cbFilterStatut.Location = new System.Drawing.Point(118, 14);
            this.cbFilterStatut.Name = "cbFilterStatut";
            this.cbFilterStatut.Size = new System.Drawing.Size(180, 33);
            this.cbFilterStatut.TabIndex = 8;
            this.cbFilterStatut.SelectedIndexChanged += new System.EventHandler(this.cbFilterStatut_SelectedIndexChanged);
            // 
            // lblFilterStatut
            // 
            this.lblFilterStatut.AutoSize = true;
            this.lblFilterStatut.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilterStatut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblFilterStatut.Location = new System.Drawing.Point(3, 17);
            this.lblFilterStatut.Name = "lblFilterStatut";
            this.lblFilterStatut.Size = new System.Drawing.Size(155, 25);
            this.lblFilterStatut.TabIndex = 7;
            this.lblFilterStatut.Text = "Filtrer par statut :";
            // 
            // ucListAbonnmentPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgvAbonnements);
            this.Controls.Add(this.cbFilterStatut);
            this.Controls.Add(this.lblFilterStatut);
            this.Name = "ucListAbonnmentPerson";
            this.Size = new System.Drawing.Size(999, 511);
            this.Load += new System.EventHandler(this.ucListAbonnmentPerson_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbonnements)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAbonnements;
        private System.Windows.Forms.ComboBox cbFilterStatut;
        private System.Windows.Forms.Label lblFilterStatut;
    }
}
