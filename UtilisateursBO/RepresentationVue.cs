using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheatreBO
{
    public class RepresentationVue
    {
        public int Id { get; set; }

        public string Heure { get; set; }

        public string Date { get; set; }

        public string Lieu { get; set; }

        public int NbPlaceMax { get; set; }

        public string Theatre { get; set; }

        public string Tarif { get; set; }

        public RepresentationVue(Representation representation)
        {
            Id = representation.id;
            Heure = representation.heure;
            Date = representation.date;
            Lieu = representation.lieu;
            NbPlaceMax = representation.nbPlaceMax;
            Theatre = representation.theatre.nom;
            Tarif = representation.tarif.libelle;
        }

        public RepresentationVue(int id, string heure, string date, string lieu, int nbPlaceMax, string theatre, string tarif)
        {
            Id = id;
            Heure = heure;
            Date = date;
            Lieu = lieu;
            NbPlaceMax = nbPlaceMax;
            Theatre = theatre;
            Tarif = tarif;
        }
    }
}
