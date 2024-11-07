using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheatreBO;
using TheatreBLL;
using System.Configuration;
using static System.Collections.Specialized.BitVector32;

namespace TheatreGUI
{
    public partial class Connexion : Form
    {
        public Connexion()
        {
            InitializeComponent();
            GestionUtilisateur.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Utilisateur"]);
        }

        private void Connexion_Load(object sender, EventArgs e)
        {

        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {

            List<Utilisateur> list = GestionUtilisateur.GetUtilisateurs();
            foreach(Utilisateur utilisateur in list)
            {
                if (utilisateur.getLoginUtilisateur() == txtLogin.Text.Trim())
                {
                    if (utilisateur.getMotDePasse() == txtMDP.Text.Trim())
                    {
                        Accueil accueil = new Accueil();
                        this.Hide();
                        accueil.Show();
                    }
                    else
                    {
                        //message d'erreur sur le mot de passe
                    }
                }
                else
                {
                    //message d'erreur sur le login
                }
            }

        }


    }
}
