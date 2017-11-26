using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DestructorPractise
{
    class ClassB:ClassA
    {
        public ClassB()
        {
            Console.WriteLine("Create instance of ClassB");
        }
       /* ~ClassB()
        {
            Console.WriteLine("destroy instacne of ClassB");
        }*/
    }
}
