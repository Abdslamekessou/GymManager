using Globla_Classes;
using GymManager.Business;
using GymManager.Presentation.Global_Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace GymManager.Presentation.Notifications
{
    public partial class ctrlNotifications : UserControl
    {

        // Create a delegate for the notification
        public delegate void NotificationCountTrackingHandler(bool IsAllRead);

        public event NotificationCountTrackingHandler NotificationCount;


        static DataTable _AllNotifications = clsNotification.AllNotifications();
        int _LastRowIndex = -1;
        public ctrlNotifications()
        {
            InitializeComponent();
            BuildUI();
            dgvNotifications.AutoGenerateColumns = false;
            cbStatus.SelectedIndex = 0;
            cbExportStatus.SelectedIndex = 0;
            dgvNotifications.CellContentClick += DgvNotifications_CellContentClick;

            //
            if (clsGlobal.CurrentUser.RoleID == 1)
            {
                btnExport.Enabled = false;
                btnMarkAllRead.Enabled = false;
                dgvNotifications.Enabled = false;
            }


        }

        private void BuildUI()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(23, 32, 51);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(226, 232, 240);
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(23, 32, 51);

            dgvNotifications.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            //-------------------------------------------------------
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();

            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(16, 26, 45);
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(16, 26, 45);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;

            dgvNotifications.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;

            //--------------------------------------------------------------------------------
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();

            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(23, 32, 51);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(226, 232, 240);
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(23, 32, 51);
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;

            dgvNotifications.DefaultCellStyle = dataGridViewCellStyle4;
            //-----------------------------------------------------
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();

            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(16, 26, 45);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(226, 232, 240);
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(16, 26, 45);

            colMarkAsRead.DefaultCellStyle = dataGridViewCellStyle3;
            colDetails.DefaultCellStyle = dataGridViewCellStyle3;


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
                    NotificationCount?.Invoke(false);


                }
            }
            //Clicking on the "Details" Cell
            if (e.ColumnIndex == colDetails.Index)
            {
                _LastRowIndex = e.RowIndex;
                clsNotification Notification = _FillNotificationInfo(e.RowIndex);
                frmNotificationDetailsTest frm = new frmNotificationDetailsTest(Notification);
                frm.NotificationMarkedAsRead += Frm_NotificationMarkedAsRead;
                frm.ShowDialog();
                btnSearch.PerformClick();
            }

        }

        private void Frm_NotificationMarkedAsRead(clsNotification Notification)
        {
            if (Notification.IsRead)
            {
                _AllNotifications.Columns["Lu Status"].ReadOnly = false;
                _AllNotifications.Rows[_LastRowIndex]["Lu Status"] = "Lu";
                _AllNotifications.Columns["Lu Status"].ReadOnly = true;
                NotificationCount?.Invoke(false);

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
                    NotificationCount?.Invoke(true);

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
                    DataTable dt = _AllNotifications.DefaultView.ToTable(false, "Adhérent", "Numéro de Téléphone", "Sport", "Type d'Abonnement", "DateDebut", "DateFin", "Status d'Abonnement", "Message");
                    if (clsUtil.GenerateAndSaveExcelFile(dt, FullPath))
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
