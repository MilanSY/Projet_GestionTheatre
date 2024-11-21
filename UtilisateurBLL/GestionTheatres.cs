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
        public static void UpdateTheatre(int id, string nom, float prix, string description, int? duree, string compagnie, string publicCateg, string theme, string auteurPrenom, string auteurNom)
        {
            TheatreDAO.UpdateTheatre( id, nom, prix, description, duree, compagnie, publicCateg, theme, auteurPrenom, auteurNom);
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
