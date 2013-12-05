using System.IO;
using System;
using System.Text.RegularExpressions;
//Write a program that reads a string from the console and prints all different letters in 
//the string along with information how many times each letter is found. 

namespace _21ExtractTheNumberOfContainedLetters
{
    class ExtractTheNumberOfContainedLetters
    {
        static void Main(string[] args)
        {
            string text = "We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            for (int index = 0; index < text.Length; index++)
            {
                if (Char.IsLetter(text[index]))
                {
                    int letterNum = Regex.Matches(text, text[index].ToString()).Count;
                    Console.WriteLine("Letter \"{0}\" is found {1} times.", text[index], letterNum);
                    text = text.Replace(text[index], ' ');
                }
            }
        }
    }
}
