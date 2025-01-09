using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BigRacesShow.interfaces;

namespace BigRacesShow.Classes
{
    internal abstract class Game : IGame
    {
        public abstract string Name { get;}
        public void Play()
        {
            Console.WriteLine($"игра {Name} началась");
            PlayGame();
            End();
        }


        protected abstract void PlayGame();

        private void End()
        {
            Console.WriteLine($"игра {Name} завершена");
        }
    }
}
