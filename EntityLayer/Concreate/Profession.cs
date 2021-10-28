using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concreate
{
   public class Profession
    {
        [Key]
        public int Profession_ID { get; set; } //Meslek tanımlamaları burda tutulacak.
        public string Profession_Name { get; set; }
        public string Profession_Description { get; set; }



        //Standartlar
     //   public Employee Employee { get; set; }
        public int CreateBy_ID { get; set; }
        public DateTime Create_Date { get; set; }
        public int UpdateBy_ID { get; set; }
        public DateTime Update_Date { get; set; }
        public bool IsDelete { get; set; }
        public bool IsActive { get; set; }

    }
}
