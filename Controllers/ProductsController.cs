using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab1.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            return View();
        }

        //GET: Products/Details?Products=[value]

        public ActionResult Details(string apple)
        {

            // check for an empty products
            if (apple == null)
            {

                //return View("Error");
                return RedirectToAction("Index");

            }
            ViewBag.apple = apple;
            return View();

        }


    }
}