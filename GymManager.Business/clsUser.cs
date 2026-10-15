using GymManager.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.Business
{
    public class clsUser
    {
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;

        public int UserID { get; set; }
        public int PersonID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int RoleID { get; set; }
        public clsRole RoleInfo;
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }

        public clsUser()
        {
            this.UserID = -1;
            this.PersonID = -1;
            this.UserName = "";
            this.Password = "";
            this.RoleID = -1;
            this.IsActive = true;
            this.CreatedDate = DateTime.Now;

            _Mode = enMode.AddNew;
        }

        private clsUser(int UserID, int PersonID, string UserName, string Password, int RoleID, bool IsActive, DateTime CreatedDate)
        {
            this.UserID = UserID;
            this.PersonID = PersonID;
            this.UserName = UserName;
            this.Password = Password;
            this.RoleID = RoleID;
            this.RoleInfo = clsRole.Find(RoleID);
            this.IsActive = IsActive;
            this.CreatedDate = CreatedDate;

            _Mode = enMode.Update;
        }

        public static clsUser Find(int UserID)
        {
            int PersonID = -1, RoleID = -1;
            string UserName = "", Password = "";
            bool IsActive = true;
            DateTime CreatedDate = DateTime.Now;


            bool IsFound = clsUserData.GetUserByID(UserID, ref PersonID, ref UserName, ref Password, ref RoleID, ref IsActive, ref CreatedDate);

            if (IsFound)
                return new clsUser(UserID, PersonID, UserName, Password, RoleID, IsActive, CreatedDate);
            else
                return null;
        }

        public static clsUser FindByUserNameAndPassword(string UserName, string Password)
        {
            int UserID = -1, PersonID = -1, RoleID = -1;
            bool IsActive = true;
            DateTime CreatedDate = DateTime.Now;

            bool IsFound = clsUserData.GetUserInfoByUserNameAndPassword(UserName, Password, ref UserID, ref PersonID,
                                                                        ref RoleID, ref IsActive, ref CreatedDate);

            if (IsFound)
                return new clsUser(UserID, PersonID, UserName, Password, RoleID, IsActive, CreatedDate);
            else
                return null;
        }

        private bool _AddNewUser()
        {
            this.UserID = clsUserData.AddUser(this.PersonID, this.UserName, this.Password, this.RoleID, this.IsActive, this.CreatedDate);

            return (UserID != -1);
        }

        private bool _UpdateUser()
        {
            return clsUserData.UpdateUser(this.UserID, this.PersonID, this.UserName, this.Password, this.RoleID, this.IsActive);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:

                    if (_AddNewUser())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateUser();
            }

            return false;
        }

        public static DataTable GetAllUser()
        {
            return clsUserData.GetAllUser();
        }

        public static bool IsUserExists(string UserName)
        {
            return clsUserData.IsUserExists(UserName);
        }

        public static bool IsAdminExists(string RoleName)
        {
            return clsUserData.IsAdminExists(RoleName);
        }

        public static bool IsUserExistedForPerson(int PersonID)
        {
            return clsUserData.IsUserExistsForPerson(PersonID);
        }
    }
}
