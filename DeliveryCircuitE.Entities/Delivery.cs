using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryCircuitE.Entities
{
   public class Delivery
    {
        [Key]
        public int Id { get; set; }
        public List<Order> OrderList { get; set; }
      
        public String Transport { get; set; }
    }
}
