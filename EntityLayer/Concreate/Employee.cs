using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concreate
{
  public  class Employee
    {
        [Key]
        public int Employee_ID { get; set; }
     //   public int District_ID { get; set; } //Çalıştığı İl
        public District District { get; set; }
      //  public int Province_ID { get; set; } //Çalıştığı İlçe için kullanılacak.(Kişisel bilgileri detay sayfasına eklenecek)
        public Province Province { get; set; }
      //  public int Department_ID { get; set; }//hangi departmanda çalıştıgını çekecek.(Öğrenmen vb ise boş geçebilir)
        public Department Department { get; set; }
      //  public int Profession_ID { get; set; } //Görevi meslek tablosundan çekecek
        public Profession Profession { get; set; }


        public int Employee_Name { get; set; }
        public int Employee_Surname { get; set; }
        public string Employee_Description { get; set; }


        //Standartlar
       
        public int CreateBy_ID { get; set; }
        public DateTime Create_Date { get; set; }
        public int UpdateBy_ID { get; set; }
        public DateTime Update_Date { get; set; }
        public bool IsDelete { get; set; }
        public bool IsActive { get; set; }

        //İzinler
        public ICollection<Branch> Branches { get; set; }
    }
}
