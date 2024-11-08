using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheatreBO
{
    public class Utilisateur
    {

        public string motDePasse;
        public string loginUtilisateur;

        public Utilisateur(string motDePasse, string loginUtilisateur)
        {
            this.motDePasse = motDePasse;
            this.loginUtilisateur = loginUtilisateur;
        }

        public string getMotDePasse() {  return motDePasse; }
        public string getLoginUtilisateur() {  return loginUtilisateur; }
        public void setMotDePasse(string mdp) { this.motDePasse = mdp; }
        public void setLoginUtilisateur(string login) {  this.loginUtilisateur = login;}

    }
}
