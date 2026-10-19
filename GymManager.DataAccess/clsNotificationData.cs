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
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

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
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

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
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

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
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

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

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

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
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

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


            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

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
    }
}
