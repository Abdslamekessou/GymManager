using GymManager.DataAccess;
using System;
using System.Collections.Generic;
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
            return clsNotificationData.Save(NotificationId, IsRead, Message);
        }

        static public bool MakeNotificationsAsExported(List<int> NotificationsID)
        {
            return clsNotificationData.MakeNotificationsAsExported(NotificationsID);
        }

        public void GenerateMessage(clsNotification N)
        {
            switch (SubscriptionStatus)
            {
                case "Active":
                    Message = $"Bonjour {N.MemberName},\n\n" +
                              $"Votre abonnement \"{N.SubscriptionType}\" pour {N.SportName} " +
                              $"est actuellement actif jusqu'au {EndDate:dd/MM/yyyy}.\n\n" +
                              "Merci pour votre confiance.";
                    break;

                case "Expiring Soon":
                    Message = $"Bonjour {N.MemberName},\n\n" +
                              $"Nous vous informons que votre abonnement \"{N.SubscriptionType}\" " +
                              $"pour {N.SportName} arrive bientôt à expiration, le {N.EndDate.Date.ToString("dd / MM / yyyy")}.\n\n" +
                              "Pensez à renouveler votre abonnement afin de continuer à profiter de nos services.\n\n" +
                              "Merci pour votre confiance.";
                    break;

                case "Expired":
                    Message = $"Bonjour {N.MemberName},\n\n" +
                              $"Nous vous informons que votre abonnement \"{N.SubscriptionType}\" " +
                              $"pour {N.SportName} a expiré le {N.EndDate.Date.ToString("dd / MM / yyyy")}.\n\n" +
                              "Vous pouvez nous contacter ou visiter la salle pour renouveler votre abonnement.\n\n" +
                              "Merci pour votre confiance.";
                    break;

                case "Cancelled":
                    Message = $"Bonjour {N.MemberName},\n\n" +
                              $"Nous vous informons que votre abonnement \"{N.SubscriptionType}\" " +
                              $"pour {N.SportName} a été annulé.\n\n" +
                              "Pour plus d'informations, veuillez nous contacter ou visiter la salle.\n\n" +
                              "Merci pour votre confiance.";
                    break;

                default:
                    Message = "";
                    break;
            }
        }

    }
}