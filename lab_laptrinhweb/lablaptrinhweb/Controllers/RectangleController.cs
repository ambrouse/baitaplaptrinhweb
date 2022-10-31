using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using lablaptrinhweb.Models;

namespace lablaptrinhweb.Controllers
{
    public class RectangleController : Controller
    {
        [HttpGet]
        // GET: Rectangle
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        
        public ActionResult Index(Rectangle x)
        {
            ViewBag.MessForAcreage = " Acreage of the Rectangle (with:" + x.width + " - height:" + x.height + " is " + x.acreage();
            ViewBag.MessForPerimeter = "perimeter of the Rectangle is " + x.perimeter();
            return View();
        }
    }
}