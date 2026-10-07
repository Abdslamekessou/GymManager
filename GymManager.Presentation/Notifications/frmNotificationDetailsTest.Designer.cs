namespace GymManager.Presentation.Notifications
{
    partial class frmNotificationDetailsTest
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
            this.btnClose = new System.Windows.Forms.Button();
            this.ctrlNoficationDetails1 = new GymManager.Presentation.Notifications.ctrlNoficationDetails();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnClose.Location = new System.Drawing.Point(463, 809);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(193, 60);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Fermer";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ctrlNoficationDetails1
            // 
            this.ctrlNoficationDetails1.AutoSize = true;
            this.ctrlNoficationDetails1.BackColor = System.Drawing.Color.White;
            this.ctrlNoficationDetails1.Location = new System.Drawing.Point(0, -7);
            this.ctrlNoficationDetails1.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlNoficationDetails1.Name = "ctrlNoficationDetails1";
            this.ctrlNoficationDetails1.Size = new System.Drawing.Size(1264, 898);
            this.ctrlNoficationDetails1.TabIndex = 0;
            // 
            // frmNotificationDetailsTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1265, 879);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ctrlNoficationDetails1);
            this.Name = "frmNotificationDetailsTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NotificationDetailsTest";
            this.Load += new System.EventHandler(this.NotificationDetailsTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlNoficationDetails ctrlNoficationDetails1;
        private System.Windows.Forms.Button btnClose;
    }
}