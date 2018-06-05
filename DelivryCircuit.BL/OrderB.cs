using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeliveryCircuit.dal;
using DeliveryCircuitE.Entities;

namespace DelivryCircuit.BL
{
    public class OrderB
    {
        OrderRepository orderRepository = new OrderRepository();
        ClientRepository clientRepository = new ClientRepository();

        public void Add(Order o)
        {
            
            orderRepository.Add(o);
        }

        public Order Find(int id)
        {
  
            return orderRepository.FindOrderById(id);

        }
        public void Delete(Order o)
        {
            orderRepository.Delete(o);
        }
        //public List<Order> FindOrderByClientId( int idClient)
        //{
        //    Client client = clientRepository.FindClientById(idClient);

        //    return 
        //}

        public void FindOrderByClientId(int clientId)
        {
            //List<Order> ListOrder = new List<Order>();
            Client client = clientRepository.FindClientById(clientId);
            //ListOrder = orderRepository.GetAll();
            //foreach (Order order in ListOrder) {
            //if (order.ClientId==clientId)
            //    {
            //        ListOrder.Add(order);  
            //    }

            //}
            //return ListOrder;
            var ListOrder = orderRepository.GetAll().Find(item => (item.Id == clientId));
          
        }
        public void UpdateOrder(Order Order)
        {
            orderRepository.UpdateOrder(Order);
        }

        public List<Order> GetAll()
        {
            return orderRepository.GetAll();
        }
    }
}
