using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tumak.Classes
{
    internal class Point : Figure
    {
        private int X { get; set; }
        private int Y { get; set; }

        public Point(string color, bool isVisible, int x, int y) : base(color, isVisible)
        {
            X = x;
            Y = y;
        }

        /// <summary>
        /// Перемещает точку по горизонтали.
        /// </summary>
        public override void MoveHor(int x)
        {
            X += x;
        }

        /// <summary>
        /// Перемещает точку по вертикали.
        /// </summary>
        public override void MoveVer(int y)
        {
            Y += y;
        }

        /// <summary>
        /// Отображает информацию о точке.
        /// </summary>
        public override void Display()
        {
            Console.WriteLine($"цвет: {Color}, видимость: {IsVisible}, x: {X}, y: {Y}");
        }
    }
}
