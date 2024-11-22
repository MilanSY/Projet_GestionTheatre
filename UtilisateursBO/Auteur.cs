using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheatreBO
{
    public class Auteur
    {
        public int id {  get; set; }
        public string nom { get; set; }
        public string prenom {  get; set; }

        public Auteur(int id, string nom, string prenom)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
        }
        public Auteur() { }

        public string getNomPrenom()
        {
            return this.nom + " " + this.prenom;
        }
    }
}
