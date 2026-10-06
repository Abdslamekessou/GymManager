using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.DataAccess
{
    public class clsAbonnementDataAccess
    {
        public static bool GetAbonnementByID(int AbonnementID, ref int AdherentID, ref int TypeAbonnementID,
            ref DateTime DateDebut, ref DateTime DateFin, ref int CreePar, ref decimal PrixPaye, ref byte EtatAbonnement)
        {
            bool isFound = false;
            string query = @"SELECT * FROM Abonnements WHERE AbonnementID = @AbonnementID";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@AbonnementID", AbonnementID);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;

                                AdherentID = (int)reader["AdherentID"];
                                TypeAbonnementID = (int)reader["TypeAbonnementID"];
                                DateDebut = (DateTime)reader["DateDebut"];
                                DateFin = (DateTime)reader["DateFin"];
                                CreePar = (int)reader["CreePar"];
                                PrixPaye = Convert.ToDecimal(reader["PrixPaye"]);
                                EtatAbonnement = (byte)reader["EtatAbonnement"];
                            }
                        }
                    }
                    catch (Exception)
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

        public static bool GetAbonnementByMemberID(int MemberID, ref int AbonnementID, ref int TypeAbonnementID,
    ref DateTime DateDebut, ref DateTime DateFin, ref int CreePar, ref decimal PrixPaye, ref byte EtatAbonnement)
        {
            bool isFound = false;
            string query = @"SELECT * FROM Abonnements WHERE AdherentID = @MemberID";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MemberID", MemberID);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;

                                AbonnementID = (int)reader["AbonnementID"];
                                TypeAbonnementID = (int)reader["TypeAbonnementID"];
                                DateDebut = (DateTime)reader["DateDebut"];
                                DateFin = (DateTime)reader["DateFin"];
                                CreePar = (int)reader["CreePar"];
                                PrixPaye = Convert.ToDecimal(reader["PrixPaye"]);
                                EtatAbonnement = (byte)reader["EtatAbonnement"];
                            }
                        }
                    }
                    catch (Exception)
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

        public static DataTable GetAllAbonnements()
        {
            DataTable dt = new DataTable();
            string query = @"select * from View_ListAbonnement";

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
                    }
                    catch (Exception)
                    {
                        
                        connection.Close();
                        return null;
                    }
                }
            }

            return dt;
        }

        public static int AddNewAbonnement(int AdherentID, int TypeAbonnementID,
            DateTime DateDebut, DateTime DateFin, int CreePar, decimal PrixPaye, byte EtatAbonnement)
        {
            int abonnementID = -1;

            string query = @"INSERT INTO Abonnements 
                            (AdherentID, TypeAbonnementID, DateDebut, DateFin, CreePar, PrixPaye, EtatAbonnement) 
                        VALUES 
                            (@AdherentID, @TypeAbonnementID, @DateDebut, @DateFin, @CreePar, @PrixPaye, @EtatAbonnement); 
                        SELECT SCOPE_IDENTITY();";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@AdherentID", AdherentID);
                    command.Parameters.AddWithValue("@TypeAbonnementID", TypeAbonnementID);
                    command.Parameters.AddWithValue("@DateDebut", DateDebut);
                    command.Parameters.AddWithValue("@DateFin", DateFin);
                    command.Parameters.AddWithValue("@CreePar", CreePar);
                    command.Parameters.AddWithValue("@PrixPaye", PrixPaye);
                    command.Parameters.AddWithValue("@EtatAbonnement", EtatAbonnement);

                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            abonnementID = insertedID;
                        }
                    }
                    catch (Exception)
                    {
                        abonnementID = -1;
                    }
                }
            }

            return abonnementID;
        }

        public static bool UpdateAbonnement(int AbonnementID, int AdherentID, int TypeAbonnementID,
            DateTime DateDebut, DateTime DateFin, int CreePar, decimal PrixPaye, byte EtatAbonnement)
        {
            int rowsAffected = 0;

            string query = @"UPDATE Abonnements
                             SET AdherentID = @AdherentID,
                                 TypeAbonnementID = @TypeAbonnementID,
                                 DateDebut = @DateDebut,
                                 DateFin = @DateFin,
                                 CreePar = @CreePar,
                                 PrixPaye = @PrixPaye,
                                 EtatAbonnement = @EtatAbonnement
                             WHERE AbonnementID = @AbonnementID";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@AbonnementID", AbonnementID);
                    command.Parameters.AddWithValue("@AdherentID", AdherentID);
                    command.Parameters.AddWithValue("@TypeAbonnementID", TypeAbonnementID);
                    command.Parameters.AddWithValue("@DateDebut", DateDebut);
                    command.Parameters.AddWithValue("@DateFin", DateFin);
                    command.Parameters.AddWithValue("@CreePar", CreePar);
                    command.Parameters.AddWithValue("@PrixPaye", PrixPaye);
                    command.Parameters.AddWithValue("@EtatAbonnement", EtatAbonnement);

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

        
        public static bool IsAbonnementExist(int AbonnementID)
        {
            bool isFound = false;

            string query = @"SELECT Found = 1 FROM Abonnements WHERE AbonnementID = @AbonnementID";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@AbonnementID", AbonnementID);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            isFound = reader.HasRows;
                        }
                    }
                    catch (Exception)
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



    }
}