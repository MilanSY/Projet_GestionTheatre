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
    public partial class AjoutRepresentation : Form
    {
        private ErrorProvider errorProvider;
        public AjoutRepresentation()
        {
            InitializeComponent();
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

        private void btnRetour_Click(object sender, EventArgs e)
        {
            Utils.DisplayFormAtLoc(this, new GestionRepresentation());
        }

        private void AjoutRepresentation_Load(object sender, EventArgs e)
        {
            errorProvider.ContainerControl = this;
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Representation repr = new Representation(
                    -1,
                    txtHeure.Text.Trim(),
                    dtpDate.Text.Trim(),
                    txtLieu.Text.Trim(),
                    Int32.Parse(txtPlace.Text.Trim()),
                    new Theatre { nom = cboPiece.Text.Trim() },
                    new Tarif { libelle = cboTarif.Text.Trim() }
                );

            GestionRepresentations.AjouterRepresentation(repr);
            MessageBox.Show("Le théâtre a été ajouté avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
