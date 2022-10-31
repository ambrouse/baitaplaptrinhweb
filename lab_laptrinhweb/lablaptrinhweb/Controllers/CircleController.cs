using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using lablaptrinhweb.Models;


namespace bai3.Controllers
{
    public class CircleController : Controller
    {
        [HttpGet]
        // GET: Circla
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(circle x) 
        {
            if (x.Radius > 0)
                ViewBag.Message = " Acreage of the circle wit Radius: " + x.Radius + "is" + x.acreage() + "\n Perimeter of the Circle is" + x.perimeter();
            return View();
        }
    }
}