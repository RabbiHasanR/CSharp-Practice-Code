using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMethodPractise
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice;
            /* do
             {
                 choice = getchoice();
                 switch (choice)
                 {
                     case "A":
                         Console.WriteLine("You wish to add an address.");
                         break;
                     case "D":
                         Console.WriteLine("You wish to delete an address.");
                         break;
                     case "M":

                         Console.WriteLine("You wish to modify an address.");
                         break;
                     case "V":

                         Console.WriteLine("You wish to view the address list.");
                         break;
                     case "Q":

                         Console.WriteLine("Bye.");
                         break;
                     default:
                         Console.WriteLine("{0} is not a valid choice", choice);
                         break;
                 }
             } while (choice != "Q");*/
            do
            {
                choice = getchoice();
                makeDecision(choice);
            } while (choice != "Q");
        }

        public static string getchoice()
        {
            string myChoice;

            Console.WriteLine("My Address Book\n");

            Console.WriteLine("A - Add New Address");
            Console.WriteLine("D - Delete Address");
            Console.WriteLine("M - Modify Address");
            Console.WriteLine("V - View Addresses");
            Console.WriteLine("Q - Quit\n");

            Console.Write("Choice (A,D,M,V,or Q): ");
            myChoice = Console.ReadLine().ToUpper();
            return myChoice;

        }
        public static void makeDecision(String choice)
        {
            Address addr = new Address();
            switch (choice)
            {
                case "A":
                    addr.name = "Rabbi";
                    addr.address = "dhaka";
                    addAdrress(ref addr);
                    break;
                case "D":
                    addr.name = "Nayem";
                    deletAddress(addr.name);
                    break;
                case "M":
                    addr.name = "Riaz";
                    addr.address = "Noakhali";
                    modifyAddress(out addr);
                    Console.WriteLine("Name is now {0}.", addr.name);
                    break;
                case "V":
                    viewAddresses("Rabbi","Nayem","Riaz");
                    break;
                case "Q":
                    Console.WriteLine("Bye");
                    break;
                default:
                    Console.WriteLine("{0} is not a valid choice", choice);
                    break;
            }
        }
        public static void addAdrress(ref Address addr)
        {
            Console.WriteLine("Name: {0}, Address: {1} added.", addr.name, addr.address);
        }
        public static void deletAddress(String name)
        {
            Console.WriteLine("You wish to delete {0}'s address.", name);
        }
        public static void modifyAddress(out Address addr) 
        {
            addr = new Address();
            addr.name = "Joe";
            addr.address = "C# Station";
        }
        public static void viewAddresses(params string[] names)
        {
            foreach (string name in names)
            {
                Console.WriteLine("Name: {0}", name);
            }
        }
    }
}
