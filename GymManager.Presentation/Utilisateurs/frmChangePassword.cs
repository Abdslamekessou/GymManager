using GymManager.Business;
using GymManager.Presentation.Global_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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

        public frmChangePassword()
        {
            InitializeComponent();
        }

        private void _ResetDefualtValues()
        {
            
            txtNewPassword.Text = "";
            txtConfirmPassword.Text = "";
            txtNewPassword.Focus();
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

            if (clsGlobal.CurrentUser.RoleInfo.RoleName != "Administrateur") //System.NullReferenceException: 'La référence d'objet n'est pas définie à une instance d'un objet.'
            {
                MessageBox.Show("Vous n'êtes pas administrateur, vous ne pouvez pas modifier le mot de passe.",
                                     "Accès refusé",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Error);
                this.Close();
                return;
            }


            lblFullNameValue.Text = _User.PersonInfo.FullName;
            lblUsernameValue.Text = _User.UserName;
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
                errorProvider1.SetError(txtNewPassword, null);
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
            if(clsGlobal.CurrentUser.RoleInfo.RoleName != "Administrateur")
            {
                MessageBox.Show("Vous n'avez pas accès à cette fonctionnalité.",
                                "Accès refusé",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

                return;
            }

            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Des champs ne sont pas valides! Passez la souris sur les icones rouges pour voir les erreurs.",
                    "Erreur de Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(txtNewPassword.Text.Length < 8)
            {
                MessageBox.Show(
                         "Le mot de passe doit contenir au moins 8 caractères.",
                         "Mot de passe invalide",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Warning);

                return;
            }

           

            string NewPassword = clsUtil.HashPassword(txtNewPassword.Text.Trim());

           

           

            if (clsUser.ChangePassword(_User.UserID , NewPassword))
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
