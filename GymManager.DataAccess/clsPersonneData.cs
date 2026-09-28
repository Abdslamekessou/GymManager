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
    public class clsPersonneData
    {

        public static bool FindPersonne(int ID , ref string Prenom ,ref string Nom ,ref string NumeroTelephone ,ref string Email ,ref DateTime DateDeNaissance ,ref byte Genre ,ref string Image)
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

                    Prenom = (string)reader["Prenom"];
                    Nom = (string)reader["Nom"];
                    NumeroTelephone = (string)reader["NumeroTelephone"];
                    DateDeNaissance = (DateTime)reader["DateDeNaissance"];
                    Genre = (byte)reader["Genre"];
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

        public static DataTable GetAllPersonnes()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query =
  @"select  Personnes.PersonneID , Personnes.Prenom , Personnes.Nom , Personnes.NumeroTelephone , Personnes.Email , 
		Personnes.DateDeNaissance , Personnes.Genre , 				  CASE
                  WHEN Personnes.Genre = 0 THEN 'Male'

                  ELSE 'Female'

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
