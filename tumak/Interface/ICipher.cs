using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tumak.Interface
{
    internal interface ICipher
    {
        string Encode(string text);
        string Decode(string encodedText);
    }
}
