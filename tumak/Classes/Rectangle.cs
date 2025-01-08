using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tumak.Classes
{
    internal class Rectangle: Point
    {
        private double Width { get; set; }
        private double Height { get; set; }

        public Rectangle(double width, double height, string color, bool isVisible, int x, int y)
            : base(color, isVisible, x, y)
        {
            Width = width;
            Height = height;
        }

        /// <summary>
        /// площадь
        /// </summary>
        public double Area()
        {
            return Width * Height;
        }

        /// <summary>
        /// вывод
        /// </summary>
        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Rectangle: Width = {Width}, Height = {Height}, Area = {Area():F2}");
        }
    }
}
