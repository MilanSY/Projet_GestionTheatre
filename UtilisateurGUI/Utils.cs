using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheatreGUI
{
    public static class Utils
    {
        public static void DisplayFormAtLoc(Form currentForm, Form form)
        {
            form.Show();
            Thread.Sleep(500);
            currentForm.Close();
        }

        // Retourne false dès qu'un chiffre est trouvé, true sinon
        public static bool NoNumbers(string str)
        {
            foreach (char c in str)
            {
                if (char.IsDigit(c))
                {
                    Console.WriteLine(c);
                    Console.WriteLine(!char.IsDigit(c));
                    return false;
                }
            }
            return true;
        }

        public static bool OnlyFloat(string str)
        {
            // Vérifie si la chaîne est vide ou null
            if (string.IsNullOrEmpty(str))
                return false;

            // Compte le nombre de points décimaux et de signes négatifs
            int decimalPointCount = 0;

            for (int i = 0; i < str.Length; i++)
            {
                char c = str[i];

                if (c == '.' || c == ',')
                {
                    decimalPointCount++;

                    // Si plus d'un point décimal, ce n'est pas un float valide
                    if (decimalPointCount > 1)
                        return false;
                }
                else if (!char.IsDigit(c))
                {
                    // Retourne false si un caractère non numérique est trouvé
                    return false;
                }
            }

            // Si tout est correct, retourne true
            return true;
        }

        // Retourne false dès qu'un caractère non numérique est trouvé, true sinon
        public static bool OnlyNumbers(string str)
        {
            foreach (char c in str)
            {
                if (!char.IsDigit(c))
                {
                    Console.WriteLine(c);
                    Console.WriteLine(!char.IsDigit(c));
                    return false;
                }
            }
            return true;
        }
    }
}
