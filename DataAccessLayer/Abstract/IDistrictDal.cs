using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IDistrictDal
    {
        List<District> ListAllDistricte();
        void AddDistrict(District district);
        void DeleteDistrict(District district);
        void UpdateDistrict(District district);
        District GetById(int id);
        
        //ilçeler için kullanılcak
    }
}
