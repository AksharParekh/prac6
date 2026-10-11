using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using prac6_dnt.Models;

namespace prac6_dnt.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            List<Product> P = new List<Product>();
            P = GetProducts();
            return View(P);
        }

        public ActionResult Details(int id)
        {
            List<Product> PALL = GetProducts();
            Product P1 = PALL.FirstOrDefault(p => p.ProductId == id);
            return View(P1);
        }

        private List<Product> GetProducts()
        {
            return new List<Product>
            {
                new Product
                {
                    ProductId = 1,
                    ProductName = "Keyboard",
                    Description = "Mechanical Gaming Keyboard",
                    Price = 5000,
                    Category = "Peripherals"
                },

                new Product
                {
                    ProductId = 2,
                    ProductName = "Mouse",
                    Description = "Wireless Mouse",
                    Price = 2500,
                    Category = "Peripherals"
                },

                new Product
                {
                    ProductId = 3,
                    ProductName = "Monitor",
                    Description = "27 inch 4K Display",
                    Price = 25000,
                    Category = "Electronics"
                },

                new Product
                {
                    ProductId = 4,
                    ProductName = "Webcam",
                    Description = "Full HD Webcam",
                    Price = 3500,
                    Category = "Accessories"
                },

                new Product
                {
                    ProductId = 5,
                    ProductName = "USB Hub",
                    Description = "7-port USB 3.0 Hub",
                    Price = 1800,
                    Category = "Accessories"
                }


            };
        }
    }
}