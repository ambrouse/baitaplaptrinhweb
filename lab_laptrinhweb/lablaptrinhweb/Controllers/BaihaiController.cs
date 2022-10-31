using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using lablaptrinhweb.Models;
using static lablaptrinhweb.Models.sinhvien;
namespace lablaptrinhweb.Controllers
{
    public class BaihaiController : Controller
    {
        // GET: Baihia
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Sinhvien(){   
            sinhvien sv = new sinhvien()
        {
            Ms = "012345",
            Hoten = "nguyen thi duy ngu",
            Gioitinh = true,
            Tuoi = 19,
            Diachi = "long an",
            Quequan = quequan.long_an,
            };

            return View(sv);
        }
        [HttpPost]
        public ActionResult Sinhvien(sinhvien model)
        {
        return View(model);
        }
            public ActionResult Hocsinh()
        {
            hocsinh sv = new hocsinh()
            {
                Ms = "012345",
                Hoten = "nguyen thi duy ngu",
                Gioitinh = hocsinh.sex.be_de,
                Tuoi = 19,
                Diachi = "long an",
               Ngaysinh="???",
               Taikhoan="duyngu@gmail.com",
               Matkhau=123456,
            };

            return View(sv);
        }
        [HttpPost]
        public ActionResult Hocsinh(hocsinh model)
        {
            return View(model);
        }
        /*
   Tên tài khoản
- Mật khẩu
- Họ tên chủ tk
- Tuổi
- Tài khoản mới
- Đã kích hoạt
- Đã xóa
   */
        public ActionResult user_() {
            user sv = new user() {
                Taikhoan = "duyngu@gmail.com",
                Matkhau = "duy123456",
                Hoten = "nguyen thi duy ngu",
                Tuoi=19,
                Taikhoanmoi=true,
                Dakichhoat=true,
                Daxoa=false
            };
            return View(sv);

        }
        [HttpPost]
        public ActionResult user_(user model)
        {
            return View(model);
        }

    }
}