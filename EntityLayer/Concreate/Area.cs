using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concreate
{
    public class Area
    {
        [Key]
        public int Area_ID { get; set; }
        //public int Country_ID { get; set; }
        public Country Country { get; set; }
        public string Area_Name { get; set; }
        public string Area_Description { get; set; }



        //Standartlar
      //  public Employee Employee { get; set; }
        public int CreateBy_ID { get; set; }
        public DateTime Create_Date { get; set; }
        public int UpdateBy_ID { get; set; }
        public DateTime Update_Date { get; set; }
        public bool IsDelete { get; set; }
        public bool IsActive { get; set; }

        //İzinler
        public ICollection<Province> Provinces { get; set; }
    }
}


//Standartlar deneme
//  public Employee Employee { get; set; }
//public int CreateBy_ID { get; set; }
//public DateTime Create_Date { get; set; }
//public int UpdateBy_ID { get; set; }
//public DateTime Update_Date { get; set; }
//public bool IsDelete { get; set; }
//public bool IsActive { get; set; }