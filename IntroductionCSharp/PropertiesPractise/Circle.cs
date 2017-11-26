using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesPractise
{
    public class Circle:Shape
    {
        public double radius;
        public Circle(double radius,string id) : base(id)
        {
            this.radius = radius;
        }
        public override double Area
        {
            get
            {
                return radius * radius * System.Math.PI;
            }
        }
    }
}
