namespace GymManager.Presentation.Members
{
    partial class frmShowMemberInfo
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
            this.ucPersonCard1 = new GymManager.Presentation.Personnes.Controls.ucPersonCard();
            this.SuspendLayout();
            // 
            // ucPersonCard1
            // 
            this.ucPersonCard1.AutoSize = true;
            this.ucPersonCard1.Location = new System.Drawing.Point(12, 37);
            this.ucPersonCard1.Name = "ucPersonCard1";
            this.ucPersonCard1.Size = new System.Drawing.Size(1083, 202);
            this.ucPersonCard1.TabIndex = 0;
            // 
            // frmShowMemberInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 580);
            this.Controls.Add(this.ucPersonCard1);
            this.Name = "frmShowMemberInfo";
            this.Text = "frmShowMemberInfo";
            this.Load += new System.EventHandler(this.frmShowMemberInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Personnes.Controls.ucPersonCard ucPersonCard1;
    }
}