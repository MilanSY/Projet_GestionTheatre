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

        // Permet d'ajouter une réservation
        public static bool AjoutReservation(Reservation reservation)
        {
            return ReservationDAO.AjouterReservation(reservation);
        }

        public static int AjouterClient(Client client)
        {
            return ReservationDAO.AjouterClient(client);
        }

        // Permet de vérifier si un client existe déjà dans la base de données
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

        // Récupère la liste des réservations
        public static List<Reservation> GetReservations()
        { 
            return ReservationDAO.GetReservations();
        }

        // Récupère la liste des réservations pour la dgv
        public static List<ReservationVue> GetReservationVueList(List<Reservation> listReservation)
        { 
            return ReservationDAO.GetReservationVueList(listReservation); 
        }

        // Supprime une réservation par l'id du client et de la représentation
        public static bool SupprimerReservation(int idCli, int idRep)
        {
            return ReservationDAO.SupprimerReservation(idCli, idRep);
        }

        // Supprime une réservation par l'objet réservation
        public static bool SupprimerReservation(Reservation res)
        {
            return ReservationDAO.SupprimerReservation(res);
        }
      
        public static List<Client> GetClients()
        {
            return ReservationDAO.GetClients();
        }

        // Récupère les infomartions du client par son email
        public static Client GetClientByEmail(string email)
        {
            return ReservationDAO.GetClientByEmail(email);
        }

        // Récupère les infomartions de la réservation par l'id du client et de la représentation
        public static Reservation GetReservationById(int idClient, int idRepr)
        {
            return ReservationDAO.GetReservationById(idClient, idRepr);
        }

        public static int GetNbplaceRestante(Representation representation)
        {
            return ReservationDAO.GetNbplaceRestante(representation);
        }
    }
}
