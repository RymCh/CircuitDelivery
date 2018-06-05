using DeliveryCircuitE.Entities;
using DelivryCircuit.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace DeliveryCircuitPL.PL.Controllers
{
    public class ClientController : Controller
    {
        ClientB clientB = new ClientB();
        
        // GET: Client
        public ActionResult Index()
        {
            return View(clientB.GetAll());
        }

        // GET: Client/Details/5
       
        public ActionResult Details(int id)
        {
            Client client = clientB.FindClient(id);
            //j'ai changé dans la méthode FindClient de la business layer 
            
            if (client == null)
            {
                return HttpNotFound();
            }
            return View(client);
        }

        // GET: Client/Create
        public ActionResult Create()

        {
            return View();
        }

        // POST: Client/Create
        [HttpPost]
        public ActionResult Create(Client c)
        {
            if (ModelState.IsValid)
            {
                // TODO: Add insert logic here
                clientB.AddClient(c);

                return RedirectToAction("Index");
            }
                return View();     
        }

        // GET: Client/Edit/5
        public ActionResult Edit(int id)
        {
            Client client = clientB.FindClient(id);
            if (client == null)
            {
                return HttpNotFound();
            }
            return View(client);
        }
        

        // POST: Client/Edit/5
        [HttpPost]
        public ActionResult Edit(int id,Client client)
        {
            clientB.UpdateClient(client);

            return View(); 
        }

        // GET: Client/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Client/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Client client)
        {
            try
            {
                clientB.Delete(client);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
