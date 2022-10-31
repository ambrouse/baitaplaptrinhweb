using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lablaptrinhweb.Models
{
    public class circle
    {
        public double Radius { get; set; }
        public circle()
            {
               this.Radius = 0;
            }
        public double acreage()
        {
            return this.Radius * this.Radius * Math.PI;
        }
        public double perimeter()
        {
            return 2 * this.Radius * Math.PI;
        }

    }
}