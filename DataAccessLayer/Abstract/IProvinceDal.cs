using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IProvinceDal
    {
        List<Province> ListAllProvince();
        void AddProvince(Province province);
        void DeleteProvince(Province province);
        void UpdateProvince(Province province);
        Province GetById(int id);

        //İller için kullanılacak
    }
}
