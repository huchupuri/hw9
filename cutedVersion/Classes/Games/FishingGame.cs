using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigRacesShow.Classes.Games
{
    internal class FishingGame: Game
    {
        public override string Name => "Рыбалка";
        protected override void PlayGame()
        {
            Console.WriteLine("рыбалка");
        }
    }
}
