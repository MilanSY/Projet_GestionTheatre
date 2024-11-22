using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheatreBO
{
    public class Compagnie
    {
        public int id {  get; set; }
        public string nom { get; set; }
        public string ville { get; set; }
        public string directeur { get; set; }

        public Compagnie(int id, string nom, string ville, string directeur)
        {
            this.id = id;
            this.nom = nom;
            this.ville = ville;
            this.directeur = directeur;
        }
        public Compagnie() { }

    }
}
