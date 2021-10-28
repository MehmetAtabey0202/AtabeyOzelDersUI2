using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concreate
{
    public class GeneralCenter
    {
        [Key]
        public int GeneralCenter_ID { get; set; }
        public int Country_ID { get; set; }  //Genel merkezin adresi için kullanılacak
        public int Area_ID { get; set; }  //Genel merkezin adresi için kullanılacak
        public int District_ID { get; set; }  //Genel merkezin adresi için kullanılacak
        public int Province_ID { get; set; }  //Genel merkezin adresi için kullanılacak
        public string GeneralCenter_Description { get; set; }
        public string Phone_Number { get; set; }
        public string Phone_Number2 { get; set; }
        public string E_Mail { get; set; }



        //Standartlar
      //  public Employee Employee { get; set; }
        public int CreateBy_ID { get; set; }
        public DateTime Create_Date { get; set; }
        public int UpdateBy_ID { get; set; }
        public DateTime Update_Date { get; set; }
        public bool IsDelete { get; set; }
        public bool IsActive { get; set; }


        public ICollection<Department> Departments { get; set; } //Bu komut ile GeneralCenter clasını Departmanda kullancağımı belirttim.
        public ICollection<Country> Countries { get; set; }


    }
}
