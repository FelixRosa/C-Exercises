using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_4___String_and_StringBuilder
{
    public class ProgLogic
    {
        //1- Write a program and ask the user to enter a few numbers separated by a hyphen. Work out if the numbers are consecutive.
        //For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", display a message: "Consecutive"; otherwise, display "Not Consecutive".
        public static String ConSeq(String input)
        {
            var cons = "";
            var numbers = input.Split("-");
            var numbersParsed = new List<int>();
            foreach (var number in numbers)
            {
                numbersParsed.Add(Convert.ToInt32(number));
            }
            if(numbersParsed[0]>numbersParsed[numbersParsed.Count-1])
                numbersParsed.Reverse();
            for (var i = 0; i < numbersParsed.Count; i++)
            {
                if (i+1 < numbersParsed.Count && numbersParsed[i+1] == (numbersParsed[i]+1))
                    cons = "Consecutive!";
                else if(i+1 < numbersParsed.Count && numbersParsed[i+1] != (numbersParsed[i]+1))
                    return "Not Consecutive!";
            }
            return cons;
        }

        //2- Write a program and ask the user to enter a few numbers separated by a hyphen.
        //If the user simply presses Enter, without supplying an input, exit immediately;
        //otherwise, check to see if there are duplicates. If so, display "Duplicate" on the console. 
        public static String DuplicateEntered(String input)
        {
            if (String.IsNullOrWhiteSpace(input))
            {
                return null;
            }
            var numbers = input.Split("-");
            var numbersParse = new List<int>();
            foreach (var number in numbers)
            {
                var temp = Convert.ToInt32(number);
                if (numbersParse.Contains(temp))
                    return "Duplicate!";
                else
                    numbersParse.Add(temp);
            }
            return "No Duplicates found!";
        }
        
        //3- Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00).
        //A valid time should be between 00:00 and 23:59. If the time is valid, display "Ok"; otherwise, display "Invalid Time".
        //If the user doesn't provide any values, consider it as invalid time. 
        public static String CheckInputTime(String input)
        {
            if (String.IsNullOrWhiteSpace(input))
                return "Invalid Time";
            try
            {
                var datTime = DateTime.Parse(input);
                return "Valid Time";
            }
            catch (Exception e)
            {
                return "Invalid Time";
            }
        }

        //4- Write a program and ask the user to enter a few words separated by a space.
        //Use the words to create a variable name with PascalCase. For example, if the user types: "number of students", display "NumberOfStudents".
        //Make sure that the program is not dependent on the input. So, if the user types "NUMBER OF STUDENTS", the program should still display "NumberOfStudents". 
        public static String RebuildInput(String input)
        {
            var builder = new StringBuilder();
            var rebuild = input.Split(" ");
            foreach (var word in rebuild)
            {
                var builder2 = new StringBuilder();
                builder2
                    .Append(word.ToLower())
                    .Replace(builder2[0], Char.ToUpper(builder2[0]));
                builder.Append(builder2);
            }
            return String.Format("Rebuilded String: {0}", Convert.ToString(builder));
        }

        //5- Write a program and ask the user to enter an English word. Count the number of vowels (a, e, o, u, i) in the word.
        //So, if the user enters "inadequate", the program should display 6 on the console.
        public static String CountVowels(String input)
        {
            var vowelsCounter = 0;
            var toCharArray = input.ToCharArray();
            var vowels = new List<char>() {'A', 'E', 'I', 'O', 'U', 'a', 'e', 'i', 'o', 'u'};
            foreach (var character in toCharArray)
            {
                if (vowels.Contains(character))
                    vowelsCounter++;
            }
            return String.Format("The entered word has {0} vowels in it", vowelsCounter);
        }
    }
}