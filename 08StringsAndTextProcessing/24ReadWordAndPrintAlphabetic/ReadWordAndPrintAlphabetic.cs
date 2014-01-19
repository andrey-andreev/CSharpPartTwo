using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.

namespace _24ReadWordAndPrintAlphabetic
{
    class ReadWordAndPrintAlphabetic
    {
        static void Main(string[] args)
        {
            string text = "Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.";
            string[] unsortedWords = text.Split(new Char[] { ' ' });
            List<string> sortedWords = unsortedWords.ToList();
            sortedWords.Sort();
            foreach (var word in sortedWords)
            {
                Console.WriteLine(word);
            }
        }
    }
}
