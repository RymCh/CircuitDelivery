using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeliveryCircuitE.Entities;

namespace DeliveryCircuit.dal
{
    public class ProductRepository
        {
        private DeliveryCircuitContext context;
        public ProductRepository()
        {
            context = new DeliveryCircuitContext();
        }
   

            public void Add(Product p)
            {
                context.Products.Add(p);
                context.SaveChanges();
            }

            public Product Find(string name)
            {
                foreach (Product p in context.Products)
                {
                    if (p.Name == name) return p;
                }
                return null;
            }

            public void Delete(Product product)
            {
            context.Products.Remove(product);
            }
        
            public List<Product> GetAll ()
            {
            return context.Products.ToList();
            }


        public Product GetProductById(int id)
        {
            foreach (Product c in context.Products.ToList())
            {
                if (c.Id == id)
                {
                    return c;
                }
            }
            return null;
        }


        public void UpdateProduct(Product Product)
        {
            Product s = GetProductById(Product.Id);
            if (s != null)
            {
                context.Products.Remove(s);
            }
            context.Products.Add(Product);
            context.SaveChanges();
        }

        public Product FindProductById(int Id)
        {
            foreach (Product c in context.Products)
            {
                if (c.Id == Id) return c;

            }
            return null;
        }

    }

}

