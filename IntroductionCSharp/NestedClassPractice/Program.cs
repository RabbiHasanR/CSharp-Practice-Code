using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedClassPractice
{
    public class Container
    {
        public int a=0;
        public class Nested
        {
            public Nested()
            {

            }
            public void display(Container parent)
            {
                Console.WriteLine(parent.a);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Container c = new Container();
            Container.Nested n = new Container.Nested();
            n.display(c);

        }
    }
}
