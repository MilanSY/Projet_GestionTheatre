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
        private static string connectionString = ConnexionBD.GetConnexionBD().GetchaineConnexion();

        // Récupère le nombre de réservations d'une représentation
        public static int GetNbReservations(Reservation reservation)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                string query = "SELECT COUNT(*) FROM Reservation WHERE res_rep = @res_rep";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@res_rep", reservation.Representation.id);
                connection.Open();
                return (int)command.ExecuteScalar();
            }
            finally
            {
                connection.Close();
            }
        }

        public static bool VerifierEmail(string email)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                string query = "SELECT * FROM Client WHERE cli_email = @cli_email";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@cli_email", email);
                connection.Open();
                return command.ExecuteScalar() != null;
            }
            finally
            {
                connection.Close();
            }
        }

        // Permet d'ajouter une réservation à la base de données
        public static bool AjouterReservation(Reservation reservation)
        {
            /* if (reservation.NbPlace > GetNbReservations(reservation))
            {
                throw new InvalidOperationException("Le nombre de places réservées dépasse le nombre de places disponibles.");
            } */

            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                string query = "INSERT INTO Reservation (res_cli, res_rep, res_nb_place) VALUES (@res_cli, @res_rep, @res_nb_place)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@res_cli", reservation.Client.id);
                command.Parameters.AddWithValue("@res_rep", reservation.Representation.id);
                command.Parameters.AddWithValue("@res_nb_place", reservation.NbPlace);
                connection.Open();
                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        // Vérifie la présence du client avec son adresse email dans la base de données
        public static int AjouterOuVerifierClient(Client client)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string queryCheck = "SELECT cli_id FROM Client WHERE cli_email = @Email";
            SqlCommand commandCheck = new SqlCommand(queryCheck, connection);
            commandCheck.Parameters.AddWithValue("@email", client.email);
            connection.Open();
            object result = commandCheck.ExecuteScalar();

            if (result == null)
            {
                string queryInsert = "INSERT INTO Client (cli_nom, cli_prenom, cli_email, cli_tel) VALUES (@Nom, @Prenom, @Email, @Telephone)";
                SqlCommand commandInsert = new SqlCommand(queryInsert, connection);
                commandInsert.Parameters.AddWithValue("@Nom", client.nom);
                commandInsert.Parameters.AddWithValue("@Prenom", client.prenom);
                commandInsert.Parameters.AddWithValue("@Email", client.email);
                commandInsert.Parameters.AddWithValue("@Telephone", client.telephone);
                commandInsert.ExecuteNonQuery();

                connection.Close();


                queryCheck = "SELECT cli_id FROM Client WHERE cli_email = @Email";
                commandCheck = new SqlCommand(queryCheck, connection);
                commandCheck.Parameters.AddWithValue("@email", client.email);
                connection.Open();
                result = commandCheck.ExecuteScalar();

                connection.Close();

                return (int)result;
            }
            else
            {
                connection.Close();
                return (int)result;
            }
            
        }
    }
}
