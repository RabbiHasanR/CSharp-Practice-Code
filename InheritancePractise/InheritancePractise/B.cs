using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePractise
{
    class B : A 
    {
        //public override void show()
        //{
        //    Console.WriteLine("I am base class method");
        //}
        int x;
        int y;
        public B(int x,int y)
        {
            this.x = x;
            this.y = y;
        }
        public override int area()
        {
            return x * y;
        }
    }
}
