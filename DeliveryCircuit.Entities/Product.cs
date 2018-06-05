using System;
using System.Collections.Generic;
using System.Text;

namespace DeliveryCircuit.Entities
{
    class Product
    {
        public String Name { get; set; }
        public String Category { get; set; }
        public String Description { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public int SellerId { get; set; }
    }
}
