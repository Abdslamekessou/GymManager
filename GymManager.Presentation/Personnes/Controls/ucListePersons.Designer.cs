namespace GymManager.Presentation.Personnes.Controls
{
    partial class ucListePersons
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucListePersons));
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.txtFilterValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRecordsCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvPersons = new System.Windows.Forms.DataGridView();
            this.cmsPeople = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.AddNewtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sendEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phoneCallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gpFilters = new System.Windows.Forms.GroupBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblManagerPersonnes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersons)).BeginInit();
            this.cmsPeople.SuspendLayout();
            this.gpFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddPerson
            // 
            resources.ApplyResources(this.btnAddPerson, "btnAddPerson");
            this.errorProvider1.SetError(this.btnAddPerson, resources.GetString("btnAddPerson.Error"));
            this.errorProvider1.SetIconAlignment(this.btnAddPerson, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnAddPerson.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.btnAddPerson, ((int)(resources.GetObject("btnAddPerson.IconPadding"))));
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.UseVisualStyleBackColor = true;
            // 
            // cbFilterBy
            // 
            resources.ApplyResources(this.cbFilterBy, "cbFilterBy");
            this.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.errorProvider1.SetError(this.cbFilterBy, resources.GetString("cbFilterBy.Error"));
            this.cbFilterBy.FormattingEnabled = true;
            this.errorProvider1.SetIconAlignment(this.cbFilterBy, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("cbFilterBy.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.cbFilterBy, ((int)(resources.GetObject("cbFilterBy.IconPadding"))));
            this.cbFilterBy.Items.AddRange(new object[] {
            resources.GetString("cbFilterBy.Items"),
            resources.GetString("cbFilterBy.Items1"),
            resources.GetString("cbFilterBy.Items2"),
            resources.GetString("cbFilterBy.Items3"),
            resources.GetString("cbFilterBy.Items4"),
            resources.GetString("cbFilterBy.Items5"),
            resources.GetString("cbFilterBy.Items6")});
            this.cbFilterBy.Name = "cbFilterBy";
            // 
            // txtFilterValue
            // 
            resources.ApplyResources(this.txtFilterValue, "txtFilterValue");
            this.txtFilterValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.errorProvider1.SetError(this.txtFilterValue, resources.GetString("txtFilterValue.Error"));
            this.errorProvider1.SetIconAlignment(this.txtFilterValue, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtFilterValue.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.txtFilterValue, ((int)(resources.GetObject("txtFilterValue.IconPadding"))));
            this.txtFilterValue.Name = "txtFilterValue";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.errorProvider1.SetError(this.label1, resources.GetString("label1.Error"));
            this.errorProvider1.SetIconAlignment(this.label1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label1.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label1, ((int)(resources.GetObject("label1.IconPadding"))));
            this.label1.Name = "label1";
            // 
            // lblRecordsCount
            // 
            resources.ApplyResources(this.lblRecordsCount, "lblRecordsCount");
            this.errorProvider1.SetError(this.lblRecordsCount, resources.GetString("lblRecordsCount.Error"));
            this.errorProvider1.SetIconAlignment(this.lblRecordsCount, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblRecordsCount.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.lblRecordsCount, ((int)(resources.GetObject("lblRecordsCount.IconPadding"))));
            this.lblRecordsCount.Name = "lblRecordsCount";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.errorProvider1.SetError(this.label2, resources.GetString("label2.Error"));
            this.errorProvider1.SetIconAlignment(this.label2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label2.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label2, ((int)(resources.GetObject("label2.IconPadding"))));
            this.label2.Name = "label2";
            // 
            // dgvPersons
            // 
            resources.ApplyResources(this.dgvPersons, "dgvPersons");
            this.dgvPersons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersons.ContextMenuStrip = this.cmsPeople;
            this.errorProvider1.SetError(this.dgvPersons, resources.GetString("dgvPersons.Error"));
            this.errorProvider1.SetIconAlignment(this.dgvPersons, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("dgvPersons.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.dgvPersons, ((int)(resources.GetObject("dgvPersons.IconPadding"))));
            this.dgvPersons.Name = "dgvPersons";
            this.dgvPersons.RowTemplate.Height = 24;
            // 
            // cmsPeople
            // 
            resources.ApplyResources(this.cmsPeople, "cmsPeople");
            this.errorProvider1.SetError(this.cmsPeople, resources.GetString("cmsPeople.Error"));
            this.errorProvider1.SetIconAlignment(this.cmsPeople, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("cmsPeople.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.cmsPeople, ((int)(resources.GetObject("cmsPeople.IconPadding"))));
            this.cmsPeople.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsPeople.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsToolStripMenuItem,
            this.toolStripSeparator2,
            this.AddNewtoolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripSeparator1,
            this.sendEmailToolStripMenuItem,
            this.phoneCallToolStripMenuItem});
            this.cmsPeople.Name = "contextMenuStrip1";
            // 
            // showDetailsToolStripMenuItem
            // 
            resources.ApplyResources(this.showDetailsToolStripMenuItem, "showDetailsToolStripMenuItem");
            this.showDetailsToolStripMenuItem.Image = global::GymManager.Presentation.Properties.Resources.PersonDetails_32;
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Click += new System.EventHandler(this.showDetailsToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            // 
            // AddNewtoolStripMenuItem
            // 
            resources.ApplyResources(this.AddNewtoolStripMenuItem, "AddNewtoolStripMenuItem");
            this.AddNewtoolStripMenuItem.Image = global::GymManager.Presentation.Properties.Resources.AddPerson_32;
            this.AddNewtoolStripMenuItem.Name = "AddNewtoolStripMenuItem";
            this.AddNewtoolStripMenuItem.Click += new System.EventHandler(this.AddNewtoolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            resources.ApplyResources(this.editToolStripMenuItem, "editToolStripMenuItem");
            this.editToolStripMenuItem.Image = global::GymManager.Presentation.Properties.Resources.edit_32;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            resources.ApplyResources(this.deleteToolStripMenuItem, "deleteToolStripMenuItem");
            this.deleteToolStripMenuItem.Image = global::GymManager.Presentation.Properties.Resources.Delete_32;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            // 
            // toolStripSeparator1
            // 
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            // 
            // sendEmailToolStripMenuItem
            // 
            resources.ApplyResources(this.sendEmailToolStripMenuItem, "sendEmailToolStripMenuItem");
            this.sendEmailToolStripMenuItem.Image = global::GymManager.Presentation.Properties.Resources.send_email_32;
            this.sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
            // 
            // phoneCallToolStripMenuItem
            // 
            resources.ApplyResources(this.phoneCallToolStripMenuItem, "phoneCallToolStripMenuItem");
            this.phoneCallToolStripMenuItem.Image = global::GymManager.Presentation.Properties.Resources.Phone_32;
            this.phoneCallToolStripMenuItem.Name = "phoneCallToolStripMenuItem";
            // 
            // gpFilters
            // 
            resources.ApplyResources(this.gpFilters, "gpFilters");
            this.gpFilters.Controls.Add(this.btnAddPerson);
            this.gpFilters.Controls.Add(this.label1);
            this.gpFilters.Controls.Add(this.cbFilterBy);
            this.gpFilters.Controls.Add(this.txtFilterValue);
            this.errorProvider1.SetError(this.gpFilters, resources.GetString("gpFilters.Error"));
            this.errorProvider1.SetIconAlignment(this.gpFilters, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("gpFilters.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.gpFilters, ((int)(resources.GetObject("gpFilters.IconPadding"))));
            this.gpFilters.Name = "gpFilters";
            this.gpFilters.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            resources.ApplyResources(this.errorProvider1, "errorProvider1");
            // 
            // lblManagerPersonnes
            // 
            resources.ApplyResources(this.lblManagerPersonnes, "lblManagerPersonnes");
            this.errorProvider1.SetError(this.lblManagerPersonnes, resources.GetString("lblManagerPersonnes.Error"));
            this.lblManagerPersonnes.ForeColor = System.Drawing.Color.Red;
            this.errorProvider1.SetIconAlignment(this.lblManagerPersonnes, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblManagerPersonnes.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.lblManagerPersonnes, ((int)(resources.GetObject("lblManagerPersonnes.IconPadding"))));
            this.lblManagerPersonnes.Name = "lblManagerPersonnes";
            // 
            // ucListePersons
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblManagerPersonnes);
            this.Controls.Add(this.gpFilters);
            this.Controls.Add(this.lblRecordsCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvPersons);
            this.errorProvider1.SetError(this, resources.GetString("$this.Error"));
            this.errorProvider1.SetIconAlignment(this, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("$this.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this, ((int)(resources.GetObject("$this.IconPadding"))));
            this.Name = "ucListePersons";
            this.Load += new System.EventHandler(this.ucListePersons_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersons)).EndInit();
            this.cmsPeople.ResumeLayout(false);
            this.gpFilters.ResumeLayout(false);
            this.gpFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.TextBox txtFilterValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRecordsCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvPersons;
        private System.Windows.Forms.GroupBox gpFilters;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblManagerPersonnes;
        private System.Windows.Forms.ContextMenuStrip cmsPeople;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem AddNewtoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem sendEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phoneCallToolStripMenuItem;
    }
}
