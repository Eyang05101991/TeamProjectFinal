using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TeamProjectFinal.Models
{
    public static class ProductDB
    {
        public static List<Product> GetAllProducts()
        {
            TeamProjectFinalDB db = new TeamProjectFinalDB();
            List<Product> prods = db.Products.ToList();
            return prods;
        }

        public static void AddProduct()
        {
            throw new NotImplementedException();
        }

        public static void DeleteProduct()
        {
            throw new NotImplementedException();
        }

        public static void UpdateProduct()
        {
            throw new NotImplementedException();
        }
    }
}