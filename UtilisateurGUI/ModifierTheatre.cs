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
            txtNomThemePieceDeTheatre.Text = vue.ThemeNom;
            // Valeur de la compagnie du théâtre
            txtCompagnie.Text = vue.CompagnieNom;
            // Valeur de la catégorie de publique du théâtre
            txtPublique.Text = vue.PublicCategNom;
            // Valeur du nom de l'auteur du théâtre
            txtNomAuteur.Text = vue.AuteurNom;
            // Valeur du prenom de l'auteur du théâtre
            txtPrenomAuteur.Text = vue.AuteurPrenom;
            // Valeur de la description du théâtre
            txtDescription.Text = vue.Description;
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
            if (checkIfEmpty())
            {
                MessageBox.Show("Veuillez remplir tous les champs obligatoires.", "Erreur de validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Introduire la modification dans la base de données
                Theatre theatre = new Theatre(
                    this.id,
                    txtNomPieceDeTheatre.Text.Trim(),
                    float.Parse(txtPrixPieceDeTheatre.Text.Trim()),
                    txtDescription.Text.Trim(),
                    int.TryParse(txtDureePieceDeTheatre.Text.Trim(), out int duree) ? (int?)duree : null,
                    new Compagnie { nom = txtCompagnie.Text.Trim() },
                    new Publics { categ = txtPublique.Text.Trim() },
                    new Theme { nom = txtNomThemePieceDeTheatre.Text.Trim() },
                    new Auteur { nom = txtNomAuteur.Text.Trim(), prenom = txtPrenomAuteur.Text.Trim() }
                );

                GestionTheatres.UpdateTheatre(theatre);
                MessageBox.Show("Le théâtre a été modifié avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Controle de saisie 
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

            if (string.IsNullOrWhiteSpace(txtNomThemePieceDeTheatre.Text))
            {
                errorProvider.SetError(txtNomThemePieceDeTheatre, "Veuillez remplir ce champ");
                hasError = true;
            }
            else
            {
                errorProvider.SetError(txtNomThemePieceDeTheatre, "");
            }

            if (string.IsNullOrWhiteSpace(txtCompagnie.Text))
            {
                errorProvider.SetError(txtCompagnie, "Veuillez remplir ce champ");
                hasError = true;
            }
            else
            {
                errorProvider.SetError(txtCompagnie, "");
            }

            return hasError;
        }
    }
}
