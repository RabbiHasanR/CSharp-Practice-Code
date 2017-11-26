using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassPractise
{
    public abstract class BaseClass:IDisplay
    {
        public abstract void display();
        abstract public int area();
    }
    public class DerrivedClass:BaseClass
    {
        private int side;
        public DerrivedClass(int side)
        {
            this.side = side;
        }
        public override int area()
        {
            return side * side;
        }
        public override void display()
        {
            Console.WriteLine("Area:{0}", area());
        }
    }
    public interface IDisplay
    {
        void display();
    }

}
