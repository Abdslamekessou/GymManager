
namespace GymManager.Presentation.Personnes.Controls
{
    partial class ucPersonCard
    {
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

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        #region Component Designer generated code

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
            this.grpPersonneInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
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
            this.grpPersonneInfo.Location = new System.Drawing.Point(3, 2);
            this.grpPersonneInfo.Margin = new System.Windows.Forms.Padding(0);
            this.grpPersonneInfo.Name = "grpPersonneInfo";
            this.grpPersonneInfo.Padding = new System.Windows.Forms.Padding(0);
            this.grpPersonneInfo.Size = new System.Drawing.Size(1560, 371);
            this.grpPersonneInfo.TabIndex = 0;
            this.grpPersonneInfo.TabStop = false;
            this.grpPersonneInfo.Enter += new System.EventHandler(this.grpPersonneInfo_Enter);
            // 
            // lblPersonIcon
            // 
            this.lblPersonIcon.AutoSize = true;
            this.lblPersonIcon.Font = new System.Drawing.Font("Segoe UI Symbol", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.lblPersonIcon.Location = new System.Drawing.Point(14, 17);
            this.lblPersonIcon.Name = "lblPersonIcon";
            this.lblPersonIcon.Size = new System.Drawing.Size(49, 45);
            this.lblPersonIcon.TabIndex = 0;
            this.lblPersonIcon.Text = "●";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(26)))), ((int)(((byte)(45)))));
            this.lblTitle.Location = new System.Drawing.Point(49, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(300, 38);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "  LES INFORMATIONS";
            // 
            // btnEditPerson
            // 
            this.btnEditPerson.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditPerson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnEditPerson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditPerson.Enabled = false;
            this.btnEditPerson.FlatAppearance.BorderSize = 0;
            this.btnEditPerson.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(78)))), ((int)(((byte)(216)))));
            this.btnEditPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditPerson.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnEditPerson.ForeColor = System.Drawing.Color.White;
            this.btnEditPerson.Location = new System.Drawing.Point(1366, 17);
            this.btnEditPerson.Name = "btnEditPerson";
            this.btnEditPerson.Padding = new System.Windows.Forms.Padding(2);
            this.btnEditPerson.Size = new System.Drawing.Size(171, 59);
            this.btnEditPerson.TabIndex = 2;
            this.btnEditPerson.Text = "Modifier";
            this.btnEditPerson.UseVisualStyleBackColor = false;
            this.btnEditPerson.Click += new System.EventHandler(this.btnEditPerson_Click);
            // 
            // pbPersonImage
            // 
            this.pbPersonImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.pbPersonImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPersonImage.Image = global::GymManager.Presentation.Properties.Resources.Male_512;
            this.pbPersonImage.Location = new System.Drawing.Point(25, 113);
            this.pbPersonImage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbPersonImage.Name = "pbPersonImage";
            this.pbPersonImage.Size = new System.Drawing.Size(158, 176);
            this.pbPersonImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPersonImage.TabIndex = 3;
            this.pbPersonImage.TabStop = false;
            // 
            // lblPersonIDTitle
            // 
            this.lblPersonIDTitle.AutoSize = true;
            this.lblPersonIDTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonIDTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblPersonIDTitle.Location = new System.Drawing.Point(203, 109);
            this.lblPersonIDTitle.Name = "lblPersonIDTitle";
            this.lblPersonIDTitle.Size = new System.Drawing.Size(167, 38);
            this.lblPersonIDTitle.TabIndex = 4;
            this.lblPersonIDTitle.Text = "ID Personne";
            // 
            // lblPersonID
            // 
            this.lblPersonID.AutoSize = true;
            this.lblPersonID.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.lblPersonID.Location = new System.Drawing.Point(436, 112);
            this.lblPersonID.Name = "lblPersonID";
            this.lblPersonID.Size = new System.Drawing.Size(89, 38);
            this.lblPersonID.TabIndex = 5;
            this.lblPersonID.Text = "[ ??? ]";
            // 
            // lblFullNameTitle
            // 
            this.lblFullNameTitle.AutoSize = true;
            this.lblFullNameTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullNameTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblFullNameTitle.Location = new System.Drawing.Point(203, 175);
            this.lblFullNameTitle.Name = "lblFullNameTitle";
            this.lblFullNameTitle.Size = new System.Drawing.Size(186, 38);
            this.lblFullNameTitle.TabIndex = 6;
            this.lblFullNameTitle.Text = "Nom complet";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.lblFullName.Location = new System.Drawing.Point(436, 178);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(89, 38);
            this.lblFullName.TabIndex = 7;
            this.lblFullName.Text = "[ ??? ]";
            // 
            // lblPhoneTitle
            // 
            this.lblPhoneTitle.AutoSize = true;
            this.lblPhoneTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblPhoneTitle.Location = new System.Drawing.Point(920, 247);
            this.lblPhoneTitle.Name = "lblPhoneTitle";
            this.lblPhoneTitle.Size = new System.Drawing.Size(145, 38);
            this.lblPhoneTitle.TabIndex = 8;
            this.lblPhoneTitle.Text = "Téléphone";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.lblPhone.Location = new System.Drawing.Point(1241, 247);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(89, 38);
            this.lblPhone.TabIndex = 9;
            this.lblPhone.Text = "[ ??? ]";
            // 
            // lblEmailTitle
            // 
            this.lblEmailTitle.AutoSize = true;
            this.lblEmailTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblEmailTitle.Location = new System.Drawing.Point(203, 247);
            this.lblEmailTitle.Name = "lblEmailTitle";
            this.lblEmailTitle.Size = new System.Drawing.Size(94, 38);
            this.lblEmailTitle.TabIndex = 10;
            this.lblEmailTitle.Text = "E-mail";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.lblEmail.Location = new System.Drawing.Point(436, 247);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(89, 38);
            this.lblEmail.TabIndex = 11;
            this.lblEmail.Text = "[ ??? ]";
            // 
            // lblDateOfBirthTitle
            // 
            this.lblDateOfBirthTitle.AutoSize = true;
            this.lblDateOfBirthTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateOfBirthTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblDateOfBirthTitle.Location = new System.Drawing.Point(917, 175);
            this.lblDateOfBirthTitle.Name = "lblDateOfBirthTitle";
            this.lblDateOfBirthTitle.Size = new System.Drawing.Size(241, 38);
            this.lblDateOfBirthTitle.TabIndex = 12;
            this.lblDateOfBirthTitle.Text = "Date de naissance";
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateOfBirth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.lblDateOfBirth.Location = new System.Drawing.Point(1241, 178);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(89, 38);
            this.lblDateOfBirth.TabIndex = 13;
            this.lblDateOfBirth.Text = "[ ??? ]";
            // 
            // lblGenderTitle
            // 
            this.lblGenderTitle.AutoSize = true;
            this.lblGenderTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenderTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblGenderTitle.Location = new System.Drawing.Point(920, 109);
            this.lblGenderTitle.Name = "lblGenderTitle";
            this.lblGenderTitle.Size = new System.Drawing.Size(92, 38);
            this.lblGenderTitle.TabIndex = 14;
            this.lblGenderTitle.Text = "Genre";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.lblGender.Location = new System.Drawing.Point(1241, 112);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(89, 38);
            this.lblGender.TabIndex = 15;
            this.lblGender.Text = "[ ??? ]";
            // 
            // ucPersonCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.Controls.Add(this.grpPersonneInfo);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ucPersonCard";
            this.Size = new System.Drawing.Size(1563, 377);
            this.Load += new System.EventHandler(this.ucPersonCard_Load);
            this.grpPersonneInfo.ResumeLayout(false);
            this.grpPersonneInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}
