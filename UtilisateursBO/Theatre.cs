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
        public int Id { get; set; }
        public string Nom { get; set; }
        public float Prix { get; set; }
        public string Description { get; set; }
        public int? Duree { get; set; }
        public string Compagnie { get; set; }
        public string PublicCateg { get; set; }
        public string Theme { get; set; }
        public string Auteur { get; set; }

        public Theatre(int id, string nom, float prix, string description, int? duree, string compagnie, string publicCateg, string theme, string auteur)
        {
            Id = id;
            Nom = nom;
            Prix = prix;
            Description = description;
            Duree = duree;
            Compagnie = compagnie;
            PublicCateg = publicCateg;
            Theme = theme;
            Auteur = auteur;
        }

    }
}
