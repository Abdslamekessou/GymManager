namespace GymManager.Presentation.Abonnements
{
    partial class frmDetailsAbonnemnt
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
            this.btnFermer = new System.Windows.Forms.Button();
            this.ucDetailsAbonnemnt1 = new GymManager.Presentation.Abonnements.Control.ucDetailsAbonnemnt();
            this.SuspendLayout();
            // 
            // btnFermer
            // 
            this.btnFermer.BackColor = System.Drawing.Color.White;
            this.btnFermer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFermer.Location = new System.Drawing.Point(702, 190);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(100, 32);
            this.btnFermer.TabIndex = 1;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = false;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // ucDetailsAbonnemnt1
            // 
            this.ucDetailsAbonnemnt1.BackColor = System.Drawing.Color.Transparent;
            this.ucDetailsAbonnemnt1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucDetailsAbonnemnt1.Location = new System.Drawing.Point(12, 12);
            this.ucDetailsAbonnemnt1.Margin = new System.Windows.Forms.Padding(0);
            this.ucDetailsAbonnemnt1.Name = "ucDetailsAbonnemnt1";
            this.ucDetailsAbonnemnt1.Size = new System.Drawing.Size(790, 170);
            this.ucDetailsAbonnemnt1.TabIndex = 0;
            // 
            // frmDetailsAbonnemnt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(814, 234);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.ucDetailsAbonnemnt1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDetailsAbonnemnt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Détails de l\'abonnement";
            this.Load += new System.EventHandler(this.frmDetailsAbonnemnt_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Control.ucDetailsAbonnemnt ucDetailsAbonnemnt1;
        private System.Windows.Forms.Button btnFermer;
    }
}