using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassPractise
{
    public abstract class Shape:IShow
    {
        protected double length=100;
        protected double height=150;
        public abstract double area();
        public abstract void show();
        public abstract void incrementLengthAndHeightValue();
        public abstract double Length
        {
            get;
        }
        public abstract double Height
        {
            get;
        }
        
    }
    public interface IShow
    {
        void show();
    }

    public class Rectangel : Shape
    {
        public override void incrementLengthAndHeightValue()
        {
            length++;
            height++;
        }
        public void display()
        {
            Console.WriteLine(length+" "+height);
        }
        public override double Length
        {
            get { return length + 10; }
        }
        public override double Height
        {
            get { return height + 10; }
        }
        public override double area()
        {
            return Length * Height;
        }
        public override void show()
        {
            Console.WriteLine("Length is:{0}",Length);
            Console.WriteLine("Height is:{0}",Height);
            Console.WriteLine("Area is:{0}",area());
        }
    }
}
