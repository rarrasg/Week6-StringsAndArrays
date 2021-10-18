using System;

namespace HOLCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab konsoolis, mitu 'h', 'o' ja 'l' tähte on lauses "Hello World!"

            Console.WriteLine("Hello, World!");
            string helloWorld = "Hello, World!".ToLower();

            int hCounter = 0;
            int oCounter = 0;
            int lCounter = 0;

            for(int i = 0; i < helloWorld.Length; i++)
            {
                if(helloWorld[i] == 'h')
                {
                    hCounter++;
                }
                if(helloWorld[i] == 'o')
                {
                    oCounter++;
                }
                if(helloWorld[i] == 'l')
                {
                    lCounter++;
                }
            }

            Console.WriteLine("Lauses 'Hello, World!'");

            if(hCounter != 1)
            {
                Console.Write($"On {hCounter} 'h' tähte, ");
            }
            else
            {
                Console.Write($"On {hCounter} 'h' täht, ");
            }
            if (oCounter != 1)
            {
                Console.Write($" {oCounter} 'o' tähte, ");
            }
            else
            {
                Console.Write($"{oCounter} 'o' täht, ");
            }
            if (lCounter != 1)
            {
                Console.Write($"ja {lCounter} 'l' tähte.");
            }
            else
            {
                Console.Write($"ja {lCounter} 'l' täht.");
            }
        }
    }
}
