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
            this.lblCurrentUser = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.pnlUtilisateurIndicator = new System.Windows.Forms.Panel();
            this.pnlAbonnementsIndicator = new System.Windows.Forms.Panel();
            this.pnlTypesAbonnementIndicator = new System.Windows.Forms.Panel();
            this.pnlSportsIndicator = new System.Windows.Forms.Panel();
            this.pnlAdherentsIndicator = new System.Windows.Forms.Panel();
            this.pnlPersonnesIndicator = new System.Windows.Forms.Panel();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.btnUtilisateurs = new FontAwesome.Sharp.IconButton();
            this.btnDeconnexion = new FontAwesome.Sharp.IconButton();
            this.btnAbonnements = new FontAwesome.Sharp.IconButton();
            this.btnTypesAbonnements = new FontAwesome.Sharp.IconButton();
            this.btnSports = new FontAwesome.Sharp.IconButton();
            this.btnAdherents = new FontAwesome.Sharp.IconButton();
            this.btnPersonnes = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ipbCurrentUser = new FontAwesome.Sharp.IconPictureBox();
            this.pnlHeader.SuspendLayout();
            this.pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipbCurrentUser)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.pictureBox1);
            this.pnlHeader.Controls.Add(this.ipbCurrentUser);
            this.pnlHeader.Controls.Add(this.lblCurrentUser);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.panel3);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1924, 79);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblCurrentUser
            // 
            this.lblCurrentUser.AutoSize = true;
            this.lblCurrentUser.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentUser.Location = new System.Drawing.Point(1753, 19);
            this.lblCurrentUser.Name = "lblCurrentUser";
            this.lblCurrentUser.Size = new System.Drawing.Size(105, 38);
            this.lblCurrentUser.TabIndex = 4;
            this.lblCurrentUser.Text = "Admin";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(90, 19);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(223, 45);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "GymManager";
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
            this.pnlSidebar.Controls.Add(this.pnlUtilisateurIndicator);
            this.pnlSidebar.Controls.Add(this.pnlAbonnementsIndicator);
            this.pnlSidebar.Controls.Add(this.pnlTypesAbonnementIndicator);
            this.pnlSidebar.Controls.Add(this.pnlSportsIndicator);
            this.pnlSidebar.Controls.Add(this.pnlAdherentsIndicator);
            this.pnlSidebar.Controls.Add(this.pnlPersonnesIndicator);
            this.pnlSidebar.Controls.Add(this.btnUtilisateurs);
            this.pnlSidebar.Controls.Add(this.btnDeconnexion);
            this.pnlSidebar.Controls.Add(this.btnAbonnements);
            this.pnlSidebar.Controls.Add(this.btnTypesAbonnements);
            this.pnlSidebar.Controls.Add(this.btnSports);
            this.pnlSidebar.Controls.Add(this.btnAdherents);
            this.pnlSidebar.Controls.Add(this.btnPersonnes);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 79);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(337, 921);
            this.pnlSidebar.TabIndex = 1;
            // 
            // pnlUtilisateurIndicator
            // 
            this.pnlUtilisateurIndicator.Location = new System.Drawing.Point(0, 575);
            this.pnlUtilisateurIndicator.Name = "pnlUtilisateurIndicator";
            this.pnlUtilisateurIndicator.Size = new System.Drawing.Size(10, 77);
            this.pnlUtilisateurIndicator.TabIndex = 12;
            this.pnlUtilisateurIndicator.Visible = false;
            // 
            // pnlAbonnementsIndicator
            // 
            this.pnlAbonnementsIndicator.Location = new System.Drawing.Point(0, 468);
            this.pnlAbonnementsIndicator.Name = "pnlAbonnementsIndicator";
            this.pnlAbonnementsIndicator.Size = new System.Drawing.Size(10, 77);
            this.pnlAbonnementsIndicator.TabIndex = 11;
            this.pnlAbonnementsIndicator.Visible = false;
            // 
            // pnlTypesAbonnementIndicator
            // 
            this.pnlTypesAbonnementIndicator.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlTypesAbonnementIndicator.Location = new System.Drawing.Point(0, 358);
            this.pnlTypesAbonnementIndicator.Name = "pnlTypesAbonnementIndicator";
            this.pnlTypesAbonnementIndicator.Size = new System.Drawing.Size(10, 77);
            this.pnlTypesAbonnementIndicator.TabIndex = 10;
            this.pnlTypesAbonnementIndicator.Visible = false;
            // 
            // pnlSportsIndicator
            // 
            this.pnlSportsIndicator.BackColor = System.Drawing.Color.MediumBlue;
            this.pnlSportsIndicator.Location = new System.Drawing.Point(0, 250);
            this.pnlSportsIndicator.Name = "pnlSportsIndicator";
            this.pnlSportsIndicator.Size = new System.Drawing.Size(10, 77);
            this.pnlSportsIndicator.TabIndex = 9;
            this.pnlSportsIndicator.Visible = false;
            // 
            // pnlAdherentsIndicator
            // 
            this.pnlAdherentsIndicator.BackColor = System.Drawing.Color.RoyalBlue;
            this.pnlAdherentsIndicator.ForeColor = System.Drawing.SystemColors.Highlight;
            this.pnlAdherentsIndicator.Location = new System.Drawing.Point(0, 145);
            this.pnlAdherentsIndicator.Name = "pnlAdherentsIndicator";
            this.pnlAdherentsIndicator.Size = new System.Drawing.Size(10, 77);
            this.pnlAdherentsIndicator.TabIndex = 8;
            this.pnlAdherentsIndicator.Visible = false;
            // 
            // pnlPersonnesIndicator
            // 
            this.pnlPersonnesIndicator.BackColor = System.Drawing.Color.MediumBlue;
            this.pnlPersonnesIndicator.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.pnlPersonnesIndicator.Location = new System.Drawing.Point(0, 41);
            this.pnlPersonnesIndicator.Name = "pnlPersonnesIndicator";
            this.pnlPersonnesIndicator.Size = new System.Drawing.Size(10, 77);
            this.pnlPersonnesIndicator.TabIndex = 7;
            this.pnlPersonnesIndicator.Visible = false;
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.White;
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(337, 79);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1587, 921);
            this.pnlContent.TabIndex = 2;
            // 
            // btnUtilisateurs
            // 
            this.btnUtilisateurs.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnUtilisateurs.IconColor = System.Drawing.Color.Black;
            this.btnUtilisateurs.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUtilisateurs.Location = new System.Drawing.Point(0, 575);
            this.btnUtilisateurs.Name = "btnUtilisateurs";
            this.btnUtilisateurs.Size = new System.Drawing.Size(337, 77);
            this.btnUtilisateurs.TabIndex = 6;
            this.btnUtilisateurs.Text = "Utilisateurs";
            this.btnUtilisateurs.UseVisualStyleBackColor = true;
            this.btnUtilisateurs.Click += new System.EventHandler(this.btnUtilisateurs_Click);
            // 
            // btnDeconnexion
            // 
            this.btnDeconnexion.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnDeconnexion.IconColor = System.Drawing.Color.Black;
            this.btnDeconnexion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDeconnexion.Location = new System.Drawing.Point(0, 787);
            this.btnDeconnexion.Name = "btnDeconnexion";
            this.btnDeconnexion.Size = new System.Drawing.Size(337, 77);
            this.btnDeconnexion.TabIndex = 5;
            this.btnDeconnexion.Text = "Déconnexion";
            this.btnDeconnexion.UseVisualStyleBackColor = true;
            // 
            // btnAbonnements
            // 
            this.btnAbonnements.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAbonnements.IconColor = System.Drawing.Color.Black;
            this.btnAbonnements.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAbonnements.Location = new System.Drawing.Point(0, 468);
            this.btnAbonnements.Name = "btnAbonnements";
            this.btnAbonnements.Size = new System.Drawing.Size(337, 77);
            this.btnAbonnements.TabIndex = 4;
            this.btnAbonnements.Text = "Abonnements";
            this.btnAbonnements.UseVisualStyleBackColor = true;
            this.btnAbonnements.Click += new System.EventHandler(this.btnAbonnements_Click);
            // 
            // btnTypesAbonnements
            // 
            this.btnTypesAbonnements.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnTypesAbonnements.IconColor = System.Drawing.Color.Black;
            this.btnTypesAbonnements.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTypesAbonnements.Location = new System.Drawing.Point(0, 358);
            this.btnTypesAbonnements.Name = "btnTypesAbonnements";
            this.btnTypesAbonnements.Size = new System.Drawing.Size(337, 77);
            this.btnTypesAbonnements.TabIndex = 3;
            this.btnTypesAbonnements.Text = "Types d’abonnements";
            this.btnTypesAbonnements.UseVisualStyleBackColor = true;
            this.btnTypesAbonnements.Click += new System.EventHandler(this.btnTypesAbonnements_Click);
            // 
            // btnSports
            // 
            this.btnSports.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSports.IconColor = System.Drawing.Color.Black;
            this.btnSports.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSports.Location = new System.Drawing.Point(-3, 250);
            this.btnSports.Name = "btnSports";
            this.btnSports.Size = new System.Drawing.Size(340, 77);
            this.btnSports.TabIndex = 2;
            this.btnSports.Text = "Sports";
            this.btnSports.UseVisualStyleBackColor = true;
            this.btnSports.Click += new System.EventHandler(this.btnSports_Click);
            // 
            // btnAdherents
            // 
            this.btnAdherents.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAdherents.IconColor = System.Drawing.Color.Black;
            this.btnAdherents.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdherents.Location = new System.Drawing.Point(0, 145);
            this.btnAdherents.Name = "btnAdherents";
            this.btnAdherents.Size = new System.Drawing.Size(337, 77);
            this.btnAdherents.TabIndex = 1;
            this.btnAdherents.Text = "Adhérents";
            this.btnAdherents.UseVisualStyleBackColor = true;
            this.btnAdherents.Click += new System.EventHandler(this.btnAdherents_Click);
            // 
            // btnPersonnes
            // 
            this.btnPersonnes.BackColor = System.Drawing.Color.Transparent;
            this.btnPersonnes.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnPersonnes.IconColor = System.Drawing.Color.Black;
            this.btnPersonnes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPersonnes.Location = new System.Drawing.Point(0, 41);
            this.btnPersonnes.Name = "btnPersonnes";
            this.btnPersonnes.Size = new System.Drawing.Size(337, 77);
            this.btnPersonnes.TabIndex = 0;
            this.btnPersonnes.Text = "Personnes";
            this.btnPersonnes.UseVisualStyleBackColor = false;
            this.btnPersonnes.Click += new System.EventHandler(this.btnPersonnes_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GymManager.Presentation.Properties.Resources.GymManagerLogo512WithBlueBgColor;
            this.pictureBox1.Location = new System.Drawing.Point(14, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // ipbCurrentUser
            // 
            this.ipbCurrentUser.BackColor = System.Drawing.Color.White;
            this.ipbCurrentUser.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ipbCurrentUser.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ipbCurrentUser.IconColor = System.Drawing.SystemColors.ControlText;
            this.ipbCurrentUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ipbCurrentUser.IconSize = 33;
            this.ipbCurrentUser.Location = new System.Drawing.Point(1708, 19);
            this.ipbCurrentUser.Name = "ipbCurrentUser";
            this.ipbCurrentUser.Size = new System.Drawing.Size(39, 33);
            this.ipbCurrentUser.TabIndex = 5;
            this.ipbCurrentUser.TabStop = false;
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
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipbCurrentUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCurrentUser;
        private FontAwesome.Sharp.IconPictureBox ipbCurrentUser;
        private FontAwesome.Sharp.IconButton btnDeconnexion;
        private FontAwesome.Sharp.IconButton btnAbonnements;
        private FontAwesome.Sharp.IconButton btnTypesAbonnements;
        private FontAwesome.Sharp.IconButton btnSports;
        private FontAwesome.Sharp.IconButton btnAdherents;
        private FontAwesome.Sharp.IconButton btnPersonnes;
        private FontAwesome.Sharp.IconButton btnUtilisateurs;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlPersonnesIndicator;
        private System.Windows.Forms.Panel pnlUtilisateurIndicator;
        private System.Windows.Forms.Panel pnlAbonnementsIndicator;
        private System.Windows.Forms.Panel pnlTypesAbonnementIndicator;
        private System.Windows.Forms.Panel pnlSportsIndicator;
        private System.Windows.Forms.Panel pnlAdherentsIndicator;
    }
}

