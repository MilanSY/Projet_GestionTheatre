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
    public class GestionReservations
    {

        public static int GetNbReservations(Reservation reservation)
        {
            return ReservationDAO.GetNbReservations(reservation);
        }

        public static bool AjoutReservation(Reservation reservation)
        {
            return ReservationDAO.AjouterReservation(reservation);
        }

        public static int AjouterOuVerifierClient(Client client)
        {
            return ReservationDAO.AjouterOuVerifierClient(client);
        }

        public static bool VerifierEmail(string email)
        {
            return ReservationDAO.VerifierEmail(email);
        }
    }
}
