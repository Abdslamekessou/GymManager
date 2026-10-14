namespace GymManager.Presentation.Sports
{
    partial class frmAjouterModifierTest
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.uctrlAjouterModifierSport1 = new GymManager.Presentation.Sports.uctrlAjouterModifierSport();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(67)))), ((int)(((byte)(74)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(1031, 789);
            this.btnSave.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(154, 54);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Sauvegarder";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.Color.White;
            this.btnAnnuler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnnuler.FlatAppearance.BorderSize = 0;
            this.btnAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnuler.ForeColor = System.Drawing.Color.Black;
            this.btnAnnuler.Location = new System.Drawing.Point(842, 789);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(166, 54);
            this.btnAnnuler.TabIndex = 2;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // uctrlAjouterModifierSport1
            // 
            this.uctrlAjouterModifierSport1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.uctrlAjouterModifierSport1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.uctrlAjouterModifierSport1.Location = new System.Drawing.Point(6, 6);
            this.uctrlAjouterModifierSport1.MinimumSize = new System.Drawing.Size(600, 450);
            this.uctrlAjouterModifierSport1.Name = "uctrlAjouterModifierSport1";
            this.uctrlAjouterModifierSport1.Size = new System.Drawing.Size(1200, 780);
            this.uctrlAjouterModifierSport1.TabIndex = 3;
            // 
            // frmAjouterModifierTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1205, 855);
            this.Controls.Add(this.uctrlAjouterModifierSport1);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnSave);
            this.Name = "frmAjouterModifierTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAjouterModifierTest";
            this.Load += new System.EventHandler(this.frmAjouterModifierTest_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAnnuler;
        private uctrlAjouterModifierSport uctrlAjouterModifierSport1;
    }
}