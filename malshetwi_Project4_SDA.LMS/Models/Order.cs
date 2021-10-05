using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace malshetwi_Project4_SDA.LMS.Models
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }


        // Relations
          public int ItemID { get; set; }
          [ForeignKey("ItemID")]
          public Item Item { get; set; }
    }
}
