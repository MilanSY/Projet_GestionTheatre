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
    public partial class GestionRepresentation : Form
    {
        public GestionRepresentation()
        {
            InitializeComponent();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            // Fermeture du formulaire actuel et retour à l'acceuil
            Accueil accueil = new Accueil();
            this.Close();
            accueil.Show();

        }

        private void btnRafraichir_Click(object sender, EventArgs e)
        {
            // Création d'un objet List d'Utilisateur à afficher dans le datagridview
            List<RepresentationVue> liste = GestionRepresentations.GetRepresentationsView(new Representation());

            // Rattachement de la List à la source de données du datagridview
            dataGridView1.DataSource = liste;
        }

    }
}
