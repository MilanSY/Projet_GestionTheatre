using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheatreBO;
using TheatreDAL;

namespace TheatreBLL
{
    public class GestionReservation
    {
        public static List<Reservation> GetReservations()
        {
            return ReservationDAO.GetReservations();
        }

        public static Reservation GetReservation(int id)
        {
            return ReservationDAO.GetReservation(id);
        }

        public static void AddReservation(Reservation reservation)
        {
            ReservationDAO.AddReservation(reservation);
        }

        public static void UpdateReservation(Reservation reservation)
        {
            ReservationDAO.UpdateReservation(reservation);
        }

        public static void SupprimerReservation(int id)
        {
            ReservationDAO.SupprimerReservation(id);
        }
    }
}
