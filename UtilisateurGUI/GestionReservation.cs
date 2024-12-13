using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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
    public partial class GestionReservation : Form
    {
        public GestionReservation()
        {
            InitializeComponent();

            // Blocage de la génération automatique des colonnes
            dgv.AutoGenerateColumns = false;
            dgv.CellClick += dgv_CellClick;


            // Création d'une en-tête de colonne pour la colonne 1
            DataGridViewTextBoxColumn clientColumn = new DataGridViewTextBoxColumn();
            clientColumn.DataPropertyName = "EmailClient";
            clientColumn.HeaderText = "Client";
            clientColumn.ReadOnly = true;

            // Création d'une en-tête de colonne pour la colonne 2
            DataGridViewTextBoxColumn representationColumn = new DataGridViewTextBoxColumn();
            representationColumn.DataPropertyName = "RepresentationText";
            representationColumn.HeaderText = "Representation";
            representationColumn.ReadOnly = true;

            // Création d'une en-tête de colonne pour la colonne 3
            DataGridViewTextBoxColumn placeColumn = new DataGridViewTextBoxColumn();
            placeColumn.DataPropertyName = "NbPlace";
            placeColumn.HeaderText = "NbPlace";
            placeColumn.ReadOnly = true;


            // Création d'une en-tête de colonne pour la colonne 4
            DataGridViewButtonColumn modifBtnColumn = new DataGridViewButtonColumn();
            modifBtnColumn.Name = "Modifier";
            modifBtnColumn.Text = "Modifier";
            modifBtnColumn.UseColumnTextForButtonValue = true;

            // Création d'une en-tête de colonne pour la colonne 5
            DataGridViewButtonColumn suppBtnColumn = new DataGridViewButtonColumn();
            suppBtnColumn.Name = "Supprimer";
            suppBtnColumn.Text = "Supprimer";
            suppBtnColumn.UseColumnTextForButtonValue = true;


            // Ajout des 5 en-têtes de colonne au datagridview
            dgv.Columns.Add(clientColumn);
            dgv.Columns.Add(representationColumn);
            dgv.Columns.Add(placeColumn);
            dgv.Columns.Add(modifBtnColumn);
            dgv.Columns.Add(suppBtnColumn);


            // Définition du style apporté au datagridview
            dgv.ColumnHeadersVisible = true;
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 10, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            // Définit un style pour la bordure du formulaire
            FormBorderStyle = FormBorderStyle.FixedToolWindow;

            // Récupération de chaîne de connexion à la BD à l'ouverture du formulaire
            GestionTheatres.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Utilisateur"]);

            // Création d'un objet List à afficher dans le datagridview
            List<ReservationVue> liste = GestionReservations.GetReservationVueList(GestionReservations.GetReservations());

            // Rattachement de la List à la source de données du datagridview
            dgv.DataSource = liste;


            dgv.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgv.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgv.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }


        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Vérifiez que l'événement ne provient pas de l'en-tête
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            if (dgv.Columns[e.ColumnIndex].Name == "Modifier")
            {

            }
            else if (dgv.Columns[e.ColumnIndex].Name == "Supprimer")
            {
                string emailClient = (string)dgv.Rows[e.RowIndex].Cells[0].Value;
                string vueRepr = (string)dgv.Rows[e.RowIndex].Cells[1].Value;
                string[] composentsRepr = vueRepr.Split(' ');
                int idRepr = Int32.Parse(composentsRepr[0]);
                int idClient = GestionReservations.getClientByEmail(emailClient).id;

                // Confirmation de suppression
                DialogResult result = MessageBox.Show(
                    $"Êtes-vous sûr de vouloir supprimer la reservation du client {emailClient} sur la représentation {vueRepr} ?",
                    "Confirmation de suppression",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    if (GestionReservations.SupprimerReservation(idClient, idRepr) == true)
                    {
                        MessageBox.Show($"La représentation du client {emailClient} sur la représentation {vueRepr} a été supprimée avec succès !");
                        // Rafraîchissement du DataGridView
                        List<ReservationVue> liste = GestionReservations.GetReservationVueList(GestionReservations.GetReservations());
                        dgv.DataSource = liste;
                    }
                    else
                    {
                        MessageBox.Show("Erreur : Impossible de supprimer la reservation à cause d'une dépendance.");
                    }
                }
                return;
            }
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
            // Création d'un objet List à afficher dans le datagridview
            List<ReservationVue> liste = GestionReservations.GetReservationVueList(GestionReservations.GetReservations());

            // Rattachement de la List à la source de données du datagridview
            dgv.DataSource = liste;
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Utils.DisplayFormAtLoc(this, new AjoutReservation());
        }
    }
}
