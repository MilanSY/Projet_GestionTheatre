using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using TheatreBO;

namespace TheatreDAL
{
    public class RepresentationDAO
    {
        public static List<RepresentationVue> GetRepresentationsView(Representation unRepresentation)
        {
            int id, heure, nbPlaceMax, tarif;
            DateTime date;
            string lieu;

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
                    r.rep_tar AS tarifRep
                FROM Representation r 
                LEFT JOIN Pieces p ON r.rep_pie = p.pie_id 
                LEFT JOIN Tarif t a ON r.rep_tar = t.tar_id;";
            connection.Open();

            SqlDataReader monReader = cmd.ExecuteReader();

            // Remplissage de la liste
            while (monReader.Read())
            {
                id = Int32.Parse(monReader["rep_id"].ToString());
                heure = Int32.Parse(monReader["rep_heure"].ToString());
                date = DateTime.Parse(monReader["rep_date"].ToString());
                lieu = monReader["rep_lieu"] == DBNull.Value ? default(string) : monReader["rep_lieu"].ToString();
                nbPlaceMax = monReader["rep_nb_place_max"] == DBNull.Value ? default(int) : Int32.Parse(monReader["rep_nb_place_max"].ToString());
                tarif = monReader["tarifRep"] == DBNull.Value ? default(int) : Int32.Parse(monReader["tarifRep"].ToString());

                // Création d'un objet Representation
                Representation uneRepresentation = new Representation
                {
                    id = id,
                    heure = heure,
                    date = date,
                    lieu = lieu,
                    nbPlaceMax = nbPlaceMax,
                    tarif = tarif
                };
                RepresentationVue vue = new RepresentationVue(uneRepresentation);
                // Ajout à la liste
                listRepresentation.Add(vue);
            }

            // Fermeture de la connexion
            connection.Close();

            return listRepresentation;
        }
    }
}
