using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheatreBO
{
    public class Publics
    {
        public int id {  get; set; }
        public string categ {  get; set; }

        public Publics(int id, string categ)
        {
            this.id = id;
            this.categ = categ;
        }
        public Publics() { }
    }
}
