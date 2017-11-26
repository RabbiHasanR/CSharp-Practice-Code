using System;


namespace ArrayPractise
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] evenNum = new int[3] { 100,200,300};
            string[] name = new string[] { "Rabbi","Nayem","Riaz"};
            //evenNum[0] = 100;
            //evenNum[1] = 200;
            //evenNum[2] = 300;
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine(name[i]);
            }
            
        }
    }
}
