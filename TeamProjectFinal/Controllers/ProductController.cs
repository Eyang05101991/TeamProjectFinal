using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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

        public ActionResult SeeProducts()
        {
            return View(ProductDB.GetAllProducts());
        }

        [HttpGet]
        public ActionResult Edit(int? id)
        {
            //if the id is null throw an exception
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Product p = ProductDB.GetProductById(id.Value);

            if(p == null)
            {
                return HttpNotFound(); //404 error
            }
            //valid id was used and product was found!
            return View(p);
        }

        [HttpPost]
        public ActionResult Edit(Product p)
        {
            if (ModelState.IsValid)
            {
                ProductDB.UpdateProduct(p);
                return RedirectToAction("SeeProducts"); 

            }
            //return view with 
            return View(p); 
        }

        [HttpGet]
        public ActionResult Delete(int? id)
        {
            if(id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest); 
            }
            Product p = ProductDB.GetProductById(id.Value); 
            if(p == null)
            {
                return HttpNotFound();
            }
            return View(p); 
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            Product p = ProductDB.GetProductById(id); 
            if(p == null)
            {
                return RedirectToAction("Index", "Product"); 
            }
            ProductDB.DeleteProduct(p); 
            return RedirectToAction("Index", "Product"); 
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