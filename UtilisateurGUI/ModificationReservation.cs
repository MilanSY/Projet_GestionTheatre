using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheatreBLL;
using TheatreBO;

namespace TheatreGUI
{
    public partial class ModificationReservation : Form
    {
        private List<Client> clients; // Supposons que cette liste contient tous les clients

        public ModificationReservation(string emailClient, int IdRepr)
        {
            InitializeComponent();
            Client client = GestionReservations.GetClientByEmail(emailClient);
            Representation representation = GestionRepresentations.GetRepresentationById(IdRepr);
            RepresentationVue reprVue = new RepresentationVue(representation);
            Reservation reservation = GestionReservations.GetReservationById(client.id, IdRepr);
            cboRepresentation.Items.Add($"{reprVue.Lieu} - {reprVue.Date} - {reprVue.Heure}");
            cboClientEnregistrer.Items.Add($"{client.email} - {client.nom} - {client.prenom} - {client.telephone}");
            RemplirComboBoxRepresentation();
            RemplirComboBoxClient();
            cboClientEnregistrer.SelectedIndex = 0;
            cboRepresentation.SelectedIndex = 0;

            // Remplir le champ du nom de la pièce de théâtre
            txtPieceDeTheatre.Text = reprVue.Theatre;
            txtNbPlace.Text = reservation.NbPlace.ToString();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            Utils.DisplayFormAtLoc(this, new GestionReservation());
        }

        private void RemplirComboBoxRepresentation()
        {
            List<RepresentationVue> listRepresentation = GestionRepresentations.GetRepresentationsVue();
            foreach (RepresentationVue representation in listRepresentation)
            {
                cboRepresentation.Items.Add($"{representation.Lieu} - {representation.Date} - {representation.Heure}");
            }
        }

        private void RemplirComboBoxClient()
        {
            List<Client> listClient = GestionReservations.GetClients();
            cboClientEnregistrer.Items.Add("");
            foreach (Client client in listClient)
            {
                cboClientEnregistrer.Items.Add($"{client.email} - {client.nom} - {client.prenom} - {client.telephone}");
            }
        }

        private void btnCalculer_Click(object sender, EventArgs e)
        {
            if (cboRepresentation.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner une représentation.", "Erreur de validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string selectedRepresentation = cboRepresentation.SelectedItem.ToString();
            string lieuRepresentation = selectedRepresentation.Split('-')[0].Trim();
            string dateRepresentation = selectedRepresentation.Split('-')[1].Trim();
            string heureRepresentation = selectedRepresentation.Split('-')[2] + ":00.0000000".Trim();

            if (selectedRepresentation == null)
            {
                MessageBox.Show("Représentation non trouvée.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Representation uneRepr = GestionRepresentations.GetRepresentationByLieuDateHours(lieuRepresentation, dateRepresentation, heureRepresentation);

            double tar_var = uneRepr.tarif.variation;

            if (uneRepr == null)
            {
                MessageBox.Show("Veuillez renseigné correctement la pièce de théâtre lié à une représentation. Tarif non trouvé", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double prixParPersonne = uneRepr.theatre.prix;

            double prixFinal = prixParPersonne + (prixParPersonne * (tar_var) / 100);

            if (!int.TryParse(txtNbPlace.Text.Trim(), out int nbPlaces))
            {
                MessageBox.Show("Le nombre de places doit être un nombre entier valide.", "Erreur de validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double prixTotal = prixFinal * nbPlaces;

            lblPrixPersonneAffichage.Text = prixParPersonne.ToString() + " euros ";
            lblPrixTotalAffichage.Text = prixTotal.ToString() + " euros ";
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            ModifierReservationEnCours();
        }

        private void ModifierReservationEnCours()
        {
            try
            {
                // Récupérer les informations du client sélectionné
                string selectedClient = cboClientEnregistrer.SelectedItem.ToString();
                string emailClient = selectedClient.Split('-')[0].Trim();
                Client client = GestionReservations.GetClientByEmail(emailClient);

                // Récupérer les informations de la représentation sélectionnée
                string selectedRepresentation = cboRepresentation.SelectedItem.ToString();
                string lieuRepresentation = selectedRepresentation.Split('-')[0].Trim();
                string dateRepresentation = selectedRepresentation.Split('-')[1].Trim();
                string heureRepresentation = selectedRepresentation.Split('-')[2].Trim() + ":00.0000000";
                Representation representation = GestionRepresentations.GetRepresentationByLieuDateHours(lieuRepresentation, dateRepresentation, heureRepresentation);

                // Récupérer le nombre de places
                if (!int.TryParse(txtNbPlace.Text.Trim(), out int nbPlaces))
                {
                    MessageBox.Show("Le nombre de places doit être un nombre entier valide.", "Erreur de validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Créer l'objet réservation
                Reservation reservation = new Reservation
                {
                    Representation = representation,
                    Client = client,
                    NbPlace = nbPlaces
                };

                GestionReservations.ModifierReservation(reservation);
        
                MessageBox.Show("La réservation a été modifiée avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Une erreur s'est produite lors de la modification de la réservation : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
