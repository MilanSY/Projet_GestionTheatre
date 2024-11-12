using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheatreDAL;


namespace TheatreBLL
{
    public class GestionTheatres
    {
        private static GestionTheatres uneGestionTheatres; // objet BLL
            // add remove update getter setter des pièces de theatre
            public static void UpdateTheatre(string nom, string adresse, string ville, string codePostal, string telephone, string courriel, string siteWeb, string description)
            {
               TheatreDAO.UpdateTheatre(nom, adresse, ville, codePostal, telephone, courriel, siteWeb, description);
            }
    }
}
