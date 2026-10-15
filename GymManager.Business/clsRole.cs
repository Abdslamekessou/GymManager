using GymManager.DataAccess;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.Business
{
    public class clsRole
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int RoleID { get; set; }
        public string RoleName { get; set; }
        public string DescriptionRole { get; set; }

        public clsRole()
        {
            this.RoleID = -1;
            this.RoleName = "";
            this.DescriptionRole = "";

            Mode = enMode.AddNew;
        }

        private clsRole(int RoleID, string RoleName, string DescriptionRole)
        {
            this.RoleID = RoleID;
            this.RoleName = RoleName;
            this.DescriptionRole = DescriptionRole;

            Mode = enMode.Update;
        }

        public static clsRole Find(int RoleID)
        {
            string RoleName = "", DescriptionRole = "";

            bool IsFound = clsRoleData.GetRoleByID(RoleID, ref RoleName, ref DescriptionRole);

            if (IsFound)
                return new clsRole(RoleID, RoleName, DescriptionRole);
            else
                return null;
        }
        private bool _UpdateRole()
        {
            return clsRoleData.UpdateRole(this.RoleID, this.RoleName, this.DescriptionRole);
        }

        private bool _AddNewRole()
        {
            this.RoleID = clsRoleData.AddNewRole(this.RoleName, this.DescriptionRole);
            return (RoleID != -1);
        }

        public bool _Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewRole())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    return _UpdateRole();
            }

            return false;
        }

        public static DataTable GetAllRole()
        {
            return clsRoleData.GetAllRole();
        }


    }
}
