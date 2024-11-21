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
<<<<<<< Updated upstream
            if (unTheatreDAO == null)
=======
            string connectionString = ConnexionBD.GetConnexionBD().GetchaineConnexion();
            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();
            string query =  @"
                UPDATE Pieces
                SET pie_nom = @nom,
                    pie_prix = @prix,
                    pie_descrip = @description,
                    pie_duree = @duree,
                    pie_comp = @compagnieId,
                    pie_pub = @publicId,
                    pie_the = @themeId,
                    pie_aut = @auteurId
                WHERE pie_id = @id";
            SqlCommand command = new SqlCommand(query, connection);

            //using (SqlCommand command = new SqlCommand(query, connection)) -- >  pas de ça (chat gpt...)
            
            // Ajout des paramètres
            command.Parameters.Add(new SqlParameter("@id", System.Data.SqlDbType.Int) { Value = id });
            command.Parameters.Add(new SqlParameter("@nom", System.Data.SqlDbType.NVarChar) { Value = nom });
            command.Parameters.Add(new SqlParameter("@prix", System.Data.SqlDbType.Float) { Value = prix });
            command.Parameters.Add(new SqlParameter("@description", System.Data.SqlDbType.NVarChar) { Value = description ?? (object)DBNull.Value });
            command.Parameters.Add(new SqlParameter("@duree", System.Data.SqlDbType.Int) { Value = duree ?? (object)DBNull.Value });
            //faire une fonction GestionCompanie.getCompanyIdByName(nom)
            command.Parameters.Add(new SqlParameter("@compagnieId", System.Data.SqlDbType.Int) { Value = compagnie });
            //faire une fonction GestionPublic.getPublicIdByName(type)
            command.Parameters.Add(new SqlParameter("@publicId", System.Data.SqlDbType.Int) { Value = publicCateg });
            //faire une fonction GestionTheme.getThemeIdByName(nom)
            command.Parameters.Add(new SqlParameter("@themeId", System.Data.SqlDbType.Int) { Value = theme });
            //faire une fonction GestionAueur.getAuteurIdByNames(prenom, nom)
            command.Parameters.Add(new SqlParameter("@auteurId", System.Data.SqlDbType.Int) { Value = (auteurPrenom,auteurNom) });

            // Exécution de la commande
            command.ExecuteNonQuery();
            
            // Connection.Close();

        }

        public static List<Theatre> GetTheatres()
        {
            int id;
            string nom, description, compagnie, publicCateg, theme, auteur;
            float prix;
            int? duree;

            string connectionString = ConnexionBD.GetConnexionBD().GetchaineConnexion();
            SqlConnection connection = new SqlConnection(connectionString) ;


            // Création d'une liste vide d'objets Theatre
            List<Theatre> listTheatres = new List<Theatre>();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = @"
                SELECT p.pie_id, p.pie_nom,
                    p.pie_prix,
                    p.pie_descrip,
                    p.pie_duree,
                    c.comp_nom AS compagnie,
                    pu.pub_categ AS publicCateg, 
                    t.the_nom AS theme, 
                    CONCAT(a.aut_prenom, ' ', a.aut_nom) AS auteur 
                FROM Pieces p 
                LEFT JOIN Compagnies c ON p.pie_comp = c.comp_id 
                LEFT JOIN Publics pu ON p.pie_pub = pu.pub_id 
                LEFT JOIN Theme t ON p.pie_the = t.the_id 
                LEFT JOIN Auteur a ON p.pie_aut = a.aut_id;";
            connection.Open();

            SqlDataReader monReader = cmd.ExecuteReader();


            // Remplissage de la liste
            while (monReader.Read())
>>>>>>> Stashed changes
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
