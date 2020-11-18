using System;
using System.Collections.Generic;
using System.Text;

namespace Over_ride_load
{
    class Shape
    {
        public virtual void Area()
        {
            Console.Write("This will print area in child functions");
        }
        public void ShapeExplain()
        {
            Console.WriteLine("Rectangular can be square or rectangle");
        }
        public void ShapeExplain(int l)
        {
            Console.WriteLine("Circle is cirle.");
        }
    }
}
