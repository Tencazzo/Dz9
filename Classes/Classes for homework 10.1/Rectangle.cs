using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz9.Classes.Classes_for_homework_10._1
{
    public class Rectangle : Point
    {
        public double Width { get; private set; }
        public double Height { get; private set; }

        public Rectangle(string color, bool visible, int x, int y, double width, double height) : base(color, visible, x, y)
        {
            Width = width;
            Height = height;
        }

        public double CalculateArea()
        {
            return Width * Height;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Ширина: {Width}, Высота: {Height}, Площадь: {CalculateArea()}");
        }
    }
}
