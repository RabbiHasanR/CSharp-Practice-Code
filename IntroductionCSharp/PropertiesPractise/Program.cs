using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesPractise
{
    class Student
    {
        private int id;
        private string name;
        private int passMark=10;
        private string city;
        private string email;
        //auto implement get and set
        public string City { get; set; }
        public string Email { get; set; }
        //encapsulation with c sharp way
        public int Id
        {
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Id not able to negative number");
                }
                this.id = value;
            }
            get
            {
                return this.id;
            }
        }
        public string Name
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Name can not able to null");
                }
                this.name = value;
            }
            get
            {
                return string.IsNullOrEmpty(name) ? "no name" : this.name;
            }
        }
        public int PassMark
        {
            get
            {
                return this.passMark;
            }
        }
        //encapsulation with getter and setter method
       /* public void setId(int id)
        {
            if (id <= 0)
            {
                throw new Exception("Id not able to negative number");
            }
            this.id = id;
        }
        public int getId()
        {
            return this.id;
        }
        public void setName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new Exception("Name can not able to null");
            }
            this.name = name;
        }
        public string getName()
        {
            //turnary operation
            return string.IsNullOrEmpty(name) ? "no name" : this.name;
            /*if (string.IsNullOrEmpty(name))
            {
                return "no name";
            }
            else
            {
                return this.name;
            }
        }*/
    }
    class Program
    {
        static void Main(string[] args)
        {
            //properties practise
            /*Student s = new Student();
            s.Id = 1;
            s.Name = "Rabbi";
            s.City = "Dhaka";
            s.Email = "jas@";
            Console.WriteLine(s.Id);
            Console.WriteLine(s.Name);
            Console.WriteLine(s.PassMark);
            Console.WriteLine(s.City);
            Console.WriteLine(s.Email);*/
            //properties practise with method overriding
            /*Person p = new Person();
            p.Name = "Rabbi";
            p.Age = 10;
            Console.WriteLine(p);
            p.Name = "Tuhin";
            p.Age = 12;
            Console.WriteLine(p);
            //increment age property
            p.Age += 1;
            p.Name = "Nayem";
            Console.WriteLine(p);*/

            //Abstract properties overriding
            /*Shape[] s =
            {
                new Square(3,"Square#1"),
                new Circle(3.4,"Circle#2"),
                new Rectangel(5.5,6.7,"Rectangel#3")
        };
            foreach(Shape sa in s)
            {
                Console.WriteLine(sa);
            }*/
            //properties use in class
            /*Employee.NumberOfEmployees = 100;
            Employee e = new Employee();
            e.Name = "Rabbi";
            Console.WriteLine("Name: " + e.Name + " Employee Number: " + Employee.Counter);*/

            //This example demonstrates how to access a property in a base class that is hidden by another property that has the same name in a derived class.
            /*Manager m = new Manager();
            m.Name = "Rabbi";
            ((Employee)m).Name = "Faizul";
            Console.WriteLine(m.Name);
            Console.WriteLine(((Employee)m).Name);*/

            //the example of overrid property of abstract base class abstract property
            /*Console.WriteLine("Enter the side:");
            double side = double.Parse(Console.ReadLine());
            Square1 s1 = new Square1(side);
            Cube c = new Cube(side);
            Console.WriteLine("Area of Square: "+s1.Area);
            Console.WriteLine("Area of Cube: " + c.Area);
            Console.WriteLine("Enter the Area:");
            double area = double.Parse(Console.ReadLine());
            s1.Area = area;
            c.Area = area;
            Console.WriteLine("Side of Square: " + s1.side);
            Console.WriteLine("Side of Cube: " + c.side);*/

            ///property use in interface then implements class
            System.Console.Write("Enter number of employees: ");
            Employee1.numberOfEmployee = int.Parse(System.Console.ReadLine());

            Employee1 e1 = new Employee1();
            System.Console.Write("Enter the name of the new employee: ");
            e1.Name = System.Console.ReadLine();

            System.Console.WriteLine("The employee information:");
            System.Console.WriteLine("Employee number: {0}",e1.Counter);
            System.Console.WriteLine("Employee name: {0}", e1.Name);
        }
    }
}
