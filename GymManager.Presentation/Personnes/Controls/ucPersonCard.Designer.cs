namespace GymManager.Presentation.Personnes.Controls
{
    partial class ucPersonCard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.GroupBox grpPersonneInfo;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPersonIcon;
        private System.Windows.Forms.Button btnEditPerson;

        private System.Windows.Forms.PictureBox pbPersonImage;

        private System.Windows.Forms.Label lblPersonIDTitle;
        private System.Windows.Forms.Label lblPersonID;

        private System.Windows.Forms.Label lblFullNameTitle;
        private System.Windows.Forms.Label lblFullName;

        private System.Windows.Forms.Label lblPhoneTitle;
        private System.Windows.Forms.Label lblPhone;

        private System.Windows.Forms.Label lblEmailTitle;
        private System.Windows.Forms.Label lblEmail;

        private System.Windows.Forms.Label lblDateOfBirthTitle;
        private System.Windows.Forms.Label lblDateOfBirth;

        private System.Windows.Forms.Label lblGenderTitle;
        private System.Windows.Forms.Label lblGender;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">
        /// true if managed resources should be disposed; otherwise, false.
        /// </param>
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
            this.grpPersonneInfo = new System.Windows.Forms.GroupBox();
            this.lblPersonIcon = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnEditPerson = new System.Windows.Forms.Button();
            this.pbPersonImage = new System.Windows.Forms.PictureBox();
            this.lblPersonIDTitle = new System.Windows.Forms.Label();
            this.lblPersonID = new System.Windows.Forms.Label();
            this.lblFullNameTitle = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblPhoneTitle = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblEmailTitle = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblDateOfBirthTitle = new System.Windows.Forms.Label();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.lblGenderTitle = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.grpPersonneInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).BeginInit();
            this.SuspendLayout();
            // 
            // grpPersonneInfo
            // 
            this.grpPersonneInfo.Controls.Add(this.lblPersonIcon);
            this.grpPersonneInfo.Controls.Add(this.lblTitle);
            this.grpPersonneInfo.Controls.Add(this.btnEditPerson);
            this.grpPersonneInfo.Controls.Add(this.pbPersonImage);
            this.grpPersonneInfo.Controls.Add(this.lblPersonIDTitle);
            this.grpPersonneInfo.Controls.Add(this.lblPersonID);
            this.grpPersonneInfo.Controls.Add(this.lblFullNameTitle);
            this.grpPersonneInfo.Controls.Add(this.lblFullName);
            this.grpPersonneInfo.Controls.Add(this.lblPhoneTitle);
            this.grpPersonneInfo.Controls.Add(this.lblPhone);
            this.grpPersonneInfo.Controls.Add(this.lblEmailTitle);
            this.grpPersonneInfo.Controls.Add(this.lblEmail);
            this.grpPersonneInfo.Controls.Add(this.lblDateOfBirthTitle);
            this.grpPersonneInfo.Controls.Add(this.lblDateOfBirth);
            this.grpPersonneInfo.Controls.Add(this.lblGenderTitle);
            this.grpPersonneInfo.Controls.Add(this.lblGender);
            this.grpPersonneInfo.Location = new System.Drawing.Point(3, 3);
            this.grpPersonneInfo.Name = "grpPersonneInfo";
            this.grpPersonneInfo.Size = new System.Drawing.Size(1077, 196);
            this.grpPersonneInfo.TabIndex = 0;
            this.grpPersonneInfo.TabStop = false;
            // 
            // lblPersonIcon
            // 
            this.lblPersonIcon.AutoSize = true;
            this.lblPersonIcon.Font = new System.Drawing.Font("Segoe UI Symbol", 14F);
            this.lblPersonIcon.Location = new System.Drawing.Point(10, 23);
            this.lblPersonIcon.Name = "lblPersonIcon";
            this.lblPersonIcon.Size = new System.Drawing.Size(35, 32);
            this.lblPersonIcon.TabIndex = 0;
            this.lblPersonIcon.Text = "●";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(38, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(337, 28);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "INFORMATIONS DE LA PERSONNE";
            // 
            // btnEditPerson
            // 
            this.btnEditPerson.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditPerson.Enabled = false;
            this.btnEditPerson.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEditPerson.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEditPerson.Location = new System.Drawing.Point(857, 21);
            this.btnEditPerson.Name = "btnEditPerson";
            this.btnEditPerson.Size = new System.Drawing.Size(195, 32);
            this.btnEditPerson.TabIndex = 2;
            this.btnEditPerson.Text = "Modifier la personne";
            this.btnEditPerson.UseVisualStyleBackColor = true;
            this.btnEditPerson.Click += new System.EventHandler(this.btnEditPerson_Click);
            // 
            // pbPersonImage
            // 
            this.pbPersonImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPersonImage.Image = global::GymManager.Presentation.Properties.Resources.Male_512;
            this.pbPersonImage.Location = new System.Drawing.Point(17, 61);
            this.pbPersonImage.Name = "pbPersonImage";
            this.pbPersonImage.Size = new System.Drawing.Size(125, 125);
            this.pbPersonImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPersonImage.TabIndex = 3;
            this.pbPersonImage.TabStop = false;
            // 
            // lblPersonIDTitle
            // 
            this.lblPersonIDTitle.AutoSize = true;
            this.lblPersonIDTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPersonIDTitle.Location = new System.Drawing.Point(185, 65);
            this.lblPersonIDTitle.Name = "lblPersonIDTitle";
            this.lblPersonIDTitle.Size = new System.Drawing.Size(102, 23);
            this.lblPersonIDTitle.TabIndex = 4;
            this.lblPersonIDTitle.Text = "ID Personne";
            // 
            // lblPersonID
            // 
            this.lblPersonID.AutoSize = true;
            this.lblPersonID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPersonID.Location = new System.Drawing.Point(304, 65);
            this.lblPersonID.Name = "lblPersonID";
            this.lblPersonID.Size = new System.Drawing.Size(53, 23);
            this.lblPersonID.TabIndex = 5;
            this.lblPersonID.Text = "[ ??? ]";
            // 
            // lblFullNameTitle
            // 
            this.lblFullNameTitle.AutoSize = true;
            this.lblFullNameTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblFullNameTitle.Location = new System.Drawing.Point(185, 94);
            this.lblFullNameTitle.Name = "lblFullNameTitle";
            this.lblFullNameTitle.Size = new System.Drawing.Size(115, 23);
            this.lblFullNameTitle.TabIndex = 6;
            this.lblFullNameTitle.Text = "Nom complet";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblFullName.Location = new System.Drawing.Point(304, 94);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(53, 23);
            this.lblFullName.TabIndex = 7;
            this.lblFullName.Text = "[ ??? ]";
            // 
            // lblPhoneTitle
            // 
            this.lblPhoneTitle.AutoSize = true;
            this.lblPhoneTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPhoneTitle.Location = new System.Drawing.Point(185, 123);
            this.lblPhoneTitle.Name = "lblPhoneTitle";
            this.lblPhoneTitle.Size = new System.Drawing.Size(88, 23);
            this.lblPhoneTitle.TabIndex = 8;
            this.lblPhoneTitle.Text = "Téléphone";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPhone.Location = new System.Drawing.Point(304, 123);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(53, 23);
            this.lblPhone.TabIndex = 9;
            this.lblPhone.Text = "[ ??? ]";
            // 
            // lblEmailTitle
            // 
            this.lblEmailTitle.AutoSize = true;
            this.lblEmailTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblEmailTitle.Location = new System.Drawing.Point(643, 123);
            this.lblEmailTitle.Name = "lblEmailTitle";
            this.lblEmailTitle.Size = new System.Drawing.Size(58, 23);
            this.lblEmailTitle.TabIndex = 10;
            this.lblEmailTitle.Text = "E-mail";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblEmail.Location = new System.Drawing.Point(800, 123);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(53, 23);
            this.lblEmail.TabIndex = 11;
            this.lblEmail.Text = "[ ??? ]";
            // 
            // lblDateOfBirthTitle
            // 
            this.lblDateOfBirthTitle.AutoSize = true;
            this.lblDateOfBirthTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDateOfBirthTitle.Location = new System.Drawing.Point(643, 94);
            this.lblDateOfBirthTitle.Name = "lblDateOfBirthTitle";
            this.lblDateOfBirthTitle.Size = new System.Drawing.Size(148, 23);
            this.lblDateOfBirthTitle.TabIndex = 12;
            this.lblDateOfBirthTitle.Text = "Date de naissance";
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDateOfBirth.Location = new System.Drawing.Point(800, 94);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(53, 23);
            this.lblDateOfBirth.TabIndex = 13;
            this.lblDateOfBirth.Text = "[ ??? ]";
            // 
            // lblGenderTitle
            // 
            this.lblGenderTitle.AutoSize = true;
            this.lblGenderTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblGenderTitle.Location = new System.Drawing.Point(645, 65);
            this.lblGenderTitle.Name = "lblGenderTitle";
            this.lblGenderTitle.Size = new System.Drawing.Size(56, 23);
            this.lblGenderTitle.TabIndex = 14;
            this.lblGenderTitle.Text = "Genre";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblGender.Location = new System.Drawing.Point(800, 65);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(53, 23);
            this.lblGender.TabIndex = 15;
            this.lblGender.Text = "[ ??? ]";
            // 
            // ucPersonCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.grpPersonneInfo);
            this.Name = "ucPersonCard";
            this.Size = new System.Drawing.Size(1092, 223);
            this.Load += new System.EventHandler(this.ucPersonCard_Load);
            this.grpPersonneInfo.ResumeLayout(false);
            this.grpPersonneInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}