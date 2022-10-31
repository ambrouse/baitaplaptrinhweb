using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lablaptrinhweb.Models
{
    public class user
    {
        public string Taikhoan { get; set; }
        public string Matkhau { get; set; }
        public string Hoten { get; set; }
        public int Tuoi { get; set; }
        public bool Taikhoanmoi { get; set; }
        public bool Dakichhoat { get; set; }
        public bool Daxoa { get; set; }
    }
}