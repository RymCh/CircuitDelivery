using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryCircuitE.Entities
{
   public class Order
    {   
        [Key]
        public int Id { get; set; }
        public int ClientId{ get; set; }
        public List<Product> ProductList { get; set; }
        [Required]
        public DateTime Date { get; set; }
        public int DeliveryId { get; set; }
    }
}
