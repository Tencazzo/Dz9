using Failik.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Failik
{
    public class RaceManager
    {
        private readonly List<Team> teams;

        public RaceManager()
        {
            teams = new List<Team>();
        }

        public void AddTeam(Team team) => teams.Add(team);

        public void StartRaces()
        {
            foreach (var team in teams)
            {
                try
                {
                    team.PlayGames();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка при игре команды {team.Name}: {ex.Message}");
                }
            }
        }
    }
}
