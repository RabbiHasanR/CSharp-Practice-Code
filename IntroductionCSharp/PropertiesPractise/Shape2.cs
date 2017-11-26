using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesPractise
{
    public abstract class Shape2
    {
        public abstract double Area
        {
            get;
            set;
        }
    }
    public class Square1 : Shape2
    {
        public double side;
        //constructor
        public Square1(double side)
        {
            this.side = side;
        }
        //overrid abstract property
        public override double Area
        {
            get { return side * side; }
            set { this.side = System.Math.Sqrt(value); }
        }
    }
    public class Cube : Shape2
    {
        public double side;
        public Cube(double side)
        {
            this.side = side;
        }
        public override double Area
        {
            get { return side * side * side; }
            set { this.side = System.Math.Sqrt(value/6); }
        }
    }
}
