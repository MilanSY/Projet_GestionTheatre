using System;
using System.Collections.Generic;
using System.Configuration;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheatreBO;
using TheatreDAL;


namespace TheatreBLL
{
    public class GestionTheatres
    {
        public static void SetchaineConnexion(ConnectionStringSettings chset)
        {
            string chaine = chset.ConnectionString;
            ConnexionBD.GetConnexionBD().SetchaineConnexion(chaine);
        }
        public static void UpdateTheatre(Theatre unTheatre)
        {
            TheatreDAO.UpdateTheatre(unTheatre);
        }

        // Méthode qui permet de récupérer les informations d'un théâtre par son ID
        public static Theatre GetTheatreById(int id)
        {
            return TheatreDAO.GetTheatreById(id);
        }

        public static List<TheatreVue> GetTheatres()
        {
            return TheatreDAO.GetTheatres();
        }

        public static bool SupprimerTheatre(int id)
        {
            return TheatreDAO.SupprimerTheatre(id);
        }

        public static bool AjoutTheatre(Theatre unTheatre)
        {
            return TheatreDAO.AjoutTheatre(unTheatre);
        }

        public static List<Compagnie> GetCompagnies()
        {
            return TheatreDAO.GetCompagnies();
        }

        public static List<Auteur> GetAuteurs()
        {
            return TheatreDAO.GetAuteurs();
        }


        public static List<Publics> GetPublics()
        {
            return TheatreDAO.GetPublics();
        }

        public static List<Theme> GetThemes()
        {
            return TheatreDAO.GetThemes();
        }
    }
}