using System;

namespace Over_ride_load
{
    class Program
    {
        static void Main(string[] args)
        {   
            //Contructor Overloading
            Circle c = new Circle(5.5);
            Rectangular s = new Rectangular(5);
            Rectangular r = new Rectangular(5,8);

            //Overriding
            c.Area();
            s.Area();
            r.Area();

            //Function Overloading
            Shape sh = new Shape();
            sh.ShapeExplain();
            sh.ShapeExplain(1);
        }
    }
}
