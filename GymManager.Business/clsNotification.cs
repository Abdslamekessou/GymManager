using System;
using System.Data;

namespace GymManager.Business
{
    public class clsNotification
    {


        static public DataTable AllNotifications()
        {

            return DataAccess.clsNotificationData.GetAllNotifications();
        }

    }
}