using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using TheatreBO;
using TheatreDAL;

namespace TheatreBLL
{
    public class GestionReservation
    {
        private ReservationDAO reservationDAO;

        public GestionReservation()
        {
            reservationDAO = new ReservationDAO();
        }

        public int GetNbReservations(Representation representation)
        {
            return reservationDAO.GetNbReservations(representation);
        }

        public bool AjoutReservation(Reservation reservation)
        {
            reservationDAO.AjouterReservation(reservation);
            return true;
        }

    }
}
