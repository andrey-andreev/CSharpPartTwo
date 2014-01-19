using System.IO;
using System;
using System.Text.RegularExpressions;
//Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".

namespace _20ExtractsPalindromes
{
    class ExtractsPalindromes
    {
        static void Main(string[] args)
        {
            string text = "lamal sadfgsdf abba sdfgdsf exe sdfgdf";
            string[] words = text.Split(new Char[] { ' ', ',', '.', ':', '!', '?' });
            for (int wordIndex = 0; wordIndex < words.Length; wordIndex++)
            {
                bool isPalindrome = false;
                string currentWord = words[wordIndex];
                for (int ch = 0; ch < currentWord.Length / 2; ch++)
                {
                    char currentChar = currentWord[ch];
                    char mirrorChar = currentWord[currentWord.Length - ch - 1];
                    if (currentChar != mirrorChar)
                    {
                        isPalindrome = false;
                        break;
                    }
                    else
                    {
                        isPalindrome = true;
                    }

                }
                if (isPalindrome)
                {
                    Console.WriteLine(currentWord);
                }
            }
        }
    }
}