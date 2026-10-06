using Globla_Classes;
using GymManager.Business;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;

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
                _LastRowIndex = e.RowIndex;
                clsNotification Notification = _FillNotificationInfo(e.RowIndex);
                frmNotificationDetailsTest frm = new frmNotificationDetailsTest(Notification);
                frm.NotificationMarkedAsRead += Frm_NotificationMarkedAsReadChangeMessage;
                frm.ShowDialog();
                btnSearch.PerformClick();
            }

        }

        private void Frm_NotificationMarkedAsReadChangeMessage(clsNotification Notification)
        {
            if (Notification.IsRead)
            {
                _AllNotifications.Columns["Lu Status"].ReadOnly = false;
                _AllNotifications.Rows[_LastRowIndex]["Lu Status"] = "Lu";
                _AllNotifications.Columns["Lu Status"].ReadOnly = true;
            }

            _AllNotifications.Columns["Message"].ReadOnly = false;
            _AllNotifications.Rows[_LastRowIndex]["Message"] = Notification.Message;
            _AllNotifications.Columns["Message"].ReadOnly = true;
        }

        private void _MarkAsReadHandler(int RowIndex)
        {
            if (clsNotification.MarkAsRead(Convert.ToInt32(_AllNotifications.Rows[RowIndex]["NotificationID"])))
            {
                _AllNotifications.Columns["Lu Status"].ReadOnly = false;
                _AllNotifications.Rows[RowIndex]["Lu Status"] = "Lu";
                _AllNotifications.Columns["Lu Status"].ReadOnly = true;
                dgvNotifications.DataSource = _AllNotifications;

            }
        }

        private clsNotification _FillNotificationInfo(int RowIndex)
        {
            int ID = (int)_AllNotifications.Rows[RowIndex]["NotificationID"];
            string MemberName = _AllNotifications.Rows[RowIndex]["Adhérent"].ToString();
            string Phone = _AllNotifications.Rows[RowIndex]["Numéro de Téléphone"].ToString();
            string Sport = _AllNotifications.Rows[RowIndex]["Sport"].ToString();
            string SubscriptionType = _AllNotifications.Rows[RowIndex]["Type d'Abonnement"].ToString();
            DateTime DateDebut = ((DateTime)_AllNotifications.Rows[RowIndex]["DateDebut"]).Date;
            DateTime DateFin = ((DateTime)_AllNotifications.Rows[RowIndex]["DateFin"]).Date;
            string AbonnementStatus = _AllNotifications.Rows[RowIndex]["Status d'Abonnement"].ToString();
            bool IsRead = _AllNotifications.Rows[RowIndex]["Lu Status"].ToString() == "Lu";
            bool IsExported = _AllNotifications.Rows[RowIndex]["Exportation"].ToString() == "Exporté";
            string Message = _AllNotifications.Rows[RowIndex]["Message"].ToString();

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
            //Get the original Notifications Data
            _LoadNotifications();

            string ReadStatus = cbStatus.Text;
            string ExportStatus = cbExportStatus.Text;
            string Operator = (cbExportStatus.Text == "Tous" || cbStatus.Text == "Tous" ? "OR" : "AND");
            string Filter = "";
            if (cbExportStatus.Text != "Tous" || cbStatus.Text != "Tous")
                Filter = string.Format("[Lu Status] = '{0}' {1} Exportation = '{2}'", ReadStatus, Operator, ExportStatus);

            _AllNotifications.DefaultView.RowFilter = Filter;
            _AllNotifications = _AllNotifications.DefaultView.ToTable();

        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (fbdExportExcel.ShowDialog() == DialogResult.OK)
            {
                string FileName = GenerateFileName();
                string FolderPath = fbdExportExcel.SelectedPath;
                string FullPath = Path.Combine(FolderPath, FileName);

                if (clsNotification.MakeNotificationsAsExported(GetNotificationsIDs(_AllNotifications)))
                {
                    if (clsUtil.GenerateAndSaveExcelFile(_AllNotifications, FullPath))
                    {
                        MessageBox.Show("Le fichier excel est sauvegadé ");
                        _LoadNotifications();
                    }
                    else
                        MessageBox.Show("Le fichier excel n'est pas sauvegadé ");
                }
                else
                    MessageBox.Show("Le fichier excel n'est pas sauvegadé ");



            }

        }

        private List<int> GetNotificationsIDs(DataTable dt)
        {
            List<int> ids = new List<int>();
            foreach (DataRow row in dt.Rows)
            {
                ids.Add((int)row["NotificationID"]);
            }
            return ids;
        }

        private string GenerateFileName()
        {

            string fileName = "Notifications";
            if (cbStatus.SelectedText != "Tous")
                fileName += "_" + cbStatus.Text;


            if (cbExportStatus.SelectedText != "Tous")
                fileName += "_" + cbExportStatus.Text;

            fileName += "_" + DateTime.Now.ToString("dd-MM-yyyy") + ".xlsx";

            return fileName;

        }
    }
}
