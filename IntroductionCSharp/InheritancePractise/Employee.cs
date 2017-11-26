using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePractise
{
    class Employee
    {
        public string firstName;
        public string lastName;
        public string email;
        public Employee()
        {

        }
        public Employee(string firstName,string lastName,string email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            Console.WriteLine("Parent Class constructor");
        }
        public void printFullName()
        {
            Console.WriteLine("Full Name:{0}",firstName+" "+lastName);
        }
    }
}
