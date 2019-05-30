using System;
using LoopExercise;

namespace Exercise_2___Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Amount of numbers between 1-100 which can be divided by three!");
            Console.WriteLine(Loops.DivThree());
            Console.WriteLine("\n");

            Console.WriteLine("Enter a number or enter 'ok' to show sum of the entered numbers!");
            Console.WriteLine(Loops.AskUserSum());
            Console.WriteLine("\n");

            Console.WriteLine("Enter a number to get the factorial of it!");
            Console.WriteLine(Loops.AskUserFact(Console.ReadLine()));
            Console.WriteLine("\n");
            
            Console.WriteLine(Loops.UserFindRandom());
            Console.WriteLine("\n");
            
            Console.WriteLine("Enter something like this '20, 50, 1, 22'");
            Console.WriteLine(Loops.FindMaxInInput(Console.ReadLine()));
        }
    }
}