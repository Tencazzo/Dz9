using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Failik.Interfaces;

namespace Failik.Classes
{
    public static class GameFactory
    {
        public static List<IGame> CreateGames()
        {
            return new List<IGame>
            {
            new BeachGame(),
            new MouseTrapGame(),
            new SeaGame(),
            new FishingGame(),
            new PostmenGame(),
            new SlideGame(),
            new Zagadka()
            };
        }
    }
}
