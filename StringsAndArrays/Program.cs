﻿using System;

namespace StringsAndArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja eesnime
            //programm kuvab kasutaja eesnime pikkust

            Console.WriteLine("Sisesta eesnimi:");
            string firstName = Console.ReadLine();

            int firstNameLength = firstName.Length;
            Console.WriteLine($"Sinu eesnimes on {firstNameLength} sümbolit.");
        }
    }
}
