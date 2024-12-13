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
using TheatreGUI;

namespace TheatreGUI
{
    public partial class AjoutTheatre : Form
    {
        private ErrorProvider errorProvider;
        public AjoutTheatre()
        {
            InitializeComponent();


            errorProvider = new ErrorProvider();

        }
        private void AjoutTheatre_Load(object sender, EventArgs e)
        {
            errorProvider.ContainerControl = this;

            //remplissage des combo box
            List<Auteur> listAuteur = GestionTheatres.GetAuteurs();
            foreach (Auteur auteur in listAuteur)
            {
                cboAuteur.Items.Add(auteur.nom + " " + auteur.prenom);
            }
            List<Theme> listTheme = GestionTheatres.GetThemes();
            foreach (Theme theme in listTheme)
            {
                cboTheme.Items.Add(theme.nom);
            }
            List<Publics> listPublic = GestionTheatres.GetPublics();
            foreach (Publics pub in listPublic)
            {
                cboPublic.Items.Add(pub.categ);
            }
            List<Compagnie> listCompagnie = GestionTheatres.GetCompagnies();
            foreach (Compagnie comp in listCompagnie)
            {
                cboCompagnie.Items.Add(comp.nom);
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            checkIfEmpty();
            checkIfFormatValid();

            if (checkIfEmpty())
            {
                MessageBox.Show("Veuillez remplir tous les champs obligatoires.", "Erreur de validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
            else if (checkIfFormatValid())
            {
                MessageBox.Show("Veuillez remplir les champs avec des valeurs valides.", "Erreur de validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                string[] auteur = cboAuteur.Text.Split(' ');

                // Introduire la modification dans la base de données
                Theatre theatre = new Theatre(
                    -1,
                    txtNom.Text.Trim(),
                    float.Parse(txtPrix.Text.Trim()),
                    txtDescription.Text.Trim(),
                    int.TryParse(txtDuree.Text.Trim(), out int duree) ? (int?)duree : null,
                    new Compagnie { nom = cboCompagnie.Text.Trim() },
                    new Publics { categ = cboPublic.Text.Trim() },
                    new Theme { nom = cboTheme.Text.Trim() },
                    new Auteur { nom = auteur[0], prenom = auteur[1] }
                );

                GestionTheatres.AjoutTheatre(theatre);
                MessageBox.Show("Le théâtre a été ajouté avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        // Controle de saisie si les champs sont vides
        private bool checkIfEmpty()
        {
            bool hasError = false;

            if (string.IsNullOrWhiteSpace(txtNom.Text))
            {
                errorProvider.SetError(txtNom, "Veuillez remplir ce champ");
                hasError = true;
            }
            else
            {
                errorProvider.SetError(txtNom, "");
            }

            if (string.IsNullOrWhiteSpace(txtPrix.Text))
            {
                errorProvider.SetError(txtPrix, "Veuillez remplir ce champ");
                hasError = true;
            }
            else
            {
                errorProvider.SetError(txtPrix, "");
            }

            if (string.IsNullOrWhiteSpace(txtDuree.Text))
            {
                errorProvider.SetError(txtDuree, "Veuillez remplir ce champ");
                hasError = true;
            }
            else
            {
                errorProvider.SetError(txtDuree, "");
            }

            if (string.IsNullOrWhiteSpace(cboTheme.Text))
            {
                errorProvider.SetError(cboTheme, "Veuillez remplir ce champ");
                hasError = true;
            }
            else
            {
                errorProvider.SetError(cboTheme, "");
            }

            if (string.IsNullOrWhiteSpace(cboCompagnie.Text))
            {
                errorProvider.SetError(cboCompagnie, "Veuillez remplir ce champ");
                hasError = true;
            }
            else
            {
                errorProvider.SetError(cboCompagnie, "");
            }

            if (string.IsNullOrWhiteSpace(cboPublic.Text))
            {
                errorProvider.SetError(cboPublic, "Veuillez remplir ce champ");
                hasError = true;
            }
            else
            {
                errorProvider.SetError(cboPublic, "");
            }

            if (string.IsNullOrWhiteSpace(cboAuteur.Text))
            {
                errorProvider.SetError(cboAuteur, "Veuillez remplir ce champ");
                hasError = true;
            }
            else
            {
                errorProvider.SetError(cboAuteur, "");
            }

            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                errorProvider.SetError(txtDescription, "Veuillez remplir ce champ");
                hasError = true;
            }
            else
            {
                errorProvider.SetError(txtDescription, "");
            }

            return hasError;
        }
        private bool checkIfFormatValid()
        {
            bool hasError = false;

            if (!float.TryParse(txtPrix.Text.Trim(), out _))
            {
                errorProvider.SetError(txtPrix, "Le prix doit être un nombre valide.");
                hasError = true;
            }
            else
            {
                errorProvider.SetError(txtPrix, "");
            }

            if (!int.TryParse(txtDuree.Text.Trim(), out _))
            {
                errorProvider.SetError(txtDuree, "La durée doit être un nombre entier.");
                hasError = true;
            }
            else
            {
                errorProvider.SetError(txtDuree, "");
            }

            if (txtNom.Text.Length > 100)
            {
                errorProvider.SetError(txtNom, "Le nom ne doit pas dépasser 100 caractères.");
                hasError = true;
            }
            else
            {
                errorProvider.SetError(txtNom, "");
            }

            if (txtDescription.Text.Length > 2000)
            {
                errorProvider.SetError(txtDescription, "La description ne doit pas dépasser 2000 caractères.");
                hasError = true;
            }
            else
            {
                errorProvider.SetError(txtDescription, "");
            }

            return hasError;
        }
        private void btnRetour_Click(object sender, EventArgs e)
        {
            Utils.DisplayFormAtLoc(this, new GestionTheatre());
        }

    }
}