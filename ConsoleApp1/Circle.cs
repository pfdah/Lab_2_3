using System;
using System.Collections.Generic;
using System.Text;

namespace Over_ride_load
{
    class Circle:Shape
    {
        public double Radius { get; private set; } 
        public Circle(double radius)
        {
            Radius = radius;
        }
        public override void Area()
        {
            Console.WriteLine($"The area of circle is {Math.PI * Radius * Radius : 0.###}");
        }

    }
}
