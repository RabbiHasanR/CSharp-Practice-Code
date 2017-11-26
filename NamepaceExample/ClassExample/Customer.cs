using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample
{
    class Customer
    {
        string firstName;
        string lastName;
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
