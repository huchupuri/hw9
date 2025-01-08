using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BigRacesShow.interfaces;

namespace BigRacesShow.Classes
{
    internal class BigRaces
    {
        private List<Team> teams;
        private List<IGame> games;

        public BigRaces(List<Team> teams, List<IGame> games)
        {
            this.teams = teams;
            this.games = games;
        }

        public void Start()
        {
            Console.WriteLine("Шоу начинается!\n");
            foreach (Team team in teams)
            {
                team.PlayGames(games);
            }
            Console.WriteLine("Шоу завершено!");
        }
    }
}
