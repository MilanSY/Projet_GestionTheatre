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
    public partial class GestionFestival : Form
    {
        public GestionFestival()
        {
            InitializeComponent();
        }

        private void GestionFestival_Load(object sender, EventArgs e)
        {
            // Blocage de la génération automatique des colonnes
            dgv.AutoGenerateColumns = false;

            // Création d'une en-tête de colonne pour la colonne 1
            DataGridViewTextBoxColumn pieceColumn = new DataGridViewTextBoxColumn();
            pieceColumn.DataPropertyName = "NomTheatre";
            pieceColumn.HeaderText = "Piece";
            pieceColumn.ReadOnly = true;

            // Création d'une en-tête de colonne pour la colonne 2
            DataGridViewTextBoxColumn nbRepresentationColumn = new DataGridViewTextBoxColumn();
            nbRepresentationColumn.DataPropertyName = "NbRepresentations";
            nbRepresentationColumn.HeaderText = "Nombre de représentation";
            nbRepresentationColumn.ReadOnly = true;

            // Création d'une en-tête de colonne pour la colonne 3
            DataGridViewTextBoxColumn nbSpecTotalColumn = new DataGridViewTextBoxColumn();
            nbSpecTotalColumn.DataPropertyName = "NbSpectateursTotal";
            nbSpecTotalColumn.HeaderText = "Nombre de spectateur total";
            nbSpecTotalColumn.ReadOnly = true;


            // Création d'une en-tête de colonne pour la colonne 4
            DataGridViewTextBoxColumn nbSpecMoyenColumn = new DataGridViewTextBoxColumn();
            nbSpecMoyenColumn.DataPropertyName = "NbSpectateursMoyen";
            nbSpecMoyenColumn.HeaderText = "Nombre de spectateur moyen";
            nbSpecMoyenColumn.ReadOnly = true;

            // Création d'une en-tête de colonne pour la colonne 5
            DataGridViewTextBoxColumn caRealiseColumn = new DataGridViewTextBoxColumn();
            caRealiseColumn.DataPropertyName = "CARealise";
            caRealiseColumn.HeaderText = "CA Réalisé";
            caRealiseColumn.ReadOnly = true;

            // Création d'une en-tête de colonne pour la colonne 6
            DataGridViewTextBoxColumn caRealiseMoyenColumn = new DataGridViewTextBoxColumn();
            caRealiseMoyenColumn.DataPropertyName = "CARealiseMoyen";
            caRealiseMoyenColumn.HeaderText = "CA Réalisé";
            caRealiseMoyenColumn.ReadOnly = true;


            // Ajout des en-têtes de colonne au datagridview
            dgv.Columns.Add(pieceColumn);
            dgv.Columns.Add(nbRepresentationColumn);
            dgv.Columns.Add(nbSpecTotalColumn);
            dgv.Columns.Add(nbSpecMoyenColumn);
            dgv.Columns.Add(caRealiseColumn);
            dgv.Columns.Add(caRealiseMoyenColumn);

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
            List<FestivalVue> liste = GestionFestivals.GetFestivalVue();

            // Rattachement de la List à la source de données du datagridview
            dgv.DataSource = liste;


            dgv.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgv.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgv.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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
            List<FestivalVue> liste = GestionFestivals.GetFestivalVue();

            // Rattachement de la List à la source de données du datagridview
            dgv.DataSource = liste;
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            // Création d'un objet List à afficher dans le datagridview
            List<FestivalVue> liste = GestionFestivals.GetFestivalVue(dtpDate1.Text, dtpDate2.Text);

            // Rattachement de la List à la source de données du datagridview
            dgv.DataSource = liste;
        }
    }
}
