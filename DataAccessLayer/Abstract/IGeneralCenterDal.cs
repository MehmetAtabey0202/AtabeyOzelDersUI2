using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
   public interface IGeneralCenterDal
    {
        List<GeneralCenter> ListAllGeneralCenter();
        void AddGeneralCenter(GeneralCenter generalCenter); 
        void DeleteGeneralCenter(GeneralCenter generalCenter);  
        void UpdateGeneralCenter(GeneralCenter generalCenter);
        GeneralCenter GetById(int id);  

        //Genel merkez tanımlaması için kullanılacak
    }

}
