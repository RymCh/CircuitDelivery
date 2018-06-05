using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using DeliveryCircuitE.Entities;
using System.Data.Entity;
namespace DeliveryCircuit
{
    public class DeliveryCircuitContext : DbContext
    {
      
        public DbSet<Client> Clients { get; set; }
        public DbSet <Product>Products { get; set; }
        public DbSet <Order> Orders { get; set; }
        public  DbSet <Delivery> Deliveries { get; set; }



    }
}
