using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lablaptrinhweb.Models
{
    public class Triangle
    {
        public float firstEdge { get; set; }
        public float secondEdge { get; set; }
        public float thirdEdge { get; set; }
        public Triangle()
        {
            this.firstEdge = 0;
            this.secondEdge = 0;
            this.thirdEdge = 0;
        }
        public bool isTriangle()
        {
            return (this.firstEdge + this.secondEdge > this.thirdEdge) &&
                  (this.firstEdge + this.thirdEdge > this.secondEdge) &&
                  (this.secondEdge + this.thirdEdge > this.firstEdge);
        }
        public float perimeter()
        {
            return (this.firstEdge + this.secondEdge + this.thirdEdge);
        }
        public float acreage()
        {
            float p = this.perimeter();
            return (float)Math.Sqrt(p * (p - firstEdge) * (p - this.secondEdge) * (p - this.thirdEdge));
        }
    }
}