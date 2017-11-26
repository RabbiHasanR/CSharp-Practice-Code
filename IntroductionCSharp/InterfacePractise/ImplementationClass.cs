using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePractise
{
    class ImplementationClass:Iinterface
    {
        private string name;
        private int age;
        public string Name
        {
            get { return name; }
            set { this.name = value; }
        }
        public int Age
        {
            get { return age; }
            set { this.age = value; }
        }
        public ImplementationClass(string name,int age)
        {
            this.name = name;
            this.age = age;
        }

        public void display()
        {
            Console.WriteLine("Name:{0} And Age:{1}", Name, Age);
        }
    }
    public interface Iinterface
    {
        string Name
        {
            get;
            set;
        }
        int Age
        {
            get;
            set;
        }
        void display();

    }
}
