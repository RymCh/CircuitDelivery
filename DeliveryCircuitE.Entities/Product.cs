using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryCircuitE.Entities
{
    public class Product
    {
        [Key]
        public int Id{get; set;}
        public String Name { get; set; }
        public String Category { get; set; }
        public int OrderId { get; set; }
        public int Quantity { get; set; }
        public String Price { get; set; }
        

    }
}
