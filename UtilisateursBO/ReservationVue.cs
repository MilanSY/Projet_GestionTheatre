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
        public int Id { get; set; }
        public Representation Representation { get; set; }
        public Client Client { get; set; }
        public int NbPlace { get; set; }
        public Theatre Theatre { get; set; }

        public ReservationVue(Reservation reservation)
        {
            Id = reservation.Id;
            Representation = reservation.Representation;
            Client = reservation.Client;
            NbPlace = reservation.NbPlace;
            Theatre = reservation.Theatre;
        }

        public ReservationVue(int id, Representation representation, Client client, int nbPlace, Theatre theatre)
        {
            Id = id;
            Representation = representation;
            Client = client;
            NbPlace = nbPlace;
            Theatre = theatre;
        }
    }
}
