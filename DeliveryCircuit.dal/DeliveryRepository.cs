using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeliveryCircuitE.Entities;

namespace DeliveryCircuit.dal
{
  public  class DeliveryRepository
    {
        
        private DeliveryCircuitContext context;
        public DeliveryRepository()
        {
            context = new DeliveryCircuitContext();
        }
            public void Add(Delivery D)
            {
                context.Deliveries.Add(D);
                context.SaveChanges();
            }

            //public Delivery Find(int Id)
            //{
            //    foreach (Delivery d in context.Deliveries)
            //    {
            //        if (d.Id == Id)
            //            return d;

            //    }
            //    return null;
            //}

            public void Delete(Delivery d)
            {
                context.Deliveries.Remove(d);
            }

            public List<Delivery> GetAll()
            {
            var list = new List<Delivery>();
            list = context.Deliveries.ToList();
            return list;
            }

        public Delivery GetDeliveryById(int id)
        {
            foreach (Delivery c in context.Deliveries.ToList())
            {
                if (c.Id == id)
                {
                    return c;
                }
            }
            return null;
        }


        public void UpdateDelivery(Delivery Delivery)
        {
            Delivery s = GetDeliveryById(Delivery.Id);
            if (s != null)
            {
                context.Deliveries.Remove(s);
            }
            context.Deliveries.Add(Delivery);
            context.SaveChanges();
        }
        public Delivery FindDeliveryById(int Id)
        {
            foreach (Delivery c in context.Deliveries)
            {
                if (c.Id == Id) return c;

            }
            return null;
        }
    }
    }

