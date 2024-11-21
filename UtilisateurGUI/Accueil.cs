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
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
        }

        private void btngestionpie_Click(object sender, EventArgs e)
        {
            // Fermeture du formulaire actuel et retour à l'acceuil
            GestionTheatre gestiontheatre = new GestionTheatre();
            this.Close();
            gestiontheatre.Show();
        }

        private void btngestionfesti_Click(object sender, EventArgs e)
        {
            GestionFestival gestionFestival = new GestionFestival();
            this.Close();
            gestionFestival.Show();
        }

        private void btngestionresa_Click(object sender, EventArgs e)
        {
            GestionReservation reservation = new GestionReservation();
            this.Close();
            reservation.Show();
        }

        private void btngestionrepre_Click(object sender, EventArgs e)
        {
            GestionRepresentation representation = new GestionRepresentation(); 
            this.Close();
            representation.Show();
        }

        private void btndeconnection_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
