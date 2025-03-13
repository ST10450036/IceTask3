using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceTask3
{
    abstract class Shape
    {
        /* abstract shape class containing a virtual display method 
         - contains one property for name
         - constructor
         - virtual method for display 
         */

        public string Name { get; set; }

        public Shape(string name)
        {
            Name = name;
        }

        public virtual void Display()
        {
            Console.WriteLine($"Shape: {Name}");
        }
    }
}
