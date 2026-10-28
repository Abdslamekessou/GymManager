using GymManager.Business;
using GymManager.Presentation.Abonnements;
using GymManager.Presentation.Personnes.Controls;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using GymManager.Presentation.Helpers;
using System.Drawing.Drawing2D;
using GymManager.Presentation.Notifications;
using GymManager.Presentation.Members.Controls;
using GymManager.Presentation.Personnes.Controls;
using GymManager.Presentation.Sports;
using GymManager.Business.GymManager.Business;

namespace GymManager.Presentation
{
    public partial class MainForm : Form
    {
        private List<Panel> _sidebarIndicators;
        private int notificationCount = clsNotification.GetNumberOfUnreadNotifications(); 

        static MainForm()
        {
            clsAbonnement.UpdateAbonnementsStatus();
            clsNotification.UpdateNotifications();
        }
        public MainForm()
        {
            InitializeComponent();

            _sidebarIndicators = new List<Panel>
            {
                    pnlPersonnesIndicator,
                    pnlAdherentsIndicator,
                    pnlSportsIndicator,
                    pnlTypesAbonnementIndicator,
                    pnlAbonnementsIndicator,
                    pnlUtilisateurIndicator
            };

        }



        private void MainForm_Load(object sender, EventArgs e)
        {
            ipbCurrentUser.IconChar = IconChar.User;
            ipbCurrentUser.IconSize = 40;

            UIHelper.SetupIconButton(btnPersonnes, IconChar.PeopleGroup);
            UIHelper.SetupIconButton(btnAdherents, IconChar.UserCheck);
            UIHelper.SetupIconButton(btnSports, IconChar.Dumbbell);
            UIHelper.SetupIconButton(btnTypesAbonnements, IconChar.List);
            UIHelper.SetupIconButton(btnAbonnements, IconChar.CreditCard);
            UIHelper.SetupIconButton(btnUtilisateurs, IconChar.UserCog);
            UIHelper.SetupIconButton(btnDeconnexion, IconChar.SignOutAlt);

            lblTitle.ForeColor = ColorTranslator.FromHtml("#111827");

            UIHelper.SetupSidebarButtonStyle(btnPersonnes);
            UIHelper.SetupSidebarButtonStyle(btnAdherents);
            UIHelper.SetupSidebarButtonStyle(btnSports);
            UIHelper.SetupSidebarButtonStyle(btnTypesAbonnements);
            UIHelper.SetupSidebarButtonStyle(btnAbonnements);
            UIHelper.SetupSidebarButtonStyle(btnUtilisateurs);
            UIHelper.SetupSidebarButtonStyle(btnDeconnexion);


            pnlSidebar.BackColor = ColorTranslator.FromHtml("#0F172A");
            pnlHeader.BackColor = ColorTranslator.FromHtml("#0F172A");
            lblTitle.ForeColor = Color.White;
            lblCurrentUser.ForeColor = Color.White;
            ipbCurrentUser.IconColor = Color.White;

          

            
            ibtnNotifications.IconChar = IconChar.Bell;
            ibtnNotifications.IconColor = Color.White;
            ibtnNotifications.BackColor = ColorTranslator.FromHtml("#334155");
            ibtnNotifications.FlatStyle = FlatStyle.Flat;
            ibtnNotifications.FlatAppearance.BorderSize = 0;

            
            ibtnNotifications.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml("#475569");
            ibtnNotifications.FlatAppearance.MouseDownBackColor = ColorTranslator.FromHtml("#1E293B");

            ibtnNotifications.TabStop = false;

        }

        public void RefreshUnreadNotificationsIcon()
        {
            notificationCount = clsNotification.GetNumberOfUnreadNotifications();
            ibtnNotifications.Refresh();
        }
        private void btnPersonnes_Click(object sender, EventArgs e)
        {
            UIHelper.ActivateButton(btnPersonnes, pnlPersonnesIndicator, _sidebarIndicators, pnlSidebar);
            ucListePersons ucListePersons = new ucListePersons();
            ShowUserControl(ucListePersons);    
        }

