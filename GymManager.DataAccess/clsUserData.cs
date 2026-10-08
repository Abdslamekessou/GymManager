using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Remoting.Messaging;
using System.Diagnostics;


namespace GymManager.DataAccess
{
    public class clsUserData
    {
        public static DataTable GetAllUser()
        {
            DataTable dt = new DataTable();

            string query = "select U.UtilisateurID, U.PersonneID, P.Prenom + ' ' + P.Nom AS NomComplet, U.NomUtilisateur, R.NomRole" +
                "\r\nfrom Utilisateurs U\r\n" +
                "inner join Personnes P on U.PersonneID = P.PersonneID\r\n " +
                "inner join RoleUtilisateurs R on U.Role = R.RoleID";


            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();


                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.HasRows)

                            {
                                dt.Load(reader);
                            }
                        }

                       clsEventLog.LogEvent($"Data retrieved successfully. Rows: {dt.Rows.Count}", EventLogEntryType.Information);
                    }
                    catch (Exception ex)
                    {
                        // Handle exception
                        clsEventLog.LogEvent($"Error fetching User data.\nMessage:{ex.Message}\nStackTrace: {ex.StackTrace}", EventLogEntryType.Error);
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }
            }

            return dt;
        }


    }
}
