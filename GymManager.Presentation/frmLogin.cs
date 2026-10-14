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
    public partial class frmLogin : Form
    {
        private clsUser _User = new clsUser();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string HashedPassword = clsUtil.ComputeHash(txtPassword.Text); 


            _User = clsUser.FindByUserNameAndPassword(txtUsername.Text, HashedPassword);

            if (_User != null)
            {
                if (!_User.IsActive)
                {
                    MessageBox.Show("Votre compte n'est pas actif, Contactez votre administrateur.", "Compte Inactif", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                clsGlobal.CurrentUser = _User;
                this.Hide();
                frmListUser frm = new frmListUser(this);
                frm.ShowDialog();
                //Add Parameter to MainForm constructor 
            }
            else
            {
                MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect.", "Erreur de connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
                txtPassword.Clear();
            }
        }
    }
}
