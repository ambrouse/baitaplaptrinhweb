using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lablaptrinhweb.Models
{
    public class ProductInfo
    {
        public int ProId { get; set; }
        public String ProName { get; set; }
        public String ProImg { get; set; }
        public double ProPrice { get; set; }
        public int CatId { get; set; }
        public String ProCategory { get; set; }
    }
}