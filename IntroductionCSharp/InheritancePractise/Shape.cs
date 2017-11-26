using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePractise
{
    public class Shape
    {
        private double length;
        private double width;

        public double Length { get => length; set => length = value; }
        public double Width { get => width; set => width = value; }
        public double getArea()
        {
            return Length * Width;
        }
    }
}
