using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePractise
{
    class Box:IDemension
    {
        public float length;
        public float width;

        public Box(float length,float width)
        {
            this.length = length;
            this.width = width;
        }
        // Explicit interface member implementation:
        float IDemension.getLength()
        {
            return length;
        }
        // Explicit interface member implementation:
        float IDemension.getWidth()
        {
            return width;
        }
    }
    public interface IDemension
    {
        float getLength();
        float getWidth();
    }
}
