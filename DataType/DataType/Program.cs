using System;


namespace DataType
{
    class Program
    {
        static void Main(string[] args)
        {
            ////bolean data type
            //bool a = true;
            //Console.WriteLine("Boolean value= {0}", a);
            ////integer data type
            //sbyte f = 1;
            //Console.WriteLine("Min={0}", sbyte.MinValue);
            //Console.WriteLine("Max={0}", sbyte.MaxValue);
            //byte b = 200;
            //Console.WriteLine("Min={0}", byte.MinValue);
            //Console.WriteLine("Max={0}", byte.MaxValue);
            //short c = -333;
            //Console.WriteLine("Min={0}", short.MinValue);
            //Console.WriteLine("Max={0}", short.MaxValue);
            //ushort d = 333;
            //Console.WriteLine("Min={0}", ushort.MinValue);
            //Console.WriteLine("Max={0}", ushort.MaxValue);
            //int s = 33333;
            //Console.WriteLine("Min={0}", int.MinValue);
            //Console.WriteLine("Max={0}", int.MaxValue);
            //uint r = 4378349;
            //Console.WriteLine("Min={0}", uint.MinValue);
            //Console.WriteLine("Max={0}", uint.MaxValue);
            //long i = 320328094328;
            //Console.WriteLine("Min={0}", long.MinValue);
            //Console.WriteLine("Max={0}", long.MaxValue);
            //ulong l = 98273982379823798;
            //Console.WriteLine("Min={0}", ulong.MinValue);
            //Console.WriteLine("Max={0}", ulong.MaxValue);
            ////floating type
            //double m = 3.8949949;
            //Console.WriteLine("Double value={0}", m);
            ////decimal type
            //decimal n = 3;
            //Console.WriteLine("Decimal value={0}", n);
            ////string type
            /* string name = "Rabbi\nRiaz\nNayem";*///newline \n
                                                    //string n = @"Hello";
                                                    //Console.WriteLine("{0}{1}",name,n);
                                                    //nullable datatypes
                                                    //bool? AreYouMajor = null;
                                                    //if (AreYouMajor == true)
                                                    //{
                                                    //    Console.WriteLine("user are major");
                                                    //}
                                                    //else if (AreYouMajor == false)
                                                    //{
                                                    //    Console.WriteLine("user did not major");
                                                    //}
                                                    //else
                                                    //{
                                                    //    Console.WriteLine("user did not answer the question");
                                                    //}

            //int? TicketsOnSale = 288;
            //int AvailableTickets;
            //if (TicketsOnSale == null)
            //{
            //    AvailableTickets = 0;
            //}
            //else
            //{
            //    AvailableTickets = TicketsOnSale.Value;
            //}
            //Console.WriteLine("AvailableTickets={0}",AvailableTickets);

            //call class in c sharp
            Rectangle r = new Rectangle();
            r.display();


        }
    }
}
