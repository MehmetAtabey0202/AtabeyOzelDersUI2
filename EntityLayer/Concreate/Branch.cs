using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concreate
{
    public class Branch
    {
        [Key]
        public int Branch_ID { get; set; }
      //  public int Season_ID { get; set; }
      //  public Season Season { get; set; }
     //   public int District_ID { get; set; }
        public District District { get; set; }
     //   public int Province_ID { get; set; }
        public Province Province { get; set; }


        public string Branch_Name { get; set; }
        public string Branch_Title { get; set; }
        public string Invoice_Place { get; set; } //fatura düzenleme yeri cursorda "Senet Düzenlenme Yeri Bilgisi :" olarak geçiyor.
        public string Branch_Address { get; set; }
        public int Employee_ID { get; set; } //Yetkili kişi personel tablosundan çekilecek.
        public int Province_PhoneNumber { get; set; }
        public int Province_PhoneNumber2 { get; set; }
        public string Branch_Mail { get; set; }
        public string Branch_Description { get; set; }
        public string Branch_Map { get; set; }
        public bool Distance_Learning { get; set; }



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
