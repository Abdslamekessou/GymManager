using System.Drawing;
using System.Windows.Forms;

namespace GymManager.Presentation.Notifications
{
    partial class ctrlNoficationDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private Label lblTitle;
        private GroupBox gbNotificationInfo;
        private GroupBox gbMessage;

        private Label lblMemberName;
        private Label lblPhone;
        private Label lblSport;
        private Label lblSubscriptionType;
        private Label lblStartDate;
        private Label lblEndDate;
        private Label lblSubscriptionStatus;
        private Label lblReadStatus;
        private Label lblExportStatus;

        private TextBox txtMemberName;
        private TextBox txtPhone;
        private TextBox txtSport;
        private TextBox txtSubscriptionType;
        private TextBox txtStartDate;
        private TextBox txtEndDate;
        private TextBox txtSubscriptionStatus;

        private Label lblReadStatusValue;
        private Label lblExportStatusValue;

        private RichTextBox rtbMessage;

        private Button btnMarkAsRead;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
        /// Required method for Designer support.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbNotificationInfo = new System.Windows.Forms.GroupBox();
            this.lblMemberName = new System.Windows.Forms.Label();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblSport = new System.Windows.Forms.Label();
            this.txtSport = new System.Windows.Forms.TextBox();
            this.lblSubscriptionType = new System.Windows.Forms.Label();
            this.txtSubscriptionType = new System.Windows.Forms.TextBox();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.txtStartDate = new System.Windows.Forms.TextBox();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.txtEndDate = new System.Windows.Forms.TextBox();
            this.lblSubscriptionStatus = new System.Windows.Forms.Label();
            this.txtSubscriptionStatus = new System.Windows.Forms.TextBox();
            this.lblReadStatus = new System.Windows.Forms.Label();
            this.lblReadStatusValue = new System.Windows.Forms.Label();
            this.lblExportStatus = new System.Windows.Forms.Label();
            this.lblExportStatusValue = new System.Windows.Forms.Label();
            this.gbMessage = new System.Windows.Forms.GroupBox();
            this.rtbMessage = new System.Windows.Forms.RichTextBox();
            this.btnMarkAsRead = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbNotificationInfo.SuspendLayout();
            this.gbMessage.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.lblTitle.Location = new System.Drawing.Point(39, 33);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(666, 54);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "🔔  DÉTAILS DE LA NOTIFICATION";
            // 
            // gbNotificationInfo
            // 
            this.gbNotificationInfo.AutoSize = true;
            this.gbNotificationInfo.Controls.Add(this.lblMemberName);
            this.gbNotificationInfo.Controls.Add(this.txtMemberName);
            this.gbNotificationInfo.Controls.Add(this.lblPhone);
            this.gbNotificationInfo.Controls.Add(this.txtPhone);
            this.gbNotificationInfo.Controls.Add(this.lblSport);
            this.gbNotificationInfo.Controls.Add(this.txtSport);
            this.gbNotificationInfo.Controls.Add(this.lblSubscriptionType);
            this.gbNotificationInfo.Controls.Add(this.txtSubscriptionType);
            this.gbNotificationInfo.Controls.Add(this.lblStartDate);
            this.gbNotificationInfo.Controls.Add(this.txtStartDate);
            this.gbNotificationInfo.Controls.Add(this.lblEndDate);
            this.gbNotificationInfo.Controls.Add(this.txtEndDate);
            this.gbNotificationInfo.Controls.Add(this.lblSubscriptionStatus);
            this.gbNotificationInfo.Controls.Add(this.txtSubscriptionStatus);
            this.gbNotificationInfo.Controls.Add(this.lblReadStatus);
            this.gbNotificationInfo.Controls.Add(this.lblReadStatusValue);
            this.gbNotificationInfo.Controls.Add(this.lblExportStatus);
            this.gbNotificationInfo.Controls.Add(this.lblExportStatusValue);
            this.gbNotificationInfo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gbNotificationInfo.Location = new System.Drawing.Point(26, 107);
            this.gbNotificationInfo.Margin = new System.Windows.Forms.Padding(4);
            this.gbNotificationInfo.Name = "gbNotificationInfo";
            this.gbNotificationInfo.Padding = new System.Windows.Forms.Padding(4);
            this.gbNotificationInfo.Size = new System.Drawing.Size(1234, 440);
            this.gbNotificationInfo.TabIndex = 1;
            this.gbNotificationInfo.TabStop = false;
            this.gbNotificationInfo.Text = "Informations de la notification";
            // 
            // lblMemberName
            // 
            this.lblMemberName.AutoSize = true;
            this.lblMemberName.Location = new System.Drawing.Point(32, 47);
            this.lblMemberName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMemberName.Name = "lblMemberName";
            this.lblMemberName.Size = new System.Drawing.Size(171, 28);
            this.lblMemberName.TabIndex = 0;
            this.lblMemberName.Text = "Nom du membre :";
            // 
            // txtMemberName
            // 
            this.txtMemberName.Location = new System.Drawing.Point(32, 80);
            this.txtMemberName.Margin = new System.Windows.Forms.Padding(4);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.ReadOnly = true;
            this.txtMemberName.Size = new System.Drawing.Size(372, 34);
            this.txtMemberName.TabIndex = 1;
            this.txtMemberName.Text = "Ahmed Ali";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(456, 47);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(213, 28);
            this.lblPhone.TabIndex = 2;
            this.lblPhone.Text = "Numéro de téléphone :";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(456, 80);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.ReadOnly = true;
            this.txtPhone.Size = new System.Drawing.Size(372, 34);
            this.txtPhone.TabIndex = 3;
            this.txtPhone.Text = "055 XX XX XX XX";
            // 
            // lblSport
            // 
            this.lblSport.AutoSize = true;
            this.lblSport.Location = new System.Drawing.Point(32, 140);
            this.lblSport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSport.Name = "lblSport";
            this.lblSport.Size = new System.Drawing.Size(70, 28);
            this.lblSport.TabIndex = 4;
            this.lblSport.Text = "Sport :";
            // 
            // txtSport
            // 
            this.txtSport.Location = new System.Drawing.Point(32, 173);
            this.txtSport.Margin = new System.Windows.Forms.Padding(4);
            this.txtSport.Name = "txtSport";
            this.txtSport.ReadOnly = true;
            this.txtSport.Size = new System.Drawing.Size(372, 34);
            this.txtSport.TabIndex = 5;
            this.txtSport.Text = "Musculation";
            // 
            // lblSubscriptionType
            // 
            this.lblSubscriptionType.AutoSize = true;
            this.lblSubscriptionType.Location = new System.Drawing.Point(456, 140);
            this.lblSubscriptionType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubscriptionType.Name = "lblSubscriptionType";
            this.lblSubscriptionType.Size = new System.Drawing.Size(195, 28);
            this.lblSubscriptionType.TabIndex = 6;
            this.lblSubscriptionType.Text = "Type d\'abonnement :";
            // 
            // txtSubscriptionType
            // 
            this.txtSubscriptionType.Location = new System.Drawing.Point(456, 173);
            this.txtSubscriptionType.Margin = new System.Windows.Forms.Padding(4);
            this.txtSubscriptionType.Name = "txtSubscriptionType";
            this.txtSubscriptionType.ReadOnly = true;
            this.txtSubscriptionType.Size = new System.Drawing.Size(372, 34);
            this.txtSubscriptionType.TabIndex = 7;
            this.txtSubscriptionType.Text = "Mensuel";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(32, 233);
            this.lblStartDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(146, 28);
            this.lblStartDate.TabIndex = 8;
            this.lblStartDate.Text = "Date de début :";
            // 
            // txtStartDate
            // 
            this.txtStartDate.Location = new System.Drawing.Point(32, 267);
            this.txtStartDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.ReadOnly = true;
            this.txtStartDate.Size = new System.Drawing.Size(372, 34);
            this.txtStartDate.TabIndex = 9;
            this.txtStartDate.Text = "10/08/2026";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(456, 233);
            this.lblEndDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(116, 28);
            this.lblEndDate.TabIndex = 10;
            this.lblEndDate.Text = "Date de fin :";
            // 
            // txtEndDate
            // 
            this.txtEndDate.Location = new System.Drawing.Point(456, 267);
            this.txtEndDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.ReadOnly = true;
            this.txtEndDate.Size = new System.Drawing.Size(372, 34);
            this.txtEndDate.TabIndex = 11;
            this.txtEndDate.Text = "10/09/2026";
            // 
            // lblSubscriptionStatus
            // 
            this.lblSubscriptionStatus.AutoSize = true;
            this.lblSubscriptionStatus.Location = new System.Drawing.Point(32, 327);
            this.lblSubscriptionStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubscriptionStatus.Name = "lblSubscriptionStatus";
            this.lblSubscriptionStatus.Size = new System.Drawing.Size(226, 28);
            this.lblSubscriptionStatus.TabIndex = 12;
            this.lblSubscriptionStatus.Text = "Statut de l\'abonnement :";
            // 
            // txtSubscriptionStatus
            // 
            this.txtSubscriptionStatus.Location = new System.Drawing.Point(32, 360);
            this.txtSubscriptionStatus.Margin = new System.Windows.Forms.Padding(4);
            this.txtSubscriptionStatus.Name = "txtSubscriptionStatus";
            this.txtSubscriptionStatus.ReadOnly = true;
            this.txtSubscriptionStatus.Size = new System.Drawing.Size(372, 34);
            this.txtSubscriptionStatus.TabIndex = 13;
            this.txtSubscriptionStatus.Text = "Expiré";
            // 
            // lblReadStatus
            // 
            this.lblReadStatus.AutoSize = true;
            this.lblReadStatus.Location = new System.Drawing.Point(868, 47);
            this.lblReadStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReadStatus.Name = "lblReadStatus";
            this.lblReadStatus.Size = new System.Drawing.Size(164, 28);
            this.lblReadStatus.TabIndex = 14;
            this.lblReadStatus.Text = "Statut de lecture :";
            // 
            // lblReadStatusValue
            // 
            this.lblReadStatusValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblReadStatusValue.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblReadStatusValue.ForeColor = System.Drawing.Color.Firebrick;
            this.lblReadStatusValue.Location = new System.Drawing.Point(868, 80);
            this.lblReadStatusValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReadStatusValue.Name = "lblReadStatusValue";
            this.lblReadStatusValue.Size = new System.Drawing.Size(321, 53);
            this.lblReadStatusValue.TabIndex = 15;
            this.lblReadStatusValue.Text = "●   Non lu";
            this.lblReadStatusValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblExportStatus
            // 
            this.lblExportStatus.AutoSize = true;
            this.lblExportStatus.Location = new System.Drawing.Point(868, 167);
            this.lblExportStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExportStatus.Name = "lblExportStatus";
            this.lblExportStatus.Size = new System.Drawing.Size(197, 28);
            this.lblExportStatus.TabIndex = 16;
            this.lblExportStatus.Text = "Statut d\'exportation :";
            // 
            // lblExportStatusValue
            // 
            this.lblExportStatusValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblExportStatusValue.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblExportStatusValue.Location = new System.Drawing.Point(868, 200);
            this.lblExportStatusValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExportStatusValue.Name = "lblExportStatusValue";
            this.lblExportStatusValue.Size = new System.Drawing.Size(321, 53);
            this.lblExportStatusValue.TabIndex = 17;
            this.lblExportStatusValue.Text = "○   Non exporté";
            this.lblExportStatusValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gbMessage
            // 
            this.gbMessage.Controls.Add(this.rtbMessage);
            this.gbMessage.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gbMessage.Location = new System.Drawing.Point(26, 567);
            this.gbMessage.Margin = new System.Windows.Forms.Padding(4);
            this.gbMessage.Name = "gbMessage";
            this.gbMessage.Padding = new System.Windows.Forms.Padding(4);
            this.gbMessage.Size = new System.Drawing.Size(1234, 240);
            this.gbMessage.TabIndex = 2;
            this.gbMessage.TabStop = false;
            this.gbMessage.Text = "MESSAGE";
            // 
            // rtbMessage
            // 
            this.rtbMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbMessage.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rtbMessage.Location = new System.Drawing.Point(26, 40);
            this.rtbMessage.Margin = new System.Windows.Forms.Padding(4);
            this.rtbMessage.Name = "rtbMessage";
            this.rtbMessage.Size = new System.Drawing.Size(1182, 172);
            this.rtbMessage.TabIndex = 0;
            this.rtbMessage.Text = "Bonjour Ahmed Ali,\n\nNous vous informons que votre abonnement Mensuel en Musculati" +
    "on a expiré le 10/09/2026.\n\nVous pouvez nous contacter ou visiter la salle pour " +
    "renouveler votre abonnement.\n\nMerci.";
            this.rtbMessage.TextChanged += new System.EventHandler(this.rtbMessage_TextChanged);
            // 
            // btnMarkAsRead
            // 
            this.btnMarkAsRead.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnMarkAsRead.Location = new System.Drawing.Point(680, 815);
            this.btnMarkAsRead.Margin = new System.Windows.Forms.Padding(4);
            this.btnMarkAsRead.Name = "btnMarkAsRead";
            this.btnMarkAsRead.Size = new System.Drawing.Size(257, 60);
            this.btnMarkAsRead.TabIndex = 3;
            this.btnMarkAsRead.Text = "✓  Marquer comme lu";
            this.btnMarkAsRead.Click += new System.EventHandler(this.btnMarkAsRead_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSave.Location = new System.Drawing.Point(958, 815);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(257, 60);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Sauvegarder";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ctrlNoficationDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.gbNotificationInfo);
            this.Controls.Add(this.btnMarkAsRead);
            this.Controls.Add(this.gbMessage);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ctrlNoficationDetails";
            this.Size = new System.Drawing.Size(1286, 889);
            this.Load += new System.EventHandler(this.ctrlNoficationDetails_Load);
            this.gbNotificationInfo.ResumeLayout(false);
            this.gbNotificationInfo.PerformLayout();
            this.gbMessage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSave;
    }
}