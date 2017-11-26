using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesPractise
{
    class Person
    {
        private string name;
        private int age;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                this.name = value;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                this.age = value;
            }
        }

        public override string ToString()
        {
            return "Name: " + Name + " " + "Age: " + Age;
        }
    }
}
