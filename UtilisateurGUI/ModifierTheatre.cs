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
    public partial class ModifierTheatre : Form
    {
        private int id;
        private ErrorProvider errorProvider;
        private TheatreVue vue;
        public ModifierTheatre(int id)
        {
            this.id = id;
            InitializeComponent();
            this.vue = new TheatreVue(GestionTheatres.GetTheatreById(id));
            errorProvider = new ErrorProvider();

        }

        private void ModifierTheatre_Load(object sender, EventArgs e)
        {
            errorProvider.ContainerControl = this;
            // Valeur du nom du théâtre
            txtNomPieceDeTheatre.Text = vue.Nom;
            // Valeur de la durée du théâtre
            txtDureePieceDeTheatre.Text = vue.Duree.HasValue ? vue.Duree.Value.ToString() : string.Empty;
            // Valeur du prix du théâtre
            txtPrixPieceDeTheatre.Text = vue.Prix.ToString();
            // Valeur du thème du théâtre
            cboTheme.Text = vue.ThemeNom;
            // Valeur de la compagnie du théâtre
            cboCompagnie.Text = vue.CompagnieNom;
            // Valeur de la catégorie de publique du théâtre
            cboPublic.Text = vue.PublicCategNom;
            // Valeur du nom de l'auteur du théâtre
            cboAuteur.Text = vue.AuteurNom + " " + vue.AuteurPrenom;
            // Valeur de la description du théâtre
            txtDescription.Text = vue.Description;


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



        private void btnModifier_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            GestionTheatre menu = new GestionTheatre();
            Utils.DisplayFormAtLoc(this, menu);
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            checkIfEmpty();
            checkIfFormatValid();

            if (checkIfEmpty() && checkIfFormatValid())
            {
                MessageBox.Show("Veuillez remplir tous les champs obligatoires.", "Erreur de validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string[] auteur = cboAuteur.Text.Split(' ');

                // Introduire la modification dans la base de données
                Theatre theatre = new Theatre(
                    this.id,
                    txtNomPieceDeTheatre.Text.Trim(),
                    float.Parse(txtPrixPieceDeTheatre.Text.Trim()),
                    txtDescription.Text.Trim(),
                    int.TryParse(txtDureePieceDeTheatre.Text.Trim(), out int duree) ? (int?)duree : null,
                    new Compagnie { nom = cboCompagnie.Text.Trim() },
                    new Publics { categ = cboPublic.Text.Trim() },
                    new Theme { nom = cboTheme.Text.Trim() },
                    new Auteur { nom = auteur[0], prenom = auteur[1]}
                );
                
                GestionTheatres.UpdateTheatre(theatre);
                MessageBox.Show("Le théâtre a été modifié avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Controle de saisie si les champs sont vides
        private bool checkIfEmpty()
        {
            bool hasError = false;

            if (string.IsNullOrWhiteSpace(txtNomPieceDeTheatre.Text))
            {
                errorProvider.SetError(txtNomPieceDeTheatre, "Veuillez remplir ce champ");
                hasError = true;
            }
            else
            {
                errorProvider.SetError(txtNomPieceDeTheatre, "");
            }

            if (string.IsNullOrWhiteSpace(txtPrixPieceDeTheatre.Text))
            {
                errorProvider.SetError(txtPrixPieceDeTheatre, "Veuillez remplir ce champ");
                hasError = true;
            }
            else
            {
                errorProvider.SetError(txtPrixPieceDeTheatre, "");
            }

            if (string.IsNullOrWhiteSpace(txtDureePieceDeTheatre.Text))
            {
                errorProvider.SetError(txtDureePieceDeTheatre, "Veuillez remplir ce champ");
                hasError = true;
            }
            else
            {
                errorProvider.SetError(txtDureePieceDeTheatre, "");
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

            if (!float.TryParse(txtPrixPieceDeTheatre.Text.Trim(), out _))
            {
                errorProvider.SetError(txtPrixPieceDeTheatre, "Le prix doit être un nombre valide.");
                hasError = true;
            }
            else
            {
                errorProvider.SetError(txtPrixPieceDeTheatre, "");
            }

            if (!int.TryParse(txtDureePieceDeTheatre.Text.Trim(), out _))
            {
                errorProvider.SetError(txtDureePieceDeTheatre, "La durée doit être un nombre entier.");
                hasError = true;
            }
            else
            {
                errorProvider.SetError(txtDureePieceDeTheatre, "");
            }

            if (txtNomPieceDeTheatre.Text.Length > 100)
            {
                errorProvider.SetError(txtNomPieceDeTheatre, "Le nom ne doit pas dépasser 100 caractères.");
                hasError = true;
            }
            else
            {
                errorProvider.SetError(txtNomPieceDeTheatre, "");
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


    }

}
