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
            idColumn.DataPropertyName = "Id";
            idColumn.HeaderText = "Identifiant";
            idColumn.ReadOnly = true;   

            // Création d'une en-tête de colonne pour la colonne 2
            DataGridViewTextBoxColumn nomColumn = new DataGridViewTextBoxColumn();
            nomColumn.DataPropertyName = "Nom";
            nomColumn.HeaderText = "Nom";
            nomColumn.ReadOnly = true;

            // Création d'une en-tête de colonne pour la colonne 3
            DataGridViewTextBoxColumn prixColum = new DataGridViewTextBoxColumn();
            prixColum.DataPropertyName = "Prix";
            prixColum.HeaderText = "Prix";
            prixColum.ReadOnly = true;

            // Création d'une en-tête de colonne pour la colonne 4
            DataGridViewTextBoxColumn descriptColum = new DataGridViewTextBoxColumn();
            descriptColum.DataPropertyName = "Description";
            descriptColum.HeaderText = "Description";
            descriptColum.ReadOnly = true;

            // Création d'une en-tête de colonne pour la colonne 5
            DataGridViewTextBoxColumn dureeColum = new DataGridViewTextBoxColumn();
            dureeColum.DataPropertyName = "Duree";
            dureeColum.HeaderText = "Durée";

            // Création d'une en-tête de colonne pour la colonne 6
            DataGridViewTextBoxColumn compColum = new DataGridViewTextBoxColumn();
            compColum.DataPropertyName = "CompagnieNom";
            compColum.HeaderText = "Compagnie";
            compColum.ReadOnly = true;

            // Création d'une en-tête de colonne pour la colonne 7
            DataGridViewTextBoxColumn pubColum = new DataGridViewTextBoxColumn();
            pubColum.DataPropertyName = "PublicCategNom";
            pubColum.HeaderText = "Type de publique";
            pubColum.ReadOnly = true;

            // Création d'une en-tête de colonne pour la colonne 8
            DataGridViewTextBoxColumn theColum = new DataGridViewTextBoxColumn();
            theColum.DataPropertyName = "ThemeNom";
            theColum.HeaderText = "Theme";
            theColum.ReadOnly = true;

            // Création d'une en-tête de colonne pour la colonne 9
            DataGridViewTextBoxColumn autColum = new DataGridViewTextBoxColumn();
            autColum.DataPropertyName = "AuteurNomPrenom";
            autColum.HeaderText = "Auteur";
            autColum.ReadOnly = true;

            // Création d'une en-tête de colonne pour la colonne 10
            DataGridViewButtonColumn modifBtnColumn = new DataGridViewButtonColumn();
            modifBtnColumn.Name = "Modifier";
            modifBtnColumn.Text = "Modifier";
            modifBtnColumn.UseColumnTextForButtonValue = true;

            // Création d'une en-tête de colonne pour la colonne 11
            DataGridViewButtonColumn suppBtnColumn = new DataGridViewButtonColumn();
            suppBtnColumn.Name = "Supprimer";
            suppBtnColumn.Text = "Supprimer";
            suppBtnColumn.UseColumnTextForButtonValue = true;


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
            List<TheatreVue> liste = new List<TheatreVue>();
            liste = GestionTheatres.GetTheatres();


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
            dgv.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv.Columns[10].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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
            List<TheatreVue> liste = GestionTheatres.GetTheatres();

            // Rattachement de la List à la source de données du datagridview
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
                ModifierTheatre modifier= new ModifierTheatre(id);
                Utils.DisplayFormAtLoc(this, modifier);
                return;
            }
            else if (dgv.Columns[e.ColumnIndex].Name == "Supprimer")
            {
                int id = (int)dgv.Rows[e.RowIndex].Cells[0].Value;
                string nom = dgv.Rows[e.RowIndex].Cells[1].Value.ToString();

                // Confirmation de suppression
                DialogResult result = MessageBox.Show(
                    $"Êtes-vous sûr de vouloir supprimer la pièce \"{nom}\" ?",
                    "Confirmation de suppression",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    if (GestionTheatres.SupprimerTheatre(id))
                    {
                        lblResultat.Text = $"La pièce N°{id} ({nom}) a été supprimée avec succès !";
                        // Rafraîchissement du DataGridView
                        List<TheatreVue> liste = GestionTheatres.GetTheatres();
                        dgv.DataSource = liste;
                    }
                    else
                    {
                        lblResultat.Text = "Erreur : Impossible de supprimer la pièce.";
                    }
                }
                return;
            }
        }
    }

}
