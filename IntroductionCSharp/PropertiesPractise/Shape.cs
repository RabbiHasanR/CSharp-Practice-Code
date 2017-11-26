using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesPractise
{
    public abstract class Shape
    {
        private string id;

        public Shape(string id)
        {
            this.id = id;
        }
        public string Id
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }
        public abstract double Area
        {
            get;
        }
        public override string ToString()
        {
            return "Id: " + Id + " " +"Area: "+Area;
        }
    }
}
