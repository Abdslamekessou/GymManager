using GymManager.DataAccess;
using System;
using System.Data;

namespace GymManager.Business
{
    public class clsNotification
    {
        public int NotificationId { get; private set; }

        public string MemberName { get; private set; }

        public string Phone { get; private set; }

        public string SportName { get; private set; }

        public string SubscriptionType { get; private set; }

        public DateTime StartDate { get; private set; }

        public DateTime EndDate { get; private set; }

        public string SubscriptionStatus { get; private set; }

        public bool IsRead { get; set; }

        public bool IsExported { get; private set; }

        public string Message { get; set; }

        public clsNotification()
        {
            NotificationId = 0;
            MemberName = "";
            Phone = "";
            SportName = "";
            this.SubscriptionType = "";
            this.StartDate = DateTime.Now;
            this.EndDate = DateTime.Now;
            this.SubscriptionStatus = "";
            this.IsRead = false;
            this.IsExported = false;
            this.Message = "";
        }
        public clsNotification(
     int notificationID,
     string memberName,
     string phone,
     string sportName,
     string subscriptionType,
     DateTime startDate,
     DateTime endDate,
     string subscriptionStatus,
     bool isRead,
     bool isExported,
     string message)
        {
            this.NotificationId = notificationID;
            this.MemberName = memberName;
            this.Phone = phone;
            this.SportName = sportName;
            this.SubscriptionType = subscriptionType;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.SubscriptionStatus = subscriptionStatus;
            this.IsRead = isRead;
            this.IsExported = isExported;
            this.Message = message;
        }
        static public DataTable AllNotifications()
        {

            return DataAccess.clsNotificationData.GetAllNotifications();
        }

        static public bool MarkAsRead(int NotificationID)
        {
            return clsNotificationData.MarkAsRead(NotificationID);
        }
        static public bool MarAllkAsRead()
        {
            return clsNotificationData.MarkAllAsRead();
        }

        public bool Save()
        {
            return clsNotificationData.Save(NotificationId,IsRead, Message);
        }
    }
}