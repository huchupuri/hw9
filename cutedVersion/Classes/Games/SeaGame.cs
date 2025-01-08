using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigRacesShow.Classes.Games
{
    internal class SeaGame: Game
    {
        public override string Name => "Море";
        protected override void PlayGame()
        {
            Console.WriteLine("соревнования в море");
        }
    }
}
