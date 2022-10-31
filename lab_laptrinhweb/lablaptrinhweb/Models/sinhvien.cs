using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lablaptrinhweb.Models
{
   
    public class sinhvien
    {
        public string Ms { get; set; }
        public string Hoten { get; set; }
        public Boolean Gioitinh { get; set; }
        public int Tuoi { get; set; }
        public string Diachi { get; set; }
        public quequan Quequan { get; set; }

        public enum quequan {
            ha_noi,
            ho_chi_minh,
            long_an
        }
    }
}