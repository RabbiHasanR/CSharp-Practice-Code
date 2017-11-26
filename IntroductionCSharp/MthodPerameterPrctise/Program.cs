using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MthodPerameterPrctise
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int j = 1;
            perameterByValue( j);
            Console.WriteLine(j);
            perameterByRefarance(ref j);
            
            Console.WriteLine(j);
            int sum = 0;
            int product = 0;
            outputPerameter(10,20,out sum,out product);
            Console.WriteLine("Sum:{0} And Product:{1}",sum,product);
            int[] number = new int[5];
            number[0] = 100;
            number[1] = 200;
            number[2] = 300;
            number[3] = 400;
            number[4] = 500;
            arrayPerameter(10, number);
            //value perameter
            int y = 200;
            Console.WriteLine("Before calling method value:{0}",y);
            MethodPractise.valuePassing(y);
            Console.WriteLine("After calling method value:{0}",y);
            //reference perameter
            int x = 100;
            Console.WriteLine("Before calling method value:{0}", x);
            MethodPractise.valuePassingByRefference( ref x);
            Console.WriteLine("After calling method value:{0}", x);
            //swaping value by refference
            int t = 2, s = 3;
            System.Console.WriteLine("before swaping i = {0}  j = {1}", t, s);

            MethodPractise.swapingValueWithRefference(ref t, ref s);

            System.Console.WriteLine("After swaping i = {0}  j = {1}", t, s);*/
            int[] array = new int[3] { 100, 200, 300 };
            Console.WriteLine("Before Calling method first array value:{0}", array[0]);
            MethodPractise.refferencePerameterExampleWithArray(ref array);
            Console.WriteLine("After Calling method first array value:{0}", array[0]);
            //Swapping string
            string a = "Rabbi";
            string b = "Nayem";
            Console.WriteLine("Before swaping a={0} and b={1}",a,b);
            MethodPractise.swapingStrihngByRefference(ref a,ref b);
            Console.WriteLine("After swaping a={0} and b={1}", a, b);
            //params perameter
            MethodPractise.paramsPerameterPassingWithArray(1,2,3,4,5);
            MethodPractise.paramsPerameterPassingWithObject(1,'a',"Rabbi");
            int[] array1 = new int[3] { 100, 200, 300 };
            object[] ob = {1,"Rabbi","Shihan" };
            MethodPractise.paramsPerameterPassingWithArray(array1);
            MethodPractise.paramsPerameterPassingWithObject(ob);

        }
        //value perameter
        public static void perameterByValue(int i)
        {
            i = 101;
        }
        //reference perameter
        public static void perameterByRefarance(ref int i)
        {
            i = 101;
        }
        //output perameter
        public static void outputPerameter(int i,int j,out int sum,out int product)
        {
            sum = i + j;
            product = i * j;
        }
        //array perameter using params keyword
        public static void arrayPerameter(int x,params int[] number)
        {
            Console.WriteLine("Array length:{0}",number.Length);
            Console.WriteLine("Number is:{0}",x);

            foreach(int k in number)
            {
                Console.WriteLine(k);
            }
        }
    }
}
