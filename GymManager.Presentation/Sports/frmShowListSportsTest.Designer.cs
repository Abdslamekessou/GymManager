namespace GymManager.Presentation.Sports
{
    partial class frmShowListSportsTest
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
            this.uctrlShowListSports1 = new GymManager.Presentation.Sports.uctrlShowListSports();
            this.SuspendLayout();
            // 
            // uctrlShowListSports1
            // 
            this.uctrlShowListSports1.AutoSize = true;
            this.uctrlShowListSports1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.uctrlShowListSports1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.uctrlShowListSports1.Location = new System.Drawing.Point(10, 16);
            this.uctrlShowListSports1.Name = "uctrlShowListSports1";
            this.uctrlShowListSports1.Size = new System.Drawing.Size(1200, 780);
            this.uctrlShowListSports1.TabIndex = 0;
            // 
            // frmShowListSportsTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1234, 826);
            this.Controls.Add(this.uctrlShowListSports1);
            this.Name = "frmShowListSportsTest";
            this.Text = "frmShowListSports";
            this.Load += new System.EventHandler(this.frmShowListSports_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private uctrlShowListSports uctrlShowListSports1;
    }
}