using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePractise
{
    class SampleClass:IControl,ISurface
    {
        //implement method with interface signature when two methos name is same
        void IControl.print()
        {
            Console.WriteLine("IControl interface");
        }
        void ISurface.print()
        {
            Console.WriteLine("ISurface interface");
        }
        //implement ineterface method
        public void print()
        {
            Console.WriteLine("This is print method");
        }
    }
    public interface IControl
    {
        void print();
    }
    public interface ISurface
    {
        void print();
    }

}
