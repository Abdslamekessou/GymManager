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

namespace GymManager.Presentation.Personnes.Controls
{
    public partial class ucPersonCard : UserControl
    {
        private clsPerson _Person;

        private int _PersonID = -1;

        public int PersonID
        {
            get { return _PersonID; }
        }

        public clsPerson SelectedPersonInfo
        {
            get { return _Person; }
        }

        public ucPersonCard()
        {
            InitializeComponent();
        }

        public void LoadPersonInfo(int PersonID)
        {
            _Person = clsPerson.FindPerson(PersonID);

            if (_Person == null)
            {
                ResetPersonInfo();
                MessageBox.Show("No Person with PersonID = " + PersonID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillPersonInfo();
        }

  

        private void _LoadPersonImage()
        {
            if (_Person.Gendor == 0)
                pbPersonImage.Image = Resources.Male_512;
            else
                pbPersonImage.Image = Resources.Female_512;
            
            string ImagePath = _Person.Image;

            if (ImagePath != "" && ImagePath != null )
            {
                if (File.Exists(ImagePath))
                    pbPersonImage.ImageLocation = ImagePath;
                else
                    MessageBox.Show("Could not find this image: = " + ImagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


        private void _FillPersonInfo()
        {
            btnEditPerson.Enabled = true;
            _PersonID = _Person.PersonID;
            lblPersonID.Text = _Person.PersonID.ToString();
            lblFullName.Text = _Person.FullName;
            lblPhone.Text = _Person.PhoneNumber;
            lblEmail.Text = _Person.Email;
            lblDateOfBirth.Text = _Person.DateOfBirth.ToString();
            lblGender.Text = _Person.Gendor == 0 ? "Male" : "Female";
            pbPersonImage.Image = (_Person.Gendor == 0) ? Resources.Male_512 : Resources.Female_512;

            _LoadPersonImage();



        }

        public void ResetPersonInfo()
        {
            _PersonID = -1;
            lblPersonID.Text = "[????]";
            lblFullName.Text = "[????]";
            lblPhone.Text = "[????]";
            lblEmail.Text = "[????]";
            lblDateOfBirth.Text = "[????]";
            lblGender.Text = "[????]";
            pbPersonImage.Image = Resources.Male_512;

        }



        private void btnEditPerson_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson frmAddUpdatePerson = new frmAddUpdatePerson(_Person.PersonID);


            frmAddUpdatePerson.ShowDialog();

            LoadPersonInfo(_Person.PersonID);
        }

        private void ucPersonCard_Load(object sender, EventArgs e)
        {

        }
    }


}
