using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
   public  interface IDepartmentDal
    {
        List<Department> ListAllDepartment();
        void AddDepartment(Department department);
        void DeleteDepartment(Department department);
        void UpdateDepartment(Department department);
        Department GetById(int id);

        //Genel merkeze baglı departmanlar için kullanılcak
    }
}
