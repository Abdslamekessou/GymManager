using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.DataAccess
{
    public class clsPersonneData
    {

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
