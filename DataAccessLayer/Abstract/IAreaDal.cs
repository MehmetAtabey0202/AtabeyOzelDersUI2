using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IAreaDal
    {
        List<Area> ListAllArea();
        void AddArea(Area area);
        void DeleteArea(Area area);
        void UpdateArea(Area area);
        Area GetById(int id);

        //Bölgeler için kullanılacak
    }
}
