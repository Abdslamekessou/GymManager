using System;
using System.Data;
using System.Windows.Forms;
using GymManager.Business;

namespace GymManager.Presentation.Notifications
{
    public partial class ctrlNotifications : UserControl
    {
        public ctrlNotifications()
        {
            InitializeComponent();

            LoadNotifications();
        }
        private void LoadNotifications()
        {
           

            dgvNotifications.DataSource =clsNotification.AllNotifications() ;
        }
        private void ctrlNotifications_Load(object sender, EventArgs e)
        {

        }

        private void ctrlNotifications_Load_1(object sender, EventArgs e)
        {

        }
    }
}
