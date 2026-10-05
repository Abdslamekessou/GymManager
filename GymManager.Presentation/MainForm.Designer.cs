namespace GymManager.Presentation
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.uc_Test1 = new GymManager.Presentation.Types_d_abonnements.Controls.uc_Test();
            this.SuspendLayout();
            // 
            // uc_Test1
            // 
            this.uc_Test1.Location = new System.Drawing.Point(143, 12);
            this.uc_Test1.Name = "uc_Test1";
            this.uc_Test1.Size = new System.Drawing.Size(1125, 678);
            this.uc_Test1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1668, 860);
            this.Controls.Add(this.uc_Test1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Types_d_abonnements.Controls.uc_Test uc_Test1;
    }
}