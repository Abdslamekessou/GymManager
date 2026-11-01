using GymManager.Business;
using GymManager.Presentation.Global_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManager.Presentation
{
    public partial class frmListUser : Form
    {
        
        public frmListUser()
        {
            InitializeComponent();

            
        }

        private static DataTable _dtAllUser;

        private void frmListUser_Load(object sender, EventArgs e)
        {
            _dtAllUser = clsUser.GetAllUser();
            dgvUsers.DataSource = _dtAllUser;

            cbxSearchBy.SelectedIndex = 0;
            cbxFilterRole.SelectedIndex = 0;
            cbxFilterRole.Enabled = false;

            if (dgvUsers.Rows.Count > 0)
            {
                dgvUsers.Columns[0].HeaderText = "Utilisateur ID";
                dgvUsers.Columns[0].Width = 110;

                dgvUsers.Columns[1].HeaderText = "Personne ID";
                dgvUsers.Columns[1].Width = 110;

                dgvUsers.Columns[2].HeaderText = "Nom Complet";
                dgvUsers.Columns[2].Width = 300;

                dgvUsers.Columns[3].HeaderText = "Nom d'utilisateur";
                dgvUsers.Columns[3].Width = 110;

                dgvUsers.Columns[4].HeaderText = "NomRole";
                dgvUsers.Columns[4].Width = 110;

            }
        }

        private void txtSearchValue_TextChanged(object sender, EventArgs e)
        {
            string Filtercolumn = "";

            switch (cbxSearchBy.Text)
            {
                case "Utilisateur ID":
                    Filtercolumn = "UtilisateurID";
                    break;
                case "Nom complet":
                    Filtercolumn = "NomComplet";
                    break;
                case "Nom d'utilisateur":
                    Filtercolumn = "NomUtilisateur";
                    break;
                case "NomRole":
                    Filtercolumn = "NomRole";
                    break;

                default:
                    Filtercolumn = "None";
                    break;
            }

            if (txtSearchValue.Text.Trim() == "" || Filtercolumn == "None")
            {
                _dtAllUser.DefaultView.RowFilter = "";
                return;
            }

            if (Filtercolumn == "UtilisateurID")
            {
                _dtAllUser.DefaultView.RowFilter = string.Format("[{0}] = '{1}'", Filtercolumn, txtSearchValue.Text.Trim());
            }
            else
            {
                _dtAllUser.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", Filtercolumn, txtSearchValue.Text.Trim());
            }
        }

        private void txtSearchValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbxSearchBy.Text == "Utilisateur ID" || cbxSearchBy.Text == "Personne ID")
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void cbxSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxSearchBy.Text == "NomRole")
            {
                txtSearchValue.Text = "";
                txtSearchValue.Enabled = false;
                cbxFilterRole.Enabled = true;
                cbxFilterRole.Focus();
                cbxFilterRole.SelectedIndex = 0;
            }
            else
            {
                txtSearchValue.Enabled = true;
                txtSearchValue.Focus();
                cbxFilterRole.Enabled = false;
            }
        }

        private void cbxFilterRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterColumn = "NomRole";
            string FilterValue = cbxFilterRole.Text;

            switch (FilterValue)
            {
                case "Tous les rôles":
                    FilterValue = "Tous les rôles";
                    break;
                case "Admin":
                    FilterValue = "Administrateur";
                    break;
                case "Récep":
                    FilterValue = "Receptionniste";
                    break;
                default:
                    FilterValue = "Tous les rôles";
                    break;
            }

            if (FilterValue == "Tous les rôles")
            {
                _dtAllUser.DefaultView.RowFilter = "";
            }
            else
            {
                _dtAllUser.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, FilterValue);
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            frmAddUpdateUser frm = new frmAddUpdateUser();
            frm.ShowDialog();
            frmListUser_Load(null, null);
        }

        private void tsmiAddUser_Click(object sender, EventArgs e)
        {
            frmAddUpdateUser frm = new frmAddUpdateUser();
            frm.ShowDialog();
            frmListUser_Load(null, null);
        }

        private void tsmiShowDetails_Click(object sender, EventArgs e)
        {
            frmDeatiles frm = new frmDeatiles((int)dgvUsers.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void tsmiEditUser_Click(object sender, EventArgs e)
        {
            frmAddUpdateUser frm = new frmAddUpdateUser((int)dgvUsers.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            frmListUser_Load(null, null);
        }


        
      
        private void tsmiDeleteUser_Click(object sender, EventArgs e)
        {
            string SelectedUserRoleName =(string) dgvUsers.CurrentRow.Cells[4].Value;

            if(clsUser.IsLastActiveAdmin() && SelectedUserRoleName == "Administrateur")
            {
                MessageBox.Show("Vous ne pouvez pas supprimer le dernier administrateur actif.",
                              "Suppression impossible",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Warning);
                return;
            }


            if (MessageBox.Show("Etes-vous sur de vouloir supprimer l'utilisateur?", "Supprimer", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int UserID = (int)dgvUsers.CurrentRow.Cells[0].Value;

                clsUser User = clsUser.Find(UserID);

                if (User == null) return;


                bool IsDeleted = clsUser.DeleteUser(UserID);

                if (IsDeleted)
                {
                    MessageBox.Show("L'utilisateur a été supprimé avec succès." , "Suppression réussie",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmListUser_Load(null, null);
                }
                else
                    MessageBox.Show("La suppression de l'utilisateur a echoue.", "Echouer", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void changerLeMotDePasseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePassword frm = new frmChangePassword((int)dgvUsers.CurrentRow.Cells[0].Value);
            frm.ShowDialog();

        }

        

        private void tsmiActiver_Click(object sender, EventArgs e)
        {

        }

        private void tsmiDesactiver_Click(object sender, EventArgs e)
        {
            string SelectedUserRoleName = (string)dgvUsers.CurrentRow.Cells[4].Value;

            if (clsUser.IsLastActiveAdmin() && SelectedUserRoleName == "Administrateur"){ 
                MessageBox.Show("Vous ne pouvez pas désactiver le dernier administrateur actif.",
                                     "Désactivation impossible",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Warning);
                return;
            }
        }
    }
}
