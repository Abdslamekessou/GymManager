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

namespace GymManager.Presentation.Utilisateurs.Controls
{
    public partial class ucListeUtilisateurs : UserControl
    {
        public ucListeUtilisateurs()
        {
            InitializeComponent();
        }

        private static DataTable _dtAllUser;

        private void ucListeUtilisateurs_Load(object sender, EventArgs e)
        {
            _dtAllUser = clsUser.GetAllUser();
            dgvUsers.DataSource = _dtAllUser;

            cbxSearchBy.SelectedIndex = 0;
            cbxFilterRole.SelectedIndex = 0;


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

                dgvUsers.Columns[4].HeaderText = "Role";
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
            if (cbxSearchBy.Text == "None")
            {
                txtSearchValue.Visible = false;
                cbxFilterRole.Visible = false;
                return;
            }
            else if (cbxSearchBy.Text == "Role")
            {
                txtSearchValue.Text = "";
                txtSearchValue.Visible = false;
                cbxFilterRole.Visible = true;
                cbxFilterRole.Focus();
                cbxFilterRole.SelectedIndex = 0;
                return;
            }
            else
            {
                txtSearchValue.Visible = true;
                txtSearchValue.Focus();
                cbxFilterRole.Visible = false;
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
            ucListeUtilisateurs_Load(null, null);
        }

        private void tsmiAddUser_Click(object sender, EventArgs e)
        {
            frmAddUpdateUser frm = new frmAddUpdateUser();
            frm.ShowDialog();
            ucListeUtilisateurs_Load(null, null);
        }

        private void tsmiEditUser_Click(object sender, EventArgs e)
        {
            frmAddUpdateUser frm = new frmAddUpdateUser((int)dgvUsers.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            ucListeUtilisateurs_Load(null, null);
        }

        private void tsmiShowDetails_Click(object sender, EventArgs e)
        {
            frmDeatiles frm = new frmDeatiles((int)dgvUsers.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void tsmiActiver_Click(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow == null) return;

            int UserID = (int)dgvUsers.CurrentRow.Cells[0].Value;

            clsUser User = clsUser.Find(UserID);

            if (User == null) return;

            if (User.IsActive == true)
            {
                MessageBox.Show("Cet utilisateur est déjà activé.",
                  "Activation impossible",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Warning);

                return;
            }

            if (MessageBox.Show("Êtes-vous sûr de vouloir activer cet utilisateur ?",
                                "Confirmation de activation",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (clsUser.ActivateUser(UserID))
                {
                    MessageBox.Show("L'utilisateur a été activé avec succès.",
                                    "Désactivation réussie",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                    ucListeUtilisateurs_Load(null, null);
                }
                else
                {
                    MessageBox.Show("Une erreur est survenue lors de la activation de l'utilisateur.",
                                    "Échec de la activation",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
        }

        private void tsmiDesactiver_Click(object sender, EventArgs e)
        {
            string SelectedUserRoleName = (string)dgvUsers.CurrentRow.Cells[4].Value;

            if (clsUser.IsLastActiveAdmin() && SelectedUserRoleName == "Administrateur")
            {
                MessageBox.Show("Impossible de désactiver cet administrateur : il n'existe qu'un seul administrateur actif.",
                                     "Désactivation impossible",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Warning);
                return;
            }

            if (dgvUsers.CurrentRow == null) return;

            int UserID = (int)dgvUsers.CurrentRow.Cells[0].Value;

            clsUser User = clsUser.Find(UserID);

            if (User == null) return;

            if (User.IsActive == false)
            {
                MessageBox.Show("Cet utilisateur est déjà désactivé.",
                                "Désactivation impossible",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                return;
            }

            if (MessageBox.Show("Êtes-vous sûr de vouloir désactiver cet utilisateur ?",
                                "Confirmation de désactivation",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (clsUser.DesActivateUser(UserID))
                {
                    MessageBox.Show("L'utilisateur a été désactivé avec succès.",
                                    "Désactivation réussie",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                    ucListeUtilisateurs_Load(null, null);
                }
                else
                {
                    MessageBox.Show("Une erreur est survenue lors de la désactivation de l'utilisateur.",
                                    "Échec de la désactivation",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
        }

        private void changerLeMotDePasseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePassword frm = new frmChangePassword((int)dgvUsers.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void tsmiDeleteUser_Click(object sender, EventArgs e)
        {
            string SelectedUserRoleName = (string)dgvUsers.CurrentRow.Cells[4].Value;

            if (clsUser.IsLastActiveAdmin() && SelectedUserRoleName == "Administrateur")
            {
                MessageBox.Show("Impossible de supprimer cet administrateur : il n'existe qu'un seul administrateur actif.",
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
                    MessageBox.Show("L'utilisateur a été supprimé avec succès.", "Suppression réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ucListeUtilisateurs_Load(null, null);

                }
                else
                    MessageBox.Show("La suppression de l'utilisateur a echoue.", "Echouer", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void cmsUserOptions_Opening(object sender, CancelEventArgs e)
        {
            string Value = dgvUsers.CurrentRow.Cells[5].Value.ToString();

            if (Value == "Désactivé")
            {
                tsmiDesactiver.Visible = false;
                tsmiActiver.Visible = true;

            }
            else if (Value == "Activé")
            {
                tsmiDesactiver.Visible = true;
                tsmiActiver.Visible = false;

            }
        }

        private void dgvUsers_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                dgvUsers.ClearSelection();
                dgvUsers.Rows[e.RowIndex].Selected = true;
                dgvUsers.CurrentCell = dgvUsers.Rows[e.RowIndex].Cells[0];
            }
        }
    }
}
