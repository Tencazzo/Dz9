using Dz9.Intefeces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz9.Classes.Classes_for_homework_10._1
{
    public abstract class Figure : IFigure
    {
        protected string Color { get; private set; }
        protected bool Visible { get; private set; }

        protected Figure(string color, bool visible)
        {
            Color = color;
            Visible = visible;
        }

        public void ChangeColor(string color)
        {
            Color = color;
        }

        public bool IsVisible()
        {
            return Visible;
        }

        public abstract void Move(int deltaX, int deltaY);

        public virtual void Print()
        {
            Console.WriteLine($"Цвет: {Color}, Видимость: {Visible}");
        }
    }
}
