using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeliveryCircuitE.Entities;

namespace DeliveryCircuit.dal
{
  public class OrderRepository
    {
        private DeliveryCircuitContext context;
        public OrderRepository()
        {
            context = new DeliveryCircuitContext();
        }
        

            public void Add(Order o)
            {
                context.Orders.Add(o);
                context.SaveChanges();
            }

       

            public void Delete(Order order)
            {
                context.Orders.Remove(order);
            }

            public List<Order> GetAll()
            {
                return context.Orders.ToList();
            }


        public Order GetOrderById(int id)
        {
            foreach (Order c in context.Orders.ToList())
            {
                if (c.Id == id)
                {
                    return c;
                }
            }
            return null;
        }


        public void UpdateOrder(Order Order)
        {
            Order s = GetOrderById(Order.Id);
            if (s != null)
            {
                context.Orders.Remove(s);
            }
            context.Orders.Add(Order);
            context.SaveChanges();
        }
        public Order FindOrderById(int Id)
        {
            foreach (Order c in context.Orders)
            {
                if (c.Id == Id) return c;

            }
            return null;
        }

    }
    }

