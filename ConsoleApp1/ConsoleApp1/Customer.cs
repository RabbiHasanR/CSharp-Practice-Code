using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Customer
    {
        string firstName;
        string lastName;
        public Customer():this("no firstname provided","no last name provided")
        {

        }

        public Customer(string firstName,string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
        public void printName()
        {
            Console.WriteLine("Full Name:{0} {1}",firstName,lastName);
        }
    }
}
