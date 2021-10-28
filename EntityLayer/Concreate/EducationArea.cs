using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concreate
{
   public class EducationArea
    {
        [Key]
        public int EducationArea_ID { get; set; } //Branş ekleme için tutuluyor
      //  public int Season_ID { get; set; }
        public Season Season { get; set; }
      //  public int EducationAreaType_ID { get; set; }  //Branş türü için tutuluyor
        public EducationAreaType EducationAreaType { get; set; }
        public string EducationArea_Name { get; set; }
        public string EducationArea_Description { get; set; }


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
