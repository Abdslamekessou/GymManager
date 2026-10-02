using GymManager.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManager.Presentation.Notifications
{
    public partial class frmNotificationDetailsTest : Form
    {
        clsNotification _Notification;

        public delegate void NotificationMarkedAsReadEventHandler(clsNotification Notification);

        public event NotificationMarkedAsReadEventHandler NotificationMarkedAsRead;

        public frmNotificationDetailsTest(clsNotification Notification)
        {
            InitializeComponent();
            _Notification = Notification;
        }

        private void NotificationDetailsTest_Load(object sender, EventArgs e)
        {
            ctrlNoficationDetails1.LoadNotification(_Notification);
            ctrlNoficationDetails1.BtnSaveEnable = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            NotificationMarkedAsRead?.Invoke(ctrlNoficationDetails1.Notificaton);
            this.Close();
        }
    }
}
