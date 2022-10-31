using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lablaptrinhweb.Controllers
{
    public class BaimotController : Controller
    {
        // GET: Baimot
        public ActionResult Index()
        {
            ViewBag.sayhello = "well com to website";
            return View();
        }
    }
}