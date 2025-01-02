using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz9.Classes.Classes_for_homework_10._1
{
    public class Circle : Point
    {
        public double Radius { get; private set; }

        public Circle(string color, bool visible, int x, int y, double radius) : base(color, visible, x, y)
        {
            Radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Радиус: {Radius}, Площадь: {CalculateArea()}");
        }
    }
}
