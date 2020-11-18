using System;
using System.Collections.Generic;
using System.Text;

namespace Over_ride_load
{
    class Rectangular:Shape
    {
        public double Side1 { get; private set; }
        public double Side2 { get; private set; }
        
        public Rectangular(double side1)
        {
            Side1 = side1;
            Side2 = side1;
        }
        public Rectangular(double side1,double side2)
        {
            Side1 = side1;
            Side2 = side2;
        }

        public override void Area()
        {
            Console.WriteLine($"The area of this shape/figure  is {Side1 * Side2 : 0.##}");
        }
    }
}
