using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePractise
{
    public class Rectangel1:Shape,IPrintCost
    {
        
      public double getCost()
        {
            return getArea() * 70;
        }
        public void display()
        {
            Console.WriteLine("Area is:{0}",getArea());
            Console.WriteLine("Cost is:{0}",getCost());
        }
    }
}
