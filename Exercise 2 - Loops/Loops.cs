using System;
using System.Collections.Generic;

namespace LoopExercise
{
    public class Loops
        {
            //1- Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder.
            //Display the count on the console.
            public static int DivThree()
            {
                int counter = 0;
                for (int i = 0; i < 100; i++)
                {
                    if (i % 3 == 0)
                    {
                        counter++;
                    }
                }
                return counter;
            }
            //2- Write a program and continuously ask the user to enter a number or "ok" to exit.
            //Calculate the sum of all the previously entered numbers and display it on the console.
            public static String AskUserSum()
            {
                var inputSum = 0;
                while (true)
                {
                    var inputVal = Console.ReadLine();
                    if(String.IsNullOrWhiteSpace(inputVal)){
                        Console.WriteLine("Enter a number or 'Ok'!");
                        continue;
                    }
                    if (inputVal.ToLower() == "ok")
                        break;
                    
                    inputSum = inputSum + Convert.ToInt32(inputVal);
                }

                return String.Format("The sum of the entered numbers is: {0}",inputSum);
            }

            //3- Write a program and ask the user to enter a number.
            //Compute the factorial of the number and print it on the console.
            //For example, if the user enters 5, the program should calculate
            //5 x 4 x 3 x 2 x 1 and display it as 5! = 120.
            public static String AskUserFact(String userInput)
            {
                var uInput = Convert.ToInt32(userInput);
                var inputFact = 1;
                for (var i = 1; i <= uInput; i++)
                {
                    inputFact *= i;
                }
                return String.Format("{0}! = {1}", uInput, inputFact);
            }

            //4- Write a program that picks a random number between 1 and 10.
            //Give the user 4 chances to guess the number.
            //If the user guesses the number, display “You won"; otherwise, display “You lost".
            //(To make sure the program is behaving correctly, you can display the secret number on the console first.) 
            public static String UserFindRandom()
            {
                
                var tries = 0;
                var random = new Random();
                var toFind = random.Next(1, 11);
                Console.WriteLine("Let's play a little game \n A number between 1 and 10 was diced. \n Your Goal: Find it with four trys! \n Good Luck! ^_^");

                while (tries < 4)
                {
                    
                    Console.WriteLine("Enter a number between 1 and 10!");
                    var uInput = Console.ReadLine();
                    if (String.IsNullOrWhiteSpace(uInput))
                    {
                        Console.WriteLine("Invalid Input!");
                        continue;
                    }
                    tries++;
                    var userInput = Convert.ToInt32(uInput);
                    if (userInput == toFind)
                        return "You won.";
                }
                return "You lost.";
            }
            
            //5- Write a program and ask the user to enter a series of numbers separated by comma.
            //Find the maximum of the numbers and display it on the console.
            //For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.
            public static String FindMaxInInput(String userInput)
            {
                var temp = "";
                var stringToNum = new List<int>();
                for(int i = 0; i < userInput.Length; i++)
                {
                    
                    if (char.IsNumber(userInput[i]))
                    {
                        temp += Convert.ToString(userInput[i]);
                    }

                    if (userInput[i] == ',' || i+2 > userInput.Length )
                    {
                        stringToNum.Add(Convert.ToInt32(temp));
                        temp = "";
                    }
                }
                var biggest = 0;
                foreach (var e in stringToNum)
                {
                    if (e > biggest)
                    {
                        biggest = e;
                    }
                }

                return String.Format("The biggest input is {0}", biggest);
            }
            
        }
}