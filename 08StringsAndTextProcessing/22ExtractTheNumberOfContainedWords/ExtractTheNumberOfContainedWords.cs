using System.IO;
using System;
using System.Text.RegularExpressions;
//Write a program that reads a string from the console and lists all different words in the 
//string along with information how many times each word is found.
namespace _22ExtractTheNumberOfContainedWords
{
    class ExtractTheNumberOfContainedWords
    {
        static void Main(string[] args)
        {
            string text = "We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            string[] split = text.Split(new Char[] { ' ', ',', '.', ':', '!', '?' });
            for (int index = 0; index < split.Length; index++)
            {
                if (Regex.IsMatch(split[index], @"^\w+$"))
                {
                    int wordNum = Regex.Matches(text, (@"\b" + split[index] + @"\b").ToString()).Count;
                    Console.WriteLine("Word \"{0}\" is found {1} times.", split[index], wordNum);
                    split[index] = String.Empty;
                }
            }
        }
    }
}

// ignorecase !!!!!!!!