using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesPractise
{
    class Manager:Employee
    {
        private string name;
        //hiding base class property use new keyword
       public new string Name
        {
            get { return name; }
            set { this.name = value + ",Maneger"; }
        }
    }
}
