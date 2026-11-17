using static System.Net.Mime.MediaTypeNames;

namespace GymManager.Presentation
{
    partial class frmDeatiles
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
            this.gbPersonInfo = new System.Windows.Forms.GroupBox();
            this.lblIDPersonneVal = new System.Windows.Forms.Label();
            this.lblIDPersonneLbl = new System.Windows.Forms.Label();
            this.lblNomVal = new System.Windows.Forms.Label();
            this.lblNomLbl = new System.Windows.Forms.Label();
            this.lblEmailVal = new System.Windows.Forms.Label();
            this.lblEmailLbl = new System.Windows.Forms.Label();
            this.lblGenreVal = new System.Windows.Forms.Label();
            this.lblGenreLbl = new System.Windows.Forms.Label();
            this.lblPrenomVal = new System.Windows.Forms.Label();
            this.lblPrenomLbl = new System.Windows.Forms.Label();
            this.lblTelephoneVal = new System.Windows.Forms.Label();
            this.lblTelephoneLbl = new System.Windows.Forms.Label();
            this.lblBirthDateVal = new System.Windows.Forms.Label();
            this.lblBirthDateLbl = new System.Windows.Forms.Label();
            this.pbUserImage = new System.Windows.Forms.PictureBox();
            this.gbAccountInfo = new System.Windows.Forms.GroupBox();
            this.lblRoleVal = new System.Windows.Forms.Label();
            this.lblRoleLbl = new System.Windows.Forms.Label();
            this.lblIDUtilisateurVal = new System.Windows.Forms.Label();
            this.lblIDUtilisateurLbl = new System.Windows.Forms.Label();
            this.lblUsernameVal = new System.Windows.Forms.Label();
            this.lblUsernameLbl = new System.Windows.Forms.Label();
            this.lblStatusVal = new System.Windows.Forms.Label();
            this.lblStatusLbl = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.gbPersonInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserImage)).BeginInit();
            this.gbAccountInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPersonInfo
            // 
            this.gbPersonInfo.Controls.Add(this.lblIDPersonneVal);
            this.gbPersonInfo.Controls.Add(this.lblIDPersonneLbl);
            this.gbPersonInfo.Controls.Add(this.lblNomVal);
            this.gbPersonInfo.Controls.Add(this.lblNomLbl);
            this.gbPersonInfo.Controls.Add(this.lblEmailVal);
            this.gbPersonInfo.Controls.Add(this.lblEmailLbl);
            this.gbPersonInfo.Controls.Add(this.lblGenreVal);
            this.gbPersonInfo.Controls.Add(this.lblGenreLbl);
            this.gbPersonInfo.Controls.Add(this.lblPrenomVal);
            this.gbPersonInfo.Controls.Add(this.lblPrenomLbl);
            this.gbPersonInfo.Controls.Add(this.lblTelephoneVal);
            this.gbPersonInfo.Controls.Add(this.lblTelephoneLbl);
            this.gbPersonInfo.Controls.Add(this.lblBirthDateVal);
            this.gbPersonInfo.Controls.Add(this.lblBirthDateLbl);
            this.gbPersonInfo.Controls.Add(this.pbUserImage);
            this.gbPersonInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPersonInfo.ForeColor = System.Drawing.Color.DimGray;
            this.gbPersonInfo.Location = new System.Drawing.Point(23, 25);
            this.gbPersonInfo.Margin = new System.Windows.Forms.Padding(4);
            this.gbPersonInfo.Name = "gbPersonInfo";
            this.gbPersonInfo.Padding = new System.Windows.Forms.Padding(4);
            this.gbPersonInfo.Size = new System.Drawing.Size(852, 283);
            this.gbPersonInfo.TabIndex = 0;
            this.gbPersonInfo.TabStop = false;
            this.gbPersonInfo.Text = "« 👤 INFORMATIONS DE LA PERSONNE »";
            // 
            // lblIDPersonneVal
            // 
            this.lblIDPersonneVal.AutoSize = true;
            this.lblIDPersonneVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDPersonneVal.ForeColor = System.Drawing.Color.Black;
            this.lblIDPersonneVal.Location = new System.Drawing.Point(163, 49);
            this.lblIDPersonneVal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIDPersonneVal.Name = "lblIDPersonneVal";
            this.lblIDPersonneVal.Size = new System.Drawing.Size(59, 20);
            this.lblIDPersonneVal.TabIndex = 14;
            this.lblIDPersonneVal.Text = "[????]";
            // 
            // lblIDPersonneLbl
            // 
            this.lblIDPersonneLbl.AutoSize = true;
            this.lblIDPersonneLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDPersonneLbl.ForeColor = System.Drawing.Color.Black;
            this.lblIDPersonneLbl.Location = new System.Drawing.Point(23, 49);
            this.lblIDPersonneLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIDPersonneLbl.Name = "lblIDPersonneLbl";
            this.lblIDPersonneLbl.Size = new System.Drawing.Size(106, 20);
            this.lblIDPersonneLbl.TabIndex = 13;
            this.lblIDPersonneLbl.Text = "ID Personne :";
            // 
            // lblNomVal
            // 
            this.lblNomVal.AutoSize = true;
            this.lblNomVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomVal.ForeColor = System.Drawing.Color.Black;
            this.lblNomVal.Location = new System.Drawing.Point(163, 92);
            this.lblNomVal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomVal.Name = "lblNomVal";
            this.lblNomVal.Size = new System.Drawing.Size(59, 20);
            this.lblNomVal.TabIndex = 12;
            this.lblNomVal.Text = "[????]";
            // 
            // lblNomLbl
            // 
            this.lblNomLbl.AutoSize = true;
            this.lblNomLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomLbl.ForeColor = System.Drawing.Color.Black;
            this.lblNomLbl.Location = new System.Drawing.Point(23, 92);
            this.lblNomLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomLbl.Name = "lblNomLbl";
            this.lblNomLbl.Size = new System.Drawing.Size(50, 20);
            this.lblNomLbl.TabIndex = 11;
            this.lblNomLbl.Text = "Nom :";
            // 
            // lblEmailVal
            // 
            this.lblEmailVal.AutoSize = true;
            this.lblEmailVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailVal.ForeColor = System.Drawing.Color.Black;
            this.lblEmailVal.Location = new System.Drawing.Point(163, 135);
            this.lblEmailVal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmailVal.Name = "lblEmailVal";
            this.lblEmailVal.Size = new System.Drawing.Size(59, 20);
            this.lblEmailVal.TabIndex = 10;
            this.lblEmailVal.Text = "[????]";
            // 
            // lblEmailLbl
            // 
            this.lblEmailLbl.AutoSize = true;
            this.lblEmailLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailLbl.ForeColor = System.Drawing.Color.Black;
            this.lblEmailLbl.Location = new System.Drawing.Point(23, 135);
            this.lblEmailLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmailLbl.Name = "lblEmailLbl";
            this.lblEmailLbl.Size = new System.Drawing.Size(61, 20);
            this.lblEmailLbl.TabIndex = 9;
            this.lblEmailLbl.Text = "E-mail :";
            // 
            // lblGenreVal
            // 
            this.lblGenreVal.AutoSize = true;
            this.lblGenreVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenreVal.ForeColor = System.Drawing.Color.Black;
            this.lblGenreVal.Location = new System.Drawing.Point(163, 178);
            this.lblGenreVal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGenreVal.Name = "lblGenreVal";
            this.lblGenreVal.Size = new System.Drawing.Size(59, 20);
            this.lblGenreVal.TabIndex = 8;
            this.lblGenreVal.Text = "[????]";
            // 
            // lblGenreLbl
            // 
            this.lblGenreLbl.AutoSize = true;
            this.lblGenreLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenreLbl.ForeColor = System.Drawing.Color.Black;
            this.lblGenreLbl.Location = new System.Drawing.Point(23, 178);
            this.lblGenreLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGenreLbl.Name = "lblGenreLbl";
            this.lblGenreLbl.Size = new System.Drawing.Size(62, 20);
            this.lblGenreLbl.TabIndex = 7;
            this.lblGenreLbl.Text = "Genre :";
            // 
            // lblPrenomVal
            // 
            this.lblPrenomVal.AutoSize = true;
            this.lblPrenomVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrenomVal.ForeColor = System.Drawing.Color.Black;
            this.lblPrenomVal.Location = new System.Drawing.Point(537, 49);
            this.lblPrenomVal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrenomVal.Name = "lblPrenomVal";
            this.lblPrenomVal.Size = new System.Drawing.Size(59, 20);
            this.lblPrenomVal.TabIndex = 6;
            this.lblPrenomVal.Text = "[????]";            // 
            // lblPrenomLbl
            // 
            this.lblPrenomLbl.AutoSize = true;
            this.lblPrenomLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrenomLbl.ForeColor = System.Drawing.Color.Black;
            this.lblPrenomLbl.Location = new System.Drawing.Point(397, 49);
            this.lblPrenomLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrenomLbl.Name = "lblPrenomLbl";
            this.lblPrenomLbl.Size = new System.Drawing.Size(72, 20);
            this.lblPrenomLbl.TabIndex = 5;
            this.lblPrenomLbl.Text = "Prénom :";
            // 
            // lblTelephoneVal
            // 
            this.lblTelephoneVal.AutoSize = true;
            this.lblTelephoneVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelephoneVal.ForeColor = System.Drawing.Color.Black;
            this.lblTelephoneVal.Location = new System.Drawing.Point(537, 92);
            this.lblTelephoneVal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelephoneVal.Name = "lblTelephoneVal";
            this.lblTelephoneVal.Size = new System.Drawing.Size(59, 20);
            this.lblTelephoneVal.TabIndex = 4;
            this.lblTelephoneVal.Text = "[????]";
            // 
            // lblTelephoneLbl
            // 
            this.lblTelephoneLbl.AutoSize = true;
            this.lblTelephoneLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelephoneLbl.ForeColor = System.Drawing.Color.Black;
            this.lblTelephoneLbl.Location = new System.Drawing.Point(397, 92);
            this.lblTelephoneLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelephoneLbl.Name = "lblTelephoneLbl";
            this.lblTelephoneLbl.Size = new System.Drawing.Size(92, 20);
            this.lblTelephoneLbl.TabIndex = 3;
            this.lblTelephoneLbl.Text = "Téléphone :";
            // 
            // lblBirthDateVal
            // 
            this.lblBirthDateVal.AutoSize = true;
            this.lblBirthDateVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthDateVal.ForeColor = System.Drawing.Color.Black;
            this.lblBirthDateVal.Location = new System.Drawing.Point(537, 135);
            this.lblBirthDateVal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBirthDateVal.Name = "lblBirthDateVal";
            this.lblBirthDateVal.Size = new System.Drawing.Size(59, 20);
            this.lblBirthDateVal.TabIndex = 2;
            this.lblBirthDateVal.Text = "[????]";
            // 
            // lblBirthDateLbl
            // 
            this.lblBirthDateLbl.AutoSize = true;
            this.lblBirthDateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthDateLbl.ForeColor = System.Drawing.Color.Black;
            this.lblBirthDateLbl.Location = new System.Drawing.Point(397, 135);
            this.lblBirthDateLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBirthDateLbl.Name = "lblBirthDateLbl";
            this.lblBirthDateLbl.Size = new System.Drawing.Size(150, 20);
            this.lblBirthDateLbl.TabIndex = 1;
            this.lblBirthDateLbl.Text = "Date de naissance :";
            // 
            // pbUserImage
            // 
            this.pbUserImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbUserImage.Image = global::GymManager.Presentation.Properties.Resources.Male_512;
            this.pbUserImage.Location = new System.Drawing.Point(700, 37);
            this.pbUserImage.Margin = new System.Windows.Forms.Padding(4);
            this.pbUserImage.Name = "pbUserImage";
            this.pbUserImage.Size = new System.Drawing.Size(128, 147);
            this.pbUserImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUserImage.TabIndex = 0;
            this.pbUserImage.TabStop = false;
            // 
            // gbAccountInfo
            // 
            this.gbAccountInfo.Controls.Add(this.lblRoleVal);
            this.gbAccountInfo.Controls.Add(this.lblRoleLbl);
            this.gbAccountInfo.Controls.Add(this.lblIDUtilisateurVal);
            this.gbAccountInfo.Controls.Add(this.lblIDUtilisateurLbl);
            this.gbAccountInfo.Controls.Add(this.lblUsernameVal);
            this.gbAccountInfo.Controls.Add(this.lblUsernameLbl);
            this.gbAccountInfo.Controls.Add(this.lblStatusVal);
            this.gbAccountInfo.Controls.Add(this.lblStatusLbl);
            this.gbAccountInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAccountInfo.ForeColor = System.Drawing.Color.DimGray;
            this.gbAccountInfo.Location = new System.Drawing.Point(23, 332);
            this.gbAccountInfo.Margin = new System.Windows.Forms.Padding(4);
            this.gbAccountInfo.Name = "gbAccountInfo";
            this.gbAccountInfo.Padding = new System.Windows.Forms.Padding(4);
            this.gbAccountInfo.Size = new System.Drawing.Size(852, 160);
            this.gbAccountInfo.TabIndex = 1;
            this.gbAccountInfo.TabStop = false;
            this.gbAccountInfo.Text = "« 🔒 INFORMATIONS DU COMPTE UTILISATEUR »";
            // 
            // lblRoleVal
            // 
            this.lblRoleVal.AutoSize = true;
            this.lblRoleVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoleVal.ForeColor = System.Drawing.Color.Black;
            this.lblRoleVal.Location = new System.Drawing.Point(537, 49);
            this.lblRoleVal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRoleVal.Name = "lblRoleVal";
            this.lblRoleVal.Size = new System.Drawing.Size(59, 20);
            this.lblRoleVal.TabIndex = 7;
            this.lblRoleVal.Text = "[????]";
            // 
            // lblRoleLbl
            // 
            this.lblRoleLbl.AutoSize = true;
            this.lblRoleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoleLbl.ForeColor = System.Drawing.Color.Black;
            this.lblRoleLbl.Location = new System.Drawing.Point(397, 49);
            this.lblRoleLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRoleLbl.Name = "lblRoleLbl";
            this.lblRoleLbl.Size = new System.Drawing.Size(50, 20);
            this.lblRoleLbl.TabIndex = 6;
            this.lblRoleLbl.Text = "Rôle :";
            // 
            // lblIDUtilisateurVal
            // 
            this.lblIDUtilisateurVal.AutoSize = true;
            this.lblIDUtilisateurVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDUtilisateurVal.ForeColor = System.Drawing.Color.Black;
            this.lblIDUtilisateurVal.Location = new System.Drawing.Point(163, 49);
            this.lblIDUtilisateurVal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIDUtilisateurVal.Name = "lblIDUtilisateurVal";
            this.lblIDUtilisateurVal.Size = new System.Drawing.Size(59, 20);
            this.lblIDUtilisateurVal.TabIndex = 5;
            this.lblIDUtilisateurVal.Text = "[????]";
            // 
            // lblIDUtilisateurLbl
            // 
            this.lblIDUtilisateurLbl.AutoSize = true;
            this.lblIDUtilisateurLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDUtilisateurLbl.ForeColor = System.Drawing.Color.Black;
            this.lblIDUtilisateurLbl.Location = new System.Drawing.Point(23, 49);
            this.lblIDUtilisateurLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIDUtilisateurLbl.Name = "lblIDUtilisateurLbl";
            this.lblIDUtilisateurLbl.Size = new System.Drawing.Size(109, 20);
            this.lblIDUtilisateurLbl.TabIndex = 4;
            this.lblIDUtilisateurLbl.Text = "ID Utilisateur :";
            // 
            // lblUsernameVal
            // 
            this.lblUsernameVal.AutoSize = true;
            this.lblUsernameVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsernameVal.ForeColor = System.Drawing.Color.Black;
            this.lblUsernameVal.Location = new System.Drawing.Point(163, 98);
            this.lblUsernameVal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsernameVal.Name = "lblUsernameVal";
            this.lblUsernameVal.Size = new System.Drawing.Size(59, 20);
            this.lblUsernameVal.TabIndex = 3;
            this.lblUsernameVal.Text = "[????]";
            // 
            // lblUsernameLbl
            // 
            this.lblUsernameLbl.AutoSize = true;
            this.lblUsernameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsernameLbl.ForeColor = System.Drawing.Color.Black;
            this.lblUsernameLbl.Location = new System.Drawing.Point(23, 98);
            this.lblUsernameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsernameLbl.Name = "lblUsernameLbl";
            this.lblUsernameLbl.Size = new System.Drawing.Size(134, 20);
            this.lblUsernameLbl.TabIndex = 2;
            this.lblUsernameLbl.Text = "Nom d\'utilisateur :";
            // 
            // lblStatusVal
            // 
            this.lblStatusVal.AutoSize = true;
            this.lblStatusVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusVal.ForeColor = System.Drawing.Color.Black;
            this.lblStatusVal.Location = new System.Drawing.Point(537, 98);
            this.lblStatusVal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatusVal.Name = "lblStatusVal";
            this.lblStatusVal.Size = new System.Drawing.Size(59, 20);
            this.lblStatusVal.TabIndex = 1;
            this.lblStatusVal.Text = "[????]";
            // 
            // lblStatusLbl
            // 
            this.lblStatusLbl.AutoSize = true;
            this.lblStatusLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusLbl.ForeColor = System.Drawing.Color.Black;
            this.lblStatusLbl.Location = new System.Drawing.Point(397, 98);
            this.lblStatusLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatusLbl.Name = "lblStatusLbl";
            this.lblStatusLbl.Size = new System.Drawing.Size(61, 20);
            this.lblStatusLbl.TabIndex = 0;
            this.lblStatusLbl.Text = "Statut :";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(723, 517);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(152, 39);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "[ Fermer ]";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmDeatiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 578);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gbAccountInfo);
            this.Controls.Add(this.gbPersonInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmDeatiles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Détails de l\'utilisateur";
            this.Load += new System.EventHandler(this.frmDeatiles_Load);
            this.gbPersonInfo.ResumeLayout(false);
            this.gbPersonInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserImage)).EndInit();
            this.gbAccountInfo.ResumeLayout(false);
            this.gbAccountInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPersonInfo;
        private System.Windows.Forms.Label lblIDPersonneVal;
        private System.Windows.Forms.Label lblIDPersonneLbl;
        private System.Windows.Forms.Label lblNomVal;
        private System.Windows.Forms.Label lblNomLbl;
        private System.Windows.Forms.Label lblEmailVal;
        private System.Windows.Forms.Label lblEmailLbl;
        private System.Windows.Forms.Label lblGenreVal;
        private System.Windows.Forms.Label lblGenreLbl;
        private System.Windows.Forms.Label lblPrenomVal;
        private System.Windows.Forms.Label lblPrenomLbl;
        private System.Windows.Forms.Label lblTelephoneVal;
        private System.Windows.Forms.Label lblTelephoneLbl;
        private System.Windows.Forms.Label lblBirthDateVal;
        private System.Windows.Forms.Label lblBirthDateLbl;
        private System.Windows.Forms.PictureBox pbUserImage;
        private System.Windows.Forms.GroupBox gbAccountInfo;
        private System.Windows.Forms.Label lblRoleVal;
        private System.Windows.Forms.Label lblRoleLbl;
        private System.Windows.Forms.Label lblIDUtilisateurVal;
        private System.Windows.Forms.Label lblIDUtilisateurLbl;
        private System.Windows.Forms.Label lblUsernameVal;
        private System.Windows.Forms.Label lblUsernameLbl;
        private System.Windows.Forms.Label lblStatusVal;
        private System.Windows.Forms.Label lblStatusLbl;
        private System.Windows.Forms.Button btnClose;
    }
}