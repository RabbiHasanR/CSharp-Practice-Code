using System;


namespace DataType
{
    class Rectangle
    {
        double length = 4.5;
        double width = 3.4;
        public double getArea()
        {
            return length * width;
        }
        public void display()
        {

            Console.WriteLine("Length is ={0}", length);
            Console.WriteLine("Width is ={0}", width);
            Console.WriteLine("Area is ={0}", getArea());

        }
    }
}
