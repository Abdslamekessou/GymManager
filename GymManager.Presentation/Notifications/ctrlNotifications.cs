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
    public partial class ctrlNotifications : UserControl
    {
        public ctrlNotifications()
        {
            InitializeComponent();

            LoadNotifications();
        }
        private void LoadNotifications()
        {
            DataTable dtNotifications = new DataTable();

            dtNotifications.Columns.Add("NotificationID", typeof(int));
            dtNotifications.Columns.Add("MemberName", typeof(string));
            dtNotifications.Columns.Add("Sport", typeof(string));
            dtNotifications.Columns.Add("SubscriptionType", typeof(string));
            dtNotifications.Columns.Add("Status", typeof(string));
            dtNotifications.Columns.Add("ReadStatus", typeof(string));
            dtNotifications.Columns.Add("ExportStatus", typeof(string));

            dtNotifications.Rows.Add(
                1,
                "Ahmed Ali",
                "Musculation",
                "Mensuel",
                "Expiré",
                "Non lu",
                "Non exporté"
            );

            dtNotifications.Rows.Add(
                2,
                "Karim Benali",
                "Spinning",
                "Trimestriel",
                "Actif",
                "Lu",
                "Non exporté"
            );

            dtNotifications.Rows.Add(
                3,
                "Sara Ahmed",
                "Yoga",
                "Mensuel",
                "Expiré",
                "Non lu",
                "Non exporté"
            );

            dtNotifications.Rows.Add(
                4,
                "Yacine Brahimi",
                "CrossFit",
                "Trimestriel",
                "Actif",
                "Lu",
                "Exporté"
            );

            dtNotifications.Rows.Add(
                5,
                "Lina Mansouri",
                "Boxe",
                "Mensuel",
                "Actif",
                "Non lu",
                "Non exporté"
            );

            dgvNotifications.DataSource = dtNotifications;

        }
        private void ctrlNotifications_Load(object sender, EventArgs e)
        {

        }
    }
}
