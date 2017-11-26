using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesPractise
{
    public interface IEmployee
    {
        string Name
        {
            get;
            set;
        }
        int Counter
        {
            get;
        }
    }
    class Employee1:IEmployee
    {
        public static int numberOfEmployee;
        private string name;

        public string Name
        {
            get { return name; }
            set { this.name = value; }
        }
        private int counter;
        public int Counter
        {
            get { return counter; }
        }

        public Employee1()
        {
            counter = ++counter + numberOfEmployee;
        }
    }
}
