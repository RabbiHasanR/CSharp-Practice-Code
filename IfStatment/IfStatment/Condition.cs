using System;


namespace IfStatment
{
    class Condition
    {
        int number;
        public void show()
        {
            Console.WriteLine("Enter Number:");
            number = int.Parse( Console.ReadLine());
            if (number == 1)
            {
                Console.WriteLine("This number is one");
            }
            else if (number == 2)
            {
                Console.WriteLine("This number is two");
            }
            else if (number == 3)
            {
                Console.WriteLine("This number is three");
            }
            else
            {
                Console.WriteLine("Other number");
            }
        }
        public void switchStatment()
        {
            number = int.Parse(Console.ReadLine());
            switch (number)
            {
                case 10:
                    Console.WriteLine("this number is {0}",number);
                    break;
                case 20:
                    Console.WriteLine("this number is {0} ",number);
                    break;
                case 30:
                    Console.WriteLine("this number is {0}",number);
                    break;
                default:
                    Console.WriteLine("you number is not 10,20 and 30");
                    break;
            }
        }
        public void switchStatment2()
        {
            Start:
            int totalCoffeCost = 0;
            Console.WriteLine("1-small ,2-medium ,3-larg");
            number = int.Parse(Console.ReadLine());
            switch (number)
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
                    Console.WriteLine("your choice number {0} nis invalid",number);
                    goto Start;
            }
            Decid:
            Console.WriteLine("Do you want to another Coffee.Enter yes or no");
            String userdecision = Console.ReadLine();
            switch (userdecision)
            {
                case "Yes":
                    goto Start;
                case "No":
                    break;
                default:
                    Console.WriteLine("you decision is {0} invalid..please try again");
                    goto Decid;
            }
            Console.WriteLine("Total coffecost is:{0}",totalCoffeCost);
           
        }
    }
}