        private void btnAdherents_Click(object sender, EventArgs e)
        {
            UIHelper.ActivateButton(btnAdherents, pnlAdherentsIndicator, _sidebarIndicators, pnlSidebar);
            ucListeMembers ucListeMembers = new ucListeMembers();
            ShowUserControl( ucListeMembers );

        }

        private void btnSports_Click(object sender, EventArgs e)
        {
            UIHelper.ActivateButton(btnSports, pnlSportsIndicator, _sidebarIndicators, pnlSidebar);
            uctrlShowListSports uctrlShowListSports = new uctrlShowListSports();
            ShowUserControl (uctrlShowListSports);
        }

        private void btnTypesAbonnements_Click(object sender, EventArgs e)
        {
            UIHelper.ActivateButton(btnTypesAbonnements, pnlTypesAbonnementIndicator, _sidebarIndicators, pnlSidebar);
            ucListTypesAbonnements ucListTypesAbonnements = new ucListTypesAbonnements();
            ShowUserControl(ucListTypesAbonnements);
        }

        private void btnAbonnements_Click(object sender, EventArgs e)
        {
            UIHelper.ActivateButton(btnAbonnements, pnlAbonnementsIndicator, _sidebarIndicators, pnlSidebar);
            ucListD_Abonnement ucList = new ucListD_Abonnement();
            ShowUserControl(ucList);
        }

        private void btnUtilisateurs_Click(object sender, EventArgs e)
        {
            UIHelper.ActivateButton(btnUtilisateurs, pnlUtilisateurIndicator, _sidebarIndicators, pnlSidebar);
            
        }

        private void btnDeconnexion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Êtes-vous sûr de vouloir vous déconnecter ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void ibtnNotifications_Paint(object sender, PaintEventArgs e)
        {

            if(notificationCount == 0)
            {
                return;
            }
           
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            string badgeText = notificationCount >= 99
                ? "99+" : notificationCount.ToString();
               

            int badgeHeight = 25;

            int badgeWidth = badgeText.Length > 2 ? 33
                             : badgeText.Length == 2 ? 26 :
                             25;

            // حساب موقع أيقونة الجرس بدقة داخل الزر
            int iconSize = ibtnNotifications.IconSize > 0 ? ibtnNotifications.IconSize : 32;
            int iconX = (ibtnNotifications.Width - iconSize) / 2;
            int iconY = (ibtnNotifications.Height - iconSize) / 2;

            // تم إزاحة الشارة أكثر نحو اليسار عبر زيادة قيمة الطرح
            int x = iconX + iconSize - (badgeWidth / 2) - 10;
            int y = iconY - 2;

            using (Brush bgBrush = new SolidBrush(ColorTranslator.FromHtml("#EF4444"))) // خلفية الشارة الحمراء
            using (Brush textBrush = new SolidBrush(Color.White))                      // لون النص الأبيض
            using (Font font = new Font("Segoe UI", 8f, FontStyle.Bold))               // خط بحجم 8
            {
                // 1. رسم الدائرة الحمراء
                e.Graphics.FillEllipse(bgBrush, x, y, badgeWidth, badgeHeight);

                // 2. حساب قياس النص لتوسيته بدقة داخل الدائرة
                SizeF textSize = e.Graphics.MeasureString(badgeText, font);

                float textX = x + (badgeWidth - textSize.Width) / 2f;
                float textY = y + (badgeHeight - textSize.Height) / 2f;
                // 3. رسم رقم الإشعارات في منتصف الدائرة الحمراء تماماً
                e.Graphics.DrawString(badgeText, font, textBrush
                   ,textX , textY);
            }
        }

        private void ShowUserControl(UserControl userControl)
        {
            pnlContent.Controls.Clear();

            userControl.Dock = DockStyle.Fill;

            pnlContent.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void ibtnNotifications_Click(object sender, EventArgs e)
        {
            ctrlNotifications ctrlNotifications = new ctrlNotifications();
            ctrlNotifications.NotificationCount += CtrlNotifications_NotificationCount;
            ShowUserControl(ctrlNotifications);
        }

        private void CtrlNotifications_NotificationCount(bool IsAllRead)
        {

            if (IsAllRead)
                notificationCount = 0;
            else
                if (notificationCount!=0)
                    notificationCount--;

            ibtnNotifications.Refresh();


        }
    }
   }

