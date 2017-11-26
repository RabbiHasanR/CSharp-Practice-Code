using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HidingMethod
{
    class FullTimeEmployee:Employee
    {
        public new void printName()
        {
            Console.WriteLine(FirstName + " " + LastName+" FullTimeEmployee");
        }
    }
}
