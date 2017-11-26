using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticAndInstanceMembersPractise
{
    class Program
    {
        static void Main(string[] args)
        {

            Circle c = new Circle(6.7);
            Console.WriteLine(c.getArea());
            Circle c1 = new Circle(8);
            Console.WriteLine(c1.getArea());
            Console.WriteLine(Circle.PI);
            c.count();
            c.count();
            c1.count();
            c1.count();
            Console.WriteLine(c.getNum());
            Console.WriteLine(c1.getNum());

        }
    }
}
