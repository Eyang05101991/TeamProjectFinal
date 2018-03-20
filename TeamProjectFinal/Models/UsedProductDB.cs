using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TeamProjectFinal.Models
{
    public class UsedProductDB
    {
        public static List<Product> GetAllUsedProducts()
        {
            TeamProjectFinalDB db = new TeamProjectFinalDB();
            List<Product> prods = db.Products.ToList();
            return prods;
        }

        public static void DeleteUsedProduct()
        {
            TeamProjectFinalDB db = new TeamProjectFinalDB();
            db.Database.ExecuteSqlCommand("DELE Product");
        }

        public static void UpdateUsedProduct(Product p)
        {
            TeamProjectFinalDB db = new TeamProjectFinalDB();

            //notifies context that product has been changed
            db.Entry(p).State = EntityState.Modified;

            //sends update query to database. 
            db.SaveChanges();
        }

        internal static void AddUsedProduct(Product p)
        {
            var db = new TeamProjectFinalDB();
            db.Products.Add(p);//
            db.SaveChanges();
        }

        /// <summary>
        /// returns a product with the given id
        /// if no product is found, null is returned. 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Product GetUsedProductById(int id)
        {
            TeamProjectFinalDB db = new TeamProjectFinalDB();
            Product prod = db.Products.Find(id);
            return prod;
        }

        internal static void DeleteUsedProduct(Product p)
        {
            var db = new TeamProjectFinalDB();
            db.Products.Remove(p);
            db.SaveChanges();
        }
    }
}