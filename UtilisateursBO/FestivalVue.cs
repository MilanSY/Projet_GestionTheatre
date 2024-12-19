using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheatreBO
{
    public class FestivalVue
    {
        // Nom de la pièce
        public string NomTheatre { get; set; }

        // Nombre total de représentations
        public int NbRepresentations { get; set; }

        // Nombre total de spectateurs
        public int NbSpectateursTotal { get; set; }

        // Nombre moyen de spectateurs par représentation
        public float NbSpectateursMoyen { get; set; }

        // Chiffre d'affaires réalisé
        public float CARealise { get; set; }

        // Chiffre d'affaires moyen réalisé
        public float CARealiseMoyen { get; set; }

        // Constructeur par défaut
        public FestivalVue() { }

        // Constructeur avec paramètres
        public FestivalVue(string nomTheatre, int nbRepresentations, int nbSpectateursTotal, float nbSpectateursMoyen, float caRealise, float caRealiseMoyen)
        {
            NomTheatre = nomTheatre;
            NbRepresentations = nbRepresentations;
            NbSpectateursTotal = nbSpectateursTotal;
            NbSpectateursMoyen = nbSpectateursMoyen;
            CARealise = caRealise;
            CARealiseMoyen = caRealiseMoyen;
        }

    }
}
