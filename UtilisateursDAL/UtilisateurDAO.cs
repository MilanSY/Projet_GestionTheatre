using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheatreDAL;
using TheatreBO;

namespace TheatreDAL
{
    public class UtilisateurDAO
    {
        private static UtilisateurDAO unUtilisateurDAO;

        // Accesseur en lecture, renvoi une instance
        public static UtilisateurDAO GetunUtilisateurDAO()
        {
            if (unUtilisateurDAO == null)
            {
                unUtilisateurDAO = new UtilisateurDAO();
            }
            return unUtilisateurDAO;
        }

        // Cette méthode retourne une List contenant les objets Utilisateurs contenus dans la table Identification
        public static List<Utilisateur> GetUtilisateurs()
        {
            string mdp;
            string nom;
            Utilisateur unUtilisateur;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            // Création d'une liste vide d'objets Utilisateurs
            List<Utilisateur> lesUtilisateurs = new List<Utilisateur>();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = " SELECT * FROM Utilisateur";

            SqlDataReader monReader = cmd.ExecuteReader();

            // Remplissage de la liste
            while (monReader.Read())
            {
                if (monReader["uti_login"] == DBNull.Value)
                {
                    nom = default(string);
                }
                else
                {
                    nom = monReader["uti_login"].ToString();
                }

                if (monReader["uti_mdp"] == DBNull.Value)
                {
                    mdp = default(string);
                }
                else
                {
                    mdp = monReader["uti_mdp"].ToString();
                }

                unUtilisateur = new Utilisateur(nom, mdp);
                lesUtilisateurs.Add(unUtilisateur);
            }

            // Fermeture de la connexion
            maConnexion.Close();

            return lesUtilisateurs;
        }


        

        
    }
}
