using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using lablaptrinhweb.Models;

namespace lablaptrinhweb.Controllers
{
    public class BaibonController : Controller
    {
        // GET: Baibon
        public ActionResult Index()
        {
            dbEntities db = new dbEntities();
            return View(db.sanPhams.ToList());
        }public ActionResult Login()
        {
            
            return View();
        }
        [HttpPost]
        public ActionResult Login(String email)
        {
            dbEntities db = new dbEntities();
            if (db.khachHangs.Where(c=>c.email==email).Count()>0)
            {
                Session["khachhang"] = (khachHang)db.khachHangs.FirstOrDefault(c=>c.email==email);
                return RedirectToAction("cart");
            }
            ViewBag.err = "email not registered yet";
                return View();
        }public ActionResult Shop()
        {
            dbEntities db = new dbEntities();
            return View(db.sanPhams.ToList());
        }public ActionResult cart()
        {
            dbEntities db = new dbEntities();
            khachHang kh = (khachHang)Session["khachhang"];
            if (Session["khachhang"] != null)
            {
                var dh = db.donHangs.Where(c => c.maKH == kh.maKH);
                var ctdh = new List<ctDonHang>();
                foreach(var i in dh) {
                    var model = db.ctDonHangs.FirstOrDefault(c=>c.soDH==i.soDH);
                    ctdh.Add(model);
                }
                return View(ctdh);
            }
            return View();
        }public ActionResult checkout()
        {
            return View();
        }public ActionResult productdetails(String id)
        {
            dbEntities db = new dbEntities();
            return View(db.sanPhams.Find(id));
        }public ActionResult blocgsingle()
        {
            return View();
        }public ActionResult blocg()
        {
            return View();
        }public ActionResult contact()
        {
            return View();
        }
    }
}