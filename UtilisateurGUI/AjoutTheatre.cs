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
        public AjoutTheatre()
        {
            InitializeComponent();

            List<TheatreVue> listeTheatres = GestionTheatres.GetTheatres();

            // Récupération des thèmes uniques

            // Lier les données à la ComboBox
            cbxTheme.DisplayMember = "Nom";       // Propriété à afficher dans la ComboBox
            cbxTheme.ValueMember = "Id";          // Propriété utilisée en interne pour l'identifiant
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            lblErreurAuteur.Visible = false;
            lblErreurDescription.Visible = false;
            lblErreurNom.Visible = false;
            lblErreurDuree.Visible = false;
            lblErreurCompagnie.Visible = false;
            lblErreurPrix.Visible = false;
            lblErreurPublic.Visible = false;
            lblErreurTheme.Visible = false;



            List<string> erreurs = new List<string>();
            string nom = txtNom.Text.Trim();

            if (nom == "")
            {
                lblErreurNom.Visible = true;
                lblErreurNom.Text = "Veuillez saisir un nom";
                txtNom.Text = "";
                erreurs.Add(lblErreurNom.Text);
            }

            string description = txtDescription.Text.Trim();

            if (description == "")
            {
                lblErreurDescription.Visible = true;
                lblErreurDescription.Text = "veuillez saisir une description";
                txtDescription.Text = "";
                erreurs.Add(lblErreurDescription.Text);
            }

            string duree = txtDuree.Text.Trim();

            if (duree == "")
            {
                lblErreurDuree.Visible = true;
                lblErreurDuree.Text = "veuillez saisir une durée";
                txtDuree.Text = "";
                erreurs.Add(lblErreurDuree.Text);
            }
            else if (!Utils.OnlyNumbers(duree))
            {
                lblErreurDuree.Visible = true;
                lblErreurDuree.Text = "la durée ne peut contenir que des chiffres";
                erreurs.Add(lblErreurDuree.Text);
            }

            string prix = txtPrix.Text.Trim();

            if (prix == "")
            {
                lblErreurPrix.Visible = true;
                lblErreurPrix.Text = "veuillez saisir un prix";
                txtDuree.Text = "";
                erreurs.Add(lblErreurPrix.Text);
            }
            else if (!Utils.OnlyNumbers(prix))
            {
                lblErreurPrix.Visible = true;
                lblErreurPrix.Text = "le prix ne peut contenir que des nombres réels";
                erreurs.Add(lblErreurPrix.Text);
            }


            string auteur = cbxAuteur.Text;

            if ( auteur == "")
            {
                lblErreurPrix.Visible = true;
                lblErreurPrix.Text = "veuillez selectionné un auteur";
                txtDuree.Text = "";
                erreurs.Add(lblErreurPrix.Text);
            }

            string theme = cbxTheme.Text;

            if ( theme == "")
            {
                lblErreurPrix.Visible = true;
                lblErreurPrix.Text = "veuillez selectionné un theme";
                txtDuree.Text = "";
                erreurs.Add(lblErreurPrix.Text);
            }

            string publicCateg = cbxPublic.Text;

            if (publicCateg ==  "")
            {
                lblErreurPublic.Visible = true;
                lblErreurPublic.Text = "veuillez selectionné un theme";
                txtDuree.Text = "";
                erreurs.Add(lblErreurPublic.Text);
            }





        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            Utils.DisplayFormAtLoc(this, new GestionTheatre());
        }
    }
}