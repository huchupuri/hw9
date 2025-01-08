using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigRacesShow.Classes.Games
{
    internal class BeachGame: Game
    {
        public override string Name => "Пляж";
        protected override void PlayGame()
        {
            Console.WriteLine("пляжные игры");
        }
    }
}
