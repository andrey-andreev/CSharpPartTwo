using System.IO;
using System;
using System.Text.RegularExpressions;
//A dictionary is stored as a sequence of text lines containing words and their explanations. Write a program that enters a word and 
//translates it by using the dictionary. Sample dictionary:
//.NET –platform for applications from Microsoft
//CLR –managed execution environment for .NET
//namespace –hierarchical organization of classes
class Program
{
    static void Main()
    {
        string[] dictionary = {
            ".NET - platform for applications from Microsoft", 
            "CLR - managed execution environment for .NET", 
            "namespace - hierarchical organization of classes"
            };
        string inputWord = ".NET";
        string pattern = @"(.*?)\s-\s(.*)";
        bool isFound = true;
        for (int index = 0; index < dictionary.Length; index++)
        {
            Match m = Regex.Match(dictionary[index], pattern, RegexOptions.IgnoreCase); 
            if (inputWord == m.Groups[1].Value)
            {
                Console.WriteLine("{0} means:\n {1}", m.Groups[1].Value, m.Groups[2].Value);
                isFound = false;
                break;
            }
        }
        if (isFound)
        {
            Console.WriteLine("No match found.");
        }
    }
}