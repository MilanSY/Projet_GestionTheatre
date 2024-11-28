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
        public int id { get; set; }
        public string nom { get; set; }
        public float prix { get; set; }
        public string description { get; set; }
        public int? duree { get; set; }
        public Compagnie compagnie { get; set; }
        public Publics publicCateg { get; set; }
        public Theme theme { get; set; }
        public Auteur auteur { get; set; }


        public Theatre(int id, string nom, float prix, string description, int? duree, Compagnie compagnie, Publics publicCateg, Theme theme, Auteur auteur)
        {
            this.id = id;
            this.nom = nom;
            this.prix = prix;
            this.description = description;
            this.duree = duree;
            this.compagnie = compagnie;
            this.publicCateg = publicCateg;
            this.theme = theme;
            this.auteur = auteur;
        }

        public Theatre() { }
    }
}
