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

namespace TheatreGUI
{
    public partial class ModificationReservation : Form
    {
        public ModificationReservation(string emailClient, int IdRepr)
        {
            InitializeComponent();
        }

        public ModificationReservation(Reservation reservationToModify)
        {
            InitializeComponent();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            Utils.DisplayFormAtLoc(this, new GestionReservation());
        }
    }
}
