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
        public static void UpdateTheatre(string nom, string adresse, string ville, string codePostal, string telephone, string courriel, string siteWeb, string description)
        {
            TheatreDAO.UpdateTheatre(nom, adresse, ville, codePostal, telephone, courriel, siteWeb, description);
        }

        // Méthode qui permet de récupérer les informations d'un théâtre par son ID
        public static Theatre GetTheatreByID(int id)
        {
            return TheatreDAO.GetTheatreById(id);
        }

        public static List<Theatre> GetTheatres()
        {
            return TheatreDAO.GetTheatres();
        }
    }
}
