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

        public Employee(string firstName,string lastName,string email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
        }
        public virtual void method()
        {
            Console.WriteLine("base class");
        }
        public void showName()
        {
            Console.WriteLine("Name is:{0} {1}",firstName,lastName);
        }
        
    }
}
