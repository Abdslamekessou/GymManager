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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.rbInActif = new System.Windows.Forms.RadioButton();
            this.rbActif = new System.Windows.Forms.RadioButton();
            this.ucAbonnementInfo1 = new GymManager.Presentation.Abonnements.Control.ucAbonnementInfo();
            this.ucPersonCardWithFilter1 = new GymManager.Presentation.Personnes.Controls.ucPersonCardWithFilter();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCancel.Location = new System.Drawing.Point(1218, 890);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(165, 50);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSave.Location = new System.Drawing.Point(1405, 890);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(180, 50);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Enregistrer";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // rbInActif
            // 
            this.rbInActif.AutoSize = true;
            this.rbInActif.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbInActif.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.rbInActif.Location = new System.Drawing.Point(1069, 450);
            this.rbInActif.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbInActif.Name = "rbInActif";
            this.rbInActif.Size = new System.Drawing.Size(151, 36);
            this.rbInActif.TabIndex = 9;
            this.rbInActif.Text = "Pas Actif";
            this.rbInActif.UseVisualStyleBackColor = true;
            // 
            // rbActif
            // 
            this.rbActif.AutoSize = true;
            this.rbActif.Checked = true;
            this.rbActif.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbActif.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.rbActif.Location = new System.Drawing.Point(959, 450);
            this.rbActif.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbActif.Name = "rbActif";
            this.rbActif.Size = new System.Drawing.Size(95, 36);
            this.rbActif.TabIndex = 10;
            this.rbActif.TabStop = true;
            this.rbActif.Text = "Actif";
            this.rbActif.UseVisualStyleBackColor = true;
            // 
            // ucAbonnementInfo1
            // 
            this.ucAbonnementInfo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.ucAbonnementInfo1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucAbonnementInfo1.IsUpdateMode = false;
            this.ucAbonnementInfo1.Location = new System.Drawing.Point(26, 505);
            this.ucAbonnementInfo1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucAbonnementInfo1.Name = "ucAbonnementInfo1";
            this.ucAbonnementInfo1.Size = new System.Drawing.Size(1559, 376);
            this.ucAbonnementInfo1.TabIndex = 1;
            this.ucAbonnementInfo1.Load += new System.EventHandler(this.ucAbonnementInfo1_Load);
            // 
            // ucPersonCardWithFilter1
            // 
            this.ucPersonCardWithFilter1.AutoSize = true;
            this.ucPersonCardWithFilter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.ucPersonCardWithFilter1.FilterEnabled = true;
            this.ucPersonCardWithFilter1.Location = new System.Drawing.Point(-1, -2);
            this.ucPersonCardWithFilter1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ucPersonCardWithFilter1.Name = "ucPersonCardWithFilter1";
            this.ucPersonCardWithFilter1.ShowAddPerson = true;
            this.ucPersonCardWithFilter1.Size = new System.Drawing.Size(1587, 522);
            this.ucPersonCardWithFilter1.TabIndex = 0;
            // 
            // frmAddUpdateMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(1598, 948);
            this.Controls.Add(this.rbActif);
            this.Controls.Add(this.rbInActif);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.ucAbonnementInfo1);
            this.Controls.Add(this.ucPersonCardWithFilter1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddUpdateMember";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "frmAddUpdateMember";
            this.Load += new System.EventHandler(this.frmAddUpdateMember_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Personnes.Controls.ucPersonCardWithFilter ucPersonCardWithFilter1;
        private Abonnements.Control.ucAbonnementInfo ucAbonnementInfo1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RadioButton rbInActif;
        private System.Windows.Forms.RadioButton rbActif;
    }
}