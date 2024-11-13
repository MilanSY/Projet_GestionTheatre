using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using TheatreBO;

namespace TheatreDAL
{
    public class TheatreDAO
    {
        private static TheatreDAO unTheatreDAO;

        // Accesseur en lecture, renvoi une instance
        public static TheatreDAO GetUnTheatre()
        {
            if (unTheatreDAO == null)
            {
                unTheatreDAO = new TheatreDAO();
            }
            return unTheatreDAO;
        }
        public static void UpdateTheatre(string nom, string adresse, string ville, string codePostal, string telephone, string courriel, string siteWeb, string description)
        {
            string connectionString = ConnexionBD.GetConnexionBD().GetchaineConnexion();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE Theatre SET Nom = @nom, Adresse = @adresse, Ville = @ville, CodePostal = @codePostal, Telephone = @telephone, Courriel = @courriel, SiteWeb = @siteWeb, Description = @description WHERE Nom = @nom";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Protection des données avec des reqûetes paramétrées
                    command.Parameters.Add(new SqlParameter("@nom", System.Data.SqlDbType.NVarChar) { Value = nom });
                    command.Parameters.Add(new SqlParameter("@adresse", System.Data.SqlDbType.NVarChar) { Value = adresse });
                    command.Parameters.Add(new SqlParameter("@ville", System.Data.SqlDbType.NVarChar) { Value = ville });
                    command.Parameters.Add(new SqlParameter("@codePostal", System.Data.SqlDbType.NVarChar) { Value = codePostal });
                    command.Parameters.Add(new SqlParameter("@telephone", System.Data.SqlDbType.NVarChar) { Value = telephone });
                    command.Parameters.Add(new SqlParameter("@courriel", System.Data.SqlDbType.NVarChar) { Value = courriel });
                    command.Parameters.Add(new SqlParameter("@siteWeb", System.Data.SqlDbType.NVarChar) { Value = siteWeb });
                    command.Parameters.Add(new SqlParameter("@description", System.Data.SqlDbType.NVarChar) { Value = description });
                }
                connection.Close();
            }
        }

        public Theatre GetTheatreById(int id)
        {
            string connectionString = ConnexionBD.GetConnexionBD().GetchaineConnexion();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Theatre WHERE Id = @id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add(new SqlParameter("@id", System.Data.SqlDbType.Int) { Value = id });
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Theatre theatre = new Theatre(reader["Nom"].ToString(), reader["Adresse"].ToString(), reader["Ville"].ToString(), reader["CodePostal"].ToString(), reader["Telephone"].ToString(), reader["Courriel"].ToString(), reader["SiteWeb"].ToString(), reader["Description"].ToString());
                            return theatre;
                        }
                    }
                }
                connection.Close();
            }
            return null;
        }
    }
}
