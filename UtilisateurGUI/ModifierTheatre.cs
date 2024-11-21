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
    public partial class ModifierTheatre : Form
    {
        private int id;
        public ModifierTheatre(int id)
        {
            this.id = id;

            InitializeComponent();

        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            GestionTheatre menu = new GestionTheatre();
            Utils.DisplayFormAtLoc(this, menu);
        }
    }
}
