using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheatreBO
{
    public class Theatre
    {
        // attributs de l'objet theatre
        private string Nom_Theatre;
        private string Adresse_Theatre;
        private string Ville_Theatre;
        private string CodePostal_Theatre;
        private string Telephone_Theatre;
        private string Courriel_Theatre;
        private string SiteWeb_Theatre;
        private string Description_Theatre;

        // Constructeur de l'objet Theatre
        public Theatre(string nom, string adresse, string ville, string codePostal, string telephone, string courriel, string siteWeb, string description)
        {
            this.nom = nom;
            this.adresse = adresse;
            this.ville = ville;
            this.codePostal = codePostal;
            this.telephone = telephone;
            this.courriel = courriel;
            this.siteWeb = siteWeb;
            this.description = description;
        }

        // Propriétés de l'objet Theatre getter / setter
        public string nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public string adresse
        {
            get { return adresse; }
            set { adresse = value; }
        }

        public string ville
        {
            get { return ville; }
            set { ville = value; }
        }

        public string codePostal
        {
            get { return codePostal; }
            set { codePostal = value; }
        }

        public string telephone
        {
            get { return telephone; }
            set { telephone = value; }
        }

        public string courriel
        {
            get { return courriel; }
            set { courriel = value; }
        }

        public string siteWeb
        {
            get { return siteWeb; }
            set { siteWeb = value; }
        }

        public string description
        {
            get { return description; }
            set { description = value; }
        }



    }
}
