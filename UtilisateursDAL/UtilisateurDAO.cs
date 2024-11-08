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
            cmd.CommandText = " SELECT * FROM Utilisateurs";

            SqlDataReader monReader = cmd.ExecuteReader();

            // Remplissage de la liste
            while (monReader.Read())
            {
                if (monReader["loginutilisateur"] == DBNull.Value)
                {
                    nom = default(string);
                }
                else
                {
                    nom = monReader["loginutilisateur"].ToString();
                }

                if (monReader["MotDePasse"] == DBNull.Value)
                {
                    mdp = default(string);
                }
                else
                {
                    mdp = monReader["MotDePasse"].ToString();
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
