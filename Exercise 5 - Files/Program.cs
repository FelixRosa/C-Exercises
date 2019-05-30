using System;

namespace Exercise_5___Files
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Get the Amount of Words in a Text-File!");
            Console.WriteLine(ProgLogic.WordsInTextFile());
            Console.WriteLine("\n");

            Console.WriteLine("Get the longest word in a Text-File!");
            Console.WriteLine(ProgLogic.LongestWordInTextFile());
            
        }
    }
}