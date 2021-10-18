using System;

namespace StringReplace
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm asendab kõik 'o' tähed lauses "Hello, World!" tärniga (*)

            string helloW = "Hello, World!";

            helloW = helloW.Replace('o', '*');

            Console.WriteLine(helloW);
        }
    }
}
