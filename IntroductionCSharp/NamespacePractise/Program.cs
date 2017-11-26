using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PTA=ProjectA.TeamA;//alias using
using PTB=ProjectA.TeamB;//alias using


namespace NamespacePractise
{
    class Program
    {
        static void Main(string[] args)
        {
            PTA.ClassA.show();
            PTB.ClassA.show();
        }
    }
}
//namespace practise.nested namespace possible
/*namespace ProjectA
{
    namespace TeamA
    {
        class classA
        {
            public static void show()
            {
                Console.WriteLine("This is Team A");
            }
        }
    }
    namespace TeamB
    {
        class classA
        {
            public static void show()
            {
                Console.WriteLine("This is Team B");
            }
        }
    }
}*/
