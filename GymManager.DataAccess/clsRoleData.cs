using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.DataAccess
{
    public class clsRoleData
    {

        public static bool GetRoleByID(int RoleID, ref string RoleName, ref string DescriptionRole)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = "SELECT * FROM RoleUtilisateurs WHERE RoleID = @RoleID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@RoleID", RoleID);
                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;


                                RoleName = (string)reader["NomRole"];
                                DescriptionRole = (string)reader["DescriptionRole"];

                            }
                        }

                        clsEventLog.LogEvent($"Data retrieved successfully for RoleID: {RoleID}", EventLogEntryType.Information);
                    }
                    catch (Exception ex)
                    {
                        // Handle exception
                        clsEventLog.LogEvent($"Error fetching Role data for RoleID: {RoleID}.\nMessage:{ex.Message}\nStackTrace: {ex.StackTrace}", EventLogEntryType.Error);
                        Console.WriteLine("Error: " + ex.Message);

                        isFound = false;
                    }
                }
            }

            return isFound;
        }

        public static int AddNewRole(string RoleName, string DescriptionRole)
        {
            int RoleID = -1;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {

                string query = @"INSERT INTO RoleUtilisateurs (NomRole, DescriptionRole)
                             VALUES (@NomRole, @DescriptionRole);
                             SELECT SCOPE_IDENTITY();";


                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@NomRole", RoleName);
                    command.Parameters.AddWithValue("@DescriptionRole", DescriptionRole);

                    try
                    {
                        connection.Open();


                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int insertID))
                        {
                            RoleID = insertID;
                            clsEventLog.LogEvent($"New Role added successfully. RoleID: {RoleID}", EventLogEntryType.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        // Handle exception
                        clsEventLog.LogEvent($"Error adding new Role.\nMessage:{ex.Message}\nStackTrace: {ex.StackTrace}", EventLogEntryType.Error);
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }
            }

            return RoleID;
        }

        public static bool UpdateRole(int RoleID, string RoleName, string DescriptionRole)
        {
            int rowsAffected = 0;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {

                string query = @"Update  RoleUtilisateurs  
                            set NomRole = @NomRole,
                                DescriptionRole = @DescriptionRole
                                where RoleID = @RoleID";


                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@RoleID", RoleID);
                    command.Parameters.AddWithValue("@NomRole", RoleName);
                    command.Parameters.AddWithValue("@DescriptionRole", DescriptionRole);

                    try
                    {

                        connection.Open();

                        rowsAffected = command.ExecuteNonQuery();

                        clsEventLog.LogEvent("Role updated successfully. RoleID: " + RoleID, EventLogEntryType.Information);
                    }
                    catch(Exception ex)
                    {
                        clsEventLog.LogEvent($"Error updating Role.\nMessage:{ex.Message}\nStackTrace: {ex.StackTrace}", EventLogEntryType.Error);
                        return false;
                    }
                }
            }

            return (rowsAffected > 0);
        }

        public static DataTable GetAllRole()
        {
            DataTable dt = new DataTable();

            string query = "select * from RoleUtilisateurs";


            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
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
