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
            this.ucMemberCardWithFilter1 = new GymManager.Presentation.Members.Controls.ucMemberCardWithFilter();
            this.ucListAbonnmentPerson1 = new GymManager.Presentation.Abonnements.Control.ucListAbonnmentPerson();
            this.SuspendLayout();
            // 
            // ucMemberCardWithFilter1
            // 
            this.ucMemberCardWithFilter1.FilterEnabled = true;
            this.ucMemberCardWithFilter1.Location = new System.Drawing.Point(12, 12);
            this.ucMemberCardWithFilter1.Name = "ucMemberCardWithFilter1";
            this.ucMemberCardWithFilter1.Size = new System.Drawing.Size(1110, 329);
            this.ucMemberCardWithFilter1.TabIndex = 0;
            // 
            // ucListAbonnmentPerson1
            // 
            this.ucListAbonnmentPerson1.BackColor = System.Drawing.Color.White;
            this.ucListAbonnmentPerson1.Location = new System.Drawing.Point(12, 313);
            this.ucListAbonnmentPerson1.Name = "ucListAbonnmentPerson1";
            this.ucListAbonnmentPerson1.Size = new System.Drawing.Size(888, 430);
            this.ucListAbonnmentPerson1.TabIndex = 1;
            // 
            // frmShowMemberInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 610);
            this.Controls.Add(this.ucListAbonnmentPerson1);
            this.Controls.Add(this.ucMemberCardWithFilter1);
            this.Name = "frmShowMemberInfo";
            this.Text = "frmShowMemberInfo";
            this.Load += new System.EventHandler(this.frmShowMemberInfo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ucMemberCardWithFilter ucMemberCardWithFilter1;
        private Abonnements.Control.ucListAbonnmentPerson ucListAbonnmentPerson1;
    }
}