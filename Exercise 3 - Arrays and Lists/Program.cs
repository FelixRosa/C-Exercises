using System;

namespace Exercise_3___Arrays_and_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Like a picture, Enter a Name!");
            Console.WriteLine(ProgLogic.FriendsNotification());
            Console.WriteLine("\n");
            
            Console.WriteLine("Enter your name to reverse it!");
            Console.WriteLine(ProgLogic.ReverseYourName());
            Console.WriteLine("\n");

            Console.WriteLine("Enter five unique numbers!");
            Console.WriteLine(ProgLogic.UniqueAndSortedNumbers());
            Console.WriteLine("\n");
            
            Console.WriteLine("Enter five unique numbers or 'Quit' to display the your input!");
            Console.WriteLine(ProgLogic.UniqueNumbersAutomated());
            Console.WriteLine("\n");

            Console.WriteLine("Please enter a List of at least five numbers in the following format '1, 2, 3, 4, 5'");
            Console.WriteLine(ProgLogic.ThreeSmallest());
        }
    }
}