using GymManager.Business;
using GymManager.Presentation.Global_Classes;
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

namespace GymManager.Presentation.Personnes
{
    public partial class frmAddUpdatePerson : Form
    {
        // Declare a delegate
        public delegate void DataBackEventHandler(object sender, int PersonID);

        // Declare an event using the delegate
        public event DataBackEventHandler DataBack;


        public enum enMode { AddNew = 0, Update = 1 };
        public enum enGendor { Male = 0, Female = 1 };

        private enMode Mode;

        private int PersonID = -1;
        private clsPerson Person;


        public frmAddUpdatePerson()
        {
            InitializeComponent();
            Mode = enMode.AddNew;

        }

        public frmAddUpdatePerson(int PersonID)
        {
            InitializeComponent();

            Mode = enMode.Update;
            this.PersonID = PersonID;
        }


        private void _ResetDefualtValues()
        {
            //this will initialize the reset the defaule values

            if (Mode == enMode.AddNew)
            {
                lblTitle.Text = "Ajouter une personne";
                Person = new clsPerson();
            }
            else
            {
                lblTitle.Text = "Modifier Une Personne";
                txtPersonID.Visible = true;
            }

            //set default image for the person.
            if ( rbMale.Checked == true )
                pbPhoto.Image = Resources.Male_512;
            else
                pbPhoto.Image = Resources.Female_512;


            //hide/show the remove linke incase there is no image for the person.
            btnRemovePhoto.Visible = (pbPhoto.ImageLocation != null);

            dtpDateOfBirth.Value = DateTime.Now;
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtPhone.Text = "";
            rbMale.Checked = true;
            txtPhone.Text = "";
            txtEmail.Text = "";


        }

