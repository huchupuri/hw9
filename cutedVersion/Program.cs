using BigRacesShow.interfaces;
using System;
using BigRacesShow.Classes.Games;
using BigRacesShow.Classes;

namespace races
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IGame> games = new List<IGame>
            {
                new SeaGame(),
                new Biathlon(),
                new BeachGame(),
                new MountainGame(),
                new BeachGame(),
                new PostmanGame(),
                new FishingGame(),
            };
            List<Team> teams = new List<Team> 
            {
                new Team("Россия"),
                new Team("Франция"),
                new Team("Китай"),
                new Team("Казахстан"),
            };
            BigRaces bigRaces = new BigRaces(teams, games);
            bigRaces.Start();
            
        }
    }
}