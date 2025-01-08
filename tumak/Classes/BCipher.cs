using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tumak.Interface;

namespace tumak.Classes
{
    class BCipher : ICipher
    {
        private const string Alphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";

        public string Encode(string input)
        {
            return Reflect(input);
        }

        public string Decode(string input)
        {
            return Reflect(input);
        }

        private string Reflect(string input)
        {
            char[] result = new char[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];
                bool isUpper = char.IsUpper(c);
                c = char.ToLower(c);

                int index = Alphabet.IndexOf(c);
                if (index != -1)
                {
                    int reflectedIndex = Alphabet.Length - 1 - index;
                    char reflectedChar = Alphabet[reflectedIndex];
                    result[i] = isUpper ? char.ToUpper(reflectedChar) : reflectedChar;
                }
                else
                {
                    result[i] = input[i];
                }
            }
            return new string(result);
        }
    }
}
