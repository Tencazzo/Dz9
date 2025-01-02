using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz9.Classes.Classes_for_homework_10._1
{
    public class Point : Figure
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public Point(string color, bool visible, int x, int y) : base(color, visible)
        {
            X = x;
            Y = y;
        }

        public override void Move(int deltaX, int deltaY)
        {
            X += deltaX;
            Y += deltaY;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Координаты: ({X}, {Y})");
        }
    }
}
