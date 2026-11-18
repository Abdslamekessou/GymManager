
namespace GymManager.Presentation
{
    partial class frmAddUpdateUser
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            this.gbSelectPerson = new System.Windows.Forms.Panel();
            this.gbUserInfo = new System.Windows.Forms.Panel();

            this.lblPersonSection = new System.Windows.Forms.Label();
            this.lblAccountSection = new System.Windows.Forms.Label();

            this.chkIsActive = new System.Windows.Forms.CheckBox();

            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmPassword = new System.Windows.Forms.Label();

            this.cbxRole = new System.Windows.Forms.ComboBox();
            this.lblRole = new System.Windows.Forms.Label();

            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();

            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();

            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();

            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);

            this.ucPersonCardWithFilter2 =
                new GymManager.Presentation.Personnes.Controls.ucPersonCardWithFilter();

            this.gbSelectPerson.SuspendLayout();
            this.gbUserInfo.SuspendLayout();

            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();

            this.SuspendLayout();

            // 
            // gbSelectPerson - Person section
            // 
            this.gbSelectPerson.BackColor = System.Drawing.Color.White;
            this.gbSelectPerson.Location = new System.Drawing.Point(20, 20);
            this.gbSelectPerson.Name = "gbSelectPerson";
            this.gbSelectPerson.Size = new System.Drawing.Size(1124, 395);
            this.gbSelectPerson.TabIndex = 0;

            this.gbSelectPerson.Controls.Add(this.lblPersonSection);
            this.gbSelectPerson.Controls.Add(this.ucPersonCardWithFilter2);

            // 
            // lblPersonSection
            // 
            this.lblPersonSection.AutoSize = true;
            this.lblPersonSection.Font = new System.Drawing.Font(
                "Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblPersonSection.ForeColor =
                System.Drawing.Color.FromArgb(16, 26, 45);
            this.lblPersonSection.Location = new System.Drawing.Point(20, 16);
            this.lblPersonSection.Name = "lblPersonSection";
            this.lblPersonSection.Size = new System.Drawing.Size(250, 20);
            this.lblPersonSection.TabIndex = 0;
            this.lblPersonSection.Text = "1. SÉLECTIONNER UNE PERSONNE";

            // 
            // ucPersonCardWithFilter2
            // 
            this.ucPersonCardWithFilter2.AutoSize = false;
            this.ucPersonCardWithFilter2.BackColor = System.Drawing.Color.White;
            this.ucPersonCardWithFilter2.FilterEnabled = true;
            this.ucPersonCardWithFilter2.Location = new System.Drawing.Point(15, 48);
            this.ucPersonCardWithFilter2.Margin = new System.Windows.Forms.Padding(0);
            this.ucPersonCardWithFilter2.Name = "ucPersonCardWithFilter2";
            this.ucPersonCardWithFilter2.PersonCardEnabled = true;
            this.ucPersonCardWithFilter2.ShowAddPerson = true;
            this.ucPersonCardWithFilter2.Size = new System.Drawing.Size(1094, 330);
            this.ucPersonCardWithFilter2.TabIndex = 1;
            this.ucPersonCardWithFilter2.OnPersonSelected +=
                new System.Action<int>(this.ucPersonCardWithFilter2_OnPersonSelected);

            // 
            // gbUserInfo - Account section
            // 
            this.gbUserInfo.BackColor = System.Drawing.Color.White;
            this.gbUserInfo.Location = new System.Drawing.Point(20, 430);
            this.gbUserInfo.Name = "gbUserInfo";
            this.gbUserInfo.Size = new System.Drawing.Size(1124, 180);
            this.gbUserInfo.TabIndex = 1;

            this.gbUserInfo.Controls.Add(this.lblAccountSection);
            this.gbUserInfo.Controls.Add(this.chkIsActive);

            this.gbUserInfo.Controls.Add(this.txtUsername);
            this.gbUserInfo.Controls.Add(this.lblUsername);

            this.gbUserInfo.Controls.Add(this.txtPassword);
            this.gbUserInfo.Controls.Add(this.lblPassword);

            this.gbUserInfo.Controls.Add(this.cbxRole);
            this.gbUserInfo.Controls.Add(this.lblRole);

            this.gbUserInfo.Controls.Add(this.txtConfirmPassword);
            this.gbUserInfo.Controls.Add(this.lblConfirmPassword);

            // 
            // lblAccountSection
            // 
            this.lblAccountSection.AutoSize = true;
            this.lblAccountSection.Font = new System.Drawing.Font(
                "Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblAccountSection.ForeColor =
                System.Drawing.Color.FromArgb(16, 26, 45);
            this.lblAccountSection.Location = new System.Drawing.Point(20, 15);
            this.lblAccountSection.Name = "lblAccountSection";
            this.lblAccountSection.Size = new System.Drawing.Size(310, 20);
            this.lblAccountSection.TabIndex = 0;
            this.lblAccountSection.Text = "2. INFORMATIONS DU COMPTE UTILISATEUR";

            // 
            // chkIsActive
            // 
            this.chkIsActive.AutoSize = true;
            this.chkIsActive.Checked = true;
            this.chkIsActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIsActive.Font = new System.Drawing.Font(
                "Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.chkIsActive.ForeColor =
                System.Drawing.Color.FromArgb(21, 128, 61);
            this.chkIsActive.Location = new System.Drawing.Point(1000, 18);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(65, 21);
            this.chkIsActive.TabIndex = 8;
            this.chkIsActive.Text = "Actif";
            this.chkIsActive.UseVisualStyleBackColor = true;

            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblUsername.ForeColor =
                System.Drawing.Color.FromArgb(23, 32, 51);
            this.lblUsername.Location = new System.Drawing.Point(25, 65);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(128, 17);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Nom d'utilisateur :";

            // 
            // txtUsername
            // 
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtUsername.Location = new System.Drawing.Point(180, 61);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(320, 25);
            this.txtUsername.TabIndex = 2;
            this.txtUsername.Validating +=
                new System.ComponentModel.CancelEventHandler(this.txtUsername_Validating);

            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblPassword.ForeColor =
                System.Drawing.Color.FromArgb(23, 32, 51);
            this.lblPassword.Location = new System.Drawing.Point(25, 112);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(105, 17);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Mot de passe :";

            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPassword.Location = new System.Drawing.Point(180, 108);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(320, 25);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.Validating +=
                new System.ComponentModel.CancelEventHandler(this.txtPassword_Validating);

            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblRole.ForeColor =
                System.Drawing.Color.FromArgb(23, 32, 51);
            this.lblRole.Location = new System.Drawing.Point(560, 65);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(42, 17);
            this.lblRole.TabIndex = 5;
            this.lblRole.Text = "Rôle :";

            // 
            // cbxRole
            // 
            this.cbxRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRole.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxRole.FormattingEnabled = true;
            this.cbxRole.Items.AddRange(new object[] {
                "Administrateur",
                "Receptionniste"
            });
            this.cbxRole.Location = new System.Drawing.Point(700, 61);
            this.cbxRole.Name = "cbxRole";
            this.cbxRole.Size = new System.Drawing.Size(320, 25);
            this.cbxRole.TabIndex = 6;

            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblConfirmPassword.ForeColor =
                System.Drawing.Color.FromArgb(23, 32, 51);
            this.lblConfirmPassword.Location = new System.Drawing.Point(560, 112);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(190, 17);
            this.lblConfirmPassword.TabIndex = 7;
            this.lblConfirmPassword.Text = "Confirmer le mot de passe :";

            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtConfirmPassword.Location = new System.Drawing.Point(760, 108);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(260, 25);
            this.txtConfirmPassword.TabIndex = 9;
            this.txtConfirmPassword.Validating +=
                new System.ComponentModel.CancelEventHandler(this.txtConfirmPassword_Validating);

            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.FlatAppearance.BorderColor =
                System.Drawing.Color.FromArgb(220, 225, 230);
            this.btnCancel.FlatAppearance.MouseOverBackColor =
                System.Drawing.Color.FromArgb(243, 244, 246);
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font(
                "Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor =
                System.Drawing.Color.FromArgb(23, 32, 51);
            this.btnCancel.Location = new System.Drawing.Point(825, 630);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(145, 40);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click +=
                new System.EventHandler(this.btnCancel_Click);

            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseOverBackColor =
                System.Drawing.Color.FromArgb(29, 78, 216);
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font(
                "Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(985, 630);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(155, 40);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Enregistrer";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click +=
                new System.EventHandler(this.btnSave_Click);

            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;

            // 
            // frmAddUpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = false;
            this.AutoValidate =
                System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(243, 244, 246);

            this.ClientSize = new System.Drawing.Size(1164, 695);

            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.gbUserInfo);
            this.Controls.Add(this.gbSelectPerson);

            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddUpdateUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GymManager - Ajouter un utilisateur";

            this.Activated +=
                new System.EventHandler(this.frmAddUpdateUser_Activated);
            this.Load +=
                new System.EventHandler(this.frmAddUpdateUser_Load);

            this.gbSelectPerson.ResumeLayout(false);
            this.gbSelectPerson.PerformLayout();

            this.gbUserInfo.ResumeLayout(false);
            this.gbUserInfo.PerformLayout();

            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();

            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel gbSelectPerson;
        private System.Windows.Forms.Panel gbUserInfo;

        private System.Windows.Forms.Label lblPersonSection;
        private System.Windows.Forms.Label lblAccountSection;

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;

        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;

        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.ComboBox cbxRole;

        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;

        private System.Windows.Forms.CheckBox chkIsActive;

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;

        private System.Windows.Forms.ErrorProvider errorProvider1;

        private GymManager.Presentation.Personnes.Controls.ucPersonCardWithFilter ucPersonCardWithFilter2;
    }
}
