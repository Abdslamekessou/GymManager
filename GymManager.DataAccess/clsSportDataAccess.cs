using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.DataAccess
{
    public class clsSportDataAccess
    {
        public static bool GetSportByID(int SportID, ref string Nom, ref string Description,
           ref bool EstActif)
        {
            bool isFound = false;
            string query = @"SELECT * FROM Sports WHERE SportID = @SportID";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@SportID", SportID);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;

                                Nom = (string)reader["Nom"];
                                Description = (string)reader["Description"];
                                EstActif = (bool)reader["EstActif"];
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        isFound = false;
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }

            return isFound;
        }

        public static DataTable GetAllSports()
        {
            DataTable dt = new DataTable();
            string query = @"SELECT * FROM Sports";

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
                    }
                    catch (Exception ex)
                    {
                        connection.Close();
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }

            return dt;
        }

        public static int AddNewSport(string Nom, string Description,
            bool EstActif)
        {
            int sportID = -1;

            string query = @"INSERT INTO Sports (Nom, Description, EstActif)
                             VALUES (@Nom, @Description, @EstActif);
                             SELECT SCOPE_IDENTITY();";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nom", Nom);
                    command.Parameters.AddWithValue("@Description", Description ?? "");
                    command.Parameters.AddWithValue("@EstActif", EstActif);

                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            sportID = insertedID;
                        }
                    }
                    catch (Exception ex)
                    {
                        sportID = -1;
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }

            return sportID;
        }

        public static bool UpdateSport(int SportID, string Nom,
            string Description, bool EstActif)
        {
            int rowsAffected = 0;

            string query = @"UPDATE Sports
                             SET Nom = @Nom,
                                 Description = @Description,
                                 EstActif = @EstActif
                             WHERE SportID = @SportID";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@SportID", SportID);
                    command.Parameters.AddWithValue("@Nom", Nom);
                    command.Parameters.AddWithValue("@Description", Description ?? "");
                    command.Parameters.AddWithValue("@EstActif", EstActif);

                    try
                    {
                        connection.Open();
                        rowsAffected = command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        return false;
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }

            return (rowsAffected > 0);
        }

    }
}

