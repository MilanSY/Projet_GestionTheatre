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
    public partial class GestionRepresentation : Form
    {
        public GestionRepresentation()
        {
            InitializeComponent();

            //remplissage des combo box
            List<TheatreVue> listTheatre = GestionTheatres.GetTheatres();
            cboPiece.Items.Add("");
            foreach (TheatreVue theatre in listTheatre)
            {
                cboPiece.Items.Add(theatre.Nom);
            }

            // Blocage de la génération automatique des colonnes
            dgv.AutoGenerateColumns = false;
            dgv.CellClick += dgv_CellClick;

            // Création d'une en-tête de colonne pour la colonne 1
            DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn();
            idColumn.DataPropertyName = "Id";
            idColumn.HeaderText = "Identifiant";
            idColumn.ReadOnly = true;

            // Création d'une en-tête de colonne pour la colonne 2
            DataGridViewTextBoxColumn heureColumn = new DataGridViewTextBoxColumn();
            heureColumn.DataPropertyName = "Heure";
            heureColumn.HeaderText = "Heure";
            heureColumn.ReadOnly = true;

            // Création d'une en-tête de colonne pour la colonne 3
            DataGridViewTextBoxColumn dateColumn = new DataGridViewTextBoxColumn();
            dateColumn.DataPropertyName = "Date";
            dateColumn.HeaderText = "Date";
            dateColumn.ReadOnly = true;

            // Création d'une en-tête de colonne pour la colonne 4
            DataGridViewTextBoxColumn placeColumn = new DataGridViewTextBoxColumn();
            placeColumn.DataPropertyName = "Lieu";
            placeColumn.HeaderText = "Lieu";
            placeColumn.ReadOnly = true;


            // Création d'une en-tête de colonne pour la colonne 5
            DataGridViewTextBoxColumn lieuColumn = new DataGridViewTextBoxColumn();
            lieuColumn.DataPropertyName = "NbPlaceMax";
            lieuColumn.HeaderText = "Nombre de places";
            lieuColumn.ReadOnly = true;

            // Création d'une en-tête de colonne pour la colonne 6
            DataGridViewTextBoxColumn pieceColumn = new DataGridViewTextBoxColumn();
            pieceColumn.DataPropertyName = "Theatre";
            pieceColumn.HeaderText = "Piece jouée";
            pieceColumn.ReadOnly = true;

            // Création d'une en-tête de colonne pour la colonne 7
            DataGridViewTextBoxColumn tarifColumn = new DataGridViewTextBoxColumn();
            tarifColumn.DataPropertyName = "Tarif";
            tarifColumn.HeaderText = "Tarif";
            tarifColumn.ReadOnly = true;

            // Création d'une en-tête de colonne pour la colonne 8
            DataGridViewButtonColumn modifBtnColumn = new DataGridViewButtonColumn();
            modifBtnColumn.Name = "Modifier";
            modifBtnColumn.Text = "Modifier";
            modifBtnColumn.UseColumnTextForButtonValue = true;

            // Création d'une en-tête de colonne pour la colonne 9
            DataGridViewButtonColumn suppBtnColumn = new DataGridViewButtonColumn();
            suppBtnColumn.Name = "Supprimer";
            suppBtnColumn.Text = "Supprimer";
            suppBtnColumn.UseColumnTextForButtonValue = true;


            // Ajout des 11 en-têtes de colonne au datagridview
            dgv.Columns.Add(idColumn);
            dgv.Columns.Add(heureColumn);
            dgv.Columns.Add(dateColumn);
            dgv.Columns.Add(lieuColumn);
            dgv.Columns.Add(placeColumn);
            dgv.Columns.Add(pieceColumn);
            dgv.Columns.Add(tarifColumn);
            dgv.Columns.Add(modifBtnColumn);
            dgv.Columns.Add(suppBtnColumn);

            // Définition du style apporté au datagridview
            dgv.ColumnHeadersVisible = true;
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 10, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            // Récupération de chaîne de connexion à la BD à l'ouverture du formulaire
            GestionTheatres.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Utilisateur"]);

            // Création d'un objet List d'Utilisateur à afficher dans le datagridview
            List<RepresentationVue> liste = new List<RepresentationVue>();
            liste = GestionRepresentations.GetRepresentationsVue();

            // Rattachement de la List à la source de données du datagridview
            dgv.DataSource = liste;

            // Définit un style pour la bordure du formulaire
            FormBorderStyle = FormBorderStyle.FixedToolWindow;

            dgv.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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
            List<RepresentationVue> liste = GestionRepresentations.GetRepresentationsVue();

            // Rattachement de la List à la source de données du datagridview
            dgv.DataSource = liste;
        }

        private void GestionRepresentation_Load(object sender, EventArgs e)
        {
            // Création d'un objet List d'Utilisateur à afficher dans le datagridview
            List<RepresentationVue> liste = GestionRepresentations.GetRepresentationsVue();

            // Affichage de la liste au démarrage du formulaire
            dgv.DataSource = liste;

        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Vérifiez que l'événement ne provient pas de l'en-tête
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            if (dgv.Columns[e.ColumnIndex].Name == "Modifier")
            {
                int id = (int)dgv.Rows[e.RowIndex].Cells[0].Value;
                Console.WriteLine(id);
                ModifierRepresentation modifier = new ModifierRepresentation(id);
                Utils.DisplayFormAtLoc(this, modifier);
                return;
            }
            else if (dgv.Columns[e.ColumnIndex].Name == "Supprimer")
            {

                int id = (int)dgv.Rows[e.RowIndex].Cells[0].Value;

                // Confirmation de suppression
                DialogResult result = MessageBox.Show(
                    $"Êtes-vous sûr de vouloir supprimer la représentation N°{id}",
                    "Confirmation de suppression",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    if (GestionRepresentations.SupprimerRepresentation(id) == true)
                    {
                        MessageBox.Show($"La représentation N°{id} a été supprimée avec succès !");
                        // Rafraîchissement du DataGridView
                        List<RepresentationVue> liste = GestionRepresentations.GetRepresentationsVue();
                        dgv.DataSource = liste;
                    }
                    else
                    {
                        MessageBox.Show("Erreur : Impossible de supprimer la représentation à cause d'une dépendance.");
                    }
                }
                return;
            }
        }

        private void btnAjouter_Click(object sender, EventArgs negro)
        {
            Utils.DisplayFormAtLoc(this, new AjoutRepresentation());
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            if (ckbDates.Checked == true)
            {
                // Création d'un objet List avec le filtre appliqué à afficher dans le datagridview
                List<RepresentationVue> liste = GestionRepresentations.SearchRepresentation(cboPiece.Text);

                // Rattachement de la List à la source de données du datagridview
                dgv.DataSource = liste;
            }
            else
            {
                // Création d'un objet List avec le filtre appliqué à afficher dans le datagridview
                List<RepresentationVue> liste = GestionRepresentations.SearchRepresentation(cboPiece.Text, dtpDate1.Text, dtpDate2.Text);

                // Rattachement de la List à la source de données du datagridview
                dgv.DataSource = liste;
            }
        }
    }
}
