using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface ISeasonDal
    {
        List<Season> ListAllSeason();
        void AddSeason(Season season);
        void DeleteSeason(Season season);
        void UpdateSeason(Season season);
        Season GetById(int id);
        
        //Sezon için kullanılacak
    }
}
