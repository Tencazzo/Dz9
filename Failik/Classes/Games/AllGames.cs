using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Failik.Classes
{
    public class BeachGame : Game
    {
        public override void Play() => Console.WriteLine("Игра: Пляж. Игроки строят песочницу.");
    }

    public class MouseTrapGame : Game
    {
        public override void Play() => Console.WriteLine("Игра: Мышеловка. Игроки ловят мышей.");
    }

    public class SeaGame : Game
    {
        public override void Play() => Console.WriteLine("Игра: Море. Игроки плавают на надувных матрасах.");
    }

    public class FishingGame : Game
    {
        public override void Play() => Console.WriteLine("Игра: Рыбалка. Игроки ловят рыбу.");
    }

    public class PostmenGame : Game
    {
        public override void Play() => Console.WriteLine("Игра: Почтальоны. Игроки раздают письма.");
    }

    public class SlideGame : Game
    {
        public override void Play() => Console.WriteLine("Игра: Горка. Игроки скатываются с горки.");
    }
}
