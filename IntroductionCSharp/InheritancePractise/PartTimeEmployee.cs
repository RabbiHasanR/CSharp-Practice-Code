using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePractise
{
    class PartTimeEmployee : Employee
    {
        public double hourlyRate;
        public PartTimeEmployee() //: base("Tuhin","hasan","tuhin@")
        {
            Console.WriteLine("Child class 2");
        }
    }
}
