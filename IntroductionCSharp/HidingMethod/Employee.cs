using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HidingMethod
{
    class Employee
    {
        private string firstName;
        private string lastName;

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }

        public void printName()
        {
            Console.WriteLine(FirstName+" "+LastName);
        }
    }
}
