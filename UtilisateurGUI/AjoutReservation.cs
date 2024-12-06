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

namespace UtilisateurGUI
{
    public partial class AjoutReservation : Form
    {
        ErrorProvider errorProvider;
        public AjoutReservation()
        {
            InitializeComponent();
            // Remplissage des combos boxs
            List<TheatreVue> listTheatre = GestionTheatres.GetTheatres();
            foreach (TheatreVue theatre in listTheatre)
            {
                cboPieceDeTheatre.Items.Add(theatre.Nom);
            }
            List<RepresentationVue> listRepresentation = GestionRepresentations.GetRepresentationsVue();
            foreach (RepresentationVue representation in listRepresentation)
            {
                cboRepresentation.Items.Add($"{representation.Lieu} - {representation.Date}");
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {

            if (checkIfEmpty() == true)
            {
                MessageBox.Show("Veuillez remplir tous les champs obligatoires.", "Erreur de validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (checkIfFormatValid() == true)
            {
                MessageBox.Show("Erreur, format des champs non valide", "Erreur de validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                /* Reservation reservation = new Reservation(
                        -1,
                        txtHeure.Text.Trim(),
                        dtpDate.Text.Trim(),
                        txtLieu.Text.Trim(),
                        Int32.Parse(txtPlace.Text.Trim()),
                        new Theatre { nom = cboPiece.Text.Trim() },
                        new Tarif { libelle = cboTarif.Text.Trim() }
                    );

                GestionRepresentations.AjouterRepresentation(repr);
                MessageBox.Show("Le théâtre a été ajouté avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information); */
            }
        }

        // Controle de saisie si les champs sont vides
        private bool checkIfEmpty()
        {
            bool hasError = false;

            if (string.IsNullOrWhiteSpace(cboPieceDeTheatre.Text))
            {
                errorProvider.SetError(cboPieceDeTheatre, "Veuillez remplir ce champ");
                hasError = true;
            }
            else
            {
                errorProvider.SetError(cboPieceDeTheatre, "");
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

            if (cboPieceDeTheatre.Text.Length > 100)
            {
                errorProvider.SetError(cboPieceDeTheatre, "Le nom ne doit pas dépasser 100 caractères.");
                hasError = true;
            }
            else
            {
                errorProvider.SetError(cboPieceDeTheatre, "");
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

            return hasError;
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool checkIfPlaceAvailable()
        {
            int nbPlaceSaisie = int.Parse(txtNbPlace.Text.Trim());
            int nbPlaceRestante = GestionRepresentations.GetNbPlaceRestante(cboRepresentation.Text);

            if (nbPlaceSaisie > nbPlaceRestante)
            {
                errorProvider.SetError(txtNbPlace, "Le nombre de places saisies est supérieur au nombre de places restantes.");
                return false;
            }
            else
            {
                errorProvider.SetError(txtNbPlace, "");
                return true;
            }
        }

        private void btnCalculer_Click(object sender, EventArgs e)
        {
            checkIfPlaceAvailable();
        }
    }
}
