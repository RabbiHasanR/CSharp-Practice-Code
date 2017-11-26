using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MthodPerameterPrctise
{
    class MethodPractise
    {
        public static void valuePassing(int x)
        {
            x = 5;
            x *= x;
            Console.WriteLine("inside method value is:{0}",x);
        }
        public static void valuePassingByRefference(ref int i)
        {
            i = 3;
            i *= i;
            Console.WriteLine("inside method value is:{0}", i);
        }
        public static void swapingValueWithRefference(ref int i,ref int j)
        {
            int temp = j;
            j = i;
            i = temp;
        }
        //reference perameter example with array
        public static void refferencePerameterExampleWithArray(ref int[] pArray)
        {
            pArray = new int[3] { 1,2,3};
            Console.WriteLine("Inside method first array value:{0}", pArray[0]);
        }
        //swaping two String
        public static void swapingStrihngByRefference(ref string n,ref string m)
        {
            string temp = m;
            m = n;
            n = temp;
        }
        //params perameter passing
        public static void paramsPerameterPassingWithArray(params int[] a)
        {
            for(int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i]+" ");
            }
        }
        public static void paramsPerameterPassingWithObject(params object[] b)
        {
            for(int k = 0; k < b.Length; k++)
            {
                Console.Write(b[k]);
            }
            
        }
        
    }
}
