using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheatreBO
{
    public class Representation
    {
        public Representation(int id, string heure, string date, string lieu, int nbPlaceMax, Theatre theatre, Tarif tarif)
        {
            this.id = id;
            if (heure.Count() == 1)
                {
                    this.heure = "0" + heure + ":00";
                }
            else if (heure.Count() == 2)
                {
                     this.heure = heure + ":00";
                }
            else
                {
                    this.heure = heure;
                }
            this.date = date;
            this.lieu = lieu;
            this.nbPlaceMax = nbPlaceMax;
            this.theatre = theatre;
            this.tarif = tarif;
        }

        public int id { get; set; }

        public string heure { get; set; }

        public string date { get; set; }

        public string lieu { get; set; }

        public int nbPlaceMax { get; set; }

        public Theatre theatre { get; set; }

        public Tarif tarif { get; set; }

    }


}
