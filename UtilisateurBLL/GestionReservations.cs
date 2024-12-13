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

        public static int AjouterClient(Client client)
        {
            return ReservationDAO.AjouterClient(client);
        }

        public static int VerifierClient(Client client)
        {
            return ReservationDAO.VerifierClient(client);
        }

        public static Client getClientById(int idCli)
        {
            return ReservationDAO.getClientById(idCli);
        }

        public static Client getClientByEmail(string email)
        {
            return ReservationDAO.getClientByEmail(email);
        }

        public static bool VerifierEmail(string email)
        {
            return ReservationDAO.VerifierEmail(email);
        }

        public static List<Reservation> GetReservations()
        { 
            return ReservationDAO.GetReservations();
        }

        public static List<ReservationVue> GetReservationVueList(List<Reservation> listReservation)
        { 
            return ReservationDAO.GetReservationVueList(listReservation); 
        }

        public static bool SupprimerReservation(int idCli, int idRep)
        {
            return ReservationDAO.SupprimerReservation(idCli, idRep);
        }

        public static bool SupprimerReservation(Reservation res)
        {
            return ReservationDAO.SupprimerReservation(res);
        }
      
        public static List<Client> GetClients()
        {
            return ReservationDAO.GetClients();
        }

        public static Client GetClientByEmail(string email)
        {
            return ReservationDAO.GetClientByEmail(email);
        }
    }
}
