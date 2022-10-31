using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static lablaptrinhweb.Models.sinhvien;

namespace lablaptrinhweb.Models
{
    
    public class hocsinh
    {
        public string Ms { get; set; }
        public string Hoten { get; set; }
        public int Tuoi { get; set; }
        public sex Gioitinh { get; set; }
        public string Diachi { get; set; }
        public string Ngaysinh { get; set; }
        public string Taikhoan { get; set; }
        public int Matkhau { get; set; }
        public enum sex { 
        nan,nu,be_de
        }
    }
}