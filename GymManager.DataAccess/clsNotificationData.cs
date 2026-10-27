using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace GymManager.DataAccess
{
    public class clsNotificationData
    {
        public static DataTable GetAllNotifications()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = @"select * from Notifications_View";

            SqlCommand cmd = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    dt.Load(reader);
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return dt;

        }

        public static bool MarkAllAsRead()
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = @"UPDATE Notifications
                 SET EstVue = 1";

            SqlCommand cmd = new SqlCommand(query, connection);
            short NumberOfRowsAffected = 0;

            try
            {
                connection.Open();
                NumberOfRowsAffected = (short)cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                //Nothine
            }
            finally
            {
                connection.Close();
            }
            return NumberOfRowsAffected > 0;
        }

        public static bool MarkAsRead(int notificationID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = @"UPDATE Notifications
                 SET EstVue = 1
                  WHERE NotificationID = @notificationID;";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("notificationID", notificationID);
            short NumberOfRowsAffected = 0;
            try
            {
                connection.Open();
                NumberOfRowsAffected = (short)cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                //Nothine
            }
            finally
            {
                connection.Close();
            }
            return NumberOfRowsAffected > 0;
        }

        public static bool Save(int notificationID, bool isRead, string message)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = @"UPDATE Notifications
                 SET EstVue = @isRead,Message =@message
                  WHERE NotificationID = @notificationID;";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("notificationID", notificationID);
            cmd.Parameters.AddWithValue("message", message);
            cmd.Parameters.AddWithValue("isRead", isRead ? 1 : 0);
            short NumberOfRowsAffected = 0;
            try
            {
                connection.Open();
                NumberOfRowsAffected = (short)cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                //Nothine
            }
            finally
            {
                connection.Close();
            }
            return NumberOfRowsAffected > 0;
        }

        public static bool MakeNotificationsAsExported(List<int> notificationsID)
        {

            if (notificationsID == null || notificationsID.Count == 0)
                return false;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string set = string.Join(",", notificationsID);
            string query = $@"UPDATE Notifications
                                SET EstExportee=1
                                WHERE NotificationID IN ({set});";

            SqlCommand cmd = new SqlCommand(query, connection);
            short NumberOfRowsAffected = 0;
            try
            {
                connection.Open();
                NumberOfRowsAffected = (short)cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }


            return NumberOfRowsAffected > 0;
        }

        public static bool CreateNotfication(int abonnementID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = @"Insert into Notifications (AbonnementID,EstVue,EstExportee,Message)
                                Values (@abonnementID,0,0,'');";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@abonnementID", abonnementID);
            short NumberOfRowsAffected = 0;

            try
            {
                connection.Open();
                NumberOfRowsAffected = (short)cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

            }
            finally { connection.Close(); }

            return NumberOfRowsAffected > 0;
        }

        public static int GetNumberOfUnreadNotifications()
        {


            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = @"select count(*) as Num from Notifications where EstVue = 0;";

            SqlCommand cmd = new SqlCommand(query, connection);
            int Num = 0;

            try
            {
                connection.Open();
                Num = (int)cmd.ExecuteScalar();

            }
            catch (Exception ex)
            {

            }
            finally { connection.Close(); }

            return Num;
        }

        public static void UpdateNotifications()
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = @"  INSERT INTO Notifications
    (AbonnementID, EstVue, EstExportee,Message)
SELECT
    A.AbonnementID,
    0,
	0,
	 'Bonjour ' + P.Nom + ' ' + P.Prenom + ', ' + 'votre abonnement ""' + T.Nom + '"" pour l''activité ' + S.Nom + ' a expiré le ' + CONVERT(VARCHAR(10), A.DateFin, 103) 
             + '. ' + 'Vous pouvez nous contacter ou visiter la salle pour renouveler votre abonnement. ' + 'Merci pour votre confiance.' AS Message

FROM 
        dbo.Abonnements AS A INNER JOIN dbo.Adherents AS AD ON A.AdherentID = AD.AdherentID and A.EtatAbonnement = 1
		INNER JOIN dbo.Personnes AS P ON AD.PersonneID = P.PersonneID 
        INNER JOIN dbo.TypeAbonnements AS T ON A.TypeAbonnementID = T.TypeAbonnementID INNER JOIN
        dbo.Sports AS S ON T.SportID = S.SportID
WHERE A.EtatAbonnement = 1
  AND NOT EXISTS
  (
      SELECT 1
      FROM Notifications AS N
      WHERE N.AbonnementID = A.AbonnementID
  );
";

            SqlCommand cmd = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

            }
            finally { connection.Close(); }

        }

        public static void DeleteNotificationByAbonnementID(int ID)
        {

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = @"Delete Notifications 
                                where AbonnementID = @AbonnementID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AbonnementID", ID);

            try
            {
                connection.Open();

               command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {

                connection.Close();

            }

        }
    }
}
