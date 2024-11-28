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

    }
}
