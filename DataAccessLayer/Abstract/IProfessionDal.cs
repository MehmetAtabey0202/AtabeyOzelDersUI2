using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IProfessionDal
    {
        List<Profession> ListAllProfession();
        void AddProfession(Profession profession);
        void DeleteProfession(Profession profession);
        void UpdateProfession(Profession profession);
        Profession GetById(int id);

        //Personeln mesleği && unvanı için kullanılacak.
    }
}
