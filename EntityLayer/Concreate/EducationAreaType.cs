using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concreate
{
   public class EducationAreaType
    {
        [Key]
        public int EducationAreaType_ID { get; set; }  //Branş türü oluşturma için tutuluyor
        public string EducationAreaType_Name { get; set; }
        public string EducationAreaType_Description { get; set; }



        //Standartlar
      //  public Employee Employee { get; set; }
        public int CreateBy_ID { get; set; }
        public DateTime Create_Date { get; set; }
        public int UpdateBy_ID { get; set; }
        public DateTime Update_Date { get; set; }
        public bool IsDelete { get; set; }
        public bool IsActive { get; set; }
    }
}
