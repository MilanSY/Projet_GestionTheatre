using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheatreBO;

namespace TheatreDAL
{
    public class ReservationDAO
    {
        private string connectionString = ConnexionBD.GetConnexionBD().GetchaineConnexion();

        // Récupère le nombre de réservations d'une représentation
        public int GetNbReservations(Representation representation)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                string query = "SELECT COUNT(*) FROM Reservations WHERE res_rep = @res_rep";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@res_rep", representation.id);
                connection.Open();
                return (int)command.ExecuteScalar();
            }
            finally
            {
                connection.Close();
            }
        }

        // Permet d'ajouter une réservation
        public void AjouterReservation(Reservation reservation)
        {
            if (reservation.NbPlace > reservation.Representation.nbPlaceMax || GetNbReservations(reservation.Representation) + reservation.NbPlace > reservation.Representation.nbPlaceMax)
            {
                throw new InvalidOperationException("Le nombre de places réservées dépasse le nombre de places disponibles.");
            }

            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                string query = "INSERT INTO Reservations (res_cli, res_rep, res_nb_place) VALUES (@res_cli, @res_rep, @res_nb_place)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@res_cli", reservation.Client.id);
                command.Parameters.AddWithValue("@res_rep", reservation.Representation.id);
                command.Parameters.AddWithValue("@res_nb_place", reservation.NbPlace);
                connection.Open();
                command.ExecuteNonQuery();
            }
            finally
            {
                connection.Close();
            }
        }

        // Vérifie la présence du client avec son adresse email dans la base de données
        public void AjouterOuVerifierClient(Client client)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                string queryCheck = "SELECT Id FROM Clients WHERE Nom = @Nom AND Prenom = @Prenom";
                SqlCommand commandCheck = new SqlCommand(queryCheck, connection);
                commandCheck.Parameters.AddWithValue("@Nom", client.nom);
                commandCheck.Parameters.AddWithValue("@Prenom", client.prenom);
                connection.Open();
                object result = commandCheck.ExecuteScalar();

                if (result == null)
                {
                    string queryInsert = "INSERT INTO Clients (Nom, Prenom, Email, Telephone) VALUES (@Nom, @Prenom, @Email, @Telephone)";
                    SqlCommand commandInsert = new SqlCommand(queryInsert, connection);
                    commandInsert.Parameters.AddWithValue("@Nom", client.nom);
                    commandInsert.Parameters.AddWithValue("@Prenom", client.prenom);
                    commandInsert.Parameters.AddWithValue("@Email", client.email);
                    commandInsert.Parameters.AddWithValue("@Telephone", client.telephone);
                    commandInsert.ExecuteNonQuery();
                }
                else
                {
                    client.id = (int)result;
                }
            }
            finally
            {
                connection.Close();
            }
        }
        
    }
}
