using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BigRacesShow.interfaces;

namespace BigRacesShow.Classes
{
    internal class Team
    {
        public string Name { get; }

        public Team(string name)
        {
            Name = name;
        }

        public void PlayGames(List<IGame> games)
        {
            Console.WriteLine($"Команда {Name} начинает игры!\n");
            foreach (Game game in games)
            {
                game.Play();
                Console.WriteLine();
            }
        }
    }
}
