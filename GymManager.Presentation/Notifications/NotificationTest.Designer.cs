namespace GymManager.Presentation.Notifications
{
    partial class NotificationTest
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
            this.ctrlNotifications1 = new GymManager.Presentation.Notifications.ctrlNotifications();
            this.SuspendLayout();
            // 
            // ctrlNotifications1
            // 
            this.ctrlNotifications1.AutoSize = true;
            this.ctrlNotifications1.BackColor = System.Drawing.Color.White;
            this.ctrlNotifications1.Location = new System.Drawing.Point(13, 1);
            this.ctrlNotifications1.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlNotifications1.Name = "ctrlNotifications1";
            this.ctrlNotifications1.Size = new System.Drawing.Size(1431, 948);
            this.ctrlNotifications1.TabIndex = 0;
            // 
            // NotificationTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1605, 987);
            this.Controls.Add(this.ctrlNotifications1);
            this.Name = "NotificationTest";
            this.Text = "NotificationTest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlNotifications ctrlNotifications1;
    }
}