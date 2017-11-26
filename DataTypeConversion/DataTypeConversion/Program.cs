using System;


namespace DataTypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            //data type conversion is two type:
            //1.implicit conversion
            //can not implicity convert float to int
            //fractional will be lost.Float is a bigger 
            //data type than int..so there is also a possibility overflow exception
            int a = 100;
            float b = a;
            Console.WriteLine(b);
            //2.explicit conversion
            float d = 1234874.45f; //when float number in big then get overflow exception
            int s = (int)d; //typecast conversion
            Console.WriteLine(s);
            int e = Convert.ToInt32(d); //use convert class 
            Console.WriteLine(e);
            //another data type conversion is parse and tryparse
            string num = "100TF";
            //int convertInt = int.Parse(num);
            int result = 0;
            bool tryconversuccess=int.TryParse(num, out result);//tryParse mathod
            if (tryconversuccess)
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("please enter valid number");
            }
            
        }
    }
}
