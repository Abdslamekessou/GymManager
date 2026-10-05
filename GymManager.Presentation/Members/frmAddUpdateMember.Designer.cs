namespace GymManager.Presentation.Members
{
    partial class frmAddUpdateMember
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
            this.ucAbonnementInfo1 = new GymManager.Presentation.Abonnements.Control.ucAbonnementInfo();
            this.ucPersonCardWithFilter1 = new GymManager.Presentation.Personnes.Controls.ucPersonCardWithFilter();
            this.SuspendLayout();
            // 
            // ucAbonnementInfo1
            // 
            this.ucAbonnementInfo1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucAbonnementInfo1.Location = new System.Drawing.Point(30, 367);
            this.ucAbonnementInfo1.Name = "ucAbonnementInfo1";
            this.ucAbonnementInfo1.Size = new System.Drawing.Size(1363, 301);
            this.ucAbonnementInfo1.TabIndex = 1;
            // 
            // ucPersonCardWithFilter1
            // 
            this.ucPersonCardWithFilter1.AutoSize = true;
            this.ucPersonCardWithFilter1.FilterEnabled = true;
            this.ucPersonCardWithFilter1.Location = new System.Drawing.Point(12, 33);
            this.ucPersonCardWithFilter1.Name = "ucPersonCardWithFilter1";
            this.ucPersonCardWithFilter1.ShowAddPerson = true;
            this.ucPersonCardWithFilter1.Size = new System.Drawing.Size(1105, 328);
            this.ucPersonCardWithFilter1.TabIndex = 0;
            // 
            // frmAddUpdateMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1739, 716);
            this.Controls.Add(this.ucAbonnementInfo1);
            this.Controls.Add(this.ucPersonCardWithFilter1);
            this.Name = "frmAddUpdateMember";
            this.Text = "frmAddUpdateMember";
            this.Load += new System.EventHandler(this.frmAddUpdateMember_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Personnes.Controls.ucPersonCardWithFilter ucPersonCardWithFilter1;
        private Abonnements.Control.ucAbonnementInfo ucAbonnementInfo1;
    }
}