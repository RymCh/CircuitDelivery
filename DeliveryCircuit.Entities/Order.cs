using System;
using System.Collections.Generic;
using System.Text;

namespace DeliveryCircuit.Entities
{
    class Order
    {
      
        public int id { get; set; }
        public int ProductId { get; set; }
        public int ClientId { get; set; }
        public DateTime Date { get; set; }
        public DateTime Deadline { get; set; }
    }
}
