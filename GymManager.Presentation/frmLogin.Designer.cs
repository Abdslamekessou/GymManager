
namespace GymManager.Presentation
{
    partial class frmLogin
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
            this.splitContainerLogin = new System.Windows.Forms.SplitContainer();
            this.pnlImage = new System.Windows.Forms.Panel();
            this.pbLoginImage = new System.Windows.Forms.PictureBox();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblImageSubtitle = new System.Windows.Forms.Label();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerLogin)).BeginInit();
            this.splitContainerLogin.Panel1.SuspendLayout();
            this.splitContainerLogin.Panel2.SuspendLayout();
            this.splitContainerLogin.SuspendLayout();
            this.pnlImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoginImage)).BeginInit();
            this.pnlLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerLogin
            // 
            this.splitContainerLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerLogin.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerLogin.Location = new System.Drawing.Point(0, 0);
            this.splitContainerLogin.Name = "splitContainerLogin";
            // 
            // splitContainerLogin.Panel1
            // 
            this.splitContainerLogin.Panel1.Controls.Add(this.pnlImage);
            this.splitContainerLogin.Panel1MinSize = 300;
            // 
            // splitContainerLogin.Panel2
            // 
            this.splitContainerLogin.Panel2.Controls.Add(this.pnlLogin);
            this.splitContainerLogin.Panel2MinSize = 450;
            this.splitContainerLogin.Size = new System.Drawing.Size(1008, 571);
            this.splitContainerLogin.SplitterDistance = 440;
            this.splitContainerLogin.SplitterWidth = 5;
            this.splitContainerLogin.TabIndex = 0;
            // 
            // pnlImage
            // 
            this.pnlImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(26)))), ((int)(((byte)(45)))));
            this.pnlImage.Controls.Add(this.pbLoginImage);
            this.pnlImage.Controls.Add(this.lblBrand);
            this.pnlImage.Controls.Add(this.lblImageSubtitle);
            this.pnlImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlImage.Location = new System.Drawing.Point(0, 0);
            this.pnlImage.Name = "pnlImage";
            this.pnlImage.Size = new System.Drawing.Size(440, 571);
            this.pnlImage.TabIndex = 0;
            // 
            // pbLoginImage
            // 
            this.pbLoginImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(26)))), ((int)(((byte)(45)))));
            this.pbLoginImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbLoginImage.Image = global::GymManager.Presentation.Properties.Resources.GymManager_450x600;
            this.pbLoginImage.Location = new System.Drawing.Point(0, 0);
            this.pbLoginImage.Name = "pbLoginImage";
            this.pbLoginImage.Size = new System.Drawing.Size(440, 571);
            this.pbLoginImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLoginImage.TabIndex = 0;
            this.pbLoginImage.TabStop = false;
            // 
            // lblBrand
            // 
            this.lblBrand.BackColor = System.Drawing.Color.Transparent;
            this.lblBrand.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold);
            this.lblBrand.ForeColor = System.Drawing.Color.White;
            this.lblBrand.Location = new System.Drawing.Point(35, 425);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(370, 55);
            this.lblBrand.TabIndex = 1;
            this.lblBrand.Text = "GymManager";
            // 
            // lblImageSubtitle
            // 
            this.lblImageSubtitle.BackColor = System.Drawing.Color.Transparent;
            this.lblImageSubtitle.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblImageSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(235)))), ((int)(((byte)(242)))));
            this.lblImageSubtitle.Location = new System.Drawing.Point(40, 488);
            this.lblImageSubtitle.Name = "lblImageSubtitle";
            this.lblImageSubtitle.Size = new System.Drawing.Size(350, 65);
            this.lblImageSubtitle.TabIndex = 2;
            this.lblImageSubtitle.Text = "Manage your gym.\r\nBuild a stronger, better organized community.";
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.Color.White;
            this.pnlLogin.Controls.Add(this.lblTitle);
            this.pnlLogin.Controls.Add(this.lblSubTitle);
            this.pnlLogin.Controls.Add(this.lblUsername);
            this.pnlLogin.Controls.Add(this.txtUsername);
            this.pnlLogin.Controls.Add(this.lblPassword);
            this.pnlLogin.Controls.Add(this.txtPassword);
            this.pnlLogin.Controls.Add(this.btnLogin);
            this.pnlLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLogin.Location = new System.Drawing.Point(0, 0);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(563, 571);
            this.pnlLogin.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 23F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(26)))), ((int)(((byte)(45)))));
            this.lblTitle.Location = new System.Drawing.Point(65, 115);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(430, 50);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Bienvenue";
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblSubTitle.Location = new System.Drawing.Point(69, 171);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(430, 35);
            this.lblSubTitle.TabIndex = 1;
            this.lblSubTitle.Text = "Connectez-vous à votre compte utilisateur";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.lblUsername.Location = new System.Drawing.Point(70, 242);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(168, 25);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Nom d\'utilisateur";
            // 
            // txtUsername
            // 
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtUsername.Location = new System.Drawing.Point(70, 270);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(430, 37);
            this.txtUsername.TabIndex = 0;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.lblPassword.Location = new System.Drawing.Point(70, 326);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(129, 25);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Mot de passe";
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtPassword.Location = new System.Drawing.Point(70, 354);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(430, 37);
            this.txtPassword.TabIndex = 1;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(78)))), ((int)(((byte)(216)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(70, 425);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(430, 48);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Se connecter";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 571);
            this.Controls.Add(this.splitContainerLogin);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GymManager - Connexion";
            this.splitContainerLogin.Panel1.ResumeLayout(false);
            this.splitContainerLogin.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerLogin)).EndInit();
            this.splitContainerLogin.ResumeLayout(false);
            this.pnlImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLoginImage)).EndInit();
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerLogin;

        private System.Windows.Forms.Panel pnlImage;
        private System.Windows.Forms.PictureBox pbLoginImage;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblImageSubtitle;

        private System.Windows.Forms.Panel pnlLogin;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubTitle;

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;

        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;

        private System.Windows.Forms.Button btnLogin;
    }
}
