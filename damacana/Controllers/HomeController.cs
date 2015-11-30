using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using damacana.Models;


namespace damacana.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Product product1 = new Product()
            {
                Id = 1,
                Name = "Erikli",
                Price = (decimal)9.50,
            };
            Product product2 = new Product()
            {
                Id = 2,
                Name = "Hayat",
                Price = (decimal)7.90,
            };

            List<Product> products = new List<Product>();
            products.Add(product1);
            products.Add(product2);
            return View(products);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}