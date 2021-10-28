using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concreate
{
 public   class Department
    {
        [Key]
        public int Department_ID { get; set; }
      //  public int GeneralCenter_ID { get; set; }  /*Departmanlar sadece genel merkeze bağlı * olarak çalışacağı için sadece genel merkez seçimi yapılacak */
        public GeneralCenter GeneralCenter{ get; set; }

        public string Department_Name { get; set; }
        public string Department_Description { get; set; }



        //Standartlar
      //  public Employee Employee { get; set; }
        public int CreateBy_ID { get; set; }
        public DateTime Create_Date { get; set; }
        public int UpdateBy_ID { get; set; }
        public DateTime Update_Date { get; set; }
        public bool IsDelete { get; set; }
        public bool IsActive { get; set; }

        //İzinler
        public ICollection<Employee> Employees { get; set; }
    }
}
