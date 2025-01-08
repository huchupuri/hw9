using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tumak.Interface;

namespace tumak.Classes
{
    class ACipher : ICipher
    {
        public string Encode(string input)
        {
            return ACipherScript(input, 1);
        }

        public string Decode(string input)
        {
            return ACipherScript(input, -1);
        }

        private string ACipherScript(string input, int shift)
        {
            string letters = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
            char[] result = new char[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];
                c = char.ToLower(c);

                int index = letters.IndexOf(c);
                if (index != -1)
                {
                    int shiftedIndex = (index + shift + letters.Length) % letters.Length;
                    char shiftedChar = letters[shiftedIndex];
                    result[i] = char.IsUpper(input[i]) ? char.ToUpper(shiftedChar) : shiftedChar;
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
