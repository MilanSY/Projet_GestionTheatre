using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheatreGUI
{
    public static class Utils
    {
        public static void DisplayFormAtLoc(Form currentForm, Form form, Point location)
        {
            form.Show();
            form.Location = location;
            currentForm.Hide();
        }

        public static bool IsAlphanumeric(string str)
        {
            foreach (char c in str)
            {
                if (!char.IsLetterOrDigit(c))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
