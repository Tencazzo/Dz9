using Failik.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Failik.Classes
{
    public abstract class Game : IGame
    {
        public abstract void Play();
    }
}
