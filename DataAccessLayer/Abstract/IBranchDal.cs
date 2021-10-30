using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IBranchDal
    {
        List<Branch> ListAllBranch();
        void AddBranch(Branch branch);
        void DeleteBranch(Branch branch);
        void UpdateBranch(Branch branch);
        Branch GetById(int id);
        
        //Şubeler için kullanılacak
    }
}
