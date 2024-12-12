using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheatreBLL;
using TheatreBO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace TheatreGUI
{
    public partial class AjoutReservation : Form
    {
        ErrorProvider errorProvider;
        public AjoutReservation()
        {
            InitializeComponent();
            errorProvider = new ErrorProvider();
            RemplirComboBoxRepresentation();
            cboRepresentation.SelectedIndexChanged += cboRepresentation_SelectedIndexChanged;
            txtPieceDeTheatre.ReadOnly = true;
        }

        private void RemplirComboBoxRepresentation()
        {
            List<RepresentationVue> listRepresentation = GestionRepresentations.GetRepresentationsVue();
            foreach (RepresentationVue representation in listRepresentation)
            {
                cboRepresentation.Items.Add($"{representation.Lieu} - {representation.Date} - {representation.Heure}");
            }
        }

        private void cboRepresentation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboRepresentation.SelectedItem != null)
            {
                string selectedRepresentation = cboRepresentation.SelectedItem.ToString();
                string lieuRepresentation = selectedRepresentation.Split('-')[0].Trim();
                string dateRepresentation = selectedRepresentation.Split('-')[1].Trim();
                string heureRepresentation = selectedRepresentation.Split('-')[2].Trim();

                List<TheatreVue> listTheatre = GestionTheatres.GetTheatresByRepresentation(lieuRepresentation, dateRepresentation, heureRepresentation);
                if (listTheatre.Count > 0)
                {
                    TheatreVue leTheatre = listTheatre[0];
                    txtPieceDeTheatre.Text = leTheatre.Nom;
                }
                else
                {
                    txtPieceDeTheatre.Text = "Erreur aucune pièce trouvé";
                    txtPieceDeTheatre.Focus();
                }
            }
        }

        // Controle de saisie si les champs sont vides
        private bool checkIfEmpty()
        {
            bool hasError = false;

            if (string.IsNullOrWhiteSpace(txtPieceDeTheatre.Text))
            {
                errorProvider.SetError(txtPieceDeTheatre, "Veuillez remplir ce champ");
                hasError = true;
            }
            else
            {
                errorProvider.SetError(txtPieceDeTheatre, "");
            }

            if (string.IsNullOrWhiteSpace(cboRepresentation.Text))
            {
                errorProvider.SetError(cboRepresentation, "Veuillez remplir ce champ");
                hasError = true;
            }
            else
            {
                errorProvider.SetError(cboRepresentation, "");
            }

            if (string.IsNullOrWhiteSpace(txtNbPlace.Text))
            {
                errorProvider.SetError(txtNbPlace, "Veuillez remplir ce champ");
                hasError = true;
            }
            else
            {
                errorProvider.SetError(txtNbPlace, "");
            }

            if (txtNbPlace.Text == "0")
            {
                errorProvider.SetError(txtNbPlace, "Le champ ne peut pas être égal à 0");
                hasError = true;
            }
            else
            {
                errorProvider.SetError(txtNbPlace, "");
            }

            if (string.IsNullOrWhiteSpace(txtNomClient.Text))
            {
                errorProvider.SetError(txtNomClient, "Veuillez remplir ce champ");
                hasError = true;
            }
            else
            {
                errorProvider.SetError(txtNomClient, "");
            }

            if (string.IsNullOrWhiteSpace(txtPrenomClient.Text))
            {
                errorProvider.SetError(txtPrenomClient, "Veuillez remplir ce champ");
                hasError = true;
            }
            else
            {
                errorProvider.SetError(txtPrenomClient, "");
            }

            if (string.IsNullOrWhiteSpace(txtEmailClient.Text))
            {
                errorProvider.SetError(txtEmailClient, "Veuillez remplir ce champ");
                hasError = true;
            }
            else
            {
                errorProvider.SetError(txtEmailClient, "");
            }

            if (string.IsNullOrWhiteSpace(txtTelClient.Text))
            {
                errorProvider.SetError(txtTelClient, "Veuillez remplir ce champ");
                hasError = true;
            }
            else
            {
                errorProvider.SetError(txtTelClient, "");
            }

            return hasError;
        }

        private bool checkIfFormatValid()
        {
            bool hasError = false;
            string regexEmail = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            if (!int.TryParse(txtNbPlace.Text.Trim(), out _))
            {
                errorProvider.SetError(txtNbPlace, "Le nombre de place doit être un nombre entier valide.");
                hasError = true;
            }
            else
            {
                errorProvider.SetError(txtNbPlace, "");
            }

            if (!int.TryParse(txtTelClient.Text.Trim(), out _))
            {
                errorProvider.SetError(txtTelClient, "Ce champ autorise uniquement des chiffres");
                hasError = true;
            }
            else
            {
                errorProvider.SetError(txtTelClient, "");
            }

            if (txtPieceDeTheatre.Text.Length > 100)
            {
                errorProvider.SetError(txtPieceDeTheatre, "Le nom ne doit pas dépasser 100 caractères.");
                hasError = true;
            }
            else
            {
                errorProvider.SetError(txtPieceDeTheatre, "");
            }

            if (txtNomClient.Text.Any(char.IsDigit) == true)
            {
                errorProvider.SetError(txtNomClient, "Le nom ne doit pas contenir de chiffre");
                hasError = true;
            }
            else
            {
                errorProvider.SetError(txtNomClient, "");
            }

            if (txtPrenomClient.Text.Any(char.IsDigit) == true)
            {
                errorProvider.SetError(txtPrenomClient, "Le prenom ne doit pas contenir de chiffre");
                hasError = true;
            }
            else
            {
                errorProvider.SetError(txtPrenomClient, "");
            }

            if (GestionReservations.VerifierEmail(txtEmailClient.Text))
            {
                errorProvider.SetError(txtEmailClient, "L'email existe déjà, le client existe en base de donnée");
                hasError = true;
            }
            else
            {
                errorProvider.SetError(txtEmailClient, "");
            }

            // Vérification du format de l'email
            if (Regex.IsMatch(txtEmailClient.Text, regexEmail))
            {
                errorProvider.SetError(txtPrenomClient, "");
            }
            else
            {
                errorProvider.SetError(txtEmailClient, "Veuillez écrire l'email dans le bon format");
                hasError = true;
            }

            return hasError;
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

            int id = GestionRepresentations.GetIdTarifRepresentationByLieuDateHours(lieuRepresentation, dateRepresentation, heureRepresentation);
            Tarif tarif = GestionRepresentations.GetTarifById(id);

            if (tarif == null)
            {
                MessageBox.Show("Veuillez renseigné correctement la pièce de théâtre lié à une représentation. Tarif non trouvé", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double prixParPersonne = GestionTheatres.GetPrixPieceDeTheatre(id);
            double tar_var = tarif.variation; 
            double prixFinal = prixParPersonne + (prixParPersonne * tar_var / 100);

            if (!int.TryParse(txtNbPlace.Text.Trim(), out int nbPlaces))
            {
                MessageBox.Show("Le nombre de places doit être un nombre entier valide.", "Erreur de validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double prixTotal = prixFinal * nbPlaces;

            lblPrixPersonneAffichage.Text = prixParPersonne.ToString() + " euros ";
            lblPrixTotalAffichage.Text = prixTotal.ToString() + " euros ";

        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            Utils.DisplayFormAtLoc(this, new TheatreGUI.GestionReservation());
        }

        // Code du bouton ajouter
        private void btnAjouter_Click_1(object sender, EventArgs e)
        {
            if (checkIfEmpty() == true)
            {
                MessageBox.Show("Veuillez remplir tous les champs obligatoires.", "Erreur de validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (checkIfFormatValid() == true)
            {
                MessageBox.Show("Erreur, vérifier les erreurs en passant le curseur sur les icones clignotante","Erreur de validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Code pour ajouter ou vérifier si un client est dans la base de donnée
                Client client = new Client(
                    -1,
                    txtNomClient.Text.Trim(),
                    txtPrenomClient.Text.Trim(),
                    txtEmailClient.Text.Trim(),
                    txtTelClient.Text.Trim()
                );

                // On vérifie si le client existe déjà dans la base de données
                client.id = GestionReservations.AjouterOuVerifierClient(client);

                // Récupérer les informations de la représentation sélectionnée
                string selectedRepresentation = cboRepresentation.SelectedItem.ToString();
                string lieuRepresentation = selectedRepresentation.Split('-')[0].Trim();
                string dateRepresentation = selectedRepresentation.Split('-')[1].Trim();
                string heureRepresentation = selectedRepresentation.Split('-')[2].Trim() + ":00.0000000";

                Representation representation = GestionRepresentations.GetRepresentationByLieuDateHours(lieuRepresentation, dateRepresentation, heureRepresentation);

                // Récupérer les informations du théâtre sélectionné
                string nomTheatre = txtPieceDeTheatre.Text;
                int idTheatre = GestionTheatres.GetTheatreIdByName(nomTheatre);
                Theatre theatre = GestionTheatres.GetTheatreById(idTheatre);

                // Créer l'objet réservation
                Reservation reservation = new Reservation(
                    representation,
                    client,
                    int.Parse(txtNbPlace.Text.Trim())
                );

                // Ajouter la réservation
                GestionReservations.AjoutReservation(reservation);

                // Message en cas de succès
                MessageBox.Show("Réservation ajoutée avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
