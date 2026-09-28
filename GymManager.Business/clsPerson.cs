using GymManager.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.Business
{
    public class clsPerson
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int PersonID { set; get; }
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string FullName 
        {
            get { return LastName + " " + FirstName; }
        }
        public string PhoneNumber { set; get; }
        public string Email { set; get; }
        public DateTime DateOfBirth { set; get; }
        public byte Gendor { set; get; }
        public string _Image { set; get; }
        public string Image
        {
            get { return _Image; }
            set { _Image = value; }
        }




        public clsPerson()
        {
            this.PersonID = -1;
            this.FirstName = "";
            this.LastName = "";
            this.PhoneNumber = "";
            this.Email = "";
            this.DateOfBirth = DateTime.Now;
            this.Image = "";

            Mode = enMode.AddNew;
        }

        private clsPerson(int PersonID, string FirstName, string LastName, string PhoneNumber,
            string Email, DateTime DateOfBirth, byte Gendor, string Image)
        {
            this.PersonID = PersonID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.PhoneNumber = PhoneNumber;
            this.Email = Email;
            this.DateOfBirth = DateOfBirth;
            this.Gendor = Gendor;
            this.Image = Image;

            Mode = enMode.Update;
        }

        private bool _AddNewPerson()
        {
            this.PersonID = clsPersonData.AddNewPerson(this.FirstName , this.LastName , this.PhoneNumber, this.Email , this.DateOfBirth , this.Gendor , this.Image);

            return PersonID != -1;
        }


        private bool _UpdatePerson()
        {
            return clsPersonData.UpdatePerson(this.PersonID, this.FirstName, this.LastName, this.PhoneNumber, this.Email, this.DateOfBirth, this.Gendor, this.Image);
        }


        public static clsPerson FindPerson(int ID)
        {
            string FirstName = "", LastName = "", PhoneNumber = "", Email = "", Image = ""; 
            byte Gendor = 0;
            DateTime DateOfBirth = DateTime.Now;



            if ( clsPersonData.FindPerson( ID, ref  FirstName, ref  LastName, ref  PhoneNumber, ref  Email, ref  DateOfBirth, ref  Gendor, ref  Image) )
                return new clsPerson(ID, FirstName,  LastName,  PhoneNumber,  Email,  DateOfBirth,  Gendor,  Image);
            else
                return null;
        }


        public static bool isPersonExist(int ID)
        {
            return clsPersonData.isPersonExist(ID);
        }



        public static DataTable GetAllPersons()
        {
            return clsPersonData.GetAllPersons();
        }


    }



}
