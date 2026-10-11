using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Remoting.Messaging;
using System.Diagnostics;
using System.Globalization;


namespace GymManager.DataAccess
{
    public class clsUserData
    {
        public static bool GetUserByID(int UserID, ref int PersonID, ref string UserName, ref string Password,
            ref int Role, ref bool IsActive, ref DateTime CreatedDate)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                string query = "SELECT * FROM Utilisateurs WHERE UtilisateurID = @UserID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UtilisateurID", UserID);
                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;

                                PersonID = (int)reader["PersonneID"];
                                UserName = (string)reader["NomUtilisateur"];
                                Password = (string)reader["MotDePasse"];
                                Role = (int)reader["Role"];     
                                IsActive = (bool)reader["Etat"];
                                CreatedDate = (DateTime)reader["DateDeCreation"];

                            }
                        }

                        clsEventLog.LogEvent($"Data retrieved successfully for UserID: {UserID}", EventLogEntryType.Information);
                    }
                    catch (Exception ex)
                    {
                        // Handle exception
                        clsEventLog.LogEvent($"Error fetching Role data for UserID: {UserID}.\nMessage:{ex.Message}\nStackTrace: {ex.StackTrace}", EventLogEntryType.Error);
                        Console.WriteLine("Error: " + ex.Message);

                        isFound = false;
                    }
                }
            }

            return isFound;
        }

        public static bool GetUserInfoByUserNameAndPassword(string NomUtilisateur, string MotDePasse, ref int UserID, ref int PersonID, ref int Role, ref bool IsActive, ref DateTime CreatedDate)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                string query = "SELECT * FROM Utilisateurs WHERE NomUtilisateur = @NomUtilisateur AND MotDePasse = @MotDePasse";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NomUtilisateur", NomUtilisateur);
                    command.Parameters.AddWithValue("@MotDePasse", MotDePasse);

                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;
                                UserID = (int)reader["UtilisateurID"];
                                PersonID = (int)reader["PersonneID"];
                                Role = Convert.ToByte( reader["Role"]);
                                IsActive = (bool)reader["Etat"];
                                CreatedDate = (DateTime)reader["DateDeCreation"];
                            }
                        }

                        clsEventLog.LogEvent($"Data retrieved successfully for UserName: {NomUtilisateur}", EventLogEntryType.Information);
                    }
                    catch (Exception ex)
                    {
                        // Handle exception
                        clsEventLog.LogEvent($"Error fetching Role data for UserName: {NomUtilisateur}.\nMessage:{ex.Message}\nStackTrace: {ex.StackTrace}", EventLogEntryType.Error);

                        Console.WriteLine("Error: " + ex.Message);
                        isFound = false;
                    }
                }
            }
            return isFound;
        }

        public static int AddUser(int PersonID, string UserName, string Password, int Role, bool IsActive, DateTime CreatedDate)
        {
            int UserID = -1;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {

                string query = "INSERT INTO Utilisateurs (PersonneID, NomUtilisateur, MotDePasse, Role, Etat, DateDeCreation) " +
                    "VALUES (@PersonneID, @NomUtilisateur, @MotDePasse, @Role, @Etat, @DateDeCreation)" +
                    "SELECT SCOPE_IDENTITY(); ";


                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PersonneID", PersonID);
                    command.Parameters.AddWithValue("@NomUtilisateur", UserName);
                    command.Parameters.AddWithValue("@MotDePasse", Password);
                    command.Parameters.AddWithValue("@Role", Role);
                    command.Parameters.AddWithValue("@Etat", IsActive);
                    command.Parameters.AddWithValue("@DateDeCreation", CreatedDate);
                    try
                    {
                        connection.Open();


                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int insertID))
                        {
                            UserID = insertID;

                            clsEventLog.LogEvent($"User added successfully. New UserID: {UserID}", EventLogEntryType.Information);
                        }

                    }
                    catch (Exception ex)
                    {
                        // Handle exception
                        clsEventLog.LogEvent($"Error adding User data for PersonID: {PersonID}.\nMessage:{ex.Message}\nStackTrace: {ex.StackTrace}", EventLogEntryType.Error);

                        Console.WriteLine("Error: " + ex.Message);
                    }
                }
            }

            return UserID;
        }

        public static bool UpdateUser(int UserID, int PersonID, string UserName, string Password, int Role, bool IsActive)
        {
            int rowsAffected = 0;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {

                string query = "UPDATE Utilisateurs SET " +
                    "PersonneID = @PersonneID," +
                    " NomUtilisateur = @NomUtilisateur," +
                    " MotDePasse = @MotDePasse," +
                    " Role = @Role," +
                    " Etat = @Etat" +
                    " WHERE UtilisateurID = @UtilisateurID";


                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UtilisateurID", UserID);
                    command.Parameters.AddWithValue("@PersonneID", PersonID);
                    command.Parameters.AddWithValue("@NomUtilisateur", UserName);
                    command.Parameters.AddWithValue("@MotDePasse", Password);
                    command.Parameters.AddWithValue("@Role", Role);
                    command.Parameters.AddWithValue("@Etat", IsActive);
                    try
                    {
                        connection.Open();

                        rowsAffected = command.ExecuteNonQuery();


                        clsEventLog.LogEvent($"User updated successfully. Rows affected: {rowsAffected}", EventLogEntryType.Information);
                    }
                    catch (Exception ex)
                    {
                        // Handle exception
                        clsEventLog.LogEvent($"Error updating User data for UserID: {UserID}.\nMessage:{ex.Message}\nStackTrace: {ex.StackTrace}", EventLogEntryType.Error);
                        Console.WriteLine("Error: " + ex.Message);
                        return false;
                    }
                }
            }

            return (rowsAffected > 0);  
        }

        public static bool IsUserExists(string UserName)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                string query = "SELECT Found = 1 FROM Utilisateurs WHERE NomUtilisateur = @UserName";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserName", UserName);
                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            isFound = reader.HasRows;

                        }


                        clsEventLog.LogEvent($"Data retrieved successfully for UserName: {UserName}", EventLogEntryType.Information);
                    }
                    catch (Exception ex)
                    {
                        // Handle exception
                        clsEventLog.LogEvent($"Error fetching Role data for UserName: {UserName}.\nMessage:{ex.Message}\nStackTrace: {ex.StackTrace}", EventLogEntryType.Error);
                        Console.WriteLine("Error: " + ex.Message);

                        isFound = false;
                    }
                }
            }

            return isFound;

        }

        public static bool IsAdminExists(string RoleName)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                string query = "SELECT Found = 1 FROM Utilisateurs Inner JOIN RoleUtilisateurs ON Utilisateurs.Role = RoleUtilisateurs.RoleID " +
                               "WHERE RoleUtilisateurs.NomRole = @RoleName";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@RoleName", RoleName);
                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            isFound = reader.HasRows;

                        }


                        clsEventLog.LogEvent($"Data retrieved successfully for RoleName: {RoleName}", EventLogEntryType.Information);
                    }
                    catch (Exception ex)
                    {
                        // Handle exception
                        clsEventLog.LogEvent($"Error fetching Role data for RoleName: {RoleName}.\nMessage:{ex.Message}\nStackTrace: {ex.StackTrace}", EventLogEntryType.Error);
                        Console.WriteLine("Error: " + ex.Message);

                        isFound = false;
                    }
                }
            }

            return isFound;
        }

        public static bool IsUserExistsForPerson(int PersonID)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                string query = "SELECT Found = 1 FROM Utilisateurs WHERE PersonneID = @PersonID";


                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PersonID", PersonID);
                    try
                    {
                        connection.Open();


                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            isFound = reader.HasRows;
                        }
                    }
                    catch (Exception ex)
                    {
                        clsEventLog.LogEvent($"Error checking user existence for PersonID: {PersonID}.\nMessage:{ex.Message}\nStackTrace: {ex.StackTrace}", EventLogEntryType.Error);

                        Console.WriteLine("Error: " + ex.Message);
                        isFound = false;
                    }
                }
            }

            return isFound;
        }

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
