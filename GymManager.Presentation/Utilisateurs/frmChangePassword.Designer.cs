
namespace GymManager.Presentation
{
    partial class frmChangePassword
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlAccountInfo = new System.Windows.Forms.Panel();
            this.lblAccountInfoTitle = new System.Windows.Forms.Label();
            this.lblFullNameLabel = new System.Windows.Forms.Label();
            this.lblFullNameValue = new System.Windows.Forms.Label();
            this.lblUsernameLabel = new System.Windows.Forms.Label();
            this.lblUsernameValue = new System.Windows.Forms.Label();
            this.pnlPassword = new System.Windows.Forms.Panel();
            this.lblNewPasswordTitle = new System.Windows.Forms.Label();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.separatorLine = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlAccountInfo.SuspendLayout();
            this.pnlPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAccountInfo
            // 
            this.pnlAccountInfo.BackColor = System.Drawing.Color.White;
            this.pnlAccountInfo.Controls.Add(this.lblAccountInfoTitle);
            this.pnlAccountInfo.Controls.Add(this.lblFullNameLabel);
            this.pnlAccountInfo.Controls.Add(this.lblFullNameValue);
            this.pnlAccountInfo.Controls.Add(this.lblUsernameLabel);
            this.pnlAccountInfo.Controls.Add(this.lblUsernameValue);
            this.pnlAccountInfo.Location = new System.Drawing.Point(30, 25);
            this.pnlAccountInfo.Name = "pnlAccountInfo";
            this.pnlAccountInfo.Size = new System.Drawing.Size(700, 145);
            this.pnlAccountInfo.TabIndex = 0;
            // 
            // lblAccountInfoTitle
            // 
            this.lblAccountInfoTitle.AutoSize = true;
            this.lblAccountInfoTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblAccountInfoTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(26)))), ((int)(((byte)(45)))));
            this.lblAccountInfoTitle.Location = new System.Drawing.Point(22, 17);
            this.lblAccountInfoTitle.Name = "lblAccountInfoTitle";
            this.lblAccountInfoTitle.Size = new System.Drawing.Size(344, 32);
            this.lblAccountInfoTitle.TabIndex = 0;
            this.lblAccountInfoTitle.Text = "INFORMATIONS DU COMPTE";
            // 
            // lblFullNameLabel
            // 
            this.lblFullNameLabel.AutoSize = true;
            this.lblFullNameLabel.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblFullNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblFullNameLabel.Location = new System.Drawing.Point(25, 65);
            this.lblFullNameLabel.Name = "lblFullNameLabel";
            this.lblFullNameLabel.Size = new System.Drawing.Size(126, 25);
            this.lblFullNameLabel.TabIndex = 1;
            this.lblFullNameLabel.Text = "Nom complet";
            // 
            // lblFullNameValue
            // 
            this.lblFullNameValue.AutoSize = true;
            this.lblFullNameValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblFullNameValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.lblFullNameValue.Location = new System.Drawing.Point(220, 65);
            this.lblFullNameValue.Name = "lblFullNameValue";
            this.lblFullNameValue.Size = new System.Drawing.Size(53, 28);
            this.lblFullNameValue.TabIndex = 2;
            this.lblFullNameValue.Text = "[???]";
            // 
            // lblUsernameLabel
            // 
            this.lblUsernameLabel.AutoSize = true;
            this.lblUsernameLabel.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblUsernameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblUsernameLabel.Location = new System.Drawing.Point(25, 105);
            this.lblUsernameLabel.Name = "lblUsernameLabel";
            this.lblUsernameLabel.Size = new System.Drawing.Size(157, 25);
            this.lblUsernameLabel.TabIndex = 3;
            this.lblUsernameLabel.Text = "Nom d\'utilisateur";
            // 
            // lblUsernameValue
            // 
            this.lblUsernameValue.AutoSize = true;
            this.lblUsernameValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblUsernameValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.lblUsernameValue.Location = new System.Drawing.Point(220, 105);
            this.lblUsernameValue.Name = "lblUsernameValue";
            this.lblUsernameValue.Size = new System.Drawing.Size(53, 28);
            this.lblUsernameValue.TabIndex = 4;
            this.lblUsernameValue.Text = "[???]";
            // 
            // pnlPassword
            // 
            this.pnlPassword.BackColor = System.Drawing.Color.White;
            this.pnlPassword.Controls.Add(this.lblNewPasswordTitle);
            this.pnlPassword.Controls.Add(this.lblNewPassword);
            this.pnlPassword.Controls.Add(this.txtNewPassword);
            this.pnlPassword.Controls.Add(this.lblConfirmPassword);
            this.pnlPassword.Controls.Add(this.txtConfirmPassword);
            this.pnlPassword.Location = new System.Drawing.Point(30, 205);
            this.pnlPassword.Name = "pnlPassword";
            this.pnlPassword.Size = new System.Drawing.Size(700, 225);
            this.pnlPassword.TabIndex = 6;
            // 
            // lblNewPasswordTitle
            // 
            this.lblNewPasswordTitle.AutoSize = true;
            this.lblNewPasswordTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblNewPasswordTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(26)))), ((int)(((byte)(45)))));
            this.lblNewPasswordTitle.Location = new System.Drawing.Point(22, 20);
            this.lblNewPasswordTitle.Name = "lblNewPasswordTitle";
            this.lblNewPasswordTitle.Size = new System.Drawing.Size(307, 32);
            this.lblNewPasswordTitle.TabIndex = 0;
            this.lblNewPasswordTitle.Text = "NOUVEAU MOT DE PASSE";
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblNewPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.lblNewPassword.Location = new System.Drawing.Point(25, 82);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(204, 25);
            this.lblNewPassword.TabIndex = 1;
            this.lblNewPassword.Text = "Nouveau mot de passe";
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNewPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNewPassword.Location = new System.Drawing.Point(271, 77);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '*';
            this.txtNewPassword.Size = new System.Drawing.Size(410, 34);
            this.txtNewPassword.TabIndex = 2;
            this.txtNewPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtNewPassword_Validating);
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.lblConfirmPassword.Location = new System.Drawing.Point(25, 145);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(233, 25);
            this.lblConfirmPassword.TabIndex = 3;
            this.lblConfirmPassword.Text = "Confirmer le mot de passe";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtConfirmPassword.Location = new System.Drawing.Point(271, 140);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(410, 34);
            this.txtConfirmPassword.TabIndex = 4;
            this.txtConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtConfirmPassword_Validating);
            // 
            // separatorLine
            // 
            this.separatorLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(225)))), ((int)(((byte)(230)))));
            this.separatorLine.Location = new System.Drawing.Point(30, 185);
            this.separatorLine.Name = "separatorLine";
            this.separatorLine.Size = new System.Drawing.Size(700, 1);
            this.separatorLine.TabIndex = 5;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(225)))), ((int)(((byte)(230)))));
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.btnCancel.Location = new System.Drawing.Point(310, 465);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(145, 42);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnChangePassword.FlatAppearance.BorderSize = 0;
            this.btnChangePassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(78)))), ((int)(((byte)(216)))));
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnChangePassword.ForeColor = System.Drawing.Color.White;
            this.btnChangePassword.Location = new System.Drawing.Point(472, 465);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(258, 42);
            this.btnChangePassword.TabIndex = 6;
            this.btnChangePassword.Text = "Changer le mot de passe";
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(760, 535);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.pnlPassword);
            this.Controls.Add(this.separatorLine);
            this.Controls.Add(this.pnlAccountInfo);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modifier le mot de passe";
            this.Load += new System.EventHandler(this.frmChangePassword_Load);
            this.pnlAccountInfo.ResumeLayout(false);
            this.pnlAccountInfo.PerformLayout();
            this.pnlPassword.ResumeLayout(false);
            this.pnlPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAccountInfo;
        private System.Windows.Forms.Panel pnlPassword;

        private System.Windows.Forms.Label lblAccountInfoTitle;
        private System.Windows.Forms.Label lblFullNameLabel;
        private System.Windows.Forms.Label lblFullNameValue;
        private System.Windows.Forms.Label lblUsernameLabel;
        private System.Windows.Forms.Label lblUsernameValue;

        private System.Windows.Forms.Label separatorLine;

        private System.Windows.Forms.Label lblNewPasswordTitle;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnChangePassword;

        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
