using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePractise
{
    class PartTimeEmployee : Employee 
    {
        public double hourlyRate;
        public PartTimeEmployee(string firstName, string lastName, string email, double hourlyRate) : base(firstName, lastName, email)
        {
            this.hourlyRate = hourlyRate;

        }
        public override void method()
        {
            Console.WriteLine("derived class");
        }
        //hidding main class method use new keyword
        public new void showName()
        {
            //base.showName();//calling base class hidding method use base keyword
            Console.WriteLine("Name is:{0} {1}", firstName, lastName+"Soytan");
        }
        
    }
}
