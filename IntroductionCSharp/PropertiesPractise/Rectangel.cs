using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesPractise
{
    public class Rectangel : Shape
    {
        public double length;
        public double height;

        public Rectangel(double length, double height, string id) : base(id)
        {
            this.length = length;
            this.height = height;
        }
        public override double Area{
            get
            {
                return length * height;
            }
            }
    }
}
