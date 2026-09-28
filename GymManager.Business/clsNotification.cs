using System;

namespace GymManager.Business
{
    internal class clsNotification
    {
        // Properties
        public int NotificationID { get; private set; }

        public int MemberID { get; private  set; }

        public string MemberName { get;private  set; }

        public int SubscriptionID { get; set; }

        public string SubscriptionType { get; private set; }

        public int SportID { get; private set; }

        public string Sport { get; private set; }

        public string Status { get; private set; }

        public bool IsRead { get; private set; }

        public bool IsExported { get; private set; }


        // Constructor
        private clsNotification(
            int notificationID,
            int memberID,
            string memberName,
            int subscriptionID,
            string subscriptionType,
            int sportID,
            string sport,
            string status,
            bool isRead,
            bool isExported)
        {
            NotificationID = notificationID;
            MemberID = memberID;
            MemberName = memberName;
            SubscriptionID = subscriptionID;
            SubscriptionType = subscriptionType;
            SportID = sportID;
            Sport = sport;
            Status = status;
            IsRead = isRead;
            IsExported = isExported;
        }


        // Methods

        public bool MarkAsRead()
        {
            if (IsRead)
                return true;

            // TODO: Call Data Access Layer
            // if (!NotificationDataAccess.MarkAsRead(NotificationID))
            //     return false;

            IsRead = true;
            return true;
        }

        public bool MarkAsUnread()
        {
            if (!IsRead)
                return true;

            // TODO: Call Data Access Layer

            IsRead = false;
            return true;
        }

        public bool MarkAsExported()
        {
            if (IsExported)
                return true;

            // TODO: Call Data Access Layer

            IsExported = true;
            return true;
        }


        // Find
        public static clsNotification Find(int notificationID)
        {
            // TODO: Call Data Access Layer
            //
            // if (NotificationDataAccess.GetNotificationByID(
            //     notificationID,
            //     ref memberID,
            //     ref memberName,
            //     ...
            // ))
            // {
            //     return new clsNotification(...);
            // }

            return null;
        }


        // Delete
        public bool Delete()
        {
            // TODO: Call Data Access Layer

            return true;
        }


        // Save
        public bool Save()
        {
            // TODO: Insert or Update through Data Access Layer

            return true;
        }
    }
}