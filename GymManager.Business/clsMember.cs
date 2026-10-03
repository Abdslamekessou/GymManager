using GymManager.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.Business
{

    public class clsMember
    {
        public enum enMode
        {
            AddNew = 0,
            Update = 1
        };

        public enMode Mode = enMode.AddNew;


        // =========================================================
        // Properties
        // =========================================================

        public int MemberID { get; set; }

        public int PersonID { get; set; }

        public DateTime CreatedAt { get; set; }

        public int CreatedBy { get; set; }

        public bool IsActif { get; set; }


        // =========================================================
        // Constructor - Add New
        // =========================================================

        public clsMember()
        {
            this.MemberID = -1;
            this.PersonID = -1;
            this.CreatedAt = DateTime.Now;
            this.CreatedBy = -1;
            this.IsActif = true;

            Mode = enMode.AddNew;
        }


        // =========================================================
        // Constructor - Update
        // =========================================================

        private clsMember(
            int AdherentID,
            int PersonID,
            DateTime DateAjout,
            int CreePar,
            bool EstActif)
        {
            this.MemberID = AdherentID;
            this.PersonID = PersonID;
            this.CreatedAt = DateAjout;
            this.CreatedBy = CreePar;
            this.IsActif = EstActif;

            Mode = enMode.Update;
        }


        // =========================================================
        // Add New Member
        // =========================================================

        private bool _AddNewMember()
        {
            this.MemberID = clsMemberData.AddNewMember(
                this.PersonID,
                this.CreatedAt,
                this.CreatedBy,
                this.IsActif
            );

            return this.MemberID != -1;
        }


        // =========================================================
        // Update Member
        // =========================================================

        private bool _UpdateMember()
        {
            return clsMemberData.UpdateMember(
                this.MemberID,
                this.PersonID,
                this.CreatedAt,
                this.CreatedBy,
                this.IsActif
            );
        }


        // =========================================================
        // Save
        // =========================================================

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:

                    if (_AddNewMember())
                    {
                        Mode = enMode.Update;
                        return true;
                    }

                    return false;


                case enMode.Update:

                    return _UpdateMember();
            }

            return false;
        }


        // =========================================================
        // Find Member By ID
        // =========================================================

        public static clsMember FindMember(int ID)
        {
            int PersonID = -1;
            DateTime DateAjout = DateTime.Now;
            int CreePar = -1;
            bool EstActif = false;


            if (clsMemberData.FindMember(
                    ID,
                    ref PersonID,
                    ref DateAjout,
                    ref CreePar,
                    ref EstActif))
            {
                return new clsMember(
                    ID,
                    PersonID,
                    DateAjout,
                    CreePar,
                    EstActif
                );
            }

            return null;
        }


        // =========================================================
        // Check If Member Exists
        // =========================================================

        public static bool IsMemberExist(int ID)
        {
            return clsMemberData.IsMemberExist(ID);
        }


        // =========================================================
        // Get All Members
        // =========================================================
        
        public static DataTable GetAllMembers()
        {
            return clsMemberData.GetAllMembers();
        }
    }

}
