using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheatreBO;

namespace TheatresBO
{
    class ReservationVue
    {
        public Representation Representation { get; set; }
        public Client Client { get; set; }
        public int NbPlace { get; set; }

        public ReservationVue(Reservation reservation)
        {
            Representation = reservation.Representation;
            Client = reservation.Client;
            NbPlace = reservation.NbPlace;
        }

        public ReservationVue(int id, Representation representation, Client client, int nbPlace, Theatre theatre)
        {
            Representation = representation;
            Client = client;
            NbPlace = nbPlace;
        }
    }
}
