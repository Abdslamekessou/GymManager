namespace GymManager.Presentation
{
    partial class Test
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
            this.ucListeUtilisateurs1 = new GymManager.Presentation.Utilisateurs.Controls.ucListeUtilisateurs();
            this.SuspendLayout();
            // 
            // ucListeUtilisateurs1
            // 
            this.ucListeUtilisateurs1.Location = new System.Drawing.Point(-1, -4);
            this.ucListeUtilisateurs1.Name = "ucListeUtilisateurs1";
            this.ucListeUtilisateurs1.Size = new System.Drawing.Size(1581, 751);
            this.ucListeUtilisateurs1.TabIndex = 0;
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1596, 853);
            this.Controls.Add(this.ucListeUtilisateurs1);
            this.Name = "Test";
            this.Text = "Test";
            this.ResumeLayout(false);

        }

        #endregion

        private Utilisateurs.Controls.ucListeUtilisateurs ucListeUtilisateurs1;
    }
}