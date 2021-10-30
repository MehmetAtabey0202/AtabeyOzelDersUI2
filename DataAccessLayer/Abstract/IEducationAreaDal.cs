using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IEducationAreaDal
    {
        List<EducationArea> ListAllEducationArea();
        void AddEducationArea(EducationArea educationArea);
        void DeleteEducationArea(EducationArea educationArea);
        void UpdateEducationArea(EducationArea educationArea);
        EducationArea GetById(int id);
        
        //Çalışma alanı için kullanılcak
    }
}
