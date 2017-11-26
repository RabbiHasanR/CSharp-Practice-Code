using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismPractise
{
    public class Employee
    {
        private string firstName;
        private string lastName;

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public virtual void printFullName()
        {
            Console.WriteLine("Full Name:{0} {1}",FirstName,LastName);
        }
    }
    public class FullTimeEmployee : Employee
    {
        public override void printFullName()
        {
            Console.WriteLine("Full Name:{0} {1}", FirstName, LastName+" FTE");
        }
    }
    public class PartTimeEmployee : Employee
    {
        public override void printFullName()
        {
            Console.WriteLine("Full Name:{0} {1}", FirstName, LastName + " PTE");
        }
    }
    public class TemporaryEmployee : Employee
    {
       /* public override void printFullName()
        {
            Console.WriteLine("Full Name:{0} {1}", FirstName, LastName + " TE");
        }*/
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[4];
            employees[0] = new Employee();
            employees[1] = new FullTimeEmployee();
            employees[2] = new PartTimeEmployee();
            employees[3] = new TemporaryEmployee();
            foreach(Employee k in employees)
            {
                k.printFullName();
            }
        }
    }
}
