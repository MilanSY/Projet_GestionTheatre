using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheatreBO
{
    public class Representation
    {
        public int id { get; set; }

        public int heure { get; set; }

        public DateTime date { get; set; }

        public string lieu { get; set; }

        public int nbPlaceMax { get; set; }

        public Theatre theatre { get; set; }

        public int tarif { get; set; }

    }


}
