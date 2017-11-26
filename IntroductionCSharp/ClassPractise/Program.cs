using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPractise
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c = new Customer();
            c.printFullName();
            Customer c1 = new Customer("Rabbi","Hasan");
            c1.printFullName();
            StaticAndInatanceClassMemberPratice saicm = new StaticAndInatanceClassMemberPratice(6.6);
            double a = saicm.calculateArea();
            Console.WriteLine("Area is:{0}", a);
        }
    }
}
