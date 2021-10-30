using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IEducationAreaTypeDal
    {
        List<EducationAreaType> ListAllEducationAreaType();
        void AddEducationAreaType(Season educationAreaType);
        void DeleteEducationAreaType(EducationAreaType educationAreaType);
        void UpdateEducationAreaType(EducationAreaType educationAreaType);
        EducationAreaType GetById(int id);
        
        //Çalışma alanı tipi için kullanılacak(TM-MF)
    }
}
