using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodPractise
{
    class Program
    {
        static void Main()
        {
            //    //int i = 0;
            //    //Console.WriteLine(i);
            //    //simpleMethod(ref i);
            //    //Console.WriteLine(i);
            //    ///output perameter passing method
            //    //int sum;
            //    //int product;
            //    //outPerameterExample(10,20,out sum,out product);
            //    //Console.WriteLine("Sum={0} and product={1}", sum, product);
            //    ///array perameter passing example
            //    int[] numbers = new int[] { 1,2,3,4};
            //    perameterArray(10,1,2,3,4,5);
            //TestMotorcycle moto = new TestMotorcycle();
            ////moto.AddGas(70);
            //moto.Drive(20, 300);
            //moto.StartEngine();
            //double speed = moto.GetTopSpeed();
            //Console.WriteLine("Speed{0}", speed);

            //Console.WriteLine("Referance type method");
            //ReferanceMethod rf = new ReferanceMethod();
            //rf.value = 10;
            //show(rf);
            //Console.WriteLine(rf.value);
            /*int i = 2;int j = 3;
            Console.WriteLine("Before using referance type{0} and {1}",i,j);
            swapingWithReferanceType(ref i, ref j);
            Console.WriteLine("after using referance type{0} and {1}",i,j);*/
            /*int[] p = new int[] { 9, 8, 7 };
            arrayTypeRefarance(ref p);
            Console.WriteLine("after using reference{0}",p[0]);*/
            
        }

        public static void simpleMethod(ref int j)
        {
            j = 201;
        }
        public static void outPerameterExample(int a, int b, out int sum, out int product)
        {
            sum = a + b;
            product = a * b;
        }
        public static void perameterArray(int x, params int[] numbers)
        {
            Console.WriteLine(x);
            Console.WriteLine("total number of array {0}", numbers.Length);
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
        }
        public static void show(ReferanceMethod rm)
        {
            rm.value = 40;
        }
        public static void swapingWithReferanceType(ref int x,ref int y)
        {
            x = 10; y = 20;
            int temp = x;
            x = y;
            y = temp;
        }
        public static void arrayTypeRefarance(ref int[] Array1)
        {
            Array1[0]= 100;
            Array1 = new int[] { 1, 2, 3, 4 };
            Console.WriteLine("inside the methos first array element is{0}", Array1[0]);
        }
       
    }
}
