using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DestructorPractise
{
    class ClassA
    {
        public ClassA()
        {
            Console.WriteLine("Create instance of ClassA");
        }
        /*~ClassA()
        {
            Console.WriteLine("destroy instacne of ClassA");
        }*/

    }
}
