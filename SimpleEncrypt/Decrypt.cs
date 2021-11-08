using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleEncrypt
{
    internal class Decrypt
    {
        static char[] alpabet = {' ', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'æ', 'ø', 'å' };
        public string DeCryptText(string text)
        {
            char[] temp = SplitStringToCharArray(text);
            string newText = "";
            for (int i = 0; i < temp.Length; i++)
            {
                for (int j = 0; j < alpabet.Length; j++)
                {
                    if (temp[i] == alpabet[j])
                    {
                        newText += alpabet[j - 1];
                    }
                }
            }
            return newText;
        }
        public char[] SplitStringToCharArray(string text)
        {
            char[] charArray = new char[text.Length];
            for (int i = 0; i < text.Length; i++)
            {
                charArray[i] = text[i];
            }
            return charArray;
        }
    }
}
