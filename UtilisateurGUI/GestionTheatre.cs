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
    public partial class GestionTheatre : Form
    {
        public GestionTheatre()
        {
            InitializeComponent();
            // Blocage de la génération automatique des colonnes
            dgv.AutoGenerateColumns = false;

            // Création d'une en-tête de colonne pour la colonne 1
            DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn();
            idColumn.DataPropertyName = "id";
            idColumn.HeaderText = "Identifiant";

            // Création d'une en-tête de colonne pour la colonne 2
            DataGridViewTextBoxColumn nomColumn = new DataGridViewTextBoxColumn();
            nomColumn.DataPropertyName = "nom";
            nomColumn.HeaderText = "Nom";

            // Création d'une en-tête de colonne pour la colonne 3
            DataGridViewTextBoxColumn prixColum = new DataGridViewTextBoxColumn();
            prixColum.DataPropertyName = "prix";
            prixColum.HeaderText = "Prix";

            // Création d'une en-tête de colonne pour la colonne 4
            DataGridViewTextBoxColumn descriptColum = new DataGridViewTextBoxColumn();
            descriptColum.DataPropertyName = "description";
            descriptColum.HeaderText = "Description";

            // Création d'une en-tête de colonne pour la colonne 5
            DataGridViewTextBoxColumn dureeColum = new DataGridViewTextBoxColumn();
            dureeColum.DataPropertyName = "duree";
            dureeColum.HeaderText = "Durée";

            // Création d'une en-tête de colonne pour la colonne 6
            DataGridViewTextBoxColumn compColum = new DataGridViewTextBoxColumn();
            compColum.DataPropertyName = "compagnie";
            compColum.HeaderText = "Compagnie";

            // Création d'une en-tête de colonne pour la colonne 7
            DataGridViewTextBoxColumn pubColum = new DataGridViewTextBoxColumn();
            pubColum.DataPropertyName = "publicCateg";
            pubColum.HeaderText = "Type de publique";

            // Création d'une en-tête de colonne pour la colonne 8
            DataGridViewTextBoxColumn theColum = new DataGridViewTextBoxColumn();
            theColum.DataPropertyName = "theme";
            theColum.HeaderText = "Theme";

            // Création d'une en-tête de colonne pour la colonne 9
            DataGridViewTextBoxColumn autColum = new DataGridViewTextBoxColumn();
            autColum.DataPropertyName = "auteur";
            autColum.HeaderText = "Auteur";

            // Création d'une en-tête de colonne pour la colonne 10
            DataGridViewButtonColumn modifBtnColumn = new DataGridViewButtonColumn();

            modifBtnColumn.Name = "Modifier";
            modifBtnColumn.Text = "Modifier";
            modifBtnColumn.UseColumnTextForButtonValue = true;

            // Création d'une en-tête de colonne pour la colonne 11
            DataGridViewButtonColumn suprBtnColumn = new DataGridViewButtonColumn();

            suprBtnColumn.Name = "Suprimer";
            suprBtnColumn.Text = "Suprimer";
            suprBtnColumn.UseColumnTextForButtonValue = true;


            // Ajout des 11 en-têtes de colonne au datagridview
            dgv.Columns.Add(idColumn);
            dgv.Columns.Add(nomColumn);
            dgv.Columns.Add(prixColum);
            dgv.Columns.Add(descriptColum);
            dgv.Columns.Add(dureeColum);
            dgv.Columns.Add(compColum);
            dgv.Columns.Add(pubColum);
            dgv.Columns.Add(theColum);
            dgv.Columns.Add(autColum);
            dgv.Columns.Add(modifBtnColumn);
            dgv.Columns.Add(suprBtnColumn);

            // Définition du style apporté au datagridview
            dgv.ColumnHeadersVisible = true;
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 10, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            // Récupération de chaîne de connexion à la BD à l'ouverture du formulaire
            GestionTheatres.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Utilisateur"]);

            // Création d'un objet List d'Utilisateur à afficher dans le datagridview
            List<Theatre> liste = new List<Theatre>();
            liste = GestionTheatres.GetTheatres();

            // Rattachement de la List à la source de données du datagridview
            dgv.DataSource = liste;

            // Définit un style pour la bordure du formulaire
            FormBorderStyle = FormBorderStyle.FixedToolWindow;

            dgv.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            // Fermeture du formulaire actuel et retour à l'acceuil
            Accueil accueil = new Accueil();
            this.Close();
            accueil.Show();

        }
            // Code exécuté sur l'évènement Click du bouton Actualiser
            private void btnActualiser_Click(object sender, EventArgs e)
            {
                // Création d'un objet List d'Utilisateur à afficher dans le datagridview
                List<Utilisateur> liste = new List<Utilisateur>();
                liste = GestionUtilisateur.GetUtilisateurs();

                // Rattachement de la List à la source de données du datagridview
                dgv.DataSource = liste;
            }

        private void btnRafraichir_Click(object sender, EventArgs e)
        {
            // Création d'un objet List d'Utilisateur à afficher dans le datagridview
            List<Theatre> liste = GestionTheatres.GetTheatres();

            // Rattachement de la List à la source de données du datagridview
            dgv.DataSource = liste;
        }
    }
}
