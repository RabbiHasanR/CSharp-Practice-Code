using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePractise
{
    class Program
    {
        static void Main(string[] args)
        {
            FulltimeEmployee FTE = new FulltimeEmployee("Rabbi","Hasan","jasrabbi50@gmail.com",100000);
           PartTimeEmployee PTE = new PartTimeEmployee("Nazmul","Ahsan","nayem420",400);
            //parentclass pc=new childclass();
            Employee PTE1 = new PartTimeEmployee("Nazmul", "Ahsan", "nayem420@gmail.com", 400);
            //method hiding 
            FTE.showName();
            ((Employee)PTE).showName(); //using overcast calling hiding method in base class
            PTE1.showName();
            ///method overriding 
            PTE.method();
            PTE1.method();
            ((Employee)PTE).method();
            

            B b = new B(5,6);
            //b.show();
            Console.WriteLine(b.area());
            
        }

    }
}
