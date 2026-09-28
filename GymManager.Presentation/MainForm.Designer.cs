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
            this.ucListePersonnes1 = new GymManager.Presentation.Personnes.Controls.ucListePersons();
            this.SuspendLayout();
            // 
            // ucListePersonnes1
            // 
            this.ucListePersonnes1.Location = new System.Drawing.Point(12, 12);
            this.ucListePersonnes1.Name = "ucListePersonnes1";
            this.ucListePersonnes1.Size = new System.Drawing.Size(1114, 481);
            this.ucListePersonnes1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 588);
            this.Controls.Add(this.ucListePersonnes1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Personnes.Controls.ucListePersons ucListePersonnes1;
    }
}

