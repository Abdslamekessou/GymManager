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
            this.btnOpenUserList = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenUserList
            // 
            this.btnOpenUserList.Location = new System.Drawing.Point(196, 82);
            this.btnOpenUserList.Name = "btnOpenUserList";
            this.btnOpenUserList.Size = new System.Drawing.Size(179, 81);
            this.btnOpenUserList.TabIndex = 0;
            this.btnOpenUserList.Text = "Open Users List";
            this.btnOpenUserList.UseVisualStyleBackColor = true;
            this.btnOpenUserList.Click += new System.EventHandler(this.btnOpenUserList_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(592, 104);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(179, 81);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1393, 735);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnOpenUserList);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenUserList;
        private System.Windows.Forms.Button btnLogout;
    }
}

