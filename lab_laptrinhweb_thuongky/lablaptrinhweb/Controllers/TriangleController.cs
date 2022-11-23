using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using lablaptrinhweb.Models;

namespace lablaptrinhweb.Controllers
{
    public class TriangleController : Controller
    {
        [HttpGet]
        // GET: Triangle
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(Triangle x) 
        {
            ViewBag.MessForAcreage = "Acreage of Triangle [a:" + x.firstEdge + "-b:" + x.secondEdge + " - c:" + x.thirdEdge + " is " + x.acreage();
            ViewBag.MessForPerimeter = "Perimeter of the Triangle is " + x.perimeter();
            return View(x);
        }
    }
}