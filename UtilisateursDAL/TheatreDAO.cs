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
        public static void UpdateTheatre(Theatre unTheatre)
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
            unTheatre.auteur.id = GetAuteurIdByName(unTheatre.auteur);
            unTheatre.compagnie.id = GetCompagnieIdByName(unTheatre.compagnie.nom);
            unTheatre.publicCateg.id = GetPublicIdByName(unTheatre.publicCateg.categ);
            unTheatre.theme.id = GetThemeByIdByName(unTheatre.theme.nom);
            command.Parameters.Add(new SqlParameter("@id", System.Data.SqlDbType.Int) { Value = unTheatre.id });
            command.Parameters.Add(new SqlParameter("@nom", System.Data.SqlDbType.NVarChar) { Value = unTheatre.nom });
            command.Parameters.Add(new SqlParameter("@prix", System.Data.SqlDbType.Float) { Value = unTheatre.prix });
            command.Parameters.Add(new SqlParameter("@description", System.Data.SqlDbType.NVarChar) { Value = unTheatre.description ?? (object)DBNull.Value });
            command.Parameters.Add(new SqlParameter("@duree", System.Data.SqlDbType.Int) { Value = unTheatre.duree ?? (object)DBNull.Value });
            command.Parameters.Add(new SqlParameter("@compagnieId", System.Data.SqlDbType.Int) { Value = unTheatre.compagnie.id });
            command.Parameters.Add(new SqlParameter("@publicId", System.Data.SqlDbType.Int) { Value = unTheatre.publicCateg.id });
            command.Parameters.Add(new SqlParameter("@themeId", System.Data.SqlDbType.Int) { Value = unTheatre.theme.id });
            command.Parameters.Add(new SqlParameter("@auteurId", System.Data.SqlDbType.Int) { Value = unTheatre.auteur.id });

            // Exécution de la commande
            command.ExecuteNonQuery();
            
            connection.Close();

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

        public static List<Theatre> GetTheatresObject()
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
            List<Theatre> listTheatres = new List<Theatre>();

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
                // Ajout à la liste
                listTheatres.Add(unTheatre);
            }

            // Fermeture de la connexion
            connection.Close();

            return listTheatres;
        }

        // Prend en paramètre un id et renvoie la piece de théâtre avec cet identifiant, et null si l'identifiant équivaut à rien
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
                compagnie = monReader["pie_comp"] == DBNull.Value ? new Compagnie() : new Compagnie(Int32.Parse(monReader["pie_comp"].ToString()), monReader["compagnieNom"].ToString(), monReader["compagnieVille"].ToString(), monReader["compagnieDirecteur"].ToString());
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

        public static int GetTheatreIdByName(string nom)
        {
            int id;

            string connectionString = ConnexionBD.GetConnexionBD().GetchaineConnexion();
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = @"
                SELECT p.pie_id
                FROM Pieces p 
                WHERE p.pie_nom = @nom;";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.Add(new SqlParameter("@nom", System.Data.SqlDbType.NVarChar) { Value = nom });
            SqlDataReader monReader = cmd.ExecuteReader();


            if (monReader.Read())
            {
                Int32.TryParse(monReader["pie_id"].ToString(), out id);

                connection.Close();

                return id;
            }

            connection.Close();

            return -1;
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

        public static bool AjoutTheatre(Theatre unTheatre)
        {
            string connectionString = ConnexionBD.GetConnexionBD().GetchaineConnexion();
            SqlConnection connection = new SqlConnection(connectionString);

            string query = @"
                INSERT INTO Pieces(pie_nom, pie_prix, pie_descrip, pie_duree, pie_comp, pie_pub, pie_the, pie_aut) 
                VALUES
                (@nom,
                 @prix,
                 @description,
                 @duree,
                 @compagnieId,
                 @publicId,
                 @themeId,
                 @auteurId)";
            SqlCommand command = new SqlCommand(query, connection);
            unTheatre.auteur.id = GetAuteurIdByName(unTheatre.auteur);
            unTheatre.compagnie.id = GetCompagnieIdByName(unTheatre.compagnie.nom);
            unTheatre.publicCateg.id = GetPublicIdByName(unTheatre.publicCateg.categ);
            unTheatre.theme.id = GetThemeByIdByName(unTheatre.theme.nom);
            command.Parameters.Add(new SqlParameter("@id", System.Data.SqlDbType.Int) { Value = unTheatre.id });
            command.Parameters.Add(new SqlParameter("@nom", System.Data.SqlDbType.NVarChar) { Value = unTheatre.nom });
            command.Parameters.Add(new SqlParameter("@prix", System.Data.SqlDbType.Float) { Value = unTheatre.prix });
            command.Parameters.Add(new SqlParameter("@description", System.Data.SqlDbType.NVarChar) { Value = unTheatre.description ?? (object)DBNull.Value });
            command.Parameters.Add(new SqlParameter("@duree", System.Data.SqlDbType.Int) { Value = unTheatre.duree ?? (object)DBNull.Value });
            command.Parameters.Add(new SqlParameter("@compagnieId", System.Data.SqlDbType.Int) { Value = unTheatre.compagnie.id });
            command.Parameters.Add(new SqlParameter("@publicId", System.Data.SqlDbType.Int) { Value = unTheatre.publicCateg.id });
            command.Parameters.Add(new SqlParameter("@themeId", System.Data.SqlDbType.Int) { Value = unTheatre.theme.id });
            command.Parameters.Add(new SqlParameter("@auteurId", System.Data.SqlDbType.Int) { Value = unTheatre.auteur.id });

            connection.Open();
            // Exécution de la commande
            command.ExecuteNonQuery();

            connection.Close();

            return true;
        }

        public static List<Auteur> GetAuteurs()
        {
            int id;
            string nom;
            string prenom;
            List<Auteur> listAuteur = new List<Auteur>() ;

            string connectionString = ConnexionBD.GetConnexionBD().GetchaineConnexion();
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "SELECT * FROM Auteur";

            connection.Open();

            SqlDataReader monReader = cmd.ExecuteReader();

            // Remplissage de la liste
            while (monReader.Read())
            {
                id = Int32.Parse(monReader["aut_id"].ToString());
                nom = monReader["aut_nom"].ToString();
                prenom = monReader["aut_prenom"].ToString();
                Auteur unAuteur = new Auteur(id, nom, prenom);

                // Ajout à la liste
                listAuteur.Add(unAuteur);
            }

            // Fermeture de la connexion
            connection.Close();

            return listAuteur;
        }

        public static int GetAuteurIdByName(Auteur auteur)
        {
            string connectionString = ConnexionBD.GetConnexionBD().GetchaineConnexion();
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "SELECT aut_id FROM Auteur WHERE aut_nom = @aut_nom AND aut_prenom = @aut_prenom";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.Add(new SqlParameter("@aut_nom", System.Data.SqlDbType.NVarChar) { Value = auteur.nom });
            command.Parameters.Add(new SqlParameter("@aut_prenom", System.Data.SqlDbType.NVarChar) { Value = auteur.prenom });
            var result = command.ExecuteScalar();
            connection.Close();

            if (result != null)
            {
                return (int)result;
            }
            else
            {
                throw new Exception("Auteur not found");
            }
        }

        public static List<Compagnie> GetCompagnies()
        {
            int id;
            string nom;
            string ville;
            string directeur;
            List<Compagnie> listCompagnie = new List<Compagnie>();

            string connectionString = ConnexionBD.GetConnexionBD().GetchaineConnexion();
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "SELECT * FROM Compagnies";
            SqlCommand cmd = new SqlCommand(query, connection);

            SqlDataReader monReader = cmd.ExecuteReader();


            // Remplissage de la liste
            while (monReader.Read())
            {
                id = Int32.Parse(monReader["comp_id"].ToString());
                nom = monReader["comp_nom"].ToString();
                ville = monReader["comp_ville"].ToString();
                directeur = monReader["comp_directeur"].ToString();
                Compagnie uneCompagnie = new Compagnie(id, nom, ville, directeur);

                // Ajout à la liste
                listCompagnie.Add(uneCompagnie);
            }

            // Fermeture de la connexion
            connection.Close();

            return listCompagnie;
        }

        public static int GetCompagnieIdByName(string nom)
        {
            string connectionString = ConnexionBD.GetConnexionBD().GetchaineConnexion();
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "SELECT comp_id FROM Compagnies WHERE comp_nom = @nom";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.Add(new SqlParameter("@nom", System.Data.SqlDbType.NVarChar) { Value = nom });

            int compagnieId = (int)command.ExecuteScalar();
            connection.Close();

            return compagnieId;
        }

        public static List<Publics> GetPublics()
        {
            int id;
            string categ;
            List<Publics> listPublic = new List<Publics>();

            string connectionString = ConnexionBD.GetConnexionBD().GetchaineConnexion();
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "SELECT * FROM Publics";
            SqlCommand cmd = new SqlCommand(query, connection);

            SqlDataReader monReader = cmd.ExecuteReader();


            // Remplissage de la liste
            while (monReader.Read())
            {
                id = Int32.Parse(monReader["pub_id"].ToString());
                categ = monReader["pub_categ"].ToString();
                Publics unPublic = new Publics(id, categ);

                // Ajout à la liste
                listPublic.Add(unPublic);
            }

            // Fermeture de la connexion
            connection.Close();

            return listPublic;
        }

        public static int GetPublicIdByName(string categ)
        {
            string connectionString = ConnexionBD.GetConnexionBD().GetchaineConnexion();
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "SELECT pub_id FROM Publics WHERE pub_categ = @categ";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.Add(new SqlParameter("@categ", System.Data.SqlDbType.NVarChar) { Value = categ });

            int publicId = (int)command.ExecuteScalar();
            connection.Close();

            return publicId;
        }

        public static List<Theme> GetThemes()
        {
            int id;
            string nom;
            List<Theme> listTheme = new List<Theme>();

            string connectionString = ConnexionBD.GetConnexionBD().GetchaineConnexion();
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "SELECT * FROM Theme";
            SqlCommand cmd = new SqlCommand(query, connection);

            SqlDataReader monReader = cmd.ExecuteReader();


            // Remplissage de la liste
            while (monReader.Read())
            {
                id = Int32.Parse(monReader["the_id"].ToString());
                nom = monReader["the_nom"].ToString();
                Theme unTheme = new Theme(id, nom);

                // Ajout à la liste
                listTheme.Add(unTheme);
            }

            // Fermeture de la connexion
            connection.Close();

            return listTheme;
        }

        public static int GetThemeByIdByName(string theme)
        {
            string connectionString = ConnexionBD.GetConnexionBD().GetchaineConnexion();
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "SELECT the_id FROM Theme WHERE the_nom = @nom";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.Add(new SqlParameter("@nom", System.Data.SqlDbType.NVarChar) { Value = theme });

            int themeId = (int)command.ExecuteScalar();
            connection.Close();

            return themeId;
        }
    }
}
