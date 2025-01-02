using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Failik.Classes
{
    public class BigRaces
    {
        private readonly List<Team> teams;

        public BigRaces()
        {
            teams = new List<Team>();
        }

        public void AddTeam(Team team) => teams.Add(team);

        public void StartRaces()
        {
            foreach (var team in teams)
            {
                team.PlayGames();
            }
        }
    }
}
