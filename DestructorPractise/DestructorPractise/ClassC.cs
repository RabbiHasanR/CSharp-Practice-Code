using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DestructorPractise
{
    class ClassC:ClassB
    {
        public ClassC()
        {
            Console.WriteLine("Create instance of ClassC");
        }
        public void show()
        {
           for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }
       /* ~ClassC()
        {
            Console.WriteLine("destroy instacne of ClassC");
        }*/
    }
}
