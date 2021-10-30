using EntityLayer.Concreate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
   public class Context: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.; database=AtabeyDB; Integrated Security = true;"); 
        }

        public DbSet<Area> Areas { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<EducationArea> EducationAreas { get; set; }
        public DbSet<EducationAreaType> EducationAreaTypes { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<GeneralCenter> GeneralCenters { get; set; }
        public DbSet<Profession> Professions { get; set; }
        public DbSet<Province> Provinces { get; set; }
        public DbSet<Season> Seasons { get; set; }



    }
}
