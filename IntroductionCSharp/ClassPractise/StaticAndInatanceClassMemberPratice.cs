using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPractise
{
    class StaticAndInatanceClassMemberPratice
    {
        static double PI;
        public double radius;

        static StaticAndInatanceClassMemberPratice()
        {
            StaticAndInatanceClassMemberPratice.PI = 3.14;
        }
        public StaticAndInatanceClassMemberPratice(double radius)
        {
            this.radius = radius;
        }
        public double calculateArea()
        {
            return StaticAndInatanceClassMemberPratice.PI * radius * radius;
        }
    }
}
