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


        public static DataTable GetAllUser()
        {
            return clsUserData.GetAllUser();
        }

    }
}
