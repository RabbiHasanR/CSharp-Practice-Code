using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePractise
{
    class Rectangel {
        public double length;
        public double height;
        public Rectangel(double length,double height)
        {
            this.length = length;
            this.height = height;
        }
        public double getArea()
        {
            return length * height;
        }
    }
    class TableTop :Rectangel
    {
        public TableTop(double l,double h):base(l,h)
        {

        }
        public double getCost()
        {
            return getArea() * 70;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            /*FullTimeEmployee ftr = new FullTimeEmployee();
            ftr.printFullName();
            PartTimeEmployee ptr = new PartTimeEmployee();
            ptr.printFullName();*/
            /*TableTop tt = new TableTop(10, 20);
            Console.WriteLine(tt.getCost());*/
            /*Rectangel1 r = new Rectangel1();
            r.Length = 10.11;
            r.Width = 5.5;
            r.display();*/
            /*WorkItem wi = new WorkItem("Title","Description",new TimeSpan(3, 4, 0, 0));
            Console.WriteLine(wi.ToString());
            WorkItem wi1 = new WorkItem("Title", "Description", new TimeSpan(3, 4, 0, 0));
            Console.WriteLine(wi1.ToString());*/
            ChangeRequest change = new ChangeRequest(1,"Change Title","Change Description",new TimeSpan(4,0,0));
            Console.WriteLine(change.ToString());

        }
    }
}
