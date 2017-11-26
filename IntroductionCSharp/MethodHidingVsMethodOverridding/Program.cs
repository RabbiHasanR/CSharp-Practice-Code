using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodHidingVsMethodOverridding
{
    //simple one 
    public class BaseClass3
    {
        public void method1()
        {
            Console.WriteLine("Base-Method1");
        }
    }
    public class DerrivedClass3:BaseClass3
    {
        public void method2()
        {
            Console.WriteLine("Derrived-Method1");
        }
    }
    //Method Hiding with Warning
    public class BaseClass4
    {
        public void method1()
        {
            Console.WriteLine("Base-Method1");
        }
        public void method2()
        {
            Console.WriteLine("Base-Method2");
        }
    }
    public class Derrived4:BaseClass4
    {
        public void method2()
        {
            Console.WriteLine("Derrived-Method2");
        }
    }
    // Overriding, Hiding and Shadowing
    public class BaseClass5
    {
        public virtual void Method1()
        {
            Console.WriteLine("Base-Method1");
        }
        public virtual void Method2()
        {
            Console.WriteLine("Base-Method2");
        }
    }
    public class Derrived5Class:BaseClass5
    {
        public override void Method1()
        {
            Console.WriteLine("Derrived-Method1");
        }
        public new void Method2()
        {
            Console.WriteLine("Derrived-Method2");
        }
    }
    // Method Overriding and Method Hiding: 
    public class BaseClass6
    {
        public virtual void Method1()
        {
            Console.WriteLine("Base-Method1");
        }
    }
    public class DerrivedClass6 : BaseClass6
    {
        public new virtual void Method1()
        {
            Console.WriteLine("Derrived1-Method1");
        }
    }
    public class DerrivedClass7 : DerrivedClass6
    {
        public override void Method1()
        {
            Console.WriteLine("Derrived2-Method1");
        }
    }

    //Method Hidding 
    public class BaseClass
    {
        public int i;
        public virtual void print()
        {
            Console.WriteLine("Base class:{0}",i);
        }
    }
    public class DerrivedClass:BaseClass
    {
        public int j;
        public new void print()
        {
            Console.WriteLine("Derrived class:{0}", j);
        }
    }
    //Method overridding
    public class BaseClass2
    {
        public virtual void print()
        {
            Console.WriteLine("Base Class");
        }
    }
    public class DerrivedClass2:BaseClass2
    {
        public override void print()
        {
            Console.WriteLine("Derrived Class");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            //method hiding example
            /*DerrivedClass d = new DerrivedClass();
            //d.j = 1;
            //d.i = 8;
            d.print();*/

            //method overriding example
            // BaseClass2 de = new DerrivedClass2();
            //de.print();

            /* //simple one
             BaseClass3 b3 = new BaseClass3();
             b3.method1();//Base-Method1
             DerrivedClass3 d3 = new DerrivedClass3();
             d3.method2();//Derrived-Method1
             BaseClass3 b4 = new DerrivedClass3();
             b4.method1();//Base-Method1*/

            //Method Hiding with Warning
            /*BaseClass4 b4 = new BaseClass4();
            b4.method1();//Base-Method1
            b4.method2();//Base-Method2
            Derrived4 d4 = new Derrived4();
            d4.method1();//Base-Method1
            d4.method2();//Derrived-Method2
            BaseClass4 b5 = new Derrived4();
            b5.method1();//Base-Method1
            b5.method2();//Base-Method2*/

            // Overriding, Hiding and Shadowing
            /*BaseClass5 b5 = new BaseClass5();
            b5.Method1();//Base-Method1
            b5.Method2();//Base-Method2
            Derrived5Class d5 = new Derrived5Class();
            d5.Method1();//Derived-Method1
            d5.Method2();//Derrived-Method2
            BaseClass5 b6 = new Derrived5Class();
            b6.Method1();//Derrived-Method1
            b6.Method2();//Base-Method2*/

            // Method Overriding and Method Hiding: 
            BaseClass6 b6 = new BaseClass6();
            b6.Method1();//Base-Method1
            DerrivedClass6 d6 = new DerrivedClass6();
            d6.Method1();//Derrived1-Method1
            DerrivedClass7 d7 = new DerrivedClass7();
            d7.Method1();//Derrived2-Method1
            BaseClass6 b7 = new DerrivedClass6();
            b7.Method1();//Base-Method1
            DerrivedClass6 b8 = new DerrivedClass7();
            b8.Method1();//Derrived2-Method1
        }
    }
}
