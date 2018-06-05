using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DeliveryCircuit.dal;
using DeliveryCircuitE.Entities;

namespace DelivryCircuit.BL
{
   public  class ProductB

    {
        ProductRepository productRepository = new ProductRepository();
        //List<Product> ProductList = new List<Product>();

        public void Add(Product p)
        {
            productRepository.Add(p);
        }
        public Product Find(int id)
        {
            return productRepository.FindProductById(id);
        }
        public void Delete(Product p) {
           
            productRepository.Delete(p);

        }
        public List<Product> GetAll()
        {
            return productRepository.GetAll();
        }
        public void UpdateProduct(Product Product)
        {
            productRepository.UpdateProduct(Product);
        }

    }
}
