
namespace GymManager.Presentation.Sports
{
    partial class uctrlAjouterModifierSport
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.TableLayoutPanel tlpForm;
        private System.Windows.Forms.Label lblSportName;
        private System.Windows.Forms.TextBox txtSportName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.FlowLayoutPanel flpStatus;
        private System.Windows.Forms.RadioButton rbActive;
        private System.Windows.Forms.RadioButton rbInactive;

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
            this.pnlForm = new System.Windows.Forms.Panel();
            this.tlpForm = new System.Windows.Forms.TableLayoutPanel();
            this.lblSportName = new System.Windows.Forms.Label();
            this.txtSportName = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.flpStatus = new System.Windows.Forms.FlowLayoutPanel();
            this.rbActive = new System.Windows.Forms.RadioButton();
            this.rbInactive = new System.Windows.Forms.RadioButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tlpMain.SuspendLayout();
            this.pnlForm.SuspendLayout();
            this.tlpForm.SuspendLayout();
            this.flpStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.lblTitle, 0, 0);
            this.tlpMain.Controls.Add(this.pnlForm, 0, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Margin = new System.Windows.Forms.Padding(0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.Padding = new System.Windows.Forms.Padding(20, 15, 20, 15);
            this.tlpMain.RowCount = 2;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Size = new System.Drawing.Size(1200, 780);
            this.tlpMain.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(55)))), ((int)(((byte)(63)))));
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1160, 60);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Ajouter un Sport";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlForm
            // 
            this.pnlForm.BackColor = this.BackColor;
            this.pnlForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlForm.Controls.Add(this.tlpForm);
            this.pnlForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlForm.Location = new System.Drawing.Point(20, 80);
            this.pnlForm.Margin = new System.Windows.Forms.Padding(0);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Padding = new System.Windows.Forms.Padding(20);
            this.pnlForm.Size = new System.Drawing.Size(1160, 685);
            this.pnlForm.TabIndex = 1;
            // 
            // tlpForm
            // 
            this.tlpForm.ColumnCount = 1;
            this.tlpForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpForm.Controls.Add(this.lblSportName, 0, 0);
            this.tlpForm.Controls.Add(this.txtSportName, 0, 1);
            this.tlpForm.Controls.Add(this.lblDescription, 0, 2);
            this.tlpForm.Controls.Add(this.txtDescription, 0, 3);
            this.tlpForm.Controls.Add(this.lblStatus, 0, 4);
            this.tlpForm.Controls.Add(this.flpStatus, 0, 5);
            this.tlpForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpForm.Location = new System.Drawing.Point(20, 20);
            this.tlpForm.Margin = new System.Windows.Forms.Padding(0);
            this.tlpForm.Name = "tlpForm";
            this.tlpForm.RowCount = 7;
            this.tlpForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tlpForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tlpForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tlpForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpForm.Size = new System.Drawing.Size(1118, 643);
            this.tlpForm.TabIndex = 0;
            // 
            // lblSportName
            // 
            this.lblSportName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSportName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(55)))), ((int)(((byte)(63)))));
            this.lblSportName.Location = new System.Drawing.Point(0, 0);
            this.lblSportName.Margin = new System.Windows.Forms.Padding(0);
            this.lblSportName.Name = "lblSportName";
            this.lblSportName.Size = new System.Drawing.Size(1118, 30);
            this.lblSportName.TabIndex = 0;
            this.lblSportName.Text = "Nom du sport *";
            this.lblSportName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSportName
            // 
            this.txtSportName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSportName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtSportName.Location = new System.Drawing.Point(0, 33);
            this.txtSportName.Margin = new System.Windows.Forms.Padding(0, 3, 0, 8);
            this.txtSportName.Name = "txtSportName";
            this.txtSportName.Size = new System.Drawing.Size(355, 37);
            this.txtSportName.TabIndex = 0;
            this.txtSportName.Validating += new System.ComponentModel.CancelEventHandler(this.txtSportName_Validating);
            // 
            // lblDescription
            // 
            this.lblDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(55)))), ((int)(((byte)(63)))));
            this.lblDescription.Location = new System.Drawing.Point(0, 80);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(1118, 35);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Description";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDescription
            // 
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtDescription.Location = new System.Drawing.Point(0, 118);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(0, 3, 0, 8);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(1118, 119);
            this.txtDescription.TabIndex = 1;
            // 
            // lblStatus
            // 
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(55)))), ((int)(((byte)(63)))));
            this.lblStatus.Location = new System.Drawing.Point(0, 245);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(1118, 35);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Statut *";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flpStatus
            // 
            this.flpStatus.Controls.Add(this.rbActive);
            this.flpStatus.Controls.Add(this.rbInactive);
            this.flpStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpStatus.Location = new System.Drawing.Point(0, 280);
            this.flpStatus.Margin = new System.Windows.Forms.Padding(0);
            this.flpStatus.Name = "flpStatus";
            this.flpStatus.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.flpStatus.Size = new System.Drawing.Size(1118, 45);
            this.flpStatus.TabIndex = 3;
            this.flpStatus.WrapContents = false;
            // 
            // rbActive
            // 
            this.rbActive.AutoSize = true;
            this.rbActive.Checked = true;
            this.rbActive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(55)))), ((int)(((byte)(63)))));
            this.rbActive.Location = new System.Drawing.Point(0, 8);
            this.rbActive.Margin = new System.Windows.Forms.Padding(0, 3, 65, 3);
            this.rbActive.Name = "rbActive";
            this.rbActive.Size = new System.Drawing.Size(77, 32);
            this.rbActive.TabIndex = 2;
            this.rbActive.TabStop = true;
            this.rbActive.Text = "Actif";
            this.rbActive.UseVisualStyleBackColor = true;
            // 
            // rbInactive
            // 
            this.rbInactive.AutoSize = true;
            this.rbInactive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(55)))), ((int)(((byte)(63)))));
            this.rbInactive.Location = new System.Drawing.Point(142, 8);
            this.rbInactive.Margin = new System.Windows.Forms.Padding(0, 3, 10, 3);
            this.rbInactive.Name = "rbInactive";
            this.rbInactive.Size = new System.Drawing.Size(90, 32);
            this.rbInactive.TabIndex = 3;
            this.rbInactive.Text = "Inactif";
            this.rbInactive.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // uctrlAjouterModifierSport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.tlpMain);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.MinimumSize = new System.Drawing.Size(600, 450);
            this.Name = "uctrlAjouterModifierSport";
            this.Size = new System.Drawing.Size(1200, 780);
            this.tlpMain.ResumeLayout(false);
            this.pnlForm.ResumeLayout(false);
            this.tlpForm.ResumeLayout(false);
            this.tlpForm.PerformLayout();
            this.flpStatus.ResumeLayout(false);
            this.flpStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}