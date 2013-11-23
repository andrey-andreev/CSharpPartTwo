using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12findLettersIndexes
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Write a program that creates an array containing all letters from 
             * the alphabet (A-Z). Read a word from the console and print the 
             * index of each of its letters in the array. 
             */

            //initialize and declare the alphabet array
            char[] alphabetArr = new char[26];
            for (int index = 0; index < 26; index++)
            {
                alphabetArr[index] = Convert.ToChar(index + 65);
            }

            //input a word
            Console.Write("Enter a word (use only upper-case letters):");
            string word = Console.ReadLine();

            //
            for (int letterIndex = 0; letterIndex < word.Length; letterIndex++)
            {
                for (int alphabetIndex = 0; alphabetIndex < alphabetArr.Length; alphabetIndex++)
                {
                    if (word[letterIndex] == alphabetArr[alphabetIndex])
                    {
                        Console.WriteLine("Letter {0} has index {1}.", word[letterIndex], alphabetIndex);
                    }

                }
            }
            
        }
    }
}
