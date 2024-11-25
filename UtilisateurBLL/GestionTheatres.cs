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
    }
}
