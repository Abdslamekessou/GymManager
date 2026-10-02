using System;
using System.Data;
using System.Windows.Forms;
using GymManager.Business;

namespace GymManager.Presentation.Notifications
{
    public partial class ctrlNotifications : UserControl
    {
        static DataTable _AllNotifications = clsNotification.AllNotifications();
        int _LastRowIndex = -1;
        public ctrlNotifications()
        {
            InitializeComponent();

            dgvNotifications.AutoGenerateColumns = false;
            cbStatus.SelectedIndex = 0;
            cbExportStatus.SelectedIndex = 0;
            dgvNotifications.CellContentClick += DgvNotifications_CellContentClick;


        }

        private void DgvNotifications_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0)
                return;

            //Handle the event when clicking on the "Marquer comme Lu" Column
            if (e.ColumnIndex == colMarkAsRead.Index)
            {
                if (dgvNotifications[ReadStatus.Index, e.RowIndex].FormattedValue.ToString() != "Lu")
                {
                    _MarkAsReadHandler(e.RowIndex);
                   
                }
            }
            //Clicking on the "Details" Cell
            if (e.ColumnIndex == colDetails.Index)
            {
                _LastRowIndex= e.RowIndex;
                clsNotification Notification = _FillNotificationInfo(e.RowIndex);
                frmNotificationDetailsTest frm = new frmNotificationDetailsTest(Notification);
                frm.NotificationMarkedAsRead += Frm_NotificationMarkedAsReadChangeMessage;
                frm.ShowDialog();
            }

        }

        private void Frm_NotificationMarkedAsReadChangeMessage(clsNotification Notification)
        {
            if (Notification.IsRead)
            {
                _AllNotifications.Columns["ReadStatus"].ReadOnly = false;
                _AllNotifications.Rows[_LastRowIndex]["ReadStatus"] = "Lu";
                _AllNotifications.Columns["ReadStatus"].ReadOnly = true;
            }

            _AllNotifications.Columns["LeMessage"].ReadOnly = false;
            _AllNotifications.Rows[_LastRowIndex]["LeMessage"] = Notification.Message;
            _AllNotifications.Columns["LeMessage"].ReadOnly = true;
        }

        private void _MarkAsReadHandler(int RowIndex)
        {
            if (clsNotification.MarkAsRead(Convert.ToInt32(_AllNotifications.Rows[RowIndex]["NotificationID"])))
            {
                _AllNotifications.Columns["ReadStatus"].ReadOnly = false;
                _AllNotifications.Rows[RowIndex]["ReadStatus"] = "Lu";
                _AllNotifications.Columns["ReadStatus"].ReadOnly = true;

            }
        }

        private clsNotification _FillNotificationInfo(int RowIndex)
        {
            int ID = (int)_AllNotifications.Rows[RowIndex]["NotificationID"];
            string MemberName = _AllNotifications.Rows[RowIndex]["MemberName"].ToString();
            string Phone = _AllNotifications.Rows[RowIndex]["Phone"].ToString();
            string Sport = _AllNotifications.Rows[RowIndex]["Sport"].ToString();
            string SubscriptionType = _AllNotifications.Rows[RowIndex]["SubscriptionType"].ToString();
            DateTime DateDebut = ((DateTime)_AllNotifications.Rows[RowIndex]["DateDebut"]).Date;
            DateTime DateFin = ((DateTime)_AllNotifications.Rows[RowIndex]["DateFin"]).Date;
            string AbonnementStatus = _AllNotifications.Rows[RowIndex]["AbonnementStatus"].ToString();
            bool IsRead = _AllNotifications.Rows[RowIndex]["ReadStatus"].ToString() == "Lu";
            bool IsExported = _AllNotifications.Rows[RowIndex]["Exportation"].ToString() == "Exporté";
            string Message = _AllNotifications.Rows[RowIndex]["LeMessage"].ToString();

            return new clsNotification(ID, MemberName, Phone, Sport, SubscriptionType, DateDebut, DateFin, AbonnementStatus, IsRead, IsExported, Message);
                                            
        }

        private void _LoadNotifications()
        {

            _AllNotifications = clsNotification.AllNotifications();
            dgvNotifications.DataSource = _AllNotifications;
        }

        private void btnMarkAllRead_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Etes vous sure de mettre tous les notifications comme LU ?", "Cofirmer", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (clsNotification.MarAllkAsRead())
                {
                    MessageBox.Show("C'est terminé avec successé", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _LoadNotifications();
                }
                else
                    MessageBox.Show("Il y a Un probleme ", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void ctrlNotifications_Load(object sender, EventArgs e)
        {
            _LoadNotifications();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string ReadStatus = cbStatus.Text;
            string ExportStatus = cbExportStatus.Text;
            string Operator = (cbExportStatus.Text == "Tous" || cbStatus.Text == "Tous" ? "OR" : "AND");
            string Filter = "";
            if (cbExportStatus.Text != "Tous" || cbStatus.Text != "Tous")
                 Filter = string.Format("ReadStatus = '{0}' {1} Exportation = '{2}'", ReadStatus,Operator ,ExportStatus);

            _AllNotifications.DefaultView.RowFilter = Filter;

        }
    }
}
