using System;
using System.Collections.Generic;
using System.Linq;
using DeliveryCircuitE.Entities;


namespace DeliveryCircuit.dal
{
    public class ClientRepository
    {
        private DeliveryCircuitContext context;
        public ClientRepository()
        {
            context = new DeliveryCircuitContext();
        }

        public void AddClient(Client c)
        {
           
           context.Clients.Add(c);
            context.SaveChanges();
        }

        public Client FindClientById (int Id)
        {
            foreach (Client c in context.Clients)
            {
                if (c.Id == Id) return c;

            }
            return null;
        }
        public Client GetClientById(int id)
        {
            foreach (Client c in context.Clients.ToList())
            {
                if (c.Id== id)
                {
                    return c;
                }
            }
            return null;
        }


        public void UpdateClient(Client client)
        {
            Client s = GetClientById(client.Id);
            if (s != null)
            {
                context.Clients.Remove(s);
            }
            context.Clients.Add(client);
            context.SaveChanges();
        }

        public void Delete(Client client)
        {
            context.Clients.Remove(client);
        }

        public List<Client> GetAll()
        {
            //List<Client> list = new List<Client>(); 
            //using (var context = new DeliveryCircuitContext())
            //    foreach(var client in context.Clients)
            //    {
            //        list.Add(client);
            //    }

            //return list;
            return context.Clients.ToList(); 
        }
        public void Dispose()
        {
            context.Dispose();
        }
    }
}

