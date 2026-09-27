using GymManager.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.Business
{
    public class clsPersonne
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int PersonneID { set; get; }
        public string Prenom { set; get; }
        public string Nom { set; get; }
        public string NomComplet 
        {
            get { return Nom + " " + Prenom; }
        }
        public string NumeroTelephone { set; get; }
        public string Email { set; get; }
        public DateTime DateDeNaissance { set; get; }
        public byte Genre { set; get; }
        public string _Image { set; get; }
        public string Image
        {
            get { return _Image; }
            set { _Image = value; }
        }




        public clsPersonne()
        {
            this.PersonneID = -1;
            this.Prenom = "";
            this.Nom = "";
            this.NumeroTelephone = "";
            this.Email = "";
            this.DateDeNaissance = DateTime.Now;
            this.Image = "";

            Mode = enMode.AddNew;
        }

        private clsPersonne(int PersonneID, string Prenom, string Nom, string NumeroTelephone,
            string Email, DateTime DateDeNaissance, byte Genre, string Image)
        {
            this.PersonneID = PersonneID;
            this.Prenom = Prenom;
            this.Nom = Nom;
            this.NumeroTelephone = NumeroTelephone;
            this.Email = Email;
            this.DateDeNaissance = DateDeNaissance;
            this.Genre = Genre;
            this.Image = Image;

            Mode = enMode.Update;
        }





        public static DataTable GetAllPersonnes()
        {
            return clsPersonneData.GetAllPersonnes();
        }


    }



}
