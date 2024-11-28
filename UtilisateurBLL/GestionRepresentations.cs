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
    }
}
