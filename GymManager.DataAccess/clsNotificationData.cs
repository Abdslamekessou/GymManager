using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.DataAccess
{
    public class clsNotificationData
    {
        public static DataTable GetAllNotifications()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            //            string query = @"SELECT 
            //N.NotificationID,
            //P.Nom +' '+ P.Prenom as MemberName,
            //S.Nom as Sport,
            //T.Nom as SubscriptionType,
            //CASE 
            //When A.EtatAbonnement = 0 then 'Active'
            //when A.EtatAbonnement = 1 then 'Expired'
            //when A.EtatAbonnement = 2 then 'Expiring Soon'
            //when A.EtatAbonnement = 3 then 'Cancelled'
            //End as AbonnementStatus,

            //CASE
            //WHEN N.EstVue = 0 then 'Lu'
            //Else 'Non Lu'
            //End as ReadStatus ,

            //CASE
            //WHEN N.EstExportee = 0 then 'Exporté'
            //Else 'Non Exporté'
            //End as Exportation 

            //FROM   Notifications as N INNER JOIN
            //             Abonnements as A ON N.AbonnementID = A.AbonnementID INNER JOIN
            //             Adherents AD ON A.AdherentID = AD.AdherentID INNER JOIN
            //             Personnes as P ON AD.PersonneID = P.PersonneID INNER JOIN
            //             TypeAbonnements as T ON A.TypeAbonnementID = T.TypeAbonnementID INNER JOIN
            //             Sports as S ON T.SportID = S.SportID
            //";

            string query = @"select * from Notifications_View";

            SqlCommand cmd = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    dt.Load(reader);
                }

            }
            catch (Exception ex)
            {

            }finally
            {
                connection.Close();
            }
            return dt;

        }
    }
}
