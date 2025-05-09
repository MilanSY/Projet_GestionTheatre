using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheatreBO
{
    public class Directeur
    {
        public int id { get; set; }
        public string nom { get; set; }


        public Directeur(int id, string nom)
        {
            this.id = id;
            this.nom = nom;
        }
        public Directeur() { }

    }
}
