using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using DeliveryCircuit.dal;
using DeliveryCircuitE.Entities;
namespace DelivryCircuit.BL
{
   public class DeliveryB
    {
        DeliveryRepository DRepository = new DeliveryRepository();

        OrderRepository orderRepository = new OrderRepository();

        public void Add(Delivery d)
        {
            DRepository.Add(d);
        }

        public Delivery Find(int id)
        {
            return DRepository.FindDeliveryById(id);
        }

        public void Delete(Delivery d)
        {
            DRepository.Delete(d);
        }

        public List<Delivery> GetAll()
        {
           return DRepository.GetAll();
        }
        public void FindDeliveryByOrderId(int OrderId)
        {
            Order order = orderRepository.FindOrderById(OrderId);
          
            var ListDel = DRepository.GetAll().Find(item => (item.Id == OrderId));

        }

        public void UpdateDelivery(Delivery delivery)
        {
           DRepository.UpdateDelivery(delivery);
        }
    }
}
