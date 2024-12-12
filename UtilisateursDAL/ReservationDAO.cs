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
        public static int VerifierClient(Client client)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                string queryCheck = "SELECT cli_id FROM Client WHERE cli_email = @Email";
                SqlCommand commandCheck = new SqlCommand(queryCheck, connection);
                commandCheck.Parameters.AddWithValue("@Email", client.email);
                connection.Open();
                object result = commandCheck.ExecuteScalar();
                return result != null ? (int)result : -1;
            }
            finally
            {
                connection.Close();
            }
        }

        // Ajoute un nouveau client dans la base de données
        public static int AjouterClient(Client client)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                string queryInsert = "INSERT INTO Client (cli_nom, cli_prenom, cli_email, cli_tel) VALUES (@Nom, @Prenom, @Email, @Telephone)";
                SqlCommand commandInsert = new SqlCommand(queryInsert, connection);
                commandInsert.Parameters.AddWithValue("@Nom", client.nom);
                commandInsert.Parameters.AddWithValue("@Prenom", client.prenom);
                commandInsert.Parameters.AddWithValue("@Email", client.email);
                commandInsert.Parameters.AddWithValue("@Telephone", client.telephone);
                connection.Open();
                commandInsert.ExecuteNonQuery();

                string queryCheck = "SELECT cli_id FROM Client WHERE cli_email = @Email";
                SqlCommand commandCheck = new SqlCommand(queryCheck, connection);
                commandCheck.Parameters.AddWithValue("@Email", client.email);
                object result = commandCheck.ExecuteScalar();
                return (int)result;
            }
            finally
            {
                connection.Close();
            }
        }

        // Récupère les clients de la base de données
        public static List<Client> GetClients()
        {
            List<Client> clients = new List<Client>();
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                string query = "SELECT * FROM Client";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string nom = reader.GetString(1);
                    string prenom = reader.GetString(2);
                    string email = reader.GetString(3);
                    string telephone = reader.GetString(4);
                    clients.Add(new Client(id, nom, prenom, email, telephone));
                }
                return clients;
            }
            finally
            {
                connection.Close();
            }
        }

        // Récupère le client en fonction de l'email renseigné
        public static Client GetClientByEmail(string email)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                string query = "SELECT * FROM Client WHERE cli_email = @cli_email";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@cli_email", email);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string nom = reader.GetString(1);
                    string prenom = reader.GetString(2);
                    string emailClient = reader.GetString(3);
                    string telephone = reader.GetString(4);
                    return new Client(id, nom, prenom, emailClient, telephone);
                }
                return null;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
