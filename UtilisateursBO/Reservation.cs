using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheatreBO
{
    public class Reservation
    {
        public Representation Representation { get; set; }
        public Client Client { get; set; }
        public int NbPlace { get; set; }

        public Reservation(Representation representation, Client client, int nbPlace)
        {
            Representation = representation;
            Client = client;
            NbPlace = nbPlace;
        }

        public Reservation() { }
    }
}
