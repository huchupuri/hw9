using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigRacesShow.Classes.Games
{
    internal class Biathlon: Game
    {
        public override string Name => "Биатлон";
        protected override void PlayGame()
        {
            Console.WriteLine("Команды стреляют и бегают");
        }
    }
}
