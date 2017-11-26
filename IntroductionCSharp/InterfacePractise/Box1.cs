using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePractise
{
    //Explicitly Implement Members of Two Interfaces
    class Box1 :IEnglishDemension,IMetricDemension
    {
        public double length;
        public double width;

        public Box1(double length,double width)
        {
            this.length = length;
            this.width = width;
        }
        // Explicitly implement the members of IEnglishDimensions:
        double IEnglishDemension.length()
        {
            return length;
        }
        double IEnglishDemension.width()
        {
            return width;
        }
        // Explicitly implement the members of IMetricDimensions:
        double IMetricDemension.length()
        {
            return length*2.2;
        }
        double IMetricDemension.width()
        {
            return width*2.2;
        }
    }
    //declear the interface
    public interface IEnglishDemension
    {
        double length();
        double width();
    }
    public interface IMetricDemension
    {
        double length();
        double width();
    }

}
