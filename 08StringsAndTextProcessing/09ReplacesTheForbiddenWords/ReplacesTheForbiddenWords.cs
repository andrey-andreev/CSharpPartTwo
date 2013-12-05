using System;
using System.Text;
using System.Text.RegularExpressions;
//We are given a string containing a list of forbidden words and a text containing some of these words. 
//Write a program that replaces the forbidden words with asterisks. Example:
//Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is 
//implemented as a dynamic language in CLR.
//Words: "PHP, CLR, Microsoft"
//The expected result:
//********* announced its next generation *** compiler today. It is based on .NET Framework 4.0 and is 
//implemented as a dynamic language in ***.
namespace _09ReplacesTheForbiddenWords
{
    class ReplacesTheForbiddenWords
    {
        static void Main(string[] args)
        {
            string text = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
            string[] words = { "PHP", "CLR", "Microsoft" };
            Console.WriteLine(CensureWords(text, words));
        }

        private static string CensureWords(string text, string[] words)
        {
            string newText = text;
            for (int index = 0; index < words.Length; index++)
            {
                int count = words[index].Length;
                StringBuilder ast = new StringBuilder().Append('*', count);
                newText = newText.Replace(words[index], ast.ToString());
            }
            return newText;
        }
    }
}
