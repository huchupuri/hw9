using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigRacesShow.Classes.Games
{
    internal class MountainGame: Game
    {
        public override string Name => "Горка";

        protected override void PlayGame()
        {
            Console.WriteLine("игра в горку");
        }
    }
}
