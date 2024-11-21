using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using TheatreBO;
using System.Collections;

namespace TheatreDAL
{
    public class TheatreDAO
    {
        public static void UpdateTheatre(int id, string nom, float prix, string description, int? duree, string compagnie, string publicCateg, string theme, string auteurPrenom, string auteurNom)
        {
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
            
            //    connection.Close();

        }

        public static List<TheatreVue> GetTheatres()
        {
            int id;
            string nom, description;
            Compagnie compagnie;
            Publics publicCateg;
            Theme theme;
            Auteur auteur;
            float prix;
            int? duree;

            string connectionString = ConnexionBD.GetConnexionBD().GetchaineConnexion();
            SqlConnection connection = new SqlConnection(connectionString);


            // Création d'une liste vide d'objets Theatre
            List<TheatreVue> listTheatres = new List<TheatreVue>();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = @"
                SELECT p.pie_id,
                    p.pie_nom,
                    p.pie_prix,
                    p.pie_descrip,
                    p.pie_duree,
                    p.pie_comp,
                    p.pie_pub,
                    p.pie_the,
                    p.pie_aut,
                    c.comp_nom AS compagnieNom,
                    c.comp_ville AS compagnieVille,
                    c.comp_directeur AS compagnieDirecteur,
                    pu.pub_categ AS publicCateg, 
                    t.the_nom AS theme,
                    a.aut_prenom AS auteurPrenom,
                    a.aut_nom AS auteurNom 
                FROM Pieces p 
                LEFT JOIN Compagnies c ON p.pie_comp = c.comp_id 
                LEFT JOIN Publics pu ON p.pie_pub = pu.pub_id 
                LEFT JOIN Theme t ON p.pie_the = t.the_id 
                LEFT JOIN Auteur a ON p.pie_aut = a.aut_id;";
            connection.Open();

            SqlDataReader monReader = cmd.ExecuteReader();


            // Remplissage de la liste
            while (monReader.Read())
            {
                id = Int32.Parse(monReader["pie_id"].ToString());
                nom = monReader["pie_nom"].ToString();
                prix = float.Parse(monReader["pie_prix"].ToString());
                description = monReader["pie_descrip"] == DBNull.Value ? default(string) : monReader["pie_descrip"].ToString();
                duree = monReader["pie_duree"] == DBNull.Value ? (int?)null : Int32.Parse(monReader["pie_duree"].ToString());
                compagnie = monReader["compagnieNom"] == DBNull.Value ? new Compagnie() : new Compagnie(Int32.Parse(monReader["pie_comp"].ToString()), monReader["compagnieNom"].ToString(), monReader["compagnieVille"].ToString(), monReader["compagnieDirecteur"].ToString());
                publicCateg = monReader["publicCateg"] == DBNull.Value ? new Publics() : new Publics(Int32.Parse(monReader["pie_pub"].ToString()), monReader["publicCateg"].ToString());
                theme = monReader["theme"] == DBNull.Value ? new Theme() : new Theme(Int32.Parse(monReader["pie_the"].ToString()), monReader["theme"].ToString());
                auteur = (monReader["auteurPrenom"] == DBNull.Value && monReader["auteurNom"] == DBNull.Value) ? new Auteur() : new Auteur(Int32.Parse(monReader["pie_aut"].ToString()), monReader["auteurNom"].ToString(), monReader["auteurPrenom"].ToString());

                // Création d'un objet Theatre
                Theatre unTheatre = new Theatre(id, nom, prix, description, duree, compagnie, publicCateg, theme, auteur);
                TheatreVue vue = new TheatreBO.TheatreVue(unTheatre);
                // Ajout à la liste
                listTheatres.Add(vue);
            }

            // Fermeture de la connexion
            connection.Close();

            return listTheatres;
        }



        //prend en paramètre un id et renvoie la piece de théâtre avec cet identifiant, et null si l'identifiant équivaut à rien
        public static Theatre GetTheatreById(int id)
        {
            string nom, description;
            Compagnie compagnie;
            Publics publicCateg;
            Theme theme;
            Auteur auteur;
            float prix;
            int? duree;

            string connectionString = ConnexionBD.GetConnexionBD().GetchaineConnexion();
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = @"
                SELECT p.pie_id,
                    p.pie_nom,
                    p.pie_prix,
                    p.pie_descrip,
                    p.pie_duree,
                    p.pie_comp,
                    p.pie_pub,
                    p.pie_the,
                    p.pie_aut,
                    c.comp_nom AS compagnieNom,
                    c.comp_ville AS compagnieVille,
                    c.comp_directeur AS compagnieDirecteur,
                    pu.pub_categ AS publicCateg, 
                    t.the_nom AS theme,
                    a.aut_prenom AS auteurPrenom,
                    a.aut_nom AS auteurNom 
                FROM Pieces p 
                LEFT JOIN Compagnies c ON p.pie_comp = c.comp_id 
                LEFT JOIN Publics pu ON p.pie_pub = pu.pub_id 
                LEFT JOIN Theme t ON p.pie_the = t.the_id 
                LEFT JOIN Auteur a ON p.pie_aut = a.aut_id
                WHERE p.pie_id = @id;"; 

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.Add(new SqlParameter("@id", System.Data.SqlDbType.Int) { Value = id });
            SqlDataReader monReader = cmd.ExecuteReader();

            if (monReader.Read())
            {
                nom = monReader["pie_nom"].ToString();
                prix = float.Parse(monReader["pie_prix"].ToString());
                description = monReader["pie_descrip"] == DBNull.Value ? default(string) : monReader["pie_descrip"].ToString();
                duree = monReader["pie_duree"] == DBNull.Value ? (int?)null : Int32.Parse(monReader["pie_duree"].ToString());
                compagnie = monReader["compagnie"] == DBNull.Value ? new Compagnie() : new Compagnie(Int32.Parse(monReader["pie_comp"].ToString()), monReader["compagnieNom"].ToString(), monReader["compagnieVille"].ToString(), monReader["compagnieDirecteur"].ToString());
                publicCateg = monReader["publicCateg"] == DBNull.Value ? new Publics() : new Publics(Int32.Parse(monReader["pie_pub"].ToString()), monReader["publicCateg"].ToString());
                theme = monReader["theme"] == DBNull.Value ? new Theme() : new Theme(Int32.Parse(monReader["pie_the"].ToString()), monReader["theme"].ToString());
                auteur = (monReader["auteurPrenom"] == DBNull.Value && monReader["auteurNom"] == DBNull.Value) ? new Auteur() : new Auteur(Int32.Parse(monReader["pie_aut"].ToString()), monReader["auteurNom"].ToString(), monReader["auteurPrenom"].ToString());

                // Création d'un objet Theatre
                Theatre unTheatre = new Theatre(id, nom, prix, description, duree, compagnie, publicCateg, theme, auteur);

                connection.Close();

                return unTheatre;
            }
                    
            connection.Close();
            
            return null;
        }

        public static bool SupprimerTheatre(int id)
        {

            string connectionString = ConnexionBD.GetConnexionBD().GetchaineConnexion();
            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();
            string query = "DELETE FROM Pieces WHERE pie_id = @id;";


            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.Add(new SqlParameter("@id", System.Data.SqlDbType.Int) { Value = id });

            try
            {
                SqlDataReader monReader = cmd.ExecuteReader();
                return true; // Retourne true si une ligne a été supprimée
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur : {ex.Message}");
                return false;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
