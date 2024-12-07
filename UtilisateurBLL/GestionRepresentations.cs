using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheatreBO;
using TheatreDAL;

namespace TheatreBLL
{
    public class GestionRepresentations
    {
        public static List<RepresentationVue> GetRepresentationsVue()
        {
            return RepresentationDAO.GetRepresentationsVue();
        }

        public static bool SupprimerRepresentation(int id)
        {
            return RepresentationDAO.SupprimerRepresentation(id);
        }

        public static Representation GetRepresentationById(int id)
        {
            return RepresentationDAO.GetRepresentationById(id);
        }

        public static List<Tarif> GetTarifs()
        {
            return RepresentationDAO.GetTarifs();
        }

        public static bool ModifierRepresentation(Representation repr)
        {
            return RepresentationDAO.ModifierRepresentation(repr);
        }

        public static bool AjouterRepresentation(Representation repr) 
        {
            return RepresentationDAO.AjouterRepresentation(repr);
        }

        public static List<RepresentationVue> SearchRepresentation(string nom)
        { 
            return RepresentationDAO.SearchRepresentation(nom);
        }
        public static List<RepresentationVue> SearchRepresentation(string nom, string date1, string date2)
        {
            return RepresentationDAO.SearchRepresentation(nom, date1, date2);
        }

        public static int GetIdRepresentationByLieuDateHours(string nom, string date, string heure)
        {
            return RepresentationDAO.GetIdRepresentationByLieuDateHours(nom, date, heure);
        }

        public static Tarif GetTarifById(int id)
        {
            return RepresentationDAO.GetTarifById(id);
        }


    }
}
