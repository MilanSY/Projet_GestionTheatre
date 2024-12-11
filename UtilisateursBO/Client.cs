using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheatreBO
{
    public class Client
    {
        public int id { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public string email { get; set; }
        public int telephone { get; set; }

        public Client(int id, string nom, string prenom, string email, int telephone)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.email = email;
            this.telephone = telephone;
        }
    }
}
