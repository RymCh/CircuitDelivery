using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeliveryCircuit.dal;
using DeliveryCircuitE.Entities;

namespace DelivryCircuit.BL
{
    public class ClientB

    {
        
        ClientRepository clientRepository = new ClientRepository();
        
        public void AddClient(Client c )
        {
            clientRepository.AddClient(c); 
        }
        public Client FindClient (int Id)
        {
            
          return clientRepository.FindClientById(Id);

        }
        public void Delete(Client c)
        {
            clientRepository.Delete(c);
        }

        public List<Client> GetAll()
        {
            List<Client> list = new List<Client>();
            list = clientRepository.GetAll();
            
                return list;
         
        }
        

        public void UpdateClient(Client client)
        {
          clientRepository.UpdateClient(client);
        }

        public void Dispose()
        {
            clientRepository.Dispose();
        }

    }
}
