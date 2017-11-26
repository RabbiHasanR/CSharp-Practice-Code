using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassPractise
{
    public abstract class Customer
    {
        public abstract void print();
    }

    class Program:Customer
    {
        public override void print()
        {
            Console.WriteLine("Abstract class and method");
        }
        static void Main(string[] args)
        {
            //smple abstract class example
            Program c = new Program();
            c.print();
            //abstract class implement interface method and it's call derrived class
            DerrivedClass dc = new DerrivedClass(2);
            dc.display();

            //abstract class with interface implementation,abastract method and abstract properties
            Rectangel r = new Rectangel();
            r.incrementLengthAndHeightValue();
            r.show();
            r.display();
            //can not creat instance on abstract class..you get error
            //Shape s = new Shape();
            //but you can creat object refference for derrived class
            Shape s = new Rectangel();

        }
    }
    //In this way, an abstract class can force derived classes to provide new method implementations for virtual methods.
    public class A
    {
        public virtual void doWork()
        {

        }
    }
    public abstract class B : A
    {
        public abstract override void doWork();
    }
    public class C : B
    {
        public override void doWork()
        {
            
        }
    } 


}
