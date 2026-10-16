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
    public partial class frmChangePassword : Form
    {
        private int _UserID = -1;

        private clsUser _User;
        public frmChangePassword(int UserID)
        {
            InitializeComponent();

            _UserID = UserID;
        }

        private void _ResetDefualtValues()
        {
            txtCurrentPassword.Text = "";
            txtNewPassword.Text = "";
            txtConfirmPassword.Text = "";
            txtCurrentPassword.Focus();
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            _ResetDefualtValues();

            _User = clsUser.Find(_UserID);

            if (_User == null)
            {
                MessageBox.Show("Utilisateur Non Trouvé", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            lblFullNameValue.Text = _User.PersonInfo.FullName;
            lblUsernameValue.Text = _User.UserName;
        }

        private void txtCurrentPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtCurrentPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtCurrentPassword, "Le mot de passe actuel ne peut pas être vide");
                return;
            }
            else
            {
                errorProvider1.SetError(txtCurrentPassword, null);
            }

            string CurrentPassword = clsUtil.ComputeHash(txtCurrentPassword.Text.Trim());

            if (_User.Password != CurrentPassword)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtCurrentPassword, "Le mot de passe actuel est incorrect");
            }
            else
            {
                errorProvider1.SetError(txtCurrentPassword, null);
            }

        }

        private void txtNewPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNewPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNewPassword, "Le mot de passe actuel ne peut pas être vide");
                return;
            }
            else
            {
                errorProvider1.SetError(txtConfirmPassword, null);
            }
        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (txtConfirmPassword.Text.Trim() != txtNewPassword.Text.Trim())
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfirmPassword, "La confirmation du mot de passe ne correspond pas au nouveau mot de passe!");

            }
            else
            {
                errorProvider1.SetError(txtConfirmPassword, null);
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Des champs ne sont pas valides! Passez la souris sur les icones rouges pour voir les erreurs.",
                    "Erreur de Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string NewPasswoed = clsUtil.ComputeHash(txtNewPassword.Text.Trim());

            //_User.Password = txtNewPassword.Text;
            _User.Password = NewPasswoed;

            if (_User.Save())
            {
                MessageBox.Show("Mot de passe modifié avec succès.",
                   "Enregistré .", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _ResetDefualtValues();

            }
            else
            {
                MessageBox.Show("Une erreur est survenue, le mot de passe n'a pas été modifié.",
                   "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
