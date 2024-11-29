using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UtilisateurGUI
{
    public partial class AjoutReservation : Form
    {
        ErrorProvider errorProvider;
        public AjoutReservation()
        {
            InitializeComponent();
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
    }
}
