using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheatreBO;
using TheatreDAL;

namespace TheatreBLL
{
    public class GestionFestivals
    {

        public static List<FestivalVue> GetFestivalVue()
        {
            return FestivalDAO.GetFestivalVue();
        }

        public static List<FestivalVue> GetFestivalVue(string date1, string date2)
        {
            return FestivalDAO.GetFestivalVue(date1, date2);
        }
    }
}
