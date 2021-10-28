using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concreate
{
    public class Country
    {
        [Key]
        public int Country_ID { get; set; }
       // public int GeneralCenter_ID { get; set; } //Bağlı olduğu genel merkez ID si
        public GeneralCenter generalCenter { get; set; }



        public string Country_Name { get; set; }
        public string Doual_Kod { get; set; }
        public int Phone_Kod { get; set; }





        //Standartlar
      //  public Employee Employee { get; set; }
        public int CreateBy_ID { get; set; }
        public DateTime Create_Date { get; set; }
        public int UpdateBy_ID { get; set; }
        public DateTime Update_Date { get; set; }
        public bool IsDelete { get; set; }
        public bool IsActive { get; set; }

        //İzinler
        public ICollection<Area> Areas { get; set; }
    }
}




