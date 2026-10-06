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
            this.ucListeMembers1 = new GymManager.Presentation.Members.Controls.ucListeMembers();
            this.SuspendLayout();
            // 
            // ucListeMembers1
            // 
            this.ucListeMembers1.AutoSize = true;
            this.ucListeMembers1.Location = new System.Drawing.Point(26, 12);
            this.ucListeMembers1.Name = "ucListeMembers1";
            this.ucListeMembers1.Size = new System.Drawing.Size(1345, 582);
            this.ucListeMembers1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1389, 612);
            this.Controls.Add(this.ucListeMembers1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Members.Controls.ucListeMembers ucListeMembers1;
    }
}

