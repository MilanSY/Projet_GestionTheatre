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
    public class RepresentationDAO
    {
        public static List<RepresentationVue> GetRepresentationsVue()
        {
            int id, nbPlaceMax;
            string lieu, heure, tarif, date, theatre;

            string connectionString = ConnexionBD.GetConnexionBD().GetchaineConnexion();
            SqlConnection connection = new SqlConnection(connectionString);

            // Création d'une liste vide d'objets Theatre
            List<RepresentationVue> listRepresentation = new List<RepresentationVue>();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = @"
                SELECT r.rep_id,
                    r.rep_heure,
                    r.rep_date,
                    r.rep_lieu,
                    r.rep_nb_place_max,
                    r.rep_pie,
                    p.pie_nom AS pieceNom,
                    r.rep_tar,
                    t.tar_lib AS tarifRep
                FROM Representation r 
                LEFT JOIN Pieces p ON r.rep_pie = p.pie_id 
                LEFT JOIN Tarif t ON r.rep_tar = t.tar_id;";
            connection.Open();

            SqlDataReader monReader = cmd.ExecuteReader();

            // Remplissage de la liste
            while (monReader.Read())
                {
                    id = Int32.Parse(monReader["rep_id"].ToString());
                    heure = monReader["rep_heure"].ToString();
                    date = monReader["rep_date"].ToString();
                    lieu = monReader["rep_lieu"].ToString();
                    nbPlaceMax = Int32.Parse(monReader["rep_nb_place_max"].ToString());
                    tarif = monReader["tarifRep"].ToString();
                    theatre = monReader["pieceNom"].ToString();

                    // Création d'un objet Representation
                    RepresentationVue uneRepresentation = new RepresentationVue
                    (
                        id,
                        heure,
                        date,
                        lieu,
                        nbPlaceMax,
                        theatre,
                        tarif
                    );

                    // Ajout à la liste
                    listRepresentation.Add(uneRepresentation);
                }

            // Fermeture de la connexion
            connection.Close();

            return listRepresentation;
            }


            public static bool SupprimerRepresentation(int id)
            {
                string connectionString = ConnexionBD.GetConnexionBD().GetchaineConnexion();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "DELETE FROM Representation WHERE rep_id = @id";
                    cmd.Parameters.AddWithValue("@id", id);

                    try
                    {
                        connection.Open();
                        int nbLignes = cmd.ExecuteNonQuery();
                        return nbLignes == 1;
                    }
                    catch (SqlException ex)
                    {
                        if (ex.Number == 547) // Foreign key constraint violation
                        {
                            // Handle the foreign key constraint violation
                            Console.WriteLine("Cannot delete the representation because it is referenced by other records.");
                            return false;
                        }
                        else
                        {
                            // Re-throw the exception if it's not a foreign key constraint violation
                            throw;
                        }
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }

            public static Representation GetRepresentationById(int id)
            {
                string date, heure, lieu;
                int nbPlace;
                Theatre theatre;

                string connectionString = ConnexionBD.GetConnexionBD().GetchaineConnexion();
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                string query = @"SELECT r.rep_id,
                        r.rep_date,
                        r.rep_heure,
                        r.rep_lieu,
                        r.rep_nb_place_max,
                        ta.tar_var AS tarifPrix,
                        ta.tar_lib AS tarifNom,
                        ta.tar_id AS tarifId,
                        p.pie_id AS pieceId,
                        p.pie_nom AS pieceNom,
                        p.pie_prix AS piecePrix,
                        p.pie_duree AS pieceDuree,
                        p.pie_descrip AS pieceDescription,
                        c.comp_id AS compagnieId,
                        c.comp_nom AS compagnieNom,
                        t.the_id AS themeId,
                        t.the_nom AS themeNom,
                        pu.pub_id AS publicId,
                        pu.pub_categ AS publicCateg,
                        a.aut_id AS auteurId,
                        a.aut_prenom AS auteurPrenom,
                        a.aut_nom AS auteurNom
                    FROM Representation r
                    LEFT JOIN Pieces p ON r.rep_pie = p.pie_id
                    LEFT JOIN Compagnies c ON p.pie_comp = c.comp_id
                    LEFT JOIN Theme t ON p.pie_the = t.the_id
                    LEFT JOIN Publics pu ON p.pie_pub = pu.pub_id
                    LEFT JOIN Auteur a ON p.pie_aut = a.aut_id
                    LEFT JOIN Tarif ta ON r.rep_tar = ta.tar_id
                    WHERE r.rep_id = @id;";

                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.Add(new SqlParameter("@id", System.Data.SqlDbType.Int) { Value = id });

                SqlDataReader monReader = cmd.ExecuteReader();

                if (monReader.Read())
                {
                    // Lecture des données de la représentation
                    date = monReader["rep_date"].ToString();
                    heure = monReader["rep_heure"].ToString();
                    lieu = monReader["rep_lieu"].ToString();
                    nbPlace = monReader["rep_nb_place_max"] == DBNull.Value ? 0 : Int32.Parse(monReader["rep_nb_place_max"].ToString());

                    // Lecture des données de la pièce associée
                    int pieceId = Int32.Parse(monReader["pieceId"].ToString());
                    string pieceNom = monReader["pieceNom"].ToString();
                    float piecePrix = float.Parse(monReader["piecePrix"].ToString());
                    string pieceDescription = monReader["pieceDescription"] == DBNull.Value ? null : monReader["pieceDescription"].ToString();
                    int? pieceDuree = monReader["pieceDuree"] == DBNull.Value ? (int?)null : Int32.Parse(monReader["pieceDuree"].ToString());

                    // Création des objets liés
                    Tarif tarif = monReader["tarifId"] == DBNull.Value
                        ? null
                        : new Tarif(
                            Int32.Parse(monReader["tarifId"].ToString()),
                            monReader["tarifNom"].ToString(),
                            int.Parse(monReader["tarifPrix"].ToString()));
                    Compagnie compagnie = monReader["compagnieId"] == DBNull.Value
                        ? new Compagnie()
                        : new Compagnie(Int32.Parse(monReader["compagnieId"].ToString()), monReader["compagnieNom"].ToString(), "", "");

                    Publics publicCateg = monReader["publicId"] == DBNull.Value
                        ? new Publics()
                        : new Publics(Int32.Parse(monReader["publicId"].ToString()), monReader["publicCateg"].ToString());

                    Theme theme = monReader["themeId"] == DBNull.Value
                        ? new Theme()
                        : new Theme(Int32.Parse(monReader["themeId"].ToString()), monReader["themeNom"].ToString());

                    Auteur auteur = monReader["auteurId"] == DBNull.Value
                        ? new Auteur()
                        : new Auteur(Int32.Parse(monReader["auteurId"].ToString()), monReader["auteurNom"].ToString(), monReader["auteurPrenom"].ToString());

                    // Création de l'objet Theatre
                    theatre = new Theatre(pieceId, pieceNom, piecePrix, pieceDescription, pieceDuree, compagnie, publicCateg, theme, auteur);

                    // Création de l'objet Representation
                    Representation representation = new Representation(id, heure, date, lieu, nbPlace, theatre, tarif);

                    connection.Close();

                    return representation;
                }

                connection.Close();
                return null;
            }

            public static List<Tarif> GetTarifs()
            {
                int id, var;
                string libelle;
                List<Tarif> listTarif = new List<Tarif>();

                string connectionString = ConnexionBD.GetConnexionBD().GetchaineConnexion();
                SqlConnection connection = new SqlConnection(connectionString);

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "SELECT * FROM Tarif";



                connection.Open();

                SqlDataReader monReader = cmd.ExecuteReader();

                // Remplissage de la liste
                while (monReader.Read())
                {
                    id = Int32.Parse(monReader["tar_id"].ToString());
                    libelle = monReader["tar_lib"].ToString();
                    var = Int32.Parse(monReader["tar_id"].ToString());
                    Tarif unTarif = new Tarif(id, libelle, var);

                    // Ajout à la liste
                    listTarif.Add(unTarif);
                }

                // Fermeture de la connexion
                connection.Close();


                return listTarif;
            }

            public static int GetTarifIdByName(string nom)
            {
                int id;
                List<Tarif> listTarif = new List<Tarif>();

                string connectionString = ConnexionBD.GetConnexionBD().GetchaineConnexion();
                SqlConnection connection = new SqlConnection(connectionString);

                string query = "SELECT * FROM Tarif WHERE tar_lib = @nom";

                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.Add(new SqlParameter("@nom", System.Data.SqlDbType.NVarChar) { Value = nom });

                connection.Open();

                SqlDataReader monReader = cmd.ExecuteReader();

                if (monReader.Read())
                {
                    id = Int32.Parse(monReader["tar_id"].ToString());

                    connection.Close();

                    return id;
                }

                connection.Close();

                return -1;
            }

            public static bool ModifierRepresentation(Representation representation)
            {
                string connectionString = ConnexionBD.GetConnexionBD().GetchaineConnexion();
                SqlConnection connection = new SqlConnection(connectionString);

                representation.theatre.id = TheatreDAO.GetTheatreIdByName(representation.theatre.nom);
                representation.tarif.id = GetTarifIdByName(representation.tarif.libelle);

                connection.Open();
                string query = @"
                UPDATE Representation
                SET rep_heure = @heure,
                    rep_date = @date,
                    rep_lieu = @lieu,
                    rep_nb_place_max = @nbPlace,
                    rep_pie = @pieceId,
                    rep_tar = @tarifId
                WHERE rep_id = @id;";

                SqlCommand cmd = new SqlCommand(query, connection);

                cmd.Parameters.Add(new SqlParameter("@id", System.Data.SqlDbType.Int) { Value = representation.id });
                cmd.Parameters.Add(new SqlParameter("@date", System.Data.SqlDbType.Date) { Value = representation.date });
                cmd.Parameters.Add(new SqlParameter("@heure", System.Data.SqlDbType.Time) { Value = representation.heure });
                cmd.Parameters.Add(new SqlParameter("@nbPlace", System.Data.SqlDbType.Int) { Value = representation.nbPlaceMax });
                cmd.Parameters.Add(new SqlParameter("@lieu", System.Data.SqlDbType.NVarChar) { Value = representation.lieu });
                cmd.Parameters.Add(new SqlParameter("@pieceId", System.Data.SqlDbType.Int) { Value = representation.theatre.id });
                cmd.Parameters.Add(new SqlParameter("@tarifId", System.Data.SqlDbType.Int) { Value = representation.tarif.id });

                // Exécution de la commande
                cmd.ExecuteNonQuery();

                connection.Close();

                return true;
            }

            public static bool AjouterRepresentation(Representation representation)
            {
                string connectionString = ConnexionBD.GetConnexionBD().GetchaineConnexion();
                SqlConnection connection = new SqlConnection(connectionString);

                representation.theatre.id = TheatreDAO.GetTheatreIdByName(representation.theatre.nom);
                representation.tarif.id = GetTarifIdByName(representation.tarif.libelle);

                connection.Open();
                string query = @"
                    INSERT INTO Representation(
                        rep_heure,
                        rep_date,
                        rep_lieu,
                        rep_nb_place_max,
                        rep_pie,
                        rep_tar)
                    VALUES(@heure,
                         @date,
                         @lieu,
                         @nbPlace,
                         @pieceId,
                         @tarifId);";

                SqlCommand cmd = new SqlCommand(query, connection);

                cmd.Parameters.Add(new SqlParameter("@date", System.Data.SqlDbType.Date) { Value = representation.date });
                cmd.Parameters.Add(new SqlParameter("@heure", System.Data.SqlDbType.Time) { Value = representation.heure });
                cmd.Parameters.Add(new SqlParameter("@nbPlace", System.Data.SqlDbType.Int) { Value = representation.nbPlaceMax });
                cmd.Parameters.Add(new SqlParameter("@lieu", System.Data.SqlDbType.NVarChar) { Value = representation.lieu });
                cmd.Parameters.Add(new SqlParameter("@pieceId", System.Data.SqlDbType.Int) { Value = representation.theatre.id });
                cmd.Parameters.Add(new SqlParameter("@tarifId", System.Data.SqlDbType.Int) { Value = representation.tarif.id });

                // Exécution de la commande
                cmd.ExecuteNonQuery();

                connection.Close();

                return true;
        }
    }
}
