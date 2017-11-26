using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePractise
{
    class FulltimeEmployee : Employee 
    {
        public double yearlyRate;
        public FulltimeEmployee(string firstName, string lastName, string email,double yearlyRate):base(firstName,lastName,email)
        {
            this.yearlyRate = yearlyRate;
        }
        
    }
}
