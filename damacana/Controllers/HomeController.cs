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
        public static List<Product> products = new List<Product>(){
            new Product()
            {
                Id = 1,
                Name = "Erikli",
                Price = (decimal)9.50,
            },
            new Product()
            {
                Id = 2,
                Name = "Hayat",
                Price = (decimal)7.90,
            }
        };

       
        public ActionResult Index()
        {
            return View(products);
        }

       
        public ActionResult AddProduct(){
            Product product = new Product()
            {
                Name = "",
                Price = (decimal)0
            };
            return View(product);
        }

 
        [HttpPost]
        public ActionResult SaveProduct(Product product)
        {
            products.Add(product);
            return View(product);
        }

        public static List<Product> cartproducts = new List<Product>(){
        };
        
 

        public ActionResult AddToCart()
        {
            Cart cart= new Cart()
            {
               
            };
            return View(cart);
        }

       [HttpGet]
        public ActionResult SaveToCart(Product product)
        {
            cartproducts.Add(product);
            return View(products);
        }
   

        public ActionResult MyCart()
        {
             return View(cartproducts);
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