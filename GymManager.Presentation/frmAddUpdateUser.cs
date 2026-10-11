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
    public partial class frmAddUpdateUser : Form
    {
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        private int _UserID = -1;
        private clsUser _User = new clsUser();

        public frmAddUpdateUser()
        {
            InitializeComponent();

            _Mode = enMode.AddNew;
        }

        public frmAddUpdateUser(int UserID)
        {
            InitializeComponent();

            _UserID = UserID;
            _Mode = enMode.Update;
        }

        private void _ResetDefualtValues()
        {
            if (_Mode == enMode.AddNew)
            {
                this.Text = "Ajouter pqr Utilisateur";
                _User = new clsUser();

                gbUserInfo.Enabled = false;
                btnSave.Enabled = false;
                ucPersonCardWithFilter1.FilterFocus();
            }
            else
            {
                this.Text = "Mise à jour Utilisateur";

                gbUserInfo.Enabled = true;
                btnSave.Enabled = true;

            }

            txtUsername.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
            cbxRole.SelectedIndex = 0;
            chkIsActive.Checked = true;
        }

        private void _LoadData()
        {
            _User = clsUser.Find(_UserID);
            ucPersonCardWithFilter1.FilterEnabled = false;

            if (_User == null)
            {
                MessageBox.Show("No Utilisateur with UtilisateurID = " + _UserID, "UtilisateurID Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();

                return;
            }

            txtUsername.Text = _User.UserName;
            txtPassword.Text = _User.Password;
            txtConfirmPassword.Text = _User.Password;
            chkIsActive.Checked = _User.IsActive;
            cbxRole.Text = _User.RoleInfo.RoleName;
            ucPersonCardWithFilter1.LoadPersonInfo(_User.PersonID);
        }

        private void frmAddUpdateUser_Load(object sender, EventArgs e)
        {
            _ResetDefualtValues();

            if (_Mode == enMode.Update)
                _LoadData();
        }

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtUsername.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtUsername, "Nom d'utilisateur est requis.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtUsername, "");
            }

            if (_Mode == enMode.AddNew) 
            {
                if (clsUser.IsUserExists(txtUsername.Text.Trim()))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txtUsername, "Nom d'utilisateur existe déjà.");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(txtUsername, null);
                }
            } 
            else
            {
                if (_User.UserName != txtUsername.Text.Trim())
                {
                   if(clsUser.IsUserExists(txtUsername.Text))
                   {
                        e.Cancel = true;
                        errorProvider1.SetError(txtUsername, "Nom d'utilisateur existe déjà.");
                        return;
                   }
                   else
                   {
                        e.Cancel = false;
                        errorProvider1.SetError(txtUsername, null);
                   }
                }
            } 
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPassword, "Mot de passe est requis.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtPassword, "");
            }
        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if(txtConfirmPassword.Text.Trim() != txtPassword.Text.Trim())
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfirmPassword, "Mot de passe ne correspond pas.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtConfirmPassword, "");
            }
        }

        private void frmAddUpdateUser_Activated(object sender, EventArgs e)
        {
            ucPersonCardWithFilter1.FilterFocus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!ValidateChildren())
            {
                MessageBox.Show("Veuillez corriger les erreurs avant de continuer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string Password = clsUtil.ComputeHash(txtPassword.Text.Trim());

            _User.PersonID = ucPersonCardWithFilter1.PersonID;
            _User.UserName = txtUsername.Text.Trim();
            _User.Password = Password;
            _User.IsActive = chkIsActive.Checked;
            _User.RoleID = (cbxRole.SelectedItem?.ToString() == "Admin") ? 1 : 2;

            if (cbxRole.SelectedItem?.ToString() == "Admin" && clsUser.IsAdminExists(cbxRole.SelectedItem.ToString()))
            {
                MessageBox.Show("Le rôle 'Admin' existe déjà. Veuillez choisir un autre rôle.", "Erreur de rôle", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_User.Save())
            {
                _Mode = enMode.Update;
                this.Text = "Mise à jour Utilisateur";

                MessageBox.Show("Utilisateur enregistré avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gbUserInfo.Enabled = false;
                btnSave.Enabled = false;
                ucPersonCardWithFilter1.Enabled = false;
            }
            else
            {
                MessageBox.Show("Erreur lors de l'enregistrement de l'utilisateur.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucPersonCardWithFilter1_OnPersonSelected(int obj)
        {
            int PersonID = obj;

            if(_Mode == enMode.Update)
            {
                btnSave.Enabled = true;
                gbUserInfo.Enabled = true;
                return;
            }

            if(PersonID != -1)
            {
                if (clsUser.IsUserExistedForPerson(PersonID))
                {
                    MessageBox.Show("Un utilisateur existe déjà pour cette personne. Veuillez choisir une autre personne.", "Erreur de personne", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // ucPersonCardWithFilter1.ClearPersonInfo();
                    gbUserInfo.Enabled = false;
                    btnSave.Enabled = false;
                }
                else
                {
                    gbUserInfo.Enabled = true;
                    btnSave.Enabled = true;
                }
            }
            else
            {
                gbUserInfo.Enabled = false;
                btnSave.Enabled = false;
            }
        }

    }
}
