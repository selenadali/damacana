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
            carts.Add(cart1);
            purchases.Add(purchase1);

            return View(products);
        }
        
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


        public static List<Product> cartproducts = new List<Product>() { };

        public static List<Cart> carts = new List<Cart>() { };

        public static List<Purchase> purchases = new List<Purchase>() { };

        Cart cart1 = new Cart()
        {
            Id = 0,
            UserId = 1,
            cartproducts = products,
        };

        Purchase purchase1 = new Purchase()
        {
            Id = 0,
            UserId = 1,
            TotalPrice = 0,
            purchaselist = products,
        };
        public ActionResult ProductList()
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

        public ActionResult AddToCart()
        {
            Cart cart= new Cart()
            {
               
            };
            return View(cart);
        }

        [HttpGet]
        public ActionResult SaveToCart(string Name)
        {
            Product product = new Product();
            foreach (var pr in products)
            {
                if (pr.Name == Name)
                {
                    product.Name = pr.Name;
                    product.Price = pr.Price;
                    product.Id = pr.Id;
                }
            }

            cartproducts.Add(product);
            return View(cartproducts);
        }
   
        public ActionResult MyCart()
        {

             return View(cartproducts);
        }
/*
       
        public ActionResult SaveToCart(string name)
        {
            Product product = new Product();

            foreach (var pr in products)
            {
                if (pr.Name == name)
                {
                    product.Name = pr.Name;
                    product.Price = pr.Price;
                    product.Id = pr.Id;
                }
            }
        return View(product);
        }
        */
        public ActionResult MyPurchase()
        {
            return View(purchases);

        }

        decimal Total;
        [HttpGet]
        public ActionResult Buy()
        {
            
            Purchase purchase = new Purchase();
            foreach (Product q in purchase.purchaselist)
            {
                Total += purchase.TotalPrice ;
            }

            return View(Total);
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