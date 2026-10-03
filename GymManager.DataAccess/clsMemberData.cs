using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.DataAccess
{

        public class clsMemberData
        {
            // =========================================================
            // Find Member
            // =========================================================

            public static bool FindMember(
                int MemberID,
                ref int PersonID,
                ref DateTime CreatedAt,
                ref int CreatedBy,
                ref bool IsActif)
            {
                bool isFound = false;

                SqlConnection connection =
                    new SqlConnection(clsDataAccessSettings.connectionString);

                string query = @"
SELECT *
FROM Adherents
WHERE AdherentID = @MemberID";


                SqlCommand command =
                    new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@MemberID", MemberID);


                try
                {
                    connection.Open();

                    SqlDataReader reader =
                        command.ExecuteReader();

                    if (reader.Read())
                    {
                        // Record was found
                        isFound = true;

                        PersonID = (int)reader["PersonneID"];
                        CreatedAt = (DateTime)reader["DateAjout"];
                        CreatedBy = (int)reader["CreePar"];
                        IsActif = (bool)reader["EstActif"];
                    }
                    else
                    {
                        // Record was not found
                        isFound = false;
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    isFound = false;
                }
                finally
                {
                    connection.Close();
                }

                return isFound;
            }


            // =========================================================
            // Add New Member
            // =========================================================

            public static int AddNewMember(
                int PersonID,
                DateTime CreatedAt,
                int CreatedBy,
                bool IsActif)
            {
                int addedMemberID = -1;

                SqlConnection connection =
                    new SqlConnection(clsDataAccessSettings.connectionString);


                string query = @"
INSERT INTO Adherents
(
    PersonneID,
    DateAjout,
    CreePar,
    EstActif
)
VALUES
(
    @PersonneID,
    @DateAjout,
    @CreePar,
    @EstActif
);

SELECT SCOPE_IDENTITY();
";


                SqlCommand command =
                    new SqlCommand(query, connection);


                command.Parameters.AddWithValue(
                    "@PersonneID",
                    PersonID);

                command.Parameters.AddWithValue(
                    "@DateAjout",
                    CreatedAt);

                command.Parameters.AddWithValue(
                    "@CreePar",
                    CreatedBy);

                command.Parameters.AddWithValue(
                    "@EstActif",
                    IsActif);


                try
                {
                    connection.Open();

                    object result =
                        command.ExecuteScalar();


                    if (result != null &&
                        int.TryParse(
                            result.ToString(),
                            out int insertedID))
                    {
                        addedMemberID = insertedID;
                    }
                }
                catch (Exception ex)
                {
                }
                finally
                {
                    connection.Close();
                }

                return addedMemberID;
            }


            // =========================================================
            // Update Member
            // =========================================================

            public static bool UpdateMember(
                int MemberID,
                int PersonID,
                DateTime CreatedAt,
                int CreatedBy,
                bool IsActif)
            {
                bool isFound = false;

                SqlConnection connection =
                    new SqlConnection(clsDataAccessSettings.connectionString);


                string query = @"
UPDATE Adherents
SET
    PersonneID = @PersonneID,
    DateAjout = @DateAjout,
    CreePar = @CreePar,
    EstActif = @EstActif
WHERE AdherentID = @MemberID;
";


                SqlCommand command =
                    new SqlCommand(query, connection);


                command.Parameters.AddWithValue(
                    "@MemberID",
                    MemberID);

                command.Parameters.AddWithValue(
                    "@PersonneID",
                    PersonID);

                command.Parameters.AddWithValue(
                    "@DateAjout",
                    CreatedAt);

                command.Parameters.AddWithValue(
                    "@CreePar",
                    CreatedBy);

                command.Parameters.AddWithValue(
                    "@EstActif",
                    IsActif);


                try
                {
                    connection.Open();

                    int rowsAffected =
                        command.ExecuteNonQuery();

                    isFound = rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    isFound = false;
                }
                finally
                {
                    connection.Close();
                }

                return isFound;
            }


            // =========================================================
            // Check If Member Exists
            // =========================================================

            public static bool IsMemberExist(int MemberID)
            {
                bool isFound = false;

                SqlConnection connection =
                    new SqlConnection(clsDataAccessSettings.connectionString);


                string query = @"
SELECT *
FROM Adherents
WHERE AdherentID = @MemberID";


                SqlCommand command =
                    new SqlCommand(query, connection);

                command.Parameters.AddWithValue(
                    "@MemberID",
                    MemberID);


                try
                {
                    connection.Open();

                    SqlDataReader reader =
                        command.ExecuteReader();

                    if (reader.HasRows)
                        isFound = true;
                    else
                        isFound = false;
                }
                catch (Exception ex)
                {
                    isFound = false;
                }
                finally
                {
                    connection.Close();
                }

                return isFound;
            }


            // =========================================================
            // Get All Members
            // =========================================================

            public static DataTable GetAllMembers()
            {
                DataTable dt = new DataTable();

                SqlConnection connection =
                    new SqlConnection(
                        clsDataAccessSettings.connectionString);


                string query = @"
SELECT Adherents.AdherentID, Adherents.PersonneID , Personnes.Prenom , Personnes.Nom, Personnes.NumeroTelephone, Personnes.Email, Personnes.DateDeNaissance, Personnes.Genre, Personnes.Image, 
                  Adherents.DateAjout, Adherents.CreePar, Adherents.EstActif
FROM     Adherents INNER JOIN
                  Personnes ON Adherents.PersonneID = Personnes.PersonneID";


                SqlCommand command =
                    new SqlCommand(query, connection);


                try
                {
                    connection.Open();

                    SqlDataReader reader =
                        command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        dt.Load(reader);
                    }

                    reader.Close();
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
        }
    
}
