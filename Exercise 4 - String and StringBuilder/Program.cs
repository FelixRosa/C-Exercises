using System;

namespace Exercise_4___String_and_StringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a sequenze like this: 2-3-5-4-5");
            Console.WriteLine(ProgLogic.ConSeq(Console.ReadLine()));
            Console.WriteLine("\n");
            
            Console.WriteLine("Please enter a sequenze like this: 2-3-5-4-52");
            Console.WriteLine(ProgLogic.DuplicateEntered(Console.ReadLine()));
            Console.WriteLine("\n");
            
            Console.WriteLine("Enter a valid time!");
            Console.WriteLine(ProgLogic.CheckInputTime(Console.ReadLine()));
            Console.WriteLine("\n");
            
            Console.WriteLine("Enter a few words seperated by space!");
            Console.WriteLine(ProgLogic.RebuildInput(Console.ReadLine()));
            Console.WriteLine("\n");
            
            Console.WriteLine("Enter a word, to check the amount of vowels!");
            Console.WriteLine(ProgLogic.CountVowels(Console.ReadLine()));
        }
    }
}