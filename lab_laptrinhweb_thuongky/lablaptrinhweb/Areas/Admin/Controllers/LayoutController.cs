using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lablaptrinhweb.Areas.Admin.Controllers
{
    public class LayoutController : Controller
    {
        // GET: Admin/Layout
        public ActionResult Index()
        {
            return RedirectToAction("Topnav");
        }public ActionResult Topnav()
        {
            return View();
        }public ActionResult Boxed()
        {
            return View();
        }public ActionResult Colap()
        {
            return View();
        }public ActionResult Fixed()
        {
            return View();
        }public ActionResult Fixed_2()
        {
            return View();
        }public ActionResult Fixed_3()
        {
            return View();
        }
    }
}