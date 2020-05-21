using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ConnectingToHWDatabase.database
{
    [Table("Hardware_Purchased")]
    
        public class HWEntity
        {
                [Key]
        public int HWID { get; set; }

        public string Hardware_Name { get; set; }

        public string Hardware_Brand { get; set; }

         public string Hardware_Model { get; set; }

         public string Hardware_Type { get; set; }

         public string Hardware_Status { get; set; }

         public decimal Hardware_Price { get; set; }

        // public DateTime Hardware_DOP{ get; set; }


        }

    }

