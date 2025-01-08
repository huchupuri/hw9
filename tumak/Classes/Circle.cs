using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tumak.Classes
{
    internal class Circle: Point
    {
        private double Radius { get; set; }
        public Circle(double radius, string color, bool isVisible, int x, int y) : base(color, isVisible, x, y)
        {
            Radius = radius;
        }
        public double Area()
        {
            return Math.PI * Radius * Radius;
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine($"радиус {Radius}; площадь: {Area():F2}");
        }
    }
}
