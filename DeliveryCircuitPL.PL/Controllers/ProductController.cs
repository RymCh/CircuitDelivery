using DeliveryCircuitE.Entities;
using DelivryCircuit.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DeliveryCircuitPL.PL.Controllers
{
    public class ProductController : Controller
    {
        ProductB ProductB = new ProductB();

        // GET: Product
        public ActionResult Index()
        {
            return View(ProductB.GetAll());
        }

        // GET: Product/Details/5

        public ActionResult Details(int id)
        {
            Product Product = ProductB.Find(id);
            //j'ai changé dans la méthode FindProduct de la business layer 

            if (Product == null)
            {
                return HttpNotFound();
            }
            return View(Product);
        }

        // GET: Product/Create
        public ActionResult Create()

        {
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        public ActionResult Create(Product c)
        {
            if (ModelState.IsValid)
            {
                // TODO: Add insert logic here
                ProductB.Add(c);

                return RedirectToAction("Index");
            }
            return View();
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            Product Product = ProductB.Find(id);
            if (Product == null)
            {
                return HttpNotFound();
            }
            return View(Product);
        }


        // POST: Product/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Product Product)
        {
            ProductB.UpdateProduct(Product);

            return View();
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Product/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Product Product)
        {
            try
            {
                ProductB.Delete(Product);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
