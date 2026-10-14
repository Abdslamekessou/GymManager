using GymManager.Business;
using GymManager.Presentation.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManager.Presentation
{
    public partial class frmDeatiles : Form
    {
        private int _UserID = -1;

        clsUser _User;

        public frmDeatiles(int UserID)
        {
            InitializeComponent();

            _UserID = UserID;
        }

        private void LoadData()
        {
            _User = clsUser.Find(_UserID);

            if (_User == null)
            {
                ResetUserInfo();
                MessageBox.Show("Utilisateur non trouvé.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            FillUserInfo();
        }

        public void ResetUserInfo()
        {
            lblIDPersonneVal.Text = "[????]";
            lblNomVal.Text = "[????]";
            lblTelephoneVal.Text = "[????]";
            lblEmailVal.Text = "[????]";
            lblBirthDateVal.Text = "[????]";
            lblGenreVal.Text = "[????]";

            lblUsernameVal.Text = "[????]";
            lblRoleVal.Text = "[????]";
            lblStatusVal.Text = "[????]";
            lblIDUtilisateurVal.Text = "[????]";
            pbUserImage.Image = Resources.Male_512;

        }

        private void FillUserInfo()
        {
            lblIDPersonneVal.Text = _User.PersonInfo.PersonID.ToString();
            lblNomVal.Text = _User.PersonInfo.FullName;
            lblTelephoneVal.Text = _User.PersonInfo.PhoneNumber;
            lblEmailVal.Text = _User.PersonInfo.Email;
            lblBirthDateVal.Text = _User.PersonInfo.DateOfBirth.ToShortDateString();
            lblGenreVal.Text = _User.PersonInfo.Gendor  == 0 ? "Male" : "Female";

            lblUsernameVal.Text = _User.UserName;
            lblRoleVal.Text = _User.RoleInfo.RoleName;
            lblStatusVal.Text = _User.IsActive ? "Active" : "Inactive";
            lblIDUtilisateurVal.Text = _UserID.ToString();

            LoadPersonImage();
        }

        private void LoadPersonImage()
        {
            if (_User.PersonInfo.Gendor == 0)
                pbUserImage.Image = Resources.Male_512;
            else
                pbUserImage.Image = Resources.Female_512;

            string ImagePath = _User.PersonInfo.Image;

            if (ImagePath != "" && ImagePath != null)
            {
                if (File.Exists(ImagePath))
                    pbUserImage.ImageLocation = ImagePath;
                else
                    MessageBox.Show("Could not find this image: = " + ImagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmDeatiles_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
