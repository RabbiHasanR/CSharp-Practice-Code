using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesPractise
{
    public class Square:Shape
    {
        public double length;

        public Square(double length,string id) : base(id)
        {
            this.length = length;
        }
        public override double Area
        {
            get
            {
                return length * length;

            }
        }
    }
}
