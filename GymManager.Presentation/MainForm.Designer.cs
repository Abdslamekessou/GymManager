namespace GymManager.Presentation
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.ipbCurrentUser = new FontAwesome.Sharp.IconPictureBox();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.btnUtilisateurs = new FontAwesome.Sharp.IconButton();
            this.btnDeconnexion = new FontAwesome.Sharp.IconButton();
            this.btnAbonnements = new FontAwesome.Sharp.IconButton();
            this.btnTypesAbonnements = new FontAwesome.Sharp.IconButton();
            this.btnSports = new FontAwesome.Sharp.IconButton();
            this.btnAdherents = new FontAwesome.Sharp.IconButton();
            this.btnPersonnes = new FontAwesome.Sharp.IconButton();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ipbCurrentUser)).BeginInit();
            this.pnlSidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.ipbCurrentUser);
            this.pnlHeader.Controls.Add(this.lblAdmin);
            this.pnlHeader.Controls.Add(this.label1);
            this.pnlHeader.Controls.Add(this.panel3);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1924, 100);
            this.pnlHeader.TabIndex = 0;
            // 
            // ipbCurrentUser
            // 
            this.ipbCurrentUser.BackColor = System.Drawing.Color.White;
            this.ipbCurrentUser.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ipbCurrentUser.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ipbCurrentUser.IconColor = System.Drawing.SystemColors.ControlText;
            this.ipbCurrentUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ipbCurrentUser.IconSize = 48;
            this.ipbCurrentUser.Location = new System.Drawing.Point(1677, 19);
            this.ipbCurrentUser.Name = "ipbCurrentUser";
            this.ipbCurrentUser.Size = new System.Drawing.Size(58, 48);
            this.ipbCurrentUser.TabIndex = 5;
            this.ipbCurrentUser.TabStop = false;
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.Location = new System.Drawing.Point(1728, 19);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(132, 48);
            this.lblAdmin.TabIndex = 4;
            this.lblAdmin.Text = "Admin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 48);
            this.label1.TabIndex = 3;
            this.label1.Text = "GymManager";
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(0, 96);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1622, 868);
            this.panel3.TabIndex = 2;
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.White;
            this.pnlSidebar.Controls.Add(this.btnUtilisateurs);
            this.pnlSidebar.Controls.Add(this.btnDeconnexion);
            this.pnlSidebar.Controls.Add(this.btnAbonnements);
            this.pnlSidebar.Controls.Add(this.btnTypesAbonnements);
            this.pnlSidebar.Controls.Add(this.btnSports);
            this.pnlSidebar.Controls.Add(this.btnAdherents);
            this.pnlSidebar.Controls.Add(this.btnPersonnes);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 100);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(327, 900);
            this.pnlSidebar.TabIndex = 1;
            // 
            // btnUtilisateurs
            // 
            this.btnUtilisateurs.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnUtilisateurs.IconColor = System.Drawing.Color.Black;
            this.btnUtilisateurs.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUtilisateurs.Location = new System.Drawing.Point(0, 580);
            this.btnUtilisateurs.Name = "btnUtilisateurs";
            this.btnUtilisateurs.Size = new System.Drawing.Size(327, 77);
            this.btnUtilisateurs.TabIndex = 6;
            this.btnUtilisateurs.Text = "Utilisateurs";
            this.btnUtilisateurs.UseVisualStyleBackColor = true;
            // 
            // btnDeconnexion
            // 
            this.btnDeconnexion.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnDeconnexion.IconColor = System.Drawing.Color.Black;
            this.btnDeconnexion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDeconnexion.Location = new System.Drawing.Point(0, 787);
            this.btnDeconnexion.Name = "btnDeconnexion";
            this.btnDeconnexion.Size = new System.Drawing.Size(327, 77);
            this.btnDeconnexion.TabIndex = 5;
            this.btnDeconnexion.Text = "Déconnexion";
            this.btnDeconnexion.UseVisualStyleBackColor = true;
            // 
            // btnAbonnements
            // 
            this.btnAbonnements.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAbonnements.IconColor = System.Drawing.Color.Black;
            this.btnAbonnements.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAbonnements.Location = new System.Drawing.Point(0, 465);
            this.btnAbonnements.Name = "btnAbonnements";
            this.btnAbonnements.Size = new System.Drawing.Size(327, 77);
            this.btnAbonnements.TabIndex = 4;
            this.btnAbonnements.Text = "Abonnements";
            this.btnAbonnements.UseVisualStyleBackColor = true;
            // 
            // btnTypesAbonnements
            // 
            this.btnTypesAbonnements.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnTypesAbonnements.IconColor = System.Drawing.Color.Black;
            this.btnTypesAbonnements.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTypesAbonnements.Location = new System.Drawing.Point(0, 358);
            this.btnTypesAbonnements.Name = "btnTypesAbonnements";
            this.btnTypesAbonnements.Size = new System.Drawing.Size(327, 77);
            this.btnTypesAbonnements.TabIndex = 3;
            this.btnTypesAbonnements.Text = "Types d’abonnements";
            this.btnTypesAbonnements.UseVisualStyleBackColor = true;
            // 
            // btnSports
            // 
            this.btnSports.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSports.IconColor = System.Drawing.Color.Black;
            this.btnSports.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSports.Location = new System.Drawing.Point(3, 250);
            this.btnSports.Name = "btnSports";
            this.btnSports.Size = new System.Drawing.Size(327, 77);
            this.btnSports.TabIndex = 2;
            this.btnSports.Text = "Sports";
            this.btnSports.UseVisualStyleBackColor = true;
            // 
            // btnAdherents
            // 
            this.btnAdherents.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAdherents.IconColor = System.Drawing.Color.Black;
            this.btnAdherents.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdherents.Location = new System.Drawing.Point(3, 143);
            this.btnAdherents.Name = "btnAdherents";
            this.btnAdherents.Size = new System.Drawing.Size(327, 77);
            this.btnAdherents.TabIndex = 1;
            this.btnAdherents.Text = "Adhérents";
            this.btnAdherents.UseVisualStyleBackColor = true;
            // 
            // btnPersonnes
            // 
            this.btnPersonnes.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnPersonnes.IconColor = System.Drawing.Color.Black;
            this.btnPersonnes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPersonnes.Location = new System.Drawing.Point(3, 41);
            this.btnPersonnes.Name = "btnPersonnes";
            this.btnPersonnes.Size = new System.Drawing.Size(327, 77);
            this.btnPersonnes.TabIndex = 0;
            this.btnPersonnes.Text = "Personnes";
            this.btnPersonnes.UseVisualStyleBackColor = true;
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.RosyBrown;
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(327, 100);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1597, 900);
            this.pnlContent.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1924, 1000);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlSidebar);
            this.Controls.Add(this.pnlHeader);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gym Manager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ipbCurrentUser)).EndInit();
            this.pnlSidebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAdmin;
        private FontAwesome.Sharp.IconPictureBox ipbCurrentUser;
        private FontAwesome.Sharp.IconButton btnDeconnexion;
        private FontAwesome.Sharp.IconButton btnAbonnements;
        private FontAwesome.Sharp.IconButton btnTypesAbonnements;
        private FontAwesome.Sharp.IconButton btnSports;
        private FontAwesome.Sharp.IconButton btnAdherents;
        private FontAwesome.Sharp.IconButton btnPersonnes;
        private FontAwesome.Sharp.IconButton btnUtilisateurs;
    }
}

