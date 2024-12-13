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
                Console.WriteLine(e.ToString());
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

        public static Client getClientById(int idCli)
        {
            string nom, prenom, email, tel;
            Client unClient = new Client();

            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = @"
            SELECT *
            FROM client
            WHERE cli_id = @idCli";
            connection.Open();

            cmd.Parameters.AddWithValue("@idCli", idCli);

            try
            {
                SqlDataReader monReader = cmd.ExecuteReader();

                while (monReader.Read())
                {
                    nom = monReader["cli_nom"].ToString();
                    prenom = monReader["cli_prenom"].ToString();
                    email = monReader["cli_email"].ToString();
                    tel = monReader["cli_tel"].ToString();

                    unClient = new Client(idCli, nom, prenom, email, tel);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            { 
                connection.Close();
            }

            return unClient;

        }

        public static Client getClientByEmail(string email)
        {
            string nom, prenom, tel;
            int id;
            Client unClient = new Client();

            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = @"
            SELECT *
            FROM client
            WHERE cli_email = @email";
            connection.Open();

            cmd.Parameters.AddWithValue("@email", email);

            try
            {
                SqlDataReader monReader = cmd.ExecuteReader();

                while (monReader.Read())
                {
                    nom = monReader["cli_nom"].ToString();
                    prenom = monReader["cli_prenom"].ToString();
                    id = Int32.Parse(monReader["cli_id"].ToString());
                    tel = monReader["cli_tel"].ToString();

                    unClient = new Client(id, nom, prenom, email, tel);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                connection.Close();
            }

            return unClient;

        }


        public static Reservation GetReservationById(int idClient, int idRepr)
        {
            int nbPlace;


            SqlConnection connection = new SqlConnection(connectionString);

            // Création d'un objet vide Reservation
            Reservation uneReservation = new Reservation();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = @"
            SELECT r.res_nb_place
            FROM Reservation r
            WHERE r.res_cli = @idCli AND r.res_rep = @idRep";
            connection.Open();
            cmd.Parameters.AddWithValue("@idCli", idClient);
            cmd.Parameters.AddWithValue("@idRep", idRepr);

            SqlDataReader monReader = cmd.ExecuteReader();

            // Remplissage de la Reservation
            while (monReader.Read())
            {
                nbPlace = Int32.Parse(monReader["res_nb_place"].ToString());

                Client unClient = ReservationDAO.getClientById(idClient);
                Representation uneRepresentation = RepresentationDAO.GetRepresentationById(idRepr);

                // Création d'un objet Reservation
                uneReservation = new Reservation(uneRepresentation, unClient, nbPlace);
            }

            // Fermeture de la connexion
            connection.Close();

            return uneReservation;
        }

            public static List<Reservation> GetReservations()
        {
            int nbPlace, idClient, idRepr;
            

            SqlConnection connection = new SqlConnection(connectionString);

            // Création d'une liste vide d'objets Reservation
            List<Reservation> listReservation = new List<Reservation>();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = @"
            SELECT r.res_cli,
                r.res_rep,
                r.res_nb_place
            FROM Reservation r";
            connection.Open();


            SqlDataReader monReader = cmd.ExecuteReader();

            // Remplissage de la liste
            while (monReader.Read())
            {
                idClient = Int32.Parse(monReader["res_cli"].ToString());
                nbPlace = Int32.Parse(monReader["res_nb_place"].ToString());
                idRepr = Int32.Parse(monReader["res_rep"].ToString());

                Client unClient = ReservationDAO.getClientById(idClient);
                Representation uneRepresentation = RepresentationDAO.GetRepresentationById(idRepr);

                // Création d'un objet Reservation
                Reservation uneReservation = new Reservation(uneRepresentation ,unClient, nbPlace);

                // Ajout à la liste
                listReservation.Add(uneReservation);
            }

            // Fermeture de la connexion
            connection.Close();

            return listReservation;
        }

        public static List<ReservationVue> GetReservationVueList(List<Reservation> listReservation)
        {
            ReservationVue ac;
            List<ReservationVue> listVue = new List<ReservationVue>();
            foreach (Reservation reservation in listReservation)
            {
                Console.WriteLine(reservation.Representation.id);
                ac = new ReservationVue(reservation);
                Console.WriteLine(ac.RepresentationText);

                listVue.Add(new ReservationVue(reservation));
            }
            return listVue;
        }

        public static bool SupprimerReservation(int idCli, int idRep)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "DELETE FROM Reservation WHERE res_cli = @idCli AND res_rep = @idRep";
            cmd.Parameters.AddWithValue("@idCli", idCli);
            cmd.Parameters.AddWithValue("@idRep", idRep);

            try
            {
                connection.Open();
                int nbLignes = cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547) // Foreign key constraint violation
                {
                    // Handle the foreign key constraint violation
                    Console.WriteLine("Impossible de supprimer la représentation car elle liée à une contrainte de clé étrangère");
                    return false;
                }
                else
                {
                    // Re-throw the exception if it's not a foreign key constraint violation
                    throw;
                }
            }
            finally
            {
                connection.Close();
            }
        }

        public static bool SupprimerReservation(Reservation uneRes)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "DELETE FROM Reservation WHERE res_cli = @idCli AND res_rep = @idRep";
            cmd.Parameters.AddWithValue("@idCli", uneRes.Client.id);
            cmd.Parameters.AddWithValue("@idRep", uneRes.Representation.id);

            try
            {
                connection.Open();
                int nbLignes = cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547) // Foreign key constraint violation
                {
                    // Handle the foreign key constraint violation
                    Console.WriteLine("Impossible de supprimer la représentation car elle liée à une contrainte de clé étrangère");
                    return false;
                }
                else
                {
                    // Re-throw the exception if it's not a foreign key constraint violation
                    throw;
                }
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
