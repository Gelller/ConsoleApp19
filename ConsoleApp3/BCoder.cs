using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class BCoder : ICoder
    {
        public string Decode(string input)
        {
            char[] code = new char[input.Length];
            for (int i = 0; i < code.Length; i++)
            {
                char c = input[i];
                if (!Char.IsLetter(c))
                    code[i] = c;
                else
                    code[i] = (char)((c + (31 - (c + 16) % 32)) - (c + 16) % 32);
            }
            string result = new string(code);
            return result;
        }

        public string Encode(string input)
        {
            char[] code = new char[input.Length];
            for (int i = 0; i < code.Length; i++)
            {
                char c = input[i];
                if (!Char.IsLetter(c))
                    code[i] = c;
                else 
                    code[i] = (char)((c + (31- (c + 16) % 32)) - (c + 16) % 32); 
            }
            string result = new string(code);
            return result;
        }
    }
}
