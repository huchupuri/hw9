using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tumak.Interface;

namespace tumak.Classes
{
    internal abstract class Figure: IMovable
    {
        public string Color { get; private set; }
        public bool IsVisible { get; private set; }
        public Figure(string color, bool isVisible)
        {
            Color = color;
            IsVisible = isVisible;
        }

        //реалицация IMovable
        public abstract void MoveHor(int x);
        public abstract void MoveVer(int y);
        /// <summary>
        /// изменение цвета
        /// </summary>
        public void ChangeColor(string color)
        {
            Color = color;
        }
        /// <summary>
        /// изменение видимости
        /// </summary>
        public void ChangeVisibility(bool isVisible)
        {
            IsVisible = isVisible;
        }
        public virtual void Display()
        {
            Console.WriteLine($"цвет: {Color}, видимость: {IsVisible}");
        }
    }
}
