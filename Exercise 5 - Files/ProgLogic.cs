using System;
using System.IO;
using System.Linq;

namespace Exercise_5___Files
{
    public class ProgLogic
    {
        //1- Write a program that reads a text file and displays the number of words. 
        public static String WordsInTextFile(String path)
        {
            //var fileText = File.ReadAllText(path);
            var fileText = File.ReadAllText(path);
            var words = fileText.ToString().Split(" ");
            //Only necessray with .rft files - skips the settings
            words = words.Skip(3).ToArray();
            return String.Format("Amount of Words: {0}", words.Length);
        }

        //2- Write a program that reads a text file and displays the longest word in the file. 
        public static String LongestWordInTextFile(String path)
        {
            var fileText = File.ReadAllText(path);
            var parsedFile = fileText.ToString().Split(" ");
            parsedFile = parsedFile.Skip(3).ToArray();
            //Only necessray with .rft files - skips the settings
            var longestWord = parsedFile[0];
            foreach (var word in parsedFile)
            {
                if (word.Length > longestWord.Length)
                    longestWord = word;
            }
            return String.Format("The longest word in the file is: {0}", longestWord);
        }
    }
}