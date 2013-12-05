using System;
using System.Text.RegularExpressions;
//Write a program that reads a string from the console and replaces all series of consecutive identical 
//letters with a single one. Example: "aaaaabbbbbcdddeeeedssaa" ? "abcdedsa".
namespace _23RemoveConsecutiveLetters
{
    class RemoveConsecutiveLetters
    {
        static void Main(string[] args)
        {
            string str = "aaaaabbbbbcdddee678eedssaa  dff798";
            string result = Regex.Replace(str, @"(\w)\1+", @"$1"); //ask why !!!!!!!!!!
            Console.WriteLine(result);
        }
    }
}
