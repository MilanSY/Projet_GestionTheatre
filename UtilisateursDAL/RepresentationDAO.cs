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
    }
}
