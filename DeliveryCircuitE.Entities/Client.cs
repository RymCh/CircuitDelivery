using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryCircuitE.Entities
{
  public  class Client
    
    {   [Key]
        public int Id { get; set; }
        [Required]
        public String FirstName { get; set; }
        [Required]
        public String LastName { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public String Email { get; set; }
        [Required]
        public String Tel { get; set; }
        [Required]
        public String Adress { get; set; }
      //  public List<Order> OrderListOfClient { get; set; }
    }
}
