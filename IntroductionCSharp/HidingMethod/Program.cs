using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HidingMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            FullTimeEmployee fte = new FullTimeEmployee();
            fte.FirstName = "Rabbi";
            fte.LastName = "Hasan";
            fte.printName();
            ((Employee)fte).printName();//hidden method call using type casting
            //another way we refference base class we call hidden method
            Employee e = new FullTimeEmployee();
            e.FirstName = "Rabbi";
            e.LastName = "Hasan";
            e.printName();
        }
    }
}
