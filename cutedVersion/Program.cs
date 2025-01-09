using BigRacesShow.interfaces;
using System;
using BigRacesShow.Classes.Games;
using BigRacesShow.Classes;

namespace races
{
    class Program
    {
//        На шоу Большие гонки собираются 4 команды из разных стран.В команде по 15 человек.
//Всего за одну игру команда проходит по 6 испытаний (6 разных игр). Будет неинтересно,
//если каждый раз игры будут одинаковыми, поэтому каждый раз игры разные.Главный
//организатор, Оливье Ганьян, добавляет новые игры.Необходимо правильно организовать
//классы, чтобы класс передачи «Большие Гонки» не изменял свой функционал, а добавлял
//новый.В консоли необходимо создать 4 команды: Россия, Франция, Китай и Казахстан, и
//чтобы они сыграли в 6 игр.
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