using System;

namespace Exercise_5___Files
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"/Users/felixrosa/documents/text2.rtf";
            
            Console.WriteLine("Get the Amount of Words in a Text-File!");
            Console.WriteLine(ProgLogic.WordsInTextFile(path));
            Console.WriteLine("\n");

            Console.WriteLine("Get the longest word in a Text-File!");
            Console.WriteLine(ProgLogic.LongestWordInTextFile(path));
            
        }
    }
}