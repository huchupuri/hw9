using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigRacesShow.Classes.Games
{
    internal class PostmanGame : Game
    {
        public override string Name => "Почтальоны";

        protected override void PlayGame()
        {
            Console.WriteLine("игра в почтальона");
        }
    }
}
