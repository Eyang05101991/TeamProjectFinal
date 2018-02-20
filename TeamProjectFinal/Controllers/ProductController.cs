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
        [HttpGet]
        public ActionResult Index()
        {
            return View(); 
        }

        public ActionResult Index(ProductViewModel prod)
        {
            if (ModelState.IsValid)
            {
                Product p = new Product()
                {
                    ProductName = prod.ProductName,
                    PhoneNumber = prod.PhoneNumber,
                    Price = prod.Price,
                    Owner = prod.Owner,
                    Category = prod.Category,
                    Description = prod.Description,
                    EmailAddress = prod.EmailAddress
                };
                ProductDB.AddProduct(p);
                return RedirectToAction("Index", "Home");
            }
            return View(prod);

        }

        
        //public ActionResult Create(Product prod)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        Product p = new Product()
        //        {
        //            ProductName = prod.ProductName,
        //            Category = prod.Category,
        //            Description = prod.Description,
        //            EmailAddress = prod.EmailAddress,
        //            Owner = prod.Owner,
        //            PhoneNumber = prod.PhoneNumber,
        //            Price = prod.Price
        //        };
        //        ProductDB.AddProduct(p);
        //        return RedirectToAction("Index", "Product");    
                
        //    }
        //}
    }
}