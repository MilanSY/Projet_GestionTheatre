using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheatreGUI
{
    public partial class ModifierRepresentation : Form
    {
        private ErrorProvider errorProvider;
        public ModifierRepresentation()
        {
            InitializeComponent();
            errorProvider = new ErrorProvider();
        }

        private void ModifierRepresentation_Load(object sender, EventArgs e)
        {

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


    }
}
