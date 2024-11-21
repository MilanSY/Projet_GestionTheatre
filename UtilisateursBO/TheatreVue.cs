using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheatreBO
{
    public class TheatreVue
    {
        public Theatre theatre {  get; set; }
        public int Id { get; set; }
        public string Nom { get; set; }
        public float Prix { get; set; }
        public string Description { get; set; }
        public int? Duree { get; set; }
        public string CompagnieNom { get; set; }
        public string PublicCategNom { get; set; }
        public string ThemeNom { get; set; }
        public string AuteurNomPrenom { get; set; }

        public TheatreVue(Theatre theatre)
        {
            Id = theatre.id;
            Nom = theatre.nom;
            Prix = theatre.prix;
            Description = theatre.description;
            Duree = theatre.duree;
            CompagnieNom = theatre.compagnie.nom;
            PublicCategNom = theatre.publicCateg.categ;
            ThemeNom = theatre.theme.nom;
            AuteurNomPrenom = theatre.auteur.getNomPrenom();
        }
    }
}
