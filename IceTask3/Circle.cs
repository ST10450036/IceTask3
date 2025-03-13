using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceTask3
{
    // A circle class that extends Shape and implements ICalculateArea
    class Circle : Shape, ICalculateArea
    {
        /* The class two properties 
         - circle properties
         - constructor
         - calculate area method
        */

        public double circRadius { get; set; }

        public Circle(double radius) : base("Circle")
        {
            circRadius = radius;
        }

        public void CalculateArea()
        {
            double circArea = (Math.PI * Math.Pow(circRadius, 2)); // Circle Area  = Pi * r^2
            Console.WriteLine($"Area: {circArea:F2}\n");
        }
    }
}
