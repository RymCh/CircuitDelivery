using DelivryCircuit.BL;
using DeliveryCircuitE.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DeliveryCircuitPL.PL.Controllers
{
    public class OrderController : Controller
    {
        OrderB OrderB = new OrderB();

        // GET: Order
        public ActionResult Index()
        {
            return View(OrderB.GetAll());
        }

        // GET: Order/Details/5

        public ActionResult Details(int id)
        {
            Order Order = OrderB.Find(id);
            //j'ai changé dans la méthode FindOrder de la business layer 

            if (Order == null)
            {
                return HttpNotFound();
            }
            return View(Order);
        }

        // GET: Order/Create
        public ActionResult Create()

        {
            return View();
        }

        // POST: Order/Create
        [HttpPost]
        public ActionResult Create(Order c)
        {
            if (ModelState.IsValid)
            {
                // TODO: Add insert logic here
                OrderB.Add(c);

                return RedirectToAction("Index");
            }
            return View();
        }

        // GET: Order/Edit/5
        public ActionResult Edit(int id)
        {
            Order Order = OrderB.Find(id);
            if (Order == null)
            {
                return HttpNotFound();
            }
            return View(Order);
        }


        // POST: Order/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Order Order)
        {
            OrderB.UpdateOrder(Order);

            return View();
        }

        // GET: Order/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Order/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Order Order)
        {
            try
            {
                OrderB.Delete(Order);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
