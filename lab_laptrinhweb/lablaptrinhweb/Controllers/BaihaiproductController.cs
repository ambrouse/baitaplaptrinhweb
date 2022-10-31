using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using lablaptrinhweb.Models;
namespace lablaptrinhweb.Controllers
{
    public class BaihaiproductController : Controller
    {
        // GET: Baihaiproduct
        public ActionResult Index()
        {
            ProductInfo pro1 = new ProductInfo
            {
                ProId = 1,
                ProName = "Sed ut perspiciati",
                ProImg = "Shay nắng_ (10).jpg",
                ProPrice = 70.00,
                CatId = 1,
                ProCategory = "Women"
            };
            ProductInfo pro2 = new ProductInfo
            {
                ProId = 2,
                ProName = "At vero eos",
                ProImg = "Shay nắng_ (3).jpg",
                ProPrice = 70.00,
                CatId = 1,
                ProCategory = "Women"
            };
            ProductInfo pro3 = new ProductInfo
            {
                ProId = 3,
                ProName = "On the other",
                ProImg = "Shay nắng_ (4).jpg",
                ProPrice = 70.00,
                CatId = 1,
                ProCategory = "Women"
            };
            ProductInfo pro4 = new ProductInfo
            {
                ProId = 4,
                ProName = "Sed ut perspiciati",
                ProImg = "Shay nắng_ (5).jpg",
                ProPrice = 70.00,
                CatId = 1,
                ProCategory = "Women"
            };
            ProductInfo pro5 = new ProductInfo
            {
                ProId = 5,
                ProName = "At vero eos",
                ProImg = "Shay nắng_ (6).jpg",
                ProPrice = 70.00,
                CatId = 1,
                ProCategory = "Women"
            };
            ProductInfo pro6 = new ProductInfo
            {
                ProId = 6,
                ProName = "On the other",
                ProImg = "Shay nắng_ (7).jpg",
                ProPrice = 70.00,
                CatId = 1,
                ProCategory = "Women"
            };
            ProductInfo pro7 = new ProductInfo
            {
                ProId = 7,
                ProName = "Sed ut perspiciati",
                ProImg = "Shay nắng_ (8).jpg",
                ProPrice = 70.00,
                CatId = 1,
                ProCategory = "Women"
            };
            ProductInfo pro8 = new ProductInfo
            {
                ProId = 8,
                ProName = "At vero eos",
                ProImg = "Shay nắng_ (9).jpg",
                ProPrice = 70.00,
                CatId = 1,
                ProCategory = "Women"
            };
            List<ProductInfo> products = new List<ProductInfo>();
            products.Add(pro1);
            products.Add(pro2);
            products.Add(pro3);
            products.Add(pro4);
            products.Add(pro5);
            products.Add(pro6);
            products.Add(pro7);
            products.Add(pro8);

            return View(products);
        }

        public ActionResult Detail()
        {
            var product = new ProductInfo
            {
                ProId = 1,
                ProName = "Sed ut perspiciati",
                ProImg = "Shay nắng_ (10).jpg",
                ProPrice = 70.00,
                CatId = 1,
                ProCategory = "Women"
            };
            return View(product);
        }
    }
}