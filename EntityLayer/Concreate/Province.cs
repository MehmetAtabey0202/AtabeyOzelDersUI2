using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concreate
{
    public class Province
    {
        [Key]
        public int Province_ID { get; set; }
       // public int Area_ID { get; set; }
        public Area Area { get; set; }
        public string Province_Name { get; set; }



        //Standartlar
    //    public Employee Employee { get; set; }
        public int CreateBy_ID { get; set; }
        public DateTime Create_Date { get; set; }
        public int UpdateBy_ID { get; set; }
        public DateTime Update_Date { get; set; }
        public bool IsDelete { get; set; }
        public bool IsActive { get; set; }

        //İzinler
        public ICollection<District> Districts { get; set; }
    }
}