        private void _LoadData()
        {

            Person = clsPerson.FindPerson(PersonID);

            if (Person == null)
            {
                MessageBox.Show("No Person with ID = " + PersonID, "Person Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }

            //the following code will not be executed if the person was not found
            txtPersonID.Text = PersonID.ToString();
            txtFirstName.Text = Person.FirstName;
            txtLastName.Text = Person.LastName;
            dtpDateOfBirth.Value = Person.DateOfBirth;

            if (Person.Gendor == 0)
                rbMale.Checked = true;
            else
                rbFemale.Checked = true;

            txtPhone.Text = Person.PhoneNumber;
            txtEmail.Text = Person.Email;


            //load person image incase it was set.
            if (Person.Image != "" && Person.Image != null)
            {
                pbPhoto.ImageLocation = Person.Image;

            }

            //hide/show the remove linke incase there is no image for the person.
            btnRemovePhoto.Visible = (Person.Image != "") && (Person.Image != null) ;

        }

        private bool _HandlePersonImage()
        {

            //this procedure will handle the person image,
            //it will take care of deleting the old image from the folder
            //in case the image changed. and it will rename the new image with guid and 
            // place it in the images folder.


            //_Person.ImagePath contains the old Image, we check if it changed then we copy the new image
            if (Person.Image != pbPhoto.ImageLocation)
            {
                if (Person.Image != "" && Person.Image != null)
                {
                    //first we delete the old image from the folder in case there is any.

                    try
                    {
                        File.Delete(Person.Image);
                    }
                    catch (IOException)
                    {
                        // We could not delete the file.
                        //log it later   
                    }
                }

                if (pbPhoto.ImageLocation != null)
                {
                    //then we copy the new image to the image folder after we rename it
                    string SourceImageFile = pbPhoto.ImageLocation.ToString();

                    if (clsUtil.CopyImageToProjectImagesFolder(ref SourceImageFile))
                    {
                        pbPhoto.ImageLocation = SourceImageFile;
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Error Copying Image File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }

            }
            return true;
        }

        private bool _Save()
        {
            Person.FirstName = txtFirstName.Text;
            Person.LastName = txtLastName.Text;
            Person.DateOfBirth = dtpDateOfBirth.Value;
            Person.Gendor = (byte)(rbMale.Checked ? 0 : 1);
            Person.Email = txtEmail.Text;
            Person.PhoneNumber = txtPhone.Text;


            // If ImageLocation is set it means PictureBox points to a file on disk
            // (user selected or loaded). Only copy the image into the application's
            // images folder when ImageLocation is non-null and different from the
            // already stored Person.ImagePath to avoid redundant copies.
            if ((pbPhoto.ImageLocation != null) && (Person.Image != pbPhoto.ImageLocation))
            {
                Guid g = Guid.NewGuid();

                string newPath = "";

                if (Path.HasExtension(pbPhoto.ImageLocation))
                {
                    newPath = Path.Combine(@"C:\GYM_People_Images", g.ToString() + Path.GetExtension(pbPhoto.ImageLocation));
                }
                else
                {
                    newPath = Path.Combine(@"C:\GYM_People_Images", g.ToString());

                }


                // Copy the currently displayed image file into our managed
                // storage folder so the app owns its own copy. This keeps the
                // original file untouched and gives us a stable path to save
                // in the Person record.
                File.Copy(pbPhoto.ImageLocation, newPath);


                // If the person already had an image path, delete the old file
                // to avoid accumulating unused files. Before deleting we dispose
                // the PictureBox Image to release any file lock the control may
                // be holding on that file. Note: disposing shared resource
                // images (from Properties.Resources) is dangerous; here we
                // only expect to dispose when the image was previously a file
                // managed by this application.
                if (Person.Image != "" && Person.Image != null)
                {
                    //var oldImage = pbPersonImage.Image;

                    //pbPersonImage.Image = newImage;

                    //oldImage?.Dispose();

                    // Delete the old photo
                    if (File.Exists(Person.Image))
                    {
                        // Dispose the current Image instance to release locks on
                        // the file before deleting it. Then remove it from the
                        // PictureBox and delete the file from disk.
                        pbPhoto.Image?.Dispose();
                        pbPhoto.Image = null;
                        File.Delete(Person.Image);
                    }

                }

                Person.Image = newPath;


            }
            else
            {
                // No new ImageLocation — check whether the person previously had
                // an image file but the PictureBox no longer points to it. This 
                // can happen when the user removed the image. If so, delete the
                // old image file and clear the Person.ImagePath so the DB no
                // longer references a missing file.
                if ((Person.Image != "") && (Person.Image != pbPhoto.ImageLocation))
                {
                    // Delete the old photo
                    if (File.Exists(Person.Image))
                    {
                        pbPhoto.Image?.Dispose();
                        pbPhoto.Image = null;
                        File.Delete(Person.Image);
                    }

                    Person.Image = null;
                }
            }



            if (Person.Save())
            {
                MessageBox.Show(
                    "Person added successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                pbPhoto.ImageLocation = Person.Image;
                Mode = enMode.Update;
                txtPersonID.Text = Person.PersonID.ToString();
                lblTitle.Text = "Modifier La Personne";

                return true;
            }
            else
            {
                MessageBox.Show(
                "Person was not added successfully.",
                "Failed",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                 );
                return false;
            }


        }





        private void frmAddUpdatePerson_Load(object sender, EventArgs e)
        {
            _ResetDefualtValues();

            if (Mode == enMode.Update)
                _LoadData();

        }

        private void btnSelectPhoto_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"C:\Users\ACER\Pictures";
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Save the chosen file path in Tag so we know this image came
                // from disk. Using `Load` sets ImageLocation which the saving
                // logic later checks to determine whether to copy the file.
                pbPhoto.Tag = openFileDialog1.FileName;
                pbPhoto.Load(openFileDialog1.FileName);
                btnRemovePhoto.Visible = true;
            }

        }

        private void btnRemovePhoto_Click(object sender, EventArgs e)
        {
            pbPhoto.ImageLocation = null;



            if (rbMale.Checked)
                pbPhoto.Image = Resources.Male_512;
            else
                pbPhoto.Image = Resources.Female_512;

            btnRemovePhoto.Visible = false;
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            //no need to validate the email incase it's empty.
            if (txtEmail.Text.Trim() == "")
                return;

        
            //validate email format
            if (!clsValidatoin.ValidateEmail(txtEmail.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtEmail, "Invalid Email Address Format!");
            }
            else
            {
                errorProvider1.SetError(txtEmail, null);
            }
            
        }

        private void ValidateEmptyTextBox(object sender, CancelEventArgs e)
        {
            // First: set AutoValidate property of your Form to EnableAllowFocusChange in designer 
            TextBox Temp = ((TextBox)sender);
            if (string.IsNullOrEmpty(Temp.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(Temp, "This field is required!");
            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(Temp, null);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            if (!_HandlePersonImage())
                return;


            Person.FirstName = txtFirstName.Text.Trim();
            Person.LastName = txtLastName.Text.Trim();
            Person.Email = txtEmail.Text.Trim();
            Person.PhoneNumber = txtPhone.Text.Trim();
            Person.DateOfBirth = dtpDateOfBirth.Value;

            if (rbMale.Checked)
                Person.Gendor = (byte)enGendor.Male;
            else
                Person.Gendor = (byte)enGendor.Female;


            if (pbPhoto.ImageLocation != null)
                Person.Image = pbPhoto.ImageLocation;
            else
                Person.Image = "";

            if (Person.Save())
            {
                txtPersonID.Visible = true;
                txtPersonID.Text = Person.PersonID.ToString();
                //change form mode to update.
                Mode = enMode.Update;
                lblTitle.Text = "Modifier La Personne";

                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);


                // Trigger the event to send data back to the caller form.
                DataBack?.Invoke(this, Person.PersonID);
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbMale_Click(object sender, EventArgs e)
        {
            //change the defualt image to male incase there is no image set.
            if (pbPhoto.ImageLocation == null)
                pbPhoto.Image = Resources.Male_512;
        }

        private void rbFemale_Click(object sender, EventArgs e)
        {
            //change the defualt image to female incase there is no image set.
            if (pbPhoto.ImageLocation == null)
                pbPhoto.Image = Resources.Female_512;
        }



    }


}
