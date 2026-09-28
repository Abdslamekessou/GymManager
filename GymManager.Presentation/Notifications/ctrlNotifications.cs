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

            dtNotifications.Columns.Add("MemberName", typeof(string));
            dtNotifications.Columns.Add("Sport", typeof(string));
            dtNotifications.Columns.Add("SubscriptionType", typeof(string));
            dtNotifications.Columns.Add("Status", typeof(string));
            dtNotifications.Columns.Add("ReadStatus", typeof(string));
            dtNotifications.Columns.Add("Exportation", typeof(string));

            dtNotifications.Rows.Add(
                "Ahmed Ali",
                "Musculation",
                "Mensuel",
                "Expiré",
                "Non lu",
                "Non exporté"
            );

            dtNotifications.Rows.Add(
                "Karim Benali",
                "Spinning",
                "Trimestriel",
                "Actif",
                "Lu",
                "Non exporté"
            );

            dtNotifications.Rows.Add(
                "Sara Ahmed",
                "Yoga",
                "Mensuel",
                "Expiré",
                "Non lu",
                "Non exporté"
            );

            dtNotifications.Rows.Add(
                "Yacine Brahimi",
                "CrossFit",
                "Trimestriel",
                "Actif",
                "Lu",
                "Exporté"
            );

            dtNotifications.Rows.Add(
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
