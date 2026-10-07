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
    public partial class ctrlNoficationDetails : UserControl
    {
        clsNotification _Notification;

        public delegate void NotificationMarkedAsReadEventHandler(clsNotification Notification);

        public event NotificationMarkedAsReadEventHandler NotificationMarkedAsRead;

        public clsNotification Notificaton
        { get { return _Notification; } }
        public ctrlNoficationDetails()
        {
            InitializeComponent();
        }
        public void LoadNotification(clsNotification notification)
        {
            _Notification = notification;
            txtMemberName.Text = _Notification.MemberName;
            txtSport.Text = _Notification.SportName;
            txtPhone.Text = _Notification.Phone;
            txtSubscriptionType.Text = _Notification.SubscriptionType;
            txtStartDate.Text = _Notification.StartDate.ToString("dd/MM/yyyy");
            txtEndDate.Text = _Notification.EndDate.Date.ToString("dd/MM/yyyy");
            txtSubscriptionStatus.Text = _Notification.SubscriptionStatus;

            rtbMessage.Text = _Notification.Message.ToString();

            if (_Notification.IsRead)
            {
                lblReadStatusValue.Text = "●   Lu";
                lblReadStatusValue.ForeColor = Color.Green;
                btnMarkAsRead.Enabled = false;
            }

            if (_Notification.IsExported)
            {
                lblExportStatusValue.Text = "●   Exporté";
                lblExportStatusValue.ForeColor = Color.Green;
            }

        }
        private void ctrlNoficationDetails_Load(object sender, EventArgs e)
        {

        }

        private void btnMarkAsRead_Click(object sender, EventArgs e)
        {
            _Notification.IsRead = true;

            lblReadStatusValue.Text = "●   Lu";
            lblReadStatusValue.ForeColor = Color.Green;
            btnMarkAsRead.Enabled = false;

        }

        private void rtbMessage_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _Notification.Message = rtbMessage.Text;
            if (_Notification.Save())
            {
                NotificationMarkedAsRead?.Invoke(_Notification);
                MessageBox.Show("Les Changements sont sauvegader avec successé");
                btnSave.Enabled = false;
            }
            else
                MessageBox.Show("Les Changements ne sont pas sauvegader", "", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }
    }
}
