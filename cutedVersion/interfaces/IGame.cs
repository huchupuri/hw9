using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigRacesShow.interfaces
{
    internal interface IGame
    {
        string Name { get; }
        void Play();
    }
}
