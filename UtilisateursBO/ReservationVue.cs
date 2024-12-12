using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheatreBO
{
    public class ReservationVue
    {
        public string RepresentationText { get; set; }
        public string EmailClient { get; set; }
        public int NbPlace { get; set; }

        public ReservationVue(Reservation reservation)
        {
            RepresentationVue res = new RepresentationVue (reservation.Representation);
            RepresentationText = $"{reservation.Representation.id} {res.Theatre} - {res.Lieu} - {res.Date} - {res.Heure}";
            EmailClient = reservation.Client.email;
            NbPlace = reservation.NbPlace;
        }

        public ReservationVue(int id, string representation, string client, int nbPlace)
        {
            RepresentationText = representation;
            EmailClient = client;
            NbPlace = nbPlace;
        }

        public ReservationVue() { }
    }
}
