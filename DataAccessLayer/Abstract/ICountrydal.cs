using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface ICountrydal
    {
        List<Country> ListAllCountry();
        void AddCountry(Country country);
        void DeleteCountry(Country country);
        void UpdateCountry(Country country);
        Country GetById(int id);

        //Ulkeler iin kullanıcak
    }
}
