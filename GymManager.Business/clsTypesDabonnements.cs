using GymManager.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.Business
{
    public class clsTypeAbonnement
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int TypeAbonnementID { set; get; }
        public string Nom { set; get; }
        public int SportID { set; get; }

        public clsSport SportInfo;

        public byte DureeEnJour { set; get; }
        public decimal Prix { set; get; }
        public string Description { set; get; }
        public byte? NombreDeSeances { set; get; }
        public bool EstActif { set; get; }

        public clsTypeAbonnement()
        {
            this.TypeAbonnementID = -1;
            this.Nom = "";
            this.SportID = -1;
            this.DureeEnJour = 0;
            this.Prix = 0;
            this.Description = "";
            this.NombreDeSeances = null;
            this.EstActif = true;

            Mode = enMode.AddNew;
        }

        private clsTypeAbonnement(int typeAbonnementID, string nom, int sportID,
            byte dureeEnJour, decimal prix, string description,
            byte? nombreDeSeances, bool estActif)
        {
            this.TypeAbonnementID = typeAbonnementID;
            this.Nom = nom;
            this.SportID = sportID;
            this.DureeEnJour = dureeEnJour;
            this.Prix = prix;
            this.SportInfo = clsSport.Find(SportID);
            this.Description = description;
            this.NombreDeSeances = nombreDeSeances;
            this.EstActif = estActif;

            Mode = enMode.Update;
        }

        private bool _AddNewTypeAbonnement()
        {
            this.TypeAbonnementID = clsTypesDabonnementsData.AddNewTypeAbonnement(
                this.Nom,
                this.SportID,
                this.DureeEnJour,
                this.Prix,
                this.Description,
                this.NombreDeSeances,
                this.EstActif
            );

            return (this.TypeAbonnementID != -1);
        }

        private bool _UpdateTypeAbonnement()
        {
            return clsTypesDabonnementsData.UpdateTypeAbonnement(
                this.TypeAbonnementID,
                this.Nom,
                this.SportID,
                this.DureeEnJour,
                this.Prix,
                this.Description,
                this.NombreDeSeances,
                this.EstActif
            );
        }

        public static clsTypeAbonnement Find(int TypeAbonnementID)
        {
            string nom = "", description = "";
            int sportID = -1;
            byte dureeEnJour = 0;
            byte? nombreDeSeances = null;
            decimal prix = 0;
            bool estActif = false;

            if (clsTypesDabonnementsData.GetTypesDabonnementsByID(TypeAbonnementID, ref nom, ref sportID,
                ref dureeEnJour, ref prix, ref description, ref nombreDeSeances, ref estActif))
            {
                return new clsTypeAbonnement(TypeAbonnementID, nom, sportID, dureeEnJour, prix, description, nombreDeSeances, estActif);
            }
            else
            {
                return null;
            }
        }

        public static clsTypeAbonnement Find(string Nom)
        {
            int typeAbonnementID = -1, sportID = -1;
            byte dureeEnJour = 0;
            byte? nombreDeSeances = null; 
            decimal prix = 0;
            string description = "";
            bool estActif = false;

            if (clsTypesDabonnementsData.GetTypesDabonnementsByNom(Nom, ref typeAbonnementID, ref sportID,
                ref dureeEnJour, ref prix, ref description, ref nombreDeSeances, ref estActif))
            {
                return new clsTypeAbonnement(typeAbonnementID, Nom, sportID, dureeEnJour, prix, description, nombreDeSeances, estActif);
            }
            else
            {
                return null;
            }
        }

        public static DataTable GetAllTypesDabonnements()
        {
            return clsTypesDabonnementsData.GetAllTypesDabonnements();
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewTypeAbonnement())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateTypeAbonnement();
            }

            return false;
        }

        public static bool DeactivateTypeAbonnement(int TypeAbonnementID)
        {
            return clsTypesDabonnementsData.DeactivateTypeAbonnement(TypeAbonnementID);
        }

        public static bool ActivateTypeAbonnement(int TypeAbonnementID)
        {
            return clsTypesDabonnementsData.ActivateTypeAbonnement(TypeAbonnementID);
        }
    }
}