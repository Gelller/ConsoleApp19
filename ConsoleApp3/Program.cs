using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            var aCoder = new ACoder();
            var testEncode = aCoder.Encode("абвГД");
            var testDecode = aCoder.Decode(testEncode);


            var bCoder = new BCoder();
            var testEncode2 = bCoder.Encode("абвягжАБВЯ");
            var testDecode2 = bCoder.Decode(testEncode2);

            Console.WriteLine("ACoder: Encode " + testEncode+ " Decode "+ testDecode);
            Console.WriteLine("BCoder: Encode " + testEncode2 + " Decode " + testDecode2);
            Console.ReadLine();
        }
    }
}
