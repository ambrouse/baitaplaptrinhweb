using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lablaptrinhweb.Models
{
    public class Rectangle
    {
        public int width { get; set; }
        public int height { get; set; }
        public int acreage()
        {
            return this.width * this.height;
        }
        public double perimeter()
        {
            return 2 * (this.width + this.height);
        }
    }
}