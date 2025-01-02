using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Failik.Interfaces;

namespace Failik.Classes
{
    public class Team
    {
        public string Name { get; }
        private readonly List<IGame> games;

        public Team(string name)
        {
            Name = name;
            games = new List<IGame>();
        }

        public void AddGame(IGame game) => games.Add(game);

        public IReadOnlyList<IGame> Games => games;

        public void PlayGames()
        {
            Console.WriteLine($"Команда {Name} начинает игры:");
            foreach (var game in games)
            {
                game.Play();
            }
            Console.WriteLine();
        }
    }
}
