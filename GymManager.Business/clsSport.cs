using GymManager.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.Business
{
    public class clsSport
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int SportID { set; get; }
        public string Nom { set; get; }
        public string Description { set; get; }
        public bool EstActif { set; get; }

        public clsSport()
        {
            this.SportID = -1;
            this.Nom = "";
            this.Description = "";
            this.EstActif = true;

            Mode = enMode.AddNew;
        }

        private clsSport(int sportID, string nom,
            string description, bool estActif)
        {
            this.SportID = sportID;
            this.Nom = nom;
            this.Description = description;
            this.EstActif = estActif;

            Mode = enMode.Update;
        }

        private bool _AddNewSport()
        {
            this.SportID = clsSportDataAccess.AddNewSport(
                this.Nom,
                this.Description,
                this.EstActif
            );

            return (this.SportID != -1);
        }

        private bool _UpdateSport()
        {
            return clsSportDataAccess.UpdateSport(
                this.SportID,
                this.Nom,
                this.Description,
                this.EstActif
            );
        }

        public static clsSport Find(int SportID)
        {
            string nom = "", description = "";
            bool estActif = false;

            if (clsSportDataAccess.GetSportByID(SportID, ref nom, ref description, ref estActif))
            {
                return new clsSport(SportID, nom, description, estActif);
            }
            else
            {
                return null;
            }
        }

        public static DataTable GetAllSports()
        {
            return clsSportDataAccess.GetAllSports();
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewSport())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateSport();
            }

            return false;
        }
    }
}
