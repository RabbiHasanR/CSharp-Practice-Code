using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticAndInstanceMembersPractise
{
    class Circle
    {
        public static double PI;
        public static int num;
        double radius;
        static Circle()
        {
            Console.WriteLine("Static constructor");
           PI = 3.14;
        }
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public double getArea()
        {
            return PI * this.radius * this.radius;
        }
        public void count()
        {
            num++;
        }
        public int getNum()
        {
            return num;
        }
    }
}
