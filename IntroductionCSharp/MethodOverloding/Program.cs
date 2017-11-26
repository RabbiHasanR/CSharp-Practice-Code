using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloding
{
    public class BaseClass
    {
        public int add(int a,int b)
        {
            return a + b;
        }
        public double add(double a,int b)
        {
            return a + b;
        }
    }
    public class DerrivedClass : BaseClass
    {
        public float add(int a,float b)
        {
            return a + b;
        }
    }

    //another example
    public class Parent
    {
        public virtual void print(int a)
        {
            Console.WriteLine(a);
        }
    }
    public class child : Parent
    {
        public override void print(int a)
        {
            Console.WriteLine(a);
        }
        public  void print(double b)
        {
            Console.WriteLine(b+"Double");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //overload based on the number of perameter
            method1(10,20);
            method1(10, 20, 30);
            //overload based ont data type
            method2(12, 12.4);
            method2(13, 13.3);
            //overload based on defferent return type
            Console.WriteLine(method2(1,2));
            Console.WriteLine(method2(12.2, 13.3));
            Console.WriteLine("Rabbi","Hasan");
            //overload based on same return type but different number of perameter
            Console.WriteLine("2 number of perameter:{0}", method2(12.2f, 13.3f));
            Console.WriteLine("3 number of perameter:{0}", method2(12.2f, 13.3f,14.4f));

            //overload is compile time polymorphism
            DerrivedClass d = new DerrivedClass();
            Console.WriteLine(d.add(1,2));
            Console.WriteLine(d.add(23.3,4));
            Console.WriteLine(d.add(1,3.3f));

            //overload method based on reference and output perameter
            int i = 100;
            int total = 0;
            int product = 0;
            Console.WriteLine(pass(ref i));
            Console.WriteLine(pass(1,2,out total,out product));
            //can not overload params perameter type array
            //int [] array=new int [5];
            //Console.WriteLine(pass(1,2,3,4,5));

            //inheritance overloading..avoid overloading across inheritance boundaries
            child c = new child();
            c.print(10);
            

            //error overloading
            error(1);
            error(5, 4);

            //name argument type overloading
            name(y: 10);
            name(x: 1);
        }
        public static void method1(int a, int b)
        {
            Console.WriteLine(a+b);
        }
        public static void method1(int a,int b,int c)
        {
            Console.WriteLine(a+b+c);
        }
        public static void method2(int a,double b)
        {
            Console.WriteLine(a+" "+b);
        }
        public static void method2(double a,int b)
        {
            Console.WriteLine(a+" "+b);
        }
        public static int method2(int a,int b)
        {
            return a + b;
        }
        public static double method2(double a,double b)
        {
            return a + b;
        }
        public static string method2(string a,string b)
        {
            return (a +" "+ b);
        }
        public static float method2(float a,float b)
        {
            return a + b;
        }
        public static float method2(float a,float b,float c)
        {
            return a + b + c;
        }
        public static int pass(ref int a)
        {
            return a;
        }
        public static int pass(int a,int b,out int sum,out int product)
        {
            sum = a + b;
            product = a * b;
            return sum+product;
        }
        public static void pass(params int []array)
        {
            Console.WriteLine(array.Length);
            foreach(int k in array)
            {
                Console.WriteLine(k);
            }
        }

        ///overloading compile time error..here not print first error
        public static void error(int x,int y = 10)
        {
            Console.WriteLine(x+y);
        }
        public static void error(int x,int y,int z=10)
        {
            Console.WriteLine(x+y+z);
        }

        public static void name(int x)
        {
            Console.WriteLine(x);
        }
        public static void name(double y)
        {
            Console.WriteLine(y);
        }
    }
}
