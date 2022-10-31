using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lablaptrinhweb.Controllers
{
    public class ReadWriteController : Controller
    {
        // GET: ReadWrite
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Save(string Id, string Name, double Marks)
        {
            string path = Server.MapPath("/StudentInfo.txt");
            string[] lines = { Id, Name, Marks.ToString() };
            System.IO.File.WriteAllLines(path, lines);
            ViewData["Message"] = "Da ghi vao file!";
            return View("Index");
        }
        public ActionResult Open()
        {
            string path = Server.MapPath("/StudentInfo.txt");
            string[] lines = System.IO.File.ReadAllLines(path);
            ViewBag.Id = lines[0];
            ViewBag.Name = lines[1];
            ViewBag.Marks = Convert.ToDouble(lines[2]);
            ViewData["Message"] = "Da doc tu file!";
            return View("Index");
        }
    }
}