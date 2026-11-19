
namespace GymManager.Presentation.Members
{
    partial class frmShowMemberInfo
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
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.pnlMemberInfo = new System.Windows.Forms.Panel();
            this.ucMemberCardWithFilter1 = new GymManager.Presentation.Members.Controls.ucMemberCardWithFilter();
            this.pnlSubscriptions = new System.Windows.Forms.Panel();
            this.ucListAbonnmentPerson1 = new GymManager.Presentation.Abonnements.Control.ucListAbonnmentPerson();
            this.tlpMain.SuspendLayout();
            this.pnlMemberInfo.SuspendLayout();
            this.pnlSubscriptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.pnlMemberInfo, 0, 0);
            this.tlpMain.Controls.Add(this.pnlSubscriptions, 0, 1);
            this.tlpMain.Location = new System.Drawing.Point(1, -1);
            this.tlpMain.Margin = new System.Windows.Forms.Padding(0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.Padding = new System.Windows.Forms.Padding(18);
            this.tlpMain.RowCount = 2;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.39698F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.60302F));
            this.tlpMain.Size = new System.Drawing.Size(1491, 832);
            this.tlpMain.TabIndex = 0;
            // 
            // pnlMemberInfo
            // 
            this.pnlMemberInfo.BackColor = System.Drawing.Color.White;
            this.pnlMemberInfo.Controls.Add(this.ucMemberCardWithFilter1);
            this.pnlMemberInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMemberInfo.Location = new System.Drawing.Point(18, 18);
            this.pnlMemberInfo.Margin = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.pnlMemberInfo.Name = "pnlMemberInfo";
            this.pnlMemberInfo.Padding = new System.Windows.Forms.Padding(12);
            this.pnlMemberInfo.Size = new System.Drawing.Size(1455, 420);
            this.pnlMemberInfo.TabIndex = 0;
            // 
            // ucMemberCardWithFilter1
            // 
            this.ucMemberCardWithFilter1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucMemberCardWithFilter1.FilterEnabled = true;
            this.ucMemberCardWithFilter1.IsAddUpdateMode = true;
            this.ucMemberCardWithFilter1.Location = new System.Drawing.Point(12, 12);
            this.ucMemberCardWithFilter1.Margin = new System.Windows.Forms.Padding(0);
            this.ucMemberCardWithFilter1.Name = "ucMemberCardWithFilter1";
            this.ucMemberCardWithFilter1.Size = new System.Drawing.Size(1431, 396);
            this.ucMemberCardWithFilter1.TabIndex = 0;
            // 
            // pnlSubscriptions
            // 
            this.pnlSubscriptions.BackColor = System.Drawing.Color.White;
            this.pnlSubscriptions.Controls.Add(this.ucListAbonnmentPerson1);
            this.pnlSubscriptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSubscriptions.Location = new System.Drawing.Point(18, 462);
            this.pnlSubscriptions.Margin = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.pnlSubscriptions.Name = "pnlSubscriptions";
            this.pnlSubscriptions.Padding = new System.Windows.Forms.Padding(12);
            this.pnlSubscriptions.Size = new System.Drawing.Size(1455, 352);
            this.pnlSubscriptions.TabIndex = 1;
            // 
            // ucListAbonnmentPerson1
            // 
            this.ucListAbonnmentPerson1.BackColor = System.Drawing.Color.White;
            this.ucListAbonnmentPerson1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucListAbonnmentPerson1.Location = new System.Drawing.Point(12, 12);
            this.ucListAbonnmentPerson1.Margin = new System.Windows.Forms.Padding(0);
            this.ucListAbonnmentPerson1.Name = "ucListAbonnmentPerson1";
            this.ucListAbonnmentPerson1.Size = new System.Drawing.Size(1431, 328);
            this.ucListAbonnmentPerson1.TabIndex = 0;
            // 
            // frmShowMemberInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(1483, 891);
            this.Controls.Add(this.tlpMain);
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1339, 947);
            this.Name = "frmShowMemberInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Member Information";
            this.Load += new System.EventHandler(this.frmShowMemberInfo_Load);
            this.tlpMain.ResumeLayout(false);
            this.pnlMemberInfo.ResumeLayout(false);
            this.pnlSubscriptions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.Panel pnlMemberInfo;
        private System.Windows.Forms.Panel pnlSubscriptions;

        private Abonnements.Control.ucListAbonnmentPerson ucListAbonnmentPerson1;
        private Controls.ucMemberCardWithFilter ucMemberCardWithFilter1;
    }
}
