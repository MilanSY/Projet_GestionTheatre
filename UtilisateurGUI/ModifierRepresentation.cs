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

namespace TheatreGUI
{
    public partial class ModifierRepresentation : Form
    {
        int id;
        RepresentationVue vue;
        private ErrorProvider errorProvider;
        

        public ModifierRepresentation(int id)
        {
            this.id = id;
            InitializeComponent();
            this.vue = new RepresentationVue(GestionRepresentations.GetRepresentationById(id));
            errorProvider = new ErrorProvider();

            // remplissage des combo box
            List<TheatreVue> listTheatre = GestionTheatres.GetTheatres();
            foreach (TheatreVue theatre in listTheatre)
            {
                cboPiece.Items.Add(theatre.Nom);
            }
            List<Tarif> listTarif = GestionRepresentations.GetTarifs();
            foreach (Tarif tarif in listTarif)
            {
                cboTarif.Items.Add(tarif.libelle);
            }
        }

        private void ModifierRepresentation_Load(object sender, EventArgs e)
        {
            errorProvider.ContainerControl = this;
            txtLieu.Text = vue.Lieu;
            txtPlace.Text = vue.NbPlaceMax.ToString();
            txtHeure.Text = vue.Heure;
            cboPiece.Text = vue.Theatre;
            cboTarif.Text = vue.Tarif;
            dtpDate.Text = vue.Date;
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            Utils.DisplayFormAtLoc(this, new GestionRepresentation());
        }

        private bool checkIfEmpty()
        {
            bool hasError = false;

            if (string.IsNullOrWhiteSpace(txtLieu.Text))
            {
                errorProvider.SetError(txtLieu, "Veuillez remplir ce champ");
                hasError = true;
            }
            else
            {
                errorProvider.SetError(txtLieu, "");
            }

            if (string.IsNullOrWhiteSpace(txtPlace.Text))
            {
                errorProvider.SetError(txtPlace, "Veuillez remplir ce champ");
                hasError = true;
            }
            else
            {
                errorProvider.SetError(txtPlace, "");
            }

            if (string.IsNullOrWhiteSpace(txtHeure.Text))
            {
                errorProvider.SetError(txtHeure, "Veuillez remplir ce champ");
                hasError = true;
            }
            else
            {
                errorProvider.SetError(txtHeure, "");
            }

            if (string.IsNullOrWhiteSpace(dtpDate.Text))
            {
                errorProvider.SetError(dtpDate, "Veuillez remplir ce champ");
                hasError = true;
            }
            else
            {
                errorProvider.SetError(dtpDate, "");
            }

            return hasError;
        }

        private bool checkIfFormatValid()
        {
            bool hasError = false;
            // Regex pour le format hh:mm
            string timeFormat = @"^(2[0-3]|[01]?[0-9]):[0-5][0-9]$";

            if (!float.TryParse(txtPlace.Text.Trim(), out _))
            {
                errorProvider.SetError(txtPlace, "Le nombre de place doit être un nombre valide.");
                hasError = true;
            }
            else
            {
                errorProvider.SetError(txtPlace, "");
            }

            if (txtLieu.Text.Length > 100)
            {
                errorProvider.SetError(txtPlace, "Le lieu doit être valide.");
                hasError = true;
            }
            else
            {
                errorProvider.SetError(txtLieu, "");
            }

            if (txtHeure.Text.Length > 7)
            {
                errorProvider.SetError(txtHeure, "L'heure doit être valide.");
                hasError = true;
            }
            else
            {
                errorProvider.SetError(txtHeure, "");
            }

            //controle de saisie de l'heure
            // Vérifier si le texte correspond au pattern
            if (txtHeure.Text.Count() < 3)
            {
                if (!int.TryParse(txtPlace.Text.Trim(), out _))
                {
                    errorProvider.SetError(txtHeure, "L'heure doit être valide. HH:mm ou HH:");
                    hasError = true; // Format invalide
                }
                else
                {
                    errorProvider.SetError(txtHeure, "");
                }
            }
            else if (Regex.IsMatch(txtHeure.Text, timeFormat) == false)
            {
                errorProvider.SetError(txtHeure, "L'heure doit être valide. HH:mm ou HH");
                hasError = true; // Format invalide
            }
            else
            {
                errorProvider.SetError(txtHeure, "");
            }

            return hasError;

        }


        private void btnModifier_Click(object sender, EventArgs e)
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
                Representation repr = new Representation(
                    id,
                    txtHeure.Text.Trim(),
                    dtpDate.Text.Trim(),
                    txtLieu.Text.Trim(),
                    Int32.Parse(txtPlace.Text.Trim()),
                    new Theatre { nom = cboPiece.Text.Trim() },
                    new Tarif { libelle = cboTarif.Text.Trim() }
                );

                GestionRepresentations.ModifierRepresentation(repr);
                MessageBox.Show("La représentation a été modifié avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
