using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz9.Interfeces
{
    public interface IFigure
    {
        void Move(int deltaX, int deltaY);
        void ChangeColor(string color);
        bool IsVisible();
        void Print();
    }
}
