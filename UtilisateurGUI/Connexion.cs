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
using System.Security.Cryptography.X509Certificates;

namespace TheatreGUI
{
    public partial class Connexion : Form
    {
        public Connexion()
        {
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Connexion_KeyDown);

            InitializeComponent();
            GestionUtilisateur.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Utilisateur"]);
        }

        private void Connexion_Load(object sender, EventArgs e)
        {

        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            LblMessageNom.Visible = false;
            LblMotDePasse.Visible = false;
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
                        LblMotDePasse.Visible = true;

                    }
                }
                else
                {
                    LblMessageNom.Visible = true;
                }
            }
        }
       
        private void Connexion_KeyDown(object sender, KeyEventArgs e)
        {
            // Vérifie si la touche pressée est Entrée
            if (e.KeyCode == Keys.Enter) // SI Keys.Enter soit la touche entrée, alors cela se connecte
            {
                btnConnexion_Click(sender, e);
            }

            else if (e.KeyCode == Keys.Down)
            {
                txtMDP.Select();
            }

            else if (e.KeyCode == Keys.Up)
            {
                txtLogin.Select();
            }
        }





    }
}
