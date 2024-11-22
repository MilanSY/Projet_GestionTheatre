using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheatreBO
{
    public class Theme
    {
        public int id {  get; set; }
        public string nom { get; set; }

        public Theme (int id, string name)
        {
            this.id = id;
            this.nom = name;
        }

        public Theme() { }


    }
}
