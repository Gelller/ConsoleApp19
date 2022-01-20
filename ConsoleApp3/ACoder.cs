using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class ACoder : ICoder
    {
        public string Decode(string input)
        {
            char[] ch = new char[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];
                if (!Char.IsLetter(c))
                    ch[i] = c;
                else
                    ch[i] = (char)(c - 1);
            }
            string s = new string(ch);
            return s;
        }

        public string Encode(string input)
        {
            char[] ch = new char[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];
                if (!Char.IsLetter(c))
                    ch[i] = c;
                else  
                    ch[i] = (char)(c + 1);  
            }
            string s = new string(ch);
            return s;    
        }
    }
}
