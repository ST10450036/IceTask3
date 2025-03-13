using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceTask3
{
    // Rectangle class that extends Shape and implements ICalculateArea
    class Rectangle: Shape, ICalculateArea
    {
        /* The class two properties 
         - two properties
         - constructor
         - calculate area method
        */

        public double recLength { get; set; }
        public double recHeight { get; set; }

        public Rectangle(double length, double height) : base("Rectangle")
        {
            recLength = length;
            recHeight = height;
        }

        public void CalculateArea()
        {
            double rectangleArea = (recHeight * recLength); // Rectangle Area = Height * Length
            Console.WriteLine($"Area: {rectangleArea:F2}\n");
        }
    }
}
