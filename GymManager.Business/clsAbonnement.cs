using GymManager.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.Business
{
    namespace GymManager.Business
    {
        public class clsAbonnement
        {
            public enum enMode { AddNew = 0, Update = 1 }
            public enMode Mode = enMode.AddNew;

            public int AbonnementID { get; set; }
            public int AdherentID { get; set; }
            public int TypeAbonnementID { get; set; }
            public clsTypeAbonnement TypeAbonnementInfo;
            public DateTime DateDebut { get; set; }
            public DateTime DateFin { get; set; }
            public int CreePar { get; set; }
            public decimal PrixPaye { get; set; }
            public byte EtatAbonnement { get; set; }

            public clsAbonnement()
            {
                this.AbonnementID = -1;
                this.AdherentID = -1;
                this.TypeAbonnementID = -1;
                this.DateDebut = DateTime.Now;
                this.DateFin = DateTime.Now;
                this.CreePar = -1;
                this.PrixPaye = 0;
                this.EtatAbonnement = 1; // 1: Actif, 0: Inactif, 2: Expiré par exemple

                this.Mode = enMode.AddNew;
            }

            private clsAbonnement(int abonnementID, int adherentID, int typeAbonnementID,
                DateTime dateDebut, DateTime dateFin, int creePar, decimal prixPaye, byte etatAbonnement)
            {
                this.AbonnementID = abonnementID;
                this.AdherentID = adherentID;
                this.TypeAbonnementID = typeAbonnementID;
                this.DateDebut = dateDebut;
                this.DateFin = dateFin;
                this.CreePar = creePar;
                this.PrixPaye = prixPaye;
                this.EtatAbonnement = etatAbonnement;

                this.TypeAbonnementInfo = clsTypeAbonnement.Find(typeAbonnementID);

                this.Mode = enMode.Update;
            }

            private bool _AddNewAbonnement()
            {
                this.AbonnementID = clsAbonnementDataAccess.AddNewAbonnement(
                    this.AdherentID,
                    this.TypeAbonnementID,
                    this.DateDebut,
                    this.DateFin,
                    this.CreePar,
                    this.PrixPaye,
                    this.EtatAbonnement
                );

                return (this.AbonnementID != -1);
            }

            private bool _UpdateAbonnement()
            {
                return clsAbonnementDataAccess.UpdateAbonnement(
                    this.AbonnementID,
                    this.AdherentID,
                    this.TypeAbonnementID,
                    this.DateDebut,
                    this.DateFin,
                    this.CreePar,
                    this.PrixPaye,
                    this.EtatAbonnement
                );
            }

            public static clsAbonnement Find(int abonnementID)
            {
                int adherentID = -1, typeAbonnementID = -1, creePar = -1;
                DateTime dateDebut = DateTime.Now, dateFin = DateTime.Now;
                decimal prixPaye = 0;
                byte etatAbonnement = 0;

                if (clsAbonnementDataAccess.GetAbonnementByID(abonnementID, ref adherentID, ref typeAbonnementID,
                    ref dateDebut, ref dateFin, ref creePar, ref prixPaye, ref etatAbonnement))
                {
                    return new clsAbonnement(abonnementID, adherentID, typeAbonnementID, dateDebut, dateFin, creePar, prixPaye, etatAbonnement);
                }
                else
                {
                    return null;
                }
            }

            public static clsAbonnement FindAbonnementByMemberID(int MemberID)
            {
                int abonnementID = -1, typeAbonnementID = -1, creePar = -1;
                DateTime dateDebut = DateTime.Now, dateFin = DateTime.Now;
                decimal prixPaye = 0;
                byte etatAbonnement = 0;

                if (clsAbonnementDataAccess.GetAbonnementByMemberID(MemberID, ref abonnementID, ref typeAbonnementID,
                    ref dateDebut, ref dateFin, ref creePar, ref prixPaye, ref etatAbonnement))
                {
                    return new clsAbonnement(abonnementID, MemberID, typeAbonnementID, dateDebut, dateFin, creePar, prixPaye, etatAbonnement);
                }
                else
                {
                    return null;
                }
            }

            public bool Save()
            {
                switch (Mode)
                {
                    case enMode.AddNew:
                        if (_AddNewAbonnement())
                        {
                            Mode = enMode.Update;
                            return true;
                        }
                        else
                        {
                            return false;
                        }

                    case enMode.Update:
                        return _UpdateAbonnement();
                }

                return false;
            }

            public static bool IsAbonnementExist(int abonnementID)
            {
                return clsAbonnementDataAccess.IsAbonnementExist(abonnementID);
            }

            public static DataTable GetAllAbonnements()
            {
                return clsAbonnementDataAccess.GetAllAbonnements();
            }

            public static bool CancelAbonnement(int abonnementID)
            {
                clsAbonnement abonnement = clsAbonnement.Find(abonnementID);
                if (abonnement == null) return false;

                abonnement.EtatAbonnement = 0;

                return abonnement.Save();
            }

            public static bool RenewAbonnement(int abonnementID, int dureeEnJours)
            {
                clsAbonnement abonnement = clsAbonnement.Find(abonnementID);
                if (abonnement == null) return false;

                abonnement.DateDebut = DateTime.Now;
                abonnement.DateFin = DateTime.Now.AddDays(dureeEnJours);
                abonnement.EtatAbonnement = 1; 

                return abonnement.Save();
            }

        }
    }
}
