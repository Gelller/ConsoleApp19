using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public interface ICoder
    {
        string Encode(string input);
        string Decode(string input);
    }
}
