using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePractise
{
    public interface ICustomer1
    {
        void print1();
    }
    public interface ICustomer2:ICustomer1
    {
        void print2();
    }
    public class Customer:ICustomer2
    {
        public void print1()
        {
            Console.WriteLine("Print1");
        }
        public void print2()
        {
            Console.WriteLine("Print2");
        }
    }
    //explicit interface example
    interface II1
    {
        void show();
    }
    interface II2
    {
        void show();
    }
    class Program:II1,II2
    {
        //void II1.show()
        public void show()
        {
            Console.WriteLine("first interface");
        }
        void II2.show()
        //public void show()
        {
            Console.WriteLine("second interface");
        }
        static void Main(string[] args)
        {
            //Interface Practise
            /*Customer c = new Customer();
            c.print1();
            c.print2();
            ICustomer1 cus = new Customer();
            cus.print1();
            //explicit interface
            Program p = new Program();
            //((II1)p).show();
            p.show();
            ((II2)p).show();*/

            //Interface parctise with property and method
            /*ImplementationClass im = new ImplementationClass("Rabbi",21);
            im.display();
            im.Name = "Sonjoy";
            im.Age = 22;
            im.display();*/

            //interface practise with two interface,two method but one signature
            //explicit interface member implementation
            /* SampleClass sc = new SampleClass();
             IControl ic = (IControl)sc;
             ISurface b = (ISurface)sc;
             sc.print();
             ic.print();
             b.print();
             Box box = new Box(4.04f,3.03f);
             IDemension demension = (IDemension)box;
             //no error cause i call explicit interface methos use interface object
             Console.WriteLine("length is:{0} ",demension.getLength());
             Console.WriteLine("width is:{0} ", demension.getWidth());
             //error..when i call use clase object..cause this is explicit interface implimentation
            /* Console.WriteLine("length is:{0} ", box.getLength());
             Console.WriteLine("width is:{0} ", box.getWidth());*/

            //Explicitly Implement Members of Two Interfaces
            Box1 b = new Box1(5.5, 6.6);
            // Declare an instance of the English units interface:
            IEnglishDemension eDimensions = (IEnglishDemension)b;

            // Declare an instance of the metric units interface:
            IMetricDemension mDimensions = (IMetricDemension)b;

            // Print dimensions in English units:
            System.Console.WriteLine("Length(in): {0}", eDimensions.length());
            System.Console.WriteLine("Width (in): {0}", eDimensions.width());

            // Print dimensions in metric units:
            System.Console.WriteLine("Length(cm): {0}", mDimensions.length());
            System.Console.WriteLine("Width (cm): {0}", mDimensions.width());

        }
    }
}
