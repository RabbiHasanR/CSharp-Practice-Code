using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructurePractise
{
    public struct Customer
    {
        private int id;
        private string name;

        public string Name { get => name; set => name = value; }
        public int Id { get => id; set => id = value; }
        public Customer(int id,string name)
        {
            this.id = id;
            this.name = name;
        }
        public void printDetail()
        {
            Console.WriteLine("Id:{0} and Name:{1}", this.id, this.name);
        }
    }
    public class TheClass
    {
        public int x;
    }
    public struct TheStruct
    {
        public int x;
    }
    class Program
    {
        static void Main(string[] args)
        {
            //struc example
            /*Customer c = new Customer(1,"Rabbi");
            c.printDetail();
            Customer c1 = new Customer();
            c1.Id = 2;
            c1.Name = "Tuhin";
            c1.printDetail();
            Customer c2 = new Customer
            {
                Id =3,
                Name = "Faizul"
            };
            c2.printDetail();*/

            //This example shows that when a struct is passed to a method,
            //a copy of the struct is passed, but when a class instance is passed,
            //a reference is passed
            TheClass a = new TheClass();
            TheStruct b = new TheStruct();
            a.x = 1;
            b.x = 1;
            classTaker(a);
            structTaker(b);
            Console.WriteLine("Class: "+a.x);
            Console.WriteLine("Struct: " + b.x);

        }
        public static void classTaker(TheClass c)
        {
            c.x = 5;
        }
        public static void structTaker(TheStruct s)
        {
            s.x = 5;
        }
    }
}
