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

            //remplissage des combo box
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

            if (string.IsNullOrWhiteSpace(txtDateJour.Text))
            {
                errorProvider.SetError(txtDateJour, "Veuillez remplir ce champ");
                hasError = true;
            }
            else
            {
                errorProvider.SetError(txtDateJour, "");
            }

            if (string.IsNullOrWhiteSpace(txtDateMois.Text))
            {
                errorProvider.SetError(txtDateMois, "Veuillez remplir ce champ");
                hasError = true;
            }
            else
            {
                errorProvider.SetError(txtDateMois, "");
            }

            if (string.IsNullOrWhiteSpace(txtDateAnnee.Text))
            {
                errorProvider.SetError(txtDateAnnee, "Veuillez remplir ce champ");
                hasError = true;
            }
            else
            {
                errorProvider.SetError(txtDateAnnee, "");
            }

            return hasError;
        }


        private void btnModifier_Click(object sender, EventArgs e)
        {

            Representation repr = new Representation (
                    id,
                    txtHeure.Text.Trim(),
                    dtpDate.Text.Trim(),
                    txtLieu.Text.Trim(),
                    Int32.Parse(txtPlace.Text.Trim()),
                    new Theatre{ nom = cboPiece.Text.Trim() },
                    new Tarif { libelle = cboTarif.Text.Trim() }
                );

            GestionRepresentations.ModifierRepresentation(repr);
            MessageBox.Show("Le théâtre a été modifié avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
