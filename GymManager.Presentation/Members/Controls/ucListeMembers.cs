using GymManager.Business;
using GymManager.Presentation.Personnes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManager.Presentation.Members.Controls
{
    public partial class ucListeMembers : UserControl
    {
        private static DataTable _dtAllMembers = clsMember.GetAllMembers();

        public ucListeMembers()
        {
            InitializeComponent();

            BuildUI();
        }

        // ===============================================================================
        private void BuildUI()
        {

            dgvMembers.AutoGenerateColumns = false;


            // MemberID
            colMemberID.HeaderText = "MemberID";
            colMemberID.Name = "colMemberID";
            colMemberID.DataPropertyName = "AdherentID";
            colMemberID.Visible = false;

            // Full Name
            colFullName.HeaderText = "Nom";
            colFullName.Name = "colFullName";
            colFullName.DataPropertyName = "NomComplet";
            colFullName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // Phone Number
            colPhoneNumber.HeaderText = "Téléphone";
            colPhoneNumber.Name = "colPhoneNumber";
            colPhoneNumber.DataPropertyName = "NumeroTelephone";
            colPhoneNumber.Width = 120;

            // Email
            colEmail.HeaderText = "Email";
            colEmail.Name = "colEmail";
            colEmail.DataPropertyName = "Email";
            colEmail.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // Gender
            colGendor.HeaderText = "Genre";
            colGendor.Name = "colGendor";
            colGendor.DataPropertyName = "GendorCaption";
            colGendor.Width = 90;

            // Details
            colMemberDetails.HeaderText = "Details";
            colMemberDetails.Name = "colMemberDetails";
            colMemberDetails.Text = "Voir Détails";
            colMemberDetails.UseColumnTextForButtonValue = true;

            // Update
            colUpdateMember.HeaderText = "Modifier";
            colUpdateMember.Name = "colUpdateMember";
            colUpdateMember.Text = "Modifier";
            colUpdateMember.UseColumnTextForButtonValue = true;
            colUpdateMember.Width = 100;

            // Manage Subscriptions
            colManagesubscriptions.HeaderText = "Abonnements";
            colManagesubscriptions.Name = "colManagesubscriptions";
            colManagesubscriptions.Text = "Gérer";
            colManagesubscriptions.UseColumnTextForButtonValue = true;
            colManagesubscriptions.Width = 100;
        }

        // ===============================================================================


        private void _RefreshListMembers()
        {
            _dtAllMembers = clsMember.GetAllMembers();
            dgvMembers.DataSource = _dtAllMembers;
        }

        private void ucListeMembers_Load(object sender, EventArgs e)
        {
            _RefreshListMembers();

            cbMemberFilterBy.SelectedIndex = 0;
            txtSearchMember.Visible = false;
            cmbGender.SelectedIndex = 0;
        }

        private void _ApplyFilters()
        {
            if (_dtAllMembers == null)
                return;

            _dtAllMembers.DefaultView.RowFilter = _GenerateMemberSearchFilter() + " AND " + _GenerateGenderFilter();
        }

        private string _GenerateMemberSearchFilter()
        {
            string filterColumn = "";

            switch (cbMemberFilterBy.SelectedItem.ToString())
            {
                case "Nom":
                    filterColumn = "NomComplet";
                    break;
                case "Phone":
                    filterColumn = "NumeroTelephone";
                    break;
                case "Email":
                    filterColumn = "Email";
                    break;
                default:
                    break;
            }

            if (filterColumn == "" || txtSearchMember.Text.Trim() == "")
            {
                _dtAllMembers.DefaultView.RowFilter = string.Empty;
                return "1=1";
            }

            return string.Format("{0} LIKE '{1}%'", filterColumn, txtSearchMember.Text);

        }

        private string _GenerateGenderFilter()
        {
            if (cmbGender.SelectedItem.ToString() == "Tous")
            {
                return "1=1";
            }
            else
            {
                return $"[GendorCaption] = '{cmbGender.Text}'";
            }

        }

        private void cbMemberFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMemberFilterBy.SelectedItem.ToString() == "Aucun")
            {
                txtSearchMember.Visible = false;
            }
            else
            {
                txtSearchMember.Visible = true;
                txtSearchMember.Text = "";
            }

        }



        private void txtSearchMember_TextChanged(object sender, EventArgs e)
        {
            _ApplyFilters();
        }

        private void cmbGender_SelectedIndexChanged(object sender, EventArgs e)
        {


            _ApplyFilters();

        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            frmAddUpdateMember frm = new frmAddUpdateMember();

            frm.ShowDialog();
        }

        private void AddNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateMember frm = new frmAddUpdateMember();

            frm.ShowDialog();
        }

        private void UpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateMember frm = new frmAddUpdateMember((int)dgvMembers.CurrentRow.Cells[0].Value);
            frm.ShowDialog();

            _RefreshListMembers();
        }


        private int _GetSelectedMemberIdOfTheSelectedRow()
        {

            int selectedMemberID = (int)_dtAllMembers.Rows[dgvMembers.CurrentRow.Index]["AdherentID"];

            return selectedMemberID;
        }

        private void dgvMembers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ignore header clicks
            if (e.RowIndex < 0)
                return;

            int memberID = Convert.ToInt32(
                dgvMembers.Rows[e.RowIndex].Cells["colMemberID"].Value
            );

            switch (dgvMembers.Columns[e.ColumnIndex].Name)
            {
                case "colUpdateMember":

                    frmAddUpdateMember frm = new frmAddUpdateMember(memberID);
                    frm.ShowDialog();
                    _RefreshListMembers();

                    break;

                case "colMemberDetails":

                    frmShowMemberInfo frm1 = new frmShowMemberInfo(memberID);
                    frm1.ShowDialog();
                    _RefreshListMembers();

                    break;

                case "colManagesubscriptions":

                    MessageBox.Show("Not implemented yet !!!");
                    break;
            }



        }






    }
}
