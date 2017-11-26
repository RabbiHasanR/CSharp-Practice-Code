using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileAndDoWhileLoop
{
    class Loop
    {
        public String userChoice=string.Empty;
        public void show()
        {
            do {
                Console.WriteLine("Enter your target");
                int target = int.Parse(Console.ReadLine());
                int start = 0;
                while (start <= target)
                {
                    Console.Write(start + " ");
                    start += 2;
                }
                do
                {
                    Console.WriteLine("do you want to continue..type yes or no");
                    userChoice = Console.ReadLine().ToUpper();
                    if (userChoice != "YES" && userChoice != "NO")
                    {
                        Console.WriteLine("Invalid choice..please choice yes or no");
                    }
                }
                while (userChoice.ToUpper() != "YES" && userChoice.ToUpper() != "NO");
            } while (userChoice=="YES");
        }
        public void show2()
        {

            int totalCoffeCost=0;
            String userdecision = string.Empty;
            do {
                int userChoice;
                do {
                    Console.WriteLine("1-small ,2-medium ,3-larg");
                    userChoice = int.Parse(Console.ReadLine());
                    switch (userChoice)
                    {
                        case 1:
                            totalCoffeCost += 1;
                            break;
                        case 2:
                            totalCoffeCost += 2;
                            break;

                        case 3:
                            totalCoffeCost += 3;
                            break;
                        default:
                            Console.WriteLine("your choice number {0} nis invalid", userChoice);
                            break;
                    }
                } while (userChoice != 1 && userChoice != 2 && userChoice != 3);
                do {
                    Console.WriteLine("Do you want to another Coffee.Enter yes or no");
                    userdecision = Console.ReadLine().ToUpper();
                    if (userdecision != "YES" && userdecision != "NO")
                    {
                        Console.WriteLine("Invalid choice..please type yes or no");
                    }

                } while (userdecision != "YES" && userdecision != "NO");
            } while (userdecision=="YES");
            Console.WriteLine("Thanks for shopping");
            Console.WriteLine("Total coffecost is:{0}", totalCoffeCost);
        }
    }
}
