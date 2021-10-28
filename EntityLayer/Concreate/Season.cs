using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concreate
{
    public class Season
    {
        [Key]
        public int Season_ID { get; set; }
     //   public Branch Branch { get; set; }
        public string Season_Name { get; set; }
        public int Season_Kode { get; set; }
        public int Season_WeekOfNumber { get; set; }
        public int Minimum_Advance_Rate { get; set; }
        public int Max_Installment { get; set; }        
        public DateTime Season_Start_Date { get; set; }
        public DateTime Season_End_Date { get; set; }
        public DateTime Season_StartOfEdication { get; set; }
        public DateTime Season_End_Installment { get; set; }
        public string Season_Description { get; set; }



        //Standartlar
     //   public Employee Employee { get; set; }
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
