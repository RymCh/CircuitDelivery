using DeliveryCircuitE.Entities;
using DelivryCircuit.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DeliveryCircuitPL.PL.Controllers
{
    public class DeliveryController : Controller
    {
        DeliveryB deliveryB = new DeliveryB();
        public ActionResult Index()
        {
            return View(deliveryB.GetAll());
        }

        // GET: Delivery/Details/5

        public ActionResult Details(int id)
        {
            Delivery Delivery = deliveryB.Find(id);

            if (Delivery == null)
            {
                return HttpNotFound();
            }
            return View(Delivery);
        }

        // GET: Delivery/Create
        public ActionResult Create()

        {
            return View();
        }

        // POST: Delivery/Create
        [HttpPost]
        public ActionResult Create(Delivery c)
        {
            if (ModelState.IsValid)
            {
                // TODO: Add insert logic here
                deliveryB.Add(c);

                return RedirectToAction("Index");
            }
            return View();
        }

        // GET: Delivery/Edit/5
        public ActionResult Edit(int id)
        {
            Delivery delivery = deliveryB.Find(id);
            if (delivery == null)
            {
                return HttpNotFound();
            }
            return View(delivery);
        }


        // POST: Delivery/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Delivery delivery)
        {
            deliveryB.UpdateDelivery(delivery);

            return View();
        }

        // GET: Delivery/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Delivery/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Delivery delivery)
        {
            try
            {
                deliveryB.Delete(delivery);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}



