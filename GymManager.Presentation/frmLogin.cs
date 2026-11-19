using Globla_Classes;
using GymManager.Business;
using GymManager.Presentation.Global_Classes;
using System;
using System.Windows.Forms;

namespace GymManager.Presentation
{
    public partial class frmLogin : Form
    {
        private clsUser _User = new clsUser();

        public frmLogin()
        {
            InitializeComponent();
            txtUsername.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Admin
            txtUsername.Text = "user1";
            txtPassword.Text = "hocine2004";

            //Recepcioniste
            //txtUsername.Text = "user2";
            //txtPassword.Text = "hocine2004";
            _User = clsUser.FindByUserName(txtUsername.Text);

            if (_User == null)
            {
                MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect.", "Erreur de connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
                return;
                
            }


            if (!_User.IsActive)
            {
                MessageBox.Show("Votre compte n'est pas actif, Contactez votre administrateur.", "Compte Inactif", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
           

            if (!clsUtil.VerifyPassword(txtPassword.Text , _User.Password))
            {
                MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect.", "Erreur de connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            clsGlobal.CurrentUser = _User;
            this.Hide();
            MainForm frm = new MainForm();
            frm.Show();


        }

       
    }
}
