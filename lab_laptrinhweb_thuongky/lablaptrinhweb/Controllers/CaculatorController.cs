using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using lablaptrinhweb.Models;

namespace lablaptrinhweb.Controllers
{
    public class CaculatorController : Controller
    {
        // GET: Caculator
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Char dau,int soa,int sob)
        {
            if (dau == '+') {
                ViewBag.kq = soa + sob;
            }if (dau == '-') {
                ViewBag.kq = soa - sob;
            }
            if (dau == '*') {
                ViewBag.kq = soa * sob;
            }
            if (dau == '/') {
                ViewBag.kq = soa / sob;
            }
            ViewBag.soa = soa;
            ViewBag.sob = sob;
            return View();
        }
    }
}