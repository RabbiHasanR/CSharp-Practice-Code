using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePractise
{
    class FullTimeEmployee : Employee 
    {
        public double yearlyRate;
        public FullTimeEmployee() //: base("Rabbi","Hasan","jas@")
        {
            Console.WriteLine("Child Class 1");
        }
    }
}
