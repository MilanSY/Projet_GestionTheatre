using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TheatreDAL
{
    public class TheatreDAO
    {
        public static void UpdateTheatre(string nom, string adresse, string ville, string codePostal, string telephone, string courriel, string siteWeb, string description)
        {
            string connectionString = "your_connection_string_here";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Theatre SET Nom = @nom, Adresse = @adresse, Ville = @ville, CodePostal = @codePostal, Telephone = @telephone, Courriel = @courriel, SiteWeb = @siteWeb, Description = @description WHERE Nom = @nom";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@nom", nom);
                command.Parameters.AddWithValue("@adresse", adresse);
                command.Parameters.AddWithValue("@ville", ville);
                command.Parameters.AddWithValue("@codePostal", codePostal);
                command.Parameters.AddWithValue("@telephone", telephone);
                command.Parameters.AddWithValue("@courriel", courriel);
                command.Parameters.AddWithValue("@siteWeb", siteWeb);
                command.Parameters.AddWithValue("@description", description);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
