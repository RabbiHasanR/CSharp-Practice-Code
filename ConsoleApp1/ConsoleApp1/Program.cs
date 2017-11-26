using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c = new Customer();
            c.printName();
            Customer c1= new Customer("Rabbi","Hasan");
            c1.printName();
        }
    }
}
