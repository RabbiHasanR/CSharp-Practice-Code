using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPractise
{
    class Customer
    {
        public string firstName;
        public string lastName;
        //default constructor
        public Customer():this("NoFirstNameProvided","NoLastNameProvided")
        {

        }
        //perameterize constructor
        public Customer(string firstName,string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
        public void printFullName()
        {
            Console.WriteLine("Full Name is:{0}",firstName+" "+lastName);
        }
        //destructor
        ~Customer(){
            //this is clean process
        }
    }
}
