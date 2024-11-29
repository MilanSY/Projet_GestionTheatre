using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheatreBO
{
    public class Tarif
    {
        
        public int id { get; set; }

        public string libelle { get; set; }

        public int variation { get; set; }

        public Tarif(int id, string libelle, int variation)
        {
            this.id = id;
            this.libelle = libelle;
            this.variation = variation;
        }

        public Tarif() { }
    }
}
