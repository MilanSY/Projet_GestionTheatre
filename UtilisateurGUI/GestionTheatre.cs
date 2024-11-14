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
            DataGridViewTextBoxColumn idcolumn = new DataGridViewTextBoxColumn();
            idcolumn.DataPropertyName = "pie_id";
            idcolumn.HeaderText = "Identifiant";

            // Création d'une en-tête de colonne pour la colonne 2
            DataGridViewTextBoxColumn nomcolumn = new DataGridViewTextBoxColumn();
            nomcolumn.DataPropertyName = "Nom";
            nomcolumn.HeaderText = "Nom de la piece";

            // Création d'une en-tête de colonne pour la colonne 3
            DataGridViewTextBoxColumn prix_colum = new DataGridViewTextBoxColumn();
            prix_colum.DataPropertyName = "pie_prix";
            prix_colum.HeaderText = "Prix";

            // Création d'une en-tête de colonne pour la colonne 4
            DataGridViewTextBoxColumn descript_colum = new DataGridViewTextBoxColumn();
            descript_colum.DataPropertyName = "Pie_descript";
            descript_colum.HeaderText = "Description";

            // Création d'une en-tête de colonne pour la colonne 5
            DataGridViewTextBoxColumn duree_colum = new DataGridViewTextBoxColumn();
            duree_colum.DataPropertyName = "Pie_duree";
            duree_colum.HeaderText = "Durée";

            // Création d'une en-tête de colonne pour la colonne 6
            DataGridViewTextBoxColumn comp_colum = new DataGridViewTextBoxColumn();
            comp_colum.DataPropertyName = "Pie_comp";
            comp_colum.HeaderText = "Compagnie";

            // Création d'une en-tête de colonne pour la colonne 7
            DataGridViewTextBoxColumn pub_colum = new DataGridViewTextBoxColumn();
            pub_colum.DataPropertyName = "pie_pub";
            pub_colum.HeaderText = "Type de publique";

            // Création d'une en-tête de colonne pour la colonne 8
            DataGridViewTextBoxColumn the_colum = new DataGridViewTextBoxColumn();
            the_colum.DataPropertyName = "pie_the";
            the_colum.HeaderText = "Theme";

            // Création d'une en-tête de colonne pour la colonne 9
            DataGridViewTextBoxColumn aut_colum = new DataGridViewTextBoxColumn();
            aut_colum.DataPropertyName = "pie_aut";
            aut_colum.HeaderText = "Auteur";




            // Ajout des 9 en-têtes de colonne au datagridview
            dgv.Columns.Add(idcolumn);
            dgv.Columns.Add(nomcolumn);
            dgv.Columns.Add(prix_colum);
            dgv.Columns.Add(descript_colum);
            dgv.Columns.Add(duree_colum);
            dgv.Columns.Add(comp_colum);
            dgv.Columns.Add(pub_colum);
            dgv.Columns.Add(the_colum);
            dgv.Columns.Add(aut_colum);










            // Définition du style apporté au datagridview
            dgv.ColumnHeadersVisible = true;
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 10, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            // Récupération de chaîne de connexion à la BD à l'ouverture du formulaire
            GestionUtilisateur.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Utilisateur"]);

            // Création d'un objet List d'Utilisateur à afficher dans le datagridview
            List<Utilisateur> liste = new List<Utilisateur>();
            liste = GestionUtilisateur.GetUtilisateurs();

            // Rattachement de la List à la source de données du datagridview
            dgv.DataSource = liste;

            // Définit un style pour la bordure du formulaire
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
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
        }
}
