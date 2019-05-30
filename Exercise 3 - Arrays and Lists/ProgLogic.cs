using System;
using System.Collections.Generic;

namespace Exercise_3___Arrays_and_Lists
{
    public class ProgLogic
    {
        //1- When you post a message on Facebook, depending on the number of people who like your post,
        //Facebook displays different information. If no one likes your post, it doesn't display anything.
        //If only one person likes your post, it displays: [Friend's Name] likes your post.
        //If two people like your post, it displays: [Friend 1] and [Friend 2] like your post.
        //If more than two people like your post, it displays: [Friend 1], [Friend 2] and [Number of Other People] others like your post.
        //Write a program and continuously ask the user to enter different names, until the user presses Enter (without supplying a name).
        //Depending on the number of names provided, display a message based on the above pattern. 
        public static String FriendsNotification()
        {
            var notfList = new List<String>();
            while (true)
            {
                var inputUser = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(inputUser))
                    break;
                notfList.Add(inputUser);
            }
            if (notfList.Count == 0)
                return "";
            else if (notfList.Count == 1)
                return String.Format("{0} liked your post!", notfList[0]);
            else if (notfList.Count == 2)
                return String.Format("{0} and {1} liked your post!", notfList[0], notfList[1]);
            else
                return String.Format("{0}, {1} and {2} others liked your post!", notfList[0], notfList[1],(notfList.Count - 2).ToString());
        }
        
        //2- Write a program and ask the user to enter their name.
        //Use an array to reverse the name and then store the result in a new string.
        //Display the reversed name on the console.
        public static String ReverseYourName()
        {
            String returnName = "";
            String userName = Console.ReadLine();
            var charArray = userName.ToCharArray();
            Array.Reverse(charArray);
            foreach (var character in charArray)
            {
                returnName += character.ToString();
            }
            return String.Format("Reversed Name: {0}", returnName);
        }

        //3- Write a program and ask the user to enter 5 numbers. If a number has been previously entered, display an error message and ask the user to re-try.
        //Once the user successfully enters 5 unique numbers, sort them and display the result on the console. 
        public static String UniqueAndSortedNumbers()
        {
            var tries = 0;
            var retStr = "";
            var numbers = new List<int>();
            while (tries < 5)
            {
                Console.WriteLine("Please Enter a Number");
                var input = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Enter a valid number");
                    continue;
                }
                if (numbers.Count == 0)
                {
                    numbers.Add(Convert.ToInt32(input));
                    tries++;
                }else if (numbers.Contains(Convert.ToInt32(input)))
                {
                    Console.WriteLine("Number already entered, please try it again, this time with an unique number!");
                }
                else
                {
                    numbers.Add(Convert.ToInt32(input));
                    tries++;
                }
            }
            numbers.Sort();
            retStr = string.Join(", ", numbers);
            return String.Format("Orderd numbers: {0}",retStr);
        }
        
        //4- Write a program and ask the user to continuously enter a number or type "Quit" to exit.
        //The list of numbers may include duplicates. Display the unique numbers that the user has entered. 
        public static String UniqueNumbersAutomated()
        {
            var returnStr = "";
            var list = new List<int>();
            while (true)
            {
                var input = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Enter a valid number!");
                    continue;
                }
                if (input.ToLower() == "quit")
                {
                    break;
                }
                if (!list.Contains(Convert.ToInt32(input)))
                {
                    list.Add(Convert.ToInt32(input));
                }
            }
            returnStr = String.Join(", ", list);
            return String.Format("Unique numbers: {0}", returnStr);
        }

        //5- Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10).
        //If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try;
        //otherwise, display the 3 smallest numbers in the list. 
        public static String ThreeSmallest()
        {
            var numbers = new List<int>();
            String[] stringSplit = null;
            while (true)
            {
                var input = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Invalid Input, please try again!");
                    continue;
                }
                stringSplit = input.Split(",");
                if (stringSplit.Length < 5)
                {
                    Console.WriteLine("Invalid list, please try again!");
                    continue;
                }
                break;
            }
            foreach (var element in stringSplit)
            {
                numbers.Add(Convert.ToInt32(element));
            }
            numbers.Sort();
            return String.Format("First Three Elements: {0},{1},{2}", numbers[0].ToString(), numbers[1].ToString(), numbers[2].ToString());
        }
    }
}