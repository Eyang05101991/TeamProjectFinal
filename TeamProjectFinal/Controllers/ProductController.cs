using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TeamProjectFinal.Models;

namespace TeamProjectFinal.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View(ProductDB.GetAllProducts());
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View(); 
        }

        [HttpPost]
        public ActionResult Create(ProductViewModel prod)
        {
            if (ModelState.IsValid)
            {
                Product p = new Product()
                {
                    ProductName = prod.ProductName,
                    Category = prod.Category,
                    Description = prod.Description,
                    EmailAddress = prod.EmailAddress,
                    Owner = prod.Owner,
                    PhoneNumber = prod.PhoneNumber,
                    Price = prod.Price
                };
                ProductDB.AddProduct(p);
                return RedirectToAction("Index", "Product");    
                
            }
        }
    }
}