using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.DataAccess
{
    public class clsTypesDabonnementsData
    {
        public static bool GetTypesDabonnementsByID(int TypeAbonnementID,
                ref string Nom, ref int SportID, ref byte DureeEnJour, ref decimal Prix,
                ref string Description, ref byte? NombreDeSeances, ref bool EstActif)
        {
            bool isFound = false;
            string query = @"SELECT * FROM TypeAbonnements WHERE TypeAbonnementID = @TypeAbonnementID";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TypeAbonnementID", TypeAbonnementID);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;

                                Nom = (string)reader["Nom"];
                                SportID = (int)reader["SportID"];
                                DureeEnJour = (byte)reader["DureeEnJour"];
                                Prix = Convert.ToDecimal(reader["Prix"]);


                                Description = reader["Description"] != DBNull.Value ? (string)reader["Description"] : "";


                                NombreDeSeances = reader["NombreDeSeances"] != DBNull.Value
                                    ? (byte?)reader["NombreDeSeances"]
                                    : null;

                                EstActif = (bool)reader["EstActif"];
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        isFound = false;
                    }
                }
            }

            return isFound;
        }


        public static DataTable GetAllTypesDabonnements()
        {
            DataTable dt = new DataTable();
            string query = @"select * from View_TypeAbonnementsList";

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
                }
            }

            return dt;
        }


        public static bool GetTypesDabonnementsByNom(string Nom, ref int TypeAbonnementID,
            ref int SportID, ref byte DureeEnJour, ref decimal Prix,
            ref string Description, ref byte? NombreDeSeances, ref bool EstActif)
        {
            bool isFound = false;
            string query = @"SELECT * FROM TypeAbonnements WHERE Nom = @Nom";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nom", Nom);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;

                                TypeAbonnementID = (int)reader["TypeAbonnementID"];
                                SportID = (int)reader["SportID"];
                                DureeEnJour = (byte)reader["DureeEnJour"];
                                Prix = Convert.ToDecimal(reader["Prix"]);


                                Description = reader["Description"] != DBNull.Value ? (string)reader["Description"] : "";


                                NombreDeSeances = reader["NombreDeSeances"] != DBNull.Value
                                    ? (byte?)reader["NombreDeSeances"]
                                    : null;

                                EstActif = (bool)reader["EstActif"];
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        isFound = false;
                    }
                }
            }

            return isFound;
        }


        public static int AddNewTypeAbonnement(string Nom, int SportID,
            byte DureeEnJour, decimal Prix, string Description,
            byte? NombreDeSeances, bool EstActif)
        {
            int typeAbonnementID = -1;

            string query = @"INSERT INTO TypeAbonnements 
                            (Nom, SportID, DureeEnJour, Prix, Description, NombreDeSeances, EstActif) 
                        VALUES 
                            (@Nom, @SportID, @DureeEnJour, @Prix, @Description, @NombreDeSeances, @EstActif); 
                        SELECT SCOPE_IDENTITY();";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nom", Nom);
                    command.Parameters.AddWithValue("@SportID", SportID);
                    command.Parameters.AddWithValue("@DureeEnJour", DureeEnJour);
                    command.Parameters.AddWithValue("@Prix", Prix);


                    if (string.IsNullOrWhiteSpace(Description))
                        command.Parameters.AddWithValue("@Description", DBNull.Value);
                    else
                        command.Parameters.AddWithValue("@Description", Description);


                    if (NombreDeSeances == null)
                        command.Parameters.AddWithValue("@NombreDeSeances", DBNull.Value);
                    else
                        command.Parameters.AddWithValue("@NombreDeSeances", NombreDeSeances.Value);

                    command.Parameters.AddWithValue("@EstActif", EstActif);

                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            typeAbonnementID = insertedID;
                        }
                    }
                    catch (Exception ex)
                    {
                        typeAbonnementID = -1;
                    }
                }
            }

            return typeAbonnementID;
        }


        public static bool UpdateTypeAbonnement(int TypeAbonnementID, string Nom, int SportID,
            byte DureeEnJour, decimal Prix, string Description,
            byte? NombreDeSeances, bool EstActif)
        {
            int rowsAffected = 0;

            string query = @"UPDATE TypeAbonnements
                     SET Nom = @Nom,
                         SportID = @SportID,
                         DureeEnJour = @DureeEnJour,
                         Prix = @Prix,
                         Description = @Description,
                         NombreDeSeances = @NombreDeSeances,
                         EstActif = @EstActif
                     WHERE TypeAbonnementID = @TypeAbonnementID";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TypeAbonnementID", TypeAbonnementID);
                    command.Parameters.AddWithValue("@Nom", Nom);
                    command.Parameters.AddWithValue("@SportID", SportID);
                    command.Parameters.AddWithValue("@DureeEnJour", DureeEnJour);
                    command.Parameters.AddWithValue("@Prix", Prix);


                    if (string.IsNullOrWhiteSpace(Description))
                        command.Parameters.AddWithValue("@Description", DBNull.Value);
                    else
                        command.Parameters.AddWithValue("@Description", Description);


                    if (NombreDeSeances == null)
                        command.Parameters.AddWithValue("@NombreDeSeances", DBNull.Value);
                    else
                        command.Parameters.AddWithValue("@NombreDeSeances", NombreDeSeances.Value);

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
                }
            }

            return (rowsAffected > 0);
        }


        public static bool ActivateTypeAbonnement(int typeAbonnementID)
        {
            int rowsAffected = 0;

            string query = @"UPDATE TypeAbonnements 
                            SET EstActif = 1 
                            WHERE TypeAbonnementID = @TypeAbonnementID";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TypeAbonnementID", typeAbonnementID);

                    try
                    {
                        connection.Open();
                        rowsAffected = command.ExecuteNonQuery();
                    }
                    catch (Exception)
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

        public static bool DeactivateTypeAbonnement(int typeAbonnementID)
        {
            int rowsAffected = 0;


            string query = @"UPDATE TypeAbonnements 
                            SET EstActif = 0 
                            WHERE TypeAbonnementID = @TypeAbonnementID";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TypeAbonnementID", typeAbonnementID);

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
