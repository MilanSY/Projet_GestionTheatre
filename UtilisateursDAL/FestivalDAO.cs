﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using TheatreBO;

namespace TheatreDAL
{
    public class FestivalDAO
    {
        private static string connectionString = ConnexionBD.GetConnexionBD().GetchaineConnexion();


        public static List<FestivalVue> GetFestivalVue()
        {
            string piece;
            int nbRepresentations, nbSpectateursTotal;
            float nbSpectateursMoyen, caRealise, caRealiseMoyen;

            SqlConnection connection = new SqlConnection(connectionString);

            // Création d'une liste vide d'objets Reservation
            List<FestivalVue> listFestival = new List<FestivalVue>();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = @"
                SELECT 
                    p.pie_nom AS Piece,
                    COUNT(DISTINCT r.rep_id) AS NbRepresentations,
                    SUM(res.res_nb_place) AS NbSpectateursTotal,
                    AVG(res.res_nb_place) AS NbSpectateursMoyen,
                    SUM(res.res_nb_place * (p.pie_prix + (p.pie_prix * t.tar_var / 100))) AS CARealise,
                    AVG(res.res_nb_place * (p.pie_prix + (p.pie_prix * t.tar_var / 100))) AS CARealiseMoyen
                FROM 
                    Pieces p
                LEFT JOIN 
                    Representation r ON p.pie_id = r.rep_pie
                LEFT JOIN 
                    Reservation res ON r.rep_id = res.res_rep
                LEFT JOIN 
                    Tarif t ON r.rep_tar = t.tar_id
                GROUP BY 
                    p.pie_nom;
                ";
            connection.Open();

            SqlDataReader monReader = cmd.ExecuteReader();
            while (monReader.Read())
            {
                piece = monReader["Piece"]?.ToString() ?? string.Empty;

                nbRepresentations = monReader["NbRepresentations"] != DBNull.Value
                    ? Convert.ToInt32(monReader["NbRepresentations"])
                    : 0;

                nbSpectateursTotal = monReader["NbSpectateursTotal"] != DBNull.Value
                    ? Convert.ToInt32(monReader["NbSpectateursTotal"])
                    : 0;

                nbSpectateursMoyen = monReader["NbSpectateursMoyen"] != DBNull.Value
                    ? Convert.ToSingle(monReader["NbSpectateursMoyen"])
                    : 0;

                caRealise = monReader["CARealise"] != DBNull.Value
                    ? Convert.ToSingle(monReader["CARealise"])
                    : 0;

                caRealiseMoyen = monReader["CARealiseMoyen"] != DBNull.Value
                    ? Convert.ToSingle(monReader["CARealiseMoyen"])
                    : 0;


                FestivalVue festivalVue = new FestivalVue(piece, nbRepresentations, nbSpectateursTotal, nbSpectateursMoyen, caRealise, caRealiseMoyen);

                listFestival.Add(festivalVue);
            }


            // Fermeture de la connexion
            connection.Close();

            return listFestival;
        }


        public static List<FestivalVue> GetFestivalVue(string date1, string date2)
        {
            string piece;
            int nbRepresentations, nbSpectateursTotal;
            float nbSpectateursMoyen, caRealise, caRealiseMoyen;

            SqlConnection connection = new SqlConnection(connectionString);

            // Création d'une liste vide d'objets Reservation
            List<FestivalVue> listFestival = new List<FestivalVue>();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = @"
                SELECT 
                    p.pie_nom AS Piece,
                    COUNT(DISTINCT r.rep_id) AS NbRepresentations,
                    SUM(res.res_nb_place) AS NbSpectateursTotal,
                    AVG(res.res_nb_place) AS NbSpectateursMoyen,
                    SUM(res.res_nb_place * (p.pie_prix + (p.pie_prix * t.tar_var / 100))) AS CARealise,
                    AVG(res.res_nb_place * (p.pie_prix + (p.pie_prix * t.tar_var / 100))) AS CARealiseMoyen
                FROM 
                    Pieces p
                LEFT JOIN 
                    Representation r ON p.pie_id = r.rep_pie
                LEFT JOIN 
                    Reservation res ON r.rep_id = res.res_rep
                LEFT JOIN 
                    Tarif t ON r.rep_tar = t.tar_id
                WHERE 
                    rep_date BETWEEN @date1 AND @date2
                GROUP BY 
                    p.pie_nom;
                ";
            connection.Open();
            cmd.Parameters.Add(new SqlParameter("@date1", System.Data.SqlDbType.Date) { Value = date1 });
            cmd.Parameters.Add(new SqlParameter("@date2", System.Data.SqlDbType.Date) { Value = date2 });

            SqlDataReader monReader = cmd.ExecuteReader();

            while (monReader.Read())
            {
                piece = monReader["Piece"]?.ToString() ?? string.Empty;

                nbRepresentations = monReader["NbRepresentations"] != DBNull.Value
                    ? Convert.ToInt32(monReader["NbRepresentations"])
                    : 0;

                nbSpectateursTotal = monReader["NbSpectateursTotal"] != DBNull.Value
                    ? Convert.ToInt32(monReader["NbSpectateursTotal"])
                    : 0;

                nbSpectateursMoyen = monReader["NbSpectateursMoyen"] != DBNull.Value
                    ? Convert.ToSingle(monReader["NbSpectateursMoyen"])
                    : 0;

                caRealise = monReader["CARealise"] != DBNull.Value
                    ? Convert.ToSingle(monReader["CARealise"])
                    : 0;

                caRealiseMoyen = monReader["CARealiseMoyen"] != DBNull.Value
                    ? Convert.ToSingle(monReader["CARealiseMoyen"])
                    : 0;


                FestivalVue festivalVue = new FestivalVue(piece, nbRepresentations, nbSpectateursTotal, nbSpectateursMoyen, caRealise, caRealiseMoyen);

                listFestival.Add(festivalVue);
            }


            // Fermeture de la connexion
            connection.Close();

            return listFestival;
        }
    }
}
