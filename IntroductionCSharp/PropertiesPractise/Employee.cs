using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesPractise
{
    public class Employee
    {
        public static int NumberOfEmployees;
        private static int counter;
        private string name;

        // A read-write instance property:
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // A read-only static property:
        public static int Counter
        {
            get { return counter; }
        }

        // A Constructor:
        public Employee()
        {
            // Calculate the employee's number:
            counter = ++counter + NumberOfEmployees;
        }
    }
}
