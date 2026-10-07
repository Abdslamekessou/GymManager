using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.DataAccess
{
    public class clsPersonData
    {

        public static bool FindPerson(int ID , ref string FirstName ,ref string LastName ,ref string PhoneNumber ,ref string Email ,ref DateTime DateOfBirth ,ref byte Gendor ,ref string Image)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);


            string query = "SELECT * FROM Personnes WHERE PersonneID = @id";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@id", ID);


            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    // The record was found
                    isFound = true;

                    FirstName = (string)reader["Prenom"];
                    LastName = (string)reader["Nom"];
                    PhoneNumber = (string)reader["NumeroTelephone"];
                    DateOfBirth = (DateTime)reader["DateDeNaissance"];
                    Gendor = (byte)reader["Genre"];
                    Email = reader["Email"] == DBNull.Value ? null : (string)reader["Email"];
                    Image = reader["Image"] == DBNull.Value ? null : (string)reader["Image"];

                }
                else
                {
                    // The record was not found
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

        public static int AddNewPerson(string FirstName, string LastName, string PhoneNumber, string Email, DateTime DateOfBirth , byte Gendor , string Image )
        {
            int addedPersonId = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"
INSERT INTO Personnes
(
    Prenom,
    Nom,
    NumeroTelephone,
    Email,
    DateDeNaissance,
    Genre,
    Image
    
)
VALUES
(
    @Prenom,
    @Nom,
    @NumeroTelephone,
    @Email,
    @DateDeNaissance,
    @Genre,
    @Image
   
);

SELECT SCOPE_IDENTITY();
";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Prenom", FirstName );
            command.Parameters.AddWithValue("@Nom", LastName);
            command.Parameters.AddWithValue("@NumeroTelephone", PhoneNumber);
            command.Parameters.AddWithValue("@DateDeNaissance", DateOfBirth);
            command.Parameters.AddWithValue("@Genre", Gendor);


            if (Email != "" && Email != null)
                command.Parameters.AddWithValue("@Email", Email);
            else
                command.Parameters.AddWithValue("@Email", DBNull.Value);


            if (Image != "" && Image != null)
                command.Parameters.AddWithValue("@Image", Image);
            else
                command.Parameters.AddWithValue("@Image", DBNull.Value);


            try
            {
                connection.Open();

                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    addedPersonId = insertedID;
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return addedPersonId;

        }

        public static bool UpdatePerson(int PersonID, string FirstName, string LastName,
    string PhoneNumber, string Email, DateTime DateOfBirth, byte Gendor, string Image)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"
UPDATE Personnes
SET
    Prenom = @Prenom,
    Nom = @Nom,
    NumeroTelephone = @NumeroTelephone,
    Email = @Email,
    DateDeNaissance = @DateDeNaissance,
    Genre = @Genre,
    Image = @Image
WHERE PersonneID = @PersonID;
";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@Prenom", FirstName);
            command.Parameters.AddWithValue("@Nom", LastName);
            command.Parameters.AddWithValue("@NumeroTelephone", PhoneNumber);
            command.Parameters.AddWithValue("@DateDeNaissance", DateOfBirth);
            command.Parameters.AddWithValue("@Genre", Gendor);

            if (!string.IsNullOrEmpty(Email))
                command.Parameters.AddWithValue("@Email", Email);
            else
                command.Parameters.AddWithValue("@Email", DBNull.Value);

            if (!string.IsNullOrEmpty(Image))
                command.Parameters.AddWithValue("@Image", Image);
            else
                command.Parameters.AddWithValue("@Image", DBNull.Value);


            try
            {
                connection.Open();

                int rowsAffected = command.ExecuteNonQuery();

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

        public static bool isPersonExist(int id)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);


            string query = "SELECT * FROM Personnes WHERE PersonneID = @id";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@id", id);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

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


        public static DataTable GetAllPersons()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query =
  @"select  Personnes.PersonneID , Personnes.Prenom , Personnes.Nom , Personnes.NumeroTelephone , Personnes.Email , 
		Personnes.DateDeNaissance , Personnes.Genre , 				  CASE
                  WHEN Personnes.Genre = 0 THEN 'Homme'

                  ELSE 'Femme'

                  END as GendorCaption , 
				  Personnes.Image
from Personnes";


            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

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
